<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.importLog_btn = New System.Windows.Forms.Button()
        Me.importWO_btn = New System.Windows.Forms.Button()
        Me.createWO_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ftp_pic = New System.Windows.Forms.PictureBox()
        Me.Version = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ftp_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'importLog_btn
        '
        Me.importLog_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.importLog_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.importLog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.importLog_btn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importLog_btn.ForeColor = System.Drawing.Color.White
        Me.importLog_btn.Location = New System.Drawing.Point(395, 279)
        Me.importLog_btn.Name = "importLog_btn"
        Me.importLog_btn.Size = New System.Drawing.Size(230, 38)
        Me.importLog_btn.TabIndex = 1
        Me.importLog_btn.Text = "Import Log History"
        Me.importLog_btn.UseVisualStyleBackColor = False
        '
        'importWO_btn
        '
        Me.importWO_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.importWO_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.importWO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.importWO_btn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importWO_btn.ForeColor = System.Drawing.Color.White
        Me.importWO_btn.Location = New System.Drawing.Point(111, 323)
        Me.importWO_btn.Name = "importWO_btn"
        Me.importWO_btn.Size = New System.Drawing.Size(230, 38)
        Me.importWO_btn.TabIndex = 1
        Me.importWO_btn.Text = "Import Work Order"
        Me.importWO_btn.UseVisualStyleBackColor = False
        '
        'createWO_btn
        '
        Me.createWO_btn.BackColor = System.Drawing.Color.OrangeRed
        Me.createWO_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createWO_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.createWO_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.createWO_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createWO_btn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createWO_btn.ForeColor = System.Drawing.Color.White
        Me.createWO_btn.Location = New System.Drawing.Point(111, 279)
        Me.createWO_btn.Name = "createWO_btn"
        Me.createWO_btn.Size = New System.Drawing.Size(230, 38)
        Me.createWO_btn.TabIndex = 1
        Me.createWO_btn.Text = "Create Work Order"
        Me.createWO_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Handheld Tools"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp6.My.Resources.Resources.hand
        Me.PictureBox2.Location = New System.Drawing.Point(473, 407)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(275, 187)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Ftp_pic
        '
        Me.Ftp_pic.Image = CType(resources.GetObject("Ftp_pic.Image"), System.Drawing.Image)
        Me.Ftp_pic.Location = New System.Drawing.Point(8, 533)
        Me.Ftp_pic.Name = "Ftp_pic"
        Me.Ftp_pic.Size = New System.Drawing.Size(50, 50)
        Me.Ftp_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ftp_pic.TabIndex = 4
        Me.Ftp_pic.TabStop = False
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Version.Location = New System.Drawing.Point(545, 11)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(175, 13)
        Me.Version.TabIndex = 5
        Me.Version.Text = "Mueller PC Application : Version 1.3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(728, 591)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Ftp_pic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.importWO_btn)
        Me.Controls.Add(Me.createWO_btn)
        Me.Controls.Add(Me.importLog_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Handheld Tools"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ftp_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents importLog_btn As Button
    Friend WithEvents importWO_btn As Button
    Friend WithEvents createWO_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Ftp_pic As PictureBox
    Friend WithEvents Version As Label
End Class
