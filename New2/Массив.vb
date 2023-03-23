Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Введите 5 чисел")
        Dim input(4) As Integer, output(5) As Integer
        For i = 0 To 4
            input(i) = Console.ReadLine
        Next
        print1(input)
        'Dim strings(4) As String
        'For i = 0 To 4
        '    strings(i) = Console.ReadLine
        'Next
        'print1(strings)
        py(input, output)
    End Sub
    Sub print1(list As Integer())
        Console.Clear()
        For i = list.Length - 1 To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
    Sub print1(list As String())
        Console.Clear()
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub
    Function py(massiv1 As Integer(), massiv2() As Integer)
        Dim number As Integer, i2 As Byte = 0
        Console.WriteLine("Поиск числа в массиве")
        number = Console.ReadLine()
        For i = 0 To massiv1.Length - 1
            If massiv1(i) = number Then
                massiv2(i2) = i + 1
                i2 = i2 + 1
            End If
        Next
        If i2 > 0 Then
            Console.Write("Совпадения в строчках: ")
            For i3 = 0 To i2 - 1
                Console.Write("{0}, ", massiv2(i3))
            Next
        Else
            Console.WriteLine("Совпадения не найдены")
        End If
    End Function
End Module
