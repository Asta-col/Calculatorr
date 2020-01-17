Public Class Calculator

    Dim Firstnum As Decimal
    Dim Secondnum As Decimal
    Dim Operations As Integer
    Dim OpSelector As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Num0.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        Else
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Num1.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Num3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Num2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Op1.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        OpSelector = True
        Operations = 1
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Num7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Num9.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Num8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Op3.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        OpSelector = True
        Operations = 3
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Num4_Click(sender As Object, e As EventArgs) Handles Num4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Num5_Click(sender As Object, e As EventArgs) Handles Num5.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Num6_Click(sender As Object, e As EventArgs) Handles Num6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Op2_Click(sender As Object, e As EventArgs) Handles Op2.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        OpSelector = True
        Operations = 2
    End Sub

    Private Sub Op4_Click(sender As Object, e As EventArgs) Handles Op4.Click
        Firstnum = TextBox1.Text
        TextBox1.Text = "0"
        OpSelector = True
        Operations = 4
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If OpSelector = True Then
            Secondnum = TextBox1.Text
            If Operations = 1 Then
                TextBox1.Text = Firstnum + Secondnum
            ElseIf Operations = 2 Then
                TextBox1.Text = Firstnum - Secondnum
            ElseIf Operations = 3 Then
                TextBox1.Text = Firstnum * Secondnum
            Else
                If Secondnum = 0 Then
                    TextBox1.Text = "Undefined"
                Else
                    TextBox1.Text = Firstnum / Secondnum
                End If
            End If
            OpSelector = False
        End If
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
