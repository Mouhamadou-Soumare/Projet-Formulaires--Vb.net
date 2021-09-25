Public Class Form7
    Private cand As Candidat
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNbreInscr.Text = nbenregistrement
        Dim matieres() As String = {"Algorithmique", "Anglais", "Base de données", "Chinois", "Droit", "Espagnol", "Expression", "Gestion", "Langage C", "Langage Java", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic .NET"}
        Dim region() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}
        CbxCand.Items.Clear()
        CbxMat.Items.Clear()
        For Each cand As Candidat In listeCandidat
            CbxCand.Items.Add(cand.nom & " " & cand.prenom)

        Next
        For Each s As String In matieres
            CbxMat.Items.Add(s)
        Next
        CbxMat.Visible = False
        CbxCand.Visible = False
        LblCand.Visible = False
        LblMatière.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RbIndividuel.CheckedChanged
        If RbIndividuel.Checked Then
            CbxCand.Visible = True
            LblCand.Visible = True
        Else
            CbxCand.Visible = False
            LblCand.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RbMatiere.CheckedChanged
        If RbMatiere.Checked Then
            LblMatière.Visible = True
            CbxMat.Visible = True
        Else
            LblMatière.Visible = False
            CbxMat.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Owner.Show()
        Me.Close()
    End Sub
    Function getcand()
        Return cand
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAfficher.Click
        Dim bool As Boolean = False

        If RbIndividuel.Checked Then
            If CbxCand.Text <> "" Then
                For Each candi As Candidat In listeCandidat
                    If (candi.nom & " " & candi.prenom) = CbxCand.Text Then
                        bool = True
                        cand = candi
                        Dim recapitulatif As New Form4(Me)
                        Me.Hide()
                        recapitulatif.BtnAnnuler.Visible = False
                        recapitulatif.BtnRetour.Visible = False
                        recapitulatif.Show(Me)
                        Exit For
                    End If
                Next
            Else
                MsgBox("candidat introuvable")
            End If
        ElseIf RbMatiere.Checked Then
            If CbxMat.Text <> "" Then
                Dim bilanMatiere As New Form8(Me)

                For Each cand As Candidat In listeCandidat
                    For i As Integer = 0 To 3
                        If cand.ecrits(i) = CbxMat.Text Then
                            bilanMatiere.DataGridView1.Rows.Add(cand.id, cand.nom, cand.prenom, cand.region, cand.age, True, False, False)

                        End If
                    Next
                    For i As Integer = 0 To 2
                        If cand.orals(i) = CbxMat.Text Then
                            bilanMatiere.DataGridView1.Rows.Add(cand.id, cand.nom, cand.prenom, cand.region, cand.age, False, True, False)

                        End If
                    Next
                    If cand.fac = CbxMat.Text Then
                        bilanMatiere.DataGridView1.Rows.Add(cand.id, cand.nom, cand.prenom, cand.region, cand.age, False, False, True)
                    End If
                Next
                bilanMatiere.Show(Me)
                Me.Hide()
            Else
                MsgBox("introuvable!")
            End If
        End If
    End Sub
End Class