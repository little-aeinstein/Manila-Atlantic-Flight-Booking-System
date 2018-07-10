<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlightList
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
        Me.btnShowPassRep = New System.Windows.Forms.Button()
        Me.btnShowPassList = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvFlgt = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbbxOrigin = New System.Windows.Forms.ComboBox()
        Me.cmbbxDestination = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbbxDay = New System.Windows.Forms.ComboBox()
        Me.cmbbxMonth = New System.Windows.Forms.ComboBox()
        Me.cmbbxYear = New System.Windows.Forms.ComboBox()
        Me.cmbbxStatus = New System.Windows.Forms.ComboBox()
        CType(Me.dgvFlgt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Flights"
        '
        'btnShowPassRep
        '
        Me.btnShowPassRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassRep.Location = New System.Drawing.Point(650, 353)
        Me.btnShowPassRep.Name = "btnShowPassRep"
        Me.btnShowPassRep.Size = New System.Drawing.Size(192, 31)
        Me.btnShowPassRep.TabIndex = 3
        Me.btnShowPassRep.Text = "Show Passenger List"
        Me.btnShowPassRep.UseVisualStyleBackColor = True
        '
        'btnShowPassList
        '
        Me.btnShowPassList.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowPassList.Location = New System.Drawing.Point(432, 353)
        Me.btnShowPassList.Name = "btnShowPassList"
        Me.btnShowPassList.Size = New System.Drawing.Size(192, 31)
        Me.btnShowPassList.TabIndex = 4
        Me.btnShowPassList.Text = "Show Passenger Report"
        Me.btnShowPassList.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(869, 351)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(192, 31)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvFlgt
        '
        Me.dgvFlgt.AllowUserToAddRows = False
        Me.dgvFlgt.AllowUserToDeleteRows = False
        Me.dgvFlgt.AllowUserToOrderColumns = True
        Me.dgvFlgt.AllowUserToResizeColumns = False
        Me.dgvFlgt.AllowUserToResizeRows = False
        Me.dgvFlgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlgt.Location = New System.Drawing.Point(16, 80)
        Me.dgvFlgt.Name = "dgvFlgt"
        Me.dgvFlgt.ReadOnly = True
        Me.dgvFlgt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlgt.Size = New System.Drawing.Size(1045, 256)
        Me.dgvFlgt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Origin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(223, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Destination"
        '
        'cmbbxOrigin
        '
        Me.cmbbxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxOrigin.FormattingEnabled = True
        Me.cmbbxOrigin.Location = New System.Drawing.Point(66, 48)
        Me.cmbbxOrigin.Name = "cmbbxOrigin"
        Me.cmbbxOrigin.Size = New System.Drawing.Size(136, 26)
        Me.cmbbxOrigin.TabIndex = 9
        '
        'cmbbxDestination
        '
        Me.cmbbxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDestination.FormattingEnabled = True
        Me.cmbbxDestination.Location = New System.Drawing.Point(311, 48)
        Me.cmbbxDestination.Name = "cmbbxDestination"
        Me.cmbbxDestination.Size = New System.Drawing.Size(136, 26)
        Me.cmbbxDestination.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(479, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(592, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Month"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(734, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(866, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Status"
        '
        'cmbbxDay
        '
        Me.cmbbxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDay.FormattingEnabled = True
        Me.cmbbxDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbbxDay.Location = New System.Drawing.Point(519, 48)
        Me.cmbbxDay.Name = "cmbbxDay"
        Me.cmbbxDay.Size = New System.Drawing.Size(58, 26)
        Me.cmbbxDay.TabIndex = 15
        '
        'cmbbxMonth
        '
        Me.cmbbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxMonth.FormattingEnabled = True
        Me.cmbbxMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbbxMonth.Location = New System.Drawing.Point(648, 48)
        Me.cmbbxMonth.Name = "cmbbxMonth"
        Me.cmbbxMonth.Size = New System.Drawing.Size(66, 26)
        Me.cmbbxMonth.TabIndex = 16
        '
        'cmbbxYear
        '
        Me.cmbbxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxYear.FormattingEnabled = True
        Me.cmbbxYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.cmbbxYear.Location = New System.Drawing.Point(778, 48)
        Me.cmbbxYear.Name = "cmbbxYear"
        Me.cmbbxYear.Size = New System.Drawing.Size(64, 26)
        Me.cmbbxYear.TabIndex = 17
        '
        'cmbbxStatus
        '
        Me.cmbbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxStatus.FormattingEnabled = True
        Me.cmbbxStatus.Location = New System.Drawing.Point(922, 48)
        Me.cmbbxStatus.Name = "cmbbxStatus"
        Me.cmbbxStatus.Size = New System.Drawing.Size(64, 26)
        Me.cmbbxStatus.TabIndex = 18
        '
        'frmFlightList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1079, 396)
        Me.Controls.Add(Me.cmbbxStatus)
        Me.Controls.Add(Me.cmbbxYear)
        Me.Controls.Add(Me.cmbbxMonth)
        Me.Controls.Add(Me.cmbbxDay)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbbxDestination)
        Me.Controls.Add(Me.cmbbxOrigin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvFlgt)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnShowPassList)
        Me.Controls.Add(Me.btnShowPassRep)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFlightList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flight List"
        CType(Me.dgvFlgt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowPassRep As Button
    Friend WithEvents btnShowPassList As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvFlgt As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbbxOrigin As ComboBox
    Friend WithEvents cmbbxDestination As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbbxDay As ComboBox
    Friend WithEvents cmbbxMonth As ComboBox
    Friend WithEvents cmbbxYear As ComboBox
    Friend WithEvents cmbbxStatus As ComboBox
End Class
