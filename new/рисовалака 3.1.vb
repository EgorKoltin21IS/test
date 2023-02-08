Imports System
Imports System.Reflection.Metadata
Imports System.Security.Cryptography.X509Certificates

Module Program
    Private brush As Char = "0"c
    Dim num01 As Byte, num03 As Byte
    Dim num02 As Integer, x As Integer, y As Integer, x1 As Integer, y1 As Integer
    Sub Main(args As String())
        Console.WriteLine("1 - ���. �����, 2 - ����. �����, 3 - ����. ���, 4 - ����. ���, 5 - �����, 6 - ����� (����.), 7 - �������")
        num01 = Console.ReadLine
        Console.WriteLine("������ ������ ���� ������ ��� ����������? 1 - ��, 2 - ���.")
        num03 = Console.ReadLine()
        uslovie1()
        Select Case num01
            Case 1
                If num03 = 1 Then
                    hline(x, y, x1)
                Else
                    hline(5, 5, 15)
                End If
            Case 2
                If num03 = 1 Then
                    vline(x, y, x1)
                Else
                    vline(5, 5, 15)
                End If
            Case 3
                If num03 = 1 Then
                    filrect(x, y, x1, y1)
                Else
                    filrect(5, 5, 50, 25)
                End If
            Case 4
                If num03 = 1 Then
                    pustcub(x, y, x1, y1)
                Else
                    pustcub(10, 10, 20, 10)
                End If
            Case 5
                If num03 = 1 Then
                    setka(x, y, x1, y1)
                Else
                    setka(7, 7, 50, 7)
                End If
            Case 6
                Console.ForegroundColor = ConsoleColor.Green
                Console.BackgroundColor = ConsoleColor.Blue
                If num03 = 1 Then
                    setka(x, y, x1, y1)
                Else
                    setka(7, 7, 50, 7)
                End If

            Case 7
                If num03 = 1 Then
                    lesenka(x, y, x1)
                Else
                    lesenka(8, 4, 20)
                End If

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
    Sub setka(leftx As Byte, topy As Byte, width As Integer, kletki As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 2 To width
            Console.Write(brush)
        Next
        For j = 1 To kletki
            num02 = Console.GetCursorPosition.Top
            For m1 = 1 To 4
                Console.SetCursorPosition(leftx, num02 + m1)
                For m2 = 1 To width / 10
                    Console.Write(brush)
                    Console.SetCursorPosition(Console.GetCursorPosition.Left + 11, Console.GetCursorPosition.Top)
                Next
            Next
            Console.SetCursorPosition(leftx, num02 + 5)
            For i = 2 To width
                Console.Write(brush)
            Next
        Next
    End Sub
    Sub lesenka(leftx As Byte, topy As Byte, height As Integer)
        Console.SetCursorPosition(leftx, topy)
        For i = 0 To height - 1
            Console.SetCursorPosition(leftx, topy + i)
            For j = 1 To i * 2
                Console.Write(brush)
            Next
        Next
    End Sub
    Sub uslovie1()
        If num03 = 1 Then
            Console.Write("������ ����� = ")
            x = Console.ReadLine()
            Console.Write("������ ������ = ")
            y = Console.ReadLine()
            Console.Write("����� = ")
            x1 = Console.ReadLine()
            If num01 = 3 Or num01 = 4 Then
                Console.Write("������ = ")
                y1 = Console.ReadLine()
            End If
            If num01 = 5 Or num01 = 6 Then
                Console.Write("������ �� ��������� = ")
                y1 = Console.ReadLine()
            End If
        End If
    End Sub
End Module