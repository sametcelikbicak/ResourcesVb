Imports System.Globalization

Module Program

    Sub Main()

        Dim cultureTR As CultureInfo = New CultureInfo(Culture.trTR())
        Dim cultureUS As CultureInfo = New CultureInfo(Culture.enUS())
        Dim cultureFR As CultureInfo = New CultureInfo(Culture.frFR())

        Console.WriteLine("Read resources from Resource.resx with Culture")
        Console.WriteLine("HelloWorld with " + cultureTR.Name + " : " + Read.FromResource("HelloWorld", cultureTR))
        Console.WriteLine("HelloWorld with " + cultureUS.Name + " : " + Read.FromResource("HelloWorld", cultureUS))
        Console.WriteLine("HelloWorld with " + cultureFR.Name + " : " + Read.FromResource("HelloWorld", cultureFR))

        Console.ReadKey()

    End Sub

End Module
