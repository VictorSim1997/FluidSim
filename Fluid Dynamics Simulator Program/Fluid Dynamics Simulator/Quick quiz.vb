Imports System.IO

Public Class QuickQuiz
    Dim myQuiz As New Quiz

    Private Sub Form3_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        'Closes the program
        Shutdown()
        End
    End Sub

    Private Sub Shutdown()
        'Closes the hidden forms
        MainMenu.Close()
        SimulatorProgram.Close()
        CalculationQuiz.Close()
    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Uses randomize to make sure the order of questions are different each time
        Randomize()
        'Tells the quiz class that this is the QuickQuiz not the CalculationQuiz and so reads in the correct file for the questions
        myQuiz.readFile("quick")
        'Sets the backcolour of the form
        Me.BackColor = Color.Beige
        'Calls procedure to display question
        OutputQuestion()
    End Sub

    Private Sub OutputQuestion()
        'Displays the question on the label with the randomly selected question
        lblQuestion.Text = myQuiz.GenerateQuestion()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Displays main menu
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        'Hides the current form
        Me.Hide()
    End Sub

    Private Sub btnAnswer_Click(sender As System.Object, e As System.EventArgs) Handles btnAnswer.Click
        Dim Correct As Boolean = True
        'Checks the answer inputted by the user
        myQuiz.CheckAnswer(txtAnswer.Text, Correct)
        'Updates score
        lblScore.Text = "Score: " & myQuiz.Score
        'Clears textbox space for user's answer and prepares next question if the user got it rihgt.
        'Otherwise, disables the answer button meaning the quiz has finished
        If Correct = True Then
            txtAnswer.Text = ""
            Proceed()
        Else
            btnAnswer.Enabled = False
        End If
    End Sub

    Private Sub Proceed()
        'Updates array so same question won't be displayed twice
        myQuiz.UpdateArray()
        'Outputs new question
        OutputQuestion()
    End Sub
End Class