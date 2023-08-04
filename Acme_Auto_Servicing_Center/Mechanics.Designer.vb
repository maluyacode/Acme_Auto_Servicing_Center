<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mechanics
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
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.txtMechanicID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgMechanics = New System.Windows.Forms.DataGridView()
        Me.txtMechanicName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dateHire = New System.Windows.Forms.DateTimePicker()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.txtSearchMechanic = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateHired = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtgMechanics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCreate.Location = New System.Drawing.Point(765, 441)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(126, 70)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'txtMechanicID
        '
        Me.txtMechanicID.Location = New System.Drawing.Point(951, 253)
        Me.txtMechanicID.Name = "txtMechanicID"
        Me.txtMechanicID.Size = New System.Drawing.Size(141, 30)
        Me.txtMechanicID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(828, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mechanic ID"
        '
        'dtgMechanics
        '
        Me.dtgMechanics.BackgroundColor = System.Drawing.Color.White
        Me.dtgMechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgMechanics.Location = New System.Drawing.Point(106, 153)
        Me.dtgMechanics.Name = "dtgMechanics"
        Me.dtgMechanics.RowHeadersWidth = 51
        Me.dtgMechanics.RowTemplate.Height = 29
        Me.dtgMechanics.Size = New System.Drawing.Size(622, 385)
        Me.dtgMechanics.TabIndex = 3
        '
        'txtMechanicName
        '
        Me.txtMechanicName.Location = New System.Drawing.Point(893, 304)
        Me.txtMechanicName.Name = "txtMechanicName"
        Me.txtMechanicName.Size = New System.Drawing.Size(199, 30)
        Me.txtMechanicName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(828, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'dateHire
        '
        Me.dateHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateHire.Location = New System.Drawing.Point(1160, 24)
        Me.dateHire.Name = "dateHire"
        Me.dateHire.Size = New System.Drawing.Size(145, 30)
        Me.dateHire.TabIndex = 4
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.Location = New System.Drawing.Point(912, 441)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(126, 70)
        Me.BtnUpdate.TabIndex = 0
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnDelete.Location = New System.Drawing.Point(1063, 441)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(126, 70)
        Me.BtnDelete.TabIndex = 0
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'txtSearchMechanic
        '
        Me.txtSearchMechanic.Location = New System.Drawing.Point(187, 98)
        Me.txtSearchMechanic.Name = "txtSearchMechanic"
        Me.txtSearchMechanic.Size = New System.Drawing.Size(175, 30)
        Me.txtSearchMechanic.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Search"
        '
        'txtDateHired
        '
        Me.txtDateHired.Location = New System.Drawing.Point(934, 357)
        Me.txtDateHired.Name = "txtDateHired"
        Me.txtDateHired.Size = New System.Drawing.Size(158, 30)
        Me.txtDateHired.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(828, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date Hired"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mechanics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1345, 594)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDateHired)
        Me.Controls.Add(Me.dateHire)
        Me.Controls.Add(Me.dtgMechanics)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMechanicName)
        Me.Controls.Add(Me.txtSearchMechanic)
        Me.Controls.Add(Me.txtMechanicID)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnCreate)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Mechanics"
        Me.Text = "Mechanics"
        CType(Me.dtgMechanics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCreate As Button
    Friend WithEvents txtMechanicID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtgMechanics As DataGridView
    Friend WithEvents txtMechanicName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dateHire As DateTimePicker
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtSearchMechanic As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDateHired As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
