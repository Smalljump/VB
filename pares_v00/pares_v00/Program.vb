Imports System

Module Program
    Sub Main(args As String())

        Dim longitud As Integer
        Dim diferencia As Integer
        Dim r As Integer
        Dim arreglo As Integer()
        Dim cumplen As Integer = 0

        Console.Write("Longitud del arreglo: ")
        longitud = Console.ReadLine()

        Console.Write("Diferencia a buscar: ")
        diferencia = Console.ReadLine()

        r = 1
        ReDim arreglo(longitud)

        ' Llenar arreglo
        While (r <= longitud)
            Console.Write($"Elemento {r}: ")
            arreglo(r - 1) = Console.ReadLine()
            r += 1
        End While

        ' Empezar a comparar por pares
        For r = 0 To arreglo.Length - 1
            cumplen += repetidos(arreglo, diferencia, r)
        Next

        Console.WriteLine("Cantidad de pares que cumplen con la diferencia: {0}", cumplen)

    End Sub

    Function repetidos(arr As Integer(), clave As Integer, posicion As Integer) As Integer
        Dim x As Integer = posicion
        Dim qty As Integer = 0
        Dim valor As Integer = 0

        While (x < arr.Length - 2)
            x += 1
            If (Math.Abs(arr(posicion) - arr(x)) = clave) Then
                qty += 1
            End If
            'Console.WriteLine("[{0}],[{1}] Diferencia: {2}", arr(posicion), arr(x), Math.Abs(arr(posicion) - arr(x)))
        End While

        Return qty

    End Function

End Module
