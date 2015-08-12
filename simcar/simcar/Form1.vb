Public Class Form1
    Private myThread As System.Threading.Thread
    Private myThread2 As System.Threading.Thread
    Dim i As Integer
    Dim i2 As Integer


    Private Sub add()

        CheckForIllegalCrossThreadCalls = False
        Dim type As Short
        If ComboBox1.Text = "Liviano" Then
            type = 1
        ElseIf ComboBox1.Text = "Pesado" Then
            type = 2
        End If

        Dim gaso As Short = Convert.ToInt16(TextBox1.Text)


        Dim ccar As New car(type, 300, gaso)
        Console.WriteLine(ccar.tipo & " " & ccar.gasolina & ccar.peso)


        Do Until i2 = 10000
            i2 = i2 + 1

            Label1.Text = i2

            Me.Refresh()
        Loop

    End Sub
    Private Sub add2()
        CheckForIllegalCrossThreadCalls = False

        Do Until i = 10000
            i = i + 1
            Label2.Text = i
            Me.Refresh()
        Loop

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myThread = New System.Threading.Thread(AddressOf add)
        myThread.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myThread2 = New System.Threading.Thread(AddressOf add2)
        myThread2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Label1.Text = "12"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
