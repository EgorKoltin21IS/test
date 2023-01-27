Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("введите строку")
        Dim s As String
        Dim counter As Integer, sym As Integer, allsym As Integer, number As Integer = 0
        s = Console.ReadLine()
        For i As Integer = 0 To s.Length - 1
            Console.Write(s.Chars(i))
            Console.WriteLine(Asc(s.Chars(i)))
            sym = sym + 1
            Select Case Asc(s.Chars(i))
                Case 32
                    counter = counter + 1
                Case 0 To 126
                    allsym = allsym + 1
            End Select

        Next
        Console.WriteLine("В строке {0} пробелов", counter)
        Console.WriteLine("В строке {0} символов", allsym)
    End Sub
End Module
