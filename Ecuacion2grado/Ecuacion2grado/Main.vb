Public Class Main
    Private A As Double
    Private B As Double
    Private C As Double
    ESTO ES UN ERROR
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim eq As Ecuation
        Try
            A = Convert.ToDouble(Replace(txtA.Text, ".", ","))
            B = Convert.ToDouble(Replace(txtB.Text, ".", ","))
            C = Convert.ToDouble(Replace(txtC.Text, ".", ","))
            If Not A = 0 Then
                eq = New Ecuation(A, B, C)
                eq.EcuacionSegundoGrado()
            Else
                MessageBox.Show("El valor de A no puede ser 0")
                limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)
        End Try

    End Sub

    Sub limpiar()
        txtA.Text = ""
        txtB.Text = ""
        txtC.Text = ""
        lblr1.Text = ""
        lblr2.Text = ""
        lblResult.Text = ""
    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged

    End Sub
End Class
