Imports System

Module Program
    Sub Main(args As String())
        Dim sm As Integer, dm As Integer, metr As Integer
        Console.WriteLine("Длина в сантиметрах")
        sm = Console.ReadLine
        metr = sm \ 100
        dm = sm \ 10
        sm = sm Mod 100
        Console.Write("{0}м {1}см", metr, sm)
        sm = sm Mod 10
        Console.Write("{0}дм {1}см", dm, sm)
        dm = dm Mod 10
        Console.Write("{0}м {1}дм {2}см", metr, dm, sm)
    End Sub
End Module
