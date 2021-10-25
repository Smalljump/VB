Imports pares_v03

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim textArray() As Integer = ConvertTo(Int16, TextBox1.Text.Split(","c))
        Dim textArray() As String = TextBox1.Text.Split(","c)
        Dim textArr2(textArray.Length) As Integer

        For x = 0 To textArray.Length - 1
            textArr2(x) = Convert.ToInt32(textArray(x))
        Next

        Dim diferencia As Integer = Convert.ToInt32(TextBox2.Text)

        Label3.Text = ClasePares.Compara(textArr2, diferencia)

    End Sub
End Class
