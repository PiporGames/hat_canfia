Imports System.Net.NetworkInformation
Imports System.Text
Imports MaterialSkin
Imports Microsoft.Toolkit.Forms.UI.Controls

Public Class mainMenu

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim materialScheme = MaterialSkinManager.Instance
        materialScheme.ColorScheme = New ColorScheme(Color.Orange, Color.DarkOrange, Color.White, Color.Orange, TextShade.WHITE)
        loadingTimer.Enabled = True
        loadingTimer.Start()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        dev_Controller.ShowDialog()
    End Sub

    Private Sub activityManager_SelectedIndexChanged(sender As Object, e As EventArgs) Handles activityManager.SelectedIndexChanged
        'seleccionar tabs
        If activityManager.SelectedTab Is search Then
            PictureBox5.Visible = True
            MaterialCard1.Visible = False
            MaterialCard2.Visible = False
            MaterialCard3.Visible = False
            searchTimer.Enabled = True
            searchTimer.Start()
        ElseIf activityManager.SelectedTab Is pet Then
            PictureBox12.Visible = True
            MaterialCard4.Visible = False
            MaterialCard5.Visible = False
            MaterialButton2.Visible = False
            petTimer.Enabled = True
            petTimer.Start()
        ElseIf activityManager.SelectedTab Is meet Then
            WebView1.Navigate("https://www.google.es/maps/@39.4718049,-6.371029,13.75z?entry=ttu")
        ElseIf activityManager.SelectedTab Is profile Then
            'nothing to change
        ElseIf activityManager.SelectedTab Is petInfo Then

        Else
            MsgBox("index out of bonds, but exception catched --- how embarrassing!")
        End If
    End Sub

    Private Sub searchTimer_Tick(sender As Object, e As EventArgs) Handles searchTimer.Tick
        PictureBox5.Visible = False
        MaterialCard1.Visible = True
        MaterialCard2.Visible = True
        MaterialCard3.Visible = True
        searchTimer.Enabled = False
    End Sub

    Private Sub petTimer_Tick(sender As Object, e As EventArgs) Handles petTimer.Tick
        PictureBox12.Visible = False
        MaterialCard4.Visible = True
        MaterialCard5.Visible = True
        MaterialButton2.Visible = True
        petTimer.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        activityManager.SelectedTab = search
        PictureBox1.BackColor = Color.Orange
        PictureBox2.BackColor = Color.DarkOrange
        PictureBox3.BackColor = Color.DarkOrange
        PictureBox4.BackColor = Color.DarkOrange
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        activityManager.SelectedTab = pet
        PictureBox4.BackColor = Color.Orange
        PictureBox2.BackColor = Color.DarkOrange
        PictureBox3.BackColor = Color.DarkOrange
        PictureBox1.BackColor = Color.DarkOrange
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        activityManager.SelectedTab = meet
        PictureBox3.BackColor = Color.Orange
        PictureBox2.BackColor = Color.DarkOrange
        PictureBox1.BackColor = Color.DarkOrange
        PictureBox4.BackColor = Color.DarkOrange
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        activityManager.SelectedTab = profile
        PictureBox2.BackColor = Color.Orange
        PictureBox1.BackColor = Color.DarkOrange
        PictureBox3.BackColor = Color.DarkOrange
        PictureBox4.BackColor = Color.DarkOrange
    End Sub

    Private Sub loadingTimer_Tick(sender As Object, e As EventArgs) Handles loadingTimer.Tick
        activityManager.SelectedTab = search
        loadingTimer.Enabled = False
    End Sub

    Private Sub FlowLayoutPanel18_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel18.Paint

    End Sub

    Private Sub FlowLayoutPanel22_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel22.Paint

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        'activityManager.SelectedTab = petInfo
        'PictureBox19.Image = My.Resources.Mascota1
        'PictureBox21.Image = My.Resources.Persona1
        'Label63.Text = Label2.Text
        'Label64.Text = Label3.Text
        'Label65.Text = Label4.Text
        'Label66.Text = Label5.Text
        'Label67.Text = Label6.Text
        'Label68.Text = Label7.Text
        'NO HAY TIEMPO PARA ESTA BASURA

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        activityManager.SelectedTab = petInfo
    End Sub
End Class