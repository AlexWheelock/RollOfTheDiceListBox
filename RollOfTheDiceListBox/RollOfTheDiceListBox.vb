'Alex Wheelock
'RCET 0265
'Roll of The Dice - List Box
'Spring 2024
'https://github.com/AlexWheelock/RollOfTheDiceListBox.git

Option Strict On
Option Explicit On
Public Class RollOfTheDiceListBox

    Sub Roll()

        'Dims a variable for each potential result to put into outputArray() later
        Dim two As Integer
        Dim three As Integer
        Dim four As Integer
        Dim five As Integer
        Dim six As Integer
        Dim seven As Integer
        Dim eight As Integer
        Dim nine As Integer
        Dim ten As Integer
        Dim eleven As Integer
        Dim twelve As Integer

        'Variables for the rolled number, and the array for the header display
        Dim returnedValue As Integer
        Dim header() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}
        Dim headerRow As String = ""
        Dim dataRow As String = ""

        'Rolls the set of die 1000 times
        For rolls = 0 To 999

            'Sends the execution to the RollTheDice() function
            'Sets returnedValue to the value returned from function
            returnedValue = RollTheDice()

            'Determines the value of rolled number, and which case it falls into,
            'Adds 1 to the number of times that number has already come up
            Select Case returnedValue
                Case = 2
                    two += 1
                Case = 3
                    three += 1
                Case = 4
                    four += 1
                Case = 5
                    five += 1
                Case = 6
                    six += 1
                Case = 7
                    seven += 1
                Case = 8
                    eight += 1
                Case = 9
                    nine += 1
                Case = 10
                    ten += 1
                Case = 11
                    eleven += 1
                Case = 12
                    twelve += 1
                Case Else
            End Select
        Next

        'Organizes the numbered variables, and the number of times that they were rolled into an array
        Dim outputArray() = {two, three, four, five, six, seven, eight, nine, ten, eleven, twelve}

        'Converts the header array into a string
        For Each letter In header
            headerRow += (CStr(letter) & "|").PadLeft(6)
        Next

        'Converts the outputArray into a string
        For Each number In outputArray
            dataRow += (CStr(number).PadLeft(5) & "|")
        Next

        'Formats the items in the DisplayListBox
        DisplayListBox.Items.Add(StrDup(25, " ") & "Roll of The Dice")
        DisplayListBox.Items.Add(StrDup(66, "-"))
        DisplayListBox.Items.Add(headerRow)
        DisplayListBox.Items.Add(StrDup(66, "-"))
        DisplayListBox.Items.Add(dataRow)
        DisplayListBox.Items.Add(StrDup(66, "-"))

    End Sub

    'Function used to roll two die
    'Takes two random integers from 1 to 6 and adds the two together, returns the sum.
    Function RollTheDice() As Integer

        Dim rolledNumber1 As Integer
        Dim rolledNumber2 As Integer
        Dim rolledTotal As Integer

        'Rolls each dice one time as a random number, then adds the two numbers together
        Randomize()
        rolledNumber1 = (CInt(Math.Floor(CDbl(Rnd() * 6) + 1)))
        rolledNumber2 = (CInt(Math.Floor(CDbl(Rnd() * 6) + 1)))
        rolledTotal = rolledNumber1 + rolledNumber2

        'Returns the sum of the two randomly rolled die values
        Return rolledTotal
    End Function

    'Displays a message box with the form information when the "About" button is pressed.
    Sub AboutMessage()
        MsgBox("This form is used to simulate the rolling of two die." & vbCrLf _
            & vbCrLf _
               & "The numbers of the two die are then added together and the resulting number is then tracked. Pressing the " & Chr(34) & "Roll" & Chr(34) & " button will roll the die 1000 times and tally the results. The " & Chr(34) & "Clear" & Chr(34) & " button will clear the display. And the " & Chr(34) & "Exit" & Chr(34) & " button will close the form.")
    End Sub


    'Event handlers below this point

    'Listbox used as the output to display the rolled values
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

    End Sub

    'Button used to clear the OutputDisplayListBox, then call the Roll() sub to fill it out again
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        DisplayListBox.Items.Clear()
        Roll()
    End Sub

    'Button used to clear the output display in the DisplayListBox
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub

    'Button used to exit the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'The "About" button in the "Help" drop down menu in the TopMenuStrip.
    'Pops up a MsgBox that tells the user what the form does.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutMessage()
    End Sub

    'Drop down button in the TopMenuStrip, contains the "Roll", "Clear", and "Exit" TopMenuItems
    Private Sub MenuTopMenuItem_Click(sender As Object, e As EventArgs) Handles MenuTopMenuItem.Click

    End Sub

    'The roll button hidden in the "Menu" drop down on top of the form.
    'rolls the die 1000 times and displays the results in the DisplayListBox
    Private Sub RollTopMenuItem_Click(sender As Object, e As EventArgs) Handles RollTopMenuItem.Click
        DisplayListBox.Items.Clear()
        Roll()
    End Sub

    'The clear button hidden in the "Menu" drop down on top of the form.
    'clears the display shown in the DisplayListBox when pressed
    Private Sub ClearTopMenuItem_Click(sender As Object, e As EventArgs) Handles ClearTopMenuItem.Click
        DisplayListBox.Items.Clear()
    End Sub

    'The exit button hidden in the "Menu" drop down on top of the form.
    'closes the form when pressed
    Private Sub ExitTopMenuItem_Click(sender As Object, e As EventArgs) Handles ExitTopMenuItem.Click
        Me.Close()
    End Sub

    'Help button shown on top of form, contains the "About" button
    Private Sub HelpTopMenuItem_Click(sender As Object, e As EventArgs) Handles HelpTopMenuItem.Click

    End Sub

    'Context menu, contains the roll and clear buttons below
    Private Sub MainContextMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MainContextMenuStrip.Opening

    End Sub

    'Roll button that appears in the context menu. Clears the DisplayListBox, then rolls the die 1000 times,
    'updates DisplayListBox with new results
    Private Sub RunContextMenuItem_Click(sender As Object, e As EventArgs) Handles RollContextMenuItem.Click
        DisplayListBox.Items.Clear()
        Roll()
    End Sub

    'Clear button that appears in the context menu. Clears the display when pressed.
    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        DisplayListBox.Items.Clear()
    End Sub
End Class
