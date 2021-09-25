Imports System.IO

Public Class Form4
    Private cand As Candidat
    Private choixepreuves As Form3
    Private bilan As Boolean = False

    Sub New(ByRef choixfaits As Form3)
        InitializeComponent()
        Me.choixepreuves = choixfaits
        Me.cand = choixfaits.getCand()
    End Sub


    Sub New(ByRef modifier As Form5)

        InitializeComponent()
        Me.cand = modifier.getCand
        Me.Show(modifier)
        Me.Owner.Hide()
        MsgBox("La suppression est irréverssible ! Ete-vous sur de votre choix?", vbYesNo, "Confirmation de suppression")
        If vbYes Then

            Module1.listeCandidat.Remove(cand)
            MsgBox("le candidat a bien été supprimé !", MsgBoxStyle.OkOnly)
            Me.Owner.Owner.Show()
            Me.Owner.Close()
            Me.Close()
        Else
            Me.Close()
            Me.Owner.Show()
        End If

    End Sub

    Sub New(ByRef bilan As Form7)

        InitializeComponent()
        Me.cand = bilan.getCand()
        Me.bilan = True

    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblNom.Text = cand.nom
        LblPren.Text = cand.prenom
        LblVille.Text = cand.ville
        LblCp.Text = cand.cp
        If cand.adress = "" Then
            LblAdress.Visible = False
            Label9.Visible = False
        Else
            LblAdress.Text = cand.adress
            Label9.Visible = True
        End If
        LblAge.Text = cand.age
        LblRegion.Text = cand.region
        For Each s As String In cand.ecrits
            LvEcrits.Items.Add(s)
        Next
        For Each s As String In cand.orals
            LvOral.Items.Add(s)
        Next
        If cand.fac = "" Then
            TxtFac.Visible = False
            Label15.Visible = False
        Else
            TxtFac.Text = cand.fac
            Label15.Visible = True
        End If

        If Not File.Exists(c) Then
            Dim d As FileStream
            d = File.Create(C)
            d.Close()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        MsgBox("Etes-vous sûr d'annuler l'inscription ?", vbYesNo, "Annulation")
        If vbYes Then
            Me.Owner.Owner.Owner.Show()
            Me.Owner.Owner.Close()
            Me.Owner.Close()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEnregistrer.Click
        cand.id += 1
        nbenregistrement += 1
        Using s As StreamWriter = New StreamWriter("num.txt")
            s.WriteLine(cand.id)
        End Using
        listeCandidat.Add(cand)
        enregistrer()

        Me.Owner.Owner.Owner.Show()
        Me.Owner.Owner.Close()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnRetour.Click
        If bilan = False Then
            Me.Owner.Owner.Show()
            Me.Owner.Owner.Close()
            Me.Close()
        Else
            Me.Owner.Show()
            Me.Close()
        End If
    End Sub


End Class