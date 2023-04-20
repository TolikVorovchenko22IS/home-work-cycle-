Imports System
Module Program
    Sub Main(args As String())

        Dim q, w, e, r, t, y As Double
        q = 1.5
        w = 0.7
        e = 2
        r = (MathF.Pow(MathF.E, q) - MathF.Cos(w)) / MathF.Sqrt(MathF.Abs(q * w * e))

        Console.WriteLine(r)
        y = (MathF.Log(q)) - w * e
        Console.WriteLine(y)
        e = MathF.Sin(r * y) + 2
        Console.WriteLine(e)

    End Sub

End Module
