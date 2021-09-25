<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtFac = New System.Windows.Forms.TextBox()
        Me.LblRegion = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LvOral = New System.Windows.Forms.ListView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LvEcrits = New System.Windows.Forms.ListView()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblAdress = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblCp = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblVille = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblPren = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnEnregistrer = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtFac)
        Me.GroupBox1.Controls.Add(Me.LblRegion)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.LvOral)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LvEcrits)
        Me.GroupBox1.Controls.Add(Me.LblAge)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.LblAdress)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LblCp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblVille)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblPren)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LblNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 369)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Données Saisie"
        '
        'TxtFac
        '
        Me.TxtFac.Location = New System.Drawing.Point(389, 310)
        Me.TxtFac.Name = "TxtFac"
        Me.TxtFac.Size = New System.Drawing.Size(124, 20)
        Me.TxtFac.TabIndex = 20
        '
        'LblRegion
        '
        Me.LblRegion.AutoSize = True
        Me.LblRegion.Location = New System.Drawing.Point(400, 33)
        Me.LblRegion.Name = "LblRegion"
        Me.LblRegion.Size = New System.Drawing.Size(45, 13)
        Me.LblRegion.TabIndex = 19
        Me.LblRegion.Text = "Label19"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(306, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Région:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(398, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(101, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Epreuves Facultatif:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LvOral
        '
        Me.LvOral.HideSelection = False
        Me.LvOral.Location = New System.Drawing.Point(475, 110)
        Me.LvOral.Name = "LvOral"
        Me.LvOral.Size = New System.Drawing.Size(175, 158)
        Me.LvOral.TabIndex = 15
        Me.LvOral.UseCompatibleStateImageBehavior = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(481, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Epreuves Orales:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(289, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Epreuves Ecrites:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LvEcrits
        '
        Me.LvEcrits.HideSelection = False
        Me.LvEcrits.Location = New System.Drawing.Point(283, 110)
        Me.LvEcrits.Name = "LvEcrits"
        Me.LvEcrits.Size = New System.Drawing.Size(162, 158)
        Me.LvEcrits.TabIndex = 12
        Me.LvEcrits.UseCompatibleStateImageBehavior = False
        '
        'LblAge
        '
        Me.LblAge.AutoSize = True
        Me.LblAge.Location = New System.Drawing.Point(121, 217)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(45, 13)
        Me.LblAge.TabIndex = 11
        Me.LblAge.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Age" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblAdress
        '
        Me.LblAdress.AutoSize = True
        Me.LblAdress.Location = New System.Drawing.Point(118, 257)
        Me.LblAdress.Name = "LblAdress"
        Me.LblAdress.Size = New System.Drawing.Size(48, 26)
        Me.LblAdress.TabIndex = 9
        Me.LblAdress.Text = "Label 10" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Adresse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblCp
        '
        Me.LblCp.AutoSize = True
        Me.LblCp.Location = New System.Drawing.Point(121, 173)
        Me.LblCp.Name = "LblCp"
        Me.LblCp.Size = New System.Drawing.Size(39, 13)
        Me.LblCp.TabIndex = 7
        Me.LblCp.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Code Postal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblVille
        '
        Me.LblVille.AutoSize = True
        Me.LblVille.Location = New System.Drawing.Point(121, 130)
        Me.LblVille.Name = "LblVille"
        Me.LblVille.Size = New System.Drawing.Size(39, 13)
        Me.LblVille.TabIndex = 5
        Me.LblVille.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ville" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblPren
        '
        Me.LblPren.AutoSize = True
        Me.LblPren.Location = New System.Drawing.Point(121, 80)
        Me.LblPren.Name = "LblPren"
        Me.LblPren.Size = New System.Drawing.Size(39, 13)
        Me.LblPren.TabIndex = 3
        Me.LblPren.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(121, 33)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(39, 13)
        Me.LblNom.TabIndex = 1
        Me.LblNom.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(252, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(189, 33)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Récapitulatif"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(-7, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(676, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = resources.GetString("Label17.Text")
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(24, 478)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnuler.TabIndex = 6
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnEnregistrer
        '
        Me.BtnEnregistrer.Location = New System.Drawing.Point(206, 478)
        Me.BtnEnregistrer.Name = "BtnEnregistrer"
        Me.BtnEnregistrer.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnregistrer.TabIndex = 7
        Me.BtnEnregistrer.Text = "Enregistrer "
        Me.BtnEnregistrer.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(116, 478)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(75, 23)
        Me.BtnRetour.TabIndex = 8
        Me.BtnRetour.Text = "Retour"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 513)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnEnregistrer)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "Récapitulatif"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblAdress As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblCp As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblVille As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblPren As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LvOral As ListView
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LvEcrits As ListView
    Friend WithEvents LblAge As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LblRegion As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnEnregistrer As Button
    Friend WithEvents BtnRetour As Button
    Friend WithEvents TxtFac As TextBox
End Class
