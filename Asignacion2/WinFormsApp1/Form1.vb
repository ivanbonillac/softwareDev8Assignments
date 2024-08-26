Imports System.Runtime.InteropServices.JavaScript.JSType
Imports System.Windows.Forms.VisualStyles

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaramos las variables como Doubles para trabajar con fracciones y potencias
        Dim y As Double
        Dim q As Double
        Dim resultado As Double
        'Declaramos la constante y asignamos su valor
        Const g As Double = 9.8

        'Realizamos la lectura de los textbox que sirven de inputs
        y = TextBox1.Text
        q = TextBox3.Text

        'Ralizamos la funcion resultado que es la operacion de la ecuacion
        'Enfasis en el juego de parentesis para que se realize de manera apropiada segun el orden de operaciones
        resultado = y + ((q) ^ 2 / (2 * g * (y) ^ 2))

        'automaticamente asigno el valor de la primera Y a la segunda Y en el denominador
        TextBox2.Text = y.ToString()
        'imprimimos el resultado en el text input con 2 decimales
        TextBox4.Text = Math.Round(resultado, 2).ToString("F2")

    End Sub
End Class
