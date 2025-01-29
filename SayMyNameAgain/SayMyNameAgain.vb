'Jason Permann
'Spring 2025
'RCET2265
'Say My Name Again
'https://github.com/JaceFoxman/SayMyNameAgain.git

Option Explicit On
Option Strict On

Module SayMyNameAgain

    Sub Main()

        Dim userInput As String

        Console.Write("Please enter your name: ")
        userInput = Console.ReadLine()

        If userInput = "Emily" Then
            Console.WriteLine("Nice to see you Emily")
        ElseIf userInput = "Joe" Then
            Console.WriteLine("It's good to see you again, Joe")
        ElseIf userInput = "Jason" Then
            Console.WriteLine("Welocome back sir")
        Else
            Console.WriteLine($"Welcome, {userInput}")
        End If

        Console.WriteLine($"Goodbye, {userInput}")
    End Sub

End Module
