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
        'Console.WriteLine("Please enter the first number: ")
        'Dim num1 As Double = Console.ReadLine()
        'Console.WriteLine("First number: " & num1)
        'Console.WriteLine("Please enter the second number: ")
        'Dim num2 As Double = Console.ReadLine()
        'Console.WriteLine("Second number: " & num2)
        'Dim answer As Double = num1 * num2
        'Console.WriteLine("The numbers multiplied is: " & num1 * num2)
        'Console.ReadLine()

        'Video 13 - If Statement
        'Console.WriteLine("What is your name?")
        'Dim userName As String = Console.ReadLine()
        'Console.WriteLine("What is your password?")
        'Dim password As String = Console.ReadLine()
        'If userName = "Bob" Then
        '    Console.WriteLine("Hi Bob!")
        'End If
        'If password = "burger" Then
        '    Console.WriteLine("You have entered the correct password!")
        'End If
        'Console.ReadLine()

        'Video 14 - Else If and Else
        'Console.WriteLine("What is your name?")
        'Dim userName As String = Console.ReadLine()
        'Console.WriteLine("What is your password?")
        'Dim password As String = Console.ReadLine()
        'If userName = "Bob" Then
        '    Console.WriteLine("Hi Bob!")
        'ElseIf userName = "Tim" Then
        '    Console.WriteLine("Sup Tim?")
        'Else
        '    Console.WriteLine("idk you")
        'End If
        'If password = "burger" Then
        '    Console.WriteLine("Congrats, " & userName & ". You have been granted access.")
        'Else
        '    Console.WriteLine("ACCESS DENIED >>> " & password & " is a dumb password anyway lol")
        'End If
        'Console.ReadLine()

        'Video 15 - Nested If Statements
        'Dim age As Integer = Nothing
        'Dim hasInsurance As Boolean = Nothing
        'Console.WriteLine("What is your age?")
        'age = Console.ReadLine()
        'Console.WriteLine("Do you have insurance? True/False")
        'hasInsurance = Console.ReadLine()
        'If age >= 16 Then
        '    If hasInsurance = True Then
        '        Console.WriteLine("You can drive legally.")
        '    Else
        '        Console.WriteLine("ILLEGAL")
        '    End If
        'Else
        '    Console.WriteLine("You cannot drive.")
        'End If

        'Video 16 - Conditional Operators
        Dim isInKindergarten As Boolean = Nothing
        Dim canDrink As Boolean = Nothing
        Dim isSeniorCitizen As Boolean = Nothing
        Console.WriteLine("What is your age?")
        Dim age As Integer = Console.ReadLine()
        Dim outcomeKindergarten As String = Nothing
        Dim outcomeSenior As String = Nothing
        Dim outcomeDrink As String = Nothing
        If age <> 5 Then
            isInKindergarten = False
            outcomeKindergarten = "You are not in kindergarten."
        Else
            isInKindergarten = True
            outcomeKindergarten = "You are in kindergarten."
        End If
        If age >= 65 Then
            isSeniorCitizen = True
            outcomeSenior = "You are a senior citizen."
        Else
            isSeniorCitizen = False
            outcomeSenior = "You are not a senior citizen."
        End If
        If age >= 21 Then
            canDrink = True
            outcomeDrink = "You can drink."
        Else
            canDrink = False
            outcomeDrink = "You cannot drink."
        End If
        Console.WriteLine(outcomeDrink & " " & outcomeSenior & " " & outcomeKindergarten)
    End Sub
End Module
