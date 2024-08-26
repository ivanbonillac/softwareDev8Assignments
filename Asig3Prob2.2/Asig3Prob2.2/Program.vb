Imports System

Module Program
    Sub Main(args As String())
        'Declaracion de Variables
        Dim nombre As String
        Dim apellido As String
        Dim cadena As String

        Console.WriteLine("####################################")
        Console.WriteLine("### Concatenar nombre y apellido ###")
        Console.WriteLine("####################################")
        Console.WriteLine("")

        Console.Write("Ingrese el nombre: ")
        nombre = Console.ReadLine()

        Console.Write("Ingrese el apellido: ")
        apellido = Console.ReadLine()

        'Enviamos parametros a la funcion
        cadena = Concatenar(nombre, apellido)

        'Recibimos el return de la funcion asignado a la variable cadena
        Console.WriteLine("Resultado de concatenar " & nombre & " y " & apellido & " es: " & cadena)

    End Sub

    Public Function Concatenar(ByVal nombre As String, ByVal apellido As String) As String
        'Retornamos una sola cadena con el nombre espacio apellido
        Return (nombre + " " + apellido)
    End Function
End Module
