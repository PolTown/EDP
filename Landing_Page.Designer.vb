<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing_Page
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnItem = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 69)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(379, 337)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(163, 51)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnItem
        '
        Me.btnItem.Location = New System.Drawing.Point(63, 135)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(156, 66)
        Me.btnItem.TabIndex = 8
        Me.btnItem.Text = "Items"
        Me.btnItem.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(363, 135)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(161, 66)
        Me.btnCustomers.TabIndex = 9
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Location = New System.Drawing.Point(63, 256)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(156, 62)
        Me.btnSale.TabIndex = 10
        Me.btnSale.Text = "Sale"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(368, 256)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(156, 62)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "Back Up"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Landing_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 413)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnSale)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnItem)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Landing_Page"
        Me.Text = "Landing_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnItem As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSale As Button
    Friend WithEvents btnBackup As Button
End Class
