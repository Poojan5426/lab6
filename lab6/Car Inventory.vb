' Author : Poojan Rajeshkumar Patel
' Student ID : 100762556
'Date : 23 March ,2020
'Description : This application is created for doing the car inventory.In this application varoius codes are used.In this application user can do a car 
'              by choosing the car company and the year when car was built and user has to add the car price and the model name of the car.the 
'              important function is there is a checkbox available so that the user can choose whether the car is used one or new one.After 
'              filling the data user can see the entire details of the car.


Option Strict On
Public Class frmCarInventory

    Dim car As Car                                      ' To declare a Car class object
    Dim iscarSelected As Boolean = False
    Dim isAddingToListView As Boolean = False
    Dim carList As New List(Of Car)

    Const DefaultYear As Integer = 1980

    'To enter the data in the application and user can also use the enter button of the keyboard to enter the data.
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' validate the data in the form
        If IsValidInput() = True Then
            lblErrorBox.Text = "Yeah it is working."
            ' set the edit flag to true
            If Not iscarSelected Then

                car = New Car(cmbMake.Text, txtModel.Text, CInt(cmbYear.Text), Convert.ToDecimal(txtPriceBox.Text), chkNew.Checked)
                carList.Add(car)

            ElseIf car.Id.ToString.Trim.Length > 0 Then


                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = CInt(cmbYear.Text)
                car.Price = Convert.ToDecimal(txtPriceBox.Text)
                car.IsNew = chkNew.Checked
            End If

            ' Indicate that the entered data is succesfull.
            lblErrorBox.Text = "Yeah it is working."



            Reset()


        End If

    End Sub
    'To reset all the things such as textboxes and lables.
    Private Sub Reset()
        txtModel.Text = String.Empty
        cmbMake.Text = String.Empty
        cmbYear.SelectedIndex = -1
        cmbMake.SelectedIndex = -1
        chkNew.Checked = False
        txtPriceBox.Clear()
        PopulateList()

        iscarSelected = False

        cmbMake.Focus()
    End Sub

    Private Function IsValidInput() As Boolean               ' function to validate values 
        Dim returnValue As Boolean = True       'variable for return value 
        Dim errorMessage As String = String.Empty          'variable to print error message 


        'To check the entered data is ok or not. 
        If cmbMake.SelectedIndex = -1 Then
            'To show the error message if the entered data is not valid.
            errorMessage += "Please select the car's make." & vbCrLf
            returnValue = False
        End If

        'To check the entered model name of car is ok or not. 
        If txtModel.Text.Trim.Length = 0 Then
            'To show the error message if the entered data is not valid.
            errorMessage += "Please enter the name of  the car(model)." & vbCrLf
            returnValue = False
        End If

        'To check the entered price of car is ok or not. 
        If txtPriceBox.Text.Trim.Length = 0 Then
            'To show the error message if the entered data is not valid.
            errorMessage += "Please enter the actual price of car." & vbCrLf
            returnValue = False
        End If

        'To check the entered number of year is ok or not. 
        If cmbYear.SelectedIndex = -1 Then
            'To show the error message if the entered data is not valid.
            errorMessage += "Please choose the number of year when car has been created ." & vbCrLf
            returnValue = False

        End If

        'if any error occurs display this message 
        If returnValue = False Then
            'To show the error .
            lblErrorBox.Text = "OOPS!Something went wrong." & vbCrLf & errorMessage
        End If

        Return returnValue

    End Function

    Sub PopulateList()

        lvwCarInventory.Items.Clear()

        For index As Integer = 0 To carList.Count - 1

            Dim carItem As New ListViewItem()

            carItem.SubItems.Add(carList(index).Id.ToString)
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString)
            carItem.Checked = carList(index).IsNew

            isAddingToListView = True

            lvwCarInventory.Items.Add(carItem)

            isAddingToListView = False

        Next


    End Sub
    ' Event handler for the event that a car is selected in the ListView
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarInventory.SelectedIndexChanged
        'private sub for listview result 
        If lvwCarInventory.SelectedIndices.Count = 1 Then
            car = carList(lvwCarInventory.SelectedIndices(0))
            iscarSelected = True

            txtModel.Text = car.Model
            txtPriceBox.Text = car.Price.ToString
            cmbMake.Text = car.Make
            cmbYear.Text = car.Year.ToString
            chkNew.Checked = car.IsNew

            lblErrorBox.Text = car.GetCarData()

        Else
            isCarSelected = False
        End If


    End Sub
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarInventory.ItemCheck

        ' if it is not in edit mode
        If isAddingToListView = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If
    End Sub


    'To reset the application to the default state and user can also use the ESC button of the keyboard to reset  the application.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()

    End Sub

    'This command helps user to close the application by clicking exit button on the screen
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cmbMake_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMake.SelectedIndexChanged

    End Sub
End Class


