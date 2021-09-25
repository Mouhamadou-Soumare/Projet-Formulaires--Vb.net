<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Preno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Reg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ecrit = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Oral = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.fac = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(333, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 33)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Bilan Matière"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(-169, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(1249, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = resources.GetString("Label17.Text")
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NOM, Me.Preno, Me.Reg, Me.Age, Me.Ecrit, Me.Oral, Me.fac})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 127)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(839, 153)
        Me.DataGridView1.TabIndex = 24
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        '
        'NOM
        '
        Me.NOM.HeaderText = "Nom"
        Me.NOM.Name = "NOM"
        '
        'Preno
        '
        Me.Preno.HeaderText = "Prénom"
        Me.Preno.Name = "Preno"
        '
        'Reg
        '
        Me.Reg.HeaderText = "Région"
        Me.Reg.Name = "Reg"
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Ecrit
        '
        Me.Ecrit.HeaderText = "Ecrit"
        Me.Ecrit.Name = "Ecrit"
        '
        'Oral
        '
        Me.Oral.HeaderText = "Oral"
        Me.Oral.Name = "Oral"
        '
        'fac
        '
        Me.fac.HeaderText = "Facultatif"
        Me.fac.Name = "fac"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 38)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Retour à l'acceuil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 383)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.Text = "Bilan matière"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NOM As DataGridViewTextBoxColumn
    Friend WithEvents Preno As DataGridViewTextBoxColumn
    Friend WithEvents Reg As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Ecrit As DataGridViewCheckBoxColumn
    Friend WithEvents Oral As DataGridViewCheckBoxColumn
    Friend WithEvents fac As DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As Button
End Class
