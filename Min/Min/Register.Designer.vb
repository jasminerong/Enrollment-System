<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Regpassword2 = New System.Windows.Forms.TextBox()
        Me.Regpassword = New System.Windows.Forms.TextBox()
        Me.Regusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(309, 155)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
        Me.CheckBox1.TabIndex = 76
        Me.CheckBox1.Text = "Show password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Create Your Account "
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(111, 177)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(69, 39)
        Me.Back.TabIndex = 74
        Me.Back.Text = "Cancel"
        Me.Back.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(217, 177)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(193, 39)
        Me.btnRegister.TabIndex = 73
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Regpassword2
        '
        Me.Regpassword2.Location = New System.Drawing.Point(170, 129)
        Me.Regpassword2.Name = "Regpassword2"
        Me.Regpassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.Regpassword2.Size = New System.Drawing.Size(241, 20)
        Me.Regpassword2.TabIndex = 72
        '
        'Regpassword
        '
        Me.Regpassword.Location = New System.Drawing.Point(170, 100)
        Me.Regpassword.Name = "Regpassword"
        Me.Regpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.Regpassword.Size = New System.Drawing.Size(241, 20)
        Me.Regpassword.TabIndex = 71
        '
        'Regusername
        '
        Me.Regusername.Location = New System.Drawing.Point(170, 64)
        Me.Regusername.Name = "Regusername"
        Me.Regusername.Size = New System.Drawing.Size(240, 20)
        Me.Regusername.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Username: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Password: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Confirm Password:"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 254)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Regpassword2)
        Me.Controls.Add(Me.Regpassword)
        Me.Controls.Add(Me.Regusername)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Regpassword2 As System.Windows.Forms.TextBox
    Friend WithEvents Regpassword As System.Windows.Forms.TextBox
    Friend WithEvents Regusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
