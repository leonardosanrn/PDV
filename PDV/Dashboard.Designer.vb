<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        MaterialCard4 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard3 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel15 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard2 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        MaterialLabel14 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        TabPage2 = New TabPage()
        btn_cadshow = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        btn_criar = New MaterialSkin.Controls.MaterialButton()
        txt_proGroup = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Check_Status = New MaterialSkin.Controls.MaterialCheckbox()
        MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        txt_price = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        txt_ProName = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        dtp_ExpDate = New MaterialSkin.Controls.MaterialMaskedTextBox()
        txt_proCode = New MaterialSkin.Controls.MaterialTextBox()
        btn_delete = New MaterialSkin.Controls.MaterialButton()
        btn_salvar = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        txt_search = New MaterialSkin.Controls.MaterialTextBox()
        btn_limpar = New MaterialSkin.Controls.MaterialButton()
        MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        TabPage3 = New TabPage()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialMultiLineTextBox1 = New MaterialSkin.Controls.MaterialMultiLineTextBox()
        MaterialMaskedTextBox1 = New MaterialSkin.Controls.MaterialMaskedTextBox()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        TabPage4 = New TabPage()
        cbxAzul = New MaterialSkin.Controls.MaterialCheckbox()
        cbxGreen = New MaterialSkin.Controls.MaterialCheckbox()
        cbxOrange = New MaterialSkin.Controls.MaterialCheckbox()
        SwitchTheme = New MaterialSkin.Controls.MaterialSwitch()
        ImageList1 = New ImageList(components)
        lblHoras = New MaterialSkin.Controls.MaterialLabel()
        Timer1 = New Timer(components)
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        MaterialCard4.SuspendLayout()
        MaterialCard3.SuspendLayout()
        MaterialCard1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Controls.Add(TabPage3)
        MaterialTabControl1.Controls.Add(TabPage4)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Dock = DockStyle.Fill
        MaterialTabControl1.ImageList = ImageList1
        MaterialTabControl1.Location = New Point(3, 88)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(1341, 923)
        MaterialTabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(MaterialCard4)
        TabPage1.Controls.Add(MaterialCard3)
        TabPage1.Controls.Add(MaterialCard2)
        TabPage1.Controls.Add(MaterialLabel13)
        TabPage1.Controls.Add(MaterialCard1)
        TabPage1.Controls.Add(MaterialLabel1)
        TabPage1.ImageKey = "computador.png"
        TabPage1.Location = New Point(4, 39)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1333, 880)
        TabPage1.TabIndex = 0
        TabPage1.Text = "DASHBOARD"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard4
        ' 
        MaterialCard4.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard4.Controls.Add(MaterialLabel16)
        MaterialCard4.Depth = 0
        MaterialCard4.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard4.Location = New Point(17, 497)
        MaterialCard4.Margin = New Padding(14)
        MaterialCard4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard4.Name = "MaterialCard4"
        MaterialCard4.Padding = New Padding(14)
        MaterialCard4.Size = New Size(829, 399)
        MaterialCard4.TabIndex = 9
        ' 
        ' MaterialLabel16
        ' 
        MaterialLabel16.AutoSize = True
        MaterialLabel16.Depth = 0
        MaterialLabel16.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel16.Location = New Point(17, 14)
        MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel16.Name = "MaterialLabel16"
        MaterialLabel16.Size = New Size(138, 24)
        MaterialLabel16.TabIndex = 8
        MaterialLabel16.Text = "Vendas do mês"
        MaterialLabel16.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MaterialCard3
        ' 
        MaterialCard3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard3.Controls.Add(MaterialLabel15)
        MaterialCard3.Depth = 0
        MaterialCard3.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard3.Location = New Point(17, 82)
        MaterialCard3.Margin = New Padding(14)
        MaterialCard3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard3.Name = "MaterialCard3"
        MaterialCard3.Padding = New Padding(14)
        MaterialCard3.Size = New Size(829, 399)
        MaterialCard3.TabIndex = 1
        ' 
        ' MaterialLabel15
        ' 
        MaterialLabel15.AutoSize = True
        MaterialLabel15.Depth = 0
        MaterialLabel15.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel15.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel15.Location = New Point(17, 14)
        MaterialLabel15.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel15.Name = "MaterialLabel15"
        MaterialLabel15.Size = New Size(138, 24)
        MaterialLabel15.TabIndex = 8
        MaterialLabel15.Text = "Vendas do mês"
        MaterialLabel15.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MaterialCard2
        ' 
        MaterialCard2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard2.Depth = 0
        MaterialCard2.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard2.Location = New Point(866, 497)
        MaterialCard2.Margin = New Padding(14)
        MaterialCard2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard2.Name = "MaterialCard2"
        MaterialCard2.Padding = New Padding(14)
        MaterialCard2.Size = New Size(400, 399)
        MaterialCard2.TabIndex = 8
        ' 
        ' MaterialLabel13
        ' 
        MaterialLabel13.AutoSize = True
        MaterialLabel13.Depth = 0
        MaterialLabel13.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        MaterialLabel13.Location = New Point(6, 44)
        MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel13.Name = "MaterialLabel13"
        MaterialLabel13.Size = New Size(374, 19)
        MaterialLabel13.TabIndex = 6
        MaterialLabel13.Text = "Tenha uma visão geral do que acontece na empresa!"
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Controls.Add(MaterialLabel14)
        MaterialCard1.Controls.Add(MaterialLabel6)
        MaterialCard1.Controls.Add(MaterialLabel5)
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(866, 81)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(400, 400)
        MaterialCard1.TabIndex = 3
        ' 
        ' MaterialLabel14
        ' 
        MaterialLabel14.AutoSize = True
        MaterialLabel14.Depth = 0
        MaterialLabel14.Font = New Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel14.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        MaterialLabel14.Location = New Point(17, 14)
        MaterialLabel14.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel14.Name = "MaterialLabel14"
        MaterialLabel14.Size = New Size(113, 24)
        MaterialLabel14.TabIndex = 7
        MaterialLabel14.Text = "Top Clientes"
        MaterialLabel14.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MaterialLabel6
        ' 
        MaterialLabel6.AutoSize = True
        MaterialLabel6.Depth = 0
        MaterialLabel6.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel6.Location = New Point(52, 91)
        MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel6.Name = "MaterialLabel6"
        MaterialLabel6.Size = New Size(107, 19)
        MaterialLabel6.TabIndex = 4
        MaterialLabel6.Text = "MaterialLabel6"
        ' 
        ' MaterialLabel5
        ' 
        MaterialLabel5.AutoSize = True
        MaterialLabel5.Depth = 0
        MaterialLabel5.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel5.Location = New Point(52, 52)
        MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel5.Name = "MaterialLabel5"
        MaterialLabel5.Size = New Size(73, 19)
        MaterialLabel5.TabIndex = 2
        MaterialLabel5.Text = "Saudação"
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel1.Location = New Point(6, 3)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(183, 41)
        MaterialLabel1.TabIndex = 1
        MaterialLabel1.Text = "Visão Geral "
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btn_cadshow)
        TabPage2.Controls.Add(MaterialLabel12)
        TabPage2.Controls.Add(btn_criar)
        TabPage2.Controls.Add(txt_proGroup)
        TabPage2.Controls.Add(MaterialLabel11)
        TabPage2.Controls.Add(MaterialLabel10)
        TabPage2.Controls.Add(Check_Status)
        TabPage2.Controls.Add(MaterialLabel9)
        TabPage2.Controls.Add(txt_price)
        TabPage2.Controls.Add(MaterialLabel8)
        TabPage2.Controls.Add(txt_ProName)
        TabPage2.Controls.Add(MaterialLabel7)
        TabPage2.Controls.Add(dtp_ExpDate)
        TabPage2.Controls.Add(txt_proCode)
        TabPage2.Controls.Add(btn_delete)
        TabPage2.Controls.Add(btn_salvar)
        TabPage2.Controls.Add(MaterialLabel4)
        TabPage2.Controls.Add(MaterialDivider1)
        TabPage2.Controls.Add(txt_search)
        TabPage2.Controls.Add(btn_limpar)
        TabPage2.Controls.Add(MaterialListView1)
        TabPage2.Controls.Add(MaterialLabel2)
        TabPage2.ImageKey = "distribuicao.png"
        TabPage2.Location = New Point(4, 39)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1333, 880)
        TabPage2.TabIndex = 1
        TabPage2.Text = "PRODUTOS"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btn_cadshow
        ' 
        btn_cadshow.Anchor = AnchorStyles.Top
        btn_cadshow.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_cadshow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_cadshow.Depth = 0
        btn_cadshow.HighEmphasis = True
        btn_cadshow.Icon = Nothing
        btn_cadshow.Location = New Point(1083, 55)
        btn_cadshow.Margin = New Padding(4, 6, 4, 6)
        btn_cadshow.MouseState = MaterialSkin.MouseState.HOVER
        btn_cadshow.Name = "btn_cadshow"
        btn_cadshow.NoAccentTextColor = Color.Empty
        btn_cadshow.Size = New Size(106, 36)
        btn_cadshow.TabIndex = 22
        btn_cadshow.Text = "Cadastrar"
        btn_cadshow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_cadshow.UseAccentColor = False
        btn_cadshow.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel12
        ' 
        MaterialLabel12.Anchor = AnchorStyles.Top
        MaterialLabel12.AutoSize = True
        MaterialLabel12.Depth = 0
        MaterialLabel12.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel12.Location = New Point(250, 784)
        MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel12.Name = "MaterialLabel12"
        MaterialLabel12.Size = New Size(69, 19)
        MaterialLabel12.TabIndex = 21
        MaterialLabel12.Text = "Categoria"
        ' 
        ' btn_criar
        ' 
        btn_criar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_criar.AutoSize = False
        btn_criar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_criar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_criar.Depth = 0
        btn_criar.HighEmphasis = True
        btn_criar.Icon = Nothing
        btn_criar.Location = New Point(1002, 835)
        btn_criar.Margin = New Padding(4, 6, 4, 6)
        btn_criar.MouseState = MaterialSkin.MouseState.HOVER
        btn_criar.Name = "btn_criar"
        btn_criar.NoAccentTextColor = Color.Empty
        btn_criar.Size = New Size(158, 36)
        btn_criar.TabIndex = 20
        btn_criar.Text = "salvar"
        btn_criar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_criar.UseAccentColor = False
        btn_criar.UseVisualStyleBackColor = True
        ' 
        ' txt_proGroup
        ' 
        txt_proGroup.Anchor = AnchorStyles.Top
        txt_proGroup.AnimateReadOnly = False
        txt_proGroup.BorderStyle = BorderStyle.None
        txt_proGroup.Depth = 0
        txt_proGroup.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_proGroup.LeadingIcon = Nothing
        txt_proGroup.Location = New Point(325, 782)
        txt_proGroup.MaxLength = 50
        txt_proGroup.MouseState = MaterialSkin.MouseState.OUT
        txt_proGroup.Multiline = False
        txt_proGroup.Name = "txt_proGroup"
        txt_proGroup.Size = New Size(389, 36)
        txt_proGroup.TabIndex = 19
        txt_proGroup.Text = ""
        txt_proGroup.TrailingIcon = Nothing
        txt_proGroup.UseTallSize = False
        ' 
        ' MaterialLabel11
        ' 
        MaterialLabel11.Anchor = AnchorStyles.Top
        MaterialLabel11.AutoSize = True
        MaterialLabel11.Depth = 0
        MaterialLabel11.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel11.Location = New Point(780, 665)
        MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel11.Name = "MaterialLabel11"
        MaterialLabel11.Size = New Size(35, 19)
        MaterialLabel11.TabIndex = 18
        MaterialLabel11.Text = "Data"
        ' 
        ' MaterialLabel10
        ' 
        MaterialLabel10.Anchor = AnchorStyles.Top
        MaterialLabel10.AutoSize = True
        MaterialLabel10.Depth = 0
        MaterialLabel10.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel10.Location = New Point(740, 790)
        MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel10.Name = "MaterialLabel10"
        MaterialLabel10.Size = New Size(47, 19)
        MaterialLabel10.TabIndex = 17
        MaterialLabel10.Text = "Status"
        ' 
        ' Check_Status
        ' 
        Check_Status.Anchor = AnchorStyles.Top
        Check_Status.AutoSize = True
        Check_Status.Depth = 0
        Check_Status.Location = New Point(790, 775)
        Check_Status.Margin = New Padding(0)
        Check_Status.MouseLocation = New Point(-1, -1)
        Check_Status.MouseState = MaterialSkin.MouseState.HOVER
        Check_Status.Name = "Check_Status"
        Check_Status.ReadOnly = False
        Check_Status.Ripple = True
        Check_Status.Size = New Size(171, 37)
        Check_Status.TabIndex = 16
        Check_Status.Text = "MaterialCheckbox1"
        Check_Status.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel9
        ' 
        MaterialLabel9.Anchor = AnchorStyles.Top
        MaterialLabel9.AutoSize = True
        MaterialLabel9.Depth = 0
        MaterialLabel9.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel9.Location = New Point(222, 749)
        MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel9.Name = "MaterialLabel9"
        MaterialLabel9.Size = New Size(97, 19)
        MaterialLabel9.TabIndex = 15
        MaterialLabel9.Text = "Valor produto"
        ' 
        ' txt_price
        ' 
        txt_price.Anchor = AnchorStyles.Top
        txt_price.AnimateReadOnly = False
        txt_price.BorderStyle = BorderStyle.None
        txt_price.Depth = 0
        txt_price.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_price.LeadingIcon = Nothing
        txt_price.Location = New Point(325, 732)
        txt_price.MaxLength = 50
        txt_price.MouseState = MaterialSkin.MouseState.OUT
        txt_price.Multiline = False
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(389, 36)
        txt_price.TabIndex = 14
        txt_price.Text = ""
        txt_price.TrailingIcon = Nothing
        txt_price.UseTallSize = False
        ' 
        ' MaterialLabel8
        ' 
        MaterialLabel8.Anchor = AnchorStyles.Top
        MaterialLabel8.AutoSize = True
        MaterialLabel8.Depth = 0
        MaterialLabel8.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel8.Location = New Point(216, 707)
        MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel8.Name = "MaterialLabel8"
        MaterialLabel8.Size = New Size(103, 19)
        MaterialLabel8.TabIndex = 13
        MaterialLabel8.Text = "Nome Produto"
        ' 
        ' txt_ProName
        ' 
        txt_ProName.Anchor = AnchorStyles.Top
        txt_ProName.AnimateReadOnly = False
        txt_ProName.BorderStyle = BorderStyle.None
        txt_ProName.Depth = 0
        txt_ProName.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_ProName.LeadingIcon = Nothing
        txt_ProName.Location = New Point(325, 690)
        txt_ProName.MaxLength = 50
        txt_ProName.MouseState = MaterialSkin.MouseState.OUT
        txt_ProName.Multiline = False
        txt_ProName.Name = "txt_ProName"
        txt_ProName.Size = New Size(389, 36)
        txt_ProName.TabIndex = 12
        txt_ProName.Text = ""
        txt_ProName.TrailingIcon = Nothing
        txt_ProName.UseTallSize = False
        ' 
        ' MaterialLabel7
        ' 
        MaterialLabel7.Anchor = AnchorStyles.Top
        MaterialLabel7.AutoSize = True
        MaterialLabel7.Depth = 0
        MaterialLabel7.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel7.Location = New Point(198, 665)
        MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel7.Name = "MaterialLabel7"
        MaterialLabel7.Size = New Size(121, 19)
        MaterialLabel7.TabIndex = 11
        MaterialLabel7.Text = "Codigo de barras"
        ' 
        ' dtp_ExpDate
        ' 
        dtp_ExpDate.AllowPromptAsInput = True
        dtp_ExpDate.Anchor = AnchorStyles.Top
        dtp_ExpDate.AnimateReadOnly = False
        dtp_ExpDate.AsciiOnly = False
        dtp_ExpDate.BackgroundImageLayout = ImageLayout.None
        dtp_ExpDate.BeepOnError = False
        dtp_ExpDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        dtp_ExpDate.Depth = 0
        dtp_ExpDate.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        dtp_ExpDate.HidePromptOnLeave = False
        dtp_ExpDate.HideSelection = True
        dtp_ExpDate.InsertKeyMode = InsertKeyMode.Default
        dtp_ExpDate.LeadingIcon = Nothing
        dtp_ExpDate.Location = New Point(869, 675)
        dtp_ExpDate.Mask = "00/00/0000"
        dtp_ExpDate.MaxLength = 32767
        dtp_ExpDate.MouseState = MaterialSkin.MouseState.OUT
        dtp_ExpDate.Name = "dtp_ExpDate"
        dtp_ExpDate.PasswordChar = ChrW(0)
        dtp_ExpDate.PrefixSuffixText = Nothing
        dtp_ExpDate.PromptChar = "_"c
        dtp_ExpDate.ReadOnly = False
        dtp_ExpDate.RejectInputOnFirstFailure = False
        dtp_ExpDate.ResetOnPrompt = True
        dtp_ExpDate.ResetOnSpace = True
        dtp_ExpDate.RightToLeft = RightToLeft.No
        dtp_ExpDate.SelectedText = ""
        dtp_ExpDate.SelectionLength = 0
        dtp_ExpDate.SelectionStart = 10
        dtp_ExpDate.ShortcutsEnabled = True
        dtp_ExpDate.Size = New Size(135, 36)
        dtp_ExpDate.SkipLiterals = True
        dtp_ExpDate.TabIndex = 10
        dtp_ExpDate.TabStop = False
        dtp_ExpDate.Text = "10/02/1998"
        dtp_ExpDate.TextAlign = HorizontalAlignment.Center
        dtp_ExpDate.TextMaskFormat = MaskFormat.IncludeLiterals
        dtp_ExpDate.TrailingIcon = Nothing
        dtp_ExpDate.UseSystemPasswordChar = False
        dtp_ExpDate.UseTallSize = False
        dtp_ExpDate.ValidatingType = Nothing
        ' 
        ' txt_proCode
        ' 
        txt_proCode.Anchor = AnchorStyles.Top
        txt_proCode.AnimateReadOnly = False
        txt_proCode.BorderStyle = BorderStyle.None
        txt_proCode.Depth = 0
        txt_proCode.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_proCode.LeadingIcon = Nothing
        txt_proCode.Location = New Point(325, 648)
        txt_proCode.MaxLength = 50
        txt_proCode.MouseState = MaterialSkin.MouseState.OUT
        txt_proCode.Multiline = False
        txt_proCode.Name = "txt_proCode"
        txt_proCode.Size = New Size(389, 36)
        txt_proCode.TabIndex = 9
        txt_proCode.Text = ""
        txt_proCode.TrailingIcon = Nothing
        txt_proCode.UseTallSize = False
        ' 
        ' btn_delete
        ' 
        btn_delete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_delete.AutoSize = False
        btn_delete.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_delete.Depth = 0
        btn_delete.HighEmphasis = True
        btn_delete.Icon = Nothing
        btn_delete.Location = New Point(836, 835)
        btn_delete.Margin = New Padding(4, 6, 4, 6)
        btn_delete.MouseState = MaterialSkin.MouseState.HOVER
        btn_delete.Name = "btn_delete"
        btn_delete.NoAccentTextColor = Color.Empty
        btn_delete.Size = New Size(158, 36)
        btn_delete.TabIndex = 8
        btn_delete.Text = "deletar"
        btn_delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_delete.UseAccentColor = False
        btn_delete.UseVisualStyleBackColor = True
        ' 
        ' btn_salvar
        ' 
        btn_salvar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_salvar.AutoSize = False
        btn_salvar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_salvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_salvar.Depth = 0
        btn_salvar.HighEmphasis = True
        btn_salvar.Icon = Nothing
        btn_salvar.Location = New Point(1002, 835)
        btn_salvar.Margin = New Padding(4, 6, 4, 6)
        btn_salvar.MouseState = MaterialSkin.MouseState.HOVER
        btn_salvar.Name = "btn_salvar"
        btn_salvar.NoAccentTextColor = Color.Empty
        btn_salvar.Size = New Size(158, 36)
        btn_salvar.TabIndex = 7
        btn_salvar.Text = "salvar"
        btn_salvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_salvar.UseAccentColor = False
        btn_salvar.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel4
        ' 
        MaterialLabel4.Anchor = AnchorStyles.Top
        MaterialLabel4.AutoSize = True
        MaterialLabel4.Depth = 0
        MaterialLabel4.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel4.Location = New Point(50, 71)
        MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel4.Name = "MaterialLabel4"
        MaterialLabel4.Size = New Size(65, 19)
        MaterialLabel4.TabIndex = 6
        MaterialLabel4.Text = "Procurar:"
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.BackgroundImageLayout = ImageLayout.Center
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-8, 41)
        MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(3205, 2)
        MaterialDivider1.TabIndex = 4
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' txt_search
        ' 
        txt_search.AccessibleRole = AccessibleRole.None
        txt_search.Anchor = AnchorStyles.Top
        txt_search.AnimateReadOnly = False
        txt_search.BorderStyle = BorderStyle.None
        txt_search.Depth = 0
        txt_search.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        txt_search.LeadingIcon = Nothing
        txt_search.Location = New Point(121, 54)
        txt_search.MaxLength = 50
        txt_search.MouseState = MaterialSkin.MouseState.OUT
        txt_search.Multiline = False
        txt_search.Name = "txt_search"
        txt_search.Size = New Size(955, 36)
        txt_search.TabIndex = 3
        txt_search.Text = ""
        txt_search.TrailingIcon = Nothing
        txt_search.UseTallSize = False
        ' 
        ' btn_limpar
        ' 
        btn_limpar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btn_limpar.AutoSize = False
        btn_limpar.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btn_limpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_limpar.Depth = 0
        btn_limpar.HighEmphasis = True
        btn_limpar.Icon = Nothing
        btn_limpar.Location = New Point(1168, 835)
        btn_limpar.Margin = New Padding(4, 6, 4, 6)
        btn_limpar.MouseState = MaterialSkin.MouseState.HOVER
        btn_limpar.Name = "btn_limpar"
        btn_limpar.NoAccentTextColor = Color.Empty
        btn_limpar.Size = New Size(158, 36)
        btn_limpar.TabIndex = 2
        btn_limpar.Text = "limpar"
        btn_limpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_limpar.UseAccentColor = False
        btn_limpar.UseVisualStyleBackColor = True
        ' 
        ' MaterialListView1
        ' 
        MaterialListView1.Anchor = AnchorStyles.Top
        MaterialListView1.AutoSizeTable = False
        MaterialListView1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialListView1.BorderStyle = BorderStyle.None
        MaterialListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6})
        MaterialListView1.Depth = 0
        MaterialListView1.FullRowSelect = True
        MaterialListView1.Location = New Point(50, 109)
        MaterialListView1.MinimumSize = New Size(200, 100)
        MaterialListView1.MouseLocation = New Point(-1, -1)
        MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        MaterialListView1.Name = "MaterialListView1"
        MaterialListView1.OwnerDraw = True
        MaterialListView1.Size = New Size(1139, 509)
        MaterialListView1.TabIndex = 1
        MaterialListView1.UseCompatibleStateImageBehavior = False
        MaterialListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Codigo de barras"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nome do Produto"
        ColumnHeader2.Width = 250
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Categoria"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Preço"
        ColumnHeader4.Width = 110
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Data"
        ColumnHeader5.Width = 110
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Status"
        ColumnHeader6.Width = 100
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.Anchor = AnchorStyles.Top
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel)
        MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H4
        MaterialLabel2.Location = New Point(438, 0)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(212, 41)
        MaterialLabel2.TabIndex = 0
        MaterialLabel2.Text = "Produtos Tela"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(MaterialButton1)
        TabPage3.Controls.Add(MaterialMultiLineTextBox1)
        TabPage3.Controls.Add(MaterialMaskedTextBox1)
        TabPage3.Controls.Add(MaterialLabel3)
        TabPage3.ImageKey = "ponto-de-venda.png"
        TabPage3.Location = New Point(4, 39)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1333, 880)
        TabPage3.TabIndex = 2
        TabPage3.Text = "PDV"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(460, 366)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(95, 36)
        MaterialButton1.TabIndex = 3
        MaterialButton1.Text = "Abrir PDV"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialMultiLineTextBox1
        ' 
        MaterialMultiLineTextBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialMultiLineTextBox1.BorderStyle = BorderStyle.None
        MaterialMultiLineTextBox1.Depth = 0
        MaterialMultiLineTextBox1.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialMultiLineTextBox1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialMultiLineTextBox1.Location = New Point(405, 187)
        MaterialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialMultiLineTextBox1.Name = "MaterialMultiLineTextBox1"
        MaterialMultiLineTextBox1.Size = New Size(266, 96)
        MaterialMultiLineTextBox1.TabIndex = 2
        MaterialMultiLineTextBox1.Text = "a" & vbLf & "a" & vbLf & "a" & vbLf & "a"
        ' 
        ' MaterialMaskedTextBox1
        ' 
        MaterialMaskedTextBox1.AllowPromptAsInput = True
        MaterialMaskedTextBox1.AnimateReadOnly = False
        MaterialMaskedTextBox1.AsciiOnly = False
        MaterialMaskedTextBox1.BackgroundImageLayout = ImageLayout.None
        MaterialMaskedTextBox1.BeepOnError = False
        MaterialMaskedTextBox1.CutCopyMaskFormat = MaskFormat.IncludeLiterals
        MaterialMaskedTextBox1.Depth = 0
        MaterialMaskedTextBox1.Font = New Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialMaskedTextBox1.HidePromptOnLeave = False
        MaterialMaskedTextBox1.HideSelection = True
        MaterialMaskedTextBox1.InsertKeyMode = InsertKeyMode.Default
        MaterialMaskedTextBox1.LeadingIcon = Nothing
        MaterialMaskedTextBox1.Location = New Point(405, 109)
        MaterialMaskedTextBox1.Mask = "00/00/0000"
        MaterialMaskedTextBox1.MaxLength = 32767
        MaterialMaskedTextBox1.MouseState = MaterialSkin.MouseState.OUT
        MaterialMaskedTextBox1.Name = "MaterialMaskedTextBox1"
        MaterialMaskedTextBox1.PasswordChar = ChrW(0)
        MaterialMaskedTextBox1.PrefixSuffixText = Nothing
        MaterialMaskedTextBox1.PromptChar = "_"c
        MaterialMaskedTextBox1.ReadOnly = False
        MaterialMaskedTextBox1.RejectInputOnFirstFailure = False
        MaterialMaskedTextBox1.ResetOnPrompt = True
        MaterialMaskedTextBox1.ResetOnSpace = True
        MaterialMaskedTextBox1.RightToLeft = RightToLeft.No
        MaterialMaskedTextBox1.SelectedText = ""
        MaterialMaskedTextBox1.SelectionLength = 0
        MaterialMaskedTextBox1.SelectionStart = 10
        MaterialMaskedTextBox1.ShortcutsEnabled = True
        MaterialMaskedTextBox1.Size = New Size(250, 48)
        MaterialMaskedTextBox1.SkipLiterals = True
        MaterialMaskedTextBox1.TabIndex = 1
        MaterialMaskedTextBox1.TabStop = False
        MaterialMaskedTextBox1.Text = "10/02/1998"
        MaterialMaskedTextBox1.TextAlign = HorizontalAlignment.Left
        MaterialMaskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals
        MaterialMaskedTextBox1.TrailingIcon = Nothing
        MaterialMaskedTextBox1.UseSystemPasswordChar = False
        MaterialMaskedTextBox1.ValidatingType = Nothing
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(498, 3)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(101, 19)
        MaterialLabel3.TabIndex = 0
        MaterialLabel3.Text = "Tela Esquisita"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(cbxAzul)
        TabPage4.Controls.Add(cbxGreen)
        TabPage4.Controls.Add(cbxOrange)
        TabPage4.Controls.Add(SwitchTheme)
        TabPage4.ImageIndex = 2
        TabPage4.Location = New Point(4, 39)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(1333, 880)
        TabPage4.TabIndex = 3
        TabPage4.Text = "CONFIGURAÇÕES"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' cbxAzul
        ' 
        cbxAzul.AutoSize = True
        cbxAzul.Depth = 0
        cbxAzul.Location = New Point(244, 334)
        cbxAzul.Margin = New Padding(0)
        cbxAzul.MouseLocation = New Point(-1, -1)
        cbxAzul.MouseState = MaterialSkin.MouseState.HOVER
        cbxAzul.Name = "cbxAzul"
        cbxAzul.ReadOnly = False
        cbxAzul.Ripple = True
        cbxAzul.Size = New Size(94, 37)
        cbxAzul.TabIndex = 3
        cbxAzul.Text = "Cor Azul"
        cbxAzul.UseVisualStyleBackColor = True
        ' 
        ' cbxGreen
        ' 
        cbxGreen.AutoSize = True
        cbxGreen.Depth = 0
        cbxGreen.Location = New Point(244, 283)
        cbxGreen.Margin = New Padding(0)
        cbxGreen.MouseLocation = New Point(-1, -1)
        cbxGreen.MouseState = MaterialSkin.MouseState.HOVER
        cbxGreen.Name = "cbxGreen"
        cbxGreen.ReadOnly = False
        cbxGreen.Ripple = True
        cbxGreen.Size = New Size(103, 37)
        cbxGreen.TabIndex = 2
        cbxGreen.Text = "Cor Verde"
        cbxGreen.UseVisualStyleBackColor = True
        ' 
        ' cbxOrange
        ' 
        cbxOrange.AutoSize = True
        cbxOrange.Depth = 0
        cbxOrange.Location = New Point(244, 229)
        cbxOrange.Margin = New Padding(0)
        cbxOrange.MouseLocation = New Point(-1, -1)
        cbxOrange.MouseState = MaterialSkin.MouseState.HOVER
        cbxOrange.Name = "cbxOrange"
        cbxOrange.ReadOnly = False
        cbxOrange.Ripple = True
        cbxOrange.Size = New Size(117, 37)
        cbxOrange.TabIndex = 1
        cbxOrange.Text = "Cor Laranja"
        cbxOrange.UseVisualStyleBackColor = True
        ' 
        ' SwitchTheme
        ' 
        SwitchTheme.AutoSize = True
        SwitchTheme.Depth = 0
        SwitchTheme.Location = New Point(244, 150)
        SwitchTheme.Margin = New Padding(0)
        SwitchTheme.MouseLocation = New Point(-1, -1)
        SwitchTheme.MouseState = MaterialSkin.MouseState.HOVER
        SwitchTheme.Name = "SwitchTheme"
        SwitchTheme.Ripple = True
        SwitchTheme.Size = New Size(140, 37)
        SwitchTheme.TabIndex = 0
        SwitchTheme.Text = "Tema Claro"
        SwitchTheme.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "base-de-dados.png")
        ImageList1.Images.SetKeyName(1, "comercio-eletronico.png")
        ImageList1.Images.SetKeyName(2, "computador.png")
        ImageList1.Images.SetKeyName(3, "dados.png")
        ImageList1.Images.SetKeyName(4, "distribuicao.png")
        ImageList1.Images.SetKeyName(5, "grafico-de-pizza (1).png")
        ImageList1.Images.SetKeyName(6, "grafico-de-pizza.png")
        ImageList1.Images.SetKeyName(7, "ponto-de-venda.png")
        ImageList1.Images.SetKeyName(8, "transacao.png")
        ' 
        ' lblHoras
        ' 
        lblHoras.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHoras.AutoSize = True
        lblHoras.BackColor = Color.Transparent
        lblHoras.Depth = 0
        lblHoras.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblHoras.Location = New Point(1228, 41)
        lblHoras.MouseState = MaterialSkin.MouseState.HOVER
        lblHoras.Name = "lblHoras"
        lblHoras.Size = New Size(116, 19)
        lblHoras.TabIndex = 10
        lblHoras.Text = "MaterialLabel17"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1347, 1014)
        Controls.Add(lblHoras)
        Controls.Add(MaterialTabControl1)
        DrawerAutoHide = False
        DrawerAutoShow = True
        DrawerIsOpen = True
        DrawerShowIconsWhenHidden = True
        DrawerTabControl = MaterialTabControl1
        FormStyle = FormStyles.ActionBar_64
        Name = "Dashboard"
        Padding = New Padding(3, 88, 3, 3)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        MaterialCard4.ResumeLayout(False)
        MaterialCard4.PerformLayout()
        MaterialCard3.ResumeLayout(False)
        MaterialCard3.PerformLayout()
        MaterialCard1.ResumeLayout(False)
        MaterialCard1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialMultiLineTextBox1 As MaterialSkin.Controls.MaterialMultiLineTextBox
    Friend WithEvents MaterialMaskedTextBox1 As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txt_search As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btn_limpar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_delete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btn_salvar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_ProName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtp_ExpDate As MaterialSkin.Controls.MaterialMaskedTextBox
    Friend WithEvents txt_proCode As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Check_Status As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txt_price As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txt_proGroup As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btn_criar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbxOrange As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents SwitchTheme As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard2 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialCard3 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialCard4 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btn_cadshow As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cbxAzul As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents cbxGreen As MaterialSkin.Controls.MaterialCheckbox
    Friend WithEvents lblHoras As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
