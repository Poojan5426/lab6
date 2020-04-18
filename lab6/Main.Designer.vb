<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuTopMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTileHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowOpenCarList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowOpenAverageUnits = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowTextEditor1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuWindowTextEditor = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsTools = New System.Windows.Forms.ToolStrip()
        Me.btnToolStripNewTextEditor = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewAverageCarUnits = New System.Windows.Forms.ToolStripButton()
        Me.btnToolStripNewCarInventory = New System.Windows.Forms.ToolStripButton()
        Me.mnuTopMenu.SuspendLayout()
        Me.tsTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuTopMenu
        '
        Me.mnuTopMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuTopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp, Me.mnuWindow})
        Me.mnuTopMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopMenu.Name = "mnuTopMenu"
        Me.mnuTopMenu.Size = New System.Drawing.Size(782, 28)
        Me.mnuTopMenu.TabIndex = 1
        Me.mnuTopMenu.Text = "MenuStrip"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(46, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Image = CType(resources.GetObject("mnuFileNew.Image"), System.Drawing.Image)
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuFileNew.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileNew.Text = "&New"
        Me.mnuFileNew.ToolTipText = "To create   a new text file."
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Image = CType(resources.GetObject("mnuFileOpen.Image"), System.Drawing.Image)
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuFileOpen.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileOpen.Text = "&Open"
        Me.mnuFileOpen.ToolTipText = "To open a old text files."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Image = CType(resources.GetObject("mnuFileSave.Image"), System.Drawing.Image)
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSave.Text = "&Save"
        Me.mnuFileSave.ToolTipText = "To save the work."
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Image = CType(resources.GetObject("mnuFileSaveAs.Image"), System.Drawing.Image)
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileSaveAs.Text = "S&ave as"
        Me.mnuFileSaveAs.ToolTipText = "To save the work as a new file."
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Image = CType(resources.GetObject("mnuFileExit.Image"), System.Drawing.Image)
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(181, 26)
        Me.mnuFileExit.Text = "E&xit"
        Me.mnuFileExit.ToolTipText = "To exit from the application."
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditCopy, Me.mnuEditCut, Me.mnuEditPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(49, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditCopy
        '
        Me.mnuEditCopy.Image = CType(resources.GetObject("mnuEditCopy.Image"), System.Drawing.Image)
        Me.mnuEditCopy.Name = "mnuEditCopy"
        Me.mnuEditCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuEditCopy.Size = New System.Drawing.Size(224, 26)
        Me.mnuEditCopy.Text = "&Copy"
        Me.mnuEditCopy.ToolTipText = "To copy the text."
        '
        'mnuEditCut
        '
        Me.mnuEditCut.Image = CType(resources.GetObject("mnuEditCut.Image"), System.Drawing.Image)
        Me.mnuEditCut.Name = "mnuEditCut"
        Me.mnuEditCut.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuEditCut.Size = New System.Drawing.Size(224, 26)
        Me.mnuEditCut.Text = "Cu&t"
        Me.mnuEditCut.ToolTipText = "To cut the text."
        '
        'mnuEditPaste
        '
        Me.mnuEditPaste.Image = CType(resources.GetObject("mnuEditPaste.Image"), System.Drawing.Image)
        Me.mnuEditPaste.Name = "mnuEditPaste"
        Me.mnuEditPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuEditPaste.Size = New System.Drawing.Size(224, 26)
        Me.mnuEditPaste.Text = "&Pate"
        Me.mnuEditPaste.ToolTipText = "To paste the text."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(55, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Image = CType(resources.GetObject("mnuHelpAbout.Image"), System.Drawing.Image)
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpAbout.Size = New System.Drawing.Size(224, 26)
        Me.mnuHelpAbout.Text = "About"
        Me.mnuHelpAbout.ToolTipText = "To know about the application."
        '
        'mnuWindow
        '
        Me.mnuWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowCascade, Me.mnuWindowTileVertical, Me.mnuWindowTileHorizontal, Me.ToolStripSeparator1, Me.mnuWindowOpenCarList, Me.mnuWindowOpenAverageUnits, Me.mnuWindowTextEditor1, Me.mnuWindowTextEditor})
        Me.mnuWindow.Name = "mnuWindow"
        Me.mnuWindow.Size = New System.Drawing.Size(78, 24)
        Me.mnuWindow.Text = "&Window"
        '
        'mnuWindowCascade
        '
        Me.mnuWindowCascade.Name = "mnuWindowCascade"
        Me.mnuWindowCascade.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowCascade.Text = "&Cascade"
        '
        'mnuWindowTileVertical
        '
        Me.mnuWindowTileVertical.Name = "mnuWindowTileVertical"
        Me.mnuWindowTileVertical.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowTileVertical.Text = "Tile  &Vertical"
        '
        'mnuWindowTileHorizontal
        '
        Me.mnuWindowTileHorizontal.Name = "mnuWindowTileHorizontal"
        Me.mnuWindowTileHorizontal.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowTileHorizontal.Text = "Tile  &Horizontal "
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuWindowOpenCarList
        '
        Me.mnuWindowOpenCarList.Name = "mnuWindowOpenCarList"
        Me.mnuWindowOpenCarList.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowOpenCarList.Text = "Open &Car List"
        '
        'mnuWindowOpenAverageUnits
        '
        Me.mnuWindowOpenAverageUnits.Name = "mnuWindowOpenAverageUnits"
        Me.mnuWindowOpenAverageUnits.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowOpenAverageUnits.Text = "Open &Average Units"
        '
        'mnuWindowTextEditor1
        '
        Me.mnuWindowTextEditor1.Name = "mnuWindowTextEditor1"
        Me.mnuWindowTextEditor1.Size = New System.Drawing.Size(221, 6)
        '
        'mnuWindowTextEditor
        '
        Me.mnuWindowTextEditor.Name = "mnuWindowTextEditor"
        Me.mnuWindowTextEditor.Size = New System.Drawing.Size(224, 26)
        Me.mnuWindowTextEditor.Text = "Text &Editor - New"
        '
        'tsTools
        '
        Me.tsTools.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnToolStripNewTextEditor, Me.btnToolStripNewAverageCarUnits, Me.btnToolStripNewCarInventory})
        Me.tsTools.Location = New System.Drawing.Point(0, 28)
        Me.tsTools.Name = "tsTools"
        Me.tsTools.Size = New System.Drawing.Size(782, 27)
        Me.tsTools.TabIndex = 2
        Me.tsTools.Text = "ToolStrip1"
        '
        'btnToolStripNewTextEditor
        '
        Me.btnToolStripNewTextEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewTextEditor.Image = CType(resources.GetObject("btnToolStripNewTextEditor.Image"), System.Drawing.Image)
        Me.btnToolStripNewTextEditor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewTextEditor.Name = "btnToolStripNewTextEditor"
        Me.btnToolStripNewTextEditor.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNewTextEditor.Text = "New Text Editor"
        '
        'btnToolStripNewAverageCarUnits
        '
        Me.btnToolStripNewAverageCarUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewAverageCarUnits.Image = CType(resources.GetObject("btnToolStripNewAverageCarUnits.Image"), System.Drawing.Image)
        Me.btnToolStripNewAverageCarUnits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewAverageCarUnits.Name = "btnToolStripNewAverageCarUnits"
        Me.btnToolStripNewAverageCarUnits.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNewAverageCarUnits.Text = "Average Car Units"
        '
        'btnToolStripNewCarInventory
        '
        Me.btnToolStripNewCarInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnToolStripNewCarInventory.Image = CType(resources.GetObject("btnToolStripNewCarInventory.Image"), System.Drawing.Image)
        Me.btnToolStripNewCarInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnToolStripNewCarInventory.Name = "btnToolStripNewCarInventory"
        Me.btnToolStripNewCarInventory.Size = New System.Drawing.Size(29, 24)
        Me.btnToolStripNewCarInventory.Text = "Car Inventory"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.tsTools)
        Me.Controls.Add(Me.mnuTopMenu)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Form"
        Me.mnuTopMenu.ResumeLayout(False)
        Me.mnuTopMenu.PerformLayout()
        Me.tsTools.ResumeLayout(False)
        Me.tsTools.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditCopy As ToolStripMenuItem
    Friend WithEvents mnuEditCut As ToolStripMenuItem
    Friend WithEvents mnuEditPaste As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuWindow As ToolStripMenuItem
    Friend WithEvents mnuWindowCascade As ToolStripMenuItem
    Friend WithEvents mnuWindowTileVertical As ToolStripMenuItem
    Friend WithEvents mnuWindowTileHorizontal As ToolStripMenuItem
    Friend WithEvents tsTools As ToolStrip
    Friend WithEvents mnuWindowOpenCarList As ToolStripMenuItem
    Friend WithEvents mnuWindowOpenAverageUnits As ToolStripMenuItem
    Friend WithEvents mnuWindowTextEditor As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuWindowTextEditor1 As ToolStripSeparator
    Friend WithEvents btnToolStripNewTextEditor As ToolStripButton
    Friend WithEvents btnToolStripNewAverageCarUnits As ToolStripButton
    Friend WithEvents btnToolStripNewCarInventory As ToolStripButton
End Class
