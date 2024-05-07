Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient

Public Class frm_cad_Produtos

    ' conexão com o banco de dados atraves de função
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
    End Function
    ' Utilização de um método para configurar o ListView, semelhante ao sugerido na primeira parte
    Private Sub ConfigureListView()
        With dgv_produtos
            .MultiSelect = False
            .FullRowSelect = True
            .GridLines = False
            .View = View.Details
            ' Considerar adicionar colunas aqui se não estiverem sendo definidas no designer
        End With
    End Sub
    ' Método FillListView extraído de DGV_load para preencher o ListView
    Private Sub FillListView(dt As DataTable)
        dgv_produtos.Items.Clear() ' Limpa os itens existentes antes de adicionar novos
        For Each row As DataRow In dt.Rows
            Dim lst As New ListViewItem(If(row("cod_barras") IsNot Nothing, row("cod_barras").ToString(), ""))
            lst.SubItems.Add(If(row("produto") IsNot Nothing, row("Produto").ToString(), ""))
            lst.SubItems.Add(If(row("valorunit") IsNot Nothing, row("valorunit").ToString(), ""))
            lst.SubItems.Add(If(row("categoria") IsNot Nothing, row("categoria").ToString(), ""))
            'lst.SubItems.Add(If(row("EXPDATE") IsNot Nothing, row("EXPDATE").date(), ""))
            ' lst.SubItems.Add(If(row("STATUS") IsNot Nothing, row("STATUS").ToString(), ""))
            ' Ajusta o texto do subitem para "Ativo" ou "Inativo" com base no valor do banco de dados
            'Dim statusText As String = If(CBool(row("STATUS")), "Ativo", "Inativo")
            'lst.SubItems.Add(statusText)

            ' Repetir para os demais campos
            dgv_produtos.Items.Add(lst)
        Next
    End Sub

    ' Método DGV_load refatorado para usar o método de conexão reutilizável e separação de responsabilidades
    Public Sub DGV_load()
        ConfigureListView() ' Garante que o ListView esteja configurado corretamente
        Dim queryString As String = "SELECT * FROM tbl_produtos ORDER BY id ASC"
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
            dgv_produtos.Columns.Clear()
            DGV_load() ' Certifique-se de que DGV_load recarrega os dados no ListView ou DataGridView
        End Using
    End Sub


    Private Sub MaterialFloatingActionButton1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub frm_cad_Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        ConsultSave()
    End Sub

    Private Sub txt_price_TextChanged(sender As Object, e As EventArgs) Handles txt_price.TextChanged

    End Sub

    Private Sub dgv_produtos_DoubleClick(sender As Object, e As EventArgs) Handles dgv_produtos.DoubleClick
        ' btn_salvar.Enabled = True
        ' btn_delete.Enabled = True
        'btn_limpar.Enabled = True
        'btn_criar.Visible = False

        Dim lv As MaterialListView = dgv_produtos

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

End Class