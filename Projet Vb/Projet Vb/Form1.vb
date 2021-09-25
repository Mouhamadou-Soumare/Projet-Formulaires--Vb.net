Imports System.IO

Public Class Form1
    Private cand As New Candidat
    Dim matieres() As String = {"Algorithmique", "Anglais", "Base de données", "Chinois", "Droit", "Espagnol", "Expression", "Gestion", "Langage C", "Langage Java", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic .NET"}
    Dim rgion() As String = {"Auvergne", "Bordelais", "Bourgogne", "Bretagne", "Corse", "Nord", "Normandie", "Paris", "Poitou", "Roussillon"}

    Function getcand()
        Return cand
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnInscription.Click
        If File.Exists("num.txt") Then
            Dim line As String
            Using reader As StreamReader = New StreamReader("num.txt")
                line = reader.ReadLine.Last
                nbenregistrement = line
                cand.id = line
            End Using
        Else
            File.Create("num.txt").Close()
            nbenregistrement = 0
            cand.id = 0
            File.WriteAllText("num.txt", cand.id)
        End If
        Dim ins As New Form2(Me)
        ins.Show(Me)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        Dim modifsuppr As New Form5
        modifsuppr.Show(Me)
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnEtatactuel.Click
        Dim registre As New Form6
        registre.Show(Me)
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnBilan.Click
        Dim bilan As New Form7
        bilan.Show(Me)
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lecture()
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        arret = True
        If arret = True Then
            For Each cand As Candidat In listeCandidat
                For Each s As String In rgion
                    For Each si As String In matieres
                        For i As Integer = 0 To 3
                            For m As Integer = 0 To 2
                                If si = cand.ecrits(i) And s = cand.region Then
                                    Using a As StreamWriter = New StreamWriter("../" & s & si & ".txt")
                                        a.WriteLine(cand.id & " " & cand.nom & " " & cand.prenom & "  ------->  inscrit à l'épreuve écrite")
                                    End Using
                                ElseIf si = cand.orals(m) And s = cand.region Then
                                    Using a As StreamWriter = New StreamWriter("../" & s & si & ".txt")
                                        a.WriteLine(cand.id & " " & cand.nom & " " & cand.prenom & "  ------->  inscrit à l'épreuve oral")
                                    End Using
                                End If
                            Next
                        Next
                    Next
                Next
            Next
        End If
        MsgBox("Fermeture de cette session d'inscriptions aux concours", MsgBoxStyle.Information)
        Application.Exit()
    End Sub
End Class