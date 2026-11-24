Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstNumber.Clear()
        txtSecondNumber.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add, fn, sn As Integer
        fn = txtFirstNumber.Text
        sn = txtSecondNumber.Text
        add = fn + sn
        txtResults.Text = add

    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        Dim subtract, fn, sn As Integer
        fn = txtFirstNumber.Text
        sn = txtSecondNumber.Text
        subtract = fn - sn
        txtResults.Text = subtract

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles BtnMultiply.Click
        Dim multiply, fn, sn As Integer
        fn = txtFirstNumber.Text
        sn = txtSecondNumber.Text
        multiply = fn * sn
        txtResults.Text = multiply

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim divide, fn, sn As Integer
        fn = txtFirstNumber.Text
        sn = txtSecondNumber.Text
        divide = fn / sn
        txtResults.Text = divide

    End Sub
End Class