<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LstId = New System.Windows.Forms.ListBox()
        Me.LstNomPren = New System.Windows.Forms.ListBox()
        Me.LstEcrits = New System.Windows.Forms.ListBox()
        Me.LstOral = New System.Windows.Forms.ListBox()
        Me.LstFac = New System.Windows.Forms.ListBox()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Etat actuels des inscriptions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-90, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1225, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = resources.GetString("Label6.Text")
        '
        'LstId
        '
        Me.LstId.FormattingEnabled = True
        Me.LstId.Location = New System.Drawing.Point(12, 105)
        Me.LstId.Name = "LstId"
        Me.LstId.Size = New System.Drawing.Size(91, 290)
        Me.LstId.TabIndex = 22
        '
        'LstNomPren
        '
        Me.LstNomPren.Enabled = False
        Me.LstNomPren.FormattingEnabled = True
        Me.LstNomPren.Location = New System.Drawing.Point(166, 105)
        Me.LstNomPren.Name = "LstNomPren"
        Me.LstNomPren.Size = New System.Drawing.Size(151, 290)
        Me.LstNomPren.TabIndex = 23
        '
        'LstEcrits
        '
        Me.LstEcrits.Enabled = False
        Me.LstEcrits.FormattingEnabled = True
        Me.LstEcrits.Location = New System.Drawing.Point(373, 105)
        Me.LstEcrits.Name = "LstEcrits"
        Me.LstEcrits.Size = New System.Drawing.Size(146, 290)
        Me.LstEcrits.TabIndex = 24
        '
        'LstOral
        '
        Me.LstOral.Enabled = False
        Me.LstOral.FormattingEnabled = True
        Me.LstOral.Location = New System.Drawing.Point(605, 105)
        Me.LstOral.Name = "LstOral"
        Me.LstOral.Size = New System.Drawing.Size(146, 290)
        Me.LstOral.TabIndex = 25
        '
        'LstFac
        '
        Me.LstFac.Enabled = False
        Me.LstFac.FormattingEnabled = True
        Me.LstFac.Location = New System.Drawing.Point(815, 105)
        Me.LstFac.Name = "LstFac"
        Me.LstFac.Size = New System.Drawing.Size(146, 290)
        Me.LstFac.TabIndex = 26
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(422, 443)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(188, 34)
        Me.BtnRetour.TabIndex = 27
        Me.BtnRetour.Text = "Retour à l'acceuil"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Identifiant"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nom Prénom"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Epreuves écrites"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(602, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Epreuves orals"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(812, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Epreuve facultatif"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 489)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.LstFac)
        Me.Controls.Add(Me.LstOral)
        Me.Controls.Add(Me.LstEcrits)
        Me.Controls.Add(Me.LstNomPren)
        Me.Controls.Add(Me.LstId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "Candidats inscrits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LstId As ListBox
    Friend WithEvents LstNomPren As ListBox
    Friend WithEvents LstEcrits As ListBox
    Friend WithEvents LstOral As ListBox
    Friend WithEvents LstFac As ListBox
    Friend WithEvents BtnRetour As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
End Class
