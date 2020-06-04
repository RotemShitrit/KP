<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WOnum_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.complete_col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.importWorkOrder_btn = New System.Windows.Forms.Button()
        Me.search_txt = New System.Windows.Forms.TextBox()
        Me.detailsBy_cmb = New System.Windows.Forms.ComboBox()
        Me.search_pic = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.search_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WOnum_col, Me.time_col, Me.complete_col})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 254)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(392, 325)
        Me.DataGridView1.TabIndex = 1
        '
        'WOnum_col
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        Me.WOnum_col.DefaultCellStyle = DataGridViewCellStyle3
        Me.WOnum_col.FillWeight = 120.0!
        Me.WOnum_col.HeaderText = "Work Order Number"
        Me.WOnum_col.Name = "WOnum_col"
        Me.WOnum_col.ReadOnly = True
        '
        'time_col
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue
        Me.time_col.DefaultCellStyle = DataGridViewCellStyle4
        Me.time_col.FillWeight = 90.0!
        Me.time_col.HeaderText = "Date\Time"
        Me.time_col.Name = "time_col"
        Me.time_col.ReadOnly = True
        '
        'complete_col
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.complete_col.DefaultCellStyle = DataGridViewCellStyle5
        Me.complete_col.FillWeight = 70.0!
        Me.complete_col.HeaderText = "Complete"
        Me.complete_col.Name = "complete_col"
        Me.complete_col.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Import Work Order"
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.back_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.back_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.White
        Me.back_btn.Location = New System.Drawing.Point(410, 551)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(150, 28)
        Me.back_btn.TabIndex = 3
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'importWorkOrder_btn
        '
        Me.importWorkOrder_btn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.importWorkOrder_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.importWorkOrder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.importWorkOrder_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.importWorkOrder_btn.ForeColor = System.Drawing.Color.White
        Me.importWorkOrder_btn.Location = New System.Drawing.Point(566, 551)
        Me.importWorkOrder_btn.Name = "importWorkOrder_btn"
        Me.importWorkOrder_btn.Size = New System.Drawing.Size(150, 28)
        Me.importWorkOrder_btn.TabIndex = 3
        Me.importWorkOrder_btn.Text = "Import Work Order"
        Me.importWorkOrder_btn.UseVisualStyleBackColor = False
        '
        'search_txt
        '
        Me.search_txt.ForeColor = System.Drawing.Color.Black
        Me.search_txt.Location = New System.Drawing.Point(151, 228)
        Me.search_txt.Name = "search_txt"
        Me.search_txt.Size = New System.Drawing.Size(233, 20)
        Me.search_txt.TabIndex = 16
        '
        'detailsBy_cmb
        '
        Me.detailsBy_cmb.FormattingEnabled = True
        Me.detailsBy_cmb.Location = New System.Drawing.Point(12, 227)
        Me.detailsBy_cmb.Name = "detailsBy_cmb"
        Me.detailsBy_cmb.Size = New System.Drawing.Size(133, 21)
        Me.detailsBy_cmb.TabIndex = 15
        '
        'search_pic
        '
        Me.search_pic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.search_pic.Image = CType(resources.GetObject("search_pic.Image"), System.Drawing.Image)
        Me.search_pic.Location = New System.Drawing.Point(383, 228)
        Me.search_pic.Name = "search_pic"
        Me.search_pic.Size = New System.Drawing.Size(20, 20)
        Me.search_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.search_pic.TabIndex = 17
        Me.search_pic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(171, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(728, 591)
        Me.Controls.Add(Me.search_pic)
        Me.Controls.Add(Me.search_txt)
        Me.Controls.Add(Me.detailsBy_cmb)
        Me.Controls.Add(Me.importWorkOrder_btn)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.search_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents back_btn As Button
    Friend WithEvents importWorkOrder_btn As Button
    Friend WithEvents search_pic As PictureBox
    Friend WithEvents search_txt As TextBox
    Friend WithEvents detailsBy_cmb As ComboBox
    Friend WithEvents WOnum_col As DataGridViewTextBoxColumn
    Friend WithEvents time_col As DataGridViewTextBoxColumn
    Friend WithEvents complete_col As DataGridViewTextBoxColumn
    Friend WithEvents bWorker As System.ComponentModel.BackgroundWorker
End Class
