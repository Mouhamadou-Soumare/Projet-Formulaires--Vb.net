Imports System.IO

Public Class Form6

    Private cand As Candidat
    Dim abreviation As String
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ecrits, orals As String
        Dim fac As String = ""

        For Each cand As Candidat In listeCandidat.OrderBy(Function(x) x.nom).ToList()
            ecrits = (abrev(cand.ecrits(0)) & " " & abrev(cand.ecrits(1)) & " " & abrev(cand.ecrits(2)) & " " & abrev(cand.ecrits(3)))
            orals = (abrev(cand.orals(0)) & " " & abrev(cand.orals(1)) & " " & abrev(cand.orals(2)))
            LstId.Items.Add(cand.id)
            LstNomPren.Items.Add(cand.nom & " " & cand.prenom)
            LstFac.Items.Add(abrev(cand.fac))
            LstEcrits.Items.Add(ecrits)
            LstOral.Items.Add(orals)

        Next
    End Sub

    Function abrev(epreuves As String)
        Dim abreviation As String = ""
        Select Case epreuves
            Case = "Algorithmique"
                abreviation = "ALG"
                Exit Select
            Case = "Anglais"
                abreviation = "ANG"
                Exit Select
            Case = "Base de données"
                abreviation = "BDD"
                Exit Select
            Case = "Chinois"
                abreviation = "CHI"
                Exit Select
            Case = "Droit"
                abreviation = "DRO"
                Exit Select
            Case = "Espagnol"
                abreviation = "ESP"
                Exit Select
            Case = "Expression"
                abreviation = "EXP"
                Exit Select
            Case = "Gestion"
                abreviation = "GES"
                Exit Select
            Case = "Langage C"
                abreviation = "LGC"
                Exit Select
            Case = "Langage Java"
                abreviation = "JAV"
                Exit Select
            Case = "Mathématiques"
                abreviation = "MAT"
                Exit Select
            Case = "Programmation Web"
                abreviation = "WEB"
                Exit Select
            Case = "Réseau"
                abreviation = "RES"
                Exit Select
            Case = "Système"
                abreviation = "SYS"
                Exit Select
            Case = "Visual Basic .NET"
                abreviation = "VBN"
                Exit Select
        End Select

        Return abreviation
    End Function

    Private Sub BtnRetour_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        Me.Owner.Show()
        Me.Close()
    End Sub

    Private Sub LstId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstId.SelectedIndexChanged
        With LstId
            LstEcrits.SelectedIndex = .SelectedIndex
            LstNomPren.SelectedIndex = .SelectedIndex
            LstOral.SelectedIndex = .SelectedIndex
            LstFac.SelectedIndex = .SelectedIndex

        End With


    End Sub
End Class