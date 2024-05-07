Imports System
Imports MaterialSkin
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports MaterialSkin.Controls
Imports MySql.Data



Public Class Dashboard
    ' Variaveis declaradas
    Dim i As Integer
    Dim dr As MySqlDataReader
    Dim lv As MaterialListView = MaterialListView1
    ' conexão com o banco de dados atraves de função
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
        Return connection
    End Function
    ' Utilização de um método para configurar o ListView, semelhante ao sugerido na primeira parte
    Private Sub ConfigureListView()
        With MaterialListView1
            .MultiSelect = False
            .FullRowSelect = True
            .GridLines = False
            .View = View.Details
            ' Considerar adicionar colunas aqui se não estiverem sendo definidas no designer
        End With
    End Sub
    ' Método FillListView extraído de DGV_load para preencher o ListView
    Private Sub FillListView(dt As DataTable)
        MaterialListView1.Items.Clear() ' Limpa os itens existentes antes de adicionar novos
        For Each row As DataRow In dt.Rows
            Dim lst As New ListViewItem(If(row("PROID") IsNot Nothing, row("PROID").ToString(), ""))
            lst.SubItems.Add(If(row("PRONAME") IsNot Nothing, row("PRONAME").ToString(), ""))
            lst.SubItems.Add(If(row("PROGROUP") IsNot Nothing, row("PROGROUP").ToString(), ""))
            lst.SubItems.Add(If(row("PRICE") IsNot Nothing, row("PRICE").ToString(), ""))
            lst.SubItems.Add(If(row("EXPDATE") IsNot Nothing, row("EXPDATE").date(), ""))
            ' lst.SubItems.Add(If(row("STATUS") IsNot Nothing, row("STATUS").ToString(), ""))
            ' Ajusta o texto do subitem para "Ativo" ou "Inativo" com base no valor do banco de dados
            Dim statusText As String = If(CBool(row("STATUS")), "Ativo", "Inativo")
            lst.SubItems.Add(statusText)

            ' Repetir para os demais campos
            MaterialListView1.Items.Add(lst)
        Next
    End Sub

    ' Método DGV_load refatorado para usar o método de conexão reutilizável e separação de responsabilidades
    Public Sub DGV_load()
        ConfigureListView() ' Garante que o ListView esteja configurado corretamente
        Dim queryString As String = "SELECT * FROM tbl_curd ORDER BY id ASC"
        Try
            Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
                conn.Open()
                Using cmd As New MySqlCommand(queryString, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim dt As DataTable = New DataTable
                        adapter.Fill(dt)
                        FillListView(dt) ' Refatorado para uma função separada
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        DGV_load()
        ' Ajustes na UI podem ser movidos para um método separado se a lógica for mais complexa
        btn_salvar.Enabled = False
        btn_delete.Enabled = False
        btn_limpar.Enabled = False
    End Sub

    Private Sub SearchData()
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            Try
                conn.Open()

                ' Limpa as linhas existentes no MaterialListView
                MaterialListView1.Items.Clear()

                Dim cmd As New MySqlCommand("SELECT * FROM tbl_curd WHERE PROID LIKE @searchText OR LOWER(PRONAME) LIKE @searchText", conn)
                cmd.Parameters.AddWithValue("@searchText", "%" & txt_search.Text & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("PROID").ToString())
                        item.SubItems.Add(reader("PRONAME").ToString())
                        item.SubItems.Add(reader("PROGROUP").ToString())
                        item.SubItems.Add(reader("PRICE").ToString())
                        item.SubItems.Add(reader("EXPDATE").ToString())
                        item.SubItems.Add(Format(CBool(reader("STATUS"))))



                        MaterialListView1.Items.Add(item)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    ' Método clear refatorado para simplificação
    Public Sub clear()
        txt_proCode.Clear()
        txt_ProName.Clear()
        txt_price.Clear()
        txt_proGroup.Clear() ' Modificado para Clear() para consistência
        dtp_ExpDate.Clear()
        Check_Status.Checked = False
        txt_proCode.ReadOnly = False
    End Sub

    Public Sub save()
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            Try
                conn.Open()

                Dim insertCmd As New MySqlCommand("INSERT INTO `tbl_curd`(`PROID`, `PRONAME`, `PROGROUP`, `PRICE`, `EXPDATE`, `STATUS`) VALUES (@PROID,@PRONAME,@PROGROUP,@PRICE,@EXPDATE,@STATUS)", conn)
                insertCmd.Parameters.AddWithValue("@PROID", txt_proCode.Text)
                insertCmd.Parameters.AddWithValue("@PRONAME", txt_ProName.Text)
                insertCmd.Parameters.AddWithValue("@PROGROUP", txt_proGroup.Text)
                insertCmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
                insertCmd.Parameters.AddWithValue("@EXPDATE", CDate(dtp_ExpDate.Text))
                insertCmd.Parameters.AddWithValue("@STATUS", Check_Status.Checked)

                Dim i As Integer = insertCmd.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Produto Cadastrado!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Erro ao salvar!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try

            ' Após a operação de inserção, recarregar os dados
            'clear() - Descomente e implemente clear se necessário para limpar os campos de entrada
            MaterialListView1.Columns.Clear()
            DGV_load() ' Certifique-se de que DGV_load recarrega os dados no ListView ou DataGridView
        End Using
    End Sub


    Public Sub ConsultSave()
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            Try
                conn.Open()
                ' Primeiro, verificar se o PROID já existe
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM tbl_curd WHERE PROID = @PROID", conn)
                checkCmd.Parameters.AddWithValue("@PROID", txt_proCode.Text)
                Dim result As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If result > 0 Then
                    MessageBox.Show("PROID já existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' PROID não existe, então insere o novo registro
                    Dim insertCmd As New MySqlCommand("INSERT INTO `tbl_curd`(`PROID`, `PRONAME`, `PROGROUP`, `PRICE`, `EXPDATE`, `STATUS`) VALUES (@PROID,@PRONAME,@PROGROUP,@PRICE,@EXPDATE,@STATUS)", conn)
                    insertCmd.Parameters.AddWithValue("@PROID", txt_proCode.Text)
                    insertCmd.Parameters.AddWithValue("@PRONAME", txt_ProName.Text)
                    insertCmd.Parameters.AddWithValue("@PROGROUP", txt_proGroup.Text)
                    insertCmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
                    insertCmd.Parameters.AddWithValue("@EXPDATE", CDate(dtp_ExpDate.Text))
                    insertCmd.Parameters.AddWithValue("@STATUS", Check_Status.Checked)

                    Dim i As Integer = insertCmd.ExecuteNonQuery()
                    If i > 0 Then
                        MessageBox.Show("Produto Cadastrado!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Erro ao salvar !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            ' Após a operação de inserção, recarregar os dados
            'clear() - Descomente e implemente clear se necessário para limpar os campos de entrada
            MaterialListView1.Columns.Clear()
            DGV_load() ' Certifique-se de que DGV_load recarrega os dados no ListView ou DataGridView
        End Using
    End Sub

    Public Sub DeleteRecord()
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            If MessageBox.Show("Are You Sure Delete This Record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM `tbl_curd` WHERE `PROID` = @PROID", conn)
                    cmd.Parameters.AddWithValue("@PROID", txt_proCode.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record Deleted Successfully!", "CURD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No records deleted. Record not found or deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                ' O usuário clicou em "No" ou fechou a caixa de diálogo
            End If
        End Using
    End Sub
    Private Sub MaterialTextBox1_TabIndexChanged(sender As Object, e As EventArgs) Handles txt_search.TabIndexChanged

    End Sub

    Private Sub MaterialListView1_DoubleClick(sender As Object, e As EventArgs) Handles MaterialListView1.DoubleClick
        btn_salvar.Enabled = True
        btn_delete.Enabled = True
        btn_limpar.Enabled = True
        btn_criar.Visible = False

        Dim lv As MaterialListView = MaterialListView1

        If lv.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lv.SelectedItems(0)

            ' Garante que há um número suficiente de subitens antes de tentar acessá-los
            If selectedItem.SubItems.Count > 5 Then
                txt_proCode.Text = selectedItem.SubItems(0).Text
                txt_ProName.Text = selectedItem.SubItems(1).Text
                txt_proGroup.Text = selectedItem.SubItems(2).Text
                txt_price.Text = selectedItem.SubItems(3).Text
                dtp_ExpDate.Text = selectedItem.SubItems(4).Text
                Check_Status.Checked = selectedItem.SubItems(5).Text.Equals("True", StringComparison.OrdinalIgnoreCase)
            Else
                MessageBox.Show("O item selecionado não contém dados suficientes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Check_Status_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Status.CheckedChanged
        ' Verifica o estado do CheckBox e ajusta o texto conforme necessário
        If Check_Status.Checked Then
            Check_Status.Text = "Ativo"
        Else
            Check_Status.Text = "Inativo"
        End If

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        SearchData()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        save()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        DeleteRecord()
    End Sub

    Private Sub btn_limpar_Click(sender As Object, e As EventArgs) Handles btn_limpar.Click
        clear()
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        ConsultSave()
    End Sub

    Private Sub btn_cadshow_Click(sender As Object, e As EventArgs) Handles btn_cadshow.Click
        frm_cad_Produtos.ShowDialog()
    End Sub

    Private Sub SwitchTheme_CheckedChanged(sender As Object, e As EventArgs) Handles SwitchTheme.CheckedChanged

        If SwitchTheme.Checked Then
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        Else
            SkinManager.Theme = MaterialSkinManager.Themes.DARK
        End If

    End Sub

    Private Sub cbxOrange_CheckedChanged(sender As Object, e As EventArgs) Handles cbxOrange.CheckedChanged
        If cbxOrange.Checked Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE)
        End If

    End Sub

    Private Sub cbxGreen_CheckedChanged(sender As Object, e As EventArgs) Handles cbxGreen.CheckedChanged
        If cbxOrange.Checked Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE)
        End If
    End Sub

    Private Sub cbxAzul_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAzul.CheckedChanged
        If cbxOrange.Checked Then
            SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHoras.Text = DateTime.Now
    End Sub

    Private Sub lblHoras_Click(sender As Object, e As EventArgs) Handles lblHoras.Click

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        pdv.ShowDialog()
    End Sub


End Class