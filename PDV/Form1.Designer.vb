<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        MaterialSwitch1 = New MaterialSkin.Controls.MaterialSwitch()
        MaterialCard1 = New MaterialSkin.Controls.MaterialCard()
        TabPage2 = New TabPage()
        MaterialFloatingActionButton1 = New MaterialSkin.Controls.MaterialFloatingActionButton()
        MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Location = New Point(6, 118)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(969, 438)
        MaterialTabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(MaterialButton1)
        TabPage1.Controls.Add(MaterialSwitch1)
        TabPage1.Controls.Add(MaterialCard1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(961, 410)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Cadastro basico"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(355, 131)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(158, 36)
        MaterialButton1.TabIndex = 1
        MaterialButton1.Text = "MaterialButton1"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialSwitch1
        ' 
        MaterialSwitch1.AutoSize = True
        MaterialSwitch1.Depth = 0
        MaterialSwitch1.Location = New Point(340, 57)
        MaterialSwitch1.Margin = New Padding(0)
        MaterialSwitch1.MouseLocation = New Point(-1, -1)
        MaterialSwitch1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialSwitch1.Name = "MaterialSwitch1"
        MaterialSwitch1.Ripple = True
        MaterialSwitch1.Size = New Size(173, 37)
        MaterialSwitch1.TabIndex = 0
        MaterialSwitch1.Text = "MaterialSwitch1"
        MaterialSwitch1.UseVisualStyleBackColor = True
        ' 
        ' MaterialCard1
        ' 
        MaterialCard1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        MaterialCard1.Depth = 0
        MaterialCard1.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        MaterialCard1.Location = New Point(118, 57)
        MaterialCard1.Margin = New Padding(14)
        MaterialCard1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialCard1.Name = "MaterialCard1"
        MaterialCard1.Padding = New Padding(14)
        MaterialCard1.Size = New Size(198, 255)
        MaterialCard1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(MaterialFloatingActionButton1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(961, 410)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Avançado"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' MaterialFloatingActionButton1
        ' 
        MaterialFloatingActionButton1.Depth = 0
        MaterialFloatingActionButton1.Icon = Nothing
        MaterialFloatingActionButton1.Location = New Point(58, 71)
        MaterialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialFloatingActionButton1.Name = "MaterialFloatingActionButton1"
        MaterialFloatingActionButton1.Size = New Size(56, 56)
        MaterialFloatingActionButton1.TabIndex = 0
        MaterialFloatingActionButton1.Text = "MaterialFloatingActionButton1"
        MaterialFloatingActionButton1.UseVisualStyleBackColor = True
        ' 
        ' MaterialTabSelector1
        ' 
        MaterialTabSelector1.BaseTabControl = MaterialTabControl1
        MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        MaterialTabSelector1.Depth = 0
        MaterialTabSelector1.Font = New Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTabSelector1.Location = New Point(0, 64)
        MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabSelector1.Name = "MaterialTabSelector1"
        MaterialTabSelector1.Size = New Size(985, 48)
        MaterialTabSelector1.TabIndex = 1
        MaterialTabSelector1.Text = "MaterialTabSelector1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(981, 647)
        Controls.Add(MaterialTabSelector1)
        Controls.Add(MaterialTabControl1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialExpansionPanel1 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Private WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialSwitch1 As MaterialSkin.Controls.MaterialSwitch
    Friend WithEvents MaterialCard1 As MaterialSkin.Controls.MaterialCard
    Friend WithEvents MaterialFloatingActionButton1 As MaterialSkin.Controls.MaterialFloatingActionButton

End Class
