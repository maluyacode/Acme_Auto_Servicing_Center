<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageCars
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.cmbCarowner = New System.Windows.Forms.ComboBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.txtCarsearch = New System.Windows.Forms.TextBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.dtgCars = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtCarType = New System.Windows.Forms.TextBox()
        Me.txtCarsManu = New System.Windows.Forms.TextBox()
        Me.txtPlateNumber = New System.Windows.Forms.TextBox()
        Me.txtCarID = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.cmbMODtype = New System.Windows.Forms.ComboBox()
        Me.cmbMODmanu = New System.Windows.Forms.ComboBox()
        Me.dtgModels = New System.Windows.Forms.DataGridView()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.txtModelSearch = New System.Windows.Forms.TextBox()
        Me.txtModelName = New System.Windows.Forms.TextBox()
        Me.txtModelID = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSearchManu = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dtgManufacturers = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtmanuName = New System.Windows.Forms.TextBox()
        Me.txtManufacturerID = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.dtgTypes = New System.Windows.Forms.DataGridView()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTypeName = New System.Windows.Forms.TextBox()
        Me.txtTypeID = New System.Windows.Forms.TextBox()
        Me.txtTypeSearch = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dtgCars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dtgModels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dtgManufacturers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.dtgTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1378, 575)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button19)
        Me.TabPage1.Controls.Add(Me.cmbCarowner)
        Me.TabPage1.Controls.Add(Me.Button18)
        Me.TabPage1.Controls.Add(Me.Button17)
        Me.TabPage1.Controls.Add(Me.txtCarsearch)
        Me.TabPage1.Controls.Add(Me.cmbModel)
        Me.TabPage1.Controls.Add(Me.dtgCars)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtMileage)
        Me.TabPage1.Controls.Add(Me.txtCarType)
        Me.TabPage1.Controls.Add(Me.txtCarsManu)
        Me.TabPage1.Controls.Add(Me.txtPlateNumber)
        Me.TabPage1.Controls.Add(Me.txtCarID)
        Me.TabPage1.Controls.Add(Me.Button16)
        Me.TabPage1.Controls.Add(Me.Button15)
        Me.TabPage1.Controls.Add(Me.Button14)
        Me.TabPage1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabPage1.Location = New System.Drawing.Point(4, 38)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1370, 533)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cars"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(22, 16)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(117, 45)
        Me.Button19.TabIndex = 8
        Me.Button19.Text = "Back"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'cmbCarowner
        '
        Me.cmbCarowner.FormattingEnabled = True
        Me.cmbCarowner.Location = New System.Drawing.Point(1111, 163)
        Me.cmbCarowner.Name = "cmbCarowner"
        Me.cmbCarowner.Size = New System.Drawing.Size(114, 31)
        Me.cmbCarowner.TabIndex = 7
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(1231, 163)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(66, 31)
        Me.Button18.TabIndex = 6
        Me.Button18.Text = "add"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(1149, 271)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(66, 31)
        Me.Button17.TabIndex = 6
        Me.Button17.Text = "add"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'txtCarsearch
        '
        Me.txtCarsearch.Location = New System.Drawing.Point(165, 96)
        Me.txtCarsearch.Name = "txtCarsearch"
        Me.txtCarsearch.Size = New System.Drawing.Size(136, 30)
        Me.txtCarsearch.TabIndex = 5
        '
        'cmbModel
        '
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(992, 271)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(151, 31)
        Me.cmbModel.TabIndex = 4
        '
        'dtgCars
        '
        Me.dtgCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCars.Location = New System.Drawing.Point(67, 132)
        Me.dtgCars.Name = "dtgCars"
        Me.dtgCars.RowHeadersWidth = 51
        Me.dtgCars.RowTemplate.Height = 29
        Me.dtgCars.Size = New System.Drawing.Size(676, 325)
        Me.dtgCars.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1018, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 23)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Customer"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(87, 99)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 23)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Search"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(766, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 23)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Mileage"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(1079, 316)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 23)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Type"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(782, 314)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(125, 23)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Manufacturers"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(900, 274)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 23)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Model"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(1011, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(122, 23)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Plate Number"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(766, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Car ID"
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(850, 211)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(153, 30)
        Me.txtMileage.TabIndex = 1
        '
        'txtCarType
        '
        Me.txtCarType.Location = New System.Drawing.Point(1139, 311)
        Me.txtCarType.Name = "txtCarType"
        Me.txtCarType.Size = New System.Drawing.Size(156, 30)
        Me.txtCarType.TabIndex = 1
        '
        'txtCarsManu
        '
        Me.txtCarsManu.Location = New System.Drawing.Point(913, 311)
        Me.txtCarsManu.Name = "txtCarsManu"
        Me.txtCarsManu.Size = New System.Drawing.Size(153, 30)
        Me.txtCarsManu.TabIndex = 1
        '
        'txtPlateNumber
        '
        Me.txtPlateNumber.Location = New System.Drawing.Point(1139, 211)
        Me.txtPlateNumber.Name = "txtPlateNumber"
        Me.txtPlateNumber.Size = New System.Drawing.Size(135, 30)
        Me.txtPlateNumber.TabIndex = 1
        '
        'txtCarID
        '
        Me.txtCarID.Location = New System.Drawing.Point(850, 163)
        Me.txtCarID.Name = "txtCarID"
        Me.txtCarID.Size = New System.Drawing.Size(153, 30)
        Me.txtCarID.TabIndex = 1
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(1111, 392)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(114, 51)
        Me.Button16.TabIndex = 0
        Me.Button16.Tag = "Delete"
        Me.Button16.Text = "Delete"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(965, 392)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(114, 51)
        Me.Button15.TabIndex = 0
        Me.Button15.Text = "Update"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(825, 392)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(114, 51)
        Me.Button14.TabIndex = 0
        Me.Button14.Text = "Create"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.Button20)
        Me.TabPage2.Controls.Add(Me.Button13)
        Me.TabPage2.Controls.Add(Me.Button12)
        Me.TabPage2.Controls.Add(Me.cmbMODtype)
        Me.TabPage2.Controls.Add(Me.cmbMODmanu)
        Me.TabPage2.Controls.Add(Me.dtgModels)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Button11)
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.txtModelSearch)
        Me.TabPage2.Controls.Add(Me.txtModelName)
        Me.TabPage2.Controls.Add(Me.txtModelID)
        Me.TabPage2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1370, 533)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Models"
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(25, 20)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(117, 45)
        Me.Button20.TabIndex = 6
        Me.Button20.Text = "Back"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(1134, 251)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(69, 29)
        Me.Button13.TabIndex = 5
        Me.Button13.Text = "Add"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(1071, 302)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(67, 29)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "Add"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'cmbMODtype
        '
        Me.cmbMODtype.FormattingEnabled = True
        Me.cmbMODtype.Location = New System.Drawing.Point(914, 302)
        Me.cmbMODtype.Name = "cmbMODtype"
        Me.cmbMODtype.Size = New System.Drawing.Size(151, 31)
        Me.cmbMODtype.TabIndex = 4
        '
        'cmbMODmanu
        '
        Me.cmbMODmanu.FormattingEnabled = True
        Me.cmbMODmanu.Location = New System.Drawing.Point(977, 249)
        Me.cmbMODmanu.Name = "cmbMODmanu"
        Me.cmbMODmanu.Size = New System.Drawing.Size(151, 31)
        Me.cmbMODmanu.TabIndex = 4
        '
        'dtgModels
        '
        Me.dtgModels.BackgroundColor = System.Drawing.Color.White
        Me.dtgModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgModels.Location = New System.Drawing.Point(127, 138)
        Me.dtgModels.Name = "dtgModels"
        Me.dtgModels.RowHeadersWidth = 51
        Me.dtgModels.RowTemplate.Height = 29
        Me.dtgModels.Size = New System.Drawing.Size(600, 312)
        Me.dtgModels.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(177, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 23)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Search"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(853, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Type"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(853, 252)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 23)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Manufacturer"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(853, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 23)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(853, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Model ID"
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button11.Location = New System.Drawing.Point(1114, 388)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(114, 62)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Delete"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button10.Location = New System.Drawing.Point(951, 388)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(114, 62)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Update"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button9.Location = New System.Drawing.Point(794, 388)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(114, 62)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Create"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'txtModelSearch
        '
        Me.txtModelSearch.Location = New System.Drawing.Point(246, 102)
        Me.txtModelSearch.Name = "txtModelSearch"
        Me.txtModelSearch.Size = New System.Drawing.Size(174, 30)
        Me.txtModelSearch.TabIndex = 0
        '
        'txtModelName
        '
        Me.txtModelName.Location = New System.Drawing.Point(933, 197)
        Me.txtModelName.Name = "txtModelName"
        Me.txtModelName.Size = New System.Drawing.Size(149, 30)
        Me.txtModelName.TabIndex = 0
        '
        'txtModelID
        '
        Me.txtModelID.Location = New System.Drawing.Point(948, 152)
        Me.txtModelID.Name = "txtModelID"
        Me.txtModelID.Size = New System.Drawing.Size(114, 30)
        Me.txtModelID.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Silver
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtSearchManu)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.dtgManufacturers)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.txtmanuName)
        Me.TabPage3.Controls.Add(Me.txtManufacturerID)
        Me.TabPage3.Location = New System.Drawing.Point(4, 38)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1370, 533)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Manufacturers"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(135, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Name Search"
        '
        'txtSearchManu
        '
        Me.txtSearchManu.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchManu.Location = New System.Drawing.Point(258, 103)
        Me.txtSearchManu.Name = "txtSearchManu"
        Me.txtSearchManu.Size = New System.Drawing.Size(170, 30)
        Me.txtSearchManu.TabIndex = 5
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.Location = New System.Drawing.Point(26, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 45)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "back"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button4.Location = New System.Drawing.Point(1054, 325)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dtgManufacturers
        '
        Me.dtgManufacturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgManufacturers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgManufacturers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgManufacturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgManufacturers.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgManufacturers.Location = New System.Drawing.Point(122, 139)
        Me.dtgManufacturers.Name = "dtgManufacturers"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgManufacturers.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgManufacturers.RowHeadersWidth = 51
        Me.dtgManufacturers.RowTemplate.Height = 29
        Me.dtgManufacturers.Size = New System.Drawing.Size(672, 307)
        Me.dtgManufacturers.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(888, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(889, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Manufacturer ID"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(1089, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 49)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(961, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(835, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtmanuName
        '
        Me.txtmanuName.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtmanuName.Location = New System.Drawing.Point(963, 245)
        Me.txtmanuName.Name = "txtmanuName"
        Me.txtmanuName.Size = New System.Drawing.Size(215, 28)
        Me.txtmanuName.TabIndex = 0
        '
        'txtManufacturerID
        '
        Me.txtManufacturerID.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtManufacturerID.Location = New System.Drawing.Point(1026, 200)
        Me.txtManufacturerID.Name = "txtManufacturerID"
        Me.txtManufacturerID.Size = New System.Drawing.Size(108, 28)
        Me.txtManufacturerID.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Silver
        Me.TabPage4.Controls.Add(Me.Button21)
        Me.TabPage4.Controls.Add(Me.dtgTypes)
        Me.TabPage4.Controls.Add(Me.Button8)
        Me.TabPage4.Controls.Add(Me.Button7)
        Me.TabPage4.Controls.Add(Me.Button6)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.txtTypeName)
        Me.TabPage4.Controls.Add(Me.txtTypeID)
        Me.TabPage4.Controls.Add(Me.txtTypeSearch)
        Me.TabPage4.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1370, 533)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Types"
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(27, 25)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(117, 45)
        Me.Button21.TabIndex = 4
        Me.Button21.Text = "Back"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'dtgTypes
        '
        Me.dtgTypes.BackgroundColor = System.Drawing.Color.White
        Me.dtgTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTypes.Location = New System.Drawing.Point(212, 147)
        Me.dtgTypes.Name = "dtgTypes"
        Me.dtgTypes.RowHeadersWidth = 51
        Me.dtgTypes.RowTemplate.Height = 29
        Me.dtgTypes.Size = New System.Drawing.Size(470, 289)
        Me.dtgTypes.TabIndex = 3
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button8.Location = New System.Drawing.Point(1043, 347)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(118, 62)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Location = New System.Drawing.Point(897, 347)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(118, 62)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Update"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button6.Location = New System.Drawing.Point(746, 347)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(118, 62)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Create"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(813, 261)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(813, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Type ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Search"
        '
        'txtTypeName
        '
        Me.txtTypeName.Location = New System.Drawing.Point(890, 258)
        Me.txtTypeName.Name = "txtTypeName"
        Me.txtTypeName.Size = New System.Drawing.Size(163, 30)
        Me.txtTypeName.TabIndex = 0
        '
        'txtTypeID
        '
        Me.txtTypeID.Location = New System.Drawing.Point(911, 193)
        Me.txtTypeID.Name = "txtTypeID"
        Me.txtTypeID.Size = New System.Drawing.Size(104, 30)
        Me.txtTypeID.TabIndex = 0
        '
        'txtTypeSearch
        '
        Me.txtTypeSearch.Location = New System.Drawing.Point(300, 103)
        Me.txtTypeSearch.Name = "txtTypeSearch"
        Me.txtTypeSearch.Size = New System.Drawing.Size(169, 30)
        Me.txtTypeSearch.TabIndex = 0
        '
        'ManageCars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1378, 575)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ManageCars"
        Me.Text = "ManageCars"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dtgCars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dtgModels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dtgManufacturers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.dtgTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents dtgManufacturers As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtmanuName As TextBox
    Friend WithEvents txtManufacturerID As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSearchManu As TextBox
    Friend WithEvents dtgTypes As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTypeName As TextBox
    Friend WithEvents txtTypeID As TextBox
    Friend WithEvents txtTypeSearch As TextBox
    Friend WithEvents dtgModels As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents txtModelSearch As TextBox
    Friend WithEvents txtModelID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModelName As TextBox
    Friend WithEvents cmbMODtype As ComboBox
    Friend WithEvents cmbMODmanu As ComboBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents dtgCars As DataGridView
    Friend WithEvents Label14 As Label
    Friend WithEvents txtCarID As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMileage As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCarType As TextBox
    Friend WithEvents txtCarsManu As TextBox
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents txtCarsearch As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbCarowner As ComboBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button21 As Button
End Class
