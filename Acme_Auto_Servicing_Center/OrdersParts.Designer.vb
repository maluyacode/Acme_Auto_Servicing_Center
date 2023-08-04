<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdersParts
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
        Me.dtgOrderParts = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPurchase = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpartID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.lbParts = New System.Windows.Forms.ListBox()
        Me.cmbname = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnCancelAll = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtgOrderParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgOrderParts
        '
        Me.dtgOrderParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgOrderParts.Location = New System.Drawing.Point(58, 101)
        Me.dtgOrderParts.Name = "dtgOrderParts"
        Me.dtgOrderParts.RowHeadersWidth = 51
        Me.dtgOrderParts.RowTemplate.Height = 29
        Me.dtgOrderParts.Size = New System.Drawing.Size(691, 429)
        Me.dtgOrderParts.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(784, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Part ID"
        '
        'BtnPurchase
        '
        Me.BtnPurchase.Location = New System.Drawing.Point(1162, 443)
        Me.BtnPurchase.Name = "BtnPurchase"
        Me.BtnPurchase.Size = New System.Drawing.Size(123, 87)
        Me.BtnPurchase.TabIndex = 3
        Me.BtnPurchase.Text = "Purchase"
        Me.BtnPurchase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(784, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'txtpartID
        '
        Me.txtpartID.Location = New System.Drawing.Point(876, 217)
        Me.txtpartID.Name = "txtpartID"
        Me.txtpartID.Size = New System.Drawing.Size(125, 30)
        Me.txtpartID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(784, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(876, 264)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(125, 30)
        Me.txtQuantity.TabIndex = 2
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(1074, 126)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(211, 31)
        Me.cmbSupplier.TabIndex = 4
        Me.cmbSupplier.Text = "SELECT SUPPLIER:"
        '
        'lbParts
        '
        Me.lbParts.FormattingEnabled = True
        Me.lbParts.ItemHeight = 23
        Me.lbParts.Location = New System.Drawing.Point(813, 385)
        Me.lbParts.Name = "lbParts"
        Me.lbParts.Size = New System.Drawing.Size(137, 142)
        Me.lbParts.TabIndex = 5
        '
        'cmbname
        '
        Me.cmbname.FormattingEnabled = True
        Me.cmbname.Location = New System.Drawing.Point(856, 126)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(173, 31)
        Me.cmbname.TabIndex = 4
        Me.cmbname.Text = "SELECT PARTS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(813, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Parts order:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(976, 471)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(143, 30)
        Me.txtTotal.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1020, 504)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Total"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(876, 176)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(125, 30)
        Me.txtPrice.TabIndex = 7
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(1030, 254)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(89, 48)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnCancelAll
        '
        Me.BtnCancelAll.Location = New System.Drawing.Point(1140, 254)
        Me.BtnCancelAll.Name = "BtnCancelAll"
        Me.BtnCancelAll.Size = New System.Drawing.Size(99, 48)
        Me.BtnCancelAll.TabIndex = 10
        Me.BtnCancelAll.Text = "Reset"
        Me.BtnCancelAll.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(655, 53)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(94, 42)
        Me.BtnRefresh.TabIndex = 11
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(29, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OrdersParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnCancelAll)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lbParts)
        Me.Controls.Add(Me.cmbname)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.BtnPurchase)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtpartID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgOrderParts)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "OrdersParts"
        Me.Text = "OrderParts"
        CType(Me.dtgOrderParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgOrderParts As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPurchase As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpartID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents lbParts As ListBox
    Friend WithEvents cmbname As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnCancelAll As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents Button1 As Button
End Class
