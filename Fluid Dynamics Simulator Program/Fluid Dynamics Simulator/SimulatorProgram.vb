Imports System.IO

Public Class SimulatorProgram
    Dim myBall As New Ball
    Dim myFluid As New Fluid
    Dim mySimulator As New Simulator
    Dim Time As Single
    Dim data(5, 999) As String
    Dim position As Integer = 1

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        'Closes the program
        Shutdown()
        End
    End Sub

    Private Sub Shutdown()
        'Closes all the other forms that is hidden
        MainMenu.Close()
        QuickQuiz.Close()
        CalculationQuiz.Close()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Initiaise the initial components
        FormInit()
    End Sub

    Private Sub FormInit()
        'Loads the initial images such as the ball and tube
        myFluid.image = Tube
        myFluid.image.Image = My.Resources.Test_tube
        myball.image = Ball
        myBall.image.Image = My.Resources.Ball
        myball.Y = 210
        'Sets the initial properties of the ball 
        LoadDefaultBall()
        'Loads colour background
        Me.BackColor = Color.Beige
    End Sub

    Private Sub LoadDefaultBall()
        'Sets the initial properties of the ball
        myball.radius = 2
        myball.density = 2
        lblRadius.Text = "Radius: " & scrRadius.Value & "mm"
        lblDensity.Text = "Density: " & scrDensity.Value & "g/cm3"
        myball.CalculateVolume(myball.radius)
        lblVolume.Text = "Volume: " & Math.Round(myball.volume, 10) & " m3"
        myball.Calculatemass(myball.volume, myball.density)
        lblWeight.Text = "Weight: " & Math.Round(myball.Getweight(), 5) & " N"
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Takes them back to the main menu
        Dim MainMenu As New MainMenu
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles scrRadius.Scroll
        'Allows the user to change the radius of the ball
        'Changes the radius value of the ball
        myball.radius = scrRadius.Value
        'Adjusts the visual size of the ball
        changeSizeOfBall()
        'Resets all the variables of the simulation and enables the run button
        ReadyForNextRun()
        'Updates the output of the ball properties to the user
        ChangeSolidVariables()
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles scrDensity.Scroll
        'Allows the user to change the denisty of the ball
        'Changes the density of the ball
        myball.density = scrDensity.Value
        'Doesn't actually change size of the ball but needed to reset the ball to its original position for next run
        changeSizeOfBall()
        'Resets all the variables of the simulation and enables the run button
        ReadyForNextRun()
        'Updates the output of the ball properties to the user
        ChangeSolidVariables()
        'Loads a different ball to show that this ball doesn't have the same density as glass (marble ball) or steel
        myBall.image.Image = My.Resources.Ball
    End Sub

    Private Sub changeSizeOfBall()
        'Changes the size of the ball
        myball.image.Size = New Size(myball.radius * 10, myball.radius * 10)
        'Keeps location at the center of the tube
        myball.image.Location = New Point(253 - myball.radius * 5, 210 - myball.radius * 5)
        'Sets the vertical position property of the ball
        myball.Y = 210 - myball.radius * 5
    End Sub

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        'Runs the simulation
        'Checks if there is a fluid chosen
        If mySimulator.FluidChosen(myFluid.fluid) = True Then
            'Enables timer to start the animation
            Timer1.Enabled = True
            'Disables the radius and density slider to prevent the user from changing the properties of the ball in the middle of the simulation
            scrRadius.Enabled = False
            scrDensity.Enabled = False
            'Disables the combo box for selecting the ball and fluid to prevent the user from changing them in the middle of the simulation
            cboSelectBall.Enabled = False
            cboSelectFluid.Enabled = False
            'Hides the export button until simulation finishes
            btnExport.Visible = False
            'Resets the timer to 0
            Time = 0
        Else
            'Alerts the user that they haven't chosen a fluid yet
            MsgBox("No fluid is chosen!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs) Handles btnPause.Click
        'Pausese the simulation
        'Disables the timer
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'This procedure controls everything that needs to be updated or checked every timer tick
        'Updates all the properties of the simulation which keeps on changing
        UpdateVariables()
        'Controls the animation of the ball
        MoveBall()
        'Stops the ball when it is going out of the tube
        CheckGoingOutOfScreen()
    End Sub

    Private Sub UpdateVariables()
        'Updates the variables of the simulation
        'Stores the data of the variables in an array every timer tick to export the data afterwards
        data(0, position) = Time
        data(1, position) = mySimulator.currentVelocity
        data(2, position) = mySimulator.Resultant
        data(3, position) = mySimulator.viscousDrag
        data(4, position) = mySimulator.Acceleration
        'Increments the position by one to start a new row for the next set of data
        position += 1
        'Outputs the time that has passed
        lblTime.Text = "Time: " & Math.Round(Time, 3) & " s"
        Time += 0.001
        'Calculates then outputs the upthrust
        mySimulator.CalculateUpthrust(myball.volume, myFluid.density)
        lblUpthrust.Text = "Upthrust: " & Math.Round(mySimulator.Upthrust, 5) & " N"
        'Calculates then outputs the viscous drag
        mySimulator.CalculateViscousDrag(myball.radius / 1000, myFluid.viscosity)
        lblViscousDrag.Text = "Viscous drag: " & Math.Round(mySimulator.viscousDrag, 5) & " N"
        'Caclulates the acceleration (no need for output)
        mySimulator.CalculateAcceleration(myball.weight, myball.mass)
        'Calculates then outputs the current velocity
        mySimulator.CalculateNewVelocity()
        lblCurrentVelocity.Text = "Velocity: " & Math.Round(mySimulator.currentVelocity, 5) & " ms-1"
        'Calculates then outputs the terminal velocity
        mySimulator.CalculateTerminalVeloctiy(myball.radius, myball.density, myFluid.density, myFluid.viscosity)
        lblTerminalVelocity.Text = "Terminal velocity: " & Math.Round(mySimulator.TerminalVelocity, 5) & " ms-1"
    End Sub

    Private Sub MoveBall()
        'Sets the myball.image.top property to the myball.Y property which is getting updated
        myball.image.Top = myball.Y
        'Calculates the distance it should move
        mySimulator.CalculateDistance()
        'Moves the position of the ball by a set distance
        myball.Y += mySimulator.Distance
    End Sub

    Private Sub CheckGoingOutOfScreen()
        'Makes sure the ball doesn't go out of the tube
        If myball.Y + myball.image.Height > 438 Then
            'Allows the user to set up the next run
            PrepareForNextRun()
        End If
    End Sub

    Private Sub ChangeSolidVariables()
        'Changes the output of the variables of the ball
        'Outputs the new values for the radius and density
        lblRadius.Text = "Radius: " & scrRadius.Value & "mm"
        lblDensity.Text = "Density: " & scrDensity.Value & "g/cm3"
        'Calculates the new volume and outputs the new volume
        myball.CalculateVolume(myball.radius)
        lblVolume.Text = "Volume: " & Math.Round(myball.volume, 10) & " m3"
        'Calculates the new mass and outputs the new mass
        myball.Calculatemass(myball.volume, myball.density)
        lblWeight.Text = "Weight: " & Math.Round(myball.Getweight(), 5) & " N"
    End Sub

    Private Sub PrepareForNextRun()
        'disables the timer and run button
        Timer1.Enabled = False
        btnRun.Enabled = False
        'Enables the user to set a new radius ad density
        scrRadius.Enabled = True
        scrDensity.Enabled = True
        cboSelectBall.Enabled = True
        cboSelectFluid.Enabled = True
        'Gives the user an option to export data
        btnExport.Visible = True
    End Sub

    Private Sub cboSelectBall_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelectBall.SelectedIndexChanged
        'Prepares for next run since new ball is selected
        ReadyForNextRun()
        'Changes the material therefore density, radius and picture of the ball
        SelectBall()
        'Outputs the new properties of the ball
        ChangeSolidVariables()
    End Sub

    Private Sub ReadyForNextRun()
        'Enables the run button for next run
        btnRun.Enabled = True
        'Resets all the variables for next run
        mySimulator.currentVelocity = 0
        mySimulator.TerminalVelocity = 0
        mySimulator.viscousDrag = 0
        mySimulator.Resultant = 0
        mySimulator.Acceleration = 0
        mySimulator.oldVelocity = 0
        'Resets the data stored in the data array to be exported to a csv file
        For x = 1 To Time * 1000 + 1
            data(0, x) = ""
            data(1, x) = ""
            data(2, x) = ""
            data(3, x) = ""
            data(4, x) = ""
        Next
        'Resets the position of the data array which the program is writing to back to one
        position = 1
    End Sub

    Private Sub SelectBall()
        'Select case statement to assign the ball its properties according to what was selected
        Select Case cboSelectBall.Text
            Case "8mm Steel Ball"
                myball.Material = "steel"
                myball.radius = 8
                myball.density = myball.GetDensity()
                myBall.image.Image = My.Resources.Steel_ball
            Case "6mm Steel Ball"
                myball.Material = "steel"
                myball.radius = 6
                myball.density = myball.GetDensity()
                myBall.image.Image = My.Resources.Steel_ball
            Case "6mm Marble Ball"
                myball.Material = "marble"
                myball.radius = 6
                myball.density = myball.GetDensity()
                myBall.image.Image = My.Resources.Marble_ball
            Case "8mm Marble Ball"
                myball.Material = "marble"
                myball.radius = 8
                myball.density = myball.GetDensity()
                myBall.image.Image = My.Resources.Marble_ball
        End Select
        'Changes the size of the picture of the ball so that the user can see the difference
        changeSizeOfBall()
    End Sub

    Private Sub cboSelectFluid_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSelectFluid.SelectedIndexChanged
        'Assigns what fluid is being used to the fluid property in the fluid class
        SelectFluid()
        'Outputs the new fluid properties
        ChangeFluidVariables()
    End Sub

    Private Sub SelectFluid()
        'Changes the value of fluid in the fluid class based on what was selected
        Select Case cboSelectFluid.Text
            Case "Glycerol"
                myFluid.fluid = "Glycerol"
            Case "Sunflower oil"
                myFluid.fluid = "Sunflower oil"
            Case "Coconut oil"
                myFluid.fluid = "Coconut oil"
            Case "Olive oil"
                myFluid.fluid = "Olive oil"
            Case Else
                myFluid.fluid = ""
        End Select
        'Changes the properties of the fluid
        myFluid.density = myFluid.GetDensity()
        myFluid.viscosity = myFluid.GetViscosity()
        'Changes the image of the fluid
        myFluid.Changecolour()
        'Changes the backcolour of the ball to match that of the fluid so it looks transparent
        myball.ChangeColour(myFluid.fluid)
        'Gets ready for next run by reseting all the variables
        ReadyForNextRun()
        'Puts ball back to initial position
        changeSizeOfBall()
    End Sub

    Private Sub ChangeFluidVariables()
        'Outputs the new values for density and viscosity
        lblFluidDensity.Text = "Fluid density: " & myFluid.density & " g/cm3"
        lblViscosity.Text = "Viscosity: " & myFluid.viscosity & " Pas"
    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click
        'Creates a streamwrite class
        Dim StreamToWrite As StreamWriter
        Dim FileLocation As String

        'User inputs where they want to write the file and the file name
        FileLocation = InputBox("Please type in the file path followed by the file name which you want it to be called followed by .csv")
        If FileLocation <> "" Then
            Try
                StreamToWrite = New StreamWriter(FileLocation)
                'Write the first row of the table
                StreamToWrite.Write("Time (s)" & "," & "Velocity (m/s)" & "," & "Resultant force (N)" & "," & "Viscous drag (N)" & "," & "Acceleration (m/s^2)")
                'Writes all the information that doesn't need to be updated every timer tick
                StreamToWrite.Write(",," & "Terminal velocity" & "," & mySimulator.TerminalVelocity & "," & "m/s" & "," & "Upthrust" & "," & _
                                    mySimulator.Upthrust & "," & "N" & "," & "Radius" & "," & myBall.radius & "," & "mm" & "," & "Weight" & "," & _
                                    myBall.weight & "," & "N" & "," & "Volume" & "," & myBall.volume & "," & "m^3" & "," & "Density of ball" & "," & _
                                    myBall.density & "," & "g/cm^3" & "," & "Fluid" & "," & myFluid.fluid & "," & "Fluid density" & "," & myFluid.density & _
                                    "," & "g/cm^3" & "," & "Viscosity" & "," & myFluid.viscosity & "," & "Pas")
                'Creates next row
                StreamToWrite.Write(vbCrLf)
                'Writes the data row by row from the array that stored the values of simulation just now
                'The time is multiplied by 1000 because they go in 0.001 second intervals so 0.001*1000 = 1 and + 1 because time starts from 0
                For x = 1 To Time * 1000 + 1
                    StreamToWrite.Write(data(0, x) & ",")
                    StreamToWrite.Write(data(1, x) & ",")
                    StreamToWrite.Write(data(2, x) & ",")
                    StreamToWrite.Write(data(3, x) & ",")
                    StreamToWrite.Write(data(4, x))
                    StreamToWrite.Write(vbCrLf)
                Next
                'Notifies user data has been exported
                MsgBox("Data exported!", MsgBoxStyle.Exclamation)
                'Closes streamwriter file so can write again next time
                StreamToWrite.Close()
            Catch ex As Exception
                'Alerts the user that an error has occured
                MsgBox("Invalid file location/File is open", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class