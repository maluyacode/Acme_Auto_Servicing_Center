<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parts
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
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.txtPartID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgParts = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostPrice = New System.Windows.Forms.TextBox()
        Me.txtSellPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpartsSearch = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dtgParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(793, 434)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(124, 72)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'txtPartID
        '
        Me.txtPartID.Location = New System.Drawing.Point(964, 158)
        Me.txtPartID.Name = "txtPartID"
        Me.txtPartID.Size = New System.Drawing.Size(125, 30)
        Me.txtPartID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(838, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Part ID"
        '
        'dtgParts
        '
        Me.dtgParts.BackgroundColor = System.Drawing.Color.White
        Me.dtgParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgParts.Location = New System.Drawing.Point(137, 136)
        Me.dtgParts.Name = "dtgParts"
        Me.dtgParts.RowHeadersWidth = 51
        Me.dtgParts.RowTemplate.Height = 29
        Me.dtgParts.Size = New System.Drawing.Size(602, 399)
        Me.dtgParts.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(964, 208)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 30)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(838, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtCostPrice
        '
        Me.txtCostPrice.Location = New System.Drawing.Point(964, 254)
        Me.txtCostPrice.Name = "txtCostPrice"
        Me.txtCostPrice.Size = New System.Drawing.Size(125, 30)
        Me.txtCostPrice.TabIndex = 1
        '
        'txtSellPrice
        '
        Me.txtSellPrice.Location = New System.Drawing.Point(964, 304)
        Me.txtSellPrice.Name = "txtSellPrice"
        Me.txtSellPrice.Size = New System.Drawing.Size(125, 30)
        Me.txtSellPrice.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(838, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cost Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(838, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Sell Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Search"
        '
        'txtpartsSearch
        '
        Me.txtpartsSearch.Location = New System.Drawing.Point(215, 90)
        Me.txtpartsSearch.Name = "txtpartsSearch"
        Me.txtpartsSearch.Size = New System.Drawing.Size(172, 30)
        Me.txtpartsSearch.TabIndex = 5
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(944, 434)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(124, 72)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(1100, 434)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(124, 72)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(964, 350)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(125, 30)
        Me.txtStock.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(838, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Stock"
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(1156, 217)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(130, 67)
        Me.BtnOrder.TabIndex = 6
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1100, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 37)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1385, 606)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.txtpartsSearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtgParts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtSellPrice)
        Me.Controls.Add(Me.txtCostPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtPartID)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Parts"
        Me.Text = "Parts"
        CType(Me.dtgParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCreate As Button
    Friend WithEvents txtPartID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgParts As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCostPrice As TextBox
    Friend WithEvents txtSellPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpartsSearch As TextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtStock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnOrder As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
