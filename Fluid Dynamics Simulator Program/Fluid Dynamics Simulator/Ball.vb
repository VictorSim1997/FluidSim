Public Class Ball
    Private p_radius As Integer
    Private p_density As Double
    Private p_top As Double
    Private p_material As String
    Private p_volume As Double
    Private p_mass As Double
    Private p_weight As Double
    Private p_image As PictureBox
    Const g = 9.81
    Const steelDensity = 8.05
    Const marbleDensity = 2.4

    Public Sub ChangeColour(fluid)
        'Changes the backcolour of the ball according to the fluid so that the backcolour of the ball matched the fluid colour
        Select Case fluid
            Case "Glycerol"
                p_image.BackColor = Color.FromArgb(255, 215, 215, 215)
            Case "Sunflower oil"
                p_image.BackColor = Color.Yellow
            Case "Coconut oil"
                p_image.BackColor = Color.FromArgb(255, 225, 230, 30)
            Case "Olive oil"
                p_image.BackColor = Color.FromArgb(255, 200, 200, 60)
            Case Else
                p_image.BackColor = Control.DefaultBackColor
        End Select
    End Sub

    Public Sub CalculateVolume(radius As Integer)
        'Radius is in units of mm
        p_volume = (4 * System.Math.PI * (radius / 1000) ^ 3) / 3
    End Sub

    Public Sub Calculatemass(volume, density)
        'density is in g/cm^3 so have to convert it to kg/m^3 by multiplying by 1000
        p_mass = volume * density * 1000
    End Sub

    Public Function Getweight()
        'Calculates the weight using mass
        p_weight = p_mass * g
        Return p_weight
    End Function

    Public Function GetDensity()
        Dim density As Double
        'Assigns the density according to what material and returns the density
        If p_material = "steel" Then
            density = steelDensity
        ElseIf p_material = "marble" Then
            density = marbleDensity
        End If
        Return density
    End Function

    Property image As PictureBox
        Get
            Return p_image
        End Get
        Set(value As PictureBox)
            p_image = value
        End Set
    End Property

    Property Material As String
        Get
            Return p_material
        End Get
        Set(value As String)
            p_material = value
        End Set
    End Property

    Property Y As Double
        Get
            Return p_top
        End Get
        Set(value As Double)
            p_top = value
        End Set
    End Property

    Property radius As Integer
        Get
            Return p_radius
        End Get
        Set(value As Integer)
            p_radius = value
        End Set
    End Property

    Property density As Double
        Get
            Return p_density
        End Get
        Set(value As Double)
            p_density = value
        End Set
    End Property

    Property volume As Double
        Get
            Return p_volume
        End Get
        Set(value As Double)
            p_volume = value
        End Set
    End Property

    Property weight
        Get
            Return p_weight
        End Get
        Set(value)
            p_weight = value
        End Set
    End Property

    Property mass
        Get
            Return p_mass
        End Get
        Set(value)
            p_mass = value
        End Set
    End Property
End Class
