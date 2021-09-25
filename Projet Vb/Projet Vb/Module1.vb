
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Module Module1
    Public a As StreamReader
    Public b As String
    Public c As String = "sauvegarde.txt"
    Public arret As Boolean

    <Serializable()>
    Public Structure Candidat
        Public id, cp, age As Integer
        Public nom, prenom, adress, ville, fac, region As String
        Public ecrits, orals As List(Of String)


    End Structure

    Public nbenregistrement As Integer
    Public listeCandidat As New List(Of Candidat)
    Private cand As Candidat

    Public Sub enregistrer()
        Dim stream As FileStream = File.Create("vec.txt")
        Dim formatter As New BinaryFormatter
        formatter.Serialize(stream, listeCandidat)
        stream.Close()
    End Sub

    Public Sub lecture()
        If File.Exists("vec.txt") Then
            Dim stream As FileStream = File.OpenRead("vec.txt")
            Dim formatter As New BinaryFormatter

            listeCandidat = formatter.Deserialize(Stream)
            Stream.Close()
        End If
    End Sub

End Module
