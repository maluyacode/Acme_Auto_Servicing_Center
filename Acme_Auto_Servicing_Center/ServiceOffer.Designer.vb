<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceOffer
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
        Me.dgtServiceType = New System.Windows.Forms.DataGridView()
        Me.txtServiceTypeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.txtServiceName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtServiceFee = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearchType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgtServiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgtServiceType
        '
        Me.dgtServiceType.BackgroundColor = System.Drawing.Color.White
        Me.dgtServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtServiceType.Location = New System.Drawing.Point(142, 158)
        Me.dgtServiceType.Name = "dgtServiceType"
        Me.dgtServiceType.RowHeadersWidth = 51
        Me.dgtServiceType.RowTemplate.Height = 29
        Me.dgtServiceType.Size = New System.Drawing.Size(503, 378)
        Me.dgtServiceType.TabIndex = 0
        '
        'txtServiceTypeID
        '
        Me.txtServiceTypeID.Location = New System.Drawing.Point(894, 231)
        Me.txtServiceTypeID.Name = "txtServiceTypeID"
        Me.txtServiceTypeID.Size = New System.Drawing.Size(125, 30)
        Me.txtServiceTypeID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(737, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Service Type ID"
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.Location = New System.Drawing.Point(671, 436)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(131, 73)
        Me.BtnCreate.TabIndex = 3
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.Location = New System.Drawing.Point(835, 436)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(131, 73)
        Me.BtnUpdate.TabIndex = 3
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.Location = New System.Drawing.Point(997, 436)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(131, 73)
        Me.BtnDelete.TabIndex = 3
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'txtServiceName
        '
        Me.txtServiceName.Location = New System.Drawing.Point(811, 279)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(197, 30)
        Me.txtServiceName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(737, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtServiceFee
        '
        Me.txtServiceFee.Location = New System.Drawing.Point(782, 328)
        Me.txtServiceFee.Name = "txtServiceFee"
        Me.txtServiceFee.Size = New System.Drawing.Size(156, 30)
        Me.txtServiceFee.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(737, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fee"
        '
        'txtSearchType
        '
        Me.txtSearchType.Location = New System.Drawing.Point(240, 106)
        Me.txtSearchType.Name = "txtSearchType"
        Me.txtSearchType.Size = New System.Drawing.Size(166, 30)
        Me.txtSearchType.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(154, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Search"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ServiceOffer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1285, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtServiceFee)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.txtSearchType)
        Me.Controls.Add(Me.txtServiceTypeID)
        Me.Controls.Add(Me.dgtServiceType)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "ServiceOffer"
        Me.Text = "ServiceOffer"
        CType(Me.dgtServiceType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgtServiceType As DataGridView
    Friend WithEvents txtServiceTypeID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtServiceName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtServiceFee As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSearchType As TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents Button1 As Button
End Class
