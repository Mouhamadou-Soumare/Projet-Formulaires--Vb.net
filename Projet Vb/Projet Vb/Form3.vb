Imports System.Text.RegularExpressions

Public Class Form3

    Dim count As Integer = 0
    Dim cpt As Integer = 0
    Private modifier As Boolean = False
    Private inscription As Form2
    Private cand As Candidat
    Private nbtours, temps, restant As Integer
    Dim matieres() As String = {"Droit", "Expression", "Gestion", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic .NET"}
    Dim ma() As String = {"Algorithmique", "Anglais", "Base de données", "Chinois", "Espagnol", "Langage C", "Langage Java", "Programmation Web"}
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        temps = 90
        restant = 0
        nbtours = 0
        LblNom2.Text = cand.nom
        LblPren2.Text = cand.prenom

        Dim EPREUVESE() As String = {"Algorithmique", "Base de donnés", "Droit", "Expression", "Gestion", "Langage C", "Langage Java", "Mathématiques", "Programmation Web", "Réseau", "Système", "Visual Basic.NET"}
        Dim epreuvesO() As String = {"Anglais", "Chinois", "Espagnol", "Droit", "Expression", "Mathématiques", "Réseau", "Système"}
        GrpFac.Visible = False

    End Sub
    Function getCand()
        Return cand
    End Function
    Sub New(ByRef ins As Form2)

        InitializeComponent()
        Me.modifier = ins.getmodifier()
        Me.inscription = ins
        cand = Me.inscription.getCand()
        If Me.modifier Then
            count = 0
            cpt = 0
            For Each ck As CheckBox In GrpEcrit.Controls
                For Each ecrit As String In cand.ecrits
                    If ck.Text = cand.ecrits(ecrit) Then
                        ck.Checked = True
                        count = count + 1
                    End If
                Next
            Next
            For Each ck As CheckBox In GrpOral.Controls
                For Each orals As String In cand.orals
                    If ck.Text = cand.orals(orals) Then
                        ck.Checked = True
                        cpt = cpt + 1
                    End If
                Next
            Next

            CbxRegion.Text = cand.region
            If cand.fac = "" Then
                RbNon.Checked = True
            Else
                RbOui.Checked = True
                CbxFacultatif.SelectedItem = cand.fac
            End If
        Else
            cand.ecrits = New List(Of String)
            cand.orals = New List(Of String)
        End If

        Me.modifier = False
    End Sub



    Private Sub CKEdroit_CheckedChanged(sender As Object, e As EventArgs) Handles CKEdroit.CheckedChanged
        If CKEdroit.Checked = True Then
            CkOdroit.Checked = False
            CkOdroit.Enabled = False
            count = count + 1
        ElseIf CKEdroit.Checked = False Then
            count = count - 1

            CkOdroit.Enabled = True
        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CkEexpr_CheckedChanged(sender As Object, e As EventArgs) Handles CkEexpr.CheckedChanged
        If CkEexpr.Checked = True Then
            CkOExpress.Checked = False
            CkOExpress.Enabled = False
            count = count + 1
        ElseIf CkEexpr.Checked = False Then
            CkOExpress.Enabled = True
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CkEGest_CheckedChanged(sender As Object, e As EventArgs) Handles CkEGest.CheckedChanged
        If CkEGest.Checked = True Then
            CkOGest.Checked = False
            CkOGest.Enabled = False
            count = count + 1
        Else
            CkOGest.Enabled = True
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CKEmath_CheckedChanged(sender As Object, e As EventArgs) Handles CKEmath.CheckedChanged
        If CKEmath.Checked = True Then
            CkOMath.Checked = False
            CkOMath.Enabled = False
            count = count + 1
        ElseIf CKEmath.Checked = False Then
            CkOMath.Enabled = True
            count = count - 1
        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CkEResa_CheckedChanged(sender As Object, e As EventArgs) Handles CkEResa.CheckedChanged
        If CkEResa.Checked = True Then
            CkORes.Checked = False
            CkORes.Enabled = False
            count = count + 1
        ElseIf CkEResa.Checked = False Then
            CkORes.Enabled = True
            count = count - 1
        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CkESyst_CheckedChanged(sender As Object, e As EventArgs) Handles CkESyst.CheckedChanged
        If CkESyst.Checked = True Then
            CkOSyst.Checked = False
            CkOSyst.Enabled = False
            count = count + 1
        ElseIf CkESyst.Checked = False Then
            CkOSyst.Enabled = True
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CkOdroit_CheckedChanged(sender As Object, e As EventArgs) Handles CkOdroit.CheckedChanged
        If CkOdroit.Checked = True Then
            CKEdroit.Checked = False
            CKEdroit.Enabled = False
            cpt = cpt + 1
        ElseIf CkOdroit.Checked = False Then
            CKEdroit.Enabled = True
            cpt = cpt - 1

        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOExpress_CheckedChanged(sender As Object, e As EventArgs) Handles CkOExpress.CheckedChanged
        If CkOExpress.Checked = True Then
            CkEexpr.Checked = False
            CkEexpr.Enabled = False
            cpt = cpt + 1
        ElseIf CkOExpress.Checked = False Then
            CkEexpr.Enabled = True
            cpt = cpt - 1

        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOGest_CheckedChanged(sender As Object, e As EventArgs) Handles CkOGest.CheckedChanged
        If CkOGest.Checked = True Then
            CkEGest.Checked = False
            CkEGest.Enabled = False
            cpt = cpt + 1
        ElseIf CkOGest.Checked = False Then
            CkEGest.Enabled = True
            cpt = cpt - 1

        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOMath_CheckedChanged(sender As Object, e As EventArgs) Handles CkOMath.CheckedChanged
        If CkOMath.Checked = True Then
            CKEmath.Checked = False
            CKEmath.Enabled = False
            cpt = cpt + 1
        ElseIf CkOMath.Checked = False Then
            CKEmath.Enabled = True
            cpt = cpt - 1

        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkORes_CheckedChanged(sender As Object, e As EventArgs) Handles CkORes.CheckedChanged
        If CkORes.Checked = True Then
            CkEResa.Checked = False
            CkEResa.Enabled = False
            cpt = cpt + 1
        ElseIf CkORes.Checked = False Then
            CkEResa.Enabled = True
            cpt = cpt - 1

        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOSyst_CheckedChanged(sender As Object, e As EventArgs) Handles CkOSyst.CheckedChanged
        If CkOSyst.Checked = True Then
            CkESyst.Checked = False
            CkESyst.Enabled = False
            cpt = cpt + 1
        ElseIf CkOSyst.Checked = False Then
            CkESyst.Enabled = True
            cpt = cpt - 1
        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub ckEAlgo_CheckedChanged(sender As Object, e As EventArgs) Handles ckEAlgo.CheckedChanged
        If ckEAlgo.Checked = True Then
            count = count + 1
        ElseIf ckEAlgo.Checked = False Then
            count = count - 1
        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub ckEbd_CheckedChanged(sender As Object, e As EventArgs) Handles ckEbd.CheckedChanged
        If ckEbd.Checked = True Then
            count = count + 1
        Else
            count = count - 1
        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CKELgeC_CheckedChanged(sender As Object, e As EventArgs) Handles CKELgeC.CheckedChanged
        If CKELgeC.Checked = True Then
            count = count + 1
        Else
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CKElgeJava_CheckedChanged(sender As Object, e As EventArgs) Handles CKElgeJava.CheckedChanged
        If CKElgeJava.Checked = True Then
            count = count + 1
        Else
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CKEPweb_CheckedChanged(sender As Object, e As EventArgs) Handles CKEPweb.CheckedChanged
        If CKEPweb.Checked = True Then
            count = count + 1
        Else
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub CKEvb_CheckedChanged(sender As Object, e As EventArgs) Handles CKEvb.CheckedChanged
        If CKEvb.Checked = True Then
            count = count + 1
        Else
            count = count - 1

        End If
        TxtNbreEcrits.Text = count.ToString
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNbreEcrits.TextChanged
        If count.ToString = 4 Then

            TxtNbreEcrits.Text = "limite atteinte"
            For Each ck As CheckBox In GrpEcrit.Controls

                If ck.Checked = False Then
                    ck.Enabled = False
                End If
            Next

        ElseIf count.ToString < 4 Then
            For Each ck As CheckBox In GrpEcrit.Controls
                If ck.Enabled = False Then
                    If ck.Checked = False Then
                        ck.Enabled = True
                    End If
                End If
                For Each ak As CheckBox In GrpOral.Controls
                    If ak.Checked = True Then
                        If ck.Text = ak.Text Then
                            ck.Enabled = False
                        End If
                    End If
                Next
            Next




        End If
    End Sub

    Private Sub CkOAng_CheckedChanged(sender As Object, e As EventArgs) Handles CkOAng.CheckedChanged
        If CkOAng.Checked = True Then
            cpt = cpt + 1
        Else
            cpt = cpt - 1
        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOChinois_CheckedChanged(sender As Object, e As EventArgs) Handles CkOChinois.CheckedChanged
        If CkOChinois.Checked = True Then
            cpt = cpt + 1
        Else
            cpt = cpt - 1
        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub CkOesp_CheckedChanged(sender As Object, e As EventArgs) Handles CkOesp.CheckedChanged
        If CkOesp.Checked = True Then
            cpt = cpt + 1
        Else
            cpt = cpt - 1
        End If
        TxtNbreOrals.Text = cpt.ToString
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtNbreOrals.TextChanged
        If cpt.ToString = 3 Then
            TxtNbreOrals.Text = "limite atteinte"
            For Each ck As CheckBox In GrpOral.Controls
                If ck.Checked = False Then
                    ck.Enabled = False
                End If
            Next

        ElseIf cpt.ToString < 3 Then
            For Each ck As CheckBox In GrpOral.Controls
                If ck.Enabled = False Then
                    If ck.Checked = False Then
                        ck.Enabled = True
                    End If
                    For Each ak As CheckBox In GrpEcrit.Controls
                        If ak.Checked = True Then
                            If ck.Text = ak.Text Then
                                ck.Enabled = False
                            End If
                        End If
                    Next
                End If

            Next
        End If

        If cpt.ToString = 3 And count.ToString = 4 Then
            GrpFac.Visible = True
            CbxFacultatif.Visible = False
        Else
            GrpFac.Visible = False

        End If

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RbOui.CheckedChanged
        Dim l As New List(Of String)
        If RbOui.Checked = True Then
            For Each ck As CheckBox In GrpEcrit.Controls
                For Each ak As CheckBox In GrpOral.Controls
                    If ck.Checked = False And ak.Checked = False Then
                        If ck.Enabled = False And ak.Enabled = False Then
                            CbxFacultatif.Items.Add(ck.Text)
                            l.Add(ck.Text)
                            Exit For

                        End If
                    End If
                Next

            Next

            For Each ak As CheckBox In GrpOral.Controls
                If ak.Checked = False And ak.Enabled = False Then

                    For Each m As String In l
                        If ak.Text <> m Then
                            CbxFacultatif.Items.Add(ak.Text)
                            Exit For
                        End If

                    Next


                End If
            Next
            CbxFacultatif.Visible = True

        Else
            CbxFacultatif.Visible = False
        End If

        GrpOral.Enabled = False
        GrpEcrit.Enabled = False
    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RbNon.CheckedChanged
        GrpOral.Enabled = True
        GrpEcrit.Enabled = True
        For Each ck As CheckBox In GrpOral.Controls
            If ck.Enabled = False Then
                If ck.Checked = False Then
                    ck.Enabled = True
                End If
                For Each ak As CheckBox In GrpEcrit.Controls
                    If ak.Checked = True Then
                        If ck.Text = ak.Text Then
                            ck.Enabled = False
                        End If
                    End If
                Next
            End If

        Next
        For Each ck As CheckBox In GrpEcrit.Controls
            If ck.Enabled = False Then
                If ck.Checked = False Then
                    ck.Enabled = True
                End If
                For Each ak As CheckBox In GrpOral.Controls
                    If ak.Checked = True Then
                        If ck.Text = ak.Text Then
                            ck.Enabled = False
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        MsgBox("Etes-vous sûr d'annuler l'inscription ?", vbYesNo, "Annulation")
        If vbYes Then
            Me.Owner.Owner.Show()

            Me.Owner.Close()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        Dim valide As Boolean = True

        If count > 4 Then
            valide = False
            MsgBox("le nombre d'épreuves écrites est supérieur à 4")
        End If
        If cpt > 3 Then
            valide = False
            MsgBox("le nombre d'épreuves orales est supérieur à 3")
        End If
        If CbxRegion.Text = "" Then
            MsgBox("vous devez choisir une région")
        End If
        If valide = True Then


            Timer1.Stop()
            For Each ck As CheckBox In GrpEcrit.Controls
                If ck.Checked = True Then
                    cand.ecrits.Insert(0, ck.Text)
                End If
            Next
            For Each ck As CheckBox In GrpOral.Controls
                If ck.Checked = True Then
                    cand.orals.Insert(0, ck.Text)
                End If
            Next
            cand.region = CbxRegion.Text
            If RbNon.Checked Then
                cand.fac = ""
            Else
                cand.fac = CbxFacultatif.Text
            End If

            Dim recapitulatif As New Form4(Me)
                recapitulatif.Show(Me)
            Me.Hide()


        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nbtours += 1
        If nbtours \ 10 = restant Then
            restant += 1
        End If
        Me.Text = "Choix des épreuves et de la région    " + TimeOfDay + "       " + (temps - restant).ToString() + "s"
        If temps - restant = 0 Then
            Me.Owner.Owner.Show()
            Me.Owner.Close()
            Me.Close()
            MsgBox("vous devez choisir vos épreuves et la région de passage en 1min30 !")
        End If
    End Sub
End Class