Imports System

Module Program
    Sub Main(args As String())
        Dim number As String = "1234"
        Console.WriteLine(CheckDublicates(number))
        Dim ver As String

        Do
            ver = Console.ReadLine()
            For m As Integer = 0 To 3
                For i As Integer = 0 To 3
                    If ver.Chars(m) = number.Chars(i) Then
                        If i = m Then
                            Console.WriteLine("{0} цифра - бык", m + 1)
                        Else
                            Console.WriteLine("{0} цифра - корова", m + 1)
                        End If
                    End If
                Next
            Next
        Loop Until number = ver
    End Sub
    Function CheckDublicates(num As String) As Boolean
        CheckDublicates = False
        For m As Integer = 0 To 2
            For i As Integer = m + 1 To 3
                If num.Chars(m) = num.Chars(i) Then
                    CheckDublicates = True
                End If
            Next
        Next
    End Function
End Module