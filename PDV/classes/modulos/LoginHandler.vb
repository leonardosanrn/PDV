' Classe LoginHandler.vb
Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginHandler
    Public Function GetMD5Hash(input As String) As String
        ' Cria um objeto MD5
        Using md5Hash As MD5 = MD5.Create()
            ' Converte a string em bytes e calcula o hash
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Cria um StringBuilder para armazenar os bytes em formato hexadecimal
            Dim builder As New StringBuilder()

            ' Loop por cada byte do hash e formata como uma string hexadecimal
            For i As Integer = 0 To data.Length - 1
                builder.Append(data(i).ToString("x2"))
            Next

            ' Retorna o hash MD5 como uma string
            Return builder.ToString()
        End Using
    End Function

    Public Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM tbl_usuario WHERE username = @Username AND senha = @Password"
        Dim connection As MySqlConnection = MySqlConnectionModule.GetMySqlConnection()

        Using cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Password", password)

            Try
                connection.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                Return count > 0
            Catch ex As Exception
                Console.WriteLine("Ocorreu um erro durante a autenticação: " & ex.Message)
                Return False
            Finally
                connection.Close()
            End Try
        End Using
    End Function
End Class



Public Class RegisterForm
    Dim connectionString As String = "server=seu_servidor;port=sua_porta;user=seu_usuario;password=sua_senha;database=seu_banco"

    'Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
    '    Dim username As String = txtUsername.Text
    '    Dim password As String = GetMD5Hash(txtPassword.Text)

    '    If CreateUser(username, password) Then
    '        MessageBox.Show("Usuário registrado com sucesso!")
    '        ' Faça a navegação para a próxima tela ou execute outras operações necessárias após o registro
    '    Else
    '        MessageBox.Show("Ocorreu um erro ao registrar o usuário.")
    '    End If
    'End Sub

    Private Function CreateUser(username As String, password As String) As Boolean
        Dim query As String = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@Password", password)
                conn.Open()
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Private Function GetMD5Hash(input As String) As String
        ' Cria um objeto MD5
        Using md5Hash As MD5 = MD5.Create()
            ' Converte a string em bytes e calcula o hash
            Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

            ' Cria um StringBuilder para armazenar os bytes em formato hexadecimal
            Dim builder As New StringBuilder()

            ' Loop por cada byte do hash e formata como uma string hexadecimal
            For i As Integer = 0 To data.Length - 1
                builder.Append(data(i).ToString("x2"))
            Next

            ' Retorna o hash MD5 como uma string
            Return builder.ToString()
        End Using
    End Function
End Class
