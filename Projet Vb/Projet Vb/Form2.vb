Public Class Form2
    Private temps, restant, nbtours As Integer
    Private cand As New Candidat
    Private modifier As Boolean = False
    Private nouvelle As Form1

    Sub New(ByRef nvlleinsc As Form1)
        InitializeComponent()
        Me.nouvelle = nvlleinsc
        cand = Me.nouvelle.getcand
    End Sub
    Sub New(ByRef Rmodification As Form5)

        InitializeComponent()
        Me.cand = Rmodification.getCand
        Me.modifier = True
        Me.Show(Rmodification)
        Me.Owner.Hide()
        cmdNom.Text = cand.nom
        CmdPren.Text = cand.prenom
        CmdAdres.Text = cand.adress
        CmdCp.Text = cand.cp
        ComboBox1.Text = cand.age
        CmdVille.Text = cand.ville

    End Sub

    Dim nbenregistrement As Integer = 0
    Function getCand()
        Return cand
    End Function

    Private Sub cmdNom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmdNom.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        cmdNom.MaxLength = 15

    End Sub

    Private Sub cmdPrenom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmdPren.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
        cmdNom.MaxLength = 20

    End Sub


    Private Sub cdmNom_lostfocus(sender As Object, e As EventArgs) Handles cmdNom.LostFocus, CmdPren.LostFocus, CmdVille.LostFocus
        If (cmdNom.TextLength > 0) Then
            cmdNom.Text = cmdNom.Text.Substring(0, 1).ToUpper() + cmdNom.Text.Substring(1).ToLower()
        End If

        If (CmdPren.TextLength > 0) Then
            CmdPren.Text = CmdPren.Text.Substring(0, 1).ToUpper() + CmdPren.Text.Substring(1).ToLower()
        End If

        If (CmdVille.TextLength > 0) Then
            CmdVille.Text = CmdVille.Text.Substring(0, 1).ToUpper() + CmdVille.Text.Substring(1).ToLower()
        End If
    End Sub

    Private Sub CmdAdres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmdAdres.KeyPress
        CmdAdres.MaxLength = 30
    End Sub

    Private Sub CmdCp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmdCp.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        CmdCp.MaxLength = 5
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAbando.Click
        If MsgBox("Etes-vous certain de vouloir quitter l'inscription ?", vbYesNo, "Demande de confirmation") = vbYes Then
            Me.Owner.Show()
            Me.Close()
        Else
            Me.Show()
        End If
    End Sub



    Private Sub cmdNom_Enter(sender As Object, e As EventArgs) Handles cmdNom.Enter
        LblNom.ForeColor = Color.Black

    End Sub

    Private Sub CmdPren_Enter(sender As Object, e As EventArgs) Handles CmdPren.Enter
        LblPren.ForeColor = Color.Black

    End Sub

    Private Sub CmdCp_Enter(sender As Object, e As EventArgs) Handles CmdCp.Enter
        LblCp.ForeColor = Color.Black

    End Sub

    Private Sub CmdVille_Enter(sender As Object, e As EventArgs) Handles CmdVille.Enter
        LblVille.ForeColor = Color.Black

    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles ComboBox1.Enter
        LblAge.ForeColor = Color.Black

    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub CmdVille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmdVille.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnContinuer.Click

        Dim valid As Boolean = True
        Dim selec As Boolean = False

        LblNom.ForeColor = Color.Black
        LblPren.ForeColor = Color.Black
        LblCp.ForeColor = Color.Black
        LblVille.ForeColor = Color.Black

        If cmdNom.TextLength = 0 Then
            LblNom.ForeColor = Color.Red
            valid = False
        End If

        If CmdPren.TextLength = 0 Then
            LblPren.ForeColor = Color.Red
            valid = False
        End If
        If CmdVille.TextLength = 0 Then
            LblVille.ForeColor = Color.Red
            valid = False
        End If
        If CmdCp.TextLength = 0 Then
            LblCp.ForeColor = Color.Red
            valid = False
        End If
        If ComboBox1.SelectedItem = 0 Then
            LblAge.ForeColor = Color.Red
            valid = False
        End If

        If CmdCp.TextLength = 0 Then
            LblCp.ForeColor = Color.Red
            valid = False
        ElseIf CmdCp.Text.Substring(0, 2).Equals("00") Then
            LblCp.ForeColor = Color.Red
            MsgBox("les deux premiers chiffres doivent être différents de zéro")
            valid = False
        End If


        selec = False
        If valid Then
            cand.nom = cmdNom.Text
            cand.prenom = CmdPren.Text
            cand.adress = CmdAdres.Text
            cand.age = ComboBox1.Text
            cand.ville = CmdVille.Text
            cand.cp = CmdCp.Text
            If CmdAdres.Text = "" Then
                cand.adress = ""
            Else
                cand.adress = CmdAdres.Text
            End If
            Timer1.Stop()
            Dim choix As New Form3(Me)
            choix.Show(Me)
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nbtours += 1
        If nbtours \ 10 = restant Then
            restant += 1
        End If
        If temps - restant = 0 Then
            Me.Owner.Show()
            Me.Close()
            MsgBox("L'inscrption doit s'effectuer en 1 min !", MsgBoxStyle.Information)
        End If
        Me.Text = "Données personnels" + "    " + TimeOfDay + "       " + (temps - restant).ToString() + "s"
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        temps = 60
        nbtours = 0
        restant = 0
    End Sub


    Function getmodifier()
        Return modifier
    End Function
End Class
