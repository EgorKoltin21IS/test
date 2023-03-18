Imports System

Module Program
    Sub Main(args As String())
        Dim sm As Integer, dm As Integer, metr As Integer
        Console.WriteLine("Длина в сантиметрах")
        sm = Console.ReadLine
        metr = sm \ 100
        dm = sm \ 10
        sm = sm Mod 100
        Console.Write("{0}м ", metr)
        Console.WriteLine("{0}см", sm)
        sm = sm Mod 10
        Console.Write("{0}дм ", dm)
        Console.WriteLine("{0}см", sm)
        dm = dm Mod 10
        Console.Write("{0}м ", metr)
        Console.Write("{0}дм ", dm)
        Console.Write("{0}см", sm)
    End Sub
End Module
