Public Class f4_calcu
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim num1, num2, res As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        res = num1 + num2
        txtRes.Text = res
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim num1, num2, res As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        res = num1 - num2
        txtRes.Text = res
    End Sub

    Private Sub BtnDivision_Click(sender As Object, e As EventArgs) Handles BtnDivision.Click
        Dim num1, num2, res As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        res = num1 / num2
        txtRes.Text = res
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        Dim num1, num2, res As Integer
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        res = num1 * num2
        txtRes.Text = res
    End Sub
End Class