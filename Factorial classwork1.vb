Imports System

Module Factorial
    Sub Main(args As String())
        Dim N As Integer, F As Long = 1
        Console.WriteLine("������� ����� �����: N = ")
        N = Console.ReadLine
        For i As Integer = 1 To N
            If False <= Int32.MaxValue / i Then
                F = F * i
            Else
                Console.WriteLine("������������ ������! ������ �������� ��� N = {0}", i - 1)
            End If
        Next
        Console.WriteLine("N! = {0}", F)
    End Sub
End Module
