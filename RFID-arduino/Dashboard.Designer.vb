<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.book_registration_btn = New System.Windows.Forms.Button()
        Me.book_data_btn = New System.Windows.Forms.Button()
        Me.user_registration_btn = New System.Windows.Forms.Button()
        Me.user_data_btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.book_registration_btn)
        Me.Panel1.Controls.Add(Me.book_data_btn)
        Me.Panel1.Controls.Add(Me.user_registration_btn)
        Me.Panel1.Controls.Add(Me.user_data_btn)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(276, 811)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RFID Book Chu"
        '
        'book_registration_btn
        '
        Me.book_registration_btn.Location = New System.Drawing.Point(18, 394)
        Me.book_registration_btn.Name = "book_registration_btn"
        Me.book_registration_btn.Size = New System.Drawing.Size(243, 47)
        Me.book_registration_btn.TabIndex = 3
        Me.book_registration_btn.Text = "Book Registration"
        Me.book_registration_btn.UseVisualStyleBackColor = True
        '
        'book_data_btn
        '
        Me.book_data_btn.Location = New System.Drawing.Point(17, 447)
        Me.book_data_btn.Name = "book_data_btn"
        Me.book_data_btn.Size = New System.Drawing.Size(243, 47)
        Me.book_data_btn.TabIndex = 2
        Me.book_data_btn.Text = "Book Data"
        Me.book_data_btn.UseVisualStyleBackColor = True
        '
        'user_registration_btn
        '
        Me.user_registration_btn.Location = New System.Drawing.Point(17, 287)
        Me.user_registration_btn.Name = "user_registration_btn"
        Me.user_registration_btn.Size = New System.Drawing.Size(245, 47)
        Me.user_registration_btn.TabIndex = 1
        Me.user_registration_btn.Text = "User Registration"
        Me.user_registration_btn.UseVisualStyleBackColor = True
        '
        'user_data_btn
        '
        Me.user_data_btn.Location = New System.Drawing.Point(17, 340)
        Me.user_data_btn.Name = "user_data_btn"
        Me.user_data_btn.Size = New System.Drawing.Size(245, 47)
        Me.user_data_btn.TabIndex = 0
        Me.user_data_btn.Text = "User Data"
        Me.user_data_btn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(294, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1123, 811)
        Me.Panel2.TabIndex = 1
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1429, 835)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents user_registration_btn As Button
    Friend WithEvents user_data_btn As Button
    Friend WithEvents book_registration_btn As Button
    Friend WithEvents book_data_btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
