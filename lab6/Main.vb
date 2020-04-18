' Author : Poojan Rajeshkumar Patel
' Student ID : 100762556
'Date : 17 April ,2020
'Description : This application is the Multi Form.In this application user have many options such as he/she can
'              write something,open a new file , save and save as functionality ,user can also use the cut,copy and paste.
'              In addition in this lab user can use many application toghether
Option Strict On

Imports System.IO
Public Class frmMain
    'Friend Shared selectedText As 
    Dim isFileOpen As Boolean = False
    Dim openFilePath As String = String.Empty


    'To create a new text editor
    Private Sub ShowNewTextEditor(sender As Object, e As EventArgs) Handles btnToolStripNewTextEditor.Click, mnuWindowTextEditor.Click
        Dim myTextEditor As New frmTextEditor

        myTextEditor.MdiParent = Me

        myTextEditor.Show()
    End Sub
    'To create a new  Average shipped Units application
    Private Sub btnToolStripNewAverageCarUnits_Click(sender As Object, e As EventArgs) Handles btnToolStripNewAverageCarUnits.Click, mnuWindowOpenAverageUnits.Click
        Dim myAverageCarUnits As New frmAverageShippedUnitsByEmployee

        myAverageCarUnits.MdiParent = Me

        myAverageCarUnits.Show()
    End Sub
    'To create a new  car inventory application
    Private Sub btnToolStripNewCarInventory_Click(sender As Object, e As EventArgs) Handles btnToolStripNewCarInventory.Click, mnuWindowOpenCarList.Click
        Dim myCarInventory As New frmCarInventory

        myCarInventory.MdiParent = Me

        myCarInventory.Show()
    End Sub
    'This command can help user to create a new tetx file.
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Dim myTextEditor As New frmTextEditor
        myTextEditor.MdiParent = Me
        myTextEditor.Show()
    End Sub
    'This command will help user to open a file.
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim openFile As FileStream
        Dim fileReader As StreamReader

        ' If opdOpen.ShowDialog() = DialogResult.OK Then

        'openFilePath = opdOpen.FileName
        isFileOpen = True
        openFile = New FileStream(openFilePath, FileMode.Open,
                     FileAccess.Read)
        fileReader = New StreamReader(openFile)
        frmTextEditor.Text = fileReader.ReadToEnd
        fileReader.Close()
        ' End If
    End Sub
    'By using this command user can save the file.
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If openFilePath = String.Empty Then
            mnuFileSaveAs_Click(sender, e)
        End If
    End Sub
    'This command helps user to close the application by clicking exit button on the screen
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
    'By using this control user can use the save as functionalit.
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) | * .txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, frmTextEditor.Text)
        End If
    End Sub
    'By using this control user can copy the  text.
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        Clipboard.Clear()

        My.Computer.Clipboard.SetText(frmTextEditor.SelectedText)
    End Sub
    'By using this control user can use the cut functionality.
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        Clipboard.Clear()
        My.Computer.Clipboard.SetText(frmTextEditor.SelectedText)
        frmTextEditor.SelectedText = String.Empty
    End Sub
    'By using this command paste the text.
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        frmTextEditor.Text = My.Computer.Clipboard.GetText()
    End Sub

    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    'Providing iinformation about the multi form application.
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Multi Form" & vbCrLf & vbCrLf &
                        "Poojan Patel's Lab 6" & vbCrLf & vbCrLf &
                        "April 17,2020")
    End Sub
End Class
