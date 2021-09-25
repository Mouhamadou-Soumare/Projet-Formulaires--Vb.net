<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.LblPren2 = New System.Windows.Forms.Label()
        Me.LblNom2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxRegion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GrpEcrit = New System.Windows.Forms.GroupBox()
        Me.CKEmath = New System.Windows.Forms.CheckBox()
        Me.CKEvb = New System.Windows.Forms.CheckBox()
        Me.CKEPweb = New System.Windows.Forms.CheckBox()
        Me.CkESyst = New System.Windows.Forms.CheckBox()
        Me.CKElgeJava = New System.Windows.Forms.CheckBox()
        Me.CkEResa = New System.Windows.Forms.CheckBox()
        Me.CKELgeC = New System.Windows.Forms.CheckBox()
        Me.ckEAlgo = New System.Windows.Forms.CheckBox()
        Me.CkEGest = New System.Windows.Forms.CheckBox()
        Me.ckEbd = New System.Windows.Forms.CheckBox()
        Me.CkEexpr = New System.Windows.Forms.CheckBox()
        Me.CKEdroit = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrpOral = New System.Windows.Forms.GroupBox()
        Me.CkORes = New System.Windows.Forms.CheckBox()
        Me.CkOMath = New System.Windows.Forms.CheckBox()
        Me.CkOSyst = New System.Windows.Forms.CheckBox()
        Me.CkOGest = New System.Windows.Forms.CheckBox()
        Me.CkOAng = New System.Windows.Forms.CheckBox()
        Me.CkOChinois = New System.Windows.Forms.CheckBox()
        Me.CkOdroit = New System.Windows.Forms.CheckBox()
        Me.CkOExpress = New System.Windows.Forms.CheckBox()
        Me.CkOesp = New System.Windows.Forms.CheckBox()
        Me.TxtNbreEcrits = New System.Windows.Forms.TextBox()
        Me.TxtNbreOrals = New System.Windows.Forms.TextBox()
        Me.GrpFac = New System.Windows.Forms.GroupBox()
        Me.CbxFacultatif = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RbNon = New System.Windows.Forms.RadioButton()
        Me.RbOui = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GrpEcrit.SuspendLayout()
        Me.GrpOral.SuspendLayout()
        Me.GrpFac.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblPren2
        '
        Me.LblPren2.AutoSize = True
        Me.LblPren2.Location = New System.Drawing.Point(152, 190)
        Me.LblPren2.Name = "LblPren2"
        Me.LblPren2.Size = New System.Drawing.Size(43, 13)
        Me.LblPren2.TabIndex = 0
        Me.LblPren2.Text = "Prénom"
        '
        'LblNom2
        '
        Me.LblNom2.AutoSize = True
        Me.LblNom2.Location = New System.Drawing.Point(152, 226)
        Me.LblNom2.Name = "LblNom2"
        Me.LblNom2.Size = New System.Drawing.Size(29, 13)
        Me.LblNom2.TabIndex = 1
        Me.LblNom2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Prénom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom :"
        '
        'CbxRegion
        '
        Me.CbxRegion.FormattingEnabled = True
        Me.CbxRegion.Items.AddRange(New Object() {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"})
        Me.CbxRegion.Location = New System.Drawing.Point(125, 253)
        Me.CbxRegion.Name = "CbxRegion"
        Me.CbxRegion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CbxRegion.Size = New System.Drawing.Size(121, 21)
        Me.CbxRegion.Sorted = True
        Me.CbxRegion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Région"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(328, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(192, 227)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oral"
        '
        'GrpEcrit
        '
        Me.GrpEcrit.Controls.Add(Me.CKEmath)
        Me.GrpEcrit.Controls.Add(Me.CKEvb)
        Me.GrpEcrit.Controls.Add(Me.CKEPweb)
        Me.GrpEcrit.Controls.Add(Me.CkESyst)
        Me.GrpEcrit.Controls.Add(Me.CKElgeJava)
        Me.GrpEcrit.Controls.Add(Me.CkEResa)
        Me.GrpEcrit.Controls.Add(Me.CKELgeC)
        Me.GrpEcrit.Controls.Add(Me.ckEAlgo)
        Me.GrpEcrit.Controls.Add(Me.CkEGest)
        Me.GrpEcrit.Controls.Add(Me.ckEbd)
        Me.GrpEcrit.Controls.Add(Me.CkEexpr)
        Me.GrpEcrit.Controls.Add(Me.CKEdroit)
        Me.GrpEcrit.Location = New System.Drawing.Point(0, 21)
        Me.GrpEcrit.Name = "GrpEcrit"
        Me.GrpEcrit.Size = New System.Drawing.Size(165, 363)
        Me.GrpEcrit.TabIndex = 23
        Me.GrpEcrit.TabStop = False
        Me.GrpEcrit.Text = "Ecrit"
        '
        'CKEmath
        '
        Me.CKEmath.AutoSize = True
        Me.CKEmath.Location = New System.Drawing.Point(6, 208)
        Me.CKEmath.Name = "CKEmath"
        Me.CKEmath.Size = New System.Drawing.Size(98, 17)
        Me.CKEmath.TabIndex = 12
        Me.CKEmath.Text = "Mathématiques"
        Me.CKEmath.UseVisualStyleBackColor = True
        '
        'CKEvb
        '
        Me.CKEvb.AutoSize = True
        Me.CKEvb.Location = New System.Drawing.Point(6, 298)
        Me.CKEvb.Name = "CKEvb"
        Me.CKEvb.Size = New System.Drawing.Size(103, 17)
        Me.CKEvb.TabIndex = 21
        Me.CKEvb.Text = "Visual Basic.Net"
        Me.CKEvb.UseVisualStyleBackColor = True
        '
        'CKEPweb
        '
        Me.CKEPweb.AutoSize = True
        Me.CKEPweb.Location = New System.Drawing.Point(6, 231)
        Me.CKEPweb.Name = "CKEPweb"
        Me.CKEPweb.Size = New System.Drawing.Size(122, 17)
        Me.CKEPweb.TabIndex = 18
        Me.CKEPweb.Text = "Programmation Web"
        Me.CKEPweb.UseVisualStyleBackColor = True
        '
        'CkESyst
        '
        Me.CkESyst.AutoSize = True
        Me.CkESyst.Location = New System.Drawing.Point(6, 277)
        Me.CkESyst.Name = "CkESyst"
        Me.CkESyst.Size = New System.Drawing.Size(66, 17)
        Me.CkESyst.TabIndex = 20
        Me.CkESyst.Text = "Système"
        Me.CkESyst.UseVisualStyleBackColor = True
        '
        'CKElgeJava
        '
        Me.CKElgeJava.AutoSize = True
        Me.CKElgeJava.Location = New System.Drawing.Point(6, 185)
        Me.CKElgeJava.Name = "CKElgeJava"
        Me.CKElgeJava.Size = New System.Drawing.Size(94, 17)
        Me.CKElgeJava.TabIndex = 11
        Me.CKElgeJava.Text = "Langage Java"
        Me.CKElgeJava.UseVisualStyleBackColor = True
        '
        'CkEResa
        '
        Me.CkEResa.AutoSize = True
        Me.CkEResa.Location = New System.Drawing.Point(6, 254)
        Me.CkEResa.Name = "CkEResa"
        Me.CkEResa.Size = New System.Drawing.Size(63, 17)
        Me.CkEResa.TabIndex = 19
        Me.CkEResa.Text = "Réseau"
        Me.CkEResa.UseVisualStyleBackColor = True
        '
        'CKELgeC
        '
        Me.CKELgeC.AutoSize = True
        Me.CKELgeC.Location = New System.Drawing.Point(6, 162)
        Me.CKELgeC.Name = "CKELgeC"
        Me.CKELgeC.Size = New System.Drawing.Size(78, 17)
        Me.CKELgeC.TabIndex = 10
        Me.CKELgeC.Text = "Langage C"
        Me.CKELgeC.UseVisualStyleBackColor = True
        '
        'ckEAlgo
        '
        Me.ckEAlgo.AutoSize = True
        Me.ckEAlgo.Location = New System.Drawing.Point(6, 47)
        Me.ckEAlgo.Name = "ckEAlgo"
        Me.ckEAlgo.Size = New System.Drawing.Size(89, 17)
        Me.ckEAlgo.TabIndex = 5
        Me.ckEAlgo.Text = "Algorithmique"
        Me.ckEAlgo.UseVisualStyleBackColor = True
        '
        'CkEGest
        '
        Me.CkEGest.AutoSize = True
        Me.CkEGest.Location = New System.Drawing.Point(6, 139)
        Me.CkEGest.Name = "CkEGest"
        Me.CkEGest.Size = New System.Drawing.Size(62, 17)
        Me.CkEGest.TabIndex = 9
        Me.CkEGest.Text = "Gestion"
        Me.CkEGest.UseVisualStyleBackColor = True
        '
        'ckEbd
        '
        Me.ckEbd.AutoSize = True
        Me.ckEbd.Location = New System.Drawing.Point(6, 70)
        Me.ckEbd.Name = "ckEbd"
        Me.ckEbd.Size = New System.Drawing.Size(109, 17)
        Me.ckEbd.TabIndex = 6
        Me.ckEbd.Text = "Base de données"
        Me.ckEbd.UseVisualStyleBackColor = True
        '
        'CkEexpr
        '
        Me.CkEexpr.AutoSize = True
        Me.CkEexpr.Location = New System.Drawing.Point(6, 116)
        Me.CkEexpr.Name = "CkEexpr"
        Me.CkEexpr.Size = New System.Drawing.Size(77, 17)
        Me.CkEexpr.TabIndex = 8
        Me.CkEexpr.Text = "Expression"
        Me.CkEexpr.UseVisualStyleBackColor = True
        '
        'CKEdroit
        '
        Me.CKEdroit.AutoSize = True
        Me.CKEdroit.Location = New System.Drawing.Point(6, 93)
        Me.CKEdroit.Name = "CKEdroit"
        Me.CKEdroit.Size = New System.Drawing.Size(48, 17)
        Me.CKEdroit.TabIndex = 7
        Me.CKEdroit.Text = "Droit"
        Me.CKEdroit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(140, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Epreuve du concours"
        '
        'GrpOral
        '
        Me.GrpOral.Controls.Add(Me.CkORes)
        Me.GrpOral.Controls.Add(Me.CkOMath)
        Me.GrpOral.Controls.Add(Me.CkOSyst)
        Me.GrpOral.Controls.Add(Me.CkOGest)
        Me.GrpOral.Controls.Add(Me.CkOAng)
        Me.GrpOral.Controls.Add(Me.CkOChinois)
        Me.GrpOral.Controls.Add(Me.CkOdroit)
        Me.GrpOral.Controls.Add(Me.CkOExpress)
        Me.GrpOral.Controls.Add(Me.CkOesp)
        Me.GrpOral.Location = New System.Drawing.Point(343, 21)
        Me.GrpOral.Name = "GrpOral"
        Me.GrpOral.Size = New System.Drawing.Size(160, 363)
        Me.GrpOral.TabIndex = 16
        Me.GrpOral.TabStop = False
        Me.GrpOral.Text = "Oral"
        '
        'CkORes
        '
        Me.CkORes.AutoSize = True
        Me.CkORes.Location = New System.Drawing.Point(6, 180)
        Me.CkORes.Name = "CkORes"
        Me.CkORes.Size = New System.Drawing.Size(63, 17)
        Me.CkORes.TabIndex = 30
        Me.CkORes.Text = "Réseau"
        Me.CkORes.UseVisualStyleBackColor = True
        '
        'CkOMath
        '
        Me.CkOMath.AutoSize = True
        Me.CkOMath.Location = New System.Drawing.Point(6, 157)
        Me.CkOMath.Name = "CkOMath"
        Me.CkOMath.Size = New System.Drawing.Size(98, 17)
        Me.CkOMath.TabIndex = 29
        Me.CkOMath.Text = "Mathématiques"
        Me.CkOMath.UseVisualStyleBackColor = True
        '
        'CkOSyst
        '
        Me.CkOSyst.AutoSize = True
        Me.CkOSyst.Location = New System.Drawing.Point(6, 203)
        Me.CkOSyst.Name = "CkOSyst"
        Me.CkOSyst.Size = New System.Drawing.Size(66, 17)
        Me.CkOSyst.TabIndex = 28
        Me.CkOSyst.Text = "Système"
        Me.CkOSyst.UseVisualStyleBackColor = True
        '
        'CkOGest
        '
        Me.CkOGest.AutoSize = True
        Me.CkOGest.Location = New System.Drawing.Point(6, 134)
        Me.CkOGest.Name = "CkOGest"
        Me.CkOGest.Size = New System.Drawing.Size(62, 17)
        Me.CkOGest.TabIndex = 27
        Me.CkOGest.Text = "Gestion"
        Me.CkOGest.UseVisualStyleBackColor = True
        '
        'CkOAng
        '
        Me.CkOAng.AutoSize = True
        Me.CkOAng.Location = New System.Drawing.Point(6, 19)
        Me.CkOAng.Name = "CkOAng"
        Me.CkOAng.Size = New System.Drawing.Size(60, 17)
        Me.CkOAng.TabIndex = 26
        Me.CkOAng.Text = "Anglais"
        Me.CkOAng.UseVisualStyleBackColor = True
        '
        'CkOChinois
        '
        Me.CkOChinois.AutoSize = True
        Me.CkOChinois.Location = New System.Drawing.Point(6, 42)
        Me.CkOChinois.Name = "CkOChinois"
        Me.CkOChinois.Size = New System.Drawing.Size(60, 17)
        Me.CkOChinois.TabIndex = 25
        Me.CkOChinois.Text = "Chinois"
        Me.CkOChinois.UseVisualStyleBackColor = True
        '
        'CkOdroit
        '
        Me.CkOdroit.AutoSize = True
        Me.CkOdroit.Location = New System.Drawing.Point(6, 88)
        Me.CkOdroit.Name = "CkOdroit"
        Me.CkOdroit.Size = New System.Drawing.Size(48, 17)
        Me.CkOdroit.TabIndex = 24
        Me.CkOdroit.Text = "Droit"
        Me.CkOdroit.UseVisualStyleBackColor = True
        '
        'CkOExpress
        '
        Me.CkOExpress.AutoSize = True
        Me.CkOExpress.Location = New System.Drawing.Point(6, 111)
        Me.CkOExpress.Name = "CkOExpress"
        Me.CkOExpress.Size = New System.Drawing.Size(77, 17)
        Me.CkOExpress.TabIndex = 23
        Me.CkOExpress.Text = "Expression"
        Me.CkOExpress.UseVisualStyleBackColor = True
        '
        'CkOesp
        '
        Me.CkOesp.AutoSize = True
        Me.CkOesp.Location = New System.Drawing.Point(6, 65)
        Me.CkOesp.Name = "CkOesp"
        Me.CkOesp.Size = New System.Drawing.Size(70, 17)
        Me.CkOesp.TabIndex = 22
        Me.CkOesp.Text = "Espagnol"
        Me.CkOesp.UseVisualStyleBackColor = True
        '
        'TxtNbreEcrits
        '
        Me.TxtNbreEcrits.Enabled = False
        Me.TxtNbreEcrits.Location = New System.Drawing.Point(3, 412)
        Me.TxtNbreEcrits.Name = "TxtNbreEcrits"
        Me.TxtNbreEcrits.Size = New System.Drawing.Size(100, 20)
        Me.TxtNbreEcrits.TabIndex = 24
        '
        'TxtNbreOrals
        '
        Me.TxtNbreOrals.Enabled = False
        Me.TxtNbreOrals.Location = New System.Drawing.Point(403, 412)
        Me.TxtNbreOrals.Name = "TxtNbreOrals"
        Me.TxtNbreOrals.Size = New System.Drawing.Size(100, 20)
        Me.TxtNbreOrals.TabIndex = 25
        '
        'GrpFac
        '
        Me.GrpFac.Controls.Add(Me.CbxFacultatif)
        Me.GrpFac.Controls.Add(Me.Label5)
        Me.GrpFac.Controls.Add(Me.RbNon)
        Me.GrpFac.Controls.Add(Me.RbOui)
        Me.GrpFac.Location = New System.Drawing.Point(171, 40)
        Me.GrpFac.Name = "GrpFac"
        Me.GrpFac.Size = New System.Drawing.Size(172, 132)
        Me.GrpFac.TabIndex = 29
        Me.GrpFac.TabStop = False
        Me.GrpFac.Text = "GroupBox4"
        '
        'CbxFacultatif
        '
        Me.CbxFacultatif.FormattingEnabled = True
        Me.CbxFacultatif.Location = New System.Drawing.Point(17, 95)
        Me.CbxFacultatif.Name = "CbxFacultatif"
        Me.CbxFacultatif.Size = New System.Drawing.Size(121, 21)
        Me.CbxFacultatif.Sorted = True
        Me.CbxFacultatif.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Epreuve facultatif:"
        '
        'RbNon
        '
        Me.RbNon.AutoSize = True
        Me.RbNon.Location = New System.Drawing.Point(17, 52)
        Me.RbNon.Name = "RbNon"
        Me.RbNon.Size = New System.Drawing.Size(45, 17)
        Me.RbNon.TabIndex = 27
        Me.RbNon.TabStop = True
        Me.RbNon.Text = "Non"
        Me.RbNon.UseVisualStyleBackColor = True
        '
        'RbOui
        '
        Me.RbOui.AutoSize = True
        Me.RbOui.Location = New System.Drawing.Point(17, 29)
        Me.RbOui.Name = "RbOui"
        Me.RbOui.Size = New System.Drawing.Size(41, 17)
        Me.RbOui.TabIndex = 26
        Me.RbOui.TabStop = True
        Me.RbOui.Text = "Oui"
        Me.RbOui.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GrpFac)
        Me.Panel1.Controls.Add(Me.TxtNbreOrals)
        Me.Panel1.Controls.Add(Me.TxtNbreEcrits)
        Me.Panel1.Controls.Add(Me.GrpOral)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GrpEcrit)
        Me.Panel1.Location = New System.Drawing.Point(275, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(513, 450)
        Me.Panel1.TabIndex = 6
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(12, 503)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnuler.TabIndex = 18
        Me.BtnAnnuler.Text = "Annuler" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(145, 503)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(75, 23)
        Me.BtnValider.TabIndex = 19
        Me.BtnValider.Text = "Valider" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-33, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(910, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(291, 33)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Choix des épreuves"
        '
        'Timer1
        '
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 585)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbxRegion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNom2)
        Me.Controls.Add(Me.LblPren2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "Choix des épreuves"
        Me.GrpEcrit.ResumeLayout(False)
        Me.GrpEcrit.PerformLayout()
        Me.GrpOral.ResumeLayout(False)
        Me.GrpOral.PerformLayout()
        Me.GrpFac.ResumeLayout(False)
        Me.GrpFac.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblPren2 As Label
    Friend WithEvents LblNom2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CbxRegion As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GrpEcrit As GroupBox
    Friend WithEvents CKEmath As CheckBox
    Friend WithEvents CKEvb As CheckBox
    Friend WithEvents CKEPweb As CheckBox
    Friend WithEvents CkESyst As CheckBox
    Friend WithEvents CKElgeJava As CheckBox
    Friend WithEvents CkEResa As CheckBox
    Friend WithEvents CKELgeC As CheckBox
    Friend WithEvents ckEAlgo As CheckBox
    Friend WithEvents CkEGest As CheckBox
    Friend WithEvents ckEbd As CheckBox
    Friend WithEvents CkEexpr As CheckBox
    Friend WithEvents CKEdroit As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GrpOral As GroupBox
    Friend WithEvents CkORes As CheckBox
    Friend WithEvents CkOMath As CheckBox
    Friend WithEvents CkOSyst As CheckBox
    Friend WithEvents CkOGest As CheckBox
    Friend WithEvents CkOAng As CheckBox
    Friend WithEvents CkOChinois As CheckBox
    Friend WithEvents CkOdroit As CheckBox
    Friend WithEvents CkOExpress As CheckBox
    Friend WithEvents CkOesp As CheckBox
    Friend WithEvents TxtNbreEcrits As TextBox
    Friend WithEvents TxtNbreOrals As TextBox
    Friend WithEvents GrpFac As GroupBox
    Friend WithEvents CbxFacultatif As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RbNon As RadioButton
    Friend WithEvents RbOui As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnValider As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class
