Imports System.IO

Public Class Quiz
    Private p_score As Integer
    Private z As Integer
    Private x As Integer = 0
    Private Questions(50) As String
    Private questionNo As Integer
    Private audioDevice As New Microsoft.VisualBasic.Devices.Audio

    Public Sub ReadFile(quiztype)
        'Creates streamreader class
        Dim fileReader As StreamReader
        'Reads the short questions for QuickQuiz by default
        fileReader = New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Short questions.csv")
        'If it is the CalculationQuiz thenr reads in the calculation questions
        If quiztype = "calculate" Then
            fileReader = New StreamReader(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Long questions.csv")
        End If
        'Stores each line of the file in an array until end of file is reached
        Do
            Questions(x) = fileReader.ReadLine()
            x += 1
        Loop Until fileReader.EndOfStream
        'Closes filereader so it can read files again later
        fileReader.Close()
        'Redims the Questions array which was initially Questions(50) to how many questions there actually are on the document to save memory space
        ReDim Preserve Questions(x)
    End Sub

    Public Sub CheckAnswer(ByVal Answer As String, ByRef Correct As Boolean)
        'Converts the use input to capital letters so that it is not case sensitive
        'Checks user's answer with answer part of the line
        If UCase(Answer) = Mid(Questions(questionNo), z + 2, Len(Questions(questionNo)) - z + 2) Then
            'Executes these lines if the user got it right
            'Plays sound effect indicating the user got it right
            audioDevice.Play(My.Resources.Correct, AudioPlayMode.Background)
            'Updates score
            p_score += 10
        Else
            'Execute these lines if the user got it wrong
            'Plays a sound effect indicating the user got it wrong
            audioDevice.Play(My.Resources.Incorrect, AudioPlayMode.Background)
            Correct = False
            'Outputs the correct answer for user's knowledge
            MsgBox("Sorry you got that wrong! The correct answer was: " & Mid(Questions(questionNo), z + 2, Len(Questions(questionNo)) - z + 2))
            'Outputs their score and a message depending on how high their score is
            If Score > 50 Then
                MsgBox("You got a score of: " & p_score & ". Well done!")
            ElseIf Score > 0 Then
                MsgBox("You got a score of: " & p_score & ". Good effort!")
            Else
                MsgBox("You got a score of: " & p_score & ". Need to work harder!")
            End If
        End If
    End Sub

    Public Sub UpdateArray()
        Dim y As Integer
        'Shifts the position of questions in the array below the selected question up by a position of 1
        For y = questionNo To (x - 1)
            Questions(y) = Questions(y + 1)
        Next
        'Subtract 1 from the value of x to show how many questions are left remaining
        x -= 1
        'Redim preserves the array so that a 'blank' question would not be picked
        ReDim Preserve Questions(x)
    End Sub

    Function GenerateQuestion()
        Dim firstpos As Boolean = False
        Dim secondpos As Boolean = False
        Dim y As Integer
        'x = 0 when all questions answered
        If x = 0 Then
            MsgBox("Well done you finished the game!")
            MsgBox("You got a score of: " & p_score & ". Well done!")
            Return Nothing
        Else
            y = 1
            'Chooses a random question
            questionNo = CInt(Int(Rnd() * x))
            'Gets question part of the csv file
            Do
                If Mid(Questions(questionNo), y, 1) = "," Then
                    firstpos = True
                Else
                    y += 1
                End If
            Loop Until firstpos = True
            z = y + 2
            Do
                If Mid(Questions(questionNo), z, 1) = "," Then
                    secondpos = True
                Else
                    z += 1
                End If
            Loop Until secondpos = True
            'Outputs the question
            Return Mid(Questions(questionNo), y + 2, z - (y + 2))
        End If
    End Function

    Property Score As Integer
        Get
            Return p_score
        End Get
        Set(value As Integer)
            p_score = value
        End Set
    End Property
End Class

