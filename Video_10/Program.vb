Imports System

Module Program
    Sub Main(args As String())
        'Video 10 - More Math Operators
        'Dim myDouble As Double = 11
        'Console.WriteLine("Initial Value: 11 New Value " & myDouble)
        'myDouble += 23
        'Console.WriteLine("Initial Value: 11 New Value " & myDouble)
        'myDouble *= 126
        'Console.WriteLine("Initial Value: 11 New Value " & myDouble)
        'Console.ReadLine()

        'Video 11 - Getting User Input
        Dim userName As String = Nothing
        Dim age As Integer = Nothing
        Dim userSalary As Double = Nothing
        Console.WriteLine("What is your name?")
        userName = Console.ReadLine()
        Console.WriteLine("What is your age?")
        age = Console.ReadLine()
        Console.WriteLine("What is your salary?")
        userSalary = Console.ReadLine()
        Console.Write("Your name is: " & userName)
        Console.Write("    Your age is: " & age)
        Console.Write("    Your salary is: " & userSalary)
        Console.WriteLine()
        Console.ReadLine()
    End Sub
End Module
