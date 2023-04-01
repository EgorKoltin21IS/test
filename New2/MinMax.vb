Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter 5 numbers")
        Dim input(4) As Integer
        For i = 0 To input.Length - 1
            input(i) = Console.ReadLine
        Next
        Dim n As Integer = Max(input)
        Dim j As Integer = Min(input)
        Console.WriteLine("Input ({0}) = {1}", n, input(n))
        Console.WriteLine("Input ({0}) = {1}", j, input(j))
    End Sub
    Function Max(list As Integer())
        Max = 0
        For i = 0 To list.Length - 1
            If list(i) > list(Max) Then
                Max = i
            End If
        Next
    End Function
    Function Min(list As Integer())
        Min = 0
        For i = 0 To list.Length - 1
            If list(i) < list(Min) Then
                Min = i
            End If
        Next
    End Function
    Sub print(list As Integer())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub
    Sub print(list As String())
        For i = 0 To list.Length - 1
            Console.WriteLine(list(i))
        Next
    End Sub
    Function find(list As Integer(), n As Integer)
        For i = 0 To list.Length - n
            If list(i) = n Then
                find = i
                Exit Function
            End If
        Next
    End Function
End Module
