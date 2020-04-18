<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lblMake = New System.Windows.Forms.Label()
        Me.blModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPriceBox = New System.Windows.Forms.TextBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCarInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblErrorBox = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ttpCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(87, 21)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(51, 17)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'blModel
        '
        Me.blModel.Location = New System.Drawing.Point(87, 57)
        Me.blModel.Name = "blModel"
        Me.blModel.Size = New System.Drawing.Size(51, 17)
        Me.blModel.TabIndex = 2
        Me.blModel.Text = "Model:"
        Me.blModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(87, 97)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(51, 17)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(87, 132)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(51, 17)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(87, 172)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(51, 17)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(162, 58)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(126, 22)
        Me.txtModel.TabIndex = 3
        Me.ttpCarInventory.SetToolTip(Me.txtModel, "Enter the car model.")
        '
        'txtPriceBox
        '
        Me.txtPriceBox.Location = New System.Drawing.Point(162, 128)
        Me.txtPriceBox.Name = "txtPriceBox"
        Me.txtPriceBox.Size = New System.Drawing.Size(127, 22)
        Me.txtPriceBox.TabIndex = 7
        Me.ttpCarInventory.SetToolTip(Me.txtPriceBox, "Enter the price of the particular car.")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"SUZUKI", "HONDA", "HYUNDAI", "LAND ROVER", "VOLKSWAGEN", "B.M.W.", "MASERATI", "AUDI", "PORSCHE", "MERCEDES", "JAGUAR", "LAMBORGHINI", "FERRARI", "BUGATTI", "MCLEARN", "KIA", "GMC", "FORD", "CHEVROLET", "CHRYSLER", "KOENIGSEGG", "PAGANI", "BENTLEY", "ROLLS ROYCE", "PONTIAC", "DATSUN", "NISSAN", "SKODA", "JEEP", "TOYOTA", "MITSUBISHI", "TATA", "M.G.", "D.S.", "D.C.", "TESLA", "ACURA", "RAM", "DODGE"})
        Me.cmbMake.Location = New System.Drawing.Point(162, 14)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(127, 24)
        Me.cmbMake.TabIndex = 1
        Me.ttpCarInventory.SetToolTip(Me.cmbMake, "Select the car company.")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1920", "1930", "1940", "1950", "1960", "1970", "1980", "1990", "2000", "2010", "2020"})
        Me.cmbYear.Location = New System.Drawing.Point(161, 94)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(127, 24)
        Me.cmbYear.TabIndex = 5
        Me.ttpCarInventory.SetToolTip(Me.cmbYear, "Select the year when car iss built.")
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(161, 172)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(18, 17)
        Me.chkNew.TabIndex = 9
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCarInventory
        '
        Me.lvwCarInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCarInventory.FullRowSelect = True
        Me.lvwCarInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCarInventory.HideSelection = False
        Me.lvwCarInventory.Location = New System.Drawing.Point(12, 195)
        Me.lvwCarInventory.MultiSelect = False
        Me.lvwCarInventory.Name = "lvwCarInventory"
        Me.lvwCarInventory.Size = New System.Drawing.Size(423, 182)
        Me.lvwCarInventory.TabIndex = 10
        Me.ttpCarInventory.SetToolTip(Me.lvwCarInventory, "Select a car information.")
        Me.lvwCarInventory.UseCompatibleStateImageBehavior = False
        Me.lvwCarInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        '
        'lblErrorBox
        '
        Me.lblErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblErrorBox.Location = New System.Drawing.Point(15, 405)
        Me.lblErrorBox.Name = "lblErrorBox"
        Me.lblErrorBox.Size = New System.Drawing.Size(365, 93)
        Me.lblErrorBox.TabIndex = 11
        Me.ttpCarInventory.SetToolTip(Me.lblErrorBox, "Message will be display over here.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(106, 501)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 32)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpCarInventory.SetToolTip(Me.btnEnter, "Click to enter the data.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(203, 501)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 32)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpCarInventory.SetToolTip(Me.btnReset, "To reset the application.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(305, 501)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "&Exit"
        Me.ttpCarInventory.SetToolTip(Me.btnExit, "To exit from the program.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(447, 545)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblErrorBox)
        Me.Controls.Add(Me.lvwCarInventory)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtPriceBox)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.blModel)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents blModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPriceBox As TextBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCarInventory As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents lblErrorBox As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ttpCarInventory As ToolTip

End Class
