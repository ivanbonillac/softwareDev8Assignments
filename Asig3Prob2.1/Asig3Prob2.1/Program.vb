Imports System

Module Program
    Sub Main(args As String())
        Dim a As Double
        Dim b As Double
        Dim promedio As Double

        Console.WriteLine("#########################################")
        Console.WriteLine("### Calcular el promedio de 2 numeros ###")
        Console.WriteLine("#########################################")
        Console.WriteLine("")

        Console.Write("Ingrese el primer número: ")
        a = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el segundo número: ")
        b = Convert.ToDouble(Console.ReadLine())

        'Se llama a la funcion y se envian los 2 parametros
        promedio = CalcularPromedio(a, b)

        'Recibimos el return de la funcion asignado a la variable promedio
        Console.WriteLine("El promedio de " & a & " y " & b & " es: " & promedio)
    End Sub

    Public Function CalcularPromedio(ByVal a As Double, ByVal b As Double) As Double
        'Retornamos el promedio de dos numeros
        Return (a + b) / 2
    End Function
End Module
