<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        tbx_email = New MaterialSkin.Controls.MaterialTextBox()
        btn_entrar = New MaterialSkin.Controls.MaterialButton()
        MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        tbx_senha = New MaterialSkin.Controls.MaterialTextBox()
        MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        SuspendLayout()
        ' 
        ' tbx_email
        ' 
        tbx_email.AnimateReadOnly = False
        tbx_email.BorderStyle = BorderStyle.None
        tbx_email.Depth = 0
        tbx_email.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        tbx_email.LeadingIcon = Nothing
        tbx_email.Location = New Point(85, 151)
        tbx_email.MaxLength = 50
        tbx_email.MouseState = MaterialSkin.MouseState.OUT
        tbx_email.Multiline = False
        tbx_email.Name = "tbx_email"
        tbx_email.Size = New Size(258, 50)
        tbx_email.TabIndex = 0
        tbx_email.Text = ""
        tbx_email.TrailingIcon = Nothing
        ' 
        ' btn_entrar
        ' 
        btn_entrar.AutoSize = False
        btn_entrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        btn_entrar.Depth = 0
        btn_entrar.HighEmphasis = True
        btn_entrar.Icon = Nothing
        btn_entrar.Location = New Point(85, 266)
        btn_entrar.Margin = New Padding(4, 6, 4, 6)
        btn_entrar.MouseState = MaterialSkin.MouseState.HOVER
        btn_entrar.Name = "btn_entrar"
        btn_entrar.NoAccentTextColor = Color.Empty
        btn_entrar.Size = New Size(258, 36)
        btn_entrar.TabIndex = 2
        btn_entrar.Text = "Entrar"
        btn_entrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        btn_entrar.UseAccentColor = False
        btn_entrar.UseVisualStyleBackColor = True
        ' 
        ' MaterialLabel1
        ' 
        MaterialLabel1.AutoSize = True
        MaterialLabel1.Depth = 0
        MaterialLabel1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel1.Location = New Point(115, 114)
        MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel1.Name = "MaterialLabel1"
        MaterialLabel1.Size = New Size(210, 19)
        MaterialLabel1.TabIndex = 2
        MaterialLabel1.Text = "Logar para acessar o sistema"
        ' 
        ' tbx_senha
        ' 
        tbx_senha.AnimateReadOnly = False
        tbx_senha.BorderStyle = BorderStyle.None
        tbx_senha.Depth = 0
        tbx_senha.Font = New Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel)
        tbx_senha.LeadingIcon = Nothing
        tbx_senha.Location = New Point(85, 207)
        tbx_senha.MaxLength = 50
        tbx_senha.MouseState = MaterialSkin.MouseState.OUT
        tbx_senha.Multiline = False
        tbx_senha.Name = "tbx_senha"
        tbx_senha.Password = True
        tbx_senha.Size = New Size(258, 50)
        tbx_senha.TabIndex = 1
        tbx_senha.Text = ""
        tbx_senha.TrailingIcon = Nothing
        ' 
        ' MaterialLabel2
        ' 
        MaterialLabel2.AutoSize = True
        MaterialLabel2.Depth = 0
        MaterialLabel2.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel2.Location = New Point(28, 166)
        MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel2.Name = "MaterialLabel2"
        MaterialLabel2.Size = New Size(41, 19)
        MaterialLabel2.TabIndex = 4
        MaterialLabel2.Text = "Email"
        ' 
        ' MaterialLabel3
        ' 
        MaterialLabel3.AutoSize = True
        MaterialLabel3.Depth = 0
        MaterialLabel3.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialLabel3.Location = New Point(28, 219)
        MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        MaterialLabel3.Name = "MaterialLabel3"
        MaterialLabel3.Size = New Size(46, 19)
        MaterialLabel3.TabIndex = 5
        MaterialLabel3.Text = "Senha"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 423)
        Controls.Add(MaterialLabel3)
        Controls.Add(MaterialLabel2)
        Controls.Add(tbx_senha)
        Controls.Add(MaterialLabel1)
        Controls.Add(btn_entrar)
        Controls.Add(tbx_email)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Login"
        Sizable = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbx_email As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btn_entrar As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbx_senha As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
End Class
