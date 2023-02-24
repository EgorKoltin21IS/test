Imports System
Imports System.Reflection.Metadata.Ecma335

Module Program
    Dim ver As String
    Sub Main(args As String())
        Dim number As String = "1234"
        Do
            ver = Console.ReadLine()
            If checksymbol() = False Then
                Console.WriteLine("Необходимо вводить только числа.")
            Else
                If checkdub() = False Then
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
                Else
                    Console.WriteLine("Символы повторяются. Нужно ввести 4 разных цифры.")
                End If
            End If
        Loop Until number = ver
    End Sub
    Function checkdub() As Boolean
        checkdub = False
        For i2 = 0 To 3
            For i3 = 0 To 3
                If i2 <> i3 And ver.Chars(i2) = ver.Chars(i3) Then
                    checkdub = True
                End If
            Next
        Next
    End Function
    Function checksymbol() As Boolean
        checksymbol = True
        If ver.Length = 4 Then
            For i1 = 0 To 3
                Select Case Asc(ver.Chars(i1))
                    Case 0 To 45
                        checksymbol = False
                    Case 58 To 255
                        checksymbol = False
                End Select
            Next
        Else
            Console.WriteLine("Вы указали меньше или больше 4 цифр. Введите 4х значное число.")
            checksymbol = False
        End If
    End Function
End Module