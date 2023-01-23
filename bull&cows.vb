Imports System

Module Program
    Sub Main(args As String())
        Dim number As String = "1234"
        Console.WriteLine("Угадай число")
        Dim ver As String

        Do
            ver = Console.ReadLine()

            For i As Integer = 0 To 3
                If ver.Chars(0) = number.Chars(1) Then
                    If 0 = 1 Then
                        Console.WriteLine("Первая цифра вашей версии - бык")
                    Else
                        Console.WriteLine("первая цифра вашей версии - корова")

                    End If
                End If
            Next
            If number = ver Then
                Console.WriteLine("Угадал!")
            Else
                Console.WriteLine("ошибка")

            End If

        Loop Until number = ver
    End Sub
End Module
