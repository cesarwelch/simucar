Public Class Form1
    Private myThread As System.Threading.Thread
    Private myThread2 As System.Threading.Thread
    Dim i As Integer
    Dim i2 As Integer
    Dim ban As Integer = 0
    Dim bans As Integer = 0
    Dim cdr As Integer = 0

    Private Sub add()



        CheckForIllegalCrossThreadCalls = False
        Dim tip As Short

        If ComboBox1.Text = "Liviano" Then
            tip = 1
        Else
            tip = 2
        End If

        If ban = 1 Then
            ban = 0
        Else ban = 0
            ban = 1
        End If
        Console.WriteLine(ban)
        Dim gaso As Short = Convert.ToInt16(TextBox1.Text)
        Dim ccar As New car(tip, 300, gaso)
        Console.WriteLine(ccar.tipo & " " & ccar.gasolina & " " & ccar.peso)


        Do While bans = 0

        Loop

        Do Until False ''ban = 0 ''i2 = 10000
            If cdr = 0 Then


                If ban = 0 Then
                    i2 = i2 + 1
                Else
                    i2 = i2 - 1
                End If
            Else

            End If

            Label1.Text = i2 / 50

            Me.Refresh()
        Loop

    End Sub
    ''' <summary>
    '''         CheckForIllegalCrossThreadCalls = False
    '''  Do Until i = 10000
    '''       i = i + 1
    '''    Label2.Text = i
    '''Me.Refresh()
    '''Loop
    ''' 
    ''' </summary>
    Private Sub add2()
        bans = 1
        If ban = 1 Then
            ban = 0
        Else ban = 0
            ban = 1
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = 20
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        myThread = New System.Threading.Thread(AddressOf add)
        myThread.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ''myThread2 = New System.Threading.Thread(AddressOf add2)
        ''myThread2.Start()
        add2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ''  Timer1.Start()
        If cdr = 1 Then
            cdr = 0
        Else cdr = 0
            cdr = 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Val(Label3.Text) + 1
        If (Val(Label3.Text) = 60) Then
            Timer1.Interval = 1000
            Label3.Text = 10
        End If
    End Sub
End Class
