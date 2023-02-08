Imports System
Imports System.Reflection.Metadata
Imports System.Security.Cryptography.X509Certificates

Module Program
    Private brush As Char = "0"c
    Dim num01 As Byte
    Sub Main(args As String())
        Console.WriteLine("1 - гор. линия, 2 - верт. линия, 3 - закр. куб, 4 - пуст. куб")
        num01 = Console.ReadLine
        Select Case num01
            Case 1
                hline(5, 5, 15)
            Case 2
                vline(5, 5, 15)
            Case 3
                filrect(5, 5, 50, 25)
            Case 4
                pustcub(10, 10, 20, 10)
        End Select
    End Sub
    Sub hline(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To length
            Console.Write(brush)
        Next
    End Sub
    Sub vline(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To length
            Console.Write(brush)
            Console.SetCursorPosition(leftx, topy + i)
        Next
    End Sub
    Sub filrect(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)
        For j = 1 To height
            For i = 1 To width
                Console.Write(brush)
            Next
            Console.SetCursorPosition(leftx, topy + j)
        Next
    End Sub
    Sub pustcub(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 1 To width
            Console.Write(brush)
        Next
        For j = 1 To height - 3
            Console.SetCursorPosition(leftx, topy + j)
            Console.Write(brush)
            Console.SetCursorPosition(leftx + width - 1, topy + j)
            Console.WriteLine(brush)
        Next
        Console.SetCursorPosition(leftx, topy + height - 2)
        For i = 1 To width
            Console.Write(brush)
        Next
    End Sub
End Module
