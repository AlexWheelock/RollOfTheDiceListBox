'Alex Wheelock
'RCET 0265
'Roll of The Dice - List Box
'Spring 2024
'https://github.com/AlexWheelock/RollOfTheDiceListBox.git

Option Strict On
Option Explicit On
Public Class RollOfTheDiceListBox

    Sub Roll()

        'Dimming a variable for each potential result to put into outputArray() later
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

        Dim returnedValue As Integer
        Dim header() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"}

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

        '(Lines 69-81): Puts together the formatting for the output display
        'Console.WriteLine(StrDup(21, " ") & "Roll of The Dice")
        'Console.WriteLine(StrDup(55, "-"))

        Dim headerRow As String = ""

        For Each letter In header

            'If headerRow = "" Then
            headerRow += (CStr(letter) & " |").PadLeft(5)
            'Else
            '    (letter.PadLeft(4).PadRight(4) & "|")
            'End If
        Next

        'Console.WriteLine()
        'Console.WriteLine(StrDup(55, "-"))

        Dim dataRow As String = ""
        For Each number In outputArray
            ' Console.Write(CStr(number).PadLeft(4).PadRight(4) & "|")
            dataRow += (CStr(number).PadLeft(5) & "|")
        Next

        DisplayListBox.Items.Add(StrDup(21, " ") & "Roll of The Dice")
        DisplayListBox.Items.Add(StrDup(55, "-"))
        DisplayListBox.Items.Add(headerRow)
        DisplayListBox.Items.Add(StrDup(55, "-"))
        DisplayListBox.Items.Add(dataRow)
        DisplayListBox.Items.Add(StrDup(55, "-"))

    End Sub

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


    'Event handlers below this point

    'Listbox used as the output to display the rolled values
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

    End Sub

    'Button used to clear the OutputDisplayListBox, then call the Roll() sub to fill it out again
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        DisplayListBox.Items.Clear()
        Roll()
    End Sub

    'Button used to clear the output display
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayListBox.Items.Clear()
    End Sub

    'Button used to exit the form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
