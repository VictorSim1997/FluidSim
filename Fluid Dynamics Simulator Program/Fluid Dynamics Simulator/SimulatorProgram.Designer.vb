<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimulatorProgram
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.lblSimulator = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrentVelocity = New System.Windows.Forms.Label()
        Me.lblTerminalVelocity = New System.Windows.Forms.Label()
        Me.lblViscousDrag = New System.Windows.Forms.Label()
        Me.lblUpthrust = New System.Windows.Forms.Label()
        Me.cboSelectBall = New System.Windows.Forms.ComboBox()
        Me.scrRadius = New System.Windows.Forms.TrackBar()
        Me.scrDensity = New System.Windows.Forms.TrackBar()
        Me.cboSelectFluid = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblDensity = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tube = New System.Windows.Forms.PictureBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblFluidDensity = New System.Windows.Forms.Label()
        Me.lblViscosity = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrRadius, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scrDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.SystemColors.Control
        Me.Ball.Location = New System.Drawing.Point(243, 200)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(20, 20)
        Me.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ball.TabIndex = 0
        Me.Ball.TabStop = False
        '
        'lblSimulator
        '
        Me.lblSimulator.AutoSize = True
        Me.lblSimulator.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimulator.Location = New System.Drawing.Point(138, 9)
        Me.lblSimulator.Name = "lblSimulator"
        Me.lblSimulator.Size = New System.Drawing.Size(325, 59)
        Me.lblSimulator.TabIndex = 1
        Me.lblSimulator.Text = "SIMULATOR"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(388, 71)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(484, 71)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 3
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please select your ball:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(394, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Create your own custom ball:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Please select your fluid:"
        '
        'lblCurrentVelocity
        '
        Me.lblCurrentVelocity.AutoSize = True
        Me.lblCurrentVelocity.Location = New System.Drawing.Point(26, 155)
        Me.lblCurrentVelocity.Name = "lblCurrentVelocity"
        Me.lblCurrentVelocity.Size = New System.Drawing.Size(84, 13)
        Me.lblCurrentVelocity.TabIndex = 7
        Me.lblCurrentVelocity.Text = "Current Velocity:"
        '
        'lblTerminalVelocity
        '
        Me.lblTerminalVelocity.AutoSize = True
        Me.lblTerminalVelocity.Location = New System.Drawing.Point(26, 195)
        Me.lblTerminalVelocity.Name = "lblTerminalVelocity"
        Me.lblTerminalVelocity.Size = New System.Drawing.Size(90, 13)
        Me.lblTerminalVelocity.TabIndex = 8
        Me.lblTerminalVelocity.Text = "Terminal Velocity:"
        '
        'lblViscousDrag
        '
        Me.lblViscousDrag.AutoSize = True
        Me.lblViscousDrag.Location = New System.Drawing.Point(26, 115)
        Me.lblViscousDrag.Name = "lblViscousDrag"
        Me.lblViscousDrag.Size = New System.Drawing.Size(71, 13)
        Me.lblViscousDrag.TabIndex = 9
        Me.lblViscousDrag.Text = "Viscous drag:"
        '
        'lblUpthrust
        '
        Me.lblUpthrust.AutoSize = True
        Me.lblUpthrust.Location = New System.Drawing.Point(26, 235)
        Me.lblUpthrust.Name = "lblUpthrust"
        Me.lblUpthrust.Size = New System.Drawing.Size(50, 13)
        Me.lblUpthrust.TabIndex = 10
        Me.lblUpthrust.Text = "Upthrust:"
        '
        'cboSelectBall
        '
        Me.cboSelectBall.FormattingEnabled = True
        Me.cboSelectBall.Items.AddRange(New Object() {"", "8mm Steel Ball", "6mm Steel Ball", "8mm Marble Ball", "6mm Marble Ball"})
        Me.cboSelectBall.Location = New System.Drawing.Point(397, 133)
        Me.cboSelectBall.Name = "cboSelectBall"
        Me.cboSelectBall.Size = New System.Drawing.Size(121, 21)
        Me.cboSelectBall.TabIndex = 11
        '
        'scrRadius
        '
        Me.scrRadius.Location = New System.Drawing.Point(359, 256)
        Me.scrRadius.Maximum = 8
        Me.scrRadius.Minimum = 2
        Me.scrRadius.Name = "scrRadius"
        Me.scrRadius.Size = New System.Drawing.Size(104, 45)
        Me.scrRadius.TabIndex = 12
        Me.scrRadius.Value = 2
        '
        'scrDensity
        '
        Me.scrDensity.Location = New System.Drawing.Point(467, 256)
        Me.scrDensity.Minimum = 2
        Me.scrDensity.Name = "scrDensity"
        Me.scrDensity.Size = New System.Drawing.Size(104, 45)
        Me.scrDensity.TabIndex = 13
        Me.scrDensity.Value = 2
        '
        'cboSelectFluid
        '
        Me.cboSelectFluid.FormattingEnabled = True
        Me.cboSelectFluid.Items.AddRange(New Object() {"", "Glycerol", "Sunflower oil", "Coconut oil", "Olive oil"})
        Me.cboSelectFluid.Location = New System.Drawing.Point(397, 347)
        Me.cboSelectFluid.Name = "cboSelectFluid"
        Me.cboSelectFluid.Size = New System.Drawing.Size(121, 21)
        Me.cboSelectFluid.TabIndex = 15
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(26, 275)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 16
        Me.lblWeight.Text = "Weight:"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(26, 315)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(45, 13)
        Me.lblVolume.TabIndex = 17
        Me.lblVolume.Text = "Volume:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(500, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(60, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Main Menu"
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(356, 304)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(68, 13)
        Me.lblRadius.TabIndex = 19
        Me.lblRadius.Text = "Radius: 2mm"
        '
        'lblDensity
        '
        Me.lblDensity.AutoSize = True
        Me.lblDensity.Location = New System.Drawing.Point(464, 304)
        Me.lblDensity.Name = "lblDensity"
        Me.lblDensity.Size = New System.Drawing.Size(85, 13)
        Me.lblDensity.TabIndex = 20
        Me.lblDensity.Text = "Density: 2g/cm3"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Tube
        '
        Me.Tube.BackColor = System.Drawing.SystemColors.Control
        Me.Tube.Location = New System.Drawing.Point(207, 117)
        Me.Tube.Name = "Tube"
        Me.Tube.Size = New System.Drawing.Size(91, 323)
        Me.Tube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tube.TabIndex = 21
        Me.Tube.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(26, 435)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 22
        Me.lblTime.Text = "Time:"
        '
        'lblFluidDensity
        '
        Me.lblFluidDensity.AutoSize = True
        Me.lblFluidDensity.Location = New System.Drawing.Point(26, 355)
        Me.lblFluidDensity.Name = "lblFluidDensity"
        Me.lblFluidDensity.Size = New System.Drawing.Size(68, 13)
        Me.lblFluidDensity.TabIndex = 23
        Me.lblFluidDensity.Text = "Fluid density:"
        '
        'lblViscosity
        '
        Me.lblViscosity.AutoSize = True
        Me.lblViscosity.Location = New System.Drawing.Point(26, 395)
        Me.lblViscosity.Name = "lblViscosity"
        Me.lblViscosity.Size = New System.Drawing.Size(76, 13)
        Me.lblViscosity.TabIndex = 24
        Me.lblViscosity.Text = "Fluid Viscosity:"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(388, 417)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(91, 43)
        Me.btnExport.TabIndex = 25
        Me.btnExport.Text = "Export data"
        Me.btnExport.UseVisualStyleBackColor = True
        Me.btnExport.Visible = False
        '
        'SimulatorProgram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(594, 472)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblViscosity)
        Me.Controls.Add(Me.lblFluidDensity)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.lblDensity)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.cboSelectFluid)
        Me.Controls.Add(Me.scrDensity)
        Me.Controls.Add(Me.scrRadius)
        Me.Controls.Add(Me.cboSelectBall)
        Me.Controls.Add(Me.lblUpthrust)
        Me.Controls.Add(Me.lblViscousDrag)
        Me.Controls.Add(Me.lblTerminalVelocity)
        Me.Controls.Add(Me.lblCurrentVelocity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.lblSimulator)
        Me.Controls.Add(Me.Tube)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SimulatorProgram"
        Me.Text = "Physics Fluid Dynamics Simulator"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrRadius, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scrDensity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ball As System.Windows.Forms.PictureBox
    Friend WithEvents lblSimulator As System.Windows.Forms.Label
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentVelocity As System.Windows.Forms.Label
    Friend WithEvents lblTerminalVelocity As System.Windows.Forms.Label
    Friend WithEvents lblViscousDrag As System.Windows.Forms.Label
    Friend WithEvents lblUpthrust As System.Windows.Forms.Label
    Friend WithEvents cboSelectBall As System.Windows.Forms.ComboBox
    Friend WithEvents scrRadius As System.Windows.Forms.TrackBar
    Friend WithEvents scrDensity As System.Windows.Forms.TrackBar
    Friend WithEvents cboSelectFluid As System.Windows.Forms.ComboBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblDensity As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Tube As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblFluidDensity As System.Windows.Forms.Label
    Friend WithEvents lblViscosity As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button

End Class
