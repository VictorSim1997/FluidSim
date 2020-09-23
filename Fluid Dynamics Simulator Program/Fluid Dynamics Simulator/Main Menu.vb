Public Class MainMenu
    Dim audioDevice As New Microsoft.VisualBasic.Devices.Audio

    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        'Calls subroutine to close all forms
        Shutdown()
        End
    End Sub

    Private Sub Shutdown()
        'Closes all the forms that may be hidden
        SimulatorProgram.Close()
        QuickQuiz.Close()
        CalculationQuiz.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnSimulator.Click
        'Opens up the SimulatorProgram form
        Dim Simulator As New SimulatorProgram
        Simulator.Show()
        'Closes this current form
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnQuickQuiz.Click
        'Opens up the QuickQuiz form
        Dim QuickQuiz As New QuickQuiz
        QuickQuiz.Show()
        'Closes the current form
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculationQuiz.Click
        'Opens up the CalculationQuiz form
        Dim CalculationQuiz As New CalculationQuiz
        CalculationQuiz.Show()
        'Closes the current form
        Me.Hide()
    End Sub

    Private Sub button_clicked(ByVal sender As Object, ByVal e As EventArgs) Handles btnSimulator.Click, btnQuickQuiz.Click, btnCalculationQuiz.Click
        'Plays a sound effect when a button is clicked
        audioDevice.Play(My.Resources.Click, AudioPlayMode.Background)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Sets the backcolour of the form
        Me.BackColor = Color.Beige
    End Sub
End Class