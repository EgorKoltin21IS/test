Imports System

Module Program
    Sub Main(args As String())
        Dim a As Int32, b As Integer
        a = 1
        Console.WriteLine("Привет, я перемножаю числа. Введи числа чтобы перемножить, 1 чтобы прекратить и вывести результат")
        Do Until b = 1

            b = Console.ReadLine()
            If (b * a) <= Int32.MaxValue Then
                a = a * b
            Else
                Console.WriteLine("Ошибка, память переполнена")

            End If
        Loop
        Console.Write("Получилось: ")
        Console.Write(a)
    End Sub
End Module
