<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineProblem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachineProblem))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCustomer = New System.Windows.Forms.Button()
        Me.BtnServices = New System.Windows.Forms.Button()
        Me.BtnMechanics = New System.Windows.Forms.Button()
        Me.BtnCars = New System.Windows.Forms.Button()
        Me.BtnParts = New System.Windows.Forms.Button()
        Me.BtnSupplier = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(550, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Management"
        '
        'BtnCustomer
        '
        Me.BtnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCustomer.BackgroundImage = CType(resources.GetObject("BtnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.BtnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCustomer.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCustomer.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCustomer.Location = New System.Drawing.Point(89, 86)
        Me.BtnCustomer.Name = "BtnCustomer"
        Me.BtnCustomer.Size = New System.Drawing.Size(350, 250)
        Me.BtnCustomer.TabIndex = 0
        Me.BtnCustomer.UseVisualStyleBackColor = False
        '
        'BtnServices
        '
        Me.BtnServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnServices.BackgroundImage = CType(resources.GetObject("BtnServices.BackgroundImage"), System.Drawing.Image)
        Me.BtnServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnServices.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnServices.Location = New System.Drawing.Point(89, 408)
        Me.BtnServices.Name = "BtnServices"
        Me.BtnServices.Size = New System.Drawing.Size(350, 250)
        Me.BtnServices.TabIndex = 0
        Me.BtnServices.UseVisualStyleBackColor = False
        '
        'BtnMechanics
        '
        Me.BtnMechanics.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnMechanics.BackgroundImage = CType(resources.GetObject("BtnMechanics.BackgroundImage"), System.Drawing.Image)
        Me.BtnMechanics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMechanics.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMechanics.Location = New System.Drawing.Point(846, 86)
        Me.BtnMechanics.Name = "BtnMechanics"
        Me.BtnMechanics.Size = New System.Drawing.Size(350, 250)
        Me.BtnMechanics.TabIndex = 0
        Me.BtnMechanics.UseVisualStyleBackColor = False
        '
        'BtnCars
        '
        Me.BtnCars.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnCars.BackgroundImage = CType(resources.GetObject("BtnCars.BackgroundImage"), System.Drawing.Image)
        Me.BtnCars.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCars.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCars.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCars.Location = New System.Drawing.Point(466, 86)
        Me.BtnCars.Name = "BtnCars"
        Me.BtnCars.Size = New System.Drawing.Size(350, 250)
        Me.BtnCars.TabIndex = 0
        Me.BtnCars.Text = "Cars"
        Me.BtnCars.UseVisualStyleBackColor = False
        '
        'BtnParts
        '
        Me.BtnParts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnParts.BackgroundImage = CType(resources.GetObject("BtnParts.BackgroundImage"), System.Drawing.Image)
        Me.BtnParts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnParts.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnParts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnParts.Location = New System.Drawing.Point(846, 408)
        Me.BtnParts.Name = "BtnParts"
        Me.BtnParts.Size = New System.Drawing.Size(350, 250)
        Me.BtnParts.TabIndex = 0
        Me.BtnParts.UseVisualStyleBackColor = False
        '
        'BtnSupplier
        '
        Me.BtnSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSupplier.BackgroundImage = CType(resources.GetObject("BtnSupplier.BackgroundImage"), System.Drawing.Image)
        Me.BtnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSupplier.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSupplier.Location = New System.Drawing.Point(466, 408)
        Me.BtnSupplier.Name = "BtnSupplier"
        Me.BtnSupplier.Size = New System.Drawing.Size(350, 250)
        Me.BtnSupplier.TabIndex = 0
        Me.BtnSupplier.Text = "Supplier"
        Me.BtnSupplier.UseVisualStyleBackColor = False
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.Location = New System.Drawing.Point(12, 12)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(117, 45)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(191, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(599, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 39)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cars"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(936, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 39)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mechanics"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(189, 659)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 39)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Services"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(569, 659)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 39)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Supplier"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(905, 659)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 39)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Parts/Accesories"
        '
        'MachineProblem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1262, 748)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnMechanics)
        Me.Controls.Add(Me.BtnSupplier)
        Me.Controls.Add(Me.BtnCustomer)
        Me.Controls.Add(Me.BtnParts)
        Me.Controls.Add(Me.BtnServices)
        Me.Controls.Add(Me.BtnCars)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "MachineProblem"
        Me.Text = "MachineProblem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCustomer As Button
    Friend WithEvents BtnServices As Button
    Friend WithEvents BtnMechanics As Button
    Friend WithEvents BtnCars As Button
    Friend WithEvents BtnParts As Button
    Friend WithEvents BtnSupplier As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
