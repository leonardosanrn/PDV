<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cad_Produtos
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
        btn_salvar = New MaterialSkin.Controls.MaterialButton()
        dgv_produtos = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        MaterialTextBox1 = New MaterialSkin.Controls.MaterialTextBox()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        txt_proCode = New MaterialSkin.Controls.MaterialTextBox()
        txt_ProName = New MaterialSkin.Controls.MaterialTextBox()
        txt_price = New MaterialSkin.Controls.MaterialTextBox()
        txt_proGroup = New MaterialSkin.Controls.MaterialComboBox()
        txt_priceaaa = New MaterialSkin.Controls.MaterialMaskedTextBox()
        Check_Status = New MaterialSkin.Controls.MaterialCheckbox()
        dtp_ExpDate = New DateTimePicker()
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        MaterialFloatingActionButton1 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        Label1 = New Label()
        TabPage2 = New TabPage()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Label2 = New Label()
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_salvar
        ' 
        btn_salvar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_salvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_salvar.Depth = 0
        btn_salvar.HighEmphasis = True
        btn_salvar.Icon = Nothing
        btn_salvar.Location = New Point(743, 702)
        btn_salvar.Margin = New Padding(4, 6, 4, 6)
        btn_salvar.MouseState = MaterialSkin.MouseState.HOVER
        btn_salvar.Name = "btn_salvar"
        btn_salvar.NoAccentTextColor = Color.Empty
        btn_salvar.Size = New Size(76, 36)
        btn_salvar.TabIndex = 0
        btn_salvar.Text = "salvar"
        btn_salvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_salvar.UseAccentColor = False
        btn_salvar.UseVisualStyleBackColor = True
        ' 
        ' dgv_produtos
        ' 
        dgv_produtos.AutoSizeTable = False
        dgv_produtos.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        dgv_produtos.BorderStyle = BorderStyle.None
        dgv_produtos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        dgv_produtos.Depth = 0
        dgv_produtos.FullRowSelect = True
        dgv_produtos.Location = New Point(21, 214)
        dgv_produtos.MinimumSize = New Size(200, 100)
        dgv_produtos.MouseLocation = New Point(-1, -1)
        dgv_produtos.MouseState = MaterialSkin.MouseState.OUT
        dgv_produtos.Name = "dgv_produtos"
        dgv_produtos.OwnerDraw = True
        dgv_produtos.Size = New Size(656, 178)
        dgv_produtos.TabIndex = 1
        dgv_produtos.UseCompatibleStateImageBehavior = False
        dgv_produtos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "cod_barras"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "produto"
        ColumnHeader2.Width = 300
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "valorunit"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "categoria"
        ColumnHeader4.Width = 130
        ' 
        ' MaterialTextBox1
        ' 
        MaterialTextBox1.AnimateReadOnly = False
        MaterialTextBox1.BorderStyle = BorderStyle.None
        MaterialTextBox1.Depth = 0
        MaterialTextBox1.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox1.LeadingIcon = Nothing
        MaterialTextBox1.Location = New Point(6, 443)
        MaterialTextBox1.MaxLength = 50
        MaterialTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox1.Multiline = False
        MaterialTextBox1.Name = "MaterialTextBox1"
        MaterialTextBox1.Size = New Size(656, 50)
        MaterialTextBox1.TabIndex = 2
        MaterialTextBox1.Text = ""
        MaterialTextBox1.TrailingIcon = Nothing
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(511, 691)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(84, 36)
        MaterialButton1.TabIndex = 3
        MaterialButton1.Text = "deletar"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton2
        ' 
        MaterialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton2.Depth = 0
        MaterialButton2.HighEmphasis = True
        MaterialButton2.Icon = Nothing
        MaterialButton2.Location = New Point(432, 691)
        MaterialButton2.Margin = New Padding(4, 6, 4, 6)
        MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton2.Name = "MaterialButton2"
        MaterialButton2.NoAccentTextColor = Color.Empty
        MaterialButton2.Size = New Size(71, 36)
        MaterialButton2.TabIndex = 4
        MaterialButton2.Text = "editar"
        MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton2.UseAccentColor = False
        MaterialButton2.UseVisualStyleBackColor = True
        ' 
        ' txt_proCode
        ' 
        txt_proCode.AnimateReadOnly = False
        txt_proCode.BorderStyle = BorderStyle.None
        txt_proCode.Depth = 0
        txt_proCode.Font = New Font("Microsoft Sans Serif", 12F)
        txt_proCode.LeadingIcon = Nothing
        txt_proCode.Location = New Point(511, 53)
        txt_proCode.MaxLength = 50
        txt_proCode.MouseState = MaterialSkin.MouseState.OUT
        txt_proCode.Multiline = False
        txt_proCode.Name = "txt_proCode"
        txt_proCode.Size = New Size(195, 50)
        txt_proCode.TabIndex = 5
        txt_proCode.Text = "Codigo de barras"
        txt_proCode.TrailingIcon = Nothing
        ' 
        ' txt_ProName
        ' 
        txt_ProName.AnimateReadOnly = False
        txt_ProName.BorderStyle = BorderStyle.None
        txt_ProName.Depth = 0
        txt_ProName.Font = New Font("Microsoft Sans Serif", 12F)
        txt_ProName.LeadingIcon = Nothing
        txt_ProName.Location = New Point(21, 53)
        txt_ProName.MaxLength = 50
        txt_ProName.MouseState = MaterialSkin.MouseState.OUT
        txt_ProName.Multiline = False
        txt_ProName.Name = "txt_ProName"
        txt_ProName.Size = New Size(195, 50)
        txt_ProName.TabIndex = 6
        txt_ProName.Text = "Nome Produto"
        txt_ProName.TrailingIcon = Nothing
        ' 
        ' txt_price
        ' 
        txt_price.AnimateReadOnly = False
        txt_price.BorderStyle = BorderStyle.None
        txt_price.Depth = 0
        txt_price.Font = New Font("Microsoft Sans Serif", 12F)
        txt_price.LeadingIcon = Nothing
        txt_price.Location = New Point(222, 516)
        txt_price.MaxLength = 50
        txt_price.MouseState = MaterialSkin.MouseState.OUT
        txt_price.Multiline = False
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(195, 50)
        txt_price.TabIndex = 7
        txt_price.Text = "Preço"
        txt_price.TrailingIcon = Nothing
        ' 
        ' txt_proGroup
        ' 
        txt_proGroup.AutoResize = False
        txt_proGroup.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        txt_proGroup.Depth = 0
        txt_proGroup.DrawMode = DrawMode.OwnerDrawVariable
        txt_proGroup.DropDownHeight = 174
        txt_proGroup.DropDownStyle = ComboBoxStyle.DropDownList
        txt_proGroup.DropDownWidth = 121
        txt_proGroup.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel)
        txt_proGroup.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        txt_proGroup.FormattingEnabled = True
        txt_proGroup.IntegralHeight = False
        txt_proGroup.ItemHeight = 43
        txt_proGroup.Items.AddRange(New Object() {"Bebidas", "Doces", "Salgadinhos", "Lanches"})
        txt_proGroup.Location = New Point(21, 574)
        txt_proGroup.MaxDropDownItems = 4
        txt_proGroup.MouseState = MaterialSkin.MouseState.OUT
        txt_proGroup.Name = "txt_proGroup"
        txt_proGroup.Size = New Size(195, 49)
        txt_proGroup.StartIndex = 0
        txt_proGroup.TabIndex = 8
        ' 
        ' txt_priceaaa
        ' 
        txt_priceaaa.AllowPromptAsInput = True
        txt_priceaaa.AnimateReadOnly = False
        txt_priceaaa.AsciiOnly = False
        txt_priceaaa.BackgroundImageLayout = ImageLayout.None
        txt_priceaaa.BeepOnError = False
        txt_priceaaa.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        txt_priceaaa.Depth = 0
        txt_priceaaa.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_priceaaa.HidePromptOnLeave = False
        txt_priceaaa.HideSelection = True
        txt_priceaaa.InsertKeyMode = InsertKeyMode.Default
        txt_priceaaa.LeadingIcon = Nothing
        txt_priceaaa.Location = New Point(21, 518)
        txt_priceaaa.Mask = "R$0000.00"
        txt_priceaaa.MaxLength = 32767
        txt_priceaaa.MouseState = MaterialSkin.MouseState.OUT
        txt_priceaaa.Name = "txt_priceaaa"
        txt_priceaaa.PasswordChar = ChrW(0)
        txt_priceaaa.PrefixSuffixText = Nothing
        txt_priceaaa.PromptChar = "_"c
        txt_priceaaa.ReadOnly = False
        txt_priceaaa.RejectInputOnFirstFailure = False
        txt_priceaaa.ResetOnPrompt = True
        txt_priceaaa.ResetOnSpace = True
        txt_priceaaa.RightToLeft = RightToLeft.No
        txt_priceaaa.SelectedText = ""
        txt_priceaaa.SelectionLength = 0
        txt_priceaaa.SelectionStart = 0
        txt_priceaaa.ShortcutsEnabled = True
        txt_priceaaa.Size = New Size(195, 48)
        txt_priceaaa.SkipLiterals = True
        txt_priceaaa.TabIndex = 9
        txt_priceaaa.TabStop = False
        txt_priceaaa.Text = "______"
        txt_priceaaa.TextAlign = HorizontalAlignment.Left
        txt_priceaaa.TextMaskFormat = MaskFormat.IncludePrompt
        txt_priceaaa.TrailingIcon = Nothing
        txt_priceaaa.UseSystemPasswordChar = False
        txt_priceaaa.ValidatingType = Nothing
        ' 
        ' Check_Status
        ' 
        Check_Status.AutoSize = True
        Check_Status.Depth = 0
        Check_Status.Location = New Point(45, 642)
        Check_Status.Margin = New Padding(0)
        Check_Status.MouseLocation = New Point(-1, -1)
        Check_Status.MouseState = MaterialSkin.MouseState.HOVER
        Check_Status.Name = "Check_Status"
        Check_Status.ReadOnly = False
        Check_Status.Ripple = True
        Check_Status.Size = New Size(171, 37)
        Check_Status.TabIndex = 10
        Check_Status.Text = "MaterialCheckbox1"
        Check_Status.UseVisualStyleBackColor = True
        ' 
        ' dtp_ExpDate
        ' 
        dtp_ExpDate.Location = New Point(237, 600)
        dtp_ExpDate.Name = "dtp_ExpDate"
        dtp_ExpDate.Size = New Size(200, 23)
        dtp_ExpDate.TabIndex = 11
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.AccessibleRole = AccessibleRole.None
        MaterialTabControl1.Appearance = TabAppearance.FlatButtons
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.ImeMode = ImeMode.On
        MaterialTabControl1.Location = New Point(6, 81)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.RightToLeft = RightToLeft.Yes
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(834, 778)
        MaterialTabControl1.SizeMode = TabSizeMode.Fixed
        MaterialTabControl1.TabIndex = 12
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(txt_proCode)
        TabPage1.Controls.Add(MaterialFloatingActionButton1)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(dtp_ExpDate)
        TabPage1.Controls.Add(MaterialTextBox1)
        TabPage1.Controls.Add(Check_Status)
        TabPage1.Controls.Add(btn_salvar)
        TabPage1.Controls.Add(txt_priceaaa)
        TabPage1.Controls.Add(dgv_produtos)
        TabPage1.Controls.Add(txt_proGroup)
        TabPage1.Controls.Add(MaterialButton1)
        TabPage1.Controls.Add(txt_price)
        TabPage1.Controls.Add(MaterialButton2)
        TabPage1.Controls.Add(txt_ProName)
        TabPage1.Location = New Point(4, 27)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(826, 747)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Cadastro Básico"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' MaterialFloatingActionButton1
        ' 
        MaterialFloatingActionButton1.Depth = 0
        MaterialFloatingActionButton1.Icon = Nothing
        MaterialFloatingActionButton1.Location = New Point(724, 53)
        MaterialFloatingActionButton1.Mini = True
        MaterialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialFloatingActionButton1.Name = "MaterialFloatingActionButton1"
        MaterialFloatingActionButton1.Size = New Size(40, 43)
        MaterialFloatingActionButton1.TabIndex = 12
        MaterialFloatingActionButton1.Text = "Gerar Aleatorio"
        MaterialFloatingActionButton1.TextAlign = ContentAlignment.BottomCenter
        MaterialFloatingActionButton1.TextImageRelation = TextImageRelation.TextAboveImage
        MaterialFloatingActionButton1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(703, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 13
        Label1.Text = "Gerar Aleatorio"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(MaterialLabel1)
        TabPage2.Location = New Point(4, 27)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(826, 747)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Avançado"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(6, 3)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(229, 19)
        MaterialLabel1.TabIndex = 0
        MaterialLabel1.Text = "Cadastro Avançado de Produtos"
        ' 
        ' MaterialTabSelector1
        ' 
        MaterialTabSelector1.BaseTabControl = MaterialTabControl1
        MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        MaterialTabSelector1.Depth = 0
        MaterialTabSelector1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTabSelector1.Location = New Point(3, 27)
        MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabSelector1.Name = "MaterialTabSelector1"
        MaterialTabSelector1.Size = New Size(837, 48)
        MaterialTabSelector1.TabIndex = 12
        MaterialTabSelector1.Text = "MaterialTabSelector1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 14
        Label2.Text = "Nome do Produto"
        ' 
        ' frm_cad_Produtos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1111, 865)
        Controls.Add(MaterialTabSelector1)
        Controls.Add(MaterialTabControl1)
        DrawerAutoShow = True
        DrawerIsOpen = True
        DrawerShowIconsWhenHidden = True
        DrawerUseColors = True
        FormStyle = FormStyles.ActionBar_None
        MaximizeBox = False
        MinimizeBox = False
        Name = "frm_cad_Produtos"
        Padding = New Padding(3, 24, 3, 3)
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "frm_cad_Produtos"
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_salvar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents dgv_produtos As MaterialSkin.Controls.MaterialListView
    Friend WithEvents MaterialTextBox1 As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txt_proCode As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txt_ProName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txt_price As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txt_proGroup As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txt_priceaaa As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents Check_Status As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents dtp_ExpDate As DateTimePicker
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Private WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents MaterialFloatingActionButton1 As MaterialSkin.Controls.MaterialFloatingActionButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
