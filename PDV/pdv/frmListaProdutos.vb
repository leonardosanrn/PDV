Imports MaterialSkin
Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient

Public Class frmListaProdutos
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
    End Function

    Private Sub frmListaProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
    Private Sub ConfigureListView()
        With dgvProdutos
            dgvProdutos.Columns.Add("ID")
            dgvProdutos.Columns.Add("Codigo de Barras", 150)
            dgvProdutos.Columns.Add("Produto", 370)
            dgvProdutos.Columns.Add("Valor Unit.", 100)
            .MultiSelect = False
            .FullRowSelect = True
            .GridLines = False
            .View = View.Details
            ' Considerar adicionar colunas aqui se não estiverem sendo definidas no designer
        End With
    End Sub
    Private Sub FillListView(dt As DataTable)
        dgvProdutos.Items.Clear()
        For Each row As DataRow In dt.Rows
            Dim lst As New ListViewItem(If(row("id") IsNot Nothing, row("id").ToString(), ""))
            lst.SubItems.Add(If(row("cod_barras") IsNot Nothing, row("cod_barras").ToString(), ""))
            lst.SubItems.Add(If(row("produto") IsNot Nothing, row("produto").ToString(), ""))
            lst.SubItems.Add(If(row("valorunit") IsNot Nothing, row("valorunit").ToString(), ""))
            dgvProdutos.Items.Add(lst)
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

    Private Sub SearchData()

        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            Try
                conn.Open()

                ' Limpa as linhas existentes no MaterialListView
                dgvProdutos.Items.Clear()

                Dim cmd As New MySqlCommand("SELECT * FROM tbl_produtos WHERE cod_barras LIKE @searchText OR LOWER(produto) LIKE @searchText", conn)
                cmd.Parameters.AddWithValue("@searchText", "%" & txtProduto.Text & "%")

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim item As New ListViewItem(reader("id").ToString())
                        item.SubItems.Add(reader("cod_barras").ToString())
                        item.SubItems.Add(reader("produto").ToString())
                        item.SubItems.Add(reader("valorunit").ToString())

                        dgvProdutos.Items.Add(item)
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub


    Private Sub txtProduto_TextChanged(sender As Object, e As EventArgs) Handles txtProduto.TextChanged
        SearchData()
    End Sub

    Public Sub PassItemsToForm2(selectedItems As List(Of ListViewItem))
        ' Crie uma instância do Formulário 2
        Dim pdv As New pdv()

        ' Adicione os itens ao MaterialListView no Formulário 2
        pdv.AddItems(selectedItems)

        ' Mostre o Formulário 2
        pdv.Show()

    End Sub

    Private Sub dgvProdutos_DoubleClick(sender As Object, e As EventArgs) Handles dgvProdutos.DoubleClick

        Dim pdv As New pdv
        Dim novaLinha As New ListViewItem("id".ToString())
        novaLinha.SubItems.Add(dgvProdutos.SelectedItems(0).SubItems(1).Text) ' Código de Barras
        novaLinha.SubItems.Add(dgvProdutos.SelectedItems(0).SubItems(2).Text) ' Produto
        novaLinha.SubItems.Add(dgvProdutos.SelectedItems(0).SubItems(3).Text) ' Valor de Venda
        pdv.dgvVendaDeProdutos.Items.Add(novaLinha)

        ' Definindo as colunas da outra MaterialListView
        pdv.dgvVendaDeProdutos.Columns.Add("ID")
        pdv.dgvVendaDeProdutos.Columns.Add("Codigo De Barras")
        pdv.dgvVendaDeProdutos.Columns.Add("Produto")
        pdv.dgvVendaDeProdutos.Columns.Add("Valor")

        pdv.Show()
        Me.Dispose()

    End Sub

    Private Sub dgvProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvProdutos.SelectedIndexChanged

    End Sub
End Class
