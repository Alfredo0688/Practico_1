Module Variables

    Public nombre_persona As String = "Ricardo" 'a nivel solucion
    Friend tipo_documento As String = "DNI" 'a nivel proyecto
    Friend numero_documento As String = "30222555"
    Friend fecha_nacimiento As Date = #11/25/1980#
    Private localidad As String = "Rosario" ' a nivel modulo o clase
    Private altura As Single = 1.85
    Private estado_civil As String = "Viudo"
    Private argentino As String = "si"

    Sub Main()
        Dim edad As Byte = 37 'byte sin signo de 0 a 255

        Console.WriteLine("Nombre: " & nombre_persona)
        Console.WriteLine("Tipo de documento: " & tipo_documento)
        Console.WriteLine("Numero de documento: " & numero_documento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de nacimiento" & fecha_nacimiento)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura corporal: " & altura)
        Console.WriteLine("Estado civil: " & estado_civil)
        Console.WriteLine("Argentino?: " & argentino)
        Console.ReadKey()

    End Sub

End Module
