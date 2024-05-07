<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
    Inherits MaterialSkin.Controls.MaterialForm

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgvProdutos = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        SuspendLayout()
        ' 
        ' dgvProdutos
        ' 
        dgvProdutos.AutoSizeTable = False
        dgvProdutos.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgvProdutos.BorderStyle = BorderStyle.None
        dgvProdutos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        dgvProdutos.Depth = 0
        dgvProdutos.Dock = DockStyle.Bottom
        dgvProdutos.FullRowSelect = True
        dgvProdutos.GridLines = True
        dgvProdutos.HeaderStyle = ColumnHeaderStyle.Nonclickable
        dgvProdutos.LabelEdit = True
        dgvProdutos.Location = New Point(3, 117)
        dgvProdutos.MinimumSize = New Size(200, 100)
        dgvProdutos.MouseLocation = New Point(-1, -1)
        dgvProdutos.MouseState = MaterialSkin.MouseState.OUT
        dgvProdutos.Name = "dgvProdutos"
        dgvProdutos.OwnerDraw = True
        dgvProdutos.Size = New Size(1012, 607)
        dgvProdutos.TabIndex = 0
        dgvProdutos.UseCompatibleStateImageBehavior = False
        dgvProdutos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nome"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Width = 80
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Protein (g)"
        ColumnHeader4.Width = 100
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel1.Location = New Point(6, 73)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(139, 41)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "Produtos"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(790, 70)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(221, 36)
        MaterialButton1.TabIndex = 2
        MaterialButton1.Text = "Cadastrar novo Produto"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' frmProdutos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 727)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialLabel1)
        Controls.Add(dgvProdutos)
        Name = "frmProdutos"
        Text = "frmProdutos"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Private WithEvents dgvProdutos As MaterialSkin.Controls.MaterialListView
    Private WithEvents ColumnHeader1 As ColumnHeader
    Private WithEvents ColumnHeader2 As ColumnHeader
    Private WithEvents ColumnHeader3 As ColumnHeader
    Private WithEvents ColumnHeader4 As ColumnHeader
End Class
