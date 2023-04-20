Imports System
Imports System.Runtime.ConstrainedExecution

Module Program
    Sub Main(args As String())
        Dim q, w, dec, sm, ost, metr, ostM, san As Integer
        Dim key As ConsoleKeyInfo
        Do
            Console.ForegroundColor = ConsoleColor.DarkCyan
            Console.WriteLine("1 - дециметр, 2 - сантиметр , 3 - метры")
            w = Console.ReadLine()
            Console.WriteLine("жмай через нескоторое время")
            q = Console.ReadLine()
            Select Case w
                Case 1
                    dec = q \ 10
                    Console.WriteLine("дециметры = {0}", dec)
                Case 2
                    metr = q \ 100
                    ostM = metr * 100
                    sm = q Mod 100
                    dec = sm \ 10
                    san = sm Mod 10
                    Console.WriteLine("метры = {0}", metr)
                    Console.WriteLine("дециметры = {0}", dec)
                    Console.WriteLine("сантиметры = {0}", san)
                Case 3
                    metr = q \ 100
                    Console.WriteLine("метры = {0}", metr)
            End Select
            Console.ForegroundColor = ConsoleColor.Magenta
            Console.WriteLine("если хочешь повторит) жми y , а если не понравилось, то жмай no ")
            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
        Loop Until key.KeyChar = "n"c
    End Sub

End Module