Imports System

Module program
    Private brush As Char = "0"c
    Sub Main(args As String())
        Dim u As Integer

        For u = 0 To 5
            Console.WriteLine(" Выбери что нарисовать ")
            Console.WriteLine(" 1 = вертикальная линия,2 = горизонтальная линия,3 =  куб,4 =  поменять цвет, 5 = выбрать параметры ")
            u = Console.ReadLine
            Console.SetWindowSize(100, 50)
            Select Case u
                Case 1

                    Vline(10, 5, 70)
                Case 3

                    FilRect(10, 5, 70, 35)

                Case 2

                    Hline(10, 5, 70)

                Case 4

                    Nova(10, 5, 70, 35)
                Case 6

                    line(10, 5, 70)
                Case 5

                    VIL()
            End Select
            Console.WriteLine()

        Next

    End Sub

    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length
            Console.Write(brush)
        Next

    End Sub
    Sub Vline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To length - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
        Next

    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To heigh - 1
            Hline(leftX, topY + j, width)
        Next

    End Sub
    Sub Nova(leftX As Byte, topY As Byte, width As Byte, heigh As Byte)
        Console.SetCursorPosition(leftX, topY)
        Console.ForegroundColor = ConsoleColor.Green
        For j = 0 To heigh - 1
            Hline(leftX, topY + j, width)
        Next

    End Sub

    Sub line(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To length - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
        Next

    End Sub
    Sub VIL()
        Dim leftx, topY, Length, hight As Byte
        Const brux As Char = "0"c
        Dim f As Char
        Console.Write("высота =")
        hight = Console.ReadLine
        Console.Write("отступ с лева =")
        leftx = Console.ReadLine
        Console.Write("отступ с права =")
        topY = Console.ReadLine
        Console.Write("длина =")
        Length = Console.ReadLine
        f = Console.ReadLine

        Console.SetCursorPosition(10, 60)
        Console.SetWindowSize(100, 50)
        For j = 1 To 10

            For i = 1 To 50
                Console.Write(f)
                Console.SetWindowSize(100, 50)
            Next
            Console.SetCursorPosition(10, 3 + j)
        Next

    End Sub

End Module