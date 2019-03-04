Public Class Form1
    Inherits System.Windows.Forms.Form

    Private Sub Form1_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Ford")
        ComboBox1.Items.Add("Toyota")

        ComboBox2.Items.Add("DX")
        ComboBox2.Items.Add("LX")
        ComboBox2.Items.Add("EX")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal E As System.EventArgs) Handles Button1.Click
        Dim MfPrice, BasePrice, RetailPrice As Double
        If (ComboBox1.Text = "Choose Maker") Or (ComboBox2.Text = "Choose Model") Then
            MsgBox("Please Choose..",, "Missing Input")
        Else
            If ComboBox1.text = "Ford" Then
                MfPrice = 20000
            Else
                MfPrice = 25000
            End If
            If ComboBox2.Text = "DX" Then
                BasePrice = MfPrice + 2000
            Else
                If ComboBox2.Text = "LX" Then
                    BasePrice = MfPrice + 3000
                Else
                    BasePrice = MfPrice + 4000
                End If
            End If
            RetailPrice = BasePrice + 500
            TextBox1.Text = Format(BasePrice, "Currency")
            TextBox2.Text = Format(BasePrice, "Currency")
        End If
    End Sub
End Class
