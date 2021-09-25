<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnInscription = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnBilan = New System.Windows.Forms.Button()
        Me.BtnFin = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnEtatactuel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInscription
        '
        Me.BtnInscription.Location = New System.Drawing.Point(94, 179)
        Me.BtnInscription.Name = "BtnInscription"
        Me.BtnInscription.Size = New System.Drawing.Size(158, 67)
        Me.BtnInscription.TabIndex = 0
        Me.BtnInscription.Text = "Nouvelle inscription"
        Me.BtnInscription.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Location = New System.Drawing.Point(94, 356)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(158, 67)
        Me.BtnModifier.TabIndex = 1
        Me.BtnModifier.Text = "Modifier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supprimer "
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnBilan
        '
        Me.BtnBilan.Location = New System.Drawing.Point(361, 446)
        Me.BtnBilan.Name = "BtnBilan"
        Me.BtnBilan.Size = New System.Drawing.Size(158, 67)
        Me.BtnBilan.TabIndex = 2
        Me.BtnBilan.Text = "Bilan"
        Me.BtnBilan.UseVisualStyleBackColor = True
        '
        'BtnFin
        '
        Me.BtnFin.Location = New System.Drawing.Point(598, 356)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(158, 67)
        Me.BtnFin.TabIndex = 3
        Me.BtnFin.Text = "Fin des inscriptions"
        Me.BtnFin.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(598, 179)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(158, 67)
        Me.BtnQuitter.TabIndex = 4
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'BtnEtatactuel
        '
        Me.BtnEtatactuel.Location = New System.Drawing.Point(361, 121)
        Me.BtnEtatactuel.Name = "BtnEtatactuel"
        Me.BtnEtatactuel.Size = New System.Drawing.Size(158, 67)
        Me.BtnEtatactuel.TabIndex = 5
        Me.BtnEtatactuel.Text = "Etat actuel des inscriptions"
        Me.BtnEtatactuel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(361, 242)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, -28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 112)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-104, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1204, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 574)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnEtatactuel)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnFin)
        Me.Controls.Add(Me.BtnBilan)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnInscription)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Menu d'acceuil"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInscription As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnBilan As Button
    Friend WithEvents BtnFin As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnEtatactuel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
