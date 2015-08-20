Public Class PR19GUI
    'define Variable
    Dim transmitt As Integer
    Dim rec_data As String
    Dim rec_data1 As String
    Dim rec_data2 As String
    Dim rec_data3 As String
    Dim rec_data4 As String
    Dim rec_data5 As String
    Dim rec_data6 As String
    Dim rec_data7 As String
    Dim rec_data8 As String
    'define com port name
    Dim WithEvents ComPort As New IO.Ports.SerialPort


    Private Sub PR19GUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To _
     My.Computer.Ports.SerialPortNames.Count - 1
            ComPortBox.Items.Add( _
              My.Computer.Ports.SerialPortNames(i))
        Next
       
        Button_forward.Enabled = False
        Button_backward.Enabled = False
        Button_right.Enabled = False
        Button_left.Enabled = False
        Button_Anticlock.Enabled = False
        Button_clock.Enabled = False
        Button_stop_rotate.Enabled = False
        Button_stop.Enabled = False
        RESET_button.Enabled = False
    End Sub
    'when user closing the panel
    Private Sub PR19GUI_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            ComPort.Close()
            transmitt = 0
        Catch ex As Exception

        End Try
    End Sub

    ' connect ComPort button is press
    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        Button_Search.Enabled = False
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        RESET_button.Enabled = True
        If ComPort.IsOpen Then
            ComPort.Close()
        End If
        Try
            With ComPort
                .PortName = ComPortBox.Text
                .BaudRate = 9600 '115200
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                ' .Encoding = System.Text.Encoding.Unicode
            End With
            BaudRate_msg.Text = ComPort.BaudRate

            ComPort.Open()
            ComPortDisp.Text = ComPortBox.Text & " connected."
            Button_Connect.Enabled = False
            Button_Cancel.Enabled = True
            transmitt = 1
            Button_Cancel.Enabled = True
           
            RESET_Button.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Please select COM PORTS")

        End Try

    End Sub

    'Cancel Com Port connection
    Private Sub Button_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Cancel.Click
        rec_display.Clear()
        Button_forward.Enabled = False
        Button_backward.Enabled = False
        Button_right.Enabled = False
        Button_left.Enabled = False
        Button_Anticlock.Enabled = False
        Button_clock.Enabled = False
        Button_stop_rotate.Enabled = False
        Button_stop.Enabled = False
        RESET_button.Enabled = False
        RESET_Button.Enabled = False
        If transmitt = 1 Then
            Dim send() As Byte = {&H30} 'sending command'0'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If

        Try
            ComPort.Close()
            ComPortDisp.Text = ComPort.PortName & " disconnected."
            Button_Connect.Enabled = True
            Button_Cancel.Enabled = False
            transmitt = 0
        Catch ex As Exception
            'MsgBox(ex.ToString)
            ComPortDisp.Text = ComPort.PortName & " disconnected."
            Button_Connect.Enabled = True
            Button_Cancel.Enabled = False
            Button_Cancel.Enabled = False

        End Try
    End Sub
    Private Sub Button_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Search.Click
        ComPortBox.Items.Clear()

        For i As Integer = 0 To _
          My.Computer.Ports.SerialPortNames.Count - 1
            ComPortBox.Items.Add( _
               My.Computer.Ports.SerialPortNames(i))
        Next
        Button_Cancel.Enabled = False
    End Sub


    Private Sub Button_forward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_forward.Click
        Button_forward.Enabled = False
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H38} 'sending command'8' 
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data1 = ComPort.ReadExisting
            rec_display.Text = rec_data1
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_stop.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = False
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H30} 'sending command'0'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data2 = ComPort.ReadExisting
            rec_display.Text = rec_data2
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_left_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_left.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = False
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H34} 'sending command'4'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data3 = ComPort.ReadExisting
            rec_display.Text = rec_data3
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_right_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_right.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = False
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H36} 'sending command'6'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data4 = ComPort.ReadExisting
            rec_display.Text = rec_data4
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_backward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_backward.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = False
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H32} 'sending command'2'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data5 = ComPort.ReadExisting
            rec_display.Text = rec_data5
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub



    Private Sub Button_Anticlock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Anticlock.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = False
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H33} 'sending command'3'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data6 = ComPort.ReadExisting
            rec_display.Text = rec_data6
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_clock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_clock.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = False
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H35} 'sending command'5'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data7 = ComPort.ReadExisting
            rec_display.Text = rec_data7
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub

    Private Sub Button_stop_rotate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_stop_rotate.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = False
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H30} 'sending command'0'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
        Try
            System.Threading.Thread.Sleep(300)

            rec_data8 = ComPort.ReadExisting
            rec_display.Text = rec_data8
        Catch ex As Exception
            MsgBox("Rc_report.fail")
        End Try
    End Sub



    Private Sub RESET_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RESET_button.Click
        Button_forward.Enabled = True
        Button_backward.Enabled = True
        Button_right.Enabled = True
        Button_left.Enabled = True
        Button_Anticlock.Enabled = True
        Button_clock.Enabled = True
        Button_stop_rotate.Enabled = True
        Button_stop.Enabled = True
        rec_display.Clear()
        If transmitt = 1 Then
            Dim send() As Byte = {&H30} 'sending command'0'
            Try
                ComPort.Write(send, 0, send.Length) 'transmitt data
            Catch ex As Exception
                'MsgBox(ex.ToString)
                MsgBox("send fail")
            End Try
        End If
    End Sub


End Class
