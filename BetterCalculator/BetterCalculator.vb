'Rudy Earnest
'RCET 2265
'Spring 2025
'Better Calculator
'
Option Strict On
Option Explicit On
Option Compare Text
Module BetterCalculator

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim operation As Integer
        Dim input As String

        Do
            Console.WriteLine("Please enter two whole numbers. Enter ""Q"" at any time to quit.")

            ' Get first number
            Do
                Console.Write("Choose Number 1: ")
                input = Console.ReadLine()
                If input = "Q" Then
                    Console.WriteLine("You entered ""q""")
                    Console.WriteLine("Have a nice day")
                    Exit Sub
                End If
                Try
                    num1 = CInt(input)
                    Console.WriteLine($"You entered ""{input}"".")
                    Exit Do
                Catch ex As Exception
                    Console.WriteLine($"You entered ""{input}"" please enter a whole number.")
                End Try
            Loop
        Loop
    End Sub

End Module
