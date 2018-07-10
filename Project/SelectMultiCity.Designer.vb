<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectMultiCity
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
        Me.dgvFlgt1 = New System.Windows.Forms.DataGridView()
        Me.dgvFlgt3 = New System.Windows.Forms.DataGridView()
        Me.dgvFlgt2 = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.dgvFlgt1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFlgt3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFlgt2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Multi-city Trip"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Flight 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Flight  2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Flight 3"
        '
        'dgvFlgt1
        '
        Me.dgvFlgt1.AllowUserToAddRows = False
        Me.dgvFlgt1.AllowUserToDeleteRows = False
        Me.dgvFlgt1.AllowUserToOrderColumns = True
        Me.dgvFlgt1.AllowUserToResizeColumns = False
        Me.dgvFlgt1.AllowUserToResizeRows = False
        Me.dgvFlgt1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlgt1.Location = New System.Drawing.Point(16, 72)
        Me.dgvFlgt1.Name = "dgvFlgt1"
        Me.dgvFlgt1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlgt1.Size = New System.Drawing.Size(760, 116)
        Me.dgvFlgt1.TabIndex = 4
        '
        'dgvFlgt3
        '
        Me.dgvFlgt3.AllowUserToAddRows = False
        Me.dgvFlgt3.AllowUserToDeleteRows = False
        Me.dgvFlgt3.AllowUserToOrderColumns = True
        Me.dgvFlgt3.AllowUserToResizeColumns = False
        Me.dgvFlgt3.AllowUserToResizeRows = False
        Me.dgvFlgt3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlgt3.Location = New System.Drawing.Point(16, 390)
        Me.dgvFlgt3.Name = "dgvFlgt3"
        Me.dgvFlgt3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlgt3.Size = New System.Drawing.Size(760, 116)
        Me.dgvFlgt3.TabIndex = 5
        '
        'dgvFlgt2
        '
        Me.dgvFlgt2.AllowUserToAddRows = False
        Me.dgvFlgt2.AllowUserToDeleteRows = False
        Me.dgvFlgt2.AllowUserToOrderColumns = True
        Me.dgvFlgt2.AllowUserToResizeColumns = False
        Me.dgvFlgt2.AllowUserToResizeRows = False
        Me.dgvFlgt2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFlgt2.Location = New System.Drawing.Point(16, 229)
        Me.dgvFlgt2.Name = "dgvFlgt2"
        Me.dgvFlgt2.ReadOnly = True
        Me.dgvFlgt2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFlgt2.Size = New System.Drawing.Size(760, 116)
        Me.dgvFlgt2.TabIndex = 6
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(291, 526)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(83, 31)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(406, 526)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(83, 31)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmSelectMultiCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 569)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFlgt2)
        Me.Controls.Add(Me.dgvFlgt3)
        Me.Controls.Add(Me.dgvFlgt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSelectMultiCity"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select a Flight"
        CType(Me.dgvFlgt1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFlgt3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFlgt2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvFlgt1 As DataGridView
    Friend WithEvents dgvFlgt3 As DataGridView
    Friend WithEvents dgvFlgt2 As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnNext As Button
End Class
