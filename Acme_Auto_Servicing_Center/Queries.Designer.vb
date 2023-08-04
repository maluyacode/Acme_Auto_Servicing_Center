<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Queries
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
        Me.txtSearchQueries = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbtQuiz1 = New System.Windows.Forms.RadioButton()
        Me.RbtQuiz2 = New System.Windows.Forms.RadioButton()
        Me.RbtQuiz3 = New System.Windows.Forms.RadioButton()
        Me.RbtQuiz4 = New System.Windows.Forms.RadioButton()
        Me.RbtQuiz5 = New System.Windows.Forms.RadioButton()
        Me.dtgQueries = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        CType(Me.dtgQueries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchQueries
        '
        Me.txtSearchQueries.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchQueries.Location = New System.Drawing.Point(935, 42)
        Me.txtSearchQueries.Name = "txtSearchQueries"
        Me.txtSearchQueries.Size = New System.Drawing.Size(228, 34)
        Me.txtSearchQueries.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(856, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search"
        '
        'RbtQuiz1
        '
        Me.RbtQuiz1.AutoSize = True
        Me.RbtQuiz1.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtQuiz1.Location = New System.Drawing.Point(43, 110)
        Me.RbtQuiz1.Name = "RbtQuiz1"
        Me.RbtQuiz1.Size = New System.Drawing.Size(513, 56)
        Me.RbtQuiz1.TabIndex = 2
        Me.RbtQuiz1.TabStop = True
        Me.RbtQuiz1.Text = "Search for a car model and list all the parts that were" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "used to repair those car" &
    " models"
        Me.RbtQuiz1.UseVisualStyleBackColor = True
        '
        'RbtQuiz2
        '
        Me.RbtQuiz2.AutoSize = True
        Me.RbtQuiz2.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtQuiz2.Location = New System.Drawing.Point(43, 211)
        Me.RbtQuiz2.Name = "RbtQuiz2"
        Me.RbtQuiz2.Size = New System.Drawing.Size(562, 30)
        Me.RbtQuiz2.TabIndex = 2
        Me.RbtQuiz2.TabStop = True
        Me.RbtQuiz2.Text = "Search for a supplier and list all delivered part/accessories"
        Me.RbtQuiz2.UseVisualStyleBackColor = True
        '
        'RbtQuiz3
        '
        Me.RbtQuiz3.AutoSize = True
        Me.RbtQuiz3.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtQuiz3.Location = New System.Drawing.Point(43, 291)
        Me.RbtQuiz3.Name = "RbtQuiz3"
        Me.RbtQuiz3.Size = New System.Drawing.Size(527, 30)
        Me.RbtQuiz3.TabIndex = 2
        Me.RbtQuiz3.TabStop = True
        Me.RbtQuiz3.Text = "Search for a mechanic and list all the cars he serviced."
        Me.RbtQuiz3.UseVisualStyleBackColor = True
        '
        'RbtQuiz4
        '
        Me.RbtQuiz4.AutoSize = True
        Me.RbtQuiz4.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtQuiz4.Location = New System.Drawing.Point(43, 373)
        Me.RbtQuiz4.Name = "RbtQuiz4"
        Me.RbtQuiz4.Size = New System.Drawing.Size(542, 30)
        Me.RbtQuiz4.TabIndex = 2
        Me.RbtQuiz4.TabStop = True
        Me.RbtQuiz4.Text = "Search for a service and list all cars that went through it."
        Me.RbtQuiz4.UseVisualStyleBackColor = True
        '
        'RbtQuiz5
        '
        Me.RbtQuiz5.AutoSize = True
        Me.RbtQuiz5.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RbtQuiz5.Location = New System.Drawing.Point(43, 451)
        Me.RbtQuiz5.Name = "RbtQuiz5"
        Me.RbtQuiz5.Size = New System.Drawing.Size(644, 30)
        Me.RbtQuiz5.TabIndex = 2
        Me.RbtQuiz5.TabStop = True
        Me.RbtQuiz5.Text = "Input a date range and list all cars that were serviced on those dates"
        Me.RbtQuiz5.UseVisualStyleBackColor = True
        '
        'dtgQueries
        '
        Me.dtgQueries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgQueries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtgQueries.BackgroundColor = System.Drawing.Color.White
        Me.dtgQueries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgQueries.Location = New System.Drawing.Point(730, 160)
        Me.dtgQueries.Name = "dtgQueries"
        Me.dtgQueries.RowHeadersWidth = 51
        Me.dtgQueries.RowTemplate.Height = 29
        Me.dtgQueries.Size = New System.Drawing.Size(658, 331)
        Me.dtgQueries.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(131, 494)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(143, 30)
        Me.DateTimePicker1.TabIndex = 4
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(354, 494)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(143, 30)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(291, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(730, 110)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(344, 34)
        Me.txtDisplay.TabIndex = 5
        '
        'Queries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1440, 623)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dtgQueries)
        Me.Controls.Add(Me.RbtQuiz5)
        Me.Controls.Add(Me.RbtQuiz4)
        Me.Controls.Add(Me.RbtQuiz3)
        Me.Controls.Add(Me.RbtQuiz2)
        Me.Controls.Add(Me.RbtQuiz1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchQueries)
        Me.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Queries"
        Me.Text = "Queries"
        CType(Me.dtgQueries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchQueries As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RbtQuiz1 As RadioButton
    Friend WithEvents RbtQuiz2 As RadioButton
    Friend WithEvents RbtQuiz3 As RadioButton
    Friend WithEvents RbtQuiz4 As RadioButton
    Friend WithEvents RbtQuiz5 As RadioButton
    Friend WithEvents dtgQueries As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisplay As TextBox
End Class
