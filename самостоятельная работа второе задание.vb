Imports System

Module Program
    Sub Main(args As String())
        Dim a, x, b, y As Double
        x = 0.07
        b = 8.91
        a = 13.7
        If Math.Sqrt(a - b) < x Then
            y = a * Math.Pow(x, 3) + b * Math.Log(2 * x)
        Else
            If Math.Sqrt(a - b) = x Then
                y = Math.Sqrt(Math.Abs(a + Math.Sin(2 * x)))
            Else
                If Math.Sqrt(a - b) > x Then
                    y = Math.Atan(5 * x) - b * Math.Pow(Math.Cos(x), 3)
                Else
                End If
            End If
        End If
        Console.WriteLine(y)
    End Sub
End Module
