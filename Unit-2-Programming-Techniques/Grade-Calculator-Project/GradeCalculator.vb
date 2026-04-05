' QUESTION: Write a program that asks for a user's test score (out of 100).
' The program should output "Grade 9" if the score is 80+, 
' "Grade 7" if 70+, and "Grade 4" if 40+.
' Created by: Jaya
' ---------------------------------------------------------

Module Module1
    Sub Main()
        Dim score As Integer
        
        Console.WriteLine("Enter your Computer Science Mock Score:")
        score = Console.ReadLine()

        If score >= 80 Then
            Console.WriteLine("Grade 9: Exceptional Achievement!")
        ElseIf score >= 70 Then
            Console.WriteLine("Grade 7: Strong Pass!")
        ElseIf score >= 40 Then
            Console.WriteLine("Grade 4: Standard Pass!")
        Else
            Console.WriteLine("Keep practicing!")
        End If

        Console.ReadLine() 
    End Sub
End Module
