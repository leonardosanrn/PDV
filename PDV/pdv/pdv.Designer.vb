<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pdv
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
        txt_ean = New MaterialSkin.Controls.MaterialTextBox2()
        dgvVendaDeProdutos = New MaterialSkin.Controls.MaterialListView()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        lblTotalPagar = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        MaterialTextBox2 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCheckbox1 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialCheckbox2 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialCheckbox3 = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txt_ean
        ' 
        txt_ean.Anchor = AnchorStyles.Top
        txt_ean.AnimateReadOnly = False
        txt_ean.BackgroundImageLayout = ImageLayout.None
        txt_ean.CharacterCasing = CharacterCasing.Normal
        txt_ean.Depth = 0
        txt_ean.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_ean.HideSelection = True
        txt_ean.LeadingIcon = Nothing
        txt_ean.Location = New Point(34, 56)
        txt_ean.MaxLength = 32767
        txt_ean.MouseState = MaterialSkin.MouseState.OUT
        txt_ean.Name = "txt_ean"
        txt_ean.PasswordChar = ChrW(0)
        txt_ean.PrefixSuffixText = Nothing
        txt_ean.ReadOnly = False
        txt_ean.RightToLeft = RightToLeft.No
        txt_ean.SelectedText = ""
        txt_ean.SelectionLength = 0
        txt_ean.SelectionStart = 0
        txt_ean.ShortcutsEnabled = True
        txt_ean.Size = New Size(1304, 48)
        txt_ean.TabIndex = 0
        txt_ean.TabStop = False
        txt_ean.Text = "Produto / EAN"
        txt_ean.TextAlign = HorizontalAlignment.Left
        txt_ean.TrailingIcon = Nothing
        txt_ean.UseSystemPasswordChar = False
        ' 
        ' dgvVendaDeProdutos
        ' 
        dgvVendaDeProdutos.Anchor = AnchorStyles.Top
        dgvVendaDeProdutos.AutoSizeTable = False
        dgvVendaDeProdutos.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgvVendaDeProdutos.BorderStyle = BorderStyle.None
        dgvVendaDeProdutos.Depth = 0
        dgvVendaDeProdutos.FullRowSelect = True
        dgvVendaDeProdutos.Location = New Point(34, 124)
        dgvVendaDeProdutos.MinimumSize = New Size(200, 100)
        dgvVendaDeProdutos.MouseLocation = New Point(-1, -1)
        dgvVendaDeProdutos.MouseState = MaterialSkin.MouseState.OUT
        dgvVendaDeProdutos.Name = "dgvVendaDeProdutos"
        dgvVendaDeProdutos.OwnerDraw = True
        dgvVendaDeProdutos.Size = New Size(871, 486)
        dgvVendaDeProdutos.TabIndex = 1
        dgvVendaDeProdutos.UseCompatibleStateImageBehavior = False
        dgvVendaDeProdutos.View = View.Details
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.Anchor = AnchorStyles.Top
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(MaterialLabel5)
        MaterialCard1.Controls.Add(MaterialLabel6)
        MaterialCard1.Controls.Add(MaterialLabel3)
        MaterialCard1.Controls.Add(MaterialLabel4)
        MaterialCard1.Controls.Add(lblTotalPagar)
        MaterialCard1.Controls.Add(MaterialLabel1)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(922, 262)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(416, 145)
        MaterialCard1.TabIndex = 2
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel5.Location = New Point(94, 89)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(66, 24)
        MaterialLabel5.TabIndex = 5
        MaterialLabel5.Text = "R$ 0,00"
        ' 
        ' MaterialLabel6
        ' 
        MaterialLabel6.AutoSize = True
        MaterialLabel6.Depth = 0
        MaterialLabel6.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        MaterialLabel6.Location = New Point(18, 85)
        MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel6.Name = "MaterialLabel6"
        MaterialLabel6.Size = New Size(70, 29)
        MaterialLabel6.TabIndex = 4
        MaterialLabel6.Text = "Troco:"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel3.Location = New Point(119, 54)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(66, 24)
        MaterialLabel3.TabIndex = 3
        MaterialLabel3.Text = "R$ 0,00"
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        MaterialLabel4.Location = New Point(17, 50)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(96, 29)
        MaterialLabel4.TabIndex = 2
        MaterialLabel4.Text = "Dinheiro:"
        ' 
        ' lblTotalPagar
        ' 
        lblTotalPagar.AutoSize = True
        lblTotalPagar.Depth = 0
        lblTotalPagar.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblTotalPagar.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        lblTotalPagar.Location = New Point(127, 18)
        lblTotalPagar.MouseState = MaterialSkin.MouseState.HOVER
        lblTotalPagar.Name = "lblTotalPagar"
        lblTotalPagar.Size = New Size(66, 24)
        lblTotalPagar.TabIndex = 1
        lblTotalPagar.Text = "R$ 0,00"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        MaterialLabel1.Location = New Point(17, 14)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(108, 29)
        MaterialLabel1.TabIndex = 0
        MaterialLabel1.Text = "Sub Total:"
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.Anchor = AnchorStyles.Top
        MaterialButton1.AutoSize = False
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.FlatStyle = FlatStyle.Flat
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(1130, 574)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(208, 36)
        MaterialButton1.TabIndex = 6
        MaterialButton1.Text = "Finalizar Venda"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.Anchor = AnchorStyles.Top
        MaterialButton2.AutoSize = False
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(922, 574)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(197, 36)
        MaterialButton2.TabIndex = 7
        MaterialButton2.Text = "Cancelar Venda"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.Anchor = AnchorStyles.Top
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(1000, 515)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(338, 50)
        MaterialTextBox1.TabIndex = 8
        MaterialTextBox1.Text = ""
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' MaterialLabel7
        ' 
        MaterialLabel7.Anchor = AnchorStyles.Top
        MaterialLabel7.AutoSize = True
        MaterialLabel7.Depth = 0
        MaterialLabel7.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel7.Location = New Point(922, 528)
        MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel7.Name = "MaterialLabel7"
        MaterialLabel7.Size = New Size(72, 19)
        MaterialLabel7.TabIndex = 9
        MaterialLabel7.Text = "Desconto:"
        ' 
        ' MaterialTextBox2
        ' 
        MaterialTextBox2.Anchor = AnchorStyles.Top
        MaterialTextBox2.AnimateReadOnly = False
        MaterialTextBox2.BorderStyle = BorderStyle.None
        MaterialTextBox2.Depth = 0
        MaterialTextBox2.Font = New Font("Microsoft Sans Serif", 12F)
        MaterialTextBox2.LeadingIcon = Nothing
        MaterialTextBox2.Location = New Point(1000, 459)
        MaterialTextBox2.MaxLength = 50
        MaterialTextBox2.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox2.Multiline = False
        MaterialTextBox2.Name = "MaterialTextBox2"
        MaterialTextBox2.Size = New Size(338, 50)
        MaterialTextBox2.TabIndex = 10
        MaterialTextBox2.Text = "R$ 100,00"
        MaterialTextBox2.TrailingIcon = Nothing
        ' 
        ' MaterialLabel8
        ' 
        MaterialLabel8.Anchor = AnchorStyles.Top
        MaterialLabel8.AutoSize = True
        MaterialLabel8.Depth = 0
        MaterialLabel8.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel8.Location = New Point(922, 476)
        MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel8.Name = "MaterialLabel8"
        MaterialLabel8.Size = New Size(64, 19)
        MaterialLabel8.TabIndex = 11
        MaterialLabel8.Text = "Dinheiro:"
        ' 
        ' MaterialCheckbox1
        ' 
        MaterialCheckbox1.Anchor = AnchorStyles.Top
        MaterialCheckbox1.AutoSize = True
        MaterialCheckbox1.Depth = 0
        MaterialCheckbox1.Location = New Point(922, 408)
        MaterialCheckbox1.Margin = New Padding(0)
        MaterialCheckbox1.MouseLocation = New Point(-1, -1)
        MaterialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox1.Name = "MaterialCheckbox1"
        MaterialCheckbox1.ReadOnly = False
        MaterialCheckbox1.Ripple = True
        MaterialCheckbox1.Size = New Size(85, 37)
        MaterialCheckbox1.TabIndex = 12
        MaterialCheckbox1.Text = "Credito"
        MaterialCheckbox1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox2
        ' 
        MaterialCheckbox2.Anchor = AnchorStyles.Top
        MaterialCheckbox2.AutoSize = True
        MaterialCheckbox2.Depth = 0
        MaterialCheckbox2.Location = New Point(1015, 408)
        MaterialCheckbox2.Margin = New Padding(0)
        MaterialCheckbox2.MouseLocation = New Point(-1, -1)
        MaterialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox2.Name = "MaterialCheckbox2"
        MaterialCheckbox2.ReadOnly = False
        MaterialCheckbox2.Ripple = True
        MaterialCheckbox2.Size = New Size(81, 37)
        MaterialCheckbox2.TabIndex = 13
        MaterialCheckbox2.Text = "Debito"
        MaterialCheckbox2.UseVisualStyleBackColor = True
        ' 
        ' MaterialCheckbox3
        ' 
        MaterialCheckbox3.Anchor = AnchorStyles.Top
        MaterialCheckbox3.AutoSize = True
        MaterialCheckbox3.Depth = 0
        MaterialCheckbox3.Location = New Point(1105, 408)
        MaterialCheckbox3.Margin = New Padding(0)
        MaterialCheckbox3.MouseLocation = New Point(-1, -1)
        MaterialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCheckbox3.Name = "MaterialCheckbox3"
        MaterialCheckbox3.ReadOnly = False
        MaterialCheckbox3.Ripple = True
        MaterialCheckbox3.Size = New Size(59, 37)
        MaterialCheckbox3.TabIndex = 14
        MaterialCheckbox3.Text = "PIX"
        MaterialCheckbox3.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel9
        ' 
        MaterialLabel9.Anchor = AnchorStyles.Top
        MaterialLabel9.AutoSize = True
        MaterialLabel9.Depth = 0
        MaterialLabel9.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel9.Location = New Point(620, 623)
        MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel9.Name = "MaterialLabel9"
        MaterialLabel9.Size = New Size(244, 41)
        MaterialLabel9.TabIndex = 15
        MaterialLabel9.Text = "Total: R$ 000,00"
        ' 
        ' pdv
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1595, 851)
        Controls.Add(MaterialLabel9)
        Controls.Add(MaterialCheckbox3)
        Controls.Add(MaterialCheckbox2)
        Controls.Add(MaterialCheckbox1)
        Controls.Add(MaterialLabel8)
        Controls.Add(MaterialTextBox2)
        Controls.Add(MaterialLabel7)
        Controls.Add(MaterialTextBox1)
        Controls.Add(MaterialButton2)
        Controls.Add(MaterialButton1)
        Controls.Add(MaterialCard1)
        Controls.Add(dgvVendaDeProdutos)
        Controls.Add(txt_ean)
        FormStyle = FormStyles.ActionBar_None
        MaximizeBox = False
        MinimizeBox = False
        Name = "pdv"
        Padding = New Padding(3, 24, 3, 3)
        StartPosition = FormStartPosition.CenterScreen
        Text = "pdv"
        WindowState = FormWindowState.Maximized
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_ean As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents dgvVendaDeProdutos As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTotalPagar As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialTextBox2 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCheckbox1 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox2 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialCheckbox3 As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
End Class
