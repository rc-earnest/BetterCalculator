Option Strict On
Option Explicit On
Option Compare Text
'Rudy Earnest
'RCET 2265
'Spring 2025
'Better Calculator
'https://github.com/rc-earnest/BetterCalculator.git
Imports System.Linq.Expressions

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
            Do
                Console.Write("Choose Number 2: ")
                input = Console.ReadLine()
                If input = "Q" Then
                    Console.WriteLine("You entered ""q""")
                    Console.WriteLine("Have a nice day")
                    Exit Sub
                End If
                Try
                    num2 = CInt(input)
                    Console.WriteLine($"You entered ""{input}"".")
                    Exit Do
                Catch ex As Exception
                    Console.WriteLine($"You entered ""{input}"" please enter a whole number.")
                End Try
            Loop
            Do
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                Console.Write("Choose one of the following options: ")
                input = Console.ReadLine()
                If input = "Q" Then
                    Console.WriteLine("You entered ""q""")
                    Console.WriteLine("Have a nice day")
                    Exit Sub
                End If
                Try
                    operation = CInt(input)
                    If operation >= 1 AndAlso operation <= 4 Then
                        Console.WriteLine("You entered """ & input & """")
                        Exit Do
                    Else
                        Console.WriteLine("You entered """ & input & """")
                    End If
                Catch ex As Exception
                    Console.WriteLine($"You entered ""{input}"" please enter a number corrisponding to one of the options.")
                End Try

            Loop
            Select Case operation
                Case 1
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}")
                Case 2
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}")
                Case 3
                    Console.WriteLine($"{num1} * {num2} = {num1 * num2}")
                Case 4
                    If num2 = 0 Then
                        Console.WriteLine("Cannot divide by zero.")
                    Else
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}")
                    End If

            End Select
        Loop
    End Sub

End Module
