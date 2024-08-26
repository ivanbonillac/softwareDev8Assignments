Imports System

Module Program
    Sub Main(args As String())
        Dim a As Double
        Dim b As Double

        Console.WriteLine("#########################################################")
        Console.WriteLine("### Calcular la hipotenusa de un triangulo rectangulo ###")
        Console.WriteLine("#########################################################")
        Console.WriteLine("")

        Console.Write("Ingrese el cateto a: ")
        a = Convert.ToDouble(Console.ReadLine())

        Console.Write("Ingrese el cateto b: ")
        b = Convert.ToDouble(Console.ReadLine())

        'Como sub no retorna valor, no es necesario asignar a ninguna variable
        calcularHipotenusa(a, b)

    End Sub

    Sub calcularHipotenusa(ByVal a As Double, ByVal b As Double)
        ' Calcular la hipotenusa usando el teorema de Pitágoras
        ' Usamos la clase Math y su funcion Sqrt para obtener la raiz cuadrada 
        Console.Write("La hipotenusa es: " & Math.Sqrt((a ^ 2) + (b ^ 2)))
    End Sub
End Module
