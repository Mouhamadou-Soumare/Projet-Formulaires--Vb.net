<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNbreInscr = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbMatiere = New System.Windows.Forms.RadioButton()
        Me.RbIndividuel = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCand = New System.Windows.Forms.Label()
        Me.LblMatière = New System.Windows.Forms.Label()
        Me.CbxMat = New System.Windows.Forms.ComboBox()
        Me.CbxCand = New System.Windows.Forms.ComboBox()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.BtnAfficher = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(189, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 33)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Bilan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-344, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1225, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre d'inscriptions enregistrées  :"
        '
        'TxtNbreInscr
        '
        Me.TxtNbreInscr.Location = New System.Drawing.Point(286, 90)
        Me.TxtNbreInscr.Name = "TxtNbreInscr"
        Me.TxtNbreInscr.Size = New System.Drawing.Size(100, 20)
        Me.TxtNbreInscr.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbMatiere)
        Me.Panel1.Controls.Add(Me.RbIndividuel)
        Me.Panel1.Location = New System.Drawing.Point(105, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 75)
        Me.Panel1.TabIndex = 25
        '
        'RbMatiere
        '
        Me.RbMatiere.AutoSize = True
        Me.RbMatiere.Location = New System.Drawing.Point(31, 35)
        Me.RbMatiere.Name = "RbMatiere"
        Me.RbMatiere.Size = New System.Drawing.Size(86, 17)
        Me.RbMatiere.TabIndex = 1
        Me.RbMatiere.TabStop = True
        Me.RbMatiere.Text = "Bilan Matière"
        Me.RbMatiere.UseVisualStyleBackColor = True
        '
        'RbIndividuel
        '
        Me.RbIndividuel.AutoSize = True
        Me.RbIndividuel.Location = New System.Drawing.Point(31, 12)
        Me.RbIndividuel.Name = "RbIndividuel"
        Me.RbIndividuel.Size = New System.Drawing.Size(96, 17)
        Me.RbIndividuel.TabIndex = 0
        Me.RbIndividuel.TabStop = True
        Me.RbIndividuel.Text = "Bilan Individuel"
        Me.RbIndividuel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choix du bilan :"
        '
        'LblCand
        '
        Me.LblCand.AutoSize = True
        Me.LblCand.Location = New System.Drawing.Point(102, 223)
        Me.LblCand.Name = "LblCand"
        Me.LblCand.Size = New System.Drawing.Size(55, 13)
        Me.LblCand.TabIndex = 26
        Me.LblCand.Text = "Candidat :"
        '
        'LblMatière
        '
        Me.LblMatière.AutoSize = True
        Me.LblMatière.Location = New System.Drawing.Point(102, 223)
        Me.LblMatière.Name = "LblMatière"
        Me.LblMatière.Size = New System.Drawing.Size(48, 13)
        Me.LblMatière.TabIndex = 27
        Me.LblMatière.Text = "Matière :"
        '
        'CbxMat
        '
        Me.CbxMat.FormattingEnabled = True
        Me.CbxMat.Location = New System.Drawing.Point(195, 220)
        Me.CbxMat.Name = "CbxMat"
        Me.CbxMat.Size = New System.Drawing.Size(121, 21)
        Me.CbxMat.TabIndex = 28
        '
        'CbxCand
        '
        Me.CbxCand.FormattingEnabled = True
        Me.CbxCand.Location = New System.Drawing.Point(195, 220)
        Me.CbxCand.Name = "CbxCand"
        Me.CbxCand.Size = New System.Drawing.Size(191, 21)
        Me.CbxCand.TabIndex = 29
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(88, 272)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(162, 34)
        Me.BtnRetour.TabIndex = 30
        Me.BtnRetour.Text = "Retour" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " à l'acceuil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'BtnAfficher
        '
        Me.BtnAfficher.Location = New System.Drawing.Point(256, 272)
        Me.BtnAfficher.Name = "BtnAfficher"
        Me.BtnAfficher.Size = New System.Drawing.Size(162, 34)
        Me.BtnAfficher.TabIndex = 31
        Me.BtnAfficher.Text = "Afficher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "le Bilan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAfficher.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 308)
        Me.Controls.Add(Me.BtnAfficher)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.CbxCand)
        Me.Controls.Add(Me.CbxMat)
        Me.Controls.Add(Me.LblMatière)
        Me.Controls.Add(Me.LblCand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtNbreInscr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form7"
        Me.Text = "Bilan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNbreInscr As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbMatiere As RadioButton
    Friend WithEvents RbIndividuel As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LblCand As Label
    Friend WithEvents LblMatière As Label
    Friend WithEvents CbxMat As ComboBox
    Friend WithEvents CbxCand As ComboBox
    Friend WithEvents BtnRetour As Button
    Friend WithEvents BtnAfficher As Button
End Class
