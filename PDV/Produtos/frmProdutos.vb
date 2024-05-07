Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class frmProdutos
    Private Sub frmProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SeedListView()
        'instanciamento de skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)


    End Sub
    Private Sub SeedListView()



        ' Define
        Dim data = New String(4)() {
        New String() {"Lollipop", "392", "0.2", "0"},
        New String() {"KitKat", "518", "26.0", "7"},
        New String() {"Ice cream sandwich", "237", "9.0", "4.3"},
        New String() {"Jelly Bean", "375", "0.0", "0.0"},
        New String() {"Honeycomb", "408", "3.2", "6.5"}
    }

        ' Add
        For Each version As String() In data
            Dim item = New ListViewItem(version)
            dgvProdutos.Items.Add(item)
        Next
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        frm_cad_Produtos.Show()
    End Sub

    Private Sub dgvProdutos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgvProdutos.SelectedIndexChanged

    End Sub
End Class