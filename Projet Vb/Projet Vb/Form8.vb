Public Class Form8
    Private bilan As Form7

    Sub New(bilan As Form7)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        Me.bilan = bilan

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Owner.Show()
        Me.Close()
    End Sub
End Class