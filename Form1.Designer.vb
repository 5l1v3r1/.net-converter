<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.csR = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vbR = New System.Windows.Forms.RadioButton()
        Me.TXTC = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.TXTVB = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBNETCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripSplitButton()
        Me.SavecsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavevbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TXTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXTVB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'csR
        '
        Me.csR.AutoSize = True
        Me.csR.Checked = True
        Me.csR.ForeColor = System.Drawing.Color.White
        Me.csR.Location = New System.Drawing.Point(14, 17)
        Me.csR.Name = "csR"
        Me.csR.Size = New System.Drawing.Size(99, 19)
        Me.csR.TabIndex = 0
        Me.csR.TabStop = True
        Me.csR.Text = "C# -> VB.NET"
        Me.csR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.vbR)
        Me.GroupBox1.Controls.Add(Me.csR)
        Me.GroupBox1.Location = New System.Drawing.Point(139, 486)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(129, 70)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'vbR
        '
        Me.vbR.AutoSize = True
        Me.vbR.ForeColor = System.Drawing.Color.White
        Me.vbR.Location = New System.Drawing.Point(14, 43)
        Me.vbR.Name = "vbR"
        Me.vbR.Size = New System.Drawing.Size(99, 19)
        Me.vbR.TabIndex = 1
        Me.vbR.Text = "VB.NET -> C#"
        Me.vbR.UseVisualStyleBackColor = True
        '
        'TXTC
        '
        Me.TXTC.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TXTC.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]" &
    "*(?<range>:)\s*(?<range>[^;]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TXTC.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.TXTC.BackBrush = Nothing
        Me.TXTC.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2
        Me.TXTC.CharHeight = 14
        Me.TXTC.CharWidth = 8
        Me.TXTC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTC.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TXTC.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.TXTC.IsReplaceMode = False
        Me.TXTC.Language = FastColoredTextBoxNS.Language.CSharp
        Me.TXTC.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.TXTC.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(123)
        Me.TXTC.LineNumberColor = System.Drawing.Color.Red
        Me.TXTC.Location = New System.Drawing.Point(12, 41)
        Me.TXTC.Name = "TXTC"
        Me.TXTC.Paddings = New System.Windows.Forms.Padding(0)
        Me.TXTC.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.TXTC.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(125)
        Me.TXTC.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTC.ServiceColors = CType(resources.GetObject("TXTC.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.TXTC.Size = New System.Drawing.Size(513, 439)
        Me.TXTC.TabIndex = 3
        Me.TXTC.Zoom = 100
        '
        'TXTVB
        '
        Me.TXTVB.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.TXTVB.AutoIndentCharsPatterns = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*[\w\.\(\)]+\s*(?<range>=)\s*(?<range>.+)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TXTVB.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.TXTVB.BackBrush = Nothing
        Me.TXTVB.CharHeight = 14
        Me.TXTVB.CharWidth = 8
        Me.TXTVB.CommentPrefix = "'"
        Me.TXTVB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTVB.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.TXTVB.IsReplaceMode = False
        Me.TXTVB.Language = FastColoredTextBoxNS.Language.VB
        Me.TXTVB.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.TXTVB.LineNumberColor = System.Drawing.Color.Red
        Me.TXTVB.Location = New System.Drawing.Point(546, 41)
        Me.TXTVB.Name = "TXTVB"
        Me.TXTVB.Paddings = New System.Windows.Forms.Padding(0)
        Me.TXTVB.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.TXTVB.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTVB.ServiceColors = CType(resources.GetObject("TXTVB.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.TXTVB.Size = New System.Drawing.Size(509, 440)
        Me.TXTVB.TabIndex = 4
        Me.TXTVB.Zoom = 100
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1067, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CCodeToolStripMenuItem, Me.VBNETCodeToolStripMenuItem})
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(75, 22)
        Me.ToolStripLabel1.Text = "Ouvrir.."
        '
        'CCodeToolStripMenuItem
        '
        Me.CCodeToolStripMenuItem.Name = "CCodeToolStripMenuItem"
        Me.CCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CCodeToolStripMenuItem.Text = "C# Code"
        '
        'VBNETCodeToolStripMenuItem
        '
        Me.VBNETCodeToolStripMenuItem.Name = "VBNETCodeToolStripMenuItem"
        Me.VBNETCodeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VBNETCodeToolStripMenuItem.Text = "VB.NET Code"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavecsToolStripMenuItem, Me.SavevbToolStripMenuItem})
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripLabel2.Image = CType(resources.GetObject("ToolStripLabel2.Image"), System.Drawing.Image)
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(137, 22)
        Me.ToolStripLabel2.Text = "Sauvegarder sous.."
        '
        'SavecsToolStripMenuItem
        '
        Me.SavecsToolStripMenuItem.Name = "SavecsToolStripMenuItem"
        Me.SavecsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SavecsToolStripMenuItem.Text = "Save.cs"
        '
        'SavevbToolStripMenuItem
        '
        Me.SavevbToolStripMenuItem.Name = "SavevbToolStripMenuItem"
        Me.SavevbToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SavevbToolStripMenuItem.Text = "Save.vb"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(274, 487)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 69)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(445, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Autheur"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(272, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Effacer tout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(99, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Convertir le code"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 486)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 568)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TXTVB)
        Me.Controls.Add(Me.TXTC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C# <> VB.net Converter | By @EaWhiteHat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TXTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXTVB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents csR As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents vbR As System.Windows.Forms.RadioButton
    Friend WithEvents TXTC As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents TXTVB As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBNETCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents SavecsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavevbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Protected WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PictureBox1 As PictureBox
End Class
