Public Class ClasePares
    Public Function [Compara](sArreglo As Integer(), sDiferencia As Integer) As String
        Dim cumplen As Integer = 0
        Dim letrero As String

        Try

            ' Empezar a comparar por pares
            For r = 0 To sArreglo.Length - 3
                Console.WriteLine("Loop ({0}) : {1}", r, sArreglo(r))
                cumplen += Repetidos(sArreglo, sDiferencia, r)
            Next

            letrero = "Cantidad de pares que cumplen con la diferencia: " & cumplen

        Catch ex As Exception
            letrero = "Error al intentar procesar el arreglo"
        End Try

        Return letrero

    End Function

    Function Repetidos(arr As Integer(), clave As Integer, posicion As Integer) As Integer
        Dim x As Integer = posicion
        Dim qty As Integer = 0

        If (posicion < arr.Length) Then
            While (x < arr.Length - 2)
                x += 1
                If (Math.Abs(arr(posicion) - arr(x)) = clave) Then
                    qty += 1
                End If
                ' Console.WriteLine("[{0}],[{1}] Diferencia: {2}", arr(posicion), arr(x), Math.Abs(arr(posicion) - arr(x)))
            End While
        End If

        Return qty

    End Function

End Class
