Public Class Calculator

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Addition()

        Try
            Dim FirstNumber As Integer
            Dim SecondNumber As Integer
            Dim Result As Integer
            FirstNumber = First_input.Text
            SecondNumber = Second_Input.Text
            Result = FirstNumber + SecondNumber
            Result_Textbox.Text = Result

        Catch ex As Exception
            MessageBox.Show("Invalid Operations.Enter the First and Second Number")

        End Try

    End Sub
    Private Sub Subtraction()
        Try
            Dim FirstNumber As Integer
            Dim SecondNumber As Integer
            Dim Result As Integer
            FirstNumber = First_input.Text
            SecondNumber = Second_Input.Text
            Result = FirstNumber - SecondNumber
            Result_Textbox.Text = Result
        Catch ex As Exception
            MessageBox.Show("Invalid Operations.Enter the First and Second Number ")

        End Try

    End Sub
    Private Sub Division()
        Try
            Dim FirstNumber As Integer
            Dim SecondNumber As Integer
            Dim Result As Double

            FirstNumber = First_input.Text
            SecondNumber = Second_Input.Text
            Result = FirstNumber / SecondNumber
            Result_Textbox.Text = Result
        Catch ex As Exception
            MessageBox.Show("Invalid Operations.Enter the First and Second Number")

        End Try

    End Sub
    Private Sub Muliplication()
        Try
            Dim FirstNumber As Integer
            Dim SecondNumber As Integer
            Dim Result As Integer
            FirstNumber = First_input.Text
            SecondNumber = Second_Input.Text
            Result = FirstNumber * SecondNumber
            Result_Textbox.Text = Result


        Catch ex As Exception
            MessageBox.Show("Invalid Operations.Enter the First and Second Number")
        End Try
    End Sub

    Private Sub Add_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Button.Click
        Call Addition()
    End Sub

    Private Sub Subtract_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subtract_Button.Click
        Call Subtraction()

    End Sub

    Private Sub Multiply_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiply_Button.Click
        Call Muliplication()

    End Sub

    Private Sub Divide_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divide_Button.Click
        Call Division()

    End Sub

   
    Private Sub Close_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close_Button.Click
        Me.Close()

    End Sub

    Private Sub Clear_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear_Button.Click
        Result_Textbox.Clear()
        First_input.Clear()
        Second_Input.Clear()

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
