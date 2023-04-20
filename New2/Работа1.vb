Imports System
Imports System.Reflection.Metadata

Module Program
    Sub Main(args As String())
        Dim a As Integer, b As Integer, y As Integer, x As Integer, e As Integer, z As Integer, dop As Integer, dop3 As Integer
        Dim dop1 As Integer
        e = 2.7182818284
        b = 1.2
        x = 1.5
        e = System.Math.Exp(System.Math.Sin(x))
        a = (b * (x ^ 2)) - x
        dop = a
        If a < 0 Then
            a = (a * (-1))
        End If
        dop = System.Math.Log(dop)
        dop3 = b * (x ^ 3) - dop
        y = (dop3) / (2 * b)
        z = System.Math.Sqrt(((a * a) + (b * e) + 1) - y)
        Console.WriteLine("z = {0}", z)
    End Sub
End Module
