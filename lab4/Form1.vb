'''''''''''''''''''''''''
'Name: - Rut Patel 
'SID: - 100774814
'Date: - 18/07/2020
'Description: - Making a car Inventroy form using the class.
'References: - Student List ,Austin Garrod
''
'''''''''''''''''''''''''''

Option Strict On

Public Class frmCarInventory
    'Declaring variables and constant
#Region "Variables and Constant"

    Dim cars As New List(Of Car)

    Dim currentlySelectedIndex As Integer = -1
    Dim editmode As Boolean = False
    Dim counter As Integer = 0
    Dim errorMessage As String = ""

#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' This event is fired when user hits enter button.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Declaring variables for this section.
        Dim inputMake As String = cbMake.Text
        Dim inputModel As String = txtModel.Text
        Dim inputYear As String = numYear.Text
        Dim inputPrice As String = txtPrice.Text
        Dim inputStatus As Boolean = ckCondition.Checked

        Dim car As Car

        Dim validation As Boolean = Validate(inputMake, inputModel, inputPrice)

        'Calling the validate function and checking the data if the data is valid.
        If (validation = True) Then

            'This takes place when user selects the existing data
            If (editmode) Then
                cars(currentlySelectedIndex).Make = inputMake
                cars(currentlySelectedIndex).Model = inputModel
                cars(currentlySelectedIndex).Year = CInt(inputYear)
                cars(currentlySelectedIndex).Price = CDec(inputPrice)
                cars(currentlySelectedIndex).NewStatus = inputStatus

                UpdateCardetails()
                ResetForm()

            Else
                'This allows the user to add new data to the list.
                car = New Car(inputMake, inputModel, CInt(inputYear), CDec(inputPrice), inputStatus)
                cars.Add(car)
                counter += 1
                ResetForm()
                UpdateCardetails()
                txtOutput.Text = "Car Added to records"
            End If
        Else
            'Displays error message
            txtOutput.Text = errorMessage
        End If

    End Sub
    ''' <summary>
    ''' This event takes place when the user hits reset button and the form gets reseted.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()

    End Sub
    ''' <summary>
    ''' When the user hits exit button, this event handler exits the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    ''' <summary>
    ''' This event is fired when user selects the row in the listview.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvCarDisplay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvCarDisplay.SelectedIndexChanged
        Dim car As Car
        If (Not lvCarDisplay.FocusedItem Is Nothing) Then
            currentlySelectedIndex = lvCarDisplay.FocusedItem.Index
            car = cars(currentlySelectedIndex)

            editmode = True

            txtModel.Text = car.Model
            txtPrice.Text = CStr(car.Price)
            numYear.Value = car.Year
            ckCondition.Checked = car.NewStatus
            cbMake.Text = car.Make
            txtOutput.Text = "Loaded data from student to update "
        End If

    End Sub
#End Region

#Region "Function & Methods"
    ''' <summary>
    ''' Function that is used for validating values.
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="price"></param>
    ''' <returns></returns>
    Function Validate(make As String, model As String, price As String) As Boolean

        Dim validPrice As Decimal = 0

        If (make = "") Then
            errorMessage += "Please select the manufacturer of the car."
            Return False
        End If
        If (model = "") Then
            errorMessage += "Please enter model of the car."
            Return False
        End If

        If (Decimal.TryParse(price, validPrice)) Then
            If (validPrice > 0) Then
                Return True
            Else
                errorMessage += "Please enter positive price."
                Return False
            End If
        Else
            errorMessage += "Please enter valid price."
            Return False
        End If


    End Function
    ''' <summary>
    ''' Method which updates the user values in the list box.
    ''' </summary>
    Private Sub UpdateCardetails()
        Dim carlist As ListViewItem

        lvCarDisplay.Items.Clear()

        For Each car As Car In cars
            carlist = New ListViewItem()

            carlist.Checked = car.NewStatus
            carlist.SubItems.Add(CStr(car.Count))
            carlist.SubItems.Add(car.Make)
            carlist.SubItems.Add(car.Model)
            carlist.SubItems.Add(CStr(car.Year))
            carlist.SubItems.Add("$ " & CStr(car.Price))
            lvCarDisplay.Items.Add(carlist)
        Next
    End Sub
    ''' <summary>
    ''' Method that reset the values from the form.
    ''' </summary>
    Private Sub ResetForm()

        lvCarDisplay.SelectedIndices.Clear()

        txtModel.Text = ""
        txtPrice.Text = ""
        txtOutput.Text = ""
        ckCondition.Checked = False
        editmode = False
        cbMake.SelectedIndex = -1
        numYear.Value = 2020
        txtOutput.Text = "Reset Form"
        errorMessage = ""

    End Sub



#End Region
End Class
