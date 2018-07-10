<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminFlight
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
        Me.btnShowLatestTrans = New System.Windows.Forms.Button()
        Me.btnAddFlgtIns = New System.Windows.Forms.Button()
        Me.btnManageLoc = New System.Windows.Forms.Button()
        Me.btnShowFlgt = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEndFlgt = New System.Windows.Forms.Button()
        Me.btnManageFlgt = New System.Windows.Forms.Button()
        Me.btnAir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select an Option:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowLatestTrans
        '
        Me.btnShowLatestTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowLatestTrans.Location = New System.Drawing.Point(12, 50)
        Me.btnShowLatestTrans.Name = "btnShowLatestTrans"
        Me.btnShowLatestTrans.Size = New System.Drawing.Size(192, 30)
        Me.btnShowLatestTrans.TabIndex = 1
        Me.btnShowLatestTrans.Text = "Show Latest Transactions"
        Me.btnShowLatestTrans.UseVisualStyleBackColor = True
        '
        'btnAddFlgtIns
        '
        Me.btnAddFlgtIns.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFlgtIns.Location = New System.Drawing.Point(12, 86)
        Me.btnAddFlgtIns.Name = "btnAddFlgtIns"
        Me.btnAddFlgtIns.Size = New System.Drawing.Size(192, 30)
        Me.btnAddFlgtIns.TabIndex = 2
        Me.btnAddFlgtIns.Text = "Manage Flight Instance"
        Me.btnAddFlgtIns.UseVisualStyleBackColor = True
        '
        'btnManageLoc
        '
        Me.btnManageLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageLoc.Location = New System.Drawing.Point(12, 122)
        Me.btnManageLoc.Name = "btnManageLoc"
        Me.btnManageLoc.Size = New System.Drawing.Size(192, 30)
        Me.btnManageLoc.TabIndex = 5
        Me.btnManageLoc.Text = "Manage Location"
        Me.btnManageLoc.UseVisualStyleBackColor = True
        '
        'btnShowFlgt
        '
        Me.btnShowFlgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowFlgt.Location = New System.Drawing.Point(230, 86)
        Me.btnShowFlgt.Name = "btnShowFlgt"
        Me.btnShowFlgt.Size = New System.Drawing.Size(192, 30)
        Me.btnShowFlgt.TabIndex = 6
        Me.btnShowFlgt.Text = "Show Flights"
        Me.btnShowFlgt.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(230, 158)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(192, 30)
        Me.btnLogout.TabIndex = 10
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnEndFlgt
        '
        Me.btnEndFlgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndFlgt.Location = New System.Drawing.Point(229, 122)
        Me.btnEndFlgt.Name = "btnEndFlgt"
        Me.btnEndFlgt.Size = New System.Drawing.Size(192, 30)
        Me.btnEndFlgt.TabIndex = 12
        Me.btnEndFlgt.Text = "End Flight"
        Me.btnEndFlgt.UseVisualStyleBackColor = True
        '
        'btnManageFlgt
        '
        Me.btnManageFlgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageFlgt.Location = New System.Drawing.Point(12, 158)
        Me.btnManageFlgt.Name = "btnManageFlgt"
        Me.btnManageFlgt.Size = New System.Drawing.Size(191, 30)
        Me.btnManageFlgt.TabIndex = 13
        Me.btnManageFlgt.Text = "Manage Flight Template"
        Me.btnManageFlgt.UseVisualStyleBackColor = True
        '
        'btnAir
        '
        Me.btnAir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAir.Location = New System.Drawing.Point(230, 50)
        Me.btnAir.Name = "btnAir"
        Me.btnAir.Size = New System.Drawing.Size(190, 30)
        Me.btnAir.TabIndex = 14
        Me.btnAir.Text = "Manage Aircraft"
        Me.btnAir.UseVisualStyleBackColor = True
        '
        'frmAdminFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 202)
        Me.Controls.Add(Me.btnAir)
        Me.Controls.Add(Me.btnManageFlgt)
        Me.Controls.Add(Me.btnEndFlgt)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnShowFlgt)
        Me.Controls.Add(Me.btnManageLoc)
        Me.Controls.Add(Me.btnAddFlgtIns)
        Me.Controls.Add(Me.btnShowLatestTrans)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAdminFlight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowLatestTrans As Button
    Friend WithEvents btnAddFlgtIns As Button
    Friend WithEvents btnManageLoc As Button
    Friend WithEvents btnShowFlgt As Button
    Friend WithEvents btnAddAir As Button
    Friend WithEvents btnRemoveAir As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnEndFlgt As Button
    Friend WithEvents btnManageFlgt As Button
    Friend WithEvents btnAir As Button
End Class
