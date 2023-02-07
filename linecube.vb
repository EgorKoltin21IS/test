Imports System
Module Program
    Sub Main(args As String())
        Dim BBod As Integer, dlinastorki As Integer, otstup As Integer, per1 As Integer
        Console.WriteLine("Выбери что нарисовать: строка горизонтально - 1, строка вертикально - 2, куб - 3, выйти из программы - 5")
        BBod = Console.ReadLine()
        Console.WriteLine("Сделать отступ? 1 - да, 2 - нет.")

        otstup = Console.ReadLine()
        If BBod = 1 Then
            Console.WriteLine("выбери длинну строки")
            dlinastorki = Console.ReadLine()
            dlinastorki = dlinastorki - 1
            If otstup = 1 Then
                Console.SetCursorPosition(10, 10)
            End If
            For i As Integer = 0 To dlinastorki
                Console.Write(0)
            Next
        ElseIf BBod = 2 Then
            Console.WriteLine("выбери высоту строки")
            dlinastorki = Console.ReadLine()
            dlinastorki = dlinastorki - 1
            For i As Integer = 0 To dlinastorki
                If otstup = 1 Then
                    Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 1)
                    Console.Write(0)
                Else
                    Console.WriteLine(0)
                End If
            Next
        ElseIf BBod = 3 Then
            Console.WriteLine("выберите длину стороны куба")
            dlinastorki = Console.ReadLine()
            If otstup = 1 Then
                Console.SetCursorPosition(10, 10)
                per1 = 10
            End If
            For i As Integer = 0 To (dlinastorki / 2)
                For u As Integer = 0 To (dlinastorki - 1)
                    Console.Write(0)
                Next
                Console.SetCursorPosition(per1, Console.GetCursorPosition().Top + 1)
            Next
        End If
    End Sub
    Sub cubeprint()
        Console.SetCursorPosition(10, 10)
        For j = 0 To 5
            For i As Integer = 0 To 10
                Console.Write(0)
            Next
            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 1)

        Next
    End Sub
End Module
