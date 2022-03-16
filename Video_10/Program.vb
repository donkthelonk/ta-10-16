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
        'Dim userName As String = Nothing
        'Dim age As Integer = Nothing
        'Dim userSalary As Double = Nothing
        'Console.WriteLine("What is your name?")
        'userName = Console.ReadLine()
        'Console.WriteLine("What is your age?")
        'age = Console.ReadLine()
        'Console.WriteLine("What is your salary?")
        'userSalary = Console.ReadLine()
        'Console.Write("Your name is: " & userName)
        'Console.Write("    Your age is: " & age)
        'Console.Write("    Your salary is: " & userSalary)
        'Console.WriteLine()
        'Console.ReadLine()

        'Video 12 - Creating a Basic Calculator
        Console.WriteLine("Please enter the first number: ")
        Dim num1 As Double = Console.ReadLine()
        Console.WriteLine("First number: " & num1)
        Console.WriteLine("Please enter the second number: ")
        Dim num2 As Double = Console.ReadLine()
        Console.WriteLine("Second number: " & num2)
        Dim answer As Double = num1 * num2
        Console.WriteLine("The numbers multiplied is: " & num1 * num2)
        Console.ReadLine()
    End Sub
End Module
