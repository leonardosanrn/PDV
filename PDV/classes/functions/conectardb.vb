Imports MySql.Data.MySqlClient
Module conectardb

    Public intPergunta As Integer
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim con As String = "server=128.201.75.108;port=3306;username=univer16_root;password=J*6$AHZ9G{2=;database=univer16_pdv"
        Return New MySqlConnection(con)
    End Function
End Module

Module MySqlConnectionModule

    Private connectionString As String = "server=128.201.75.108;port=3306;username=univer16_root;password=J*6$AHZ9G{2=;database=univer16_pdv"

    Public Function GetMySqlConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function


End Module
