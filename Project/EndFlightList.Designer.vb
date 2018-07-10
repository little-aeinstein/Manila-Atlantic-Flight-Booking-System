<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEndFlightList
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
        Me.cmbbxDestination = New System.Windows.Forms.ComboBox()
        Me.cmbbxOrigin = New System.Windows.Forms.ComboBox()
        Me.cmbbxStatus = New System.Windows.Forms.ComboBox()
        Me.dgvFlgt = New System.Windows.Forms.DataGridView()
        Me.btnEndFlgt = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvFlgt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "End a Flight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Origin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Destination"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(476, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'cmbbxDestination
        '
        Me.cmbbxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxDestination.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxDestination.FormattingEnabled = True
        Me.cmbbxDestination.Location = New System.Drawing.Point(311, 51)
        Me.cmbbxDestination.Name = "cmbbxDestination"
        Me.cmbbxDestination.Size = New System.Drawing.Size(136, 26)
        Me.cmbbxDestination.TabIndex = 7
        '
        'cmbbxOrigin
        '
        Me.cmbbxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxOrigin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxOrigin.FormattingEnabled = True
        Me.cmbbxOrigin.Location = New System.Drawing.Point(66, 51)
        Me.cmbbxOrigin.Name = "cmbbxOrigin"
        Me.cmbbxOrigin.Size = New System.Drawing.Size(136, 26)
        Me.cmbbxOrigin.TabIndex = 8
        '
        'cmbbxStatus
        '
        Me.cmbbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbxStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbxStatus.FormattingEnabled = True
        Me.cmbbxStatus.Location = New System.Drawing.Point(532, 51)
        Me.cmbbxStatus.Name = "cmbbxStatus"
        Me.cmbbxStatus.Size = New System.Drawing.Size(58, 26)
        Me.cmbbxStatus.TabIndex = 11
        '
        'dgvFlgt
        '
        Me.dgvFlgt.AllowUserToAddRows = False
        Me.dgvFlgt.AllowUserToDeleteRows = False
        Me.dgvFlgt.AllowUserToOrderColumns = True
        Me.dgvFlgt.AllowUserToResizeColumns = False
        Me.dgvFlgt.AllowUserToResizeRows = False
        Me.dgvFlgt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlgt.Location = New System.Drawing.Point(16, 83)
        Me.dgvFlgt.Name = "dgvFlgt"
        Me.dgvFlgt.ReadOnly = True
        Me.dgvFlgt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlgt.Size = New System.Drawing.Size(1045, 256)
        Me.dgvFlgt.TabIndex = 13
        '
        'btnEndFlgt
        '
        Me.btnEndFlgt.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEndFlgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndFlgt.Location = New System.Drawing.Point(648, 353)
        Me.btnEndFlgt.Name = "btnEndFlgt"
        Me.btnEndFlgt.Size = New System.Drawing.Size(192, 31)
        Me.btnEndFlgt.TabIndex = 14
        Me.btnEndFlgt.Text = "End Flight"
        Me.btnEndFlgt.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(869, 353)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(192, 31)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmEndFlightList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1079, 396)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEndFlgt)
        Me.Controls.Add(Me.dgvFlgt)
        Me.Controls.Add(Me.cmbbxStatus)
        Me.Controls.Add(Me.cmbbxOrigin)
        Me.Controls.Add(Me.cmbbxDestination)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEndFlightList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flight List"
        CType(Me.dgvFlgt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbbxDestination As ComboBox
    Friend WithEvents cmbbxOrigin As ComboBox
    Friend WithEvents cmbbxStatus As ComboBox
    Friend WithEvents dgvFlgt As DataGridView
    Friend WithEvents btnEndFlgt As Button
    Friend WithEvents btnBack As Button
End Class
