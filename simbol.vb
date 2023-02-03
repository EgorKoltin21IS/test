Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("введите строку")
        Dim s As String
        Dim counter As Integer, sym As Integer, allsym As Integer, gl As Integer, sgl As Integer, number As Integer = 0
        s = Console.ReadLine()
        For i As Integer = 0 To s.Length - 1
            Console.Write(s.Chars(i))
            Console.WriteLine(Asc(s.Chars(i)))
            sym = sym + 1
            Select Case Asc(s.Chars(i))
                Case 32
                    counter = counter + 1
                Case 97 To 122
                    gl = gl + 1
                Case 65 To 90
                    sgl = sgl + 1
                Case 48 To 57
                    allsym = allsym + 1
            End Select

        Next
        Console.WriteLine("В строке {0} пробелов", counter)
        Console.WriteLine("В строке {0} гласных", gl)
        Console.WriteLine("В строке {0} согласных", sgl)
        Console.WriteLine("В строке {0} знаков препинания", allsym)
    End Sub
End Module
