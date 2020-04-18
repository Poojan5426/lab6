' Author : Poojan Rajeshkumar Patel
' Student ID : 100762556
'Date : 2 April ,2020
'Description : This application is the text editor.In this application user have many options such as he/she can
'              write something,open a new file , save and save as functionality ,user can also use the cut,copy and paste.
Option Strict On
Imports System.IO

Public Class frmTextEditor
    Friend Shared SelectedText As String
    Dim isFileOpen As Boolean = False
    Dim openFilePath As String = String.Empty


    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Text Editor" & vbCrLf & vbCrLf &
                        "Poojan Patel's Lab 5" & vbCrLf & vbCrLf &
                        "April 2,2020")

    End Sub
    '
    'This command helps user to close the application by clicking exit button on the screen
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
    'This command can help user to create a new tetx file.
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        tbEditor.Clear()
        isFileOpen = False
        openFilePath = String.Empty
    End Sub
    'This command will help user to open a file.
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim openFile As FileStream
        Dim fileReader As StreamReader

        If opdOpen.ShowDialog() = DialogResult.OK Then

            openFilePath = opdOpen.FileName
            isFileOpen = True
            openFile = New FileStream(openFilePath, FileMode.Open,
                         FileAccess.Read)
            fileReader = New StreamReader(openFile)
            tbEditor.Text = fileReader.ReadToEnd
            fileReader.Close()
        End If


    End Sub
    'By using this command user can save the file.
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        If openFilePath = String.Empty Then
            mnuFileSaveAs_Click(sender, e)
        End If
    End Sub
    'By using this control user can use the save as functionalit.
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Dim iSave As New SaveFileDialog
        iSave.Filter = "txt files (*.txt) | * .txt"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, tbEditor.Text)
        End If
    End Sub
    'By using this control user can copy the  text.
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        Clipboard.Clear()

        My.Computer.Clipboard.SetText(tbEditor.SelectedText)
    End Sub
    'By using this control user can use the cut functionality.
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        Clipboard.Clear()
        My.Computer.Clipboard.SetText(tbEditor.SelectedText)
        tbEditor.SelectedText = String.Empty
    End Sub
    'By using this command paste the text.
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        tbEditor.Text = My.Computer.Clipboard.GetText()
    End Sub
End Class
