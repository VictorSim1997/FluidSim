Public Class Fluid
    Private p_fluid As String
    Private p_density As Double
    Private p_viscosity As Double
    Private p_image As PictureBox
    Const GlycerolDensity = 1.26
    Const SunFlowerOilDensity = 0.93
    Const CoconutOilDensity = 0.924
    Const OliveOilDensity = 0.86
    Const GlycerolViscosity = 1.412
    Const SunFlowerOilViscosity = 0.4914
    Const CoconutOilViscosity = 0.06
    Const OliveOilViscosity = 0.1075

    Public Sub Changecolour()
        'Loads a tube with a different colour depending on what fluid is selected
        Select Case p_fluid
            Case "Glycerol"
                p_image.Image = My.Resources.Glycerol_test_tube
            Case "Sunflower oil"
                p_image.Image = My.Resources.Sunflower_test_tube
            Case "Coconut oil"
                p_image.Image = My.Resources.Coconut_oil_test_tube
            Case "Olive oil"
                p_image.Image = My.Resources.Olive_oil_test_tube
            Case Else
                p_image.Image = My.Resources.Test_tube
        End Select
    End Sub

    Public Function GetDensity()
        'Gets the density of the fluid and returns it according to what is the selected fluid
        Select Case p_fluid
            Case "Glycerol"
                p_density = GlycerolDensity
            Case "Sunflower oil"
                p_density = SunFlowerOilDensity
            Case "Coconut oil"
                p_density = CoconutOilDensity
            Case "Olive oil"
                p_density = OliveOilDensity
        End Select
        Return p_density
    End Function

    Public Function GetViscosity()
        'Gets viscosity of the fluid and returns it according to what is the selected fluid
        Select Case p_fluid
            Case "Glycerol"
                p_viscosity = GlycerolViscosity
            Case "Sunflower oil"
                p_viscosity = SunFlowerOilViscosity
            Case "Coconut oil"
                p_viscosity = CoconutOilViscosity
            Case "Olive oil"
                p_viscosity = OliveOilViscosity
        End Select
        Return p_viscosity
    End Function

    Property image As PictureBox
        Get
            Return p_image
        End Get
        Set(value As PictureBox)
            p_image = value
        End Set
    End Property

    Property fluid As String
        Get
            Return p_fluid
        End Get
        Set(value As String)
            p_fluid = value
        End Set
    End Property

    Property density As Single
        Get
            Return p_density
        End Get
        Set(value As Single)
            p_density = value
        End Set
    End Property

    Property viscosity As Single
        Get
            Return p_viscosity
        End Get
        Set(value As Single)
            p_viscosity = value
        End Set
    End Property
End Class
