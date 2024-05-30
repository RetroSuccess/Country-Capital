Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Dim selectedCountry As String = ComboBox1.SelectedItem.ToString()

        Select Case selectedCountry
            Case "Iraq"
                TextBox1.Text = "Baghdad"
            Case "Germany"
                TextBox1.Text = "Berlin"
            Case "Lebanon"
                TextBox1.Text = "Beirut"
            Case "Egypt"
                TextBox1.Text = "Cairo"
            Case "France"
                TextBox1.Text = "Paris"
        End Select
    End Sub
End Class
