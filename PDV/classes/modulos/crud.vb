Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class crud

    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
    End Function

    Public Sub AdicionarVenda(idCompra As Integer, idProduto As Integer, quantidade As Integer, valorUnitario As Decimal, dataVenda As Date, statusPagamento As String)
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "INSERT INTO tbl_vendas (id_compra, id_produto, quantidade, valor_unitario, valor_total, data_venda, status_pagamento) VALUES (@IdCompra, @IdProduto, @Quantidade, @ValorUnitario, @ValorTotal, @DataVenda, @StatusPagamento)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                cmd.Parameters.AddWithValue("@IdProduto", idProduto)
                cmd.Parameters.AddWithValue("@Quantidade", quantidade)
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
                cmd.Parameters.AddWithValue("@ValorTotal", quantidade * valorUnitario)
                cmd.Parameters.AddWithValue("@DataVenda", dataVenda)
                cmd.Parameters.AddWithValue("@StatusPagamento", statusPagamento)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function ObterVendas() As DataTable
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "SELECT * FROM tbl_vendas"
            Using cmd As New MySqlCommand(query, conn)
                Dim dt As New DataTable
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
                Return dt
            End Using
        End Using
    End Function
    Public Sub AtualizarVenda(idVenda As Integer, idCompra As Integer, idProduto As Integer, quantidade As Integer, valorUnitario As Decimal, dataVenda As Date, statusPagamento As String)
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "UPDATE tbl_vendas SET id_compra = @IdCompra, id_produto = @IdProduto, quantidade = @Quantidade, valor_unitario = @ValorUnitario, valor_total = @ValorTotal, data_venda = @DataVenda, status_pagamento = @StatusPagamento WHERE id_venda = @IdVenda"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdVenda", idVenda)
                cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                cmd.Parameters.AddWithValue("@IdProduto", idProduto)
                cmd.Parameters.AddWithValue("@Quantidade", quantidade)
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
                cmd.Parameters.AddWithValue("@ValorTotal", quantidade * valorUnitario)
                cmd.Parameters.AddWithValue("@DataVenda", dataVenda)
                cmd.Parameters.AddWithValue("@StatusPagamento", statusPagamento)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub ExcluirVenda(idVenda As Integer)
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "DELETE FROM tbl_vendas WHERE id_venda = @IdVenda"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdVenda", idVenda)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub AdicionarCliente(apelido As String)
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "INSERT INTO tbl_clientes (apelido_cliente) VALUES (@Apelido)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Apelido", apelido)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Adicione métodos para ler, atualizar e excluir clientes conforme necessário




End Class

Public Class CompraActions


    Public Sub AdicionarCompra(idCliente As Integer, valorTotal As Decimal, dataCompra As Date, dataPagamentoEstimada As Date)
        Using conn As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()
            conn.Open()
            Dim query As String = "INSERT INTO tbl_compras (id_cliente, valor_total, data_compra, data_pagamento_estimada) VALUES (@IdCliente, @ValorTotal, @DataCompra, @DataPagamentoEstimada)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdCliente", idCliente)
                cmd.Parameters.AddWithValue("@ValorTotal", valorTotal)
                cmd.Parameters.AddWithValue("@DataCompra", dataCompra)
                cmd.Parameters.AddWithValue("@DataPagamentoEstimada", dataPagamentoEstimada)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Adicione métodos para ler, atualizar e excluir compras conforme necessário
End Class

Public Class ProdutoActions
    Private connectionString As String = "sua_string_de_conexao"

    Public Sub AdicionarProduto(codBarras As String, produto As String, valorUnitario As Decimal, categoria As String)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO tbl_produtos (cod_barras, produto, valorunit, categoria) VALUES (@CodBarras, @Produto, @ValorUnitario, @Categoria)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CodBarras", codBarras)
                cmd.Parameters.AddWithValue("@Produto", produto)
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
                cmd.Parameters.AddWithValue("@Categoria", categoria)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Adicione métodos para ler, atualizar e excluir produtos conforme necessário
End Class

Public Class VendaActions
    Private connectionString As String = "sua_string_de_conexao"

    Public Sub AdicionarVenda(idCompra As Integer, idProduto As Integer, quantidade As Integer, valorUnitario As Decimal, dataVenda As Date, statusPagamento As String)
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "INSERT INTO tbl_vendas (id_compra, id_produto, quantidade, valor_unitario, valor_total, data_venda, status_pagamento) VALUES (@IdCompra, @IdProduto, @Quantidade, @ValorUnitario, @ValorTotal, @DataVenda, @StatusPagamento)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IdCompra", idCompra)
                cmd.Parameters.AddWithValue("@IdProduto", idProduto)
                cmd.Parameters.AddWithValue("@Quantidade", quantidade)
                cmd.Parameters.AddWithValue("@ValorUnitario", valorUnitario)
                cmd.Parameters.AddWithValue("@ValorTotal", quantidade * valorUnitario)
                cmd.Parameters.AddWithValue("@DataVenda", dataVenda)
                cmd.Parameters.AddWithValue("@StatusPagamento", statusPagamento)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Adicione métodos para ler, atualizar e excluir vendas conforme necessário

End Class
