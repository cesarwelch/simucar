﻿Public Class Form1
    Private myThread As System.Threading.Thread
    Private myThread2 As System.Threading.Thread
    Dim i As Integer
    Dim i2 As Integer

    Private Sub add()

        Do Until i2 = 10000
            i2 = i2 + 1

            Label1.Text = i2

            Me.Refresh()
        Loop

    End Sub
    Private Sub add2()

        Do Until i = 10000
            i = i + 1
            Label2.Text = i
            Me.Refresh()
        Loop

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = 20
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myThread = New System.Threading.Thread(AddressOf add)
        myThread.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myThread2 = New System.Threading.Thread(AddressOf add2)
        myThread2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = "12"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Val(Label3.Text) + 1
        If (Val(Label3.Text) = 60) Then
            Timer1.Interval = 1000
            Label3.Text = 10
        End If
    End Sub
End Class
