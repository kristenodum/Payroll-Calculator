Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPay.Clear()
        lblTotalCost.Text = ""
        txtPay.Focus()
    End Sub


    Private Sub btnComputeTax_Click(sender As Object, e As EventArgs) Handles btnComputeTax.Click

        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Const _cdecFica As Decimal = 0.0765D
        Const _cdecFed As Decimal = 0.22D
        Const _cdecState As Decimal = 0.0765D

        strIncome = txtPay.Text
        decIncome = Convert.ToInt32(txtPay)
        decNet = decFica * _cdecState
        lblTotalCost.Text = decNet.ToString("C")

        lblTotalCost.Visible = True
    End Sub
End Class
