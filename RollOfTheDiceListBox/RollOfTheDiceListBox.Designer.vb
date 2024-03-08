<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollOfTheDiceListBox
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
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(7, 48)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(404, 186)
        Me.OutputListBox.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(306, 240)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(105, 49)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 240)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(105, 49)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(84, 240)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(105, 49)
        Me.RollButton.TabIndex = 3
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'RollOfTheDiceListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 296)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.OutputListBox)
        Me.Name = "RollOfTheDiceListBox"
        Me.Text = "Roll of The Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents RollButton As Button
End Class
