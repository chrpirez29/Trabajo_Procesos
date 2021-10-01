Public Class Ecuation
    'ATTRIBUTES
    Private A As Double
    Private B As Double
    Private C As Double

    'BUILDER
    Sub New(ByVal A As Double, ByVal B As Double, ByVal C As Double)
        Me.A = A
        Me.B = B
        Me.C = C
    End Sub


    Public Sub EcuacionSegundoGrado()
        Dim r As Double
        r = B ^ 2 - 4 * A * C

        Select Case r
            Case Is > 0
                Main.lblr1.Text = Math.Round(Convert.ToDouble((-1 * B + Math.Sqrt(r)) / (2 * A)), 2)
                Main.lblr2.Text = Math.Round(Convert.ToDouble((-1 * B - Math.Sqrt(r)) / (2 * A)), 2)
                Main.lblResult.Text = "2 soluciones reales"
                Main.lblResult.ForeColor = Color.Blue
                Main.lblr1.ForeColor = Color.Blue
                Main.lblr2.ForeColor = Color.Blue
            Case Is = 0
                Main.lblr1.Text = " " & (-B / (2 * A))
                Main.lblResult.Text = "1 solucion real"
                Main.lblResult.ForeColor = Color.Blue
                Main.lblr1.ForeColor = Color.Blue
            Case Is < 0
                Main.lblr1.Text = -B / 2 * A & "+" & Math.Round(Math.Sqrt(r * -1) / (2 * A), 2) & "i"
                Main.lblr2.Text = -B / 2 * A & "-" & Math.Round(Math.Sqrt(r * -1) / (2 * A), 2) & "i"
                Main.lblResult.Text = "2 soluciones imaginarias"
                Main.lblResult.ForeColor = Color.Red
                Main.lblr1.ForeColor = Color.Red
                Main.lblr2.ForeColor = Color.Red
        End Select
    End Sub

End Class
