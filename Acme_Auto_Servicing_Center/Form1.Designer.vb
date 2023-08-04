<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRecordService = New System.Windows.Forms.Button()
        Me.BtnManage = New System.Windows.Forms.Button()
        Me.BtnQueries = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BankGothic Lt BT", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(224, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(885, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Acme Auto Serving Center"
        '
        'BtnRecordService
        '
        Me.BtnRecordService.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnRecordService.Font = New System.Drawing.Font("Baskerville Old Face", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnRecordService.Location = New System.Drawing.Point(793, 195)
        Me.BtnRecordService.Name = "BtnRecordService"
        Me.BtnRecordService.Size = New System.Drawing.Size(286, 100)
        Me.BtnRecordService.TabIndex = 1
        Me.BtnRecordService.Text = "Record Service"
        Me.BtnRecordService.UseVisualStyleBackColor = False
        '
        'BtnManage
        '
        Me.BtnManage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnManage.Font = New System.Drawing.Font("Baskerville Old Face", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnManage.Location = New System.Drawing.Point(793, 325)
        Me.BtnManage.Name = "BtnManage"
        Me.BtnManage.Size = New System.Drawing.Size(286, 100)
        Me.BtnManage.TabIndex = 1
        Me.BtnManage.Text = "Manage"
        Me.BtnManage.UseVisualStyleBackColor = False
        '
        'BtnQueries
        '
        Me.BtnQueries.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnQueries.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnQueries.Location = New System.Drawing.Point(37, 488)
        Me.BtnQueries.Name = "BtnQueries"
        Me.BtnQueries.Size = New System.Drawing.Size(115, 56)
        Me.BtnQueries.TabIndex = 2
        Me.BtnQueries.Text = "Queries"
        Me.BtnQueries.UseVisualStyleBackColor = False
        '
        'BtnHistory
        '
        Me.BtnHistory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnHistory.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHistory.Location = New System.Drawing.Point(175, 488)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(115, 56)
        Me.BtnHistory.TabIndex = 3
        Me.BtnHistory.Text = "History"
        Me.BtnHistory.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1323, 571)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnQueries)
        Me.Controls.Add(Me.BtnManage)
        Me.Controls.Add(Me.BtnRecordService)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRecordService As Button
    Friend WithEvents BtnManage As Button
    Friend WithEvents BtnQueries As Button
    Friend WithEvents BtnHistory As Button
End Class
