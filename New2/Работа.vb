Imports System
Imports System.Reflection.Metadata

Module Program
    Sub Main(args As String())
        Dim a As Long, b As Long, y As Long, x As Long, e As Long, z As Long, dop As Long, dop1 Integer, dop2 As Long
        e = 2.7182818284
        b = 1.2
        x = 1.5

        e = System.Math.Exp(System.Math.Sin(x))
        a = (b * (x ^ 2)) - x
        dop = absolute(a)
        dop1 = System.Math.Log(dop)
        dop2 = b * (x ^ 3) - dop1

        y = ((b * (x ^ 3)) - System.Math.Log(dop)) / (2 * b)
        z = System.Math.Sqrt(((a * a) + (b * e) + 1) - y)
        Console.WriteLine("z = {0}", z)
    End Sub
    Function absolute(num As Integer)
        If num < 0 Then
            num = (num * (-1))
        End If
    End Function
End Module
