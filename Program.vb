Imports System

Module HWcycle
    Sub Main(args As String())
        Dim a, p, n As Integer
        Const max As Integer = 2147483647
        p = 1
        Console.WriteLine(" ������� ���������� �������� ����� ")
        n = (Console.ReadLine())
        For i = 1 To n
            If p < max / a Then
                Console.WriteLine(" ������� ����� ")
                a = (Console.ReadLine())
                p = p * a
            Else
                Console.Write(" ������ ����������� !!!")
                Console.WriteLine(a - 1)
            End If
        Next
        Console.WriteLine(" ������������ N ��������� ���� ����� ����� ")
        Console.WriteLine(p)
    End Sub
End Module
