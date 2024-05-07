Imports MaterialSkin
Imports System.Data.SqlClient
Imports System.IO
Imports System.Reflection
Imports MaterialSkin.Controls
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class Form1

    ' Variaveis declaradas
    Dim i As Integer
    Dim dr As MySqlDataReader
    ' Dim lv As MaterialListView = MaterialListView1

    ' conexão com o banco de dados atraves de função
    Public Function GetConnectionMYSQL() As MySqlConnection
        Dim con As String = "server=128.201.75.108;port=3306;username=univer16_root;password=J*6$AHZ9G{2=;database=univer16_pdv"
        Return New MySqlConnection(con)
    End Function

    'Utilização de um método para configurar o ListView, semelhante ao sugerido na primeira parte
    Private Sub ConfigureListView()
        ' With MaterialListView1
        '  .MultiSelect = False
        '   .FullRowSelect = True
        '    .GridLines = False
        '  .View = View.Details
        '        ' Considerar adicionar colunas aqui se não estiverem sendo definidas no designer
        ' End With
    End Sub

    ' Método FillListView extraído de DGV_load para preencher o ListView
    Private Sub FillListView(dt As DataTable)
        ''MaterialListView1.Items.Clear() ' Limpa os itens existentes antes de adicionar novos
        'For Each row As DataRow In dt.Rows
        '    Dim lst As New ListViewItem(If(row("PROID") IsNot Nothing, row("PROID").ToString(), ""))
        '    lst.SubItems.Add(If(row("PRONAME") IsNot Nothing, row("PRONAME").ToString(), ""))
        '    lst.SubItems.Add(If(row("PROGROUP") IsNot Nothing, row("PROGROUP").ToString(), ""))
        '    lst.SubItems.Add(If(row("PRICE") IsNot Nothing, row("PRICE").ToString(), ""))
        '    lst.SubItems.Add(If(row("EXPDATE") IsNot Nothing, row("EXPDATE").date(), ""))
        '    ' lst.SubItems.Add(If(row("STATUS") IsNot Nothing, row("STATUS").ToString(), ""))
        '    ' Ajusta o texto do subitem para "Ativo" ou "Inativo" com base no valor do banco de dados
        '    Dim statusText As String = If(CBool(row("STATUS")), "Ativo", "Inativo")
        '    lst.SubItems.Add(statusText)

        '    ' Repetir para os demais campos
        '    MaterialListView1.Items.Add(lst)
        'Next
    End Sub

    ' Método DGV_load refatorado para usar o método de conexão reutilizável e separação de responsabilidades
    Public Sub DGV_load()
        ConfigureListView() ' Garante que o ListView esteja configurado corretamente
        Dim queryString As String = "SELECT * FROM tbl_curd ORDER BY id ASC"
        Try
            Using conn As MySqlConnection = GetConnectionMYSQL()
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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        DGV_load()

    End Sub
End Class
