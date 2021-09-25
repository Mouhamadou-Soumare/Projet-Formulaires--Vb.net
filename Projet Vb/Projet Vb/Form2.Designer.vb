<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.LblNom = New System.Windows.Forms.Label()
        Me.LblPren = New System.Windows.Forms.Label()
        Me.LblAdres = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdNom = New System.Windows.Forms.TextBox()
        Me.CmdAdres = New System.Windows.Forms.TextBox()
        Me.CmdPren = New System.Windows.Forms.TextBox()
        Me.LblCp = New System.Windows.Forms.Label()
        Me.CmdCp = New System.Windows.Forms.TextBox()
        Me.LblVille = New System.Windows.Forms.Label()
        Me.CmdVille = New System.Windows.Forms.TextBox()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnAbando = New System.Windows.Forms.Button()
        Me.BtnContinuer = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(70, 135)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(32, 13)
        Me.LblNom.TabIndex = 0
        Me.LblNom.Text = "Nom:"
        '
        'LblPren
        '
        Me.LblPren.AutoSize = True
        Me.LblPren.Location = New System.Drawing.Point(70, 195)
        Me.LblPren.Name = "LblPren"
        Me.LblPren.Size = New System.Drawing.Size(46, 13)
        Me.LblPren.TabIndex = 1
        Me.LblPren.Text = "Prenom:"
        '
        'LblAdres
        '
        Me.LblAdres.AutoSize = True
        Me.LblAdres.Location = New System.Drawing.Point(70, 254)
        Me.LblAdres.Name = "LblAdres"
        Me.LblAdres.Size = New System.Drawing.Size(48, 13)
        Me.LblAdres.TabIndex = 2
        Me.LblAdres.Text = "Adresse:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inscription"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(676, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'cmdNom
        '
        Me.cmdNom.Location = New System.Drawing.Point(208, 128)
        Me.cmdNom.Name = "cmdNom"
        Me.cmdNom.Size = New System.Drawing.Size(139, 20)
        Me.cmdNom.TabIndex = 0
        '
        'CmdAdres
        '
        Me.CmdAdres.Location = New System.Drawing.Point(208, 247)
        Me.CmdAdres.Name = "CmdAdres"
        Me.CmdAdres.Size = New System.Drawing.Size(301, 20)
        Me.CmdAdres.TabIndex = 2
        '
        'CmdPren
        '
        Me.CmdPren.Location = New System.Drawing.Point(208, 192)
        Me.CmdPren.Name = "CmdPren"
        Me.CmdPren.Size = New System.Drawing.Size(139, 20)
        Me.CmdPren.TabIndex = 1
        '
        'LblCp
        '
        Me.LblCp.AutoSize = True
        Me.LblCp.Location = New System.Drawing.Point(70, 315)
        Me.LblCp.Name = "LblCp"
        Me.LblCp.Size = New System.Drawing.Size(73, 13)
        Me.LblCp.TabIndex = 8
        Me.LblCp.Text = "Code Postale:"
        '
        'CmdCp
        '
        Me.CmdCp.Location = New System.Drawing.Point(208, 308)
        Me.CmdCp.Name = "CmdCp"
        Me.CmdCp.Size = New System.Drawing.Size(139, 20)
        Me.CmdCp.TabIndex = 3
        '
        'LblVille
        '
        Me.LblVille.AutoSize = True
        Me.LblVille.Location = New System.Drawing.Point(70, 370)
        Me.LblVille.Name = "LblVille"
        Me.LblVille.Size = New System.Drawing.Size(29, 13)
        Me.LblVille.TabIndex = 10
        Me.LblVille.Text = "Ville:"
        '
        'CmdVille
        '
        Me.CmdVille.Location = New System.Drawing.Point(208, 363)
        Me.CmdVille.Name = "CmdVille"
        Me.CmdVille.Size = New System.Drawing.Size(139, 20)
        Me.CmdVille.TabIndex = 4
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(73, 420)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(29, 13)
        Me.LblAge.TabIndex = 12
        Me.LblAge.Text = "Age:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {" 18", " 19", " 20", " 21", " 22", " 23", " 24", " 25", " 26", " 27", " 28", " 29", " 30", " 31", " 32", " 33", " 34", " 35", " 36", " 37", " 38", " 39", " 40", " 41", " 42", " 43", " 44", " 45", " 46", " 47", " 48", " 49", " 50", " 51", " 52", " 53", " 54", " 55"})
        Me.ComboBox1.Location = New System.Drawing.Point(208, 411)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(139, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'BtnAbando
        '
        Me.BtnAbando.Location = New System.Drawing.Point(102, 497)
        Me.BtnAbando.Name = "BtnAbando"
        Me.BtnAbando.Size = New System.Drawing.Size(111, 34)
        Me.BtnAbando.TabIndex = 13
        Me.BtnAbando.Text = "Abandonner"
        Me.BtnAbando.UseVisualStyleBackColor = True
        '
        'BtnContinuer
        '
        Me.BtnContinuer.Location = New System.Drawing.Point(333, 497)
        Me.BtnContinuer.Name = "BtnContinuer"
        Me.BtnContinuer.Size = New System.Drawing.Size(122, 33)
        Me.BtnContinuer.TabIndex = 14
        Me.BtnContinuer.Text = "Continuer"
        Me.BtnContinuer.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(-24, 547)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(676, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 559)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 560)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 9)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Informations Obligatoires"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(53, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(53, 192)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(53, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(53, 363)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(53, 411)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 13)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "*"
        '
        'Timer1
        '
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 581)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnContinuer)
        Me.Controls.Add(Me.BtnAbando)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LblAge)
        Me.Controls.Add(Me.CmdVille)
        Me.Controls.Add(Me.LblVille)
        Me.Controls.Add(Me.CmdCp)
        Me.Controls.Add(Me.LblCp)
        Me.Controls.Add(Me.CmdPren)
        Me.Controls.Add(Me.CmdAdres)
        Me.Controls.Add(Me.cmdNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAdres)
        Me.Controls.Add(Me.LblPren)
        Me.Controls.Add(Me.LblNom)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Insciption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNom As Label
    Friend WithEvents LblPren As Label
    Friend WithEvents LblAdres As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdNom As TextBox
    Friend WithEvents CmdAdres As TextBox
    Friend WithEvents CmdPren As TextBox
    Friend WithEvents LblCp As Label
    Friend WithEvents CmdCp As TextBox
    Friend WithEvents LblVille As Label
    Friend WithEvents CmdVille As TextBox
    Friend WithEvents LblAge As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnAbando As Button
    Friend WithEvents BtnContinuer As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Timer1 As Timer
End Class
