Public Class Form1
    Inherits System.Windows.Forms.Form
    Public Sub Form1_Load(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Computer")
        ComboBox1.Items.Add("Cell Phone")
        ComboBox1.Items.Add("Web Camera")
        ComboBox1.Items.Add("Laser Printer")
    End Sub
    Public Sub Button1_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Button1.Click
        If (Val(TextBox1.Text) = 0) Or (ComboBox1.Text = "Choose Item") Then
            MsgBox("Please Input your bid!", , "Missing input data")
        Else
            MsgBox("Offer is accepted. Please find the result!")
        End If
    End Sub
    Public Sub Button2_Click(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Button2.Click
        Dim CurrentHighestBid As Double
        If ComboBox1.Text = "Computer" Then
            CurrentHighestBid = 1000
        End If
        If ComboBox1.Text = "Cell Phone" Then
            CurrentHighestBid = 200
        End If
        If ComboBox1.Text = "Web Camera" Then
            CurrentHighestBid = 100
        End If
        If ComboBox1.Text = "Laser Printer" Then
            CurrentHighestBid = 400
        End If
        If Val(TextBox1.Text) > CurrentHighestBid Then
            MsgBox("You win!", , "You win!")
        Else
            MsgBox("Sorry, your bid is not high enough. Bid again!")
        End If
    End Sub

End Class
' EDUARDO DAVILA 