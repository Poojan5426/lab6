<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageShippedUnitsByEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.txtUnitsInput = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.txtEmployee1Units = New System.Windows.Forms.TextBox()
        Me.txtEmployee2Units = New System.Windows.Forms.TextBox()
        Me.txtEmployee3Units = New System.Windows.Forms.TextBox()
        Me.lblWeek1Average = New System.Windows.Forms.Label()
        Me.lblWeek2Average = New System.Windows.Forms.Label()
        Me.lblWeek3Average = New System.Windows.Forms.Label()
        Me.lblFinalAverage = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpAverageUnitsShippedByEmployee = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblDay
        '
        Me.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDay.Location = New System.Drawing.Point(38, 9)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(100, 23)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnitsInput
        '
        Me.txtUnitsInput.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtUnitsInput.Location = New System.Drawing.Point(159, 50)
        Me.txtUnitsInput.Name = "txtUnitsInput"
        Me.txtUnitsInput.Size = New System.Drawing.Size(100, 22)
        Me.txtUnitsInput.TabIndex = 1
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.txtUnitsInput, "Enter the unit numbers over here")
        '
        'lblUnits
        '
        Me.lblUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnits.Location = New System.Drawing.Point(42, 49)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(100, 23)
        Me.lblUnits.TabIndex = 2
        Me.lblUnits.Text = "Units"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee1
        '
        Me.lblEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee1.Location = New System.Drawing.Point(42, 87)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee1.TabIndex = 3
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee2
        '
        Me.lblEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee2.Location = New System.Drawing.Point(223, 87)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee2.TabIndex = 4
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEmployee3
        '
        Me.lblEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee3.Location = New System.Drawing.Point(393, 87)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployee3.TabIndex = 5
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEmployee1Units
        '
        Me.txtEmployee1Units.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployee1Units.Location = New System.Drawing.Point(22, 124)
        Me.txtEmployee1Units.Multiline = True
        Me.txtEmployee1Units.Name = "txtEmployee1Units"
        Me.txtEmployee1Units.ReadOnly = True
        Me.txtEmployee1Units.Size = New System.Drawing.Size(143, 218)
        Me.txtEmployee1Units.TabIndex = 6
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.txtEmployee1Units, "Dispaly the unit number which are entered for employee 1 ")
        '
        'txtEmployee2Units
        '
        Me.txtEmployee2Units.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployee2Units.Location = New System.Drawing.Point(196, 124)
        Me.txtEmployee2Units.Multiline = True
        Me.txtEmployee2Units.Name = "txtEmployee2Units"
        Me.txtEmployee2Units.ReadOnly = True
        Me.txtEmployee2Units.Size = New System.Drawing.Size(143, 218)
        Me.txtEmployee2Units.TabIndex = 7
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.txtEmployee2Units, "Dispaly the unit number which are entered for employee 2 ")
        '
        'txtEmployee3Units
        '
        Me.txtEmployee3Units.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtEmployee3Units.Location = New System.Drawing.Point(378, 124)
        Me.txtEmployee3Units.Multiline = True
        Me.txtEmployee3Units.Name = "txtEmployee3Units"
        Me.txtEmployee3Units.ReadOnly = True
        Me.txtEmployee3Units.Size = New System.Drawing.Size(131, 218)
        Me.txtEmployee3Units.TabIndex = 8
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.txtEmployee3Units, "Dispaly the unit number which are entered for employee 3 ")
        '
        'lblWeek1Average
        '
        Me.lblWeek1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek1Average.Location = New System.Drawing.Point(22, 349)
        Me.lblWeek1Average.Name = "lblWeek1Average"
        Me.lblWeek1Average.Size = New System.Drawing.Size(143, 23)
        Me.lblWeek1Average.TabIndex = 9
        Me.lblWeek1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.lblWeek1Average, "To display the average of employee1")
        '
        'lblWeek2Average
        '
        Me.lblWeek2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek2Average.Location = New System.Drawing.Point(196, 349)
        Me.lblWeek2Average.Name = "lblWeek2Average"
        Me.lblWeek2Average.Size = New System.Drawing.Size(143, 23)
        Me.lblWeek2Average.TabIndex = 10
        Me.lblWeek2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.lblWeek2Average, "To display the average of employee2")
        '
        'lblWeek3Average
        '
        Me.lblWeek3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeek3Average.Location = New System.Drawing.Point(378, 349)
        Me.lblWeek3Average.Name = "lblWeek3Average"
        Me.lblWeek3Average.Size = New System.Drawing.Size(131, 23)
        Me.lblWeek3Average.TabIndex = 11
        Me.lblWeek3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.lblWeek3Average, "To display the average of employee3")
        '
        'lblFinalAverage
        '
        Me.lblFinalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFinalAverage.Location = New System.Drawing.Point(22, 387)
        Me.lblFinalAverage.Name = "lblFinalAverage"
        Me.lblFinalAverage.Size = New System.Drawing.Size(487, 33)
        Me.lblFinalAverage.TabIndex = 12
        Me.lblFinalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.lblFinalAverage, "To display the total average.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(22, 435)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(143, 36)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.btnEnter, "To add the numbers to the list.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(212, 435)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(127, 36)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.btnReset, "To reset the application.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(393, 435)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 36)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.ttpAverageUnitsShippedByEmployee.SetToolTip(Me.btnExit, "To exit from the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAverageShippedUnitsByEmployee
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(537, 493)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblFinalAverage)
        Me.Controls.Add(Me.lblWeek3Average)
        Me.Controls.Add(Me.lblWeek2Average)
        Me.Controls.Add(Me.lblWeek1Average)
        Me.Controls.Add(Me.txtEmployee3Units)
        Me.Controls.Add(Me.txtEmployee2Units)
        Me.Controls.Add(Me.txtEmployee1Units)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtUnitsInput)
        Me.Controls.Add(Me.lblDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageShippedUnitsByEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped By Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDay As Label
    Friend WithEvents txtUnitsInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents txtEmployee1Units As TextBox
    Friend WithEvents txtEmployee2Units As TextBox
    Friend WithEvents txtEmployee3Units As TextBox
    Friend WithEvents lblWeek1Average As Label
    Friend WithEvents lblWeek2Average As Label
    Friend WithEvents lblWeek3Average As Label
    Friend WithEvents lblFinalAverage As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpAverageUnitsShippedByEmployee As ToolTip
End Class
