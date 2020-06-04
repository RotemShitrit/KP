<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createWorkOrder_btn = New System.Windows.Forms.Button()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.left_btn = New System.Windows.Forms.Button()
        Me.right_btn = New System.Windows.Forms.Button()
        Me.workOrderNumber_label = New System.Windows.Forms.Label()
        Me.numberOfAcc_label = New System.Windows.Forms.Label()
        Me.detailsBy_cmb = New System.Windows.Forms.ComboBox()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.search_pic = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Create Work Order"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 280)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(334, 391)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CustomerNumber"
        Me.Column1.FillWeight = 102.0!
        Me.Column1.HeaderText = "Account Number"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Address"
        Me.Column2.FillWeight = 80.0!
        Me.Column2.HeaderText = "Address"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "MeterSn"
        Me.Column3.FillWeight = 75.0!
        Me.Column3.HeaderText = "Meter SN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'createWorkOrder_btn
        '
        Me.createWorkOrder_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.createWorkOrder_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createWorkOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.createWorkOrder_btn.ForeColor = System.Drawing.Color.White
        Me.createWorkOrder_btn.Location = New System.Drawing.Point(563, 643)
        Me.createWorkOrder_btn.Name = "createWorkOrder_btn"
        Me.createWorkOrder_btn.Size = New System.Drawing.Size(150, 28)
        Me.createWorkOrder_btn.TabIndex = 6
        Me.createWorkOrder_btn.Text = "Create Work Order"
        Me.createWorkOrder_btn.UseVisualStyleBackColor = False
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.Location = New System.Drawing.Point(390, 643)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(150, 28)
        Me.back_btn.TabIndex = 7
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView3.EnableHeadersVisualStyles = False
        Me.DataGridView3.Location = New System.Drawing.Point(390, 280)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView3.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(323, 290)
        Me.DataGridView3.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 102.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Account Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 75.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Meter SN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'left_btn
        '
        Me.left_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.left_btn.Image = CType(resources.GetObject("left_btn.Image"), System.Drawing.Image)
        Me.left_btn.Location = New System.Drawing.Point(352, 451)
        Me.left_btn.Name = "left_btn"
        Me.left_btn.Size = New System.Drawing.Size(32, 29)
        Me.left_btn.TabIndex = 9
        Me.left_btn.UseVisualStyleBackColor = True
        '
        'right_btn
        '
        Me.right_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.right_btn.Image = CType(resources.GetObject("right_btn.Image"), System.Drawing.Image)
        Me.right_btn.Location = New System.Drawing.Point(352, 416)
        Me.right_btn.Name = "right_btn"
        Me.right_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.right_btn.Size = New System.Drawing.Size(32, 29)
        Me.right_btn.TabIndex = 9
        Me.right_btn.UseVisualStyleBackColor = True
        '
        'workOrderNumber_label
        '
        Me.workOrderNumber_label.AutoSize = True
        Me.workOrderNumber_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.workOrderNumber_label.Location = New System.Drawing.Point(386, 586)
        Me.workOrderNumber_label.Name = "workOrderNumber_label"
        Me.workOrderNumber_label.Size = New System.Drawing.Size(203, 20)
        Me.workOrderNumber_label.TabIndex = 10
        Me.workOrderNumber_label.Text = "Work Order Number: 10023"
        '
        'numberOfAcc_label
        '
        Me.numberOfAcc_label.AutoSize = True
        Me.numberOfAcc_label.Location = New System.Drawing.Point(598, 256)
        Me.numberOfAcc_label.Name = "numberOfAcc_label"
        Me.numberOfAcc_label.Size = New System.Drawing.Size(115, 13)
        Me.numberOfAcc_label.TabIndex = 11
        Me.numberOfAcc_label.Text = "Number of accounts: 0"
        '
        'detailsBy_cmb
        '
        Me.detailsBy_cmb.FormattingEnabled = True
        Me.detailsBy_cmb.Location = New System.Drawing.Point(13, 248)
        Me.detailsBy_cmb.Name = "detailsBy_cmb"
        Me.detailsBy_cmb.Size = New System.Drawing.Size(105, 21)
        Me.detailsBy_cmb.TabIndex = 12
        '
        'search_txt
        '
        Me.search_txt.ForeColor = System.Drawing.Color.Black
        Me.search_txt.Location = New System.Drawing.Point(124, 249)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(204, 20)
        Me.search_txt.TabIndex = 13
        '
        'search_pic
        '
        Me.search_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_pic.Image = CType(resources.GetObject("search_pic.Image"), System.Drawing.Image)
        Me.search_pic.Location = New System.Drawing.Point(326, 249)
        Me.search_pic.Name = "search_pic"
        Me.search_pic.Size = New System.Drawing.Size(20, 20)
        Me.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.search_pic.TabIndex = 14
        Me.search_pic.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 683)
        Me.Controls.Add(Me.search_pic)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.detailsBy_cmb)
        Me.Controls.Add(Me.numberOfAcc_label)
        Me.Controls.Add(Me.workOrderNumber_label)
        Me.Controls.Add(Me.right_btn)
        Me.Controls.Add(Me.left_btn)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.createWorkOrder_btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents createWorkOrder_btn As Button
    Friend WithEvents back_btn As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents left_btn As Button
    Friend WithEvents right_btn As Button
    Friend WithEvents workOrderNumber_label As Label
    Friend WithEvents numberOfAcc_label As Label
    Friend WithEvents detailsBy_cmb As ComboBox
    Friend WithEvents search_txt As TextBox
    Friend WithEvents search_pic As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
