Imports System

Module Program
    Dim sec As Integer, Minute As Integer, hours As Integer
    Sub Main(args As String())
        Console.WriteLine("Ведите время в секундах")
        sec = Console.ReadLine()
        hours = sec / 3600
        Minute = (sec Mod 3600) / 60
        sec = sec Mod 60
        Console.Write("{0} часов", hours)
        Console.Write(" {0} минут", Minute)
        Console.Write(" {0} секунд", sec)
    End Sub
End Module