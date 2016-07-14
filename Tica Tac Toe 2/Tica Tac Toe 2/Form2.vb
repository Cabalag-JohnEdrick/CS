Public Class Form2

    Dim turn As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        turn = 1
        Me.BackColor = Color.LightYellow
        Button1.BackColor = Color.LightBlue
        Button2.BackColor = Color.LightBlue
        Button3.BackColor = Color.LightBlue
        Button4.BackColor = Color.LightBlue
        Button5.BackColor = Color.LightBlue
        Button6.BackColor = Color.LightBlue
        Button7.BackColor = Color.LightBlue
        Button8.BackColor = Color.LightBlue
        Button9.BackColor = Color.LightBlue
        Button10.BackColor = Color.LightBlue
    End Sub
     Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If turn = 1 Then
            Button1.Text = "O"
            Label2.Text = "X"
        Else
            Button1.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button1.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If turn = 1 Then
            Button2.Text = "O"
            Label2.Text = "X"
        Else
            Button2.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If turn = 1 Then
            Button3.Text = "O"
            Label2.Text = "X"
        Else
            Button3.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If turn = 1 Then
            Button4.Text = "O"
            Label2.Text = "X"
        Else
            Button4.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If turn = 1 Then
            Button5.Text = "O"
            Label2.Text = "X"
        Else
            Button5.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If turn = 1 Then
            Button6.Text = "O"
            Label2.Text = "X"
        Else
            Button6.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If turn = 1 Then
            Button7.Text = "O"
            Label2.Text = "X"
        Else
            Button7.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If turn = 1 Then
            Button8.Text = "O"
            Label2.Text = "X"
        Else
            Button8.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If turn = 1 Then
            Button9.Text = "O"
            Label2.Text = "X"
        Else
            Button9.Text = "X"
            Label2.Text = "O"
        End If
        turn += 1
        If turn > 2 Then
            turn = 1
        End If
        Call win()
        Button9.Enabled = False
    End Sub
     Private Sub disablebuttons()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False

    End Sub
     Private Sub win()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MessageBox.Show("Player X wins!")
            Label6.Text += 1
            Call disablebuttons()
    End Sub
End Class
