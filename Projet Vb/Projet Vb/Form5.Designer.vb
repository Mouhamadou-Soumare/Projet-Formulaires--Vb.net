<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdBtnNomPren = New System.Windows.Forms.RadioButton()
        Me.RdBtnNum = New System.Windows.Forms.RadioButton()
        Me.Txtnum = New System.Windows.Forms.TextBox()
        Me.txtnopren = New System.Windows.Forms.TextBox()
        Me.cbxNum = New System.Windows.Forms.ComboBox()
        Me.cbxnompren = New System.Windows.Forms.ComboBox()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.BtnModif = New System.Windows.Forms.Button()
        Me.BtnRetour = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type de recherche :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdBtnNomPren)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RdBtnNum)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'RdBtnNomPren
        '
        Me.RdBtnNomPren.AutoSize = True
        Me.RdBtnNomPren.Location = New System.Drawing.Point(6, 39)
        Me.RdBtnNomPren.Name = "RdBtnNomPren"
        Me.RdBtnNomPren.Size = New System.Drawing.Size(71, 17)
        Me.RdBtnNomPren.TabIndex = 1
        Me.RdBtnNomPren.TabStop = True
        Me.RdBtnNomPren.Text = "Identifiant"
        Me.RdBtnNomPren.UseVisualStyleBackColor = True
        '
        'RdBtnNum
        '
        Me.RdBtnNum.AutoSize = True
        Me.RdBtnNum.Location = New System.Drawing.Point(3, 16)
        Me.RdBtnNum.Name = "RdBtnNum"
        Me.RdBtnNum.Size = New System.Drawing.Size(65, 17)
        Me.RdBtnNum.TabIndex = 0
        Me.RdBtnNum.TabStop = True
        Me.RdBtnNum.Text = "Numéro "
        Me.RdBtnNum.UseVisualStyleBackColor = True
        '
        'Txtnum
        '
        Me.Txtnum.Enabled = False
        Me.Txtnum.Location = New System.Drawing.Point(170, 154)
        Me.Txtnum.Name = "Txtnum"
        Me.Txtnum.Size = New System.Drawing.Size(33, 20)
        Me.Txtnum.TabIndex = 2
        Me.Txtnum.Text = "N° :"
        Me.Txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtnopren
        '
        Me.txtnopren.Enabled = False
        Me.txtnopren.Location = New System.Drawing.Point(110, 154)
        Me.txtnopren.Name = "txtnopren"
        Me.txtnopren.Size = New System.Drawing.Size(93, 20)
        Me.txtnopren.TabIndex = 3
        Me.txtnopren.Text = "Identifiant :"
        '
        'cbxNum
        '
        Me.cbxNum.FormattingEnabled = True
        Me.cbxNum.Location = New System.Drawing.Point(228, 154)
        Me.cbxNum.Name = "cbxNum"
        Me.cbxNum.Size = New System.Drawing.Size(99, 21)
        Me.cbxNum.TabIndex = 4
        '
        'cbxnompren
        '
        Me.cbxnompren.FormattingEnabled = True
        Me.cbxnompren.Location = New System.Drawing.Point(228, 154)
        Me.cbxnompren.Name = "cbxnompren"
        Me.cbxnompren.Size = New System.Drawing.Size(205, 21)
        Me.cbxnompren.TabIndex = 5
        '
        'btnSupp
        '
        Me.btnSupp.Location = New System.Drawing.Point(145, 202)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(100, 24)
        Me.btnSupp.TabIndex = 2
        Me.btnSupp.Text = "Supprimer"
        Me.btnSupp.UseVisualStyleBackColor = True
        '
        'BtnModif
        '
        Me.BtnModif.Location = New System.Drawing.Point(305, 202)
        Me.BtnModif.Name = "BtnModif"
        Me.BtnModif.Size = New System.Drawing.Size(100, 24)
        Me.BtnModif.TabIndex = 6
        Me.BtnModif.Text = "Modifier"
        Me.BtnModif.UseVisualStyleBackColor = True
        '
        'BtnRetour
        '
        Me.BtnRetour.Location = New System.Drawing.Point(216, 279)
        Me.BtnRetour.Name = "BtnRetour"
        Me.BtnRetour.Size = New System.Drawing.Size(137, 23)
        Me.BtnRetour.TabIndex = 7
        Me.BtnRetour.Text = "Retour à l'acceuil"
        Me.BtnRetour.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Modification Ou Suppression"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-75, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(676, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 304)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRetour)
        Me.Controls.Add(Me.BtnModif)
        Me.Controls.Add(Me.btnSupp)
        Me.Controls.Add(Me.cbxnompren)
        Me.Controls.Add(Me.cbxNum)
        Me.Controls.Add(Me.Txtnum)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnopren)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Action sur candidat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdBtnNomPren As RadioButton
    Friend WithEvents RdBtnNum As RadioButton
    Friend WithEvents Txtnum As TextBox
    Friend WithEvents txtnopren As TextBox
    Friend WithEvents cbxNum As ComboBox
    Friend WithEvents cbxnompren As ComboBox
    Friend WithEvents btnSupp As Button
    Friend WithEvents BtnModif As Button
    Friend WithEvents BtnRetour As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
