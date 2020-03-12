Public Class Acceso
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Se va a cerrar el formulario y el programa")
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class