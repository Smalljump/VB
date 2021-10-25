Imports System

Module Program
    Sub Main(args As String())

        Dim cadena As String

        Console.WriteLine("Bienvenido. Mi nombre es Sherlock.")
        'Una vez descartado lo imposible, lo que queda, por improbable que parezca, debe ser la verdad.

        Console.Write("Introduzca la cadena a revisar: ")
        cadena = Console.ReadLine()

        Console.WriteLine("...")

        If (revisa(cadena) > (cadena.Length + 1)) Then
            Console.WriteLine("Cadena NO válida")
        Else
            Console.WriteLine("Cadena válida!")
        End If

        Console.WriteLine()

    End Sub

    Function revisa(str As String) As Integer
        Dim caracteres As Integer = 0
        Dim posicion As Integer = 0

        For r = posicion To str.Length - 1
            caracteres += 1
            For s = r + 1 To str.Length - 1
                If str(r) = str(s) Then
                    'Console.WriteLine("Estos son iguales (R({0}): {1}, S({2}): {3})", r, s, str(r), str(s))
                    caracteres += 1
                End If
            Next
        Next

        Return caracteres

    End Function
End Module
