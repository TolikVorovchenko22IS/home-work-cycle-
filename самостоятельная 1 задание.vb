Imports System
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions

Module Program
    Sub main(args As String())
        Console.WriteLine(Mat)
    End Sub
    Function Mat() As Double
        Dim a, b, t, x, e, d, y As Double
        x = 1.38
        Mat = 0
        d = 4
        t = 3
        a = Math.Sin(t) * 2.3
        b = 17.6 * Math.Pow(x, 3)
        y = Math.Pow(Math.E, -a * t) * (t + (Math.Sqrt(Math.Abs(t + a)))) / t - Math.Sqrt(Math.Abs(d * t - b))

    End Function
End Module
