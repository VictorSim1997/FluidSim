<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimulator = New System.Windows.Forms.Button()
        Me.btnQuickQuiz = New System.Windows.Forms.Button()
        Me.btnCalculationQuiz = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(598, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Physics Fluid Dynamics"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(168, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 59)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Simulator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Please select your mode:"
        '
        'btnSimulator
        '
        Me.btnSimulator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnSimulator.Location = New System.Drawing.Point(200, 214)
        Me.btnSimulator.Name = "btnSimulator"
        Me.btnSimulator.Size = New System.Drawing.Size(190, 23)
        Me.btnSimulator.TabIndex = 3
        Me.btnSimulator.Text = "Simulator"
        Me.btnSimulator.UseVisualStyleBackColor = True
        '
        'btnQuickQuiz
        '
        Me.btnQuickQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnQuickQuiz.Location = New System.Drawing.Point(200, 270)
        Me.btnQuickQuiz.Name = "btnQuickQuiz"
        Me.btnQuickQuiz.Size = New System.Drawing.Size(190, 23)
        Me.btnQuickQuiz.TabIndex = 4
        Me.btnQuickQuiz.Text = "Quick Quiz"
        Me.btnQuickQuiz.UseVisualStyleBackColor = True
        '
        'btnCalculationQuiz
        '
        Me.btnCalculationQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnCalculationQuiz.Location = New System.Drawing.Point(200, 329)
        Me.btnCalculationQuiz.Name = "btnCalculationQuiz"
        Me.btnCalculationQuiz.Size = New System.Drawing.Size(190, 23)
        Me.btnCalculationQuiz.TabIndex = 5
        Me.btnCalculationQuiz.Text = "Calculation Quiz"
        Me.btnCalculationQuiz.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 472)
        Me.Controls.Add(Me.btnCalculationQuiz)
        Me.Controls.Add(Me.btnQuickQuiz)
        Me.Controls.Add(Me.btnSimulator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Text = "Physics Fluid Dynamics Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSimulator As System.Windows.Forms.Button
    Friend WithEvents btnQuickQuiz As System.Windows.Forms.Button
    Friend WithEvents btnCalculationQuiz As System.Windows.Forms.Button
End Class
