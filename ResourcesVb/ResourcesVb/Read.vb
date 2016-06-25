Imports System.Globalization
Imports System.Reflection
Imports System.Resources

Public NotInheritable Class Read

    Public Shared Function FromResource(key As String, culture As CultureInfo)
        Dim rm As ResourceManager = New ResourceManager("ResourcesVb.Resource", Assembly.GetExecutingAssembly())
        Return rm.GetString(key, culture)
    End Function

End Class
