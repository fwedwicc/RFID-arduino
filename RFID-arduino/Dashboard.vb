Public Class Dashboard


    Private Sub LoadFormInPanel(childForm As Form)
        Panel2.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel2.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub user_data_btn_Click(sender As Object, e As EventArgs) Handles user_data_btn.Click
        LoadFormInPanel(New Form1())
    End Sub

    Private Sub user_registration_btn_Click(sender As Object, e As EventArgs) Handles user_registration_btn.Click
        LoadFormInPanel(New Form2())
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormInPanel(New Form2())
    End Sub

    Private Sub book_data_btn_Click(sender As Object, e As EventArgs) Handles book_data_btn.Click
        LoadFormInPanel(New Form3())
    End Sub

    Private Sub book_registration_btn_Click(sender As Object, e As EventArgs) Handles book_registration_btn.Click
        LoadFormInPanel(New Form4())
    End Sub
End Class
