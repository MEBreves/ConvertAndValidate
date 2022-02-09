'Miranda Breves
'RCET0265
'Spring 2022
'Convert and Verify
'url

Option Strict On
Option Explicit On

Module ConvertAndValidate

    Function ConversionValid(ByVal inputString As String, ByRef intendedInteger As Integer) As Boolean

        Dim status As Boolean

        'Attempting to convert the string to the integer value. If it doesn't work, the status is set to false.
        Try
            intendedInteger = CInt(inputString)
            status = True
        Catch ex As Exception
            status = False
        End Try

        'Status is returned back to the function caller.
        Return status

    End Function


    Sub Main()

        'Declaring variables
        Dim aValidNumber As Integer
        Dim userResponse As String
        Dim validNumberFound As Boolean = False

        'Program loops until the user enters a valid number for conversion to Int
        Do Until validNumberFound

            'Getting the input from the user and sending it to the ConversionValid function
            Console.WriteLine($"Enter a number:")
            userResponse = Console.ReadLine()
            validNumberFound = ConversionValid(userResponse, aValidNumber)

            'The status from the ConversionValid function will determine if the user sees a success or a failure
            If validNumberFound Then
                Console.WriteLine($"'{userResponse}' converted successfully to {aValidNumber}!")
            Else
                Console.WriteLine($"Oops, '{userResponse}' does not seem to be a number")
            End If

            'Adding a line break for formatting
            Console.WriteLine()

        Loop

        'Allowing the user to see the successful message before ending the program.
        Console.WriteLine(vbNewLine & "Please press Enter to exit.")
        Console.ReadLine()

    End Sub

End Module
