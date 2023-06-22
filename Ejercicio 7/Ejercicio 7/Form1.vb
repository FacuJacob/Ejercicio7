Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim vectora(8) As Integer
        Dim vectorb(8) As Integer
        For j = 1 To 8
            vectora(j) = InputBox("Ingrese los valores del vector", "Vector(8)")
        Next
        For j = 1 To 4
            vectorb(j) = vectora(j + 4)
            vectorb(j + 4) = vectora(j)
        Next

        lstVectorA.Items.Clear()
        lstVectorB.Items.Clear()

        For j = 1 To 8
            lstVectorA.Items.Add(vectora(j))
            lstVectorB.Items.Add(vectorb(j))
        Next
    End Sub
End Class
