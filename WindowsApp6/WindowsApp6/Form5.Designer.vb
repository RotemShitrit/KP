<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.host_txt = New System.Windows.Forms.TextBox()
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.password_txt = New System.Windows.Forms.TextBox()
        Me.port_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Port"
        '
        'host_txt
        '
        Me.host_txt.Location = New System.Drawing.Point(141, 123)
        Me.host_txt.Name = "host_txt"
        Me.host_txt.Size = New System.Drawing.Size(205, 20)
        Me.host_txt.TabIndex = 4
        '
        'user_txt
        '
        Me.user_txt.Location = New System.Drawing.Point(141, 172)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(205, 20)
        Me.user_txt.TabIndex = 5
        '
        'password_txt
        '
        Me.password_txt.Location = New System.Drawing.Point(141, 219)
        Me.password_txt.Name = "password_txt"
        Me.password_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_txt.Size = New System.Drawing.Size(205, 20)
        Me.password_txt.TabIndex = 6
        '
        'port_txt
        '
        Me.port_txt.Location = New System.Drawing.Point(141, 267)
        Me.port_txt.Name = "port_txt"
        Me.port_txt.Size = New System.Drawing.Size(205, 20)
        Me.port_txt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(123, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FTP Settings"
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.DarkOrange
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.save_btn.Location = New System.Drawing.Point(156, 342)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(94, 38)
        Me.save_btn.TabIndex = 9
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(420, 429)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.port_txt)
        Me.Controls.Add(Me.password_txt)
        Me.Controls.Add(Me.user_txt)
        Me.Controls.Add(Me.host_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTP Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents host_txt As TextBox
    Friend WithEvents user_txt As TextBox
    Friend WithEvents password_txt As TextBox
    Friend WithEvents port_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents save_btn As Button
End Class
