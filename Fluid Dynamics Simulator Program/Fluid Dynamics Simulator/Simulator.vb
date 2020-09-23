Public Class Simulator
    Private p_OldVelocity As Double = 0
    Private p_CurrentVelocity As Double
    Private p_TerminalVelocity As Double
    Private p_ViscousDrag As Double
    Private p_Upthrust As Double
    Private p_Resultant As Double
    Private p_Acceleration As Double
    Private p_Distance As Double
    Const g = 9.81
    Const time = 0.001

    Public Sub CalculateUpthrust(volume, densityOfFluid)
        'Caclulates up-thrust using volume and density
        'Multiplied by 1000 to get it in SI units
        p_Upthrust = volume * densityOfFluid * 1000 * g
    End Sub

    Public Sub CalculateAcceleration(Weight, Mass)
        'Calculates the resultant force
        p_Resultant = Weight - (p_ViscousDrag + p_Upthrust)
        'Uses Newton's 2nd law to get the acceleration
        p_Acceleration = p_Resultant / Mass
    End Sub

    Public Sub CalculateNewVelocity()
        'Uses the SUVAT equation v = u + at
        p_CurrentVelocity = p_OldVelocity + p_Acceleration * time
        'Updates the old velocity to become the new velocity
        p_OldVelocity = p_CurrentVelocity
    End Sub

    Public Sub CalculateDistance()
        'Calculates the distance it should move by using distance = speed * time
        'Multiplies the time by 100000 to get noticable movement because time in order of magnitude 10^-3 and velocities are very small
        p_Distance = p_CurrentVelocity * time * 100000
    End Sub

    Public Sub CalculateTerminalVeloctiy(radius, solidDensity, fluidDensity, viscosity)
        'Calculates the terminal velocity using equation (2r^2(ρs – ρf))/(9η)
        'Divides and multiplies by 1000 to get it into SI units
        p_TerminalVelocity = (2 * (radius / 1000) ^ 2 * g * (solidDensity * 1000 - fluidDensity * 1000)) / (9 * viscosity)
    End Sub

    Public Sub CalculateViscousDrag(radius, viscosity)
        'Calculates the viscous drag acting on the ball using Stokes' law
        p_ViscousDrag = 6 * System.Math.PI * p_CurrentVelocity * radius * viscosity
    End Sub

    Public Function FluidChosen(fluid) As Boolean
        'Checks if there is fluid chosen and returns true if there is or false if there isn't
        FluidChosen = True
        If fluid = "" Then
            FluidChosen = False
        End If
        Return FluidChosen
    End Function

    Property currentVelocity
        Get
            Return p_CurrentVelocity
        End Get
        Set(value)
            p_CurrentVelocity = value
        End Set
    End Property

    Property oldVelocity
        Get
            Return p_OldVelocity
        End Get
        Set(value)
            p_OldVelocity = value
        End Set
    End Property

    Property viscousDrag
        Get
            Return p_ViscousDrag
        End Get
        Set(value)
            p_ViscousDrag = value
        End Set
    End Property

    Property Upthrust
        Get
            Return p_Upthrust
        End Get
        Set(value)
            p_Upthrust = value
        End Set
    End Property

    Property Resultant
        Get
            Return p_Resultant
        End Get
        Set(value)
            p_Resultant = value
        End Set
    End Property

    Property TerminalVelocity
        Get
            Return p_TerminalVelocity
        End Get
        Set(value)
            p_TerminalVelocity = value
        End Set
    End Property

    Property Acceleration
        Get
            Return p_Acceleration
        End Get
        Set(value)
            p_Acceleration = value
        End Set
    End Property

    Property Distance
        Get
            Return p_Distance
        End Get
        Set(value)
            p_Distance = value
        End Set
    End Property
End Class