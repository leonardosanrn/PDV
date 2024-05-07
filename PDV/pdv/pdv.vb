Imports MaterialSkin
Imports MaterialSkin.Controls
Imports MySql.Data.MySqlClient

Public Class pdv
    Private Sub pdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        txt_ean.Focus()
    End Sub

    ' conexão com o banco de dados atraves de função
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
        Return connection
    End Function

    ' Utilização de um método para configurar o ListView, semelhante ao sugerido na primeira parte
    'Private Sub ConfigureListView()
    '    With dgvVendaDeProdutos
    '        dgvVendaDeProdutos.Columns.Add("Codigo de Barras", 150)
    '        dgvVendaDeProdutos.Columns.Add("Produto", 370)
    '        dgvVendaDeProdutos.Columns.Add("Valor Unit.", 100)
    '        dgvVendaDeProdutos.Columns.Add("Quantidade", 120)
    '        dgvVendaDeProdutos.Columns.Add("Valor Total", 120)

    '        .MultiSelect = False
    '        .FullRowSelect = True
    '        .GridLines = False
    '        .View = View.Details
    '        ' Considerar adicionar colunas aqui se não estiverem sendo definidas no designer
    '    End With
    'End Sub
    ' Método FillListView extraído de DGV_load para preencher o ListView
    'Public Sub FillListView(dt As DataTable)
    '    dgvVendaDeProdutos.Items.Clear() ' Limpa os itens existentes antes de adicionar novos
    '    For Each row As DataRow In dt.Rows
    '        Dim lst As New ListViewItem(If(row("cod_barras") IsNot Nothing, row("cod_barras").ToString(), ""))
    '        lst.SubItems.Add(If(row("produto") IsNot Nothing, row("produto").ToString(), ""))
    '        lst.SubItems.Add(If(row("valorunit") IsNot Nothing, row("valorunit").ToString(), ""))
    '        'lst.SubItems.Add(If(row("categoria") IsNot Nothing, row("categoria").ToString(), ""))
    '        'lst.SubItems.Add(If(row("EXPDATE") IsNot Nothing, row("EXPDATE").date(), ""))
    '        ' lst.SubItems.Add(If(row("STATUS") IsNot Nothing, row("STATUS").ToString(), ""))
    '        ' Ajusta o texto do subitem para "Ativo" ou "Inativo" com base no valor do banco de dados
    '        'Dim statusText As String = If(CBool(row("STATUS")), "Ativo", "Inativo")
    '        'lst.SubItems.Add(statusText)

    '        ' Repetir para os demais campos
    '        dgvVendaDeProdutos.Items.Add(lst)
    '    Next
    'End Sub

    ' Método DGV_load refatorado para usar o método de conexão reutilizável e separação de responsabilidades
    'Public Sub DGV_load()
    '    ConfigureListView() ' Garante que o ListView esteja configurado corretamente
    '    Dim queryString As String = "SELECT * FROM tbl_produtos ORDER BY id ASC"
    '    Try
    '        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
    '            conn.Open()
    '            Using cmd As New MySqlCommand(queryString, conn)
    '                Using adapter As New MySqlDataAdapter(cmd)
    '                    Dim dt As DataTable = New DataTable
    '                    adapter.Fill(dt)
    '                    FillListView(dt) ' Refatorado para uma função separada
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub SearchData()

    '    Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
    '        Try
    '            conn.Open()

    '            ' Limpa as linhas existentes no MaterialListView
    '            dgvVendaDeProdutos.Items.Clear()

    '            Dim cmd As New MySqlCommand("SELECT * FROM tbl_produtos WHERE cod_barras LIKE @searchText OR LOWER(produto) LIKE @searchText", conn)
    '            cmd.Parameters.AddWithValue("@searchText", "%" & txt_ean.Text & "%")

    '            Using reader As MySqlDataReader = cmd.ExecuteReader()
    '                While reader.Read()
    '                    Dim item As New ListViewItem(reader("id").ToString())
    '                    item.SubItems.Add(reader("cod_barras").ToString())
    '                    item.SubItems.Add(reader("produto").ToString())
    '                    item.SubItems.Add(reader("valorunit").ToString())
    '                    item.SubItems.Add(reader("categoria").ToString())




    '                    dgvVendaDeProdutos.Items.Add(item)
    '                End While
    '            End Using
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End Using
    'End Sub

    Public Sub AddItems(items As List(Of ListViewItem))
        ' Adicione os itens ao MaterialListView
        For Each item As ListViewItem In items
            dgvVendaDeProdutos.Items.Add(item.Clone()) ' Clone() é usado para copiar o item, para que ele possa ser adicionado ao novo MaterialListView
        Next
    End Sub

    Private Sub txt_ean_TextChanged(sender As Object, e As EventArgs) Handles txt_ean.TextChanged

    End Sub

    Private Sub txtProdutoVenda_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_ean.KeyUp
        frmListaProdutos.txtProduto.Text = txt_ean.Text

        'Para posicionar o cursor no final do conteúdo de um controle TextBox, 
        'chame o método Select e especifique a posição de início de seleção para o 
        'comprimento do conteúdo texto, e o comprimento da seleção para 0
        frmListaProdutos.txtProduto.Select(frmListaProdutos.txtProduto.Text.Length, 0)
        frmListaProdutos.ShowDialog()
        'Dim _valorUnitario As Double
        'For i As Integer = 0 To dgvVendaDeProdutos.Items - 1
        '    _valorUnitario = _valorUnitario + dgvVendaDeProdutos.Items(i).Cells("valor_unitario").Value
        'Next
        '  lblTotalPagar.Text = FormatCurrency(_valorUnitario)
    End Sub

    Private Sub txt_ean_Click(sender As Object, e As EventArgs) Handles txt_ean.Click

    End Sub
End Class

'Public Class VendaActions
'    Private connectionString As String = "sua_string_de_conexao"

'    Public Sub RealizarVenda(idCaixa As Integer, idProduto As Integer, quantidade As Integer, valorUnitario As Decimal, dataVenda As Date, statusPagamento As String, formaPagamento As String, taxaPagamento As Decimal)
'        Using conn As New MySqlConnection(connectionString)
'            conn.Open()

'            ' Verificar se o caixa está aberto
'            If Not CaixaEstaAberto(idCaixa) Then
'                MessageBox.Show("O caixa está fechado. Abra o caixa antes de realizar uma venda.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'                Return
'            End If

'            ' Registrar a venda na tabela tbl_vendas
'            Dim idVenda As Integer
'            Using cmdVenda As New MySqlCommand("INSERT INTO tbl_vendas (id_caixa, id_produto, quantidade, valor_unitario, valor_total, data_venda, status_pagamento, forma_pagamento, taxa_pagamento) VALUES (@IdCaixa, @IdProduto, @Quantidade, @ValorUnitario, @ValorTotal, @DataVenda, @StatusPagamento, @FormaPagamento, @TaxaPagamento)", conn)
'                cmdVenda.Parameters.AddWithValue("@IdCaixa", idCaixa)
'                cmdVenda.Parameters.AddWithValue("@IdProduto", idProduto)
'                cmdVenda.Parameters.AddWithValue("@Quantidade", quantidade)
'                cmdVenda.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
'                cmdVenda.Parameters.AddWithValue("@ValorTotal", quantidade * valorUnitario)
'                cmdVenda.Parameters.AddWithValue("@DataVenda", dataVenda)
'                cmdVenda.Parameters.AddWithValue("@StatusPagamento", statusPagamento)
'                cmdVenda.Parameters.AddWithValue("@FormaPagamento", formaPagamento)
'                cmdVenda.Parameters.AddWithValue("@TaxaPagamento", taxaPagamento)
'                cmdVenda.ExecuteNonQuery()

'                ' Obter o ID da venda recém-inserida
'                idVenda = CInt(cmdVenda.LastInsertedId)
'            End Using

'            ' Associar a venda ao estoque na tabela tbl_estoque
'            Using cmdEstoque As New MySqlCommand("UPDATE tbl_estoque SET id_venda = @IdVenda WHERE id_produto = @IdProduto AND em_estoque > 0 LIMIT @Quantidade", conn)
'                cmdEstoque.Parameters.AddWithValue("@IdVenda", idVenda)
'                cmdEstoque.Parameters.AddWithValue("@IdProduto", idProduto)
'                cmdEstoque.Parameters.AddWithValue("@Quantidade", quantidade)
'                cmdEstoque.ExecuteNonQuery()
'            End Using
'        End Using
'    End Sub

'    Private Function CaixaEstaAberto(idCaixa As Integer) As Boolean
'        ' Implemente a lógica para verificar se o caixa está aberto
'        ' Retorne True se estiver aberto, False se estiver fechado
'        Return True ' Exemplo: sempre retorna True para fins de demonstração
'    End Function
'End Class
