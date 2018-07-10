<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchRoundTrip
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbbxOrigin = New System.Windows.Forms.ComboBox()
        Me.cmbbxDestination = New System.Windows.Forms.ComboBox()
        Me.dtpDeptDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpRetDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbbxNumPass = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Round Trip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Origin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Destination"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Departure Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Return Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. of Passengers"
        '
        'cmbbxOrigin
        '
        Me.cmbbxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxOrigin.FormattingEnabled = True
        Me.cmbbxOrigin.Location = New System.Drawing.Point(140, 48)
        Me.cmbbxOrigin.Name = "cmbbxOrigin"
        Me.cmbbxOrigin.Size = New System.Drawing.Size(257, 26)
        Me.cmbbxOrigin.TabIndex = 6
        '
        'cmbbxDestination
        '
        Me.cmbbxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDestination.FormattingEnabled = True
        Me.cmbbxDestination.Location = New System.Drawing.Point(140, 79)
        Me.cmbbxDestination.Name = "cmbbxDestination"
        Me.cmbbxDestination.Size = New System.Drawing.Size(257, 26)
        Me.cmbbxDestination.TabIndex = 7
        '
        'dtpDeptDate
        '
        Me.dtpDeptDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDeptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeptDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeptDate.Location = New System.Drawing.Point(140, 111)
        Me.dtpDeptDate.Name = "dtpDeptDate"
        Me.dtpDeptDate.Size = New System.Drawing.Size(257, 24)
        Me.dtpDeptDate.TabIndex = 8
        '
        'dtpRetDate
        '
        Me.dtpRetDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpRetDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRetDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRetDate.Location = New System.Drawing.Point(140, 141)
        Me.dtpRetDate.Name = "dtpRetDate"
        Me.dtpRetDate.Size = New System.Drawing.Size(257, 24)
        Me.dtpRetDate.TabIndex = 9
        '
        'cmbbxNumPass
        '
        Me.cmbbxNumPass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxNumPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxNumPass.FormattingEnabled = True
        Me.cmbbxNumPass.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbbxNumPass.Location = New System.Drawing.Point(150, 187)
        Me.cmbbxNumPass.Name = "cmbbxNumPass"
        Me.cmbbxNumPass.Size = New System.Drawing.Size(65, 26)
        Me.cmbbxNumPass.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(239, 183)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 31)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(328, 184)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(83, 31)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmSearchRoundTrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 224)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmbbxNumPass)
        Me.Controls.Add(Me.dtpRetDate)
        Me.Controls.Add(Me.dtpDeptDate)
        Me.Controls.Add(Me.cmbbxDestination)
        Me.Controls.Add(Me.cmbbxOrigin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSearchRoundTrip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SearchRoundTrip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbbxOrigin As ComboBox
    Friend WithEvents cmbbxDestination As ComboBox
    Friend WithEvents dtpDeptDate As DateTimePicker
    Friend WithEvents dtpRetDate As DateTimePicker
    Friend WithEvents cmbbxNumPass As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
