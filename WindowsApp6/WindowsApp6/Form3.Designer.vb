<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.importLog_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.search_pic = New System.Windows.Forms.PictureBox()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.detailsBy_cmb = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.search_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 82)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.Location = New System.Drawing.Point(413, 551)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(150, 28)
        Me.back_btn.TabIndex = 3
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'importLog_btn
        '
        Me.importLog_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.importLog_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.importLog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.importLog_btn.ForeColor = System.Drawing.Color.White
        Me.importLog_btn.Location = New System.Drawing.Point(569, 551)
        Me.importLog_btn.Name = "importLog_btn"
        Me.importLog_btn.Size = New System.Drawing.Size(150, 28)
        Me.importLog_btn.TabIndex = 4
        Me.importLog_btn.Text = "Import Log History"
        Me.importLog_btn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 254)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(392, 325)
        Me.DataGridView1.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.FillWeight = 120.0!
        Me.Column1.HeaderText = "Node ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 90.0!
        Me.Column2.HeaderText = "Date\Time"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 70.0!
        Me.Column3.HeaderText = "Meter SN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Import Log History"
        '
        'search_pic
        '
        Me.search_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_pic.Image = CType(resources.GetObject("search_pic.Image"), System.Drawing.Image)
        Me.search_pic.Location = New System.Drawing.Point(383, 228)
        Me.search_pic.Name = "search_pic"
        Me.search_pic.Size = New System.Drawing.Size(20, 20)
        Me.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.search_pic.TabIndex = 20
        Me.search_pic.TabStop = False
        '
        'search_txt
        '
        Me.search_txt.ForeColor = System.Drawing.Color.Black
        Me.search_txt.Location = New System.Drawing.Point(151, 228)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(233, 20)
        Me.search_txt.TabIndex = 19
        '
        'detailsBy_cmb
        '
        Me.detailsBy_cmb.FormattingEnabled = True
        Me.detailsBy_cmb.Location = New System.Drawing.Point(12, 227)
        Me.detailsBy_cmb.Name = "detailsBy_cmb"
        Me.detailsBy_cmb.Size = New System.Drawing.Size(133, 21)
        Me.detailsBy_cmb.TabIndex = 18
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 591)
        Me.Controls.Add(Me.search_pic)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.detailsBy_cmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.importLog_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents back_btn As Button
    Friend WithEvents importLog_btn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents search_pic As PictureBox
    Friend WithEvents search_txt As TextBox
    Friend WithEvents detailsBy_cmb As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
