<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.CloseForm = New System.Windows.Forms.Button()
        Me.BackToLogin = New System.Windows.Forms.Button()
        Me.LabelTellingUsername2 = New System.Windows.Forms.Label()
        Me.LabelTellingPassword2 = New System.Windows.Forms.Label()
        Me.LabelTellingUsername1 = New System.Windows.Forms.Label()
        Me.LabelTellingPassword1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CloseForm
        '
        Me.CloseForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseForm.Location = New System.Drawing.Point(408, 73)
        Me.CloseForm.Name = "CloseForm"
        Me.CloseForm.Size = New System.Drawing.Size(127, 61)
        Me.CloseForm.TabIndex = 3
        Me.CloseForm.Text = "Close Form"
        Me.CloseForm.UseVisualStyleBackColor = True
        '
        'BackToLogin
        '
        Me.BackToLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackToLogin.Location = New System.Drawing.Point(408, 140)
        Me.BackToLogin.Name = "BackToLogin"
        Me.BackToLogin.Size = New System.Drawing.Size(127, 55)
        Me.BackToLogin.TabIndex = 5
        Me.BackToLogin.Text = "Back to login form"
        Me.BackToLogin.UseVisualStyleBackColor = True
        '
        'LabelTellingUsername2
        '
        Me.LabelTellingUsername2.AutoSize = True
        Me.LabelTellingUsername2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTellingUsername2.Location = New System.Drawing.Point(12, 9)
        Me.LabelTellingUsername2.Name = "LabelTellingUsername2"
        Me.LabelTellingUsername2.Size = New System.Drawing.Size(253, 31)
        Me.LabelTellingUsername2.TabIndex = 6
        Me.LabelTellingUsername2.Text = "Username: Test123"
        '
        'LabelTellingPassword2
        '
        Me.LabelTellingPassword2.AutoSize = True
        Me.LabelTellingPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTellingPassword2.Location = New System.Drawing.Point(12, 40)
        Me.LabelTellingPassword2.Name = "LabelTellingPassword2"
        Me.LabelTellingPassword2.Size = New System.Drawing.Size(248, 31)
        Me.LabelTellingPassword2.TabIndex = 7
        Me.LabelTellingPassword2.Text = "Password: 123Test"
        '
        'LabelTellingUsername1
        '
        Me.LabelTellingUsername1.AutoSize = True
        Me.LabelTellingUsername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTellingUsername1.Location = New System.Drawing.Point(12, 135)
        Me.LabelTellingUsername1.Name = "LabelTellingUsername1"
        Me.LabelTellingUsername1.Size = New System.Drawing.Size(253, 31)
        Me.LabelTellingUsername1.TabIndex = 8
        Me.LabelTellingUsername1.Text = "Username: Test321"
        '
        'LabelTellingPassword1
        '
        Me.LabelTellingPassword1.AutoSize = True
        Me.LabelTellingPassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTellingPassword1.Location = New System.Drawing.Point(12, 166)
        Me.LabelTellingPassword1.Name = "LabelTellingPassword1"
        Me.LabelTellingPassword1.Size = New System.Drawing.Size(248, 31)
        Me.LabelTellingPassword1.TabIndex = 9
        Me.LabelTellingPassword1.Text = "Password: 321Test"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 206)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelTellingPassword1)
        Me.Controls.Add(Me.LabelTellingUsername1)
        Me.Controls.Add(Me.LabelTellingPassword2)
        Me.Controls.Add(Me.LabelTellingUsername2)
        Me.Controls.Add(Me.BackToLogin)
        Me.Controls.Add(Me.CloseForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CloseForm As Button
    Friend WithEvents BackToLogin As Button
    Friend WithEvents LabelTellingUsername2 As Label
    Friend WithEvents LabelTellingPassword2 As Label
    Friend WithEvents LabelTellingUsername1 As Label
    Friend WithEvents LabelTellingPassword1 As Label
End Class
