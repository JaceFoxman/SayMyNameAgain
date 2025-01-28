'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/JaceFoxman/SayMyNameAgain.git

Option Explicit On


Module SayMyNameAgain

    Sub Main()

        Dim userInput As String

        Do
            Console.Write("Please enter your name: ")
            userInput = Console.Read()

            Select Case userInput

                Case userInput = "Emily"
                    Console.WriteLine($"Welcome, {userInput}")
                Case userInput = "Joe"
                    Console.WriteLine($"Welcome, {userInput}")
                Case userInput = "Jason"
                    Console.WriteLine($"Welcome back Sir.")

            End Select

        Loop Until = "Q"

        Console.WriteLine($"have a nice day, {userInput}")

    End Sub

End Module
