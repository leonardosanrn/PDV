Imports MaterialSkin
Imports Org.BouncyCastle.Crypto.Paddings
Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
    End Sub
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

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        Dim username As String = tbx_email.Text
        Dim password As String = GetMD5Hash(tbx_senha.Text)

        Dim loginHandler As New LoginHandler()
        If loginHandler.AuthenticateUser(username, password) Then
            MessageBox.Show("Login bem-sucedido!")



            Dashboard.ShowDialog()
            Me.Dispose()
            ' Continue com o que precisar após o login
        Else
            MessageBox.Show("Credenciais inválidas. Tente novamente.")
        End If


    End Sub
End Class