<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlightType
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
        Me.rdbtnOneWay = New System.Windows.Forms.RadioButton()
        Me.rdbtnRoundTrip = New System.Windows.Forms.RadioButton()
        Me.rdbtnMultiCity = New System.Windows.Forms.RadioButton()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Type of Trip"
        '
        'rdbtnOneWay
        '
        Me.rdbtnOneWay.AutoSize = True
        Me.rdbtnOneWay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnOneWay.Location = New System.Drawing.Point(12, 50)
        Me.rdbtnOneWay.Name = "rdbtnOneWay"
        Me.rdbtnOneWay.Size = New System.Drawing.Size(89, 22)
        Me.rdbtnOneWay.TabIndex = 1
        Me.rdbtnOneWay.TabStop = True
        Me.rdbtnOneWay.Text = "One-Way"
        Me.rdbtnOneWay.UseVisualStyleBackColor = True
        '
        'rdbtnRoundTrip
        '
        Me.rdbtnRoundTrip.AutoSize = True
        Me.rdbtnRoundTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnRoundTrip.Location = New System.Drawing.Point(107, 50)
        Me.rdbtnRoundTrip.Name = "rdbtnRoundTrip"
        Me.rdbtnRoundTrip.Size = New System.Drawing.Size(99, 22)
        Me.rdbtnRoundTrip.TabIndex = 2
        Me.rdbtnRoundTrip.TabStop = True
        Me.rdbtnRoundTrip.Text = "Round Trip"
        Me.rdbtnRoundTrip.UseVisualStyleBackColor = True
        '
        'rdbtnMultiCity
        '
        Me.rdbtnMultiCity.AutoSize = True
        Me.rdbtnMultiCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbtnMultiCity.Location = New System.Drawing.Point(212, 50)
        Me.rdbtnMultiCity.Name = "rdbtnMultiCity"
        Me.rdbtnMultiCity.Size = New System.Drawing.Size(87, 22)
        Me.rdbtnMultiCity.TabIndex = 3
        Me.rdbtnMultiCity.TabStop = True
        Me.rdbtnMultiCity.Text = "Multi-City"
        Me.rdbtnMultiCity.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(61, 93)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 31)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(162, 93)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(83, 31)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmFlightType
        '
        Me.AcceptButton = Me.btnNext
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(306, 144)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rdbtnMultiCity)
        Me.Controls.Add(Me.rdbtnRoundTrip)
        Me.Controls.Add(Me.rdbtnOneWay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFlightType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search a Flight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents rdbtnOneWay As RadioButton
    Friend WithEvents rdbtnRoundTrip As RadioButton
    Friend WithEvents rdbtnMultiCity As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
