Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btntrue1_Click(sender As Object, e As EventArgs) Handles btntrue1.Click
        btntrue1.Enabled = False
        btnfalse1.Visible = False
        lblraional1.Visible = True
        answer1.Text = " INCORRECT "

    End Sub

    Private Sub btnfalse1_Click(sender As Object, e As EventArgs) Handles btnfalse1.Click
        btnfalse1.Enabled = False
        btntrue1.Visible = False
        lblraional1.Visible = True
        answer1.Text = " CORRECT "

    End Sub

    Private Sub btntrue2_Click(sender As Object, e As EventArgs) Handles btntrue2.Click
        btntrue2.Enabled = False
        btnfalse2.Visible = False
        lblrational2.Visible = True
        answer2.Text = " CORRECT "

    End Sub

    Private Sub btnfalse2_Click(sender As Object, e As EventArgs) Handles btnfalse2.Click
        btnfalse2.Enabled = False
        btntrue2.Visible = False
        lblrational2.Visible = True
        answer2.Text = " INCORRECT "

    End Sub

    Private Sub btntrue3_Click(sender As Object, e As EventArgs) Handles btntrue3.Click
        btntrue3.Enabled = False
        btnfalse3.Visible = False
        lblrational3.Visible = True
        answer3.Text = " INCORRECT "


    End Sub

    Private Sub btnfalse3_Click(sender As Object, e As EventArgs) Handles btnfalse3.Click
        btnfalse3.Enabled = False
        btntrue3.Visible = False
        lblrational3.Visible = True
        answer3.Text = " CORRECT "

    End Sub

    Private Sub btnrest_Click(sender As Object, e As EventArgs) Handles btnrest.Click
        btntrue1.Visible = True
        btnfalse1.Visible = True
        btnfalse2.Visible = True
        btntrue2.Visible = True
        btnfalse3.Visible = True
        btntrue3.Visible = True

        btntrue1.Enabled = True
        btnfalse1.Enabled = True
        btnfalse2.Enabled = True
        btntrue2.Enabled = True
        btnfalse3.Enabled = True
        btntrue3.Enabled = True

        lblraional1.Visible = False
        lblrational2.Visible = False
        lblrational3.Visible = False
        answer1.Text = " "
        answer2.Text = " "
        answer3.Text = " "


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
