'Imports System
Imports Serilog

'Do a dotnet add package on the following:
'Imports Microsoft.Extensions.Logging  (optional)
    'Imports Serilog.Events
    'Imports Serilog.Sinks.SystemConsole



Module Program
    Sub Main(args As String())
        Log.Logger = New LoggerConfiguration().WriteTo.Console().WriteTo.File("logs\myapp.log").CreateLogger()

        Log.Information("This is an informational message")

        Try
            Throw New Exception("This is an example exception")
        Catch ex As Exception
            Log.Error(ex, "Throwing an intentional error")
        End Try

        Log.CloseAndFlush()

    End Sub
End Module
