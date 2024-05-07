<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaProdutos
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
        txtProduto = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        dgvProdutos = New MaterialSkin.Controls.MaterialListView()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtProduto
        ' 
        txtProduto.AnimateReadOnly = False
        txtProduto.BorderStyle = BorderStyle.None
        txtProduto.Depth = 0
        txtProduto.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txtProduto.LeadingIcon = Nothing
        txtProduto.Location = New Point(19, 54)
        txtProduto.MaxLength = 50
        txtProduto.MouseState = MaterialSkin.MouseState.OUT
        txtProduto.Multiline = False
        txtProduto.Name = "txtProduto"
        txtProduto.Size = New Size(668, 50)
        txtProduto.TabIndex = 0
        txtProduto.Text = ""
        txtProduto.TrailingIcon = Nothing
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(19, 32)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(493, 19)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "Após selecionar o produto, dê duplo clique no produto para confirmar."
        ' 
        ' dgvProdutos
        ' 
        dgvProdutos.AutoSizeTable = False
        dgvProdutos.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgvProdutos.BorderStyle = BorderStyle.None
        dgvProdutos.Depth = 0
        dgvProdutos.FullRowSelect = True
        dgvProdutos.Location = New Point(19, 110)
        dgvProdutos.MinimumSize = New Size(200, 100)
        dgvProdutos.MouseLocation = New Point(-1, -1)
        dgvProdutos.MouseState = MaterialSkin.MouseState.OUT
        dgvProdutos.Name = "dgvProdutos"
        dgvProdutos.OwnerDraw = True
        dgvProdutos.Size = New Size(668, 345)
        dgvProdutos.TabIndex = 2
        dgvProdutos.UseCompatibleStateImageBehavior = False
        dgvProdutos.View = View.Details
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(685, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(27, 28)
        Button1.TabIndex = 3
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmListaProdutos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(718, 477)
        Controls.Add(Button1)
        Controls.Add(dgvProdutos)
        Controls.Add(MaterialLabel1)
        Controls.Add(txtProduto)
        FormStyle = FormStyles.ActionBar_None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmListaProdutos"
        Padding = New Padding(3, 24, 3, 3)
        StartPosition = FormStartPosition.CenterParent
        Text = "frmListaProdutos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtProduto As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvProdutos As MaterialSkin.Controls.MaterialListView
    Friend WithEvents Button1 As Button
End Class
