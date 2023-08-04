<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnFinalSearch = New System.Windows.Forms.Button()
        Me.txtCarDesc = New System.Windows.Forms.TextBox()
        Me.cmbDate = New System.Windows.Forms.ComboBox()
        Me.cmbCar = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNameSearch = New System.Windows.Forms.TextBox()
        Me.txtTypeSearch = New System.Windows.Forms.TextBox()
        Me.dtgList = New System.Windows.Forms.DataGridView()
        Me.dtgMechanics = New System.Windows.Forms.DataGridView()
        Me.dtgPartsPurchase = New System.Windows.Forms.DataGridView()
        Me.dtgServiceAvail = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnCompute = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDateRangeIncome = New System.Windows.Forms.TextBox()
        Me.txtTotalIncome = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgMechanics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgPartsPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgServiceAvail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1443, 650)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.BtnFinalSearch)
        Me.TabPage1.Controls.Add(Me.txtCarDesc)
        Me.TabPage1.Controls.Add(Me.cmbDate)
        Me.TabPage1.Controls.Add(Me.cmbCar)
        Me.TabPage1.Controls.Add(Me.BtnSearch)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtNameSearch)
        Me.TabPage1.Controls.Add(Me.txtTypeSearch)
        Me.TabPage1.Controls.Add(Me.dtgList)
        Me.TabPage1.Controls.Add(Me.dtgMechanics)
        Me.TabPage1.Controls.Add(Me.dtgPartsPurchase)
        Me.TabPage1.Controls.Add(Me.dtgServiceAvail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1435, 608)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Customer Transaction History"
        '
        'BtnFinalSearch
        '
        Me.BtnFinalSearch.Location = New System.Drawing.Point(1151, 47)
        Me.BtnFinalSearch.Name = "BtnFinalSearch"
        Me.BtnFinalSearch.Size = New System.Drawing.Size(149, 86)
        Me.BtnFinalSearch.TabIndex = 7
        Me.BtnFinalSearch.Text = "Search Transaction"
        Me.BtnFinalSearch.UseVisualStyleBackColor = True
        '
        'txtCarDesc
        '
        Me.txtCarDesc.Location = New System.Drawing.Point(809, 89)
        Me.txtCarDesc.Name = "txtCarDesc"
        Me.txtCarDesc.Size = New System.Drawing.Size(319, 34)
        Me.txtCarDesc.TabIndex = 6
        '
        'cmbDate
        '
        Me.cmbDate.FormattingEnabled = True
        Me.cmbDate.Location = New System.Drawing.Point(1086, 145)
        Me.cmbDate.Name = "cmbDate"
        Me.cmbDate.Size = New System.Drawing.Size(171, 34)
        Me.cmbDate.TabIndex = 5
        '
        'cmbCar
        '
        Me.cmbCar.FormattingEnabled = True
        Me.cmbCar.Location = New System.Drawing.Point(930, 49)
        Me.cmbCar.Name = "cmbCar"
        Me.cmbCar.Size = New System.Drawing.Size(198, 34)
        Me.cmbCar.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(447, 88)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(88, 35)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1099, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 26)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Mechanics"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(788, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Parts Purchase"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(467, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Service Avail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "List of customers"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(809, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 26)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Has been serviced"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(803, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Has Car(s)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search Customer Name:"
        '
        'txtNameSearch
        '
        Me.txtNameSearch.Location = New System.Drawing.Point(541, 89)
        Me.txtNameSearch.Name = "txtNameSearch"
        Me.txtNameSearch.Size = New System.Drawing.Size(228, 34)
        Me.txtNameSearch.TabIndex = 1
        '
        'txtTypeSearch
        '
        Me.txtTypeSearch.Location = New System.Drawing.Point(75, 76)
        Me.txtTypeSearch.Name = "txtTypeSearch"
        Me.txtTypeSearch.Size = New System.Drawing.Size(298, 34)
        Me.txtTypeSearch.TabIndex = 1
        '
        'dtgList
        '
        Me.dtgList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgList.BackgroundColor = System.Drawing.Color.White
        Me.dtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgList.Location = New System.Drawing.Point(65, 168)
        Me.dtgList.Name = "dtgList"
        Me.dtgList.RowHeadersWidth = 51
        Me.dtgList.RowTemplate.Height = 29
        Me.dtgList.Size = New System.Drawing.Size(289, 404)
        Me.dtgList.TabIndex = 0
        '
        'dtgMechanics
        '
        Me.dtgMechanics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgMechanics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgMechanics.BackgroundColor = System.Drawing.Color.White
        Me.dtgMechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMechanics.Location = New System.Drawing.Point(1099, 241)
        Me.dtgMechanics.Name = "dtgMechanics"
        Me.dtgMechanics.RowHeadersWidth = 51
        Me.dtgMechanics.RowTemplate.Height = 29
        Me.dtgMechanics.Size = New System.Drawing.Size(267, 331)
        Me.dtgMechanics.TabIndex = 0
        '
        'dtgPartsPurchase
        '
        Me.dtgPartsPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgPartsPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgPartsPurchase.BackgroundColor = System.Drawing.Color.White
        Me.dtgPartsPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgPartsPurchase.Location = New System.Drawing.Point(788, 241)
        Me.dtgPartsPurchase.Name = "dtgPartsPurchase"
        Me.dtgPartsPurchase.RowHeadersWidth = 51
        Me.dtgPartsPurchase.RowTemplate.Height = 29
        Me.dtgPartsPurchase.Size = New System.Drawing.Size(291, 331)
        Me.dtgPartsPurchase.TabIndex = 0
        '
        'dtgServiceAvail
        '
        Me.dtgServiceAvail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgServiceAvail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgServiceAvail.BackgroundColor = System.Drawing.Color.White
        Me.dtgServiceAvail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgServiceAvail.Location = New System.Drawing.Point(467, 197)
        Me.dtgServiceAvail.Name = "dtgServiceAvail"
        Me.dtgServiceAvail.RowHeadersWidth = 51
        Me.dtgServiceAvail.RowTemplate.Height = 29
        Me.dtgServiceAvail.Size = New System.Drawing.Size(302, 375)
        Me.dtgServiceAvail.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.DateTimePicker2)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Controls.Add(Me.BtnCompute)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtDateRangeIncome)
        Me.TabPage2.Controls.Add(Me.txtTotalIncome)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1435, 608)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Income History"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(1112, 314)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(195, 45)
        Me.DateTimePicker2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(763, 314)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(195, 45)
        Me.DateTimePicker1.TabIndex = 3
        '
        'BtnCompute
        '
        Me.BtnCompute.Font = New System.Drawing.Font("Baskerville Old Face", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCompute.Location = New System.Drawing.Point(960, 402)
        Me.BtnCompute.Name = "BtnCompute"
        Me.BtnCompute.Size = New System.Drawing.Size(164, 62)
        Me.BtnCompute.TabIndex = 2
        Me.BtnCompute.Text = "Compute"
        Me.BtnCompute.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(999, 314)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 45)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "To"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(885, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(337, 45)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Date Range Income"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(229, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(271, 45)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Overall Income"
        '
        'txtDateRangeIncome
        '
        Me.txtDateRangeIncome.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDateRangeIncome.Location = New System.Drawing.Point(801, 200)
        Me.txtDateRangeIncome.Multiline = True
        Me.txtDateRangeIncome.Name = "txtDateRangeIncome"
        Me.txtDateRangeIncome.Size = New System.Drawing.Size(474, 77)
        Me.txtDateRangeIncome.TabIndex = 0
        Me.txtDateRangeIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTotalIncome
        '
        Me.txtTotalIncome.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTotalIncome.Location = New System.Drawing.Point(133, 167)
        Me.txtTotalIncome.Multiline = True
        Me.txtTotalIncome.Name = "txtTotalIncome"
        Me.txtTotalIncome.Size = New System.Drawing.Size(474, 77)
        Me.txtTotalIncome.TabIndex = 0
        Me.txtTotalIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1443, 650)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "History"
        Me.Text = "History"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgMechanics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgPartsPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgServiceAvail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNameSearch As TextBox
    Friend WithEvents txtTypeSearch As TextBox
    Friend WithEvents dtgList As DataGridView
    Friend WithEvents dtgServiceAvail As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cmbCar As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCarDesc As TextBox
    Friend WithEvents cmbDate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtgMechanics As DataGridView
    Friend WithEvents dtgPartsPurchase As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnFinalSearch As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnCompute As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDateRangeIncome As TextBox
    Friend WithEvents txtTotalIncome As TextBox
End Class
