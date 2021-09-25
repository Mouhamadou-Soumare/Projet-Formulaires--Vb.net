Public Class Form5
    Private cand As Candidat
    Function getCand()
        Return cand
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxnompren.Items.Clear()
        cbxNum.Items.Clear()
        For Each cand As Candidat In listeCandidat
            cbxnompren.Items.Add(cand.nom & " " & cand.prenom)
            cbxNum.Items.Add(cand.id)
        Next
        cbxNum.Visible = False
        cbxnompren.Visible = False
        txtnopren.Visible = False
        Txtnum.Visible = False
    End Sub

    Private Sub RdBtnNum_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnNum.CheckedChanged
        If RdBtnNum.Checked = True Then
            cbxNum.Visible = True
            Txtnum.Visible = True
        Else
            cbxNum.Visible = False
            Txtnum.Visible = False
        End If
    End Sub

    Private Sub RdBtnNomPren_CheckedChanged(sender As Object, e As EventArgs) Handles RdBtnNomPren.CheckedChanged
        If RdBtnNomPren.Checked = True Then
            cbxnompren.Visible = True
            txtnopren.Visible = True
        Else
            cbxnompren.Visible = False
            txtnopren.Visible = False
        End If
    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnSupp.Click
        If RdBtnNomPren.Checked = True Then
            For Each s As Candidat In listeCandidat
                If (s.nom & " " & s.prenom) = cbxnompren.Text Then
                    cand = s
                    Dim recapitulatif As New Form4(Me)
                    Exit For
                End If
            Next

        ElseIf RdBtnNum.Checked = True Then
            For Each s As Candidat In listeCandidat
                If s.id = cand.id Then
                    cand = s
                    Dim recapitulatif As New Form4(Me)
                    Exit For
                End If

            Next
        End If
    End Sub

    Private Sub BtnModif_Click(sender As Object, e As EventArgs) Handles BtnModif.Click
        If RdBtnNomPren.Checked = True Then
            For Each s As Candidat In listeCandidat
                If (s.nom & " " & s.prenom) = cbxnompren.Text Then
                    cand = s
                    Dim modification As New Form2(Me)

                    Exit For
                End If
            Next

        ElseIf RdBtnNum.Checked = True Then
            For Each s As Candidat In listeCandidat
                If s.id = cbxNum.Text Then
                    cand = s
                    Dim modification As New Form2(Me)

                    Exit For
                End If
            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Owner.Show()
        Me.Close()
    End Sub
End Class