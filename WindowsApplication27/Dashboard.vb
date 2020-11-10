Imports System.IO



Public Class Dashboard

    Dim pic As New Drawing2D.GraphicsPath
    Dim direction As Integer
    Dim pixel1(24) As Color
    Dim pixel2(24) As Color
    Dim pixel3(24) As Color
    Dim pixel4(24) As Color
    Dim pixel5(24) As Color
    Dim pixel6(24) As Color
    Dim pixel7(24) As Color
    Dim pixel8(24) As Color

    Dim patterFilePath = "C:\LED Editor\8x25\examples\"
    Dim R As Integer
    Dim G As Integer
    Dim B As Integer

    'Dim customColorList As New List(Of List(Of Integer))
    Dim customColorList(30, 2) As Integer

    ' Dim cc1(2) As Integer
    Dim frames = 200
    Dim LEDs = 200
    Dim duration = frames * LEDs
    Dim ccs As Integer
    'Public framesR(40000) As Integer  200 Frames into 200
    'Dim framesR(40000) As Integer
    Public framesR(duration) As Integer
    Public framesG(duration) As Integer
    Public framesB(duration) As Integer

    Public f(duration) As Color
    Public f2(duration) As Color
    Public f3(duration) As Color
    Public f4(duration) As Color

    Dim btn(199) As Button

    Dim copy As Long

    Dim serialn As Long

    Dim filepath As String

    Dim colorList(25) As Color

    ' Dim colorList() As Color

    Dim moveColorList(25, 2) As Integer

    Dim selec As Integer
    Dim tbs As Integer
    ' b1(0,1,2)
    Public patternLEDList(200, 2) As Integer


    ''' Simulator Decleration

    Dim x As Integer

    Dim colorBoxList As New List(Of Color)



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Location = New Point(0, 0)
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width

        direction = 1
        ButtonUp.BackColor = Color.Red

        Timer1.Stop()

        IntervalCount.Text = TrackBarInterval.Value * 100
        pic.AddEllipse(-1, 1, 20, 20)



        setbtn()

        If (Not Directory.Exists("C:\LED Editor")) Then
            Directory.CreateDirectory("C:\LED Editor")
        End If

        If (Not Directory.Exists("C:\LED Editor\8x25")) Then
            Directory.CreateDirectory("C:\LED Editor\8x25")
        End If

        If (Not Directory.Exists("C:\LED Editor\8x25\colorbox")) Then
            Directory.CreateDirectory("C:\LED Editor\8x25\colorbox")
        End If


        If (Not Directory.Exists("C:\Windows\Temp\datacount546")) Then
            Directory.CreateDirectory("C:\Windows\Temp\datacount546")

            Dim fw As StreamWriter
            fw = New StreamWriter("C:\Windows\Temp\datacount546\datacount.txt", False)
            fw.Write(0)
            fw.Close()
        End If

        R = 255
        G = 255
        B = 255
        selec = 0

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B


        Dim h As Integer
        For c = 0 To 30
            For h = 0 To 2
                customColorList(c, h) = 255
            Next
        Next

        ccs = 1
        frameCount.Value = 8
        frameAnimator.Maximum = (frameCount.Value) - 1

        Dim y As Long
        For y = 0 To duration
            framesR(y) = 0
            framesG(y) = 0
            framesB(y) = 0

            f(y) = Color.Black

        Next
        copy = 0
        filepath = Nothing
        TrackBarInterval.Value = 3
        tbs = 15
        drawLED()
    End Sub

    Private Sub drawLED()
        PictureBox1.Region = New Region(pic)
        PictureBox2.Region = New Region(pic)
        PictureBox3.Region = New Region(pic)
        PictureBox4.Region = New Region(pic)
        PictureBox5.Region = New Region(pic)
        PictureBox6.Region = New Region(pic)
        PictureBox7.Region = New Region(pic)
        PictureBox8.Region = New Region(pic)
        PictureBox9.Region = New Region(pic)
        PictureBox10.Region = New Region(pic)
        PictureBox11.Region = New Region(pic)
        PictureBox12.Region = New Region(pic)
        PictureBox13.Region = New Region(pic)
        PictureBox14.Region = New Region(pic)
        PictureBox15.Region = New Region(pic)
        PictureBox16.Region = New Region(pic)
        PictureBox17.Region = New Region(pic)
        PictureBox18.Region = New Region(pic)
        PictureBox19.Region = New Region(pic)
        PictureBox20.Region = New Region(pic)
        PictureBox21.Region = New Region(pic)
        PictureBox22.Region = New Region(pic)
        PictureBox23.Region = New Region(pic)
        PictureBox24.Region = New Region(pic)
        PictureBox25.Region = New Region(pic)
        PictureBox26.Region = New Region(pic)
        PictureBox27.Region = New Region(pic)
        PictureBox28.Region = New Region(pic)
        PictureBox29.Region = New Region(pic)
        PictureBox30.Region = New Region(pic)
        PictureBox31.Region = New Region(pic)
        PictureBox32.Region = New Region(pic)
        PictureBox33.Region = New Region(pic)
        PictureBox34.Region = New Region(pic)
        PictureBox35.Region = New Region(pic)
        PictureBox36.Region = New Region(pic)
        PictureBox37.Region = New Region(pic)
        PictureBox38.Region = New Region(pic)
        PictureBox39.Region = New Region(pic)
        PictureBox40.Region = New Region(pic)
        PictureBox41.Region = New Region(pic)
        PictureBox42.Region = New Region(pic)
        PictureBox43.Region = New Region(pic)
        PictureBox44.Region = New Region(pic)
        PictureBox45.Region = New Region(pic)
        PictureBox46.Region = New Region(pic)
        PictureBox47.Region = New Region(pic)
        PictureBox48.Region = New Region(pic)
        PictureBox49.Region = New Region(pic)
        PictureBox50.Region = New Region(pic)
        PictureBox51.Region = New Region(pic)
        PictureBox52.Region = New Region(pic)
        PictureBox53.Region = New Region(pic)
        PictureBox54.Region = New Region(pic)
        PictureBox55.Region = New Region(pic)
        PictureBox56.Region = New Region(pic)
        PictureBox57.Region = New Region(pic)
        PictureBox58.Region = New Region(pic)
        PictureBox59.Region = New Region(pic)
        PictureBox60.Region = New Region(pic)
        PictureBox61.Region = New Region(pic)
        PictureBox62.Region = New Region(pic)
        PictureBox63.Region = New Region(pic)
        PictureBox64.Region = New Region(pic)
        PictureBox65.Region = New Region(pic)
        PictureBox66.Region = New Region(pic)
        PictureBox67.Region = New Region(pic)
        PictureBox68.Region = New Region(pic)
        PictureBox69.Region = New Region(pic)
        PictureBox70.Region = New Region(pic)
        PictureBox71.Region = New Region(pic)
        PictureBox72.Region = New Region(pic)
        PictureBox73.Region = New Region(pic)
        PictureBox74.Region = New Region(pic)
        PictureBox75.Region = New Region(pic)
        PictureBox76.Region = New Region(pic)
        PictureBox77.Region = New Region(pic)
        PictureBox78.Region = New Region(pic)
        PictureBox79.Region = New Region(pic)
        PictureBox80.Region = New Region(pic)
        PictureBox81.Region = New Region(pic)
        PictureBox82.Region = New Region(pic)
        PictureBox83.Region = New Region(pic)
        PictureBox84.Region = New Region(pic)
        PictureBox85.Region = New Region(pic)
        PictureBox86.Region = New Region(pic)
        PictureBox87.Region = New Region(pic)
        PictureBox88.Region = New Region(pic)
        PictureBox89.Region = New Region(pic)
        PictureBox90.Region = New Region(pic)
        PictureBox91.Region = New Region(pic)
        PictureBox92.Region = New Region(pic)
        PictureBox93.Region = New Region(pic)
        PictureBox94.Region = New Region(pic)
        PictureBox95.Region = New Region(pic)
        PictureBox96.Region = New Region(pic)
        PictureBox97.Region = New Region(pic)
        PictureBox98.Region = New Region(pic)
        PictureBox99.Region = New Region(pic)
        PictureBox100.Region = New Region(pic)
        PictureBox101.Region = New Region(pic)
        PictureBox102.Region = New Region(pic)
        PictureBox103.Region = New Region(pic)
        PictureBox104.Region = New Region(pic)
        PictureBox105.Region = New Region(pic)
        PictureBox106.Region = New Region(pic)
        PictureBox107.Region = New Region(pic)
        PictureBox108.Region = New Region(pic)
        PictureBox109.Region = New Region(pic)
        PictureBox110.Region = New Region(pic)
        PictureBox111.Region = New Region(pic)
        PictureBox112.Region = New Region(pic)
        PictureBox113.Region = New Region(pic)
        PictureBox114.Region = New Region(pic)
        PictureBox115.Region = New Region(pic)
        PictureBox116.Region = New Region(pic)
        PictureBox117.Region = New Region(pic)
        PictureBox118.Region = New Region(pic)
        PictureBox119.Region = New Region(pic)
        PictureBox120.Region = New Region(pic)
        PictureBox121.Region = New Region(pic)
        PictureBox122.Region = New Region(pic)
        PictureBox123.Region = New Region(pic)
        PictureBox124.Region = New Region(pic)
        PictureBox125.Region = New Region(pic)
        PictureBox126.Region = New Region(pic)
        PictureBox127.Region = New Region(pic)
        PictureBox128.Region = New Region(pic)
        PictureBox129.Region = New Region(pic)
        PictureBox130.Region = New Region(pic)
        PictureBox131.Region = New Region(pic)
        PictureBox132.Region = New Region(pic)
        PictureBox133.Region = New Region(pic)
        PictureBox134.Region = New Region(pic)
        PictureBox135.Region = New Region(pic)
        PictureBox136.Region = New Region(pic)
        PictureBox137.Region = New Region(pic)
        PictureBox138.Region = New Region(pic)
        PictureBox139.Region = New Region(pic)
        PictureBox140.Region = New Region(pic)
        PictureBox141.Region = New Region(pic)
        PictureBox142.Region = New Region(pic)
        PictureBox143.Region = New Region(pic)
        PictureBox144.Region = New Region(pic)
        PictureBox145.Region = New Region(pic)
        PictureBox146.Region = New Region(pic)
        PictureBox147.Region = New Region(pic)
        PictureBox148.Region = New Region(pic)
        PictureBox149.Region = New Region(pic)
        PictureBox150.Region = New Region(pic)
        PictureBox151.Region = New Region(pic)
        PictureBox152.Region = New Region(pic)
        PictureBox153.Region = New Region(pic)
        PictureBox154.Region = New Region(pic)
        PictureBox155.Region = New Region(pic)
        PictureBox156.Region = New Region(pic)
        PictureBox157.Region = New Region(pic)
        PictureBox158.Region = New Region(pic)
        PictureBox159.Region = New Region(pic)
        PictureBox160.Region = New Region(pic)
        PictureBox161.Region = New Region(pic)
        PictureBox162.Region = New Region(pic)
        PictureBox163.Region = New Region(pic)
        PictureBox164.Region = New Region(pic)
        PictureBox165.Region = New Region(pic)
        PictureBox166.Region = New Region(pic)
        PictureBox167.Region = New Region(pic)
        PictureBox168.Region = New Region(pic)
        PictureBox169.Region = New Region(pic)
        PictureBox170.Region = New Region(pic)
        PictureBox171.Region = New Region(pic)
        PictureBox172.Region = New Region(pic)
        PictureBox173.Region = New Region(pic)
        PictureBox174.Region = New Region(pic)
        PictureBox175.Region = New Region(pic)
        PictureBox176.Region = New Region(pic)
        PictureBox177.Region = New Region(pic)
        PictureBox178.Region = New Region(pic)
        PictureBox179.Region = New Region(pic)
        PictureBox180.Region = New Region(pic)
        PictureBox181.Region = New Region(pic)
        PictureBox182.Region = New Region(pic)
        PictureBox183.Region = New Region(pic)
        PictureBox184.Region = New Region(pic)
        PictureBox185.Region = New Region(pic)
        PictureBox186.Region = New Region(pic)
        PictureBox187.Region = New Region(pic)
        PictureBox188.Region = New Region(pic)
        PictureBox189.Region = New Region(pic)
        PictureBox190.Region = New Region(pic)
        PictureBox191.Region = New Region(pic)
        PictureBox192.Region = New Region(pic)
        PictureBox193.Region = New Region(pic)
        PictureBox194.Region = New Region(pic)
        PictureBox195.Region = New Region(pic)
        PictureBox196.Region = New Region(pic)
        PictureBox197.Region = New Region(pic)
        PictureBox198.Region = New Region(pic)
        PictureBox199.Region = New Region(pic)
        PictureBox200.Region = New Region(pic)


    End Sub


    Sub setbtn()
        ''Row 1 - 25
        btn(0) = Button1
        btn(1) = Button16
        btn(2) = Button17
        btn(3) = Button32
        btn(4) = Button33
        btn(5) = Button48
        btn(6) = Button49
        btn(7) = Button64
        btn(8) = Button65
        btn(9) = Button80
        btn(10) = Button81
        btn(11) = Button96
        btn(12) = Button97
        btn(13) = Button112
        btn(14) = Button113
        btn(15) = Button128
        btn(16) = Button129
        btn(17) = Button144
        btn(18) = Button145
        btn(19) = Button160
        btn(20) = Button161
        btn(21) = Button176
        btn(22) = Button177
        btn(23) = Button192
        btn(24) = Button193

        btn(25) = Button2
        btn(26) = Button15
        btn(27) = Button18
        btn(28) = Button31
        btn(29) = Button34
        btn(30) = Button47
        btn(31) = Button50
        btn(32) = Button63
        btn(33) = Button66
        btn(34) = Button79
        btn(35) = Button82
        btn(36) = Button95
        btn(37) = Button98
        btn(38) = Button111
        btn(39) = Button114
        btn(40) = Button127
        btn(41) = Button130
        btn(42) = Button143
        btn(43) = Button146
        btn(44) = Button159
        btn(45) = Button162
        btn(46) = Button175
        btn(47) = Button178
        btn(48) = Button191
        btn(49) = Button194
        btn(50) = Button3
        btn(51) = Button14
        btn(52) = Button19
        btn(53) = Button30
        btn(54) = Button35
        btn(55) = Button46
        btn(56) = Button51
        btn(57) = Button62
        btn(58) = Button67
        btn(59) = Button78
        btn(60) = Button83
        btn(61) = Button94
        btn(62) = Button99
        btn(63) = Button110
        btn(64) = Button115
        btn(65) = Button126
        btn(66) = Button131
        btn(67) = Button142
        btn(68) = Button147
        btn(69) = Button158
        btn(70) = Button163
        btn(71) = Button174
        btn(72) = Button179
        btn(73) = Button190
        btn(74) = Button195
        btn(75) = Button4
        btn(76) = Button13
        btn(77) = Button20
        btn(78) = Button29
        btn(79) = Button36
        btn(80) = Button45
        btn(81) = Button52
        btn(82) = Button61
        btn(83) = Button68
        btn(84) = Button77
        btn(85) = Button84
        btn(86) = Button93
        btn(87) = Button100
        btn(88) = Button109
        btn(89) = Button116
        btn(90) = Button125
        btn(91) = Button132
        btn(92) = Button141
        btn(93) = Button148
        btn(94) = Button157
        btn(95) = Button164
        btn(96) = Button173
        btn(97) = Button180
        btn(98) = Button189
        btn(99) = Button196
        btn(100) = Button5
        btn(101) = Button12
        btn(102) = Button21
        btn(103) = Button28
        btn(104) = Button37
        btn(105) = Button44
        btn(106) = Button53
        btn(107) = Button60
        btn(108) = Button69
        btn(109) = Button76
        btn(110) = Button85
        btn(111) = Button92
        btn(112) = Button101
        btn(113) = Button108
        btn(114) = Button117
        btn(115) = Button124
        btn(116) = Button133
        btn(117) = Button140
        btn(118) = Button149
        btn(119) = Button156
        btn(120) = Button165
        btn(121) = Button172
        btn(122) = Button181
        btn(123) = Button188
        btn(124) = Button197
        btn(125) = Button6
        btn(126) = Button11
        btn(127) = Button22
        btn(128) = Button27
        btn(129) = Button38
        btn(130) = Button43
        btn(131) = Button54
        btn(132) = Button59
        btn(133) = Button70
        btn(134) = Button75
        btn(135) = Button86
        btn(136) = Button91
        btn(137) = Button102
        btn(138) = Button107
        btn(139) = Button118
        btn(140) = Button123
        btn(141) = Button134
        btn(142) = Button139
        btn(143) = Button150
        btn(144) = Button155
        btn(145) = Button166
        btn(146) = Button171
        btn(147) = Button182
        btn(148) = Button187
        btn(149) = Button198
        btn(150) = Button7
        btn(151) = Button10
        btn(152) = Button23
        btn(153) = Button26
        btn(154) = Button39
        btn(155) = Button42
        btn(156) = Button55
        btn(157) = Button58
        btn(158) = Button71
        btn(159) = Button74
        btn(160) = Button87
        btn(161) = Button90
        btn(162) = Button103
        btn(163) = Button106
        btn(164) = Button119
        btn(165) = Button122
        btn(166) = Button135
        btn(167) = Button138
        btn(168) = Button151
        btn(169) = Button154
        btn(170) = Button167
        btn(171) = Button170
        btn(172) = Button183
        btn(173) = Button186
        btn(174) = Button199
        btn(175) = Button8
        btn(176) = Button9
        btn(177) = Button24
        btn(178) = Button25
        btn(179) = Button40
        btn(180) = Button41
        btn(181) = Button56
        btn(182) = Button57
        btn(183) = Button72
        btn(184) = Button73
        btn(185) = Button88
        btn(186) = Button89
        btn(187) = Button104
        btn(188) = Button105
        btn(189) = Button120
        btn(190) = Button121
        btn(191) = Button136
        btn(192) = Button137
        btn(193) = Button152
        btn(194) = Button153
        btn(195) = Button168
        btn(196) = Button169
        btn(197) = Button184
        btn(198) = Button185
        btn(199) = Button200

    End Sub
    Sub upc1()
        patternLEDList(1, 0) = patternLEDList(2, 0)
        patternLEDList(1, 1) = patternLEDList(2, 1)
        patternLEDList(1, 2) = patternLEDList(2, 2)
        Button1.BackColor = Button2.BackColor

        patternLEDList(2, 0) = patternLEDList(3, 0)
        patternLEDList(2, 1) = patternLEDList(3, 1)
        patternLEDList(2, 2) = patternLEDList(3, 2)
        Button2.BackColor = Button3.BackColor

        patternLEDList(3, 0) = patternLEDList(4, 0)
        patternLEDList(3, 1) = patternLEDList(4, 1)
        patternLEDList(3, 2) = patternLEDList(4, 2)
        Button3.BackColor = Button4.BackColor

        patternLEDList(4, 0) = patternLEDList(5, 0)
        patternLEDList(4, 1) = patternLEDList(5, 1)
        patternLEDList(4, 2) = patternLEDList(5, 2)
        Button4.BackColor = Button5.BackColor

        patternLEDList(5, 0) = patternLEDList(6, 0)
        patternLEDList(5, 1) = patternLEDList(6, 1)
        patternLEDList(5, 2) = patternLEDList(6, 2)
        Button5.BackColor = Button6.BackColor

        patternLEDList(6, 0) = patternLEDList(7, 0)
        patternLEDList(6, 1) = patternLEDList(7, 1)
        patternLEDList(6, 2) = patternLEDList(7, 2)
        Button6.BackColor = Button7.BackColor

        patternLEDList(7, 0) = patternLEDList(8, 0)
        patternLEDList(7, 1) = patternLEDList(8, 1)
        patternLEDList(7, 2) = patternLEDList(8, 2)
        Button7.BackColor = Button8.BackColor

        patternLEDList(8, 0) = 0
        patternLEDList(8, 1) = 0
        patternLEDList(8, 2) = 0
        Button8.BackColor = Color.Black


    End Sub
    Sub upc2()
        patternLEDList(16, 0) = patternLEDList(15, 0)
        patternLEDList(16, 1) = patternLEDList(15, 1)
        patternLEDList(16, 2) = patternLEDList(15, 2)
        Button16.BackColor = Button15.BackColor

        patternLEDList(15, 0) = patternLEDList(14, 0)
        patternLEDList(15, 1) = patternLEDList(14, 1)
        patternLEDList(15, 2) = patternLEDList(14, 2)
        Button15.BackColor = Button14.BackColor

        patternLEDList(14, 0) = patternLEDList(13, 0)
        patternLEDList(14, 1) = patternLEDList(13, 1)
        patternLEDList(14, 2) = patternLEDList(13, 2)
        Button14.BackColor = Button13.BackColor

        patternLEDList(13, 0) = patternLEDList(12, 0)
        patternLEDList(13, 1) = patternLEDList(12, 1)
        patternLEDList(13, 2) = patternLEDList(12, 2)
        Button13.BackColor = Button12.BackColor

        patternLEDList(12, 0) = patternLEDList(11, 0)
        patternLEDList(12, 1) = patternLEDList(11, 1)
        patternLEDList(12, 2) = patternLEDList(11, 2)
        Button12.BackColor = Button11.BackColor

        patternLEDList(11, 0) = patternLEDList(10, 0)
        patternLEDList(11, 1) = patternLEDList(10, 1)
        patternLEDList(11, 2) = patternLEDList(10, 2)
        Button11.BackColor = Button10.BackColor

        patternLEDList(10, 0) = patternLEDList(9, 0)
        patternLEDList(10, 1) = patternLEDList(9, 1)
        patternLEDList(10, 2) = patternLEDList(9, 2)
        Button10.BackColor = Button9.BackColor

        patternLEDList(9, 0) = 0
        patternLEDList(9, 1) = 0
        patternLEDList(9, 2) = 0
        Button9.BackColor = Color.Black

    End Sub
    Sub upc3()
        patternLEDList(17, 0) = patternLEDList(18, 0)
        patternLEDList(17, 1) = patternLEDList(18, 1)
        patternLEDList(17, 2) = patternLEDList(18, 2)
        Button17.BackColor = Button18.BackColor

        patternLEDList(18, 0) = patternLEDList(19, 0)
        patternLEDList(18, 1) = patternLEDList(19, 1)
        patternLEDList(18, 2) = patternLEDList(19, 2)
        Button18.BackColor = Button19.BackColor

        patternLEDList(19, 0) = patternLEDList(20, 0)
        patternLEDList(19, 1) = patternLEDList(20, 1)
        patternLEDList(19, 2) = patternLEDList(20, 2)
        Button19.BackColor = Button20.BackColor

        patternLEDList(20, 0) = patternLEDList(21, 0)
        patternLEDList(20, 1) = patternLEDList(21, 1)
        patternLEDList(20, 2) = patternLEDList(21, 2)
        Button20.BackColor = Button21.BackColor

        patternLEDList(21, 0) = patternLEDList(22, 0)
        patternLEDList(21, 1) = patternLEDList(22, 1)
        patternLEDList(21, 2) = patternLEDList(22, 2)
        Button21.BackColor = Button22.BackColor

        patternLEDList(22, 0) = patternLEDList(23, 0)
        patternLEDList(22, 1) = patternLEDList(23, 1)
        patternLEDList(22, 2) = patternLEDList(23, 2)
        Button22.BackColor = Button23.BackColor

        patternLEDList(23, 0) = patternLEDList(24, 0)
        patternLEDList(23, 1) = patternLEDList(24, 1)
        patternLEDList(23, 2) = patternLEDList(24, 2)
        Button23.BackColor = Button24.BackColor

        patternLEDList(24, 0) = 0
        patternLEDList(24, 1) = 0
        patternLEDList(24, 2) = 0
        Button24.BackColor = Color.Black

    End Sub
    Sub upc4()
        patternLEDList(32, 0) = patternLEDList(31, 0)
        patternLEDList(32, 1) = patternLEDList(31, 1)
        patternLEDList(32, 2) = patternLEDList(31, 2)
        Button32.BackColor = Button31.BackColor

        patternLEDList(31, 0) = patternLEDList(30, 0)
        patternLEDList(31, 1) = patternLEDList(30, 1)
        patternLEDList(31, 2) = patternLEDList(30, 2)
        Button31.BackColor = Button30.BackColor

        patternLEDList(30, 0) = patternLEDList(29, 0)
        patternLEDList(30, 1) = patternLEDList(29, 1)
        patternLEDList(30, 2) = patternLEDList(29, 2)
        Button30.BackColor = Button29.BackColor

        patternLEDList(29, 0) = patternLEDList(28, 0)
        patternLEDList(29, 1) = patternLEDList(28, 1)
        patternLEDList(29, 2) = patternLEDList(28, 2)
        Button29.BackColor = Button28.BackColor

        patternLEDList(28, 0) = patternLEDList(27, 0)
        patternLEDList(28, 1) = patternLEDList(27, 1)
        patternLEDList(28, 2) = patternLEDList(27, 2)
        Button28.BackColor = Button27.BackColor

        patternLEDList(27, 0) = patternLEDList(26, 0)
        patternLEDList(27, 1) = patternLEDList(26, 1)
        patternLEDList(27, 2) = patternLEDList(26, 2)
        Button27.BackColor = Button26.BackColor

        patternLEDList(26, 0) = patternLEDList(25, 0)
        patternLEDList(26, 1) = patternLEDList(25, 1)
        patternLEDList(26, 2) = patternLEDList(25, 2)
        Button26.BackColor = Button25.BackColor

        patternLEDList(25, 0) = 0
        patternLEDList(25, 1) = 0
        patternLEDList(25, 2) = 0
        Button25.BackColor = Color.Black


    End Sub
    Sub upc5()
        patternLEDList(33, 0) = patternLEDList(34, 0)
        patternLEDList(33, 1) = patternLEDList(34, 1)
        patternLEDList(33, 2) = patternLEDList(34, 2)
        Button33.BackColor = Button34.BackColor

        patternLEDList(34, 0) = patternLEDList(35, 0)
        patternLEDList(34, 1) = patternLEDList(35, 1)
        patternLEDList(34, 2) = patternLEDList(35, 2)
        Button34.BackColor = Button35.BackColor

        patternLEDList(35, 0) = patternLEDList(36, 0)
        patternLEDList(35, 1) = patternLEDList(36, 1)
        patternLEDList(35, 2) = patternLEDList(36, 2)
        Button35.BackColor = Button36.BackColor

        patternLEDList(36, 0) = patternLEDList(37, 0)
        patternLEDList(36, 1) = patternLEDList(37, 1)
        patternLEDList(36, 2) = patternLEDList(37, 2)
        Button36.BackColor = Button37.BackColor

        patternLEDList(37, 0) = patternLEDList(38, 0)
        patternLEDList(37, 1) = patternLEDList(38, 1)
        patternLEDList(37, 2) = patternLEDList(38, 2)
        Button37.BackColor = Button38.BackColor

        patternLEDList(38, 0) = patternLEDList(39, 0)
        patternLEDList(38, 1) = patternLEDList(39, 1)
        patternLEDList(38, 2) = patternLEDList(39, 2)
        Button38.BackColor = Button39.BackColor

        patternLEDList(39, 0) = patternLEDList(40, 0)
        patternLEDList(39, 1) = patternLEDList(40, 1)
        patternLEDList(39, 2) = patternLEDList(40, 2)
        Button39.BackColor = Button40.BackColor

        patternLEDList(40, 0) = 0
        patternLEDList(40, 1) = 0
        patternLEDList(40, 2) = 0
        Button40.BackColor = Color.Black

    End Sub
    Sub upc6()
        patternLEDList(48, 0) = patternLEDList(47, 0)
        patternLEDList(48, 1) = patternLEDList(47, 1)
        patternLEDList(48, 2) = patternLEDList(47, 2)
        Button48.BackColor = Button47.BackColor

        patternLEDList(47, 0) = patternLEDList(46, 0)
        patternLEDList(47, 1) = patternLEDList(46, 1)
        patternLEDList(47, 2) = patternLEDList(46, 2)
        Button47.BackColor = Button46.BackColor

        patternLEDList(46, 0) = patternLEDList(45, 0)
        patternLEDList(46, 1) = patternLEDList(45, 1)
        patternLEDList(46, 2) = patternLEDList(45, 2)
        Button46.BackColor = Button45.BackColor

        patternLEDList(45, 0) = patternLEDList(44, 0)
        patternLEDList(45, 1) = patternLEDList(44, 1)
        patternLEDList(45, 2) = patternLEDList(44, 2)
        Button45.BackColor = Button44.BackColor

        patternLEDList(44, 0) = patternLEDList(43, 0)
        patternLEDList(44, 1) = patternLEDList(43, 1)
        patternLEDList(44, 2) = patternLEDList(43, 2)
        Button44.BackColor = Button43.BackColor

        patternLEDList(43, 0) = patternLEDList(42, 0)
        patternLEDList(43, 1) = patternLEDList(42, 1)
        patternLEDList(43, 2) = patternLEDList(42, 2)
        Button43.BackColor = Button42.BackColor

        patternLEDList(42, 0) = patternLEDList(41, 0)
        patternLEDList(42, 1) = patternLEDList(41, 1)
        patternLEDList(42, 2) = patternLEDList(41, 2)
        Button42.BackColor = Button41.BackColor

        patternLEDList(41, 0) = 0
        patternLEDList(41, 1) = 0
        patternLEDList(41, 2) = 0
        Button41.BackColor = Color.Black

    End Sub
    Sub upc7()
        patternLEDList(49, 0) = patternLEDList(50, 0)
        patternLEDList(49, 1) = patternLEDList(50, 1)
        patternLEDList(49, 2) = patternLEDList(50, 2)
        Button49.BackColor = Button50.BackColor

        patternLEDList(50, 0) = patternLEDList(51, 0)
        patternLEDList(50, 1) = patternLEDList(51, 1)
        patternLEDList(50, 2) = patternLEDList(51, 2)
        Button50.BackColor = Button51.BackColor

        patternLEDList(51, 0) = patternLEDList(52, 0)
        patternLEDList(51, 1) = patternLEDList(52, 1)
        patternLEDList(51, 2) = patternLEDList(52, 2)
        Button51.BackColor = Button52.BackColor

        patternLEDList(52, 0) = patternLEDList(53, 0)
        patternLEDList(52, 1) = patternLEDList(53, 1)
        patternLEDList(52, 2) = patternLEDList(53, 2)
        Button52.BackColor = Button53.BackColor

        patternLEDList(53, 0) = patternLEDList(54, 0)
        patternLEDList(53, 1) = patternLEDList(54, 1)
        patternLEDList(53, 2) = patternLEDList(54, 2)
        Button53.BackColor = Button54.BackColor

        patternLEDList(54, 0) = patternLEDList(55, 0)
        patternLEDList(54, 1) = patternLEDList(55, 1)
        patternLEDList(54, 2) = patternLEDList(55, 2)
        Button54.BackColor = Button55.BackColor

        patternLEDList(55, 0) = patternLEDList(56, 0)
        patternLEDList(55, 1) = patternLEDList(56, 1)
        patternLEDList(55, 2) = patternLEDList(56, 2)
        Button55.BackColor = Button56.BackColor

        patternLEDList(56, 0) = 0
        patternLEDList(56, 1) = 0
        patternLEDList(56, 2) = 0
        Button56.BackColor = Color.Black

    End Sub
    Sub upc8()
        patternLEDList(64, 0) = patternLEDList(63, 0)
        patternLEDList(64, 1) = patternLEDList(63, 1)
        patternLEDList(64, 2) = patternLEDList(63, 2)
        Button64.BackColor = Button63.BackColor

        patternLEDList(63, 0) = patternLEDList(62, 0)
        patternLEDList(63, 1) = patternLEDList(62, 1)
        patternLEDList(63, 2) = patternLEDList(62, 2)
        Button63.BackColor = Button62.BackColor

        patternLEDList(62, 0) = patternLEDList(61, 0)
        patternLEDList(62, 1) = patternLEDList(61, 1)
        patternLEDList(62, 2) = patternLEDList(61, 2)
        Button62.BackColor = Button61.BackColor

        patternLEDList(61, 0) = patternLEDList(60, 0)
        patternLEDList(61, 1) = patternLEDList(60, 1)
        patternLEDList(61, 2) = patternLEDList(60, 2)
        Button61.BackColor = Button60.BackColor

        patternLEDList(60, 0) = patternLEDList(59, 0)
        patternLEDList(60, 1) = patternLEDList(59, 1)
        patternLEDList(60, 2) = patternLEDList(59, 2)
        Button60.BackColor = Button59.BackColor

        patternLEDList(59, 0) = patternLEDList(58, 0)
        patternLEDList(59, 1) = patternLEDList(58, 1)
        patternLEDList(59, 2) = patternLEDList(58, 2)
        Button59.BackColor = Button58.BackColor

        patternLEDList(58, 0) = patternLEDList(57, 0)
        patternLEDList(58, 1) = patternLEDList(57, 1)
        patternLEDList(58, 2) = patternLEDList(57, 2)
        Button58.BackColor = Button57.BackColor

        patternLEDList(57, 0) = 0
        patternLEDList(57, 1) = 0
        patternLEDList(57, 2) = 0
        Button57.BackColor = Color.Black

    End Sub
    Sub upc9()
        patternLEDList(65, 0) = patternLEDList(66, 0)
        patternLEDList(65, 1) = patternLEDList(66, 1)
        patternLEDList(65, 2) = patternLEDList(66, 2)
        Button65.BackColor = Button66.BackColor

        patternLEDList(66, 0) = patternLEDList(67, 0)
        patternLEDList(66, 1) = patternLEDList(67, 1)
        patternLEDList(66, 2) = patternLEDList(67, 2)
        Button66.BackColor = Button67.BackColor

        patternLEDList(67, 0) = patternLEDList(68, 0)
        patternLEDList(67, 1) = patternLEDList(68, 1)
        patternLEDList(67, 2) = patternLEDList(68, 2)
        Button67.BackColor = Button68.BackColor

        patternLEDList(68, 0) = patternLEDList(69, 0)
        patternLEDList(68, 1) = patternLEDList(69, 1)
        patternLEDList(68, 2) = patternLEDList(69, 2)
        Button68.BackColor = Button69.BackColor

        patternLEDList(69, 0) = patternLEDList(70, 0)
        patternLEDList(69, 1) = patternLEDList(70, 1)
        patternLEDList(69, 2) = patternLEDList(70, 2)
        Button69.BackColor = Button70.BackColor

        patternLEDList(70, 0) = patternLEDList(71, 0)
        patternLEDList(70, 1) = patternLEDList(71, 1)
        patternLEDList(70, 2) = patternLEDList(71, 2)
        Button70.BackColor = Button71.BackColor

        patternLEDList(71, 0) = patternLEDList(72, 0)
        patternLEDList(71, 1) = patternLEDList(72, 1)
        patternLEDList(71, 2) = patternLEDList(72, 2)
        Button71.BackColor = Button72.BackColor

        patternLEDList(72, 0) = 0
        patternLEDList(72, 1) = 0
        patternLEDList(72, 2) = 0
        Button72.BackColor = Color.Black

    End Sub
    Sub upc10()
        patternLEDList(80, 0) = patternLEDList(79, 0)
        patternLEDList(80, 1) = patternLEDList(79, 1)
        patternLEDList(80, 2) = patternLEDList(79, 2)
        Button80.BackColor = Button79.BackColor

        patternLEDList(79, 0) = patternLEDList(78, 0)
        patternLEDList(79, 1) = patternLEDList(78, 1)
        patternLEDList(79, 2) = patternLEDList(78, 2)
        Button79.BackColor = Button78.BackColor

        patternLEDList(78, 0) = patternLEDList(77, 0)
        patternLEDList(78, 1) = patternLEDList(77, 1)
        patternLEDList(78, 2) = patternLEDList(77, 2)
        Button78.BackColor = Button77.BackColor

        patternLEDList(77, 0) = patternLEDList(76, 0)
        patternLEDList(77, 1) = patternLEDList(76, 1)
        patternLEDList(77, 2) = patternLEDList(76, 2)
        Button77.BackColor = Button76.BackColor

        patternLEDList(76, 0) = patternLEDList(75, 0)
        patternLEDList(76, 1) = patternLEDList(75, 1)
        patternLEDList(76, 2) = patternLEDList(75, 2)
        Button76.BackColor = Button75.BackColor

        patternLEDList(75, 0) = patternLEDList(74, 0)
        patternLEDList(75, 1) = patternLEDList(74, 1)
        patternLEDList(75, 2) = patternLEDList(74, 2)
        Button75.BackColor = Button74.BackColor

        patternLEDList(74, 0) = patternLEDList(73, 0)
        patternLEDList(74, 1) = patternLEDList(73, 1)
        patternLEDList(74, 2) = patternLEDList(73, 2)
        Button74.BackColor = Button73.BackColor

        patternLEDList(73, 0) = 0
        patternLEDList(73, 1) = 0
        patternLEDList(73, 2) = 0
        Button73.BackColor = Color.Black

    End Sub
    Sub upc11()
        patternLEDList(81, 0) = patternLEDList(82, 0)
        patternLEDList(81, 1) = patternLEDList(82, 1)
        patternLEDList(81, 2) = patternLEDList(82, 2)
        Button81.BackColor = Button82.BackColor

        patternLEDList(82, 0) = patternLEDList(83, 0)
        patternLEDList(82, 1) = patternLEDList(83, 1)
        patternLEDList(82, 2) = patternLEDList(83, 2)
        Button82.BackColor = Button83.BackColor

        patternLEDList(83, 0) = patternLEDList(84, 0)
        patternLEDList(83, 1) = patternLEDList(84, 1)
        patternLEDList(83, 2) = patternLEDList(84, 2)
        Button83.BackColor = Button84.BackColor

        patternLEDList(84, 0) = patternLEDList(85, 0)
        patternLEDList(84, 1) = patternLEDList(85, 1)
        patternLEDList(84, 2) = patternLEDList(85, 2)
        Button84.BackColor = Button85.BackColor

        patternLEDList(85, 0) = patternLEDList(86, 0)
        patternLEDList(85, 1) = patternLEDList(86, 1)
        patternLEDList(85, 2) = patternLEDList(86, 2)
        Button85.BackColor = Button86.BackColor

        patternLEDList(86, 0) = patternLEDList(87, 0)
        patternLEDList(86, 1) = patternLEDList(87, 1)
        patternLEDList(86, 2) = patternLEDList(87, 2)
        Button86.BackColor = Button87.BackColor

        patternLEDList(87, 0) = patternLEDList(88, 0)
        patternLEDList(87, 1) = patternLEDList(88, 1)
        patternLEDList(87, 2) = patternLEDList(88, 2)
        Button87.BackColor = Button88.BackColor

        patternLEDList(88, 0) = 0
        patternLEDList(88, 1) = 0
        patternLEDList(88, 2) = 0
        Button88.BackColor = Color.Black

    End Sub
    Sub upc12()
        patternLEDList(96, 0) = patternLEDList(95, 0)
        patternLEDList(96, 1) = patternLEDList(95, 1)
        patternLEDList(96, 2) = patternLEDList(95, 2)
        Button96.BackColor = Button95.BackColor

        patternLEDList(95, 0) = patternLEDList(94, 0)
        patternLEDList(95, 1) = patternLEDList(94, 1)
        patternLEDList(95, 2) = patternLEDList(94, 2)
        Button95.BackColor = Button94.BackColor

        patternLEDList(94, 0) = patternLEDList(93, 0)
        patternLEDList(94, 1) = patternLEDList(93, 1)
        patternLEDList(94, 2) = patternLEDList(93, 2)
        Button94.BackColor = Button93.BackColor

        patternLEDList(93, 0) = patternLEDList(92, 0)
        patternLEDList(93, 1) = patternLEDList(92, 1)
        patternLEDList(93, 2) = patternLEDList(92, 2)
        Button93.BackColor = Button92.BackColor

        patternLEDList(92, 0) = patternLEDList(91, 0)
        patternLEDList(92, 1) = patternLEDList(91, 1)
        patternLEDList(92, 2) = patternLEDList(91, 2)
        Button92.BackColor = Button91.BackColor

        patternLEDList(91, 0) = patternLEDList(90, 0)
        patternLEDList(91, 1) = patternLEDList(90, 1)
        patternLEDList(91, 2) = patternLEDList(90, 2)
        Button91.BackColor = Button90.BackColor

        patternLEDList(90, 0) = patternLEDList(89, 0)
        patternLEDList(90, 1) = patternLEDList(89, 1)
        patternLEDList(90, 2) = patternLEDList(89, 2)
        Button90.BackColor = Button89.BackColor

        patternLEDList(89, 0) = 0
        patternLEDList(89, 1) = 0
        patternLEDList(89, 2) = 0
        Button89.BackColor = Color.Black

    End Sub
    Sub upc13()
        patternLEDList(97, 0) = patternLEDList(98, 0)
        patternLEDList(97, 1) = patternLEDList(98, 1)
        patternLEDList(97, 2) = patternLEDList(98, 2)
        Button97.BackColor = Button98.BackColor

        patternLEDList(98, 0) = patternLEDList(99, 0)
        patternLEDList(98, 1) = patternLEDList(99, 1)
        patternLEDList(98, 2) = patternLEDList(99, 2)
        Button98.BackColor = Button99.BackColor

        patternLEDList(99, 0) = patternLEDList(100, 0)
        patternLEDList(99, 1) = patternLEDList(100, 1)
        patternLEDList(99, 2) = patternLEDList(100, 2)
        Button99.BackColor = Button100.BackColor

        patternLEDList(100, 0) = patternLEDList(101, 0)
        patternLEDList(100, 1) = patternLEDList(101, 1)
        patternLEDList(100, 2) = patternLEDList(101, 2)
        Button100.BackColor = Button101.BackColor

        patternLEDList(101, 0) = patternLEDList(102, 0)
        patternLEDList(101, 1) = patternLEDList(102, 1)
        patternLEDList(101, 2) = patternLEDList(102, 2)
        Button101.BackColor = Button102.BackColor

        patternLEDList(102, 0) = patternLEDList(103, 0)
        patternLEDList(102, 1) = patternLEDList(103, 1)
        patternLEDList(102, 2) = patternLEDList(103, 2)
        Button102.BackColor = Button103.BackColor

        patternLEDList(103, 0) = patternLEDList(104, 0)
        patternLEDList(103, 1) = patternLEDList(104, 1)
        patternLEDList(103, 2) = patternLEDList(104, 2)
        Button103.BackColor = Button104.BackColor

        patternLEDList(104, 0) = 0
        patternLEDList(104, 1) = 0
        patternLEDList(104, 2) = 0
        Button104.BackColor = Color.Black

    End Sub
    Sub upc14()
        patternLEDList(112, 0) = patternLEDList(111, 0)
        patternLEDList(112, 1) = patternLEDList(111, 1)
        patternLEDList(112, 2) = patternLEDList(111, 2)
        Button112.BackColor = Button111.BackColor

        patternLEDList(111, 0) = patternLEDList(110, 0)
        patternLEDList(111, 1) = patternLEDList(110, 1)
        patternLEDList(111, 2) = patternLEDList(110, 2)
        Button111.BackColor = Button110.BackColor

        patternLEDList(110, 0) = patternLEDList(109, 0)
        patternLEDList(110, 1) = patternLEDList(109, 1)
        patternLEDList(110, 2) = patternLEDList(109, 2)
        Button110.BackColor = Button109.BackColor

        patternLEDList(109, 0) = patternLEDList(108, 0)
        patternLEDList(109, 1) = patternLEDList(108, 1)
        patternLEDList(109, 2) = patternLEDList(108, 2)
        Button109.BackColor = Button108.BackColor

        patternLEDList(108, 0) = patternLEDList(107, 0)
        patternLEDList(108, 1) = patternLEDList(107, 1)
        patternLEDList(108, 2) = patternLEDList(107, 2)
        Button108.BackColor = Button107.BackColor

        patternLEDList(107, 0) = patternLEDList(106, 0)
        patternLEDList(107, 1) = patternLEDList(106, 1)
        patternLEDList(107, 2) = patternLEDList(106, 2)
        Button107.BackColor = Button106.BackColor

        patternLEDList(106, 0) = patternLEDList(105, 0)
        patternLEDList(106, 1) = patternLEDList(105, 1)
        patternLEDList(106, 2) = patternLEDList(105, 2)
        Button106.BackColor = Button105.BackColor

        patternLEDList(105, 0) = 0
        patternLEDList(105, 1) = 0
        patternLEDList(105, 2) = 0
        Button105.BackColor = Color.Black

    End Sub
    Sub upc15()
        patternLEDList(113, 0) = patternLEDList(114, 0)
        patternLEDList(113, 1) = patternLEDList(114, 1)
        patternLEDList(113, 2) = patternLEDList(114, 2)
        Button113.BackColor = Button114.BackColor

        patternLEDList(114, 0) = patternLEDList(115, 0)
        patternLEDList(114, 1) = patternLEDList(115, 1)
        patternLEDList(114, 2) = patternLEDList(115, 2)
        Button114.BackColor = Button115.BackColor

        patternLEDList(115, 0) = patternLEDList(116, 0)
        patternLEDList(115, 1) = patternLEDList(116, 1)
        patternLEDList(115, 2) = patternLEDList(116, 2)
        Button115.BackColor = Button116.BackColor

        patternLEDList(116, 0) = patternLEDList(117, 0)
        patternLEDList(116, 1) = patternLEDList(117, 1)
        patternLEDList(116, 2) = patternLEDList(117, 2)
        Button116.BackColor = Button117.BackColor

        patternLEDList(117, 0) = patternLEDList(118, 0)
        patternLEDList(117, 1) = patternLEDList(118, 1)
        patternLEDList(117, 2) = patternLEDList(118, 2)
        Button117.BackColor = Button118.BackColor

        patternLEDList(118, 0) = patternLEDList(119, 0)
        patternLEDList(118, 1) = patternLEDList(119, 1)
        patternLEDList(118, 2) = patternLEDList(119, 2)
        Button118.BackColor = Button119.BackColor

        patternLEDList(119, 0) = patternLEDList(120, 0)
        patternLEDList(119, 1) = patternLEDList(120, 1)
        patternLEDList(119, 2) = patternLEDList(120, 2)
        Button119.BackColor = Button120.BackColor

        patternLEDList(120, 0) = 0
        patternLEDList(120, 1) = 0
        patternLEDList(120, 2) = 0
        Button120.BackColor = Color.Black

    End Sub
    Sub upc16()
        patternLEDList(128, 0) = patternLEDList(127, 0)
        patternLEDList(128, 1) = patternLEDList(127, 1)
        patternLEDList(128, 2) = patternLEDList(127, 2)
        Button128.BackColor = Button127.BackColor

        patternLEDList(127, 0) = patternLEDList(126, 0)
        patternLEDList(127, 1) = patternLEDList(126, 1)
        patternLEDList(127, 2) = patternLEDList(126, 2)
        Button127.BackColor = Button126.BackColor

        patternLEDList(126, 0) = patternLEDList(125, 0)
        patternLEDList(126, 1) = patternLEDList(125, 1)
        patternLEDList(126, 2) = patternLEDList(125, 2)
        Button126.BackColor = Button125.BackColor

        patternLEDList(125, 0) = patternLEDList(124, 0)
        patternLEDList(125, 1) = patternLEDList(124, 1)
        patternLEDList(125, 2) = patternLEDList(124, 2)
        Button125.BackColor = Button124.BackColor

        patternLEDList(124, 0) = patternLEDList(123, 0)
        patternLEDList(124, 1) = patternLEDList(123, 1)
        patternLEDList(124, 2) = patternLEDList(123, 2)
        Button124.BackColor = Button123.BackColor

        patternLEDList(123, 0) = patternLEDList(122, 0)
        patternLEDList(123, 1) = patternLEDList(122, 1)
        patternLEDList(123, 2) = patternLEDList(122, 2)
        Button123.BackColor = Button122.BackColor

        patternLEDList(122, 0) = patternLEDList(121, 0)
        patternLEDList(122, 1) = patternLEDList(121, 1)
        patternLEDList(122, 2) = patternLEDList(121, 2)
        Button122.BackColor = Button121.BackColor

        patternLEDList(121, 0) = 0
        patternLEDList(121, 1) = 0
        patternLEDList(121, 2) = 0
        Button121.BackColor = Color.Black

    End Sub
    Sub upc17()
        patternLEDList(129, 0) = patternLEDList(130, 0)
        patternLEDList(129, 1) = patternLEDList(130, 1)
        patternLEDList(129, 2) = patternLEDList(130, 2)
        Button129.BackColor = Button130.BackColor

        patternLEDList(130, 0) = patternLEDList(131, 0)
        patternLEDList(130, 1) = patternLEDList(131, 1)
        patternLEDList(130, 2) = patternLEDList(131, 2)
        Button130.BackColor = Button131.BackColor

        patternLEDList(131, 0) = patternLEDList(132, 0)
        patternLEDList(131, 1) = patternLEDList(132, 1)
        patternLEDList(131, 2) = patternLEDList(132, 2)
        Button131.BackColor = Button132.BackColor

        patternLEDList(132, 0) = patternLEDList(133, 0)
        patternLEDList(132, 1) = patternLEDList(133, 1)
        patternLEDList(132, 2) = patternLEDList(133, 2)
        Button132.BackColor = Button133.BackColor

        patternLEDList(133, 0) = patternLEDList(134, 0)
        patternLEDList(133, 1) = patternLEDList(134, 1)
        patternLEDList(133, 2) = patternLEDList(134, 2)
        Button133.BackColor = Button134.BackColor

        patternLEDList(134, 0) = patternLEDList(135, 0)
        patternLEDList(134, 1) = patternLEDList(135, 1)
        patternLEDList(134, 2) = patternLEDList(135, 2)
        Button134.BackColor = Button135.BackColor

        patternLEDList(135, 0) = patternLEDList(136, 0)
        patternLEDList(135, 1) = patternLEDList(136, 1)
        patternLEDList(135, 2) = patternLEDList(136, 2)
        Button135.BackColor = Button136.BackColor

        patternLEDList(136, 0) = 0
        patternLEDList(136, 1) = 0
        patternLEDList(136, 2) = 0
        Button136.BackColor = Color.Black

    End Sub
    Sub upc18()
        patternLEDList(144, 0) = patternLEDList(143, 0)
        patternLEDList(144, 1) = patternLEDList(143, 1)
        patternLEDList(144, 2) = patternLEDList(143, 2)
        Button144.BackColor = Button143.BackColor

        patternLEDList(143, 0) = patternLEDList(142, 0)
        patternLEDList(143, 1) = patternLEDList(142, 1)
        patternLEDList(143, 2) = patternLEDList(142, 2)
        Button143.BackColor = Button142.BackColor

        patternLEDList(142, 0) = patternLEDList(141, 0)
        patternLEDList(142, 1) = patternLEDList(141, 1)
        patternLEDList(142, 2) = patternLEDList(141, 2)
        Button142.BackColor = Button141.BackColor

        patternLEDList(141, 0) = patternLEDList(140, 0)
        patternLEDList(141, 1) = patternLEDList(140, 1)
        patternLEDList(141, 2) = patternLEDList(140, 2)
        Button141.BackColor = Button140.BackColor

        patternLEDList(140, 0) = patternLEDList(139, 0)
        patternLEDList(140, 1) = patternLEDList(139, 1)
        patternLEDList(140, 2) = patternLEDList(139, 2)
        Button140.BackColor = Button139.BackColor

        patternLEDList(139, 0) = patternLEDList(138, 0)
        patternLEDList(139, 1) = patternLEDList(138, 1)
        patternLEDList(139, 2) = patternLEDList(138, 2)
        Button139.BackColor = Button138.BackColor

        patternLEDList(138, 0) = patternLEDList(137, 0)
        patternLEDList(138, 1) = patternLEDList(137, 1)
        patternLEDList(138, 2) = patternLEDList(137, 2)
        Button138.BackColor = Button137.BackColor

        patternLEDList(137, 0) = 0
        patternLEDList(137, 1) = 0
        patternLEDList(137, 2) = 0
        Button137.BackColor = Color.Black

    End Sub
    Sub upc19()
        patternLEDList(145, 0) = patternLEDList(146, 0)
        patternLEDList(145, 1) = patternLEDList(146, 1)
        patternLEDList(145, 2) = patternLEDList(146, 2)
        Button145.BackColor = Button146.BackColor

        patternLEDList(146, 0) = patternLEDList(147, 0)
        patternLEDList(146, 1) = patternLEDList(147, 1)
        patternLEDList(146, 2) = patternLEDList(147, 2)
        Button146.BackColor = Button147.BackColor

        patternLEDList(147, 0) = patternLEDList(148, 0)
        patternLEDList(147, 1) = patternLEDList(148, 1)
        patternLEDList(147, 2) = patternLEDList(148, 2)
        Button147.BackColor = Button148.BackColor

        patternLEDList(148, 0) = patternLEDList(149, 0)
        patternLEDList(148, 1) = patternLEDList(149, 1)
        patternLEDList(148, 2) = patternLEDList(149, 2)
        Button148.BackColor = Button149.BackColor

        patternLEDList(149, 0) = patternLEDList(150, 0)
        patternLEDList(149, 1) = patternLEDList(150, 1)
        patternLEDList(149, 2) = patternLEDList(150, 2)
        Button149.BackColor = Button150.BackColor

        patternLEDList(150, 0) = patternLEDList(151, 0)
        patternLEDList(150, 1) = patternLEDList(151, 1)
        patternLEDList(150, 2) = patternLEDList(151, 2)
        Button150.BackColor = Button151.BackColor

        patternLEDList(151, 0) = patternLEDList(152, 0)
        patternLEDList(151, 1) = patternLEDList(152, 1)
        patternLEDList(151, 2) = patternLEDList(152, 2)
        Button151.BackColor = Button152.BackColor

        patternLEDList(152, 0) = 0
        patternLEDList(152, 1) = 0
        patternLEDList(152, 2) = 0
        Button152.BackColor = Color.Black

    End Sub
    Sub upc20()
        patternLEDList(160, 0) = patternLEDList(159, 0)
        patternLEDList(160, 1) = patternLEDList(159, 1)
        patternLEDList(160, 2) = patternLEDList(159, 2)
        Button160.BackColor = Button159.BackColor

        patternLEDList(159, 0) = patternLEDList(158, 0)
        patternLEDList(159, 1) = patternLEDList(158, 1)
        patternLEDList(159, 2) = patternLEDList(158, 2)
        Button159.BackColor = Button158.BackColor

        patternLEDList(158, 0) = patternLEDList(157, 0)
        patternLEDList(158, 1) = patternLEDList(157, 1)
        patternLEDList(158, 2) = patternLEDList(157, 2)
        Button158.BackColor = Button157.BackColor

        patternLEDList(157, 0) = patternLEDList(156, 0)
        patternLEDList(157, 1) = patternLEDList(156, 1)
        patternLEDList(157, 2) = patternLEDList(156, 2)
        Button157.BackColor = Button156.BackColor

        patternLEDList(156, 0) = patternLEDList(155, 0)
        patternLEDList(156, 1) = patternLEDList(155, 1)
        patternLEDList(156, 2) = patternLEDList(155, 2)
        Button156.BackColor = Button155.BackColor

        patternLEDList(155, 0) = patternLEDList(154, 0)
        patternLEDList(155, 1) = patternLEDList(154, 1)
        patternLEDList(155, 2) = patternLEDList(154, 2)
        Button155.BackColor = Button154.BackColor

        patternLEDList(154, 0) = patternLEDList(153, 0)
        patternLEDList(154, 1) = patternLEDList(153, 1)
        patternLEDList(154, 2) = patternLEDList(153, 2)
        Button154.BackColor = Button153.BackColor

        patternLEDList(153, 0) = 0
        patternLEDList(153, 1) = 0
        patternLEDList(153, 2) = 0
        Button153.BackColor = Color.Black

    End Sub
    Sub upc21()
        patternLEDList(161, 0) = patternLEDList(162, 0)
        patternLEDList(161, 1) = patternLEDList(162, 1)
        patternLEDList(161, 2) = patternLEDList(162, 2)
        Button161.BackColor = Button162.BackColor

        patternLEDList(162, 0) = patternLEDList(163, 0)
        patternLEDList(162, 1) = patternLEDList(163, 1)
        patternLEDList(162, 2) = patternLEDList(163, 2)
        Button162.BackColor = Button163.BackColor

        patternLEDList(163, 0) = patternLEDList(164, 0)
        patternLEDList(163, 1) = patternLEDList(164, 1)
        patternLEDList(163, 2) = patternLEDList(164, 2)
        Button163.BackColor = Button164.BackColor

        patternLEDList(164, 0) = patternLEDList(165, 0)
        patternLEDList(164, 1) = patternLEDList(165, 1)
        patternLEDList(164, 2) = patternLEDList(165, 2)
        Button164.BackColor = Button165.BackColor

        patternLEDList(165, 0) = patternLEDList(166, 0)
        patternLEDList(165, 1) = patternLEDList(166, 1)
        patternLEDList(165, 2) = patternLEDList(166, 2)
        Button165.BackColor = Button166.BackColor

        patternLEDList(166, 0) = patternLEDList(167, 0)
        patternLEDList(166, 1) = patternLEDList(167, 1)
        patternLEDList(166, 2) = patternLEDList(167, 2)
        Button166.BackColor = Button167.BackColor

        patternLEDList(167, 0) = patternLEDList(168, 0)
        patternLEDList(167, 1) = patternLEDList(168, 1)
        patternLEDList(167, 2) = patternLEDList(168, 2)
        Button167.BackColor = Button168.BackColor

        patternLEDList(168, 0) = 0
        patternLEDList(168, 1) = 0
        patternLEDList(168, 2) = 0
        Button168.BackColor = Color.Black

    End Sub
    Sub upc22()
        patternLEDList(176, 0) = patternLEDList(175, 0)
        patternLEDList(176, 1) = patternLEDList(175, 1)
        patternLEDList(176, 2) = patternLEDList(175, 2)
        Button176.BackColor = Button175.BackColor

        patternLEDList(175, 0) = patternLEDList(174, 0)
        patternLEDList(175, 1) = patternLEDList(174, 1)
        patternLEDList(175, 2) = patternLEDList(174, 2)
        Button175.BackColor = Button174.BackColor

        patternLEDList(174, 0) = patternLEDList(173, 0)
        patternLEDList(174, 1) = patternLEDList(173, 1)
        patternLEDList(174, 2) = patternLEDList(173, 2)
        Button174.BackColor = Button173.BackColor

        patternLEDList(173, 0) = patternLEDList(172, 0)
        patternLEDList(173, 1) = patternLEDList(172, 1)
        patternLEDList(173, 2) = patternLEDList(172, 2)
        Button173.BackColor = Button172.BackColor

        patternLEDList(172, 0) = patternLEDList(171, 0)
        patternLEDList(172, 1) = patternLEDList(171, 1)
        patternLEDList(172, 2) = patternLEDList(171, 2)
        Button172.BackColor = Button171.BackColor

        patternLEDList(171, 0) = patternLEDList(170, 0)
        patternLEDList(171, 1) = patternLEDList(170, 1)
        patternLEDList(171, 2) = patternLEDList(170, 2)
        Button171.BackColor = Button170.BackColor

        patternLEDList(170, 0) = patternLEDList(169, 0)
        patternLEDList(170, 1) = patternLEDList(169, 1)
        patternLEDList(170, 2) = patternLEDList(169, 2)
        Button170.BackColor = Button169.BackColor

        patternLEDList(169, 0) = 0
        patternLEDList(169, 1) = 0
        patternLEDList(169, 2) = 0
        Button169.BackColor = Color.Black

    End Sub
    Sub upc23()
        patternLEDList(177, 0) = patternLEDList(178, 0)
        patternLEDList(177, 1) = patternLEDList(178, 1)
        patternLEDList(177, 2) = patternLEDList(178, 2)
        Button177.BackColor = Button178.BackColor

        patternLEDList(178, 0) = patternLEDList(179, 0)
        patternLEDList(178, 1) = patternLEDList(179, 1)
        patternLEDList(178, 2) = patternLEDList(179, 2)
        Button178.BackColor = Button179.BackColor

        patternLEDList(179, 0) = patternLEDList(180, 0)
        patternLEDList(179, 1) = patternLEDList(180, 1)
        patternLEDList(179, 2) = patternLEDList(180, 2)
        Button179.BackColor = Button180.BackColor

        patternLEDList(180, 0) = patternLEDList(181, 0)
        patternLEDList(180, 1) = patternLEDList(181, 1)
        patternLEDList(180, 2) = patternLEDList(181, 2)
        Button180.BackColor = Button181.BackColor

        patternLEDList(181, 0) = patternLEDList(182, 0)
        patternLEDList(181, 1) = patternLEDList(182, 1)
        patternLEDList(181, 2) = patternLEDList(182, 2)
        Button181.BackColor = Button182.BackColor

        patternLEDList(182, 0) = patternLEDList(183, 0)
        patternLEDList(182, 1) = patternLEDList(183, 1)
        patternLEDList(182, 2) = patternLEDList(183, 2)
        Button182.BackColor = Button183.BackColor

        patternLEDList(183, 0) = patternLEDList(184, 0)
        patternLEDList(183, 1) = patternLEDList(184, 1)
        patternLEDList(183, 2) = patternLEDList(184, 2)
        Button183.BackColor = Button184.BackColor

        patternLEDList(184, 0) = 0
        patternLEDList(184, 1) = 0
        patternLEDList(184, 2) = 0
        Button184.BackColor = Color.Black

    End Sub
    Sub upc24()
        patternLEDList(192, 0) = patternLEDList(191, 0)
        patternLEDList(192, 1) = patternLEDList(191, 1)
        patternLEDList(192, 2) = patternLEDList(191, 2)
        Button192.BackColor = Button191.BackColor

        patternLEDList(191, 0) = patternLEDList(190, 0)
        patternLEDList(191, 1) = patternLEDList(190, 1)
        patternLEDList(191, 2) = patternLEDList(190, 2)
        Button191.BackColor = Button190.BackColor

        patternLEDList(190, 0) = patternLEDList(189, 0)
        patternLEDList(190, 1) = patternLEDList(189, 1)
        patternLEDList(190, 2) = patternLEDList(189, 2)
        Button190.BackColor = Button189.BackColor

        patternLEDList(189, 0) = patternLEDList(188, 0)
        patternLEDList(189, 1) = patternLEDList(188, 1)
        patternLEDList(189, 2) = patternLEDList(188, 2)
        Button189.BackColor = Button188.BackColor

        patternLEDList(188, 0) = patternLEDList(187, 0)
        patternLEDList(188, 1) = patternLEDList(187, 1)
        patternLEDList(188, 2) = patternLEDList(187, 2)
        Button188.BackColor = Button187.BackColor

        patternLEDList(187, 0) = patternLEDList(186, 0)
        patternLEDList(187, 1) = patternLEDList(186, 1)
        patternLEDList(187, 2) = patternLEDList(186, 2)
        Button187.BackColor = Button186.BackColor

        patternLEDList(186, 0) = patternLEDList(185, 0)
        patternLEDList(186, 1) = patternLEDList(185, 1)
        patternLEDList(186, 2) = patternLEDList(185, 2)
        Button186.BackColor = Button185.BackColor

        patternLEDList(185, 0) = 0
        patternLEDList(185, 1) = 0
        patternLEDList(185, 2) = 0
        Button185.BackColor = Color.Black

    End Sub
    Sub upc25()
        patternLEDList(193, 0) = patternLEDList(194, 0)
        patternLEDList(193, 1) = patternLEDList(194, 1)
        patternLEDList(193, 2) = patternLEDList(194, 2)
        Button193.BackColor = Button194.BackColor

        patternLEDList(194, 0) = patternLEDList(195, 0)
        patternLEDList(194, 1) = patternLEDList(195, 1)
        patternLEDList(194, 2) = patternLEDList(195, 2)
        Button194.BackColor = Button195.BackColor

        patternLEDList(195, 0) = patternLEDList(196, 0)
        patternLEDList(195, 1) = patternLEDList(196, 1)
        patternLEDList(195, 2) = patternLEDList(196, 2)
        Button195.BackColor = Button196.BackColor

        patternLEDList(196, 0) = patternLEDList(197, 0)
        patternLEDList(196, 1) = patternLEDList(197, 1)
        patternLEDList(196, 2) = patternLEDList(197, 2)
        Button196.BackColor = Button197.BackColor

        patternLEDList(197, 0) = patternLEDList(198, 0)
        patternLEDList(197, 1) = patternLEDList(198, 1)
        patternLEDList(197, 2) = patternLEDList(198, 2)
        Button197.BackColor = Button198.BackColor

        patternLEDList(198, 0) = patternLEDList(199, 0)
        patternLEDList(198, 1) = patternLEDList(199, 1)
        patternLEDList(198, 2) = patternLEDList(199, 2)
        Button198.BackColor = Button199.BackColor

        patternLEDList(199, 0) = patternLEDList(200, 0)
        patternLEDList(199, 1) = patternLEDList(200, 1)
        patternLEDList(199, 2) = patternLEDList(200, 2)
        Button199.BackColor = Button200.BackColor

        patternLEDList(200, 0) = 0
        patternLEDList(200, 1) = 0
        patternLEDList(200, 2) = 0
        Button200.BackColor = Color.Black

    End Sub

    Sub downc1()
        patternLEDList(8, 0) = patternLEDList(7, 0)
        patternLEDList(8, 1) = patternLEDList(7, 1)
        patternLEDList(8, 2) = patternLEDList(7, 2)
        Button8.BackColor = Button7.BackColor

        patternLEDList(7, 0) = patternLEDList(6, 0)
        patternLEDList(7, 1) = patternLEDList(6, 1)
        patternLEDList(7, 2) = patternLEDList(6, 2)
        Button7.BackColor = Button6.BackColor

        patternLEDList(6, 0) = patternLEDList(5, 0)
        patternLEDList(6, 1) = patternLEDList(5, 1)
        patternLEDList(6, 2) = patternLEDList(5, 2)
        Button6.BackColor = Button5.BackColor

        patternLEDList(5, 0) = patternLEDList(4, 0)
        patternLEDList(5, 1) = patternLEDList(4, 1)
        patternLEDList(5, 2) = patternLEDList(4, 2)
        Button5.BackColor = Button4.BackColor

        patternLEDList(4, 0) = patternLEDList(3, 0)
        patternLEDList(4, 1) = patternLEDList(3, 1)
        patternLEDList(4, 2) = patternLEDList(3, 2)
        Button4.BackColor = Button3.BackColor

        patternLEDList(3, 0) = patternLEDList(2, 0)
        patternLEDList(3, 1) = patternLEDList(2, 1)
        patternLEDList(3, 2) = patternLEDList(2, 2)
        Button3.BackColor = Button2.BackColor

        patternLEDList(2, 0) = patternLEDList(1, 0)
        patternLEDList(2, 1) = patternLEDList(1, 1)
        patternLEDList(2, 2) = patternLEDList(1, 2)
        Button2.BackColor = Button1.BackColor

        patternLEDList(1, 0) = 0
        patternLEDList(1, 1) = 0
        patternLEDList(1, 2) = 0
        Button1.BackColor = Color.Black
    End Sub
    Sub downc2()
        patternLEDList(9, 0) = patternLEDList(10, 0)
        patternLEDList(9, 1) = patternLEDList(10, 1)
        patternLEDList(9, 2) = patternLEDList(10, 2)
        Button9.BackColor = Button10.BackColor

        patternLEDList(10, 0) = patternLEDList(11, 0)
        patternLEDList(10, 1) = patternLEDList(11, 1)
        patternLEDList(10, 2) = patternLEDList(11, 2)
        Button10.BackColor = Button11.BackColor

        patternLEDList(11, 0) = patternLEDList(12, 0)
        patternLEDList(11, 1) = patternLEDList(12, 1)
        patternLEDList(11, 2) = patternLEDList(12, 2)
        Button11.BackColor = Button12.BackColor

        patternLEDList(12, 0) = patternLEDList(13, 0)
        patternLEDList(12, 1) = patternLEDList(13, 1)
        patternLEDList(12, 2) = patternLEDList(13, 2)
        Button12.BackColor = Button13.BackColor

        patternLEDList(13, 0) = patternLEDList(14, 0)
        patternLEDList(13, 1) = patternLEDList(14, 1)
        patternLEDList(13, 2) = patternLEDList(14, 2)
        Button13.BackColor = Button14.BackColor

        patternLEDList(14, 0) = patternLEDList(15, 0)
        patternLEDList(14, 1) = patternLEDList(15, 1)
        patternLEDList(14, 2) = patternLEDList(15, 2)
        Button14.BackColor = Button15.BackColor

        patternLEDList(15, 0) = patternLEDList(16, 0)
        patternLEDList(15, 1) = patternLEDList(16, 1)
        patternLEDList(15, 2) = patternLEDList(16, 2)
        Button15.BackColor = Button16.BackColor

        patternLEDList(16, 0) = 0
        patternLEDList(16, 1) = 0
        patternLEDList(16, 2) = 0
        Button16.BackColor = Color.Black
    End Sub
    Sub downc3()
        patternLEDList(24, 0) = patternLEDList(23, 0)
        patternLEDList(24, 1) = patternLEDList(23, 1)
        patternLEDList(24, 2) = patternLEDList(23, 2)
        Button24.BackColor = Button23.BackColor

        patternLEDList(23, 0) = patternLEDList(22, 0)
        patternLEDList(23, 1) = patternLEDList(22, 1)
        patternLEDList(23, 2) = patternLEDList(22, 2)
        Button23.BackColor = Button22.BackColor

        patternLEDList(22, 0) = patternLEDList(21, 0)
        patternLEDList(22, 1) = patternLEDList(21, 1)
        patternLEDList(22, 2) = patternLEDList(21, 2)
        Button22.BackColor = Button21.BackColor

        patternLEDList(21, 0) = patternLEDList(20, 0)
        patternLEDList(21, 1) = patternLEDList(20, 1)
        patternLEDList(21, 2) = patternLEDList(20, 2)
        Button21.BackColor = Button20.BackColor

        patternLEDList(20, 0) = patternLEDList(19, 0)
        patternLEDList(20, 1) = patternLEDList(19, 1)
        patternLEDList(20, 2) = patternLEDList(19, 2)
        Button20.BackColor = Button19.BackColor

        patternLEDList(19, 0) = patternLEDList(18, 0)
        patternLEDList(19, 1) = patternLEDList(18, 1)
        patternLEDList(19, 2) = patternLEDList(18, 2)
        Button19.BackColor = Button18.BackColor

        patternLEDList(18, 0) = patternLEDList(17, 0)
        patternLEDList(18, 1) = patternLEDList(17, 1)
        patternLEDList(18, 2) = patternLEDList(17, 2)
        Button18.BackColor = Button17.BackColor

        patternLEDList(17, 0) = 0
        patternLEDList(17, 1) = 0
        patternLEDList(17, 2) = 0
        Button17.BackColor = Color.Black
    End Sub
    Sub downc4()
        patternLEDList(25, 0) = patternLEDList(26, 0)
        patternLEDList(25, 1) = patternLEDList(26, 1)
        patternLEDList(25, 2) = patternLEDList(26, 2)
        Button25.BackColor = Button26.BackColor

        patternLEDList(26, 0) = patternLEDList(27, 0)
        patternLEDList(26, 1) = patternLEDList(27, 1)
        patternLEDList(26, 2) = patternLEDList(27, 2)
        Button26.BackColor = Button27.BackColor

        patternLEDList(27, 0) = patternLEDList(28, 0)
        patternLEDList(27, 1) = patternLEDList(28, 1)
        patternLEDList(27, 2) = patternLEDList(28, 2)
        Button27.BackColor = Button28.BackColor

        patternLEDList(28, 0) = patternLEDList(29, 0)
        patternLEDList(28, 1) = patternLEDList(29, 1)
        patternLEDList(28, 2) = patternLEDList(29, 2)
        Button28.BackColor = Button29.BackColor

        patternLEDList(29, 0) = patternLEDList(30, 0)
        patternLEDList(29, 1) = patternLEDList(30, 1)
        patternLEDList(29, 2) = patternLEDList(30, 2)
        Button29.BackColor = Button30.BackColor

        patternLEDList(30, 0) = patternLEDList(31, 0)
        patternLEDList(30, 1) = patternLEDList(31, 1)
        patternLEDList(30, 2) = patternLEDList(31, 2)
        Button30.BackColor = Button31.BackColor

        patternLEDList(31, 0) = patternLEDList(32, 0)
        patternLEDList(31, 1) = patternLEDList(32, 1)
        patternLEDList(31, 2) = patternLEDList(32, 2)
        Button31.BackColor = Button32.BackColor

        patternLEDList(32, 0) = 0
        patternLEDList(32, 1) = 0
        patternLEDList(32, 2) = 0
        Button32.BackColor = Color.Black
    End Sub
    Sub downc5()
        patternLEDList(40, 0) = patternLEDList(39, 0)
        patternLEDList(40, 1) = patternLEDList(39, 1)
        patternLEDList(40, 2) = patternLEDList(39, 2)
        Button40.BackColor = Button39.BackColor

        patternLEDList(39, 0) = patternLEDList(38, 0)
        patternLEDList(39, 1) = patternLEDList(38, 1)
        patternLEDList(39, 2) = patternLEDList(38, 2)
        Button39.BackColor = Button38.BackColor

        patternLEDList(38, 0) = patternLEDList(37, 0)
        patternLEDList(38, 1) = patternLEDList(37, 1)
        patternLEDList(38, 2) = patternLEDList(37, 2)
        Button38.BackColor = Button37.BackColor

        patternLEDList(37, 0) = patternLEDList(36, 0)
        patternLEDList(37, 1) = patternLEDList(36, 1)
        patternLEDList(37, 2) = patternLEDList(36, 2)
        Button37.BackColor = Button36.BackColor

        patternLEDList(36, 0) = patternLEDList(35, 0)
        patternLEDList(36, 1) = patternLEDList(35, 1)
        patternLEDList(36, 2) = patternLEDList(35, 2)
        Button36.BackColor = Button35.BackColor

        patternLEDList(35, 0) = patternLEDList(34, 0)
        patternLEDList(35, 1) = patternLEDList(34, 1)
        patternLEDList(35, 2) = patternLEDList(34, 2)
        Button35.BackColor = Button34.BackColor

        patternLEDList(34, 0) = patternLEDList(33, 0)
        patternLEDList(34, 1) = patternLEDList(33, 1)
        patternLEDList(34, 2) = patternLEDList(33, 2)
        Button34.BackColor = Button33.BackColor

        patternLEDList(33, 0) = 0
        patternLEDList(33, 1) = 0
        patternLEDList(33, 2) = 0
        Button33.BackColor = Color.Black
    End Sub
    Sub downc6()
        patternLEDList(41, 0) = patternLEDList(42, 0)
        patternLEDList(41, 1) = patternLEDList(42, 1)
        patternLEDList(41, 2) = patternLEDList(42, 2)
        Button41.BackColor = Button42.BackColor

        patternLEDList(42, 0) = patternLEDList(43, 0)
        patternLEDList(42, 1) = patternLEDList(43, 1)
        patternLEDList(42, 2) = patternLEDList(43, 2)
        Button42.BackColor = Button43.BackColor

        patternLEDList(43, 0) = patternLEDList(44, 0)
        patternLEDList(43, 1) = patternLEDList(44, 1)
        patternLEDList(43, 2) = patternLEDList(44, 2)
        Button43.BackColor = Button44.BackColor

        patternLEDList(44, 0) = patternLEDList(45, 0)
        patternLEDList(44, 1) = patternLEDList(45, 1)
        patternLEDList(44, 2) = patternLEDList(45, 2)
        Button44.BackColor = Button45.BackColor

        patternLEDList(45, 0) = patternLEDList(46, 0)
        patternLEDList(45, 1) = patternLEDList(46, 1)
        patternLEDList(45, 2) = patternLEDList(46, 2)
        Button45.BackColor = Button46.BackColor

        patternLEDList(46, 0) = patternLEDList(47, 0)
        patternLEDList(46, 1) = patternLEDList(47, 1)
        patternLEDList(46, 2) = patternLEDList(47, 2)
        Button46.BackColor = Button47.BackColor

        patternLEDList(47, 0) = patternLEDList(48, 0)
        patternLEDList(47, 1) = patternLEDList(48, 1)
        patternLEDList(47, 2) = patternLEDList(48, 2)
        Button47.BackColor = Button48.BackColor

        patternLEDList(48, 0) = 0
        patternLEDList(48, 1) = 0
        patternLEDList(48, 2) = 0
        Button48.BackColor = Color.Black
    End Sub
    Sub downc7()
        patternLEDList(56, 0) = patternLEDList(55, 0)
        patternLEDList(56, 1) = patternLEDList(55, 1)
        patternLEDList(56, 2) = patternLEDList(55, 2)
        Button56.BackColor = Button55.BackColor

        patternLEDList(55, 0) = patternLEDList(54, 0)
        patternLEDList(55, 1) = patternLEDList(54, 1)
        patternLEDList(55, 2) = patternLEDList(54, 2)
        Button55.BackColor = Button54.BackColor

        patternLEDList(54, 0) = patternLEDList(53, 0)
        patternLEDList(54, 1) = patternLEDList(53, 1)
        patternLEDList(54, 2) = patternLEDList(53, 2)
        Button54.BackColor = Button53.BackColor

        patternLEDList(53, 0) = patternLEDList(52, 0)
        patternLEDList(53, 1) = patternLEDList(52, 1)
        patternLEDList(53, 2) = patternLEDList(52, 2)
        Button53.BackColor = Button52.BackColor

        patternLEDList(52, 0) = patternLEDList(51, 0)
        patternLEDList(52, 1) = patternLEDList(51, 1)
        patternLEDList(52, 2) = patternLEDList(51, 2)
        Button52.BackColor = Button51.BackColor

        patternLEDList(51, 0) = patternLEDList(50, 0)
        patternLEDList(51, 1) = patternLEDList(50, 1)
        patternLEDList(51, 2) = patternLEDList(50, 2)
        Button51.BackColor = Button50.BackColor

        patternLEDList(50, 0) = patternLEDList(49, 0)
        patternLEDList(50, 1) = patternLEDList(49, 1)
        patternLEDList(50, 2) = patternLEDList(49, 2)
        Button50.BackColor = Button49.BackColor

        patternLEDList(49, 0) = 0
        patternLEDList(49, 1) = 0
        patternLEDList(49, 2) = 0
        Button49.BackColor = Color.Black
    End Sub
    Sub downc8()
        patternLEDList(57, 0) = patternLEDList(58, 0)
        patternLEDList(57, 1) = patternLEDList(58, 1)
        patternLEDList(57, 2) = patternLEDList(58, 2)
        Button57.BackColor = Button58.BackColor

        patternLEDList(58, 0) = patternLEDList(59, 0)
        patternLEDList(58, 1) = patternLEDList(59, 1)
        patternLEDList(58, 2) = patternLEDList(59, 2)
        Button58.BackColor = Button59.BackColor

        patternLEDList(59, 0) = patternLEDList(60, 0)
        patternLEDList(59, 1) = patternLEDList(60, 1)
        patternLEDList(59, 2) = patternLEDList(60, 2)
        Button59.BackColor = Button60.BackColor

        patternLEDList(60, 0) = patternLEDList(61, 0)
        patternLEDList(60, 1) = patternLEDList(61, 1)
        patternLEDList(60, 2) = patternLEDList(61, 2)
        Button60.BackColor = Button61.BackColor

        patternLEDList(61, 0) = patternLEDList(62, 0)
        patternLEDList(61, 1) = patternLEDList(62, 1)
        patternLEDList(61, 2) = patternLEDList(62, 2)
        Button61.BackColor = Button62.BackColor

        patternLEDList(62, 0) = patternLEDList(63, 0)
        patternLEDList(62, 1) = patternLEDList(63, 1)
        patternLEDList(62, 2) = patternLEDList(63, 2)
        Button62.BackColor = Button63.BackColor

        patternLEDList(63, 0) = patternLEDList(64, 0)
        patternLEDList(63, 1) = patternLEDList(64, 1)
        patternLEDList(63, 2) = patternLEDList(64, 2)
        Button63.BackColor = Button64.BackColor

        patternLEDList(64, 0) = 0
        patternLEDList(64, 1) = 0
        patternLEDList(64, 2) = 0
        Button64.BackColor = Color.Black
    End Sub
    Sub downc9()
        patternLEDList(72, 0) = patternLEDList(71, 0)
        patternLEDList(72, 1) = patternLEDList(71, 1)
        patternLEDList(72, 2) = patternLEDList(71, 2)
        Button72.BackColor = Button71.BackColor

        patternLEDList(71, 0) = patternLEDList(70, 0)
        patternLEDList(71, 1) = patternLEDList(70, 1)
        patternLEDList(71, 2) = patternLEDList(70, 2)
        Button71.BackColor = Button70.BackColor

        patternLEDList(70, 0) = patternLEDList(69, 0)
        patternLEDList(70, 1) = patternLEDList(69, 1)
        patternLEDList(70, 2) = patternLEDList(69, 2)
        Button70.BackColor = Button69.BackColor

        patternLEDList(69, 0) = patternLEDList(68, 0)
        patternLEDList(69, 1) = patternLEDList(68, 1)
        patternLEDList(69, 2) = patternLEDList(68, 2)
        Button69.BackColor = Button68.BackColor

        patternLEDList(68, 0) = patternLEDList(67, 0)
        patternLEDList(68, 1) = patternLEDList(67, 1)
        patternLEDList(68, 2) = patternLEDList(67, 2)
        Button68.BackColor = Button67.BackColor

        patternLEDList(67, 0) = patternLEDList(66, 0)
        patternLEDList(67, 1) = patternLEDList(66, 1)
        patternLEDList(67, 2) = patternLEDList(66, 2)
        Button67.BackColor = Button66.BackColor

        patternLEDList(66, 0) = patternLEDList(65, 0)
        patternLEDList(66, 1) = patternLEDList(65, 1)
        patternLEDList(66, 2) = patternLEDList(65, 2)
        Button66.BackColor = Button65.BackColor

        patternLEDList(65, 0) = 0
        patternLEDList(65, 1) = 0
        patternLEDList(65, 2) = 0
        Button65.BackColor = Color.Black
    End Sub
    Sub downc10()
        patternLEDList(73, 0) = patternLEDList(74, 0)
        patternLEDList(73, 1) = patternLEDList(74, 1)
        patternLEDList(73, 2) = patternLEDList(74, 2)
        Button73.BackColor = Button74.BackColor

        patternLEDList(74, 0) = patternLEDList(75, 0)
        patternLEDList(74, 1) = patternLEDList(75, 1)
        patternLEDList(74, 2) = patternLEDList(75, 2)
        Button74.BackColor = Button75.BackColor

        patternLEDList(75, 0) = patternLEDList(76, 0)
        patternLEDList(75, 1) = patternLEDList(76, 1)
        patternLEDList(75, 2) = patternLEDList(76, 2)
        Button75.BackColor = Button76.BackColor

        patternLEDList(76, 0) = patternLEDList(77, 0)
        patternLEDList(76, 1) = patternLEDList(77, 1)
        patternLEDList(76, 2) = patternLEDList(77, 2)
        Button76.BackColor = Button77.BackColor

        patternLEDList(77, 0) = patternLEDList(78, 0)
        patternLEDList(77, 1) = patternLEDList(78, 1)
        patternLEDList(77, 2) = patternLEDList(78, 2)
        Button77.BackColor = Button78.BackColor

        patternLEDList(78, 0) = patternLEDList(79, 0)
        patternLEDList(78, 1) = patternLEDList(79, 1)
        patternLEDList(78, 2) = patternLEDList(79, 2)
        Button78.BackColor = Button79.BackColor

        patternLEDList(79, 0) = patternLEDList(80, 0)
        patternLEDList(79, 1) = patternLEDList(80, 1)
        patternLEDList(79, 2) = patternLEDList(80, 2)
        Button79.BackColor = Button80.BackColor

        patternLEDList(80, 0) = 0
        patternLEDList(80, 1) = 0
        patternLEDList(80, 2) = 0
        Button80.BackColor = Color.Black
    End Sub
    Sub downc11()
        patternLEDList(88, 0) = patternLEDList(87, 0)
        patternLEDList(88, 1) = patternLEDList(87, 1)
        patternLEDList(88, 2) = patternLEDList(87, 2)
        Button88.BackColor = Button87.BackColor

        patternLEDList(87, 0) = patternLEDList(86, 0)
        patternLEDList(87, 1) = patternLEDList(86, 1)
        patternLEDList(87, 2) = patternLEDList(86, 2)
        Button87.BackColor = Button86.BackColor

        patternLEDList(86, 0) = patternLEDList(85, 0)
        patternLEDList(86, 1) = patternLEDList(85, 1)
        patternLEDList(86, 2) = patternLEDList(85, 2)
        Button86.BackColor = Button85.BackColor

        patternLEDList(85, 0) = patternLEDList(84, 0)
        patternLEDList(85, 1) = patternLEDList(84, 1)
        patternLEDList(85, 2) = patternLEDList(84, 2)
        Button85.BackColor = Button84.BackColor

        patternLEDList(84, 0) = patternLEDList(83, 0)
        patternLEDList(84, 1) = patternLEDList(83, 1)
        patternLEDList(84, 2) = patternLEDList(83, 2)
        Button84.BackColor = Button83.BackColor

        patternLEDList(83, 0) = patternLEDList(82, 0)
        patternLEDList(83, 1) = patternLEDList(82, 1)
        patternLEDList(83, 2) = patternLEDList(82, 2)
        Button83.BackColor = Button82.BackColor

        patternLEDList(82, 0) = patternLEDList(81, 0)
        patternLEDList(82, 1) = patternLEDList(81, 1)
        patternLEDList(82, 2) = patternLEDList(81, 2)
        Button82.BackColor = Button81.BackColor

        patternLEDList(81, 0) = 0
        patternLEDList(81, 1) = 0
        patternLEDList(81, 2) = 0
        Button81.BackColor = Color.Black
    End Sub
    Sub downc12()
        patternLEDList(89, 0) = patternLEDList(90, 0)
        patternLEDList(89, 1) = patternLEDList(90, 1)
        patternLEDList(89, 2) = patternLEDList(90, 2)
        Button89.BackColor = Button90.BackColor

        patternLEDList(90, 0) = patternLEDList(91, 0)
        patternLEDList(90, 1) = patternLEDList(91, 1)
        patternLEDList(90, 2) = patternLEDList(91, 2)
        Button90.BackColor = Button91.BackColor

        patternLEDList(91, 0) = patternLEDList(92, 0)
        patternLEDList(91, 1) = patternLEDList(92, 1)
        patternLEDList(91, 2) = patternLEDList(92, 2)
        Button91.BackColor = Button92.BackColor

        patternLEDList(92, 0) = patternLEDList(93, 0)
        patternLEDList(92, 1) = patternLEDList(93, 1)
        patternLEDList(92, 2) = patternLEDList(93, 2)
        Button92.BackColor = Button93.BackColor

        patternLEDList(93, 0) = patternLEDList(94, 0)
        patternLEDList(93, 1) = patternLEDList(94, 1)
        patternLEDList(93, 2) = patternLEDList(94, 2)
        Button93.BackColor = Button94.BackColor

        patternLEDList(94, 0) = patternLEDList(95, 0)
        patternLEDList(94, 1) = patternLEDList(95, 1)
        patternLEDList(94, 2) = patternLEDList(95, 2)
        Button94.BackColor = Button95.BackColor

        patternLEDList(95, 0) = patternLEDList(96, 0)
        patternLEDList(95, 1) = patternLEDList(96, 1)
        patternLEDList(95, 2) = patternLEDList(96, 2)
        Button95.BackColor = Button96.BackColor

        patternLEDList(96, 0) = 0
        patternLEDList(96, 1) = 0
        patternLEDList(96, 2) = 0
        Button96.BackColor = Color.Black
    End Sub
    Sub downc13()
        patternLEDList(104, 0) = patternLEDList(103, 0)
        patternLEDList(104, 1) = patternLEDList(103, 1)
        patternLEDList(104, 2) = patternLEDList(103, 2)
        Button104.BackColor = Button103.BackColor

        patternLEDList(103, 0) = patternLEDList(102, 0)
        patternLEDList(103, 1) = patternLEDList(102, 1)
        patternLEDList(103, 2) = patternLEDList(102, 2)
        Button103.BackColor = Button102.BackColor

        patternLEDList(102, 0) = patternLEDList(101, 0)
        patternLEDList(102, 1) = patternLEDList(101, 1)
        patternLEDList(102, 2) = patternLEDList(101, 2)
        Button102.BackColor = Button101.BackColor

        patternLEDList(101, 0) = patternLEDList(100, 0)
        patternLEDList(101, 1) = patternLEDList(100, 1)
        patternLEDList(101, 2) = patternLEDList(100, 2)
        Button101.BackColor = Button100.BackColor

        patternLEDList(100, 0) = patternLEDList(99, 0)
        patternLEDList(100, 1) = patternLEDList(99, 1)
        patternLEDList(100, 2) = patternLEDList(99, 2)
        Button100.BackColor = Button99.BackColor

        patternLEDList(99, 0) = patternLEDList(98, 0)
        patternLEDList(99, 1) = patternLEDList(98, 1)
        patternLEDList(99, 2) = patternLEDList(98, 2)
        Button99.BackColor = Button98.BackColor

        patternLEDList(98, 0) = patternLEDList(97, 0)
        patternLEDList(98, 1) = patternLEDList(97, 1)
        patternLEDList(98, 2) = patternLEDList(97, 2)
        Button98.BackColor = Button97.BackColor

        patternLEDList(97, 0) = 0
        patternLEDList(97, 1) = 0
        patternLEDList(97, 2) = 0
        Button97.BackColor = Color.Black
    End Sub
    Sub downc14()
        patternLEDList(105, 0) = patternLEDList(106, 0)
        patternLEDList(105, 1) = patternLEDList(106, 1)
        patternLEDList(105, 2) = patternLEDList(106, 2)
        Button105.BackColor = Button106.BackColor

        patternLEDList(106, 0) = patternLEDList(107, 0)
        patternLEDList(106, 1) = patternLEDList(107, 1)
        patternLEDList(106, 2) = patternLEDList(107, 2)
        Button106.BackColor = Button107.BackColor

        patternLEDList(107, 0) = patternLEDList(108, 0)
        patternLEDList(107, 1) = patternLEDList(108, 1)
        patternLEDList(107, 2) = patternLEDList(108, 2)
        Button107.BackColor = Button108.BackColor

        patternLEDList(108, 0) = patternLEDList(109, 0)
        patternLEDList(108, 1) = patternLEDList(109, 1)
        patternLEDList(108, 2) = patternLEDList(109, 2)
        Button108.BackColor = Button109.BackColor

        patternLEDList(109, 0) = patternLEDList(110, 0)
        patternLEDList(109, 1) = patternLEDList(110, 1)
        patternLEDList(109, 2) = patternLEDList(110, 2)
        Button109.BackColor = Button110.BackColor

        patternLEDList(110, 0) = patternLEDList(111, 0)
        patternLEDList(110, 1) = patternLEDList(111, 1)
        patternLEDList(110, 2) = patternLEDList(111, 2)
        Button110.BackColor = Button111.BackColor

        patternLEDList(111, 0) = patternLEDList(112, 0)
        patternLEDList(111, 1) = patternLEDList(112, 1)
        patternLEDList(111, 2) = patternLEDList(112, 2)
        Button111.BackColor = Button112.BackColor

        patternLEDList(112, 0) = 0
        patternLEDList(112, 1) = 0
        patternLEDList(112, 2) = 0
        Button112.BackColor = Color.Black
    End Sub
    Sub downc15()
        patternLEDList(120, 0) = patternLEDList(119, 0)
        patternLEDList(120, 1) = patternLEDList(119, 1)
        patternLEDList(120, 2) = patternLEDList(119, 2)
        Button120.BackColor = Button119.BackColor

        patternLEDList(119, 0) = patternLEDList(118, 0)
        patternLEDList(119, 1) = patternLEDList(118, 1)
        patternLEDList(119, 2) = patternLEDList(118, 2)
        Button119.BackColor = Button118.BackColor

        patternLEDList(118, 0) = patternLEDList(117, 0)
        patternLEDList(118, 1) = patternLEDList(117, 1)
        patternLEDList(118, 2) = patternLEDList(117, 2)
        Button118.BackColor = Button117.BackColor

        patternLEDList(117, 0) = patternLEDList(116, 0)
        patternLEDList(117, 1) = patternLEDList(116, 1)
        patternLEDList(117, 2) = patternLEDList(116, 2)
        Button117.BackColor = Button116.BackColor

        patternLEDList(116, 0) = patternLEDList(115, 0)
        patternLEDList(116, 1) = patternLEDList(115, 1)
        patternLEDList(116, 2) = patternLEDList(115, 2)
        Button116.BackColor = Button115.BackColor

        patternLEDList(115, 0) = patternLEDList(114, 0)
        patternLEDList(115, 1) = patternLEDList(114, 1)
        patternLEDList(115, 2) = patternLEDList(114, 2)
        Button115.BackColor = Button114.BackColor

        patternLEDList(114, 0) = patternLEDList(113, 0)
        patternLEDList(114, 1) = patternLEDList(113, 1)
        patternLEDList(114, 2) = patternLEDList(113, 2)
        Button114.BackColor = Button113.BackColor

        patternLEDList(113, 0) = 0
        patternLEDList(113, 1) = 0
        patternLEDList(113, 2) = 0
        Button113.BackColor = Color.Black
    End Sub
    Sub downc16()
        patternLEDList(121, 0) = patternLEDList(122, 0)
        patternLEDList(121, 1) = patternLEDList(122, 1)
        patternLEDList(121, 2) = patternLEDList(122, 2)
        Button121.BackColor = Button122.BackColor

        patternLEDList(122, 0) = patternLEDList(123, 0)
        patternLEDList(122, 1) = patternLEDList(123, 1)
        patternLEDList(122, 2) = patternLEDList(123, 2)
        Button122.BackColor = Button123.BackColor

        patternLEDList(123, 0) = patternLEDList(124, 0)
        patternLEDList(123, 1) = patternLEDList(124, 1)
        patternLEDList(123, 2) = patternLEDList(124, 2)
        Button123.BackColor = Button124.BackColor

        patternLEDList(124, 0) = patternLEDList(125, 0)
        patternLEDList(124, 1) = patternLEDList(125, 1)
        patternLEDList(124, 2) = patternLEDList(125, 2)
        Button124.BackColor = Button125.BackColor

        patternLEDList(125, 0) = patternLEDList(126, 0)
        patternLEDList(125, 1) = patternLEDList(126, 1)
        patternLEDList(125, 2) = patternLEDList(126, 2)
        Button125.BackColor = Button126.BackColor

        patternLEDList(126, 0) = patternLEDList(127, 0)
        patternLEDList(126, 1) = patternLEDList(127, 1)
        patternLEDList(126, 2) = patternLEDList(127, 2)
        Button126.BackColor = Button127.BackColor

        patternLEDList(127, 0) = patternLEDList(128, 0)
        patternLEDList(127, 1) = patternLEDList(128, 1)
        patternLEDList(127, 2) = patternLEDList(128, 2)
        Button127.BackColor = Button128.BackColor

        patternLEDList(128, 0) = 0
        patternLEDList(128, 1) = 0
        patternLEDList(128, 2) = 0
        Button128.BackColor = Color.Black
    End Sub
    Sub downc17()
        patternLEDList(136, 0) = patternLEDList(135, 0)
        patternLEDList(136, 1) = patternLEDList(135, 1)
        patternLEDList(136, 2) = patternLEDList(135, 2)
        Button136.BackColor = Button135.BackColor

        patternLEDList(135, 0) = patternLEDList(134, 0)
        patternLEDList(135, 1) = patternLEDList(134, 1)
        patternLEDList(135, 2) = patternLEDList(134, 2)
        Button135.BackColor = Button134.BackColor

        patternLEDList(134, 0) = patternLEDList(133, 0)
        patternLEDList(134, 1) = patternLEDList(133, 1)
        patternLEDList(134, 2) = patternLEDList(133, 2)
        Button134.BackColor = Button133.BackColor

        patternLEDList(133, 0) = patternLEDList(132, 0)
        patternLEDList(133, 1) = patternLEDList(132, 1)
        patternLEDList(133, 2) = patternLEDList(132, 2)
        Button133.BackColor = Button132.BackColor

        patternLEDList(132, 0) = patternLEDList(131, 0)
        patternLEDList(132, 1) = patternLEDList(131, 1)
        patternLEDList(132, 2) = patternLEDList(131, 2)
        Button132.BackColor = Button131.BackColor

        patternLEDList(131, 0) = patternLEDList(130, 0)
        patternLEDList(131, 1) = patternLEDList(130, 1)
        patternLEDList(131, 2) = patternLEDList(130, 2)
        Button131.BackColor = Button130.BackColor

        patternLEDList(130, 0) = patternLEDList(129, 0)
        patternLEDList(130, 1) = patternLEDList(129, 1)
        patternLEDList(130, 2) = patternLEDList(129, 2)
        Button130.BackColor = Button129.BackColor

        patternLEDList(129, 0) = 0
        patternLEDList(129, 1) = 0
        patternLEDList(129, 2) = 0
        Button129.BackColor = Color.Black
    End Sub
    Sub downc18()
        patternLEDList(137, 0) = patternLEDList(138, 0)
        patternLEDList(137, 1) = patternLEDList(138, 1)
        patternLEDList(137, 2) = patternLEDList(138, 2)
        Button137.BackColor = Button138.BackColor

        patternLEDList(138, 0) = patternLEDList(139, 0)
        patternLEDList(138, 1) = patternLEDList(139, 1)
        patternLEDList(138, 2) = patternLEDList(139, 2)
        Button138.BackColor = Button139.BackColor

        patternLEDList(139, 0) = patternLEDList(140, 0)
        patternLEDList(139, 1) = patternLEDList(140, 1)
        patternLEDList(139, 2) = patternLEDList(140, 2)
        Button139.BackColor = Button140.BackColor

        patternLEDList(140, 0) = patternLEDList(141, 0)
        patternLEDList(140, 1) = patternLEDList(141, 1)
        patternLEDList(140, 2) = patternLEDList(141, 2)
        Button140.BackColor = Button141.BackColor

        patternLEDList(141, 0) = patternLEDList(142, 0)
        patternLEDList(141, 1) = patternLEDList(142, 1)
        patternLEDList(141, 2) = patternLEDList(142, 2)
        Button141.BackColor = Button142.BackColor

        patternLEDList(142, 0) = patternLEDList(143, 0)
        patternLEDList(142, 1) = patternLEDList(143, 1)
        patternLEDList(142, 2) = patternLEDList(143, 2)
        Button142.BackColor = Button143.BackColor

        patternLEDList(143, 0) = patternLEDList(144, 0)
        patternLEDList(143, 1) = patternLEDList(144, 1)
        patternLEDList(143, 2) = patternLEDList(144, 2)
        Button143.BackColor = Button144.BackColor

        patternLEDList(144, 0) = 0
        patternLEDList(144, 1) = 0
        patternLEDList(144, 2) = 0
        Button144.BackColor = Color.Black
    End Sub
    Sub downc19()
        patternLEDList(152, 0) = patternLEDList(151, 0)
        patternLEDList(152, 1) = patternLEDList(151, 1)
        patternLEDList(152, 2) = patternLEDList(151, 2)
        Button152.BackColor = Button151.BackColor

        patternLEDList(151, 0) = patternLEDList(150, 0)
        patternLEDList(151, 1) = patternLEDList(150, 1)
        patternLEDList(151, 2) = patternLEDList(150, 2)
        Button151.BackColor = Button150.BackColor

        patternLEDList(150, 0) = patternLEDList(149, 0)
        patternLEDList(150, 1) = patternLEDList(149, 1)
        patternLEDList(150, 2) = patternLEDList(149, 2)
        Button150.BackColor = Button149.BackColor

        patternLEDList(149, 0) = patternLEDList(148, 0)
        patternLEDList(149, 1) = patternLEDList(148, 1)
        patternLEDList(149, 2) = patternLEDList(148, 2)
        Button149.BackColor = Button148.BackColor

        patternLEDList(148, 0) = patternLEDList(147, 0)
        patternLEDList(148, 1) = patternLEDList(147, 1)
        patternLEDList(148, 2) = patternLEDList(147, 2)
        Button148.BackColor = Button147.BackColor

        patternLEDList(147, 0) = patternLEDList(146, 0)
        patternLEDList(147, 1) = patternLEDList(146, 1)
        patternLEDList(147, 2) = patternLEDList(146, 2)
        Button147.BackColor = Button146.BackColor

        patternLEDList(146, 0) = patternLEDList(145, 0)
        patternLEDList(146, 1) = patternLEDList(145, 1)
        patternLEDList(146, 2) = patternLEDList(145, 2)
        Button146.BackColor = Button145.BackColor

        patternLEDList(145, 0) = 0
        patternLEDList(145, 1) = 0
        patternLEDList(145, 2) = 0
        Button145.BackColor = Color.Black
    End Sub
    Sub downc20()
        patternLEDList(153, 0) = patternLEDList(154, 0)
        patternLEDList(153, 1) = patternLEDList(154, 1)
        patternLEDList(153, 2) = patternLEDList(154, 2)
        Button153.BackColor = Button154.BackColor

        patternLEDList(154, 0) = patternLEDList(155, 0)
        patternLEDList(154, 1) = patternLEDList(155, 1)
        patternLEDList(154, 2) = patternLEDList(155, 2)
        Button154.BackColor = Button155.BackColor

        patternLEDList(155, 0) = patternLEDList(156, 0)
        patternLEDList(155, 1) = patternLEDList(156, 1)
        patternLEDList(155, 2) = patternLEDList(156, 2)
        Button155.BackColor = Button156.BackColor

        patternLEDList(156, 0) = patternLEDList(157, 0)
        patternLEDList(156, 1) = patternLEDList(157, 1)
        patternLEDList(156, 2) = patternLEDList(157, 2)
        Button156.BackColor = Button157.BackColor

        patternLEDList(157, 0) = patternLEDList(158, 0)
        patternLEDList(157, 1) = patternLEDList(158, 1)
        patternLEDList(157, 2) = patternLEDList(158, 2)
        Button157.BackColor = Button158.BackColor

        patternLEDList(158, 0) = patternLEDList(159, 0)
        patternLEDList(158, 1) = patternLEDList(159, 1)
        patternLEDList(158, 2) = patternLEDList(159, 2)
        Button158.BackColor = Button159.BackColor

        patternLEDList(159, 0) = patternLEDList(160, 0)
        patternLEDList(159, 1) = patternLEDList(160, 1)
        patternLEDList(159, 2) = patternLEDList(160, 2)
        Button159.BackColor = Button160.BackColor

        patternLEDList(160, 0) = 0
        patternLEDList(160, 1) = 0
        patternLEDList(160, 2) = 0
        Button160.BackColor = Color.Black
    End Sub
    Sub downc21()
        patternLEDList(168, 0) = patternLEDList(167, 0)
        patternLEDList(168, 1) = patternLEDList(167, 1)
        patternLEDList(168, 2) = patternLEDList(167, 2)
        Button168.BackColor = Button167.BackColor

        patternLEDList(167, 0) = patternLEDList(166, 0)
        patternLEDList(167, 1) = patternLEDList(166, 1)
        patternLEDList(167, 2) = patternLEDList(166, 2)
        Button167.BackColor = Button166.BackColor

        patternLEDList(166, 0) = patternLEDList(165, 0)
        patternLEDList(166, 1) = patternLEDList(165, 1)
        patternLEDList(166, 2) = patternLEDList(165, 2)
        Button166.BackColor = Button165.BackColor

        patternLEDList(165, 0) = patternLEDList(164, 0)
        patternLEDList(165, 1) = patternLEDList(164, 1)
        patternLEDList(165, 2) = patternLEDList(164, 2)
        Button165.BackColor = Button164.BackColor

        patternLEDList(164, 0) = patternLEDList(163, 0)
        patternLEDList(164, 1) = patternLEDList(163, 1)
        patternLEDList(164, 2) = patternLEDList(163, 2)
        Button164.BackColor = Button163.BackColor

        patternLEDList(163, 0) = patternLEDList(162, 0)
        patternLEDList(163, 1) = patternLEDList(162, 1)
        patternLEDList(163, 2) = patternLEDList(162, 2)
        Button163.BackColor = Button162.BackColor

        patternLEDList(162, 0) = patternLEDList(161, 0)
        patternLEDList(162, 1) = patternLEDList(161, 1)
        patternLEDList(162, 2) = patternLEDList(161, 2)
        Button162.BackColor = Button161.BackColor

        patternLEDList(161, 0) = 0
        patternLEDList(161, 1) = 0
        patternLEDList(161, 2) = 0
        Button161.BackColor = Color.Black
    End Sub
    Sub downc22()
        patternLEDList(169, 0) = patternLEDList(170, 0)
        patternLEDList(169, 1) = patternLEDList(170, 1)
        patternLEDList(169, 2) = patternLEDList(170, 2)
        Button169.BackColor = Button170.BackColor

        patternLEDList(170, 0) = patternLEDList(171, 0)
        patternLEDList(170, 1) = patternLEDList(171, 1)
        patternLEDList(170, 2) = patternLEDList(171, 2)
        Button170.BackColor = Button171.BackColor

        patternLEDList(171, 0) = patternLEDList(172, 0)
        patternLEDList(171, 1) = patternLEDList(172, 1)
        patternLEDList(171, 2) = patternLEDList(172, 2)
        Button171.BackColor = Button172.BackColor

        patternLEDList(172, 0) = patternLEDList(173, 0)
        patternLEDList(172, 1) = patternLEDList(173, 1)
        patternLEDList(172, 2) = patternLEDList(173, 2)
        Button172.BackColor = Button173.BackColor

        patternLEDList(173, 0) = patternLEDList(174, 0)
        patternLEDList(173, 1) = patternLEDList(174, 1)
        patternLEDList(173, 2) = patternLEDList(174, 2)
        Button173.BackColor = Button174.BackColor

        patternLEDList(174, 0) = patternLEDList(175, 0)
        patternLEDList(174, 1) = patternLEDList(175, 1)
        patternLEDList(174, 2) = patternLEDList(175, 2)
        Button174.BackColor = Button175.BackColor

        patternLEDList(175, 0) = patternLEDList(176, 0)
        patternLEDList(175, 1) = patternLEDList(176, 1)
        patternLEDList(175, 2) = patternLEDList(176, 2)
        Button175.BackColor = Button176.BackColor

        patternLEDList(176, 0) = 0
        patternLEDList(176, 1) = 0
        patternLEDList(176, 2) = 0
        Button176.BackColor = Color.Black
    End Sub
    Sub downc23()
        patternLEDList(184, 0) = patternLEDList(183, 0)
        patternLEDList(184, 1) = patternLEDList(183, 1)
        patternLEDList(184, 2) = patternLEDList(183, 2)
        Button184.BackColor = Button183.BackColor

        patternLEDList(183, 0) = patternLEDList(182, 0)
        patternLEDList(183, 1) = patternLEDList(182, 1)
        patternLEDList(183, 2) = patternLEDList(182, 2)
        Button183.BackColor = Button182.BackColor

        patternLEDList(182, 0) = patternLEDList(181, 0)
        patternLEDList(182, 1) = patternLEDList(181, 1)
        patternLEDList(182, 2) = patternLEDList(181, 2)
        Button182.BackColor = Button181.BackColor

        patternLEDList(181, 0) = patternLEDList(180, 0)
        patternLEDList(181, 1) = patternLEDList(180, 1)
        patternLEDList(181, 2) = patternLEDList(180, 2)
        Button181.BackColor = Button180.BackColor

        patternLEDList(180, 0) = patternLEDList(179, 0)
        patternLEDList(180, 1) = patternLEDList(179, 1)
        patternLEDList(180, 2) = patternLEDList(179, 2)
        Button180.BackColor = Button179.BackColor

        patternLEDList(179, 0) = patternLEDList(178, 0)
        patternLEDList(179, 1) = patternLEDList(178, 1)
        patternLEDList(179, 2) = patternLEDList(178, 2)
        Button179.BackColor = Button178.BackColor

        patternLEDList(178, 0) = patternLEDList(177, 0)
        patternLEDList(178, 1) = patternLEDList(177, 1)
        patternLEDList(178, 2) = patternLEDList(177, 2)
        Button178.BackColor = Button177.BackColor

        patternLEDList(177, 0) = 0
        patternLEDList(177, 1) = 0
        patternLEDList(177, 2) = 0
        Button177.BackColor = Color.Black
    End Sub
    Sub downc24()
        patternLEDList(185, 0) = patternLEDList(186, 0)
        patternLEDList(185, 1) = patternLEDList(186, 1)
        patternLEDList(185, 2) = patternLEDList(186, 2)
        Button185.BackColor = Button186.BackColor

        patternLEDList(186, 0) = patternLEDList(187, 0)
        patternLEDList(186, 1) = patternLEDList(187, 1)
        patternLEDList(186, 2) = patternLEDList(187, 2)
        Button186.BackColor = Button187.BackColor

        patternLEDList(187, 0) = patternLEDList(188, 0)
        patternLEDList(187, 1) = patternLEDList(188, 1)
        patternLEDList(187, 2) = patternLEDList(188, 2)
        Button187.BackColor = Button188.BackColor

        patternLEDList(188, 0) = patternLEDList(189, 0)
        patternLEDList(188, 1) = patternLEDList(189, 1)
        patternLEDList(188, 2) = patternLEDList(189, 2)
        Button188.BackColor = Button189.BackColor

        patternLEDList(189, 0) = patternLEDList(190, 0)
        patternLEDList(189, 1) = patternLEDList(190, 1)
        patternLEDList(189, 2) = patternLEDList(190, 2)
        Button189.BackColor = Button190.BackColor

        patternLEDList(190, 0) = patternLEDList(191, 0)
        patternLEDList(190, 1) = patternLEDList(191, 1)
        patternLEDList(190, 2) = patternLEDList(191, 2)
        Button190.BackColor = Button191.BackColor

        patternLEDList(191, 0) = patternLEDList(192, 0)
        patternLEDList(191, 1) = patternLEDList(192, 1)
        patternLEDList(191, 2) = patternLEDList(192, 2)
        Button191.BackColor = Button192.BackColor

        patternLEDList(192, 0) = 0
        patternLEDList(192, 1) = 0
        patternLEDList(192, 2) = 0
        Button192.BackColor = Color.Black
    End Sub
    Sub downc25()
        patternLEDList(200, 0) = patternLEDList(199, 0)
        patternLEDList(200, 1) = patternLEDList(199, 1)
        patternLEDList(200, 2) = patternLEDList(199, 2)
        Button200.BackColor = Button199.BackColor

        patternLEDList(199, 0) = patternLEDList(198, 0)
        patternLEDList(199, 1) = patternLEDList(198, 1)
        patternLEDList(199, 2) = patternLEDList(198, 2)
        Button199.BackColor = Button198.BackColor

        patternLEDList(198, 0) = patternLEDList(197, 0)
        patternLEDList(198, 1) = patternLEDList(197, 1)
        patternLEDList(198, 2) = patternLEDList(197, 2)
        Button198.BackColor = Button197.BackColor

        patternLEDList(197, 0) = patternLEDList(196, 0)
        patternLEDList(197, 1) = patternLEDList(196, 1)
        patternLEDList(197, 2) = patternLEDList(196, 2)
        Button197.BackColor = Button196.BackColor

        patternLEDList(196, 0) = patternLEDList(195, 0)
        patternLEDList(196, 1) = patternLEDList(195, 1)
        patternLEDList(196, 2) = patternLEDList(195, 2)
        Button196.BackColor = Button195.BackColor

        patternLEDList(195, 0) = patternLEDList(194, 0)
        patternLEDList(195, 1) = patternLEDList(194, 1)
        patternLEDList(195, 2) = patternLEDList(194, 2)
        Button195.BackColor = Button194.BackColor

        patternLEDList(194, 0) = patternLEDList(193, 0)
        patternLEDList(194, 1) = patternLEDList(193, 1)
        patternLEDList(194, 2) = patternLEDList(193, 2)
        Button194.BackColor = Button193.BackColor

        patternLEDList(193, 0) = 0
        patternLEDList(193, 1) = 0
        patternLEDList(193, 2) = 0
        Button193.BackColor = Color.Black
    End Sub


    Sub rightr1()
        patternLEDList(193, 0) = patternLEDList(192, 0)
        patternLEDList(193, 1) = patternLEDList(192, 1)
        patternLEDList(193, 2) = patternLEDList(192, 2)
        Button193.BackColor = Button192.BackColor
        patternLEDList(192, 0) = patternLEDList(177, 0)
        patternLEDList(192, 1) = patternLEDList(177, 1)
        patternLEDList(192, 2) = patternLEDList(177, 2)
        Button192.BackColor = Button177.BackColor
        patternLEDList(177, 0) = patternLEDList(176, 0)
        patternLEDList(177, 1) = patternLEDList(176, 1)
        patternLEDList(177, 2) = patternLEDList(176, 2)
        Button177.BackColor = Button176.BackColor
        patternLEDList(176, 0) = patternLEDList(161, 0)
        patternLEDList(176, 1) = patternLEDList(161, 1)
        patternLEDList(176, 2) = patternLEDList(161, 2)
        Button176.BackColor = Button161.BackColor
        patternLEDList(161, 0) = patternLEDList(160, 0)
        patternLEDList(161, 1) = patternLEDList(160, 1)
        patternLEDList(161, 2) = patternLEDList(160, 2)
        Button161.BackColor = Button160.BackColor
        patternLEDList(160, 0) = patternLEDList(145, 0)
        patternLEDList(160, 1) = patternLEDList(145, 1)
        patternLEDList(160, 2) = patternLEDList(145, 2)
        Button160.BackColor = Button145.BackColor
        patternLEDList(145, 0) = patternLEDList(144, 0)
        patternLEDList(145, 1) = patternLEDList(144, 1)
        patternLEDList(145, 2) = patternLEDList(144, 2)
        Button145.BackColor = Button144.BackColor
        patternLEDList(144, 0) = patternLEDList(129, 0)
        patternLEDList(144, 1) = patternLEDList(129, 1)
        patternLEDList(144, 2) = patternLEDList(129, 2)
        Button144.BackColor = Button129.BackColor
        patternLEDList(129, 0) = patternLEDList(128, 0)
        patternLEDList(129, 1) = patternLEDList(128, 1)
        patternLEDList(129, 2) = patternLEDList(128, 2)
        Button129.BackColor = Button128.BackColor
        patternLEDList(128, 0) = patternLEDList(113, 0)
        patternLEDList(128, 1) = patternLEDList(113, 1)
        patternLEDList(128, 2) = patternLEDList(113, 2)
        Button128.BackColor = Button113.BackColor
        patternLEDList(113, 0) = patternLEDList(112, 0)
        patternLEDList(113, 1) = patternLEDList(112, 1)
        patternLEDList(113, 2) = patternLEDList(112, 2)
        Button113.BackColor = Button112.BackColor
        patternLEDList(112, 0) = patternLEDList(97, 0)
        patternLEDList(112, 1) = patternLEDList(97, 1)
        patternLEDList(112, 2) = patternLEDList(97, 2)
        Button112.BackColor = Button97.BackColor
        patternLEDList(97, 0) = patternLEDList(96, 0)
        patternLEDList(97, 1) = patternLEDList(96, 1)
        patternLEDList(97, 2) = patternLEDList(96, 2)
        Button97.BackColor = Button96.BackColor
        patternLEDList(96, 0) = patternLEDList(81, 0)
        patternLEDList(96, 1) = patternLEDList(81, 1)
        patternLEDList(96, 2) = patternLEDList(81, 2)
        Button96.BackColor = Button81.BackColor
        patternLEDList(81, 0) = patternLEDList(80, 0)
        patternLEDList(81, 1) = patternLEDList(80, 1)
        patternLEDList(81, 2) = patternLEDList(80, 2)
        Button81.BackColor = Button80.BackColor
        patternLEDList(80, 0) = patternLEDList(65, 0)
        patternLEDList(80, 1) = patternLEDList(65, 1)
        patternLEDList(80, 2) = patternLEDList(65, 2)
        Button80.BackColor = Button65.BackColor
        patternLEDList(65, 0) = patternLEDList(64, 0)
        patternLEDList(65, 1) = patternLEDList(64, 1)
        patternLEDList(65, 2) = patternLEDList(64, 2)
        Button65.BackColor = Button64.BackColor
        patternLEDList(64, 0) = patternLEDList(49, 0)
        patternLEDList(64, 1) = patternLEDList(49, 1)
        patternLEDList(64, 2) = patternLEDList(49, 2)
        Button64.BackColor = Button49.BackColor
        patternLEDList(49, 0) = patternLEDList(48, 0)
        patternLEDList(49, 1) = patternLEDList(48, 1)
        patternLEDList(49, 2) = patternLEDList(48, 2)
        Button49.BackColor = Button48.BackColor
        patternLEDList(48, 0) = patternLEDList(33, 0)
        patternLEDList(48, 1) = patternLEDList(33, 1)
        patternLEDList(48, 2) = patternLEDList(33, 2)
        Button48.BackColor = Button33.BackColor
        patternLEDList(33, 0) = patternLEDList(32, 0)
        patternLEDList(33, 1) = patternLEDList(32, 1)
        patternLEDList(33, 2) = patternLEDList(32, 2)
        Button33.BackColor = Button32.BackColor
        patternLEDList(32, 0) = patternLEDList(17, 0)
        patternLEDList(32, 1) = patternLEDList(17, 1)
        patternLEDList(32, 2) = patternLEDList(17, 2)
        Button32.BackColor = Button17.BackColor
        patternLEDList(17, 0) = patternLEDList(16, 0)
        patternLEDList(17, 1) = patternLEDList(16, 1)
        patternLEDList(17, 2) = patternLEDList(16, 2)
        Button17.BackColor = Button16.BackColor
        patternLEDList(16, 0) = patternLEDList(1, 0)
        patternLEDList(16, 1) = patternLEDList(1, 1)
        patternLEDList(16, 2) = patternLEDList(1, 2)
        Button16.BackColor = Button1.BackColor
        patternLEDList(1, 0) = 0
        patternLEDList(1, 1) = 0
        patternLEDList(1, 2) = 0
        Button1.BackColor = Color.Black

    End Sub
    Sub rightr2()
        patternLEDList(194, 0) = patternLEDList(191, 0)
        patternLEDList(194, 1) = patternLEDList(191, 1)
        patternLEDList(194, 2) = patternLEDList(191, 2)
        Button194.BackColor = Button191.BackColor
        patternLEDList(191, 0) = patternLEDList(178, 0)
        patternLEDList(191, 1) = patternLEDList(178, 1)
        patternLEDList(191, 2) = patternLEDList(178, 2)
        Button191.BackColor = Button178.BackColor
        patternLEDList(178, 0) = patternLEDList(175, 0)
        patternLEDList(178, 1) = patternLEDList(175, 1)
        patternLEDList(178, 2) = patternLEDList(175, 2)
        Button178.BackColor = Button175.BackColor
        patternLEDList(175, 0) = patternLEDList(162, 0)
        patternLEDList(175, 1) = patternLEDList(162, 1)
        patternLEDList(175, 2) = patternLEDList(162, 2)
        Button175.BackColor = Button162.BackColor
        patternLEDList(162, 0) = patternLEDList(159, 0)
        patternLEDList(162, 1) = patternLEDList(159, 1)
        patternLEDList(162, 2) = patternLEDList(159, 2)
        Button162.BackColor = Button159.BackColor
        patternLEDList(159, 0) = patternLEDList(146, 0)
        patternLEDList(159, 1) = patternLEDList(146, 1)
        patternLEDList(159, 2) = patternLEDList(146, 2)
        Button159.BackColor = Button146.BackColor
        patternLEDList(146, 0) = patternLEDList(143, 0)
        patternLEDList(146, 1) = patternLEDList(143, 1)
        patternLEDList(146, 2) = patternLEDList(143, 2)
        Button146.BackColor = Button143.BackColor
        patternLEDList(143, 0) = patternLEDList(130, 0)
        patternLEDList(143, 1) = patternLEDList(130, 1)
        patternLEDList(143, 2) = patternLEDList(130, 2)
        Button143.BackColor = Button130.BackColor
        patternLEDList(130, 0) = patternLEDList(127, 0)
        patternLEDList(130, 1) = patternLEDList(127, 1)
        patternLEDList(130, 2) = patternLEDList(127, 2)
        Button130.BackColor = Button127.BackColor
        patternLEDList(127, 0) = patternLEDList(114, 0)
        patternLEDList(127, 1) = patternLEDList(114, 1)
        patternLEDList(127, 2) = patternLEDList(114, 2)
        Button127.BackColor = Button114.BackColor
        patternLEDList(114, 0) = patternLEDList(111, 0)
        patternLEDList(114, 1) = patternLEDList(111, 1)
        patternLEDList(114, 2) = patternLEDList(111, 2)
        Button114.BackColor = Button111.BackColor
        patternLEDList(111, 0) = patternLEDList(98, 0)
        patternLEDList(111, 1) = patternLEDList(98, 1)
        patternLEDList(111, 2) = patternLEDList(98, 2)
        Button111.BackColor = Button98.BackColor
        patternLEDList(98, 0) = patternLEDList(95, 0)
        patternLEDList(98, 1) = patternLEDList(95, 1)
        patternLEDList(98, 2) = patternLEDList(95, 2)
        Button98.BackColor = Button95.BackColor
        patternLEDList(95, 0) = patternLEDList(82, 0)
        patternLEDList(95, 1) = patternLEDList(82, 1)
        patternLEDList(95, 2) = patternLEDList(82, 2)
        Button95.BackColor = Button82.BackColor
        patternLEDList(82, 0) = patternLEDList(79, 0)
        patternLEDList(82, 1) = patternLEDList(79, 1)
        patternLEDList(82, 2) = patternLEDList(79, 2)
        Button82.BackColor = Button79.BackColor
        patternLEDList(79, 0) = patternLEDList(66, 0)
        patternLEDList(79, 1) = patternLEDList(66, 1)
        patternLEDList(79, 2) = patternLEDList(66, 2)
        Button79.BackColor = Button66.BackColor
        patternLEDList(66, 0) = patternLEDList(63, 0)
        patternLEDList(66, 1) = patternLEDList(63, 1)
        patternLEDList(66, 2) = patternLEDList(63, 2)
        Button66.BackColor = Button63.BackColor
        patternLEDList(63, 0) = patternLEDList(50, 0)
        patternLEDList(63, 1) = patternLEDList(50, 1)
        patternLEDList(63, 2) = patternLEDList(50, 2)
        Button63.BackColor = Button50.BackColor
        patternLEDList(50, 0) = patternLEDList(47, 0)
        patternLEDList(50, 1) = patternLEDList(47, 1)
        patternLEDList(50, 2) = patternLEDList(47, 2)
        Button50.BackColor = Button47.BackColor
        patternLEDList(47, 0) = patternLEDList(34, 0)
        patternLEDList(47, 1) = patternLEDList(34, 1)
        patternLEDList(47, 2) = patternLEDList(34, 2)
        Button47.BackColor = Button34.BackColor
        patternLEDList(34, 0) = patternLEDList(31, 0)
        patternLEDList(34, 1) = patternLEDList(31, 1)
        patternLEDList(34, 2) = patternLEDList(31, 2)
        Button34.BackColor = Button31.BackColor
        patternLEDList(31, 0) = patternLEDList(18, 0)
        patternLEDList(31, 1) = patternLEDList(18, 1)
        patternLEDList(31, 2) = patternLEDList(18, 2)
        Button31.BackColor = Button18.BackColor
        patternLEDList(18, 0) = patternLEDList(15, 0)
        patternLEDList(18, 1) = patternLEDList(15, 1)
        patternLEDList(18, 2) = patternLEDList(15, 2)
        Button18.BackColor = Button15.BackColor
        patternLEDList(15, 0) = patternLEDList(2, 0)
        patternLEDList(15, 1) = patternLEDList(2, 1)
        patternLEDList(15, 2) = patternLEDList(2, 2)
        Button15.BackColor = Button2.BackColor
        patternLEDList(2, 0) = 0
        patternLEDList(2, 1) = 0
        patternLEDList(2, 2) = 0
        Button2.BackColor = Color.Black

    End Sub
    Sub rightr3()
        patternLEDList(195, 0) = patternLEDList(190, 0)
        patternLEDList(195, 1) = patternLEDList(190, 1)
        patternLEDList(195, 2) = patternLEDList(190, 2)
        Button195.BackColor = Button190.BackColor
        patternLEDList(190, 0) = patternLEDList(179, 0)
        patternLEDList(190, 1) = patternLEDList(179, 1)
        patternLEDList(190, 2) = patternLEDList(179, 2)
        Button190.BackColor = Button179.BackColor
        patternLEDList(179, 0) = patternLEDList(174, 0)
        patternLEDList(179, 1) = patternLEDList(174, 1)
        patternLEDList(179, 2) = patternLEDList(174, 2)
        Button179.BackColor = Button174.BackColor
        patternLEDList(174, 0) = patternLEDList(163, 0)
        patternLEDList(174, 1) = patternLEDList(163, 1)
        patternLEDList(174, 2) = patternLEDList(163, 2)
        Button174.BackColor = Button163.BackColor
        patternLEDList(163, 0) = patternLEDList(158, 0)
        patternLEDList(163, 1) = patternLEDList(158, 1)
        patternLEDList(163, 2) = patternLEDList(158, 2)
        Button163.BackColor = Button158.BackColor
        patternLEDList(158, 0) = patternLEDList(147, 0)
        patternLEDList(158, 1) = patternLEDList(147, 1)
        patternLEDList(158, 2) = patternLEDList(147, 2)
        Button158.BackColor = Button147.BackColor
        patternLEDList(147, 0) = patternLEDList(142, 0)
        patternLEDList(147, 1) = patternLEDList(142, 1)
        patternLEDList(147, 2) = patternLEDList(142, 2)
        Button147.BackColor = Button142.BackColor
        patternLEDList(142, 0) = patternLEDList(131, 0)
        patternLEDList(142, 1) = patternLEDList(131, 1)
        patternLEDList(142, 2) = patternLEDList(131, 2)
        Button142.BackColor = Button131.BackColor
        patternLEDList(131, 0) = patternLEDList(126, 0)
        patternLEDList(131, 1) = patternLEDList(126, 1)
        patternLEDList(131, 2) = patternLEDList(126, 2)
        Button131.BackColor = Button126.BackColor
        patternLEDList(126, 0) = patternLEDList(115, 0)
        patternLEDList(126, 1) = patternLEDList(115, 1)
        patternLEDList(126, 2) = patternLEDList(115, 2)
        Button126.BackColor = Button115.BackColor
        patternLEDList(115, 0) = patternLEDList(110, 0)
        patternLEDList(115, 1) = patternLEDList(110, 1)
        patternLEDList(115, 2) = patternLEDList(110, 2)
        Button115.BackColor = Button110.BackColor
        patternLEDList(110, 0) = patternLEDList(99, 0)
        patternLEDList(110, 1) = patternLEDList(99, 1)
        patternLEDList(110, 2) = patternLEDList(99, 2)
        Button110.BackColor = Button99.BackColor
        patternLEDList(99, 0) = patternLEDList(94, 0)
        patternLEDList(99, 1) = patternLEDList(94, 1)
        patternLEDList(99, 2) = patternLEDList(94, 2)
        Button99.BackColor = Button94.BackColor
        patternLEDList(94, 0) = patternLEDList(83, 0)
        patternLEDList(94, 1) = patternLEDList(83, 1)
        patternLEDList(94, 2) = patternLEDList(83, 2)
        Button94.BackColor = Button83.BackColor
        patternLEDList(83, 0) = patternLEDList(78, 0)
        patternLEDList(83, 1) = patternLEDList(78, 1)
        patternLEDList(83, 2) = patternLEDList(78, 2)
        Button83.BackColor = Button78.BackColor
        patternLEDList(78, 0) = patternLEDList(67, 0)
        patternLEDList(78, 1) = patternLEDList(67, 1)
        patternLEDList(78, 2) = patternLEDList(67, 2)
        Button78.BackColor = Button67.BackColor
        patternLEDList(67, 0) = patternLEDList(62, 0)
        patternLEDList(67, 1) = patternLEDList(62, 1)
        patternLEDList(67, 2) = patternLEDList(62, 2)
        Button67.BackColor = Button62.BackColor
        patternLEDList(62, 0) = patternLEDList(51, 0)
        patternLEDList(62, 1) = patternLEDList(51, 1)
        patternLEDList(62, 2) = patternLEDList(51, 2)
        Button62.BackColor = Button51.BackColor
        patternLEDList(51, 0) = patternLEDList(46, 0)
        patternLEDList(51, 1) = patternLEDList(46, 1)
        patternLEDList(51, 2) = patternLEDList(46, 2)
        Button51.BackColor = Button46.BackColor
        patternLEDList(46, 0) = patternLEDList(35, 0)
        patternLEDList(46, 1) = patternLEDList(35, 1)
        patternLEDList(46, 2) = patternLEDList(35, 2)
        Button46.BackColor = Button35.BackColor
        patternLEDList(35, 0) = patternLEDList(30, 0)
        patternLEDList(35, 1) = patternLEDList(30, 1)
        patternLEDList(35, 2) = patternLEDList(30, 2)
        Button35.BackColor = Button30.BackColor
        patternLEDList(30, 0) = patternLEDList(19, 0)
        patternLEDList(30, 1) = patternLEDList(19, 1)
        patternLEDList(30, 2) = patternLEDList(19, 2)
        Button30.BackColor = Button19.BackColor
        patternLEDList(19, 0) = patternLEDList(14, 0)
        patternLEDList(19, 1) = patternLEDList(14, 1)
        patternLEDList(19, 2) = patternLEDList(14, 2)
        Button19.BackColor = Button14.BackColor
        patternLEDList(14, 0) = patternLEDList(3, 0)
        patternLEDList(14, 1) = patternLEDList(3, 1)
        patternLEDList(14, 2) = patternLEDList(3, 2)
        Button14.BackColor = Button3.BackColor
        patternLEDList(3, 0) = 0
        patternLEDList(3, 1) = 0
        patternLEDList(3, 2) = 0
        Button3.BackColor = Color.Black
    End Sub
    Sub rightr4()
        patternLEDList(196, 0) = patternLEDList(189, 0)
        patternLEDList(196, 1) = patternLEDList(189, 1)
        patternLEDList(196, 2) = patternLEDList(189, 2)
        Button196.BackColor = Button189.BackColor
        patternLEDList(189, 0) = patternLEDList(180, 0)
        patternLEDList(189, 1) = patternLEDList(180, 1)
        patternLEDList(189, 2) = patternLEDList(180, 2)
        Button189.BackColor = Button180.BackColor
        patternLEDList(180, 0) = patternLEDList(173, 0)
        patternLEDList(180, 1) = patternLEDList(173, 1)
        patternLEDList(180, 2) = patternLEDList(173, 2)
        Button180.BackColor = Button173.BackColor
        patternLEDList(173, 0) = patternLEDList(164, 0)
        patternLEDList(173, 1) = patternLEDList(164, 1)
        patternLEDList(173, 2) = patternLEDList(164, 2)
        Button173.BackColor = Button164.BackColor
        patternLEDList(164, 0) = patternLEDList(157, 0)
        patternLEDList(164, 1) = patternLEDList(157, 1)
        patternLEDList(164, 2) = patternLEDList(157, 2)
        Button164.BackColor = Button157.BackColor
        patternLEDList(157, 0) = patternLEDList(148, 0)
        patternLEDList(157, 1) = patternLEDList(148, 1)
        patternLEDList(157, 2) = patternLEDList(148, 2)
        Button157.BackColor = Button148.BackColor
        patternLEDList(148, 0) = patternLEDList(141, 0)
        patternLEDList(148, 1) = patternLEDList(141, 1)
        patternLEDList(148, 2) = patternLEDList(141, 2)
        Button148.BackColor = Button141.BackColor
        patternLEDList(141, 0) = patternLEDList(132, 0)
        patternLEDList(141, 1) = patternLEDList(132, 1)
        patternLEDList(141, 2) = patternLEDList(132, 2)
        Button141.BackColor = Button132.BackColor
        patternLEDList(132, 0) = patternLEDList(125, 0)
        patternLEDList(132, 1) = patternLEDList(125, 1)
        patternLEDList(132, 2) = patternLEDList(125, 2)
        Button132.BackColor = Button125.BackColor
        patternLEDList(125, 0) = patternLEDList(116, 0)
        patternLEDList(125, 1) = patternLEDList(116, 1)
        patternLEDList(125, 2) = patternLEDList(116, 2)
        Button125.BackColor = Button116.BackColor
        patternLEDList(116, 0) = patternLEDList(109, 0)
        patternLEDList(116, 1) = patternLEDList(109, 1)
        patternLEDList(116, 2) = patternLEDList(109, 2)
        Button116.BackColor = Button109.BackColor
        patternLEDList(109, 0) = patternLEDList(100, 0)
        patternLEDList(109, 1) = patternLEDList(100, 1)
        patternLEDList(109, 2) = patternLEDList(100, 2)
        Button109.BackColor = Button100.BackColor
        patternLEDList(100, 0) = patternLEDList(93, 0)
        patternLEDList(100, 1) = patternLEDList(93, 1)
        patternLEDList(100, 2) = patternLEDList(93, 2)
        Button100.BackColor = Button93.BackColor
        patternLEDList(93, 0) = patternLEDList(84, 0)
        patternLEDList(93, 1) = patternLEDList(84, 1)
        patternLEDList(93, 2) = patternLEDList(84, 2)
        Button93.BackColor = Button84.BackColor
        patternLEDList(84, 0) = patternLEDList(77, 0)
        patternLEDList(84, 1) = patternLEDList(77, 1)
        patternLEDList(84, 2) = patternLEDList(77, 2)
        Button84.BackColor = Button77.BackColor
        patternLEDList(77, 0) = patternLEDList(68, 0)
        patternLEDList(77, 1) = patternLEDList(68, 1)
        patternLEDList(77, 2) = patternLEDList(68, 2)
        Button77.BackColor = Button68.BackColor
        patternLEDList(68, 0) = patternLEDList(61, 0)
        patternLEDList(68, 1) = patternLEDList(61, 1)
        patternLEDList(68, 2) = patternLEDList(61, 2)
        Button68.BackColor = Button61.BackColor
        patternLEDList(61, 0) = patternLEDList(52, 0)
        patternLEDList(61, 1) = patternLEDList(52, 1)
        patternLEDList(61, 2) = patternLEDList(52, 2)
        Button61.BackColor = Button52.BackColor
        patternLEDList(52, 0) = patternLEDList(45, 0)
        patternLEDList(52, 1) = patternLEDList(45, 1)
        patternLEDList(52, 2) = patternLEDList(45, 2)
        Button52.BackColor = Button45.BackColor
        patternLEDList(45, 0) = patternLEDList(36, 0)
        patternLEDList(45, 1) = patternLEDList(36, 1)
        patternLEDList(45, 2) = patternLEDList(36, 2)
        Button45.BackColor = Button36.BackColor
        patternLEDList(36, 0) = patternLEDList(29, 0)
        patternLEDList(36, 1) = patternLEDList(29, 1)
        patternLEDList(36, 2) = patternLEDList(29, 2)
        Button36.BackColor = Button29.BackColor
        patternLEDList(29, 0) = patternLEDList(20, 0)
        patternLEDList(29, 1) = patternLEDList(20, 1)
        patternLEDList(29, 2) = patternLEDList(20, 2)
        Button29.BackColor = Button20.BackColor
        patternLEDList(20, 0) = patternLEDList(13, 0)
        patternLEDList(20, 1) = patternLEDList(13, 1)
        patternLEDList(20, 2) = patternLEDList(13, 2)
        Button20.BackColor = Button13.BackColor
        patternLEDList(13, 0) = patternLEDList(4, 0)
        patternLEDList(13, 1) = patternLEDList(4, 1)
        patternLEDList(13, 2) = patternLEDList(4, 2)
        Button13.BackColor = Button4.BackColor
        patternLEDList(4, 0) = 0
        patternLEDList(4, 1) = 0
        patternLEDList(4, 2) = 0
        Button4.BackColor = Color.Black
    End Sub
    Sub rightr5()
        patternLEDList(197, 0) = patternLEDList(188, 0)
        patternLEDList(197, 1) = patternLEDList(188, 1)
        patternLEDList(197, 2) = patternLEDList(188, 2)
        Button197.BackColor = Button188.BackColor
        patternLEDList(188, 0) = patternLEDList(181, 0)
        patternLEDList(188, 1) = patternLEDList(181, 1)
        patternLEDList(188, 2) = patternLEDList(181, 2)
        Button188.BackColor = Button181.BackColor
        patternLEDList(181, 0) = patternLEDList(172, 0)
        patternLEDList(181, 1) = patternLEDList(172, 1)
        patternLEDList(181, 2) = patternLEDList(172, 2)
        Button181.BackColor = Button172.BackColor
        patternLEDList(172, 0) = patternLEDList(165, 0)
        patternLEDList(172, 1) = patternLEDList(165, 1)
        patternLEDList(172, 2) = patternLEDList(165, 2)
        Button172.BackColor = Button165.BackColor
        patternLEDList(165, 0) = patternLEDList(156, 0)
        patternLEDList(165, 1) = patternLEDList(156, 1)
        patternLEDList(165, 2) = patternLEDList(156, 2)
        Button165.BackColor = Button156.BackColor
        patternLEDList(156, 0) = patternLEDList(149, 0)
        patternLEDList(156, 1) = patternLEDList(149, 1)
        patternLEDList(156, 2) = patternLEDList(149, 2)
        Button156.BackColor = Button149.BackColor
        patternLEDList(149, 0) = patternLEDList(140, 0)
        patternLEDList(149, 1) = patternLEDList(140, 1)
        patternLEDList(149, 2) = patternLEDList(140, 2)
        Button149.BackColor = Button140.BackColor
        patternLEDList(140, 0) = patternLEDList(133, 0)
        patternLEDList(140, 1) = patternLEDList(133, 1)
        patternLEDList(140, 2) = patternLEDList(133, 2)
        Button140.BackColor = Button133.BackColor
        patternLEDList(133, 0) = patternLEDList(124, 0)
        patternLEDList(133, 1) = patternLEDList(124, 1)
        patternLEDList(133, 2) = patternLEDList(124, 2)
        Button133.BackColor = Button124.BackColor
        patternLEDList(124, 0) = patternLEDList(117, 0)
        patternLEDList(124, 1) = patternLEDList(117, 1)
        patternLEDList(124, 2) = patternLEDList(117, 2)
        Button124.BackColor = Button117.BackColor
        patternLEDList(117, 0) = patternLEDList(108, 0)
        patternLEDList(117, 1) = patternLEDList(108, 1)
        patternLEDList(117, 2) = patternLEDList(108, 2)
        Button117.BackColor = Button108.BackColor
        patternLEDList(108, 0) = patternLEDList(101, 0)
        patternLEDList(108, 1) = patternLEDList(101, 1)
        patternLEDList(108, 2) = patternLEDList(101, 2)
        Button108.BackColor = Button101.BackColor
        patternLEDList(101, 0) = patternLEDList(92, 0)
        patternLEDList(101, 1) = patternLEDList(92, 1)
        patternLEDList(101, 2) = patternLEDList(92, 2)
        Button101.BackColor = Button92.BackColor
        patternLEDList(92, 0) = patternLEDList(85, 0)
        patternLEDList(92, 1) = patternLEDList(85, 1)
        patternLEDList(92, 2) = patternLEDList(85, 2)
        Button92.BackColor = Button85.BackColor
        patternLEDList(85, 0) = patternLEDList(76, 0)
        patternLEDList(85, 1) = patternLEDList(76, 1)
        patternLEDList(85, 2) = patternLEDList(76, 2)
        Button85.BackColor = Button76.BackColor
        patternLEDList(76, 0) = patternLEDList(69, 0)
        patternLEDList(76, 1) = patternLEDList(69, 1)
        patternLEDList(76, 2) = patternLEDList(69, 2)
        Button76.BackColor = Button69.BackColor
        patternLEDList(69, 0) = patternLEDList(60, 0)
        patternLEDList(69, 1) = patternLEDList(60, 1)
        patternLEDList(69, 2) = patternLEDList(60, 2)
        Button69.BackColor = Button60.BackColor
        patternLEDList(60, 0) = patternLEDList(53, 0)
        patternLEDList(60, 1) = patternLEDList(53, 1)
        patternLEDList(60, 2) = patternLEDList(53, 2)
        Button60.BackColor = Button53.BackColor
        patternLEDList(53, 0) = patternLEDList(44, 0)
        patternLEDList(53, 1) = patternLEDList(44, 1)
        patternLEDList(53, 2) = patternLEDList(44, 2)
        Button53.BackColor = Button44.BackColor
        patternLEDList(44, 0) = patternLEDList(37, 0)
        patternLEDList(44, 1) = patternLEDList(37, 1)
        patternLEDList(44, 2) = patternLEDList(37, 2)
        Button44.BackColor = Button37.BackColor
        patternLEDList(37, 0) = patternLEDList(28, 0)
        patternLEDList(37, 1) = patternLEDList(28, 1)
        patternLEDList(37, 2) = patternLEDList(28, 2)
        Button37.BackColor = Button28.BackColor
        patternLEDList(28, 0) = patternLEDList(21, 0)
        patternLEDList(28, 1) = patternLEDList(21, 1)
        patternLEDList(28, 2) = patternLEDList(21, 2)
        Button28.BackColor = Button21.BackColor
        patternLEDList(21, 0) = patternLEDList(12, 0)
        patternLEDList(21, 1) = patternLEDList(12, 1)
        patternLEDList(21, 2) = patternLEDList(12, 2)
        Button21.BackColor = Button12.BackColor
        patternLEDList(12, 0) = patternLEDList(5, 0)
        patternLEDList(12, 1) = patternLEDList(5, 1)
        patternLEDList(12, 2) = patternLEDList(5, 2)
        Button12.BackColor = Button5.BackColor
        patternLEDList(5, 0) = 0
        patternLEDList(5, 1) = 0
        patternLEDList(5, 2) = 0
        Button5.BackColor = Color.Black
    End Sub
    Sub rightr6()
        patternLEDList(198, 0) = patternLEDList(187, 0)
        patternLEDList(198, 1) = patternLEDList(187, 1)
        patternLEDList(198, 2) = patternLEDList(187, 2)
        Button198.BackColor = Button187.BackColor
        patternLEDList(187, 0) = patternLEDList(182, 0)
        patternLEDList(187, 1) = patternLEDList(182, 1)
        patternLEDList(187, 2) = patternLEDList(182, 2)
        Button187.BackColor = Button182.BackColor
        patternLEDList(182, 0) = patternLEDList(171, 0)
        patternLEDList(182, 1) = patternLEDList(171, 1)
        patternLEDList(182, 2) = patternLEDList(171, 2)
        Button182.BackColor = Button171.BackColor
        patternLEDList(171, 0) = patternLEDList(166, 0)
        patternLEDList(171, 1) = patternLEDList(166, 1)
        patternLEDList(171, 2) = patternLEDList(166, 2)
        Button171.BackColor = Button166.BackColor
        patternLEDList(166, 0) = patternLEDList(155, 0)
        patternLEDList(166, 1) = patternLEDList(155, 1)
        patternLEDList(166, 2) = patternLEDList(155, 2)
        Button166.BackColor = Button155.BackColor
        patternLEDList(155, 0) = patternLEDList(150, 0)
        patternLEDList(155, 1) = patternLEDList(150, 1)
        patternLEDList(155, 2) = patternLEDList(150, 2)
        Button155.BackColor = Button150.BackColor
        patternLEDList(150, 0) = patternLEDList(139, 0)
        patternLEDList(150, 1) = patternLEDList(139, 1)
        patternLEDList(150, 2) = patternLEDList(139, 2)
        Button150.BackColor = Button139.BackColor
        patternLEDList(139, 0) = patternLEDList(134, 0)
        patternLEDList(139, 1) = patternLEDList(134, 1)
        patternLEDList(139, 2) = patternLEDList(134, 2)
        Button139.BackColor = Button134.BackColor
        patternLEDList(134, 0) = patternLEDList(123, 0)
        patternLEDList(134, 1) = patternLEDList(123, 1)
        patternLEDList(134, 2) = patternLEDList(123, 2)
        Button134.BackColor = Button123.BackColor
        patternLEDList(123, 0) = patternLEDList(118, 0)
        patternLEDList(123, 1) = patternLEDList(118, 1)
        patternLEDList(123, 2) = patternLEDList(118, 2)
        Button123.BackColor = Button118.BackColor
        patternLEDList(118, 0) = patternLEDList(107, 0)
        patternLEDList(118, 1) = patternLEDList(107, 1)
        patternLEDList(118, 2) = patternLEDList(107, 2)
        Button118.BackColor = Button107.BackColor
        patternLEDList(107, 0) = patternLEDList(102, 0)
        patternLEDList(107, 1) = patternLEDList(102, 1)
        patternLEDList(107, 2) = patternLEDList(102, 2)
        Button107.BackColor = Button102.BackColor
        patternLEDList(102, 0) = patternLEDList(91, 0)
        patternLEDList(102, 1) = patternLEDList(91, 1)
        patternLEDList(102, 2) = patternLEDList(91, 2)
        Button102.BackColor = Button91.BackColor
        patternLEDList(91, 0) = patternLEDList(86, 0)
        patternLEDList(91, 1) = patternLEDList(86, 1)
        patternLEDList(91, 2) = patternLEDList(86, 2)
        Button91.BackColor = Button86.BackColor
        patternLEDList(86, 0) = patternLEDList(75, 0)
        patternLEDList(86, 1) = patternLEDList(75, 1)
        patternLEDList(86, 2) = patternLEDList(75, 2)
        Button86.BackColor = Button75.BackColor
        patternLEDList(75, 0) = patternLEDList(70, 0)
        patternLEDList(75, 1) = patternLEDList(70, 1)
        patternLEDList(75, 2) = patternLEDList(70, 2)
        Button75.BackColor = Button70.BackColor
        patternLEDList(70, 0) = patternLEDList(59, 0)
        patternLEDList(70, 1) = patternLEDList(59, 1)
        patternLEDList(70, 2) = patternLEDList(59, 2)
        Button70.BackColor = Button59.BackColor
        patternLEDList(59, 0) = patternLEDList(54, 0)
        patternLEDList(59, 1) = patternLEDList(54, 1)
        patternLEDList(59, 2) = patternLEDList(54, 2)
        Button59.BackColor = Button54.BackColor
        patternLEDList(54, 0) = patternLEDList(43, 0)
        patternLEDList(54, 1) = patternLEDList(43, 1)
        patternLEDList(54, 2) = patternLEDList(43, 2)
        Button54.BackColor = Button43.BackColor
        patternLEDList(43, 0) = patternLEDList(38, 0)
        patternLEDList(43, 1) = patternLEDList(38, 1)
        patternLEDList(43, 2) = patternLEDList(38, 2)
        Button43.BackColor = Button38.BackColor
        patternLEDList(38, 0) = patternLEDList(27, 0)
        patternLEDList(38, 1) = patternLEDList(27, 1)
        patternLEDList(38, 2) = patternLEDList(27, 2)
        Button38.BackColor = Button27.BackColor
        patternLEDList(27, 0) = patternLEDList(22, 0)
        patternLEDList(27, 1) = patternLEDList(22, 1)
        patternLEDList(27, 2) = patternLEDList(22, 2)
        Button27.BackColor = Button22.BackColor
        patternLEDList(22, 0) = patternLEDList(11, 0)
        patternLEDList(22, 1) = patternLEDList(11, 1)
        patternLEDList(22, 2) = patternLEDList(11, 2)
        Button22.BackColor = Button11.BackColor
        patternLEDList(11, 0) = patternLEDList(6, 0)
        patternLEDList(11, 1) = patternLEDList(6, 1)
        patternLEDList(11, 2) = patternLEDList(6, 2)
        Button11.BackColor = Button6.BackColor
        patternLEDList(6, 0) = 0
        patternLEDList(6, 1) = 0
        patternLEDList(6, 2) = 0
        Button6.BackColor = Color.Black
    End Sub
    Sub rightr7()
        patternLEDList(199, 0) = patternLEDList(186, 0)
        patternLEDList(199, 1) = patternLEDList(186, 1)
        patternLEDList(199, 2) = patternLEDList(186, 2)
        Button199.BackColor = Button186.BackColor
        patternLEDList(186, 0) = patternLEDList(183, 0)
        patternLEDList(186, 1) = patternLEDList(183, 1)
        patternLEDList(186, 2) = patternLEDList(183, 2)
        Button186.BackColor = Button183.BackColor
        patternLEDList(183, 0) = patternLEDList(170, 0)
        patternLEDList(183, 1) = patternLEDList(170, 1)
        patternLEDList(183, 2) = patternLEDList(170, 2)
        Button183.BackColor = Button170.BackColor
        patternLEDList(170, 0) = patternLEDList(167, 0)
        patternLEDList(170, 1) = patternLEDList(167, 1)
        patternLEDList(170, 2) = patternLEDList(167, 2)
        Button170.BackColor = Button167.BackColor
        patternLEDList(167, 0) = patternLEDList(154, 0)
        patternLEDList(167, 1) = patternLEDList(154, 1)
        patternLEDList(167, 2) = patternLEDList(154, 2)
        Button167.BackColor = Button154.BackColor
        patternLEDList(154, 0) = patternLEDList(151, 0)
        patternLEDList(154, 1) = patternLEDList(151, 1)
        patternLEDList(154, 2) = patternLEDList(151, 2)
        Button154.BackColor = Button151.BackColor
        patternLEDList(151, 0) = patternLEDList(138, 0)
        patternLEDList(151, 1) = patternLEDList(138, 1)
        patternLEDList(151, 2) = patternLEDList(138, 2)
        Button151.BackColor = Button138.BackColor
        patternLEDList(138, 0) = patternLEDList(135, 0)
        patternLEDList(138, 1) = patternLEDList(135, 1)
        patternLEDList(138, 2) = patternLEDList(135, 2)
        Button138.BackColor = Button135.BackColor
        patternLEDList(135, 0) = patternLEDList(122, 0)
        patternLEDList(135, 1) = patternLEDList(122, 1)
        patternLEDList(135, 2) = patternLEDList(122, 2)
        Button135.BackColor = Button122.BackColor
        patternLEDList(122, 0) = patternLEDList(119, 0)
        patternLEDList(122, 1) = patternLEDList(119, 1)
        patternLEDList(122, 2) = patternLEDList(119, 2)
        Button122.BackColor = Button119.BackColor
        patternLEDList(119, 0) = patternLEDList(106, 0)
        patternLEDList(119, 1) = patternLEDList(106, 1)
        patternLEDList(119, 2) = patternLEDList(106, 2)
        Button119.BackColor = Button106.BackColor
        patternLEDList(106, 0) = patternLEDList(103, 0)
        patternLEDList(106, 1) = patternLEDList(103, 1)
        patternLEDList(106, 2) = patternLEDList(103, 2)
        Button106.BackColor = Button103.BackColor
        patternLEDList(103, 0) = patternLEDList(90, 0)
        patternLEDList(103, 1) = patternLEDList(90, 1)
        patternLEDList(103, 2) = patternLEDList(90, 2)
        Button103.BackColor = Button90.BackColor
        patternLEDList(90, 0) = patternLEDList(87, 0)
        patternLEDList(90, 1) = patternLEDList(87, 1)
        patternLEDList(90, 2) = patternLEDList(87, 2)
        Button90.BackColor = Button87.BackColor
        patternLEDList(87, 0) = patternLEDList(74, 0)
        patternLEDList(87, 1) = patternLEDList(74, 1)
        patternLEDList(87, 2) = patternLEDList(74, 2)
        Button87.BackColor = Button74.BackColor
        patternLEDList(74, 0) = patternLEDList(71, 0)
        patternLEDList(74, 1) = patternLEDList(71, 1)
        patternLEDList(74, 2) = patternLEDList(71, 2)
        Button74.BackColor = Button71.BackColor
        patternLEDList(71, 0) = patternLEDList(58, 0)
        patternLEDList(71, 1) = patternLEDList(58, 1)
        patternLEDList(71, 2) = patternLEDList(58, 2)
        Button71.BackColor = Button58.BackColor
        patternLEDList(58, 0) = patternLEDList(55, 0)
        patternLEDList(58, 1) = patternLEDList(55, 1)
        patternLEDList(58, 2) = patternLEDList(55, 2)
        Button58.BackColor = Button55.BackColor
        patternLEDList(55, 0) = patternLEDList(42, 0)
        patternLEDList(55, 1) = patternLEDList(42, 1)
        patternLEDList(55, 2) = patternLEDList(42, 2)
        Button55.BackColor = Button42.BackColor
        patternLEDList(42, 0) = patternLEDList(39, 0)
        patternLEDList(42, 1) = patternLEDList(39, 1)
        patternLEDList(42, 2) = patternLEDList(39, 2)
        Button42.BackColor = Button39.BackColor
        patternLEDList(39, 0) = patternLEDList(26, 0)
        patternLEDList(39, 1) = patternLEDList(26, 1)
        patternLEDList(39, 2) = patternLEDList(26, 2)
        Button39.BackColor = Button26.BackColor
        patternLEDList(26, 0) = patternLEDList(23, 0)
        patternLEDList(26, 1) = patternLEDList(23, 1)
        patternLEDList(26, 2) = patternLEDList(23, 2)
        Button26.BackColor = Button23.BackColor
        patternLEDList(23, 0) = patternLEDList(10, 0)
        patternLEDList(23, 1) = patternLEDList(10, 1)
        patternLEDList(23, 2) = patternLEDList(10, 2)
        Button23.BackColor = Button10.BackColor
        patternLEDList(10, 0) = patternLEDList(7, 0)
        patternLEDList(10, 1) = patternLEDList(7, 1)
        patternLEDList(10, 2) = patternLEDList(7, 2)
        Button10.BackColor = Button7.BackColor
        patternLEDList(7, 0) = 0
        patternLEDList(7, 1) = 0
        patternLEDList(7, 2) = 0
        Button7.BackColor = Color.Black
    End Sub
    Sub rightr8()
        patternLEDList(200, 0) = patternLEDList(185, 0)
        patternLEDList(200, 1) = patternLEDList(185, 1)
        patternLEDList(200, 2) = patternLEDList(185, 2)
        Button200.BackColor = Button185.BackColor
        patternLEDList(185, 0) = patternLEDList(184, 0)
        patternLEDList(185, 1) = patternLEDList(184, 1)
        patternLEDList(185, 2) = patternLEDList(184, 2)
        Button185.BackColor = Button184.BackColor
        patternLEDList(184, 0) = patternLEDList(169, 0)
        patternLEDList(184, 1) = patternLEDList(169, 1)
        patternLEDList(184, 2) = patternLEDList(169, 2)
        Button184.BackColor = Button169.BackColor
        patternLEDList(169, 0) = patternLEDList(168, 0)
        patternLEDList(169, 1) = patternLEDList(168, 1)
        patternLEDList(169, 2) = patternLEDList(168, 2)
        Button169.BackColor = Button168.BackColor
        patternLEDList(168, 0) = patternLEDList(153, 0)
        patternLEDList(168, 1) = patternLEDList(153, 1)
        patternLEDList(168, 2) = patternLEDList(153, 2)
        Button168.BackColor = Button153.BackColor
        patternLEDList(153, 0) = patternLEDList(152, 0)
        patternLEDList(153, 1) = patternLEDList(152, 1)
        patternLEDList(153, 2) = patternLEDList(152, 2)
        Button153.BackColor = Button152.BackColor
        patternLEDList(152, 0) = patternLEDList(137, 0)
        patternLEDList(152, 1) = patternLEDList(137, 1)
        patternLEDList(152, 2) = patternLEDList(137, 2)
        Button152.BackColor = Button137.BackColor
        patternLEDList(137, 0) = patternLEDList(136, 0)
        patternLEDList(137, 1) = patternLEDList(136, 1)
        patternLEDList(137, 2) = patternLEDList(136, 2)
        Button137.BackColor = Button136.BackColor
        patternLEDList(136, 0) = patternLEDList(121, 0)
        patternLEDList(136, 1) = patternLEDList(121, 1)
        patternLEDList(136, 2) = patternLEDList(121, 2)
        Button136.BackColor = Button121.BackColor
        patternLEDList(121, 0) = patternLEDList(120, 0)
        patternLEDList(121, 1) = patternLEDList(120, 1)
        patternLEDList(121, 2) = patternLEDList(120, 2)
        Button121.BackColor = Button120.BackColor
        patternLEDList(120, 0) = patternLEDList(105, 0)
        patternLEDList(120, 1) = patternLEDList(105, 1)
        patternLEDList(120, 2) = patternLEDList(105, 2)
        Button120.BackColor = Button105.BackColor
        patternLEDList(105, 0) = patternLEDList(104, 0)
        patternLEDList(105, 1) = patternLEDList(104, 1)
        patternLEDList(105, 2) = patternLEDList(104, 2)
        Button105.BackColor = Button104.BackColor
        patternLEDList(104, 0) = patternLEDList(89, 0)
        patternLEDList(104, 1) = patternLEDList(89, 1)
        patternLEDList(104, 2) = patternLEDList(89, 2)
        Button104.BackColor = Button89.BackColor
        patternLEDList(89, 0) = patternLEDList(88, 0)
        patternLEDList(89, 1) = patternLEDList(88, 1)
        patternLEDList(89, 2) = patternLEDList(88, 2)
        Button89.BackColor = Button88.BackColor
        patternLEDList(88, 0) = patternLEDList(73, 0)
        patternLEDList(88, 1) = patternLEDList(73, 1)
        patternLEDList(88, 2) = patternLEDList(73, 2)
        Button88.BackColor = Button73.BackColor
        patternLEDList(73, 0) = patternLEDList(72, 0)
        patternLEDList(73, 1) = patternLEDList(72, 1)
        patternLEDList(73, 2) = patternLEDList(72, 2)
        Button73.BackColor = Button72.BackColor
        patternLEDList(72, 0) = patternLEDList(57, 0)
        patternLEDList(72, 1) = patternLEDList(57, 1)
        patternLEDList(72, 2) = patternLEDList(57, 2)
        Button72.BackColor = Button57.BackColor
        patternLEDList(57, 0) = patternLEDList(56, 0)
        patternLEDList(57, 1) = patternLEDList(56, 1)
        patternLEDList(57, 2) = patternLEDList(56, 2)
        Button57.BackColor = Button56.BackColor
        patternLEDList(56, 0) = patternLEDList(41, 0)
        patternLEDList(56, 1) = patternLEDList(41, 1)
        patternLEDList(56, 2) = patternLEDList(41, 2)
        Button56.BackColor = Button41.BackColor
        patternLEDList(41, 0) = patternLEDList(40, 0)
        patternLEDList(41, 1) = patternLEDList(40, 1)
        patternLEDList(41, 2) = patternLEDList(40, 2)
        Button41.BackColor = Button40.BackColor
        patternLEDList(40, 0) = patternLEDList(25, 0)
        patternLEDList(40, 1) = patternLEDList(25, 1)
        patternLEDList(40, 2) = patternLEDList(25, 2)
        Button40.BackColor = Button25.BackColor
        patternLEDList(25, 0) = patternLEDList(24, 0)
        patternLEDList(25, 1) = patternLEDList(24, 1)
        patternLEDList(25, 2) = patternLEDList(24, 2)
        Button25.BackColor = Button24.BackColor
        patternLEDList(24, 0) = patternLEDList(9, 0)
        patternLEDList(24, 1) = patternLEDList(9, 1)
        patternLEDList(24, 2) = patternLEDList(9, 2)
        Button24.BackColor = Button9.BackColor
        patternLEDList(9, 0) = patternLEDList(8, 0)
        patternLEDList(9, 1) = patternLEDList(8, 1)
        patternLEDList(9, 2) = patternLEDList(8, 2)
        Button9.BackColor = Button8.BackColor
        patternLEDList(8, 0) = 0
        patternLEDList(8, 1) = 0
        patternLEDList(8, 2) = 0
        Button8.BackColor = Color.Black
    End Sub
    Sub leftr1()
        patternLEDList(1, 0) = patternLEDList(16, 0)
        patternLEDList(1, 1) = patternLEDList(16, 1)
        patternLEDList(1, 2) = patternLEDList(16, 2)
        Button1.BackColor = Button16.BackColor
        patternLEDList(16, 0) = patternLEDList(17, 0)
        patternLEDList(16, 1) = patternLEDList(17, 1)
        patternLEDList(16, 2) = patternLEDList(17, 2)
        Button16.BackColor = Button17.BackColor
        patternLEDList(17, 0) = patternLEDList(32, 0)
        patternLEDList(17, 1) = patternLEDList(32, 1)
        patternLEDList(17, 2) = patternLEDList(32, 2)
        Button17.BackColor = Button32.BackColor
        patternLEDList(32, 0) = patternLEDList(33, 0)
        patternLEDList(32, 1) = patternLEDList(33, 1)
        patternLEDList(32, 2) = patternLEDList(33, 2)
        Button32.BackColor = Button33.BackColor
        patternLEDList(33, 0) = patternLEDList(48, 0)
        patternLEDList(33, 1) = patternLEDList(48, 1)
        patternLEDList(33, 2) = patternLEDList(48, 2)
        Button33.BackColor = Button48.BackColor
        patternLEDList(48, 0) = patternLEDList(49, 0)
        patternLEDList(48, 1) = patternLEDList(49, 1)
        patternLEDList(48, 2) = patternLEDList(49, 2)
        Button48.BackColor = Button49.BackColor
        patternLEDList(49, 0) = patternLEDList(64, 0)
        patternLEDList(49, 1) = patternLEDList(64, 1)
        patternLEDList(49, 2) = patternLEDList(64, 2)
        Button49.BackColor = Button64.BackColor
        patternLEDList(64, 0) = patternLEDList(65, 0)
        patternLEDList(64, 1) = patternLEDList(65, 1)
        patternLEDList(64, 2) = patternLEDList(65, 2)
        Button64.BackColor = Button65.BackColor
        patternLEDList(65, 0) = patternLEDList(80, 0)
        patternLEDList(65, 1) = patternLEDList(80, 1)
        patternLEDList(65, 2) = patternLEDList(80, 2)
        Button65.BackColor = Button80.BackColor
        patternLEDList(80, 0) = patternLEDList(81, 0)
        patternLEDList(80, 1) = patternLEDList(81, 1)
        patternLEDList(80, 2) = patternLEDList(81, 2)
        Button80.BackColor = Button81.BackColor
        patternLEDList(81, 0) = patternLEDList(96, 0)
        patternLEDList(81, 1) = patternLEDList(96, 1)
        patternLEDList(81, 2) = patternLEDList(96, 2)
        Button81.BackColor = Button96.BackColor
        patternLEDList(96, 0) = patternLEDList(97, 0)
        patternLEDList(96, 1) = patternLEDList(97, 1)
        patternLEDList(96, 2) = patternLEDList(97, 2)
        Button96.BackColor = Button97.BackColor
        patternLEDList(97, 0) = patternLEDList(112, 0)
        patternLEDList(97, 1) = patternLEDList(112, 1)
        patternLEDList(97, 2) = patternLEDList(112, 2)
        Button97.BackColor = Button112.BackColor
        patternLEDList(112, 0) = patternLEDList(113, 0)
        patternLEDList(112, 1) = patternLEDList(113, 1)
        patternLEDList(112, 2) = patternLEDList(113, 2)
        Button112.BackColor = Button113.BackColor
        patternLEDList(113, 0) = patternLEDList(128, 0)
        patternLEDList(113, 1) = patternLEDList(128, 1)
        patternLEDList(113, 2) = patternLEDList(128, 2)
        Button113.BackColor = Button128.BackColor
        patternLEDList(128, 0) = patternLEDList(129, 0)
        patternLEDList(128, 1) = patternLEDList(129, 1)
        patternLEDList(128, 2) = patternLEDList(129, 2)
        Button128.BackColor = Button129.BackColor
        patternLEDList(129, 0) = patternLEDList(144, 0)
        patternLEDList(129, 1) = patternLEDList(144, 1)
        patternLEDList(129, 2) = patternLEDList(144, 2)
        Button129.BackColor = Button144.BackColor
        patternLEDList(144, 0) = patternLEDList(145, 0)
        patternLEDList(144, 1) = patternLEDList(145, 1)
        patternLEDList(144, 2) = patternLEDList(145, 2)
        Button144.BackColor = Button145.BackColor
        patternLEDList(145, 0) = patternLEDList(160, 0)
        patternLEDList(145, 1) = patternLEDList(160, 1)
        patternLEDList(145, 2) = patternLEDList(160, 2)
        Button145.BackColor = Button160.BackColor
        patternLEDList(160, 0) = patternLEDList(161, 0)
        patternLEDList(160, 1) = patternLEDList(161, 1)
        patternLEDList(160, 2) = patternLEDList(161, 2)
        Button160.BackColor = Button161.BackColor
        patternLEDList(161, 0) = patternLEDList(176, 0)
        patternLEDList(161, 1) = patternLEDList(176, 1)
        patternLEDList(161, 2) = patternLEDList(176, 2)
        Button161.BackColor = Button176.BackColor
        patternLEDList(176, 0) = patternLEDList(177, 0)
        patternLEDList(176, 1) = patternLEDList(177, 1)
        patternLEDList(176, 2) = patternLEDList(177, 2)
        Button176.BackColor = Button177.BackColor
        patternLEDList(177, 0) = patternLEDList(192, 0)
        patternLEDList(177, 1) = patternLEDList(192, 1)
        patternLEDList(177, 2) = patternLEDList(192, 2)
        Button177.BackColor = Button192.BackColor
        patternLEDList(192, 0) = patternLEDList(193, 0)
        patternLEDList(192, 1) = patternLEDList(193, 1)
        patternLEDList(192, 2) = patternLEDList(193, 2)
        Button192.BackColor = Button193.BackColor
        patternLEDList(193, 0) = 0
        patternLEDList(193, 1) = 0
        patternLEDList(193, 2) = 0
        Button193.BackColor = Color.Black
    End Sub
    Sub leftr2()
        patternLEDList(2, 0) = patternLEDList(15, 0)
        patternLEDList(2, 1) = patternLEDList(15, 1)
        patternLEDList(2, 2) = patternLEDList(15, 2)
        Button2.BackColor = Button15.BackColor
        patternLEDList(15, 0) = patternLEDList(18, 0)
        patternLEDList(15, 1) = patternLEDList(18, 1)
        patternLEDList(15, 2) = patternLEDList(18, 2)
        Button15.BackColor = Button18.BackColor
        patternLEDList(18, 0) = patternLEDList(31, 0)
        patternLEDList(18, 1) = patternLEDList(31, 1)
        patternLEDList(18, 2) = patternLEDList(31, 2)
        Button18.BackColor = Button31.BackColor
        patternLEDList(31, 0) = patternLEDList(34, 0)
        patternLEDList(31, 1) = patternLEDList(34, 1)
        patternLEDList(31, 2) = patternLEDList(34, 2)
        Button31.BackColor = Button34.BackColor
        patternLEDList(34, 0) = patternLEDList(47, 0)
        patternLEDList(34, 1) = patternLEDList(47, 1)
        patternLEDList(34, 2) = patternLEDList(47, 2)
        Button34.BackColor = Button47.BackColor
        patternLEDList(47, 0) = patternLEDList(50, 0)
        patternLEDList(47, 1) = patternLEDList(50, 1)
        patternLEDList(47, 2) = patternLEDList(50, 2)
        Button47.BackColor = Button50.BackColor
        patternLEDList(50, 0) = patternLEDList(63, 0)
        patternLEDList(50, 1) = patternLEDList(63, 1)
        patternLEDList(50, 2) = patternLEDList(63, 2)
        Button50.BackColor = Button63.BackColor
        patternLEDList(63, 0) = patternLEDList(66, 0)
        patternLEDList(63, 1) = patternLEDList(66, 1)
        patternLEDList(63, 2) = patternLEDList(66, 2)
        Button63.BackColor = Button66.BackColor
        patternLEDList(66, 0) = patternLEDList(79, 0)
        patternLEDList(66, 1) = patternLEDList(79, 1)
        patternLEDList(66, 2) = patternLEDList(79, 2)
        Button66.BackColor = Button79.BackColor
        patternLEDList(79, 0) = patternLEDList(82, 0)
        patternLEDList(79, 1) = patternLEDList(82, 1)
        patternLEDList(79, 2) = patternLEDList(82, 2)
        Button79.BackColor = Button82.BackColor
        patternLEDList(82, 0) = patternLEDList(95, 0)
        patternLEDList(82, 1) = patternLEDList(95, 1)
        patternLEDList(82, 2) = patternLEDList(95, 2)
        Button82.BackColor = Button95.BackColor
        patternLEDList(95, 0) = patternLEDList(98, 0)
        patternLEDList(95, 1) = patternLEDList(98, 1)
        patternLEDList(95, 2) = patternLEDList(98, 2)
        Button95.BackColor = Button98.BackColor
        patternLEDList(98, 0) = patternLEDList(111, 0)
        patternLEDList(98, 1) = patternLEDList(111, 1)
        patternLEDList(98, 2) = patternLEDList(111, 2)
        Button98.BackColor = Button111.BackColor
        patternLEDList(111, 0) = patternLEDList(114, 0)
        patternLEDList(111, 1) = patternLEDList(114, 1)
        patternLEDList(111, 2) = patternLEDList(114, 2)
        Button111.BackColor = Button114.BackColor
        patternLEDList(114, 0) = patternLEDList(127, 0)
        patternLEDList(114, 1) = patternLEDList(127, 1)
        patternLEDList(114, 2) = patternLEDList(127, 2)
        Button114.BackColor = Button127.BackColor
        patternLEDList(127, 0) = patternLEDList(130, 0)
        patternLEDList(127, 1) = patternLEDList(130, 1)
        patternLEDList(127, 2) = patternLEDList(130, 2)
        Button127.BackColor = Button130.BackColor
        patternLEDList(130, 0) = patternLEDList(143, 0)
        patternLEDList(130, 1) = patternLEDList(143, 1)
        patternLEDList(130, 2) = patternLEDList(143, 2)
        Button130.BackColor = Button143.BackColor
        patternLEDList(143, 0) = patternLEDList(146, 0)
        patternLEDList(143, 1) = patternLEDList(146, 1)
        patternLEDList(143, 2) = patternLEDList(146, 2)
        Button143.BackColor = Button146.BackColor
        patternLEDList(146, 0) = patternLEDList(159, 0)
        patternLEDList(146, 1) = patternLEDList(159, 1)
        patternLEDList(146, 2) = patternLEDList(159, 2)
        Button146.BackColor = Button159.BackColor
        patternLEDList(159, 0) = patternLEDList(162, 0)
        patternLEDList(159, 1) = patternLEDList(162, 1)
        patternLEDList(159, 2) = patternLEDList(162, 2)
        Button159.BackColor = Button162.BackColor
        patternLEDList(162, 0) = patternLEDList(175, 0)
        patternLEDList(162, 1) = patternLEDList(175, 1)
        patternLEDList(162, 2) = patternLEDList(175, 2)
        Button162.BackColor = Button175.BackColor
        patternLEDList(175, 0) = patternLEDList(178, 0)
        patternLEDList(175, 1) = patternLEDList(178, 1)
        patternLEDList(175, 2) = patternLEDList(178, 2)
        Button175.BackColor = Button178.BackColor
        patternLEDList(178, 0) = patternLEDList(191, 0)
        patternLEDList(178, 1) = patternLEDList(191, 1)
        patternLEDList(178, 2) = patternLEDList(191, 2)
        Button178.BackColor = Button191.BackColor
        patternLEDList(191, 0) = patternLEDList(194, 0)
        patternLEDList(191, 1) = patternLEDList(194, 1)
        patternLEDList(191, 2) = patternLEDList(194, 2)
        Button191.BackColor = Button194.BackColor
        patternLEDList(194, 0) = 0
        patternLEDList(194, 1) = 0
        patternLEDList(194, 2) = 0
        Button194.BackColor = Color.Black
    End Sub
    Sub leftr3()
        patternLEDList(3, 0) = patternLEDList(14, 0)
        patternLEDList(3, 1) = patternLEDList(14, 1)
        patternLEDList(3, 2) = patternLEDList(14, 2)
        Button3.BackColor = Button14.BackColor
        patternLEDList(14, 0) = patternLEDList(19, 0)
        patternLEDList(14, 1) = patternLEDList(19, 1)
        patternLEDList(14, 2) = patternLEDList(19, 2)
        Button14.BackColor = Button19.BackColor
        patternLEDList(19, 0) = patternLEDList(30, 0)
        patternLEDList(19, 1) = patternLEDList(30, 1)
        patternLEDList(19, 2) = patternLEDList(30, 2)
        Button19.BackColor = Button30.BackColor
        patternLEDList(30, 0) = patternLEDList(35, 0)
        patternLEDList(30, 1) = patternLEDList(35, 1)
        patternLEDList(30, 2) = patternLEDList(35, 2)
        Button30.BackColor = Button35.BackColor
        patternLEDList(35, 0) = patternLEDList(46, 0)
        patternLEDList(35, 1) = patternLEDList(46, 1)
        patternLEDList(35, 2) = patternLEDList(46, 2)
        Button35.BackColor = Button46.BackColor
        patternLEDList(46, 0) = patternLEDList(51, 0)
        patternLEDList(46, 1) = patternLEDList(51, 1)
        patternLEDList(46, 2) = patternLEDList(51, 2)
        Button46.BackColor = Button51.BackColor
        patternLEDList(51, 0) = patternLEDList(62, 0)
        patternLEDList(51, 1) = patternLEDList(62, 1)
        patternLEDList(51, 2) = patternLEDList(62, 2)
        Button51.BackColor = Button62.BackColor
        patternLEDList(62, 0) = patternLEDList(67, 0)
        patternLEDList(62, 1) = patternLEDList(67, 1)
        patternLEDList(62, 2) = patternLEDList(67, 2)
        Button62.BackColor = Button67.BackColor
        patternLEDList(67, 0) = patternLEDList(78, 0)
        patternLEDList(67, 1) = patternLEDList(78, 1)
        patternLEDList(67, 2) = patternLEDList(78, 2)
        Button67.BackColor = Button78.BackColor
        patternLEDList(78, 0) = patternLEDList(83, 0)
        patternLEDList(78, 1) = patternLEDList(83, 1)
        patternLEDList(78, 2) = patternLEDList(83, 2)
        Button78.BackColor = Button83.BackColor
        patternLEDList(83, 0) = patternLEDList(94, 0)
        patternLEDList(83, 1) = patternLEDList(94, 1)
        patternLEDList(83, 2) = patternLEDList(94, 2)
        Button83.BackColor = Button94.BackColor
        patternLEDList(94, 0) = patternLEDList(99, 0)
        patternLEDList(94, 1) = patternLEDList(99, 1)
        patternLEDList(94, 2) = patternLEDList(99, 2)
        Button94.BackColor = Button99.BackColor
        patternLEDList(99, 0) = patternLEDList(110, 0)
        patternLEDList(99, 1) = patternLEDList(110, 1)
        patternLEDList(99, 2) = patternLEDList(110, 2)
        Button99.BackColor = Button110.BackColor
        patternLEDList(110, 0) = patternLEDList(115, 0)
        patternLEDList(110, 1) = patternLEDList(115, 1)
        patternLEDList(110, 2) = patternLEDList(115, 2)
        Button110.BackColor = Button115.BackColor
        patternLEDList(115, 0) = patternLEDList(126, 0)
        patternLEDList(115, 1) = patternLEDList(126, 1)
        patternLEDList(115, 2) = patternLEDList(126, 2)
        Button115.BackColor = Button126.BackColor
        patternLEDList(126, 0) = patternLEDList(131, 0)
        patternLEDList(126, 1) = patternLEDList(131, 1)
        patternLEDList(126, 2) = patternLEDList(131, 2)
        Button126.BackColor = Button131.BackColor
        patternLEDList(131, 0) = patternLEDList(142, 0)
        patternLEDList(131, 1) = patternLEDList(142, 1)
        patternLEDList(131, 2) = patternLEDList(142, 2)
        Button131.BackColor = Button142.BackColor
        patternLEDList(142, 0) = patternLEDList(147, 0)
        patternLEDList(142, 1) = patternLEDList(147, 1)
        patternLEDList(142, 2) = patternLEDList(147, 2)
        Button142.BackColor = Button147.BackColor
        patternLEDList(147, 0) = patternLEDList(158, 0)
        patternLEDList(147, 1) = patternLEDList(158, 1)
        patternLEDList(147, 2) = patternLEDList(158, 2)
        Button147.BackColor = Button158.BackColor
        patternLEDList(158, 0) = patternLEDList(163, 0)
        patternLEDList(158, 1) = patternLEDList(163, 1)
        patternLEDList(158, 2) = patternLEDList(163, 2)
        Button158.BackColor = Button163.BackColor
        patternLEDList(163, 0) = patternLEDList(174, 0)
        patternLEDList(163, 1) = patternLEDList(174, 1)
        patternLEDList(163, 2) = patternLEDList(174, 2)
        Button163.BackColor = Button174.BackColor
        patternLEDList(174, 0) = patternLEDList(179, 0)
        patternLEDList(174, 1) = patternLEDList(179, 1)
        patternLEDList(174, 2) = patternLEDList(179, 2)
        Button174.BackColor = Button179.BackColor
        patternLEDList(179, 0) = patternLEDList(190, 0)
        patternLEDList(179, 1) = patternLEDList(190, 1)
        patternLEDList(179, 2) = patternLEDList(190, 2)
        Button179.BackColor = Button190.BackColor
        patternLEDList(190, 0) = patternLEDList(195, 0)
        patternLEDList(190, 1) = patternLEDList(195, 1)
        patternLEDList(190, 2) = patternLEDList(195, 2)
        Button190.BackColor = Button195.BackColor
        patternLEDList(195, 0) = 0
        patternLEDList(195, 1) = 0
        patternLEDList(195, 2) = 0
        Button195.BackColor = Color.Black
    End Sub
    Sub leftr4()
        patternLEDList(4, 0) = patternLEDList(13, 0)
        patternLEDList(4, 1) = patternLEDList(13, 1)
        patternLEDList(4, 2) = patternLEDList(13, 2)
        Button4.BackColor = Button13.BackColor
        patternLEDList(13, 0) = patternLEDList(20, 0)
        patternLEDList(13, 1) = patternLEDList(20, 1)
        patternLEDList(13, 2) = patternLEDList(20, 2)
        Button13.BackColor = Button20.BackColor
        patternLEDList(20, 0) = patternLEDList(29, 0)
        patternLEDList(20, 1) = patternLEDList(29, 1)
        patternLEDList(20, 2) = patternLEDList(29, 2)
        Button20.BackColor = Button29.BackColor
        patternLEDList(29, 0) = patternLEDList(36, 0)
        patternLEDList(29, 1) = patternLEDList(36, 1)
        patternLEDList(29, 2) = patternLEDList(36, 2)
        Button29.BackColor = Button36.BackColor
        patternLEDList(36, 0) = patternLEDList(45, 0)
        patternLEDList(36, 1) = patternLEDList(45, 1)
        patternLEDList(36, 2) = patternLEDList(45, 2)
        Button36.BackColor = Button45.BackColor
        patternLEDList(45, 0) = patternLEDList(52, 0)
        patternLEDList(45, 1) = patternLEDList(52, 1)
        patternLEDList(45, 2) = patternLEDList(52, 2)
        Button45.BackColor = Button52.BackColor
        patternLEDList(52, 0) = patternLEDList(61, 0)
        patternLEDList(52, 1) = patternLEDList(61, 1)
        patternLEDList(52, 2) = patternLEDList(61, 2)
        Button52.BackColor = Button61.BackColor
        patternLEDList(61, 0) = patternLEDList(68, 0)
        patternLEDList(61, 1) = patternLEDList(68, 1)
        patternLEDList(61, 2) = patternLEDList(68, 2)
        Button61.BackColor = Button68.BackColor
        patternLEDList(68, 0) = patternLEDList(77, 0)
        patternLEDList(68, 1) = patternLEDList(77, 1)
        patternLEDList(68, 2) = patternLEDList(77, 2)
        Button68.BackColor = Button77.BackColor
        patternLEDList(77, 0) = patternLEDList(84, 0)
        patternLEDList(77, 1) = patternLEDList(84, 1)
        patternLEDList(77, 2) = patternLEDList(84, 2)
        Button77.BackColor = Button84.BackColor
        patternLEDList(84, 0) = patternLEDList(93, 0)
        patternLEDList(84, 1) = patternLEDList(93, 1)
        patternLEDList(84, 2) = patternLEDList(93, 2)
        Button84.BackColor = Button93.BackColor
        patternLEDList(93, 0) = patternLEDList(100, 0)
        patternLEDList(93, 1) = patternLEDList(100, 1)
        patternLEDList(93, 2) = patternLEDList(100, 2)
        Button93.BackColor = Button100.BackColor
        patternLEDList(100, 0) = patternLEDList(109, 0)
        patternLEDList(100, 1) = patternLEDList(109, 1)
        patternLEDList(100, 2) = patternLEDList(109, 2)
        Button100.BackColor = Button109.BackColor
        patternLEDList(109, 0) = patternLEDList(116, 0)
        patternLEDList(109, 1) = patternLEDList(116, 1)
        patternLEDList(109, 2) = patternLEDList(116, 2)
        Button109.BackColor = Button116.BackColor
        patternLEDList(116, 0) = patternLEDList(125, 0)
        patternLEDList(116, 1) = patternLEDList(125, 1)
        patternLEDList(116, 2) = patternLEDList(125, 2)
        Button116.BackColor = Button125.BackColor
        patternLEDList(125, 0) = patternLEDList(132, 0)
        patternLEDList(125, 1) = patternLEDList(132, 1)
        patternLEDList(125, 2) = patternLEDList(132, 2)
        Button125.BackColor = Button132.BackColor
        patternLEDList(132, 0) = patternLEDList(141, 0)
        patternLEDList(132, 1) = patternLEDList(141, 1)
        patternLEDList(132, 2) = patternLEDList(141, 2)
        Button132.BackColor = Button141.BackColor
        patternLEDList(141, 0) = patternLEDList(148, 0)
        patternLEDList(141, 1) = patternLEDList(148, 1)
        patternLEDList(141, 2) = patternLEDList(148, 2)
        Button141.BackColor = Button148.BackColor
        patternLEDList(148, 0) = patternLEDList(157, 0)
        patternLEDList(148, 1) = patternLEDList(157, 1)
        patternLEDList(148, 2) = patternLEDList(157, 2)
        Button148.BackColor = Button157.BackColor
        patternLEDList(157, 0) = patternLEDList(164, 0)
        patternLEDList(157, 1) = patternLEDList(164, 1)
        patternLEDList(157, 2) = patternLEDList(164, 2)
        Button157.BackColor = Button164.BackColor
        patternLEDList(164, 0) = patternLEDList(173, 0)
        patternLEDList(164, 1) = patternLEDList(173, 1)
        patternLEDList(164, 2) = patternLEDList(173, 2)
        Button164.BackColor = Button173.BackColor
        patternLEDList(173, 0) = patternLEDList(180, 0)
        patternLEDList(173, 1) = patternLEDList(180, 1)
        patternLEDList(173, 2) = patternLEDList(180, 2)
        Button173.BackColor = Button180.BackColor
        patternLEDList(180, 0) = patternLEDList(189, 0)
        patternLEDList(180, 1) = patternLEDList(189, 1)
        patternLEDList(180, 2) = patternLEDList(189, 2)
        Button180.BackColor = Button189.BackColor
        patternLEDList(189, 0) = patternLEDList(196, 0)
        patternLEDList(189, 1) = patternLEDList(196, 1)
        patternLEDList(189, 2) = patternLEDList(196, 2)
        Button189.BackColor = Button196.BackColor
        patternLEDList(196, 0) = 0
        patternLEDList(196, 1) = 0
        patternLEDList(196, 2) = 0
        Button196.BackColor = Color.Black
    End Sub
    Sub leftr5()
        patternLEDList(5, 0) = patternLEDList(12, 0)
        patternLEDList(5, 1) = patternLEDList(12, 1)
        patternLEDList(5, 2) = patternLEDList(12, 2)
        Button5.BackColor = Button12.BackColor
        patternLEDList(12, 0) = patternLEDList(21, 0)
        patternLEDList(12, 1) = patternLEDList(21, 1)
        patternLEDList(12, 2) = patternLEDList(21, 2)
        Button12.BackColor = Button21.BackColor
        patternLEDList(21, 0) = patternLEDList(28, 0)
        patternLEDList(21, 1) = patternLEDList(28, 1)
        patternLEDList(21, 2) = patternLEDList(28, 2)
        Button21.BackColor = Button28.BackColor
        patternLEDList(28, 0) = patternLEDList(37, 0)
        patternLEDList(28, 1) = patternLEDList(37, 1)
        patternLEDList(28, 2) = patternLEDList(37, 2)
        Button28.BackColor = Button37.BackColor
        patternLEDList(37, 0) = patternLEDList(44, 0)
        patternLEDList(37, 1) = patternLEDList(44, 1)
        patternLEDList(37, 2) = patternLEDList(44, 2)
        Button37.BackColor = Button44.BackColor
        patternLEDList(44, 0) = patternLEDList(53, 0)
        patternLEDList(44, 1) = patternLEDList(53, 1)
        patternLEDList(44, 2) = patternLEDList(53, 2)
        Button44.BackColor = Button53.BackColor
        patternLEDList(53, 0) = patternLEDList(60, 0)
        patternLEDList(53, 1) = patternLEDList(60, 1)
        patternLEDList(53, 2) = patternLEDList(60, 2)
        Button53.BackColor = Button60.BackColor
        patternLEDList(60, 0) = patternLEDList(69, 0)
        patternLEDList(60, 1) = patternLEDList(69, 1)
        patternLEDList(60, 2) = patternLEDList(69, 2)
        Button60.BackColor = Button69.BackColor
        patternLEDList(69, 0) = patternLEDList(76, 0)
        patternLEDList(69, 1) = patternLEDList(76, 1)
        patternLEDList(69, 2) = patternLEDList(76, 2)
        Button69.BackColor = Button76.BackColor
        patternLEDList(76, 0) = patternLEDList(85, 0)
        patternLEDList(76, 1) = patternLEDList(85, 1)
        patternLEDList(76, 2) = patternLEDList(85, 2)
        Button76.BackColor = Button85.BackColor
        patternLEDList(85, 0) = patternLEDList(92, 0)
        patternLEDList(85, 1) = patternLEDList(92, 1)
        patternLEDList(85, 2) = patternLEDList(92, 2)
        Button85.BackColor = Button92.BackColor
        patternLEDList(92, 0) = patternLEDList(101, 0)
        patternLEDList(92, 1) = patternLEDList(101, 1)
        patternLEDList(92, 2) = patternLEDList(101, 2)
        Button92.BackColor = Button101.BackColor
        patternLEDList(101, 0) = patternLEDList(108, 0)
        patternLEDList(101, 1) = patternLEDList(108, 1)
        patternLEDList(101, 2) = patternLEDList(108, 2)
        Button101.BackColor = Button108.BackColor
        patternLEDList(108, 0) = patternLEDList(117, 0)
        patternLEDList(108, 1) = patternLEDList(117, 1)
        patternLEDList(108, 2) = patternLEDList(117, 2)
        Button108.BackColor = Button117.BackColor
        patternLEDList(117, 0) = patternLEDList(124, 0)
        patternLEDList(117, 1) = patternLEDList(124, 1)
        patternLEDList(117, 2) = patternLEDList(124, 2)
        Button117.BackColor = Button124.BackColor
        patternLEDList(124, 0) = patternLEDList(133, 0)
        patternLEDList(124, 1) = patternLEDList(133, 1)
        patternLEDList(124, 2) = patternLEDList(133, 2)
        Button124.BackColor = Button133.BackColor
        patternLEDList(133, 0) = patternLEDList(140, 0)
        patternLEDList(133, 1) = patternLEDList(140, 1)
        patternLEDList(133, 2) = patternLEDList(140, 2)
        Button133.BackColor = Button140.BackColor
        patternLEDList(140, 0) = patternLEDList(149, 0)
        patternLEDList(140, 1) = patternLEDList(149, 1)
        patternLEDList(140, 2) = patternLEDList(149, 2)
        Button140.BackColor = Button149.BackColor
        patternLEDList(149, 0) = patternLEDList(156, 0)
        patternLEDList(149, 1) = patternLEDList(156, 1)
        patternLEDList(149, 2) = patternLEDList(156, 2)
        Button149.BackColor = Button156.BackColor
        patternLEDList(156, 0) = patternLEDList(165, 0)
        patternLEDList(156, 1) = patternLEDList(165, 1)
        patternLEDList(156, 2) = patternLEDList(165, 2)
        Button156.BackColor = Button165.BackColor
        patternLEDList(165, 0) = patternLEDList(172, 0)
        patternLEDList(165, 1) = patternLEDList(172, 1)
        patternLEDList(165, 2) = patternLEDList(172, 2)
        Button165.BackColor = Button172.BackColor
        patternLEDList(172, 0) = patternLEDList(181, 0)
        patternLEDList(172, 1) = patternLEDList(181, 1)
        patternLEDList(172, 2) = patternLEDList(181, 2)
        Button172.BackColor = Button181.BackColor
        patternLEDList(181, 0) = patternLEDList(188, 0)
        patternLEDList(181, 1) = patternLEDList(188, 1)
        patternLEDList(181, 2) = patternLEDList(188, 2)
        Button181.BackColor = Button188.BackColor
        patternLEDList(188, 0) = patternLEDList(197, 0)
        patternLEDList(188, 1) = patternLEDList(197, 1)
        patternLEDList(188, 2) = patternLEDList(197, 2)
        Button188.BackColor = Button197.BackColor
        patternLEDList(197, 0) = 0
        patternLEDList(197, 1) = 0
        patternLEDList(197, 2) = 0
        Button197.BackColor = Color.Black
    End Sub
    Sub leftr6()
        patternLEDList(6, 0) = patternLEDList(11, 0)
        patternLEDList(6, 1) = patternLEDList(11, 1)
        patternLEDList(6, 2) = patternLEDList(11, 2)
        Button6.BackColor = Button11.BackColor
        patternLEDList(11, 0) = patternLEDList(22, 0)
        patternLEDList(11, 1) = patternLEDList(22, 1)
        patternLEDList(11, 2) = patternLEDList(22, 2)
        Button11.BackColor = Button22.BackColor
        patternLEDList(22, 0) = patternLEDList(27, 0)
        patternLEDList(22, 1) = patternLEDList(27, 1)
        patternLEDList(22, 2) = patternLEDList(27, 2)
        Button22.BackColor = Button27.BackColor
        patternLEDList(27, 0) = patternLEDList(38, 0)
        patternLEDList(27, 1) = patternLEDList(38, 1)
        patternLEDList(27, 2) = patternLEDList(38, 2)
        Button27.BackColor = Button38.BackColor
        patternLEDList(38, 0) = patternLEDList(43, 0)
        patternLEDList(38, 1) = patternLEDList(43, 1)
        patternLEDList(38, 2) = patternLEDList(43, 2)
        Button38.BackColor = Button43.BackColor
        patternLEDList(43, 0) = patternLEDList(54, 0)
        patternLEDList(43, 1) = patternLEDList(54, 1)
        patternLEDList(43, 2) = patternLEDList(54, 2)
        Button43.BackColor = Button54.BackColor
        patternLEDList(54, 0) = patternLEDList(59, 0)
        patternLEDList(54, 1) = patternLEDList(59, 1)
        patternLEDList(54, 2) = patternLEDList(59, 2)
        Button54.BackColor = Button59.BackColor
        patternLEDList(59, 0) = patternLEDList(70, 0)
        patternLEDList(59, 1) = patternLEDList(70, 1)
        patternLEDList(59, 2) = patternLEDList(70, 2)
        Button59.BackColor = Button70.BackColor
        patternLEDList(70, 0) = patternLEDList(75, 0)
        patternLEDList(70, 1) = patternLEDList(75, 1)
        patternLEDList(70, 2) = patternLEDList(75, 2)
        Button70.BackColor = Button75.BackColor
        patternLEDList(75, 0) = patternLEDList(86, 0)
        patternLEDList(75, 1) = patternLEDList(86, 1)
        patternLEDList(75, 2) = patternLEDList(86, 2)
        Button75.BackColor = Button86.BackColor
        patternLEDList(86, 0) = patternLEDList(91, 0)
        patternLEDList(86, 1) = patternLEDList(91, 1)
        patternLEDList(86, 2) = patternLEDList(91, 2)
        Button86.BackColor = Button91.BackColor
        patternLEDList(91, 0) = patternLEDList(102, 0)
        patternLEDList(91, 1) = patternLEDList(102, 1)
        patternLEDList(91, 2) = patternLEDList(102, 2)
        Button91.BackColor = Button102.BackColor
        patternLEDList(102, 0) = patternLEDList(107, 0)
        patternLEDList(102, 1) = patternLEDList(107, 1)
        patternLEDList(102, 2) = patternLEDList(107, 2)
        Button102.BackColor = Button107.BackColor
        patternLEDList(107, 0) = patternLEDList(118, 0)
        patternLEDList(107, 1) = patternLEDList(118, 1)
        patternLEDList(107, 2) = patternLEDList(118, 2)
        Button107.BackColor = Button118.BackColor
        patternLEDList(118, 0) = patternLEDList(123, 0)
        patternLEDList(118, 1) = patternLEDList(123, 1)
        patternLEDList(118, 2) = patternLEDList(123, 2)
        Button118.BackColor = Button123.BackColor
        patternLEDList(123, 0) = patternLEDList(134, 0)
        patternLEDList(123, 1) = patternLEDList(134, 1)
        patternLEDList(123, 2) = patternLEDList(134, 2)
        Button123.BackColor = Button134.BackColor
        patternLEDList(134, 0) = patternLEDList(139, 0)
        patternLEDList(134, 1) = patternLEDList(139, 1)
        patternLEDList(134, 2) = patternLEDList(139, 2)
        Button134.BackColor = Button139.BackColor
        patternLEDList(139, 0) = patternLEDList(150, 0)
        patternLEDList(139, 1) = patternLEDList(150, 1)
        patternLEDList(139, 2) = patternLEDList(150, 2)
        Button139.BackColor = Button150.BackColor
        patternLEDList(150, 0) = patternLEDList(155, 0)
        patternLEDList(150, 1) = patternLEDList(155, 1)
        patternLEDList(150, 2) = patternLEDList(155, 2)
        Button150.BackColor = Button155.BackColor
        patternLEDList(155, 0) = patternLEDList(166, 0)
        patternLEDList(155, 1) = patternLEDList(166, 1)
        patternLEDList(155, 2) = patternLEDList(166, 2)
        Button155.BackColor = Button166.BackColor
        patternLEDList(166, 0) = patternLEDList(171, 0)
        patternLEDList(166, 1) = patternLEDList(171, 1)
        patternLEDList(166, 2) = patternLEDList(171, 2)
        Button166.BackColor = Button171.BackColor
        patternLEDList(171, 0) = patternLEDList(182, 0)
        patternLEDList(171, 1) = patternLEDList(182, 1)
        patternLEDList(171, 2) = patternLEDList(182, 2)
        Button171.BackColor = Button182.BackColor
        patternLEDList(182, 0) = patternLEDList(187, 0)
        patternLEDList(182, 1) = patternLEDList(187, 1)
        patternLEDList(182, 2) = patternLEDList(187, 2)
        Button182.BackColor = Button187.BackColor
        patternLEDList(187, 0) = patternLEDList(198, 0)
        patternLEDList(187, 1) = patternLEDList(198, 1)
        patternLEDList(187, 2) = patternLEDList(198, 2)
        Button187.BackColor = Button198.BackColor
        patternLEDList(198, 0) = 0
        patternLEDList(198, 1) = 0
        patternLEDList(198, 2) = 0
        Button198.BackColor = Color.Black
    End Sub
    Sub leftr7()
        patternLEDList(7, 0) = patternLEDList(10, 0)
        patternLEDList(7, 1) = patternLEDList(10, 1)
        patternLEDList(7, 2) = patternLEDList(10, 2)
        Button7.BackColor = Button10.BackColor
        patternLEDList(10, 0) = patternLEDList(23, 0)
        patternLEDList(10, 1) = patternLEDList(23, 1)
        patternLEDList(10, 2) = patternLEDList(23, 2)
        Button10.BackColor = Button23.BackColor
        patternLEDList(23, 0) = patternLEDList(26, 0)
        patternLEDList(23, 1) = patternLEDList(26, 1)
        patternLEDList(23, 2) = patternLEDList(26, 2)
        Button23.BackColor = Button26.BackColor
        patternLEDList(26, 0) = patternLEDList(39, 0)
        patternLEDList(26, 1) = patternLEDList(39, 1)
        patternLEDList(26, 2) = patternLEDList(39, 2)
        Button26.BackColor = Button39.BackColor
        patternLEDList(39, 0) = patternLEDList(42, 0)
        patternLEDList(39, 1) = patternLEDList(42, 1)
        patternLEDList(39, 2) = patternLEDList(42, 2)
        Button39.BackColor = Button42.BackColor
        patternLEDList(42, 0) = patternLEDList(55, 0)
        patternLEDList(42, 1) = patternLEDList(55, 1)
        patternLEDList(42, 2) = patternLEDList(55, 2)
        Button42.BackColor = Button55.BackColor
        patternLEDList(55, 0) = patternLEDList(58, 0)
        patternLEDList(55, 1) = patternLEDList(58, 1)
        patternLEDList(55, 2) = patternLEDList(58, 2)
        Button55.BackColor = Button58.BackColor
        patternLEDList(58, 0) = patternLEDList(71, 0)
        patternLEDList(58, 1) = patternLEDList(71, 1)
        patternLEDList(58, 2) = patternLEDList(71, 2)
        Button58.BackColor = Button71.BackColor
        patternLEDList(71, 0) = patternLEDList(74, 0)
        patternLEDList(71, 1) = patternLEDList(74, 1)
        patternLEDList(71, 2) = patternLEDList(74, 2)
        Button71.BackColor = Button74.BackColor
        patternLEDList(74, 0) = patternLEDList(87, 0)
        patternLEDList(74, 1) = patternLEDList(87, 1)
        patternLEDList(74, 2) = patternLEDList(87, 2)
        Button74.BackColor = Button87.BackColor
        patternLEDList(87, 0) = patternLEDList(90, 0)
        patternLEDList(87, 1) = patternLEDList(90, 1)
        patternLEDList(87, 2) = patternLEDList(90, 2)
        Button87.BackColor = Button90.BackColor
        patternLEDList(90, 0) = patternLEDList(103, 0)
        patternLEDList(90, 1) = patternLEDList(103, 1)
        patternLEDList(90, 2) = patternLEDList(103, 2)
        Button90.BackColor = Button103.BackColor
        patternLEDList(103, 0) = patternLEDList(106, 0)
        patternLEDList(103, 1) = patternLEDList(106, 1)
        patternLEDList(103, 2) = patternLEDList(106, 2)
        Button103.BackColor = Button106.BackColor
        patternLEDList(106, 0) = patternLEDList(119, 0)
        patternLEDList(106, 1) = patternLEDList(119, 1)
        patternLEDList(106, 2) = patternLEDList(119, 2)
        Button106.BackColor = Button119.BackColor
        patternLEDList(119, 0) = patternLEDList(122, 0)
        patternLEDList(119, 1) = patternLEDList(122, 1)
        patternLEDList(119, 2) = patternLEDList(122, 2)
        Button119.BackColor = Button122.BackColor
        patternLEDList(122, 0) = patternLEDList(135, 0)
        patternLEDList(122, 1) = patternLEDList(135, 1)
        patternLEDList(122, 2) = patternLEDList(135, 2)
        Button122.BackColor = Button135.BackColor
        patternLEDList(135, 0) = patternLEDList(138, 0)
        patternLEDList(135, 1) = patternLEDList(138, 1)
        patternLEDList(135, 2) = patternLEDList(138, 2)
        Button135.BackColor = Button138.BackColor
        patternLEDList(138, 0) = patternLEDList(151, 0)
        patternLEDList(138, 1) = patternLEDList(151, 1)
        patternLEDList(138, 2) = patternLEDList(151, 2)
        Button138.BackColor = Button151.BackColor
        patternLEDList(151, 0) = patternLEDList(154, 0)
        patternLEDList(151, 1) = patternLEDList(154, 1)
        patternLEDList(151, 2) = patternLEDList(154, 2)
        Button151.BackColor = Button154.BackColor
        patternLEDList(154, 0) = patternLEDList(167, 0)
        patternLEDList(154, 1) = patternLEDList(167, 1)
        patternLEDList(154, 2) = patternLEDList(167, 2)
        Button154.BackColor = Button167.BackColor
        patternLEDList(167, 0) = patternLEDList(170, 0)
        patternLEDList(167, 1) = patternLEDList(170, 1)
        patternLEDList(167, 2) = patternLEDList(170, 2)
        Button167.BackColor = Button170.BackColor
        patternLEDList(170, 0) = patternLEDList(183, 0)
        patternLEDList(170, 1) = patternLEDList(183, 1)
        patternLEDList(170, 2) = patternLEDList(183, 2)
        Button170.BackColor = Button183.BackColor
        patternLEDList(183, 0) = patternLEDList(186, 0)
        patternLEDList(183, 1) = patternLEDList(186, 1)
        patternLEDList(183, 2) = patternLEDList(186, 2)
        Button183.BackColor = Button186.BackColor
        patternLEDList(186, 0) = patternLEDList(199, 0)
        patternLEDList(186, 1) = patternLEDList(199, 1)
        patternLEDList(186, 2) = patternLEDList(199, 2)
        Button186.BackColor = Button199.BackColor
        patternLEDList(199, 0) = 0
        patternLEDList(199, 1) = 0
        patternLEDList(199, 2) = 0
        Button199.BackColor = Color.Black
    End Sub
    Sub leftr8()
        patternLEDList(8, 0) = patternLEDList(9, 0)
        patternLEDList(8, 1) = patternLEDList(9, 1)
        patternLEDList(8, 2) = patternLEDList(9, 2)
        Button8.BackColor = Button9.BackColor
        patternLEDList(9, 0) = patternLEDList(24, 0)
        patternLEDList(9, 1) = patternLEDList(24, 1)
        patternLEDList(9, 2) = patternLEDList(24, 2)
        Button9.BackColor = Button24.BackColor
        patternLEDList(24, 0) = patternLEDList(25, 0)
        patternLEDList(24, 1) = patternLEDList(25, 1)
        patternLEDList(24, 2) = patternLEDList(25, 2)
        Button24.BackColor = Button25.BackColor
        patternLEDList(25, 0) = patternLEDList(40, 0)
        patternLEDList(25, 1) = patternLEDList(40, 1)
        patternLEDList(25, 2) = patternLEDList(40, 2)
        Button25.BackColor = Button40.BackColor
        patternLEDList(40, 0) = patternLEDList(41, 0)
        patternLEDList(40, 1) = patternLEDList(41, 1)
        patternLEDList(40, 2) = patternLEDList(41, 2)
        Button40.BackColor = Button41.BackColor
        patternLEDList(41, 0) = patternLEDList(56, 0)
        patternLEDList(41, 1) = patternLEDList(56, 1)
        patternLEDList(41, 2) = patternLEDList(56, 2)
        Button41.BackColor = Button56.BackColor
        patternLEDList(56, 0) = patternLEDList(57, 0)
        patternLEDList(56, 1) = patternLEDList(57, 1)
        patternLEDList(56, 2) = patternLEDList(57, 2)
        Button56.BackColor = Button57.BackColor
        patternLEDList(57, 0) = patternLEDList(72, 0)
        patternLEDList(57, 1) = patternLEDList(72, 1)
        patternLEDList(57, 2) = patternLEDList(72, 2)
        Button57.BackColor = Button72.BackColor
        patternLEDList(72, 0) = patternLEDList(73, 0)
        patternLEDList(72, 1) = patternLEDList(73, 1)
        patternLEDList(72, 2) = patternLEDList(73, 2)
        Button72.BackColor = Button73.BackColor
        patternLEDList(73, 0) = patternLEDList(88, 0)
        patternLEDList(73, 1) = patternLEDList(88, 1)
        patternLEDList(73, 2) = patternLEDList(88, 2)
        Button73.BackColor = Button88.BackColor
        patternLEDList(88, 0) = patternLEDList(89, 0)
        patternLEDList(88, 1) = patternLEDList(89, 1)
        patternLEDList(88, 2) = patternLEDList(89, 2)
        Button88.BackColor = Button89.BackColor
        patternLEDList(89, 0) = patternLEDList(104, 0)
        patternLEDList(89, 1) = patternLEDList(104, 1)
        patternLEDList(89, 2) = patternLEDList(104, 2)
        Button89.BackColor = Button104.BackColor
        patternLEDList(104, 0) = patternLEDList(105, 0)
        patternLEDList(104, 1) = patternLEDList(105, 1)
        patternLEDList(104, 2) = patternLEDList(105, 2)
        Button104.BackColor = Button105.BackColor
        patternLEDList(105, 0) = patternLEDList(120, 0)
        patternLEDList(105, 1) = patternLEDList(120, 1)
        patternLEDList(105, 2) = patternLEDList(120, 2)
        Button105.BackColor = Button120.BackColor
        patternLEDList(120, 0) = patternLEDList(121, 0)
        patternLEDList(120, 1) = patternLEDList(121, 1)
        patternLEDList(120, 2) = patternLEDList(121, 2)
        Button120.BackColor = Button121.BackColor
        patternLEDList(121, 0) = patternLEDList(136, 0)
        patternLEDList(121, 1) = patternLEDList(136, 1)
        patternLEDList(121, 2) = patternLEDList(136, 2)
        Button121.BackColor = Button136.BackColor
        patternLEDList(136, 0) = patternLEDList(137, 0)
        patternLEDList(136, 1) = patternLEDList(137, 1)
        patternLEDList(136, 2) = patternLEDList(137, 2)
        Button136.BackColor = Button137.BackColor
        patternLEDList(137, 0) = patternLEDList(152, 0)
        patternLEDList(137, 1) = patternLEDList(152, 1)
        patternLEDList(137, 2) = patternLEDList(152, 2)
        Button137.BackColor = Button152.BackColor
        patternLEDList(152, 0) = patternLEDList(153, 0)
        patternLEDList(152, 1) = patternLEDList(153, 1)
        patternLEDList(152, 2) = patternLEDList(153, 2)
        Button152.BackColor = Button153.BackColor
        patternLEDList(153, 0) = patternLEDList(168, 0)
        patternLEDList(153, 1) = patternLEDList(168, 1)
        patternLEDList(153, 2) = patternLEDList(168, 2)
        Button153.BackColor = Button168.BackColor
        patternLEDList(168, 0) = patternLEDList(169, 0)
        patternLEDList(168, 1) = patternLEDList(169, 1)
        patternLEDList(168, 2) = patternLEDList(169, 2)
        Button168.BackColor = Button169.BackColor
        patternLEDList(169, 0) = patternLEDList(184, 0)
        patternLEDList(169, 1) = patternLEDList(184, 1)
        patternLEDList(169, 2) = patternLEDList(184, 2)
        Button169.BackColor = Button184.BackColor
        patternLEDList(184, 0) = patternLEDList(185, 0)
        patternLEDList(184, 1) = patternLEDList(185, 1)
        patternLEDList(184, 2) = patternLEDList(185, 2)
        Button184.BackColor = Button185.BackColor
        patternLEDList(185, 0) = patternLEDList(200, 0)
        patternLEDList(185, 1) = patternLEDList(200, 1)
        patternLEDList(185, 2) = patternLEDList(200, 2)
        Button185.BackColor = Button200.BackColor
        patternLEDList(200, 0) = 0
        patternLEDList(200, 1) = 0
        patternLEDList(200, 2) = 0
        Button200.BackColor = Color.Black
    End Sub

    Private Sub Button201_Click(sender As Object, e As EventArgs) Handles Button201.Click
        upc1()
        setarraydisply()

    End Sub

    Private Sub Button202_Click(sender As Object, e As EventArgs) Handles Button202.Click
        upc2()
        setarraydisply()

    End Sub

    Private Sub Button203_Click(sender As Object, e As EventArgs) Handles Button203.Click
        upc3()
        setarraydisply()
    End Sub

    Private Sub Button204_Click(sender As Object, e As EventArgs) Handles Button204.Click
        upc4()
        setarraydisply()
    End Sub

    Private Sub Button205_Click(sender As Object, e As EventArgs) Handles Button205.Click
        upc5()
        setarraydisply()
    End Sub

    Private Sub Button206_Click(sender As Object, e As EventArgs) Handles Button206.Click
        upc6()
        setarraydisply()
    End Sub

    Private Sub Button207_Click(sender As Object, e As EventArgs) Handles Button207.Click
        upc7()
        setarraydisply()
    End Sub

    Private Sub Button208_Click(sender As Object, e As EventArgs) Handles Button208.Click
        upc8()
        setarraydisply()
    End Sub

    Private Sub Button209_Click(sender As Object, e As EventArgs) Handles Button209.Click
        upc9()
        setarraydisply()
    End Sub

    Private Sub Button210_Click(sender As Object, e As EventArgs) Handles Button210.Click
        upc10()
        setarraydisply()
    End Sub

    Private Sub Button211_Click(sender As Object, e As EventArgs) Handles Button211.Click
        upc11()
        setarraydisply()
    End Sub

    Private Sub Button212_Click(sender As Object, e As EventArgs) Handles Button212.Click
        upc12()
        setarraydisply()
    End Sub

    Private Sub Button213_Click(sender As Object, e As EventArgs) Handles Button213.Click
        upc13()
        setarraydisply()
    End Sub

    Private Sub Button214_Click(sender As Object, e As EventArgs) Handles Button214.Click
        upc14()
        setarraydisply()
    End Sub

    Private Sub Button215_Click(sender As Object, e As EventArgs) Handles Button215.Click
        upc15()
        setarraydisply()
    End Sub

    Private Sub Button216_Click(sender As Object, e As EventArgs) Handles Button216.Click
        upc16()
        setarraydisply()
    End Sub

    Private Sub Button217_Click(sender As Object, e As EventArgs) Handles Button217.Click
        upc17()
        setarraydisply()
    End Sub

    Private Sub Button218_Click(sender As Object, e As EventArgs) Handles Button218.Click
        upc18()
        setarraydisply()
    End Sub

    Private Sub Button219_Click(sender As Object, e As EventArgs) Handles Button219.Click
        upc19()
        setarraydisply()
    End Sub

    Private Sub Button220_Click(sender As Object, e As EventArgs) Handles Button220.Click
        upc20()
        setarraydisply()
    End Sub

    Private Sub Button221_Click(sender As Object, e As EventArgs) Handles Button221.Click
        upc21()
        setarraydisply()
    End Sub

    Private Sub Button222_Click(sender As Object, e As EventArgs) Handles Button222.Click
        upc22()
        setarraydisply()
    End Sub

    Private Sub Button223_Click(sender As Object, e As EventArgs) Handles Button223.Click
        upc23()
        setarraydisply()
    End Sub

    Private Sub Button224_Click(sender As Object, e As EventArgs) Handles Button224.Click
        upc24()
        setarraydisply()
    End Sub

    Private Sub Button225_Click(sender As Object, e As EventArgs) Handles Button225.Click
        upc25()
        setarraydisply()
    End Sub

    Private Sub Button250_Click(sender As Object, e As EventArgs) Handles Button250.Click
        downc1()
        setarraydisply()
    End Sub

    Private Sub Button249_Click(sender As Object, e As EventArgs) Handles Button249.Click
        downc2()
        setarraydisply()
    End Sub

    Private Sub Button248_Click(sender As Object, e As EventArgs) Handles Button248.Click
        downc3()
        setarraydisply()
    End Sub

    Private Sub Button247_Click(sender As Object, e As EventArgs) Handles Button247.Click
        downc4()
        setarraydisply()
    End Sub

    Private Sub Button246_Click(sender As Object, e As EventArgs) Handles Button246.Click
        downc5()
        setarraydisply()
    End Sub

    Private Sub Button245_Click(sender As Object, e As EventArgs) Handles Button245.Click
        downc6()
        setarraydisply()
    End Sub

    Private Sub Button244_Click(sender As Object, e As EventArgs) Handles Button244.Click
        downc7()
        setarraydisply()
    End Sub

    Private Sub Button243_Click(sender As Object, e As EventArgs) Handles Button243.Click
        downc8()
        setarraydisply()
    End Sub

    Private Sub Button242_Click(sender As Object, e As EventArgs) Handles Button242.Click
        downc9()
        setarraydisply()
    End Sub

    Private Sub Button241_Click(sender As Object, e As EventArgs) Handles Button241.Click
        downc10()
        setarraydisply()
    End Sub

    Private Sub Button240_Click(sender As Object, e As EventArgs) Handles Button240.Click
        downc11()
        setarraydisply()
    End Sub

    Private Sub Button239_Click(sender As Object, e As EventArgs) Handles Button239.Click
        downc12()
        setarraydisply()
    End Sub

    Private Sub Button238_Click(sender As Object, e As EventArgs) Handles Button238.Click
        downc13()
        setarraydisply()
    End Sub

    Private Sub Button237_Click(sender As Object, e As EventArgs) Handles Button237.Click
        downc14()
        setarraydisply()
    End Sub

    Private Sub Button236_Click(sender As Object, e As EventArgs) Handles Button236.Click
        downc15()
        setarraydisply()
    End Sub

    Private Sub Button235_Click(sender As Object, e As EventArgs) Handles Button235.Click
        downc16()
        setarraydisply()
    End Sub

    Private Sub Button234_Click(sender As Object, e As EventArgs) Handles Button234.Click
        downc17()
        setarraydisply()
    End Sub

    Private Sub Button233_Click(sender As Object, e As EventArgs) Handles Button233.Click
        downc18()
        setarraydisply()
    End Sub

    Private Sub Button232_Click(sender As Object, e As EventArgs) Handles Button232.Click
        downc19()
        setarraydisply()
    End Sub

    Private Sub Button231_Click(sender As Object, e As EventArgs) Handles Button231.Click
        downc20()
        setarraydisply()
    End Sub

    Private Sub Button230_Click(sender As Object, e As EventArgs) Handles Button230.Click
        downc21()
        setarraydisply()
    End Sub

    Private Sub Button229_Click(sender As Object, e As EventArgs) Handles Button229.Click
        downc22()
        setarraydisply()
    End Sub

    Private Sub Button228_Click(sender As Object, e As EventArgs) Handles Button228.Click
        downc23()
        setarraydisply()
    End Sub

    Private Sub Button227_Click(sender As Object, e As EventArgs) Handles Button227.Click
        downc24()
        setarraydisply()
    End Sub

    Private Sub Button226_Click(sender As Object, e As EventArgs) Handles Button226.Click
        downc25()
        setarraydisply()
    End Sub

    Private Sub Button266_Click(sender As Object, e As EventArgs) Handles Button266.Click
        rightr1()

        setarraydisply()
    End Sub

    Private Sub Button265_Click(sender As Object, e As EventArgs) Handles Button265.Click
        rightr2()
        setarraydisply()

    End Sub

    Private Sub Button264_Click(sender As Object, e As EventArgs) Handles Button264.Click
        rightr3()
        setarraydisply()

    End Sub

    Private Sub Button263_Click(sender As Object, e As EventArgs) Handles Button263.Click
        rightr4()
        setarraydisply()

    End Sub

    Private Sub Button262_Click(sender As Object, e As EventArgs) Handles Button262.Click
        rightr5()
        setarraydisply()

    End Sub

    Private Sub Button261_Click(sender As Object, e As EventArgs) Handles Button261.Click
        rightr6()
        setarraydisply()

    End Sub

    Private Sub Button260_Click(sender As Object, e As EventArgs) Handles Button260.Click
        rightr7()
        setarraydisply()


    End Sub

    Private Sub Button259_Click(sender As Object, e As EventArgs) Handles Button259.Click
        rightr8()
        setarraydisply()
    End Sub

    Private Sub Button251_Click(sender As Object, e As EventArgs) Handles Button251.Click
        leftr1()
        setarraydisply()
    End Sub

    Private Sub Button252_Click(sender As Object, e As EventArgs) Handles Button252.Click
        leftr2()
        setarraydisply()
    End Sub

    Private Sub Button253_Click(sender As Object, e As EventArgs) Handles Button253.Click
        leftr3()
        setarraydisply()
    End Sub

    Private Sub Button254_Click(sender As Object, e As EventArgs) Handles Button254.Click
        leftr4()
        setarraydisply()
    End Sub

    Private Sub Button255_Click(sender As Object, e As EventArgs) Handles Button255.Click
        leftr5()
        setarraydisply()
    End Sub

    Private Sub Button256_Click(sender As Object, e As EventArgs) Handles Button256.Click
        leftr6()
        setarraydisply()
    End Sub

    Private Sub Button257_Click(sender As Object, e As EventArgs) Handles Button257.Click
        leftr7()
        setarraydisply()
    End Sub

    Private Sub Button258_Click(sender As Object, e As EventArgs) Handles Button258.Click
        leftr8()
        setarraydisply()
    End Sub

    Private Sub Button267_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button268_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button269_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button270_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub sc_Click(sender As Object, e As EventArgs) Handles sc.Click
        If (selec = 0) Then
            selec = 1
        Else
            selec = 0

        End If
    End Sub

    Private Sub Button280_Click(sender As Object, e As EventArgs) Handles Button280.Click
        R = 255
        G = 0
        B = 0
        sc.BackColor = Button280.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button279_Click(sender As Object, e As EventArgs)
        R = 0
        G = 255
        B = 0
        sc.BackColor = Button279.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button281_Click(sender As Object, e As EventArgs) Handles Button281.Click
        R = 0
        G = 0
        B = 255
        sc.BackColor = Button281.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button278_Click(sender As Object, e As EventArgs) Handles Button278.Click
        R = 255
        G = 255
        B = 0
        sc.BackColor = Button278.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button276_Click(sender As Object, e As EventArgs) Handles Button276.Click
        R = 255
        G = 165
        B = 0
        sc.BackColor = Button276.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button274_Click(sender As Object, e As EventArgs)
        R = 0
        G = 255
        B = 255
        sc.BackColor = Button274.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button277_Click(sender As Object, e As EventArgs)
        R = 255
        G = 0
        B = 255
        sc.BackColor = Button277.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button272_Click(sender As Object, e As EventArgs) Handles Button272.Click
        R = 255
        G = 255
        B = 255
        sc.BackColor = Button272.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button273_Click(sender As Object, e As EventArgs)
        R = 0
        G = 0
        B = 0
        sc.BackColor = Button273.BackColor

        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button285_Click(sender As Object, e As EventArgs) Handles Button285.Click
        ccs = 1
        R = customColorList(1, 0)
        G = customColorList(1, 1)
        B = customColorList(1, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button284_Click(sender As Object, e As EventArgs) Handles Button284.Click
        ccs = 2
        R = customColorList(2, 0)
        G = customColorList(2, 1)
        B = customColorList(2, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button283_Click(sender As Object, e As EventArgs) Handles Button283.Click
        ccs = 3
        R = customColorList(3, 0)
        G = customColorList(3, 1)
        B = customColorList(3, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button282_Click(sender As Object, e As EventArgs) Handles Button282.Click
        ccs = 4
        R = customColorList(4, 0)
        G = customColorList(4, 1)
        B = customColorList(4, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button275_Click(sender As Object, e As EventArgs) Handles Button275.Click
        ccs = 5
        R = customColorList(5, 0)
        G = customColorList(5, 1)
        B = customColorList(5, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button287_Click(sender As Object, e As EventArgs) Handles Button287.Click
        ccs = 6
        R = customColorList(6, 0)
        G = customColorList(6, 1)
        B = customColorList(6, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button286_Click(sender As Object, e As EventArgs) Handles Button286.Click
        ccs = 7
        R = customColorList(7, 0)
        G = customColorList(7, 1)
        B = customColorList(7, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button288_Click(sender As Object, e As EventArgs) Handles Button288.Click
        ccs = 8
        R = customColorList(8, 0)
        G = customColorList(8, 1)
        B = customColorList(8, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

    End Sub

    Private Sub Button301_Click(sender As Object, e As EventArgs) Handles Button301.Click
        ccs = 9
        R = customColorList(9, 0)
        G = customColorList(9, 1)
        B = customColorList(9, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button300_Click(sender As Object, e As EventArgs) Handles Button300.Click
        ccs = 10
        R = customColorList(10, 0)
        G = customColorList(10, 1)
        B = customColorList(10, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button311_Click(sender As Object, e As EventArgs) Handles Button311.Click
        ccs = 11
        R = customColorList(11, 0)
        G = customColorList(11, 1)
        B = customColorList(11, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button310_Click(sender As Object, e As EventArgs) Handles Button310.Click
        ccs = 12
        R = customColorList(12, 0)
        G = customColorList(12, 1)
        B = customColorList(12, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button309_Click(sender As Object, e As EventArgs) Handles Button309.Click
        ccs = 13
        R = customColorList(13, 0)
        G = customColorList(13, 1)
        B = customColorList(13, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button308_Click(sender As Object, e As EventArgs) Handles Button308.Click
        ccs = 14
        R = customColorList(14, 0)
        G = customColorList(14, 1)
        B = customColorList(14, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button307_Click(sender As Object, e As EventArgs) Handles Button307.Click
        ccs = 15
        R = customColorList(15, 0)
        G = customColorList(15, 1)
        B = customColorList(15, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button306_Click(sender As Object, e As EventArgs) Handles Button306.Click
        ccs = 16
        R = customColorList(16, 0)
        G = customColorList(16, 1)
        B = customColorList(16, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button305_Click(sender As Object, e As EventArgs) Handles Button305.Click
        ccs = 17
        R = customColorList(17, 0)
        G = customColorList(17, 1)
        B = customColorList(17, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button304_Click(sender As Object, e As EventArgs) Handles Button304.Click
        ccs = 18
        R = customColorList(18, 0)
        G = customColorList(18, 1)
        B = customColorList(18, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button303_Click(sender As Object, e As EventArgs) Handles Button303.Click
        ccs = 19
        R = customColorList(19, 0)
        G = customColorList(19, 1)
        B = customColorList(19, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button302_Click(sender As Object, e As EventArgs) Handles Button302.Click
        ccs = 20
        R = customColorList(20, 0)
        G = customColorList(20, 1)
        B = customColorList(20, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button321_Click(sender As Object, e As EventArgs) Handles Button321.Click
        ccs = 21
        R = customColorList(21, 0)
        G = customColorList(21, 1)
        B = customColorList(21, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button320_Click(sender As Object, e As EventArgs) Handles Button320.Click
        ccs = 22
        R = customColorList(22, 0)
        G = customColorList(22, 1)
        B = customColorList(22, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button319_Click(sender As Object, e As EventArgs) Handles Button319.Click
        ccs = 23
        R = customColorList(23, 0)
        G = customColorList(23, 1)
        B = customColorList(23, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button318_Click(sender As Object, e As EventArgs) Handles Button318.Click
        ccs = 24
        R = customColorList(24, 0)
        G = customColorList(24, 1)
        B = customColorList(24, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button317_Click(sender As Object, e As EventArgs) Handles Button317.Click
        ccs = 25
        R = customColorList(25, 0)
        G = customColorList(25, 1)
        B = customColorList(25, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button316_Click(sender As Object, e As EventArgs) Handles Button316.Click
        ccs = 26
        R = customColorList(26, 0)
        G = customColorList(26, 1)
        B = customColorList(26, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button315_Click(sender As Object, e As EventArgs) Handles Button315.Click
        ccs = 27
        R = customColorList(27, 0)
        G = customColorList(27, 1)
        B = customColorList(27, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button314_Click(sender As Object, e As EventArgs) Handles Button314.Click
        ccs = 28
        R = customColorList(28, 0)
        G = customColorList(28, 1)
        B = customColorList(28, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button313_Click(sender As Object, e As EventArgs) Handles Button313.Click
        ccs = 29
        R = customColorList(29, 0)
        G = customColorList(29, 1)
        B = customColorList(29, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub Button312_Click(sender As Object, e As EventArgs) Handles Button312.Click
        ccs = 30
        R = customColorList(30, 0)
        G = customColorList(30, 1)
        B = customColorList(30, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B
    End Sub

    Private Sub setTrackBar()

    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label37.Text = TrackBar1.Value * tbs


        If (ccs = 1) Then
            customColorList(1, 0) = TrackBar1.Value * tbs
            customColorList(1, 1) = TrackBar2.Value * tbs
            customColorList(1, 2) = TrackBar3.Value * tbs
            Button285.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 2) Then
            customColorList(2, 0) = TrackBar1.Value * tbs
            customColorList(2, 1) = TrackBar2.Value * tbs
            customColorList(2, 2) = TrackBar3.Value * tbs
            Button284.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 3) Then
            customColorList(3, 0) = TrackBar1.Value * tbs
            customColorList(3, 1) = TrackBar2.Value * tbs
            customColorList(3, 2) = TrackBar3.Value * tbs
            Button283.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 4) Then
            customColorList(4, 0) = TrackBar1.Value * tbs
            customColorList(4, 1) = TrackBar2.Value * tbs
            customColorList(4, 2) = TrackBar3.Value * tbs
            Button282.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 5) Then
            customColorList(5, 0) = TrackBar1.Value * tbs
            customColorList(5, 1) = TrackBar2.Value * tbs
            customColorList(5, 2) = TrackBar3.Value * tbs
            Button275.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 6) Then
            customColorList(6, 0) = TrackBar1.Value * tbs
            customColorList(6, 1) = TrackBar2.Value * tbs
            customColorList(6, 2) = TrackBar3.Value * tbs
            Button287.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 7) Then
            customColorList(7, 0) = TrackBar1.Value * tbs
            customColorList(7, 1) = TrackBar2.Value * tbs
            customColorList(7, 2) = TrackBar3.Value * tbs
            Button286.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 8) Then
            customColorList(8, 0) = TrackBar1.Value * tbs
            customColorList(8, 1) = TrackBar2.Value * tbs
            customColorList(8, 2) = TrackBar3.Value * tbs
            Button288.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 9) Then
            customColorList(9, 0) = TrackBar1.Value * tbs
            customColorList(9, 1) = TrackBar2.Value * tbs
            customColorList(9, 2) = TrackBar3.Value * tbs
            Button301.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 10) Then
            customColorList(10, 0) = TrackBar1.Value * tbs
            customColorList(10, 1) = TrackBar2.Value * tbs
            customColorList(10, 2) = TrackBar3.Value * tbs
            Button300.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 11) Then
            customColorList(11, 0) = TrackBar1.Value * tbs
            customColorList(11, 1) = TrackBar2.Value * tbs
            customColorList(11, 2) = TrackBar3.Value * tbs
            Button311.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 12) Then
            customColorList(12, 0) = TrackBar1.Value * tbs
            customColorList(12, 1) = TrackBar2.Value * tbs
            customColorList(12, 2) = TrackBar3.Value * tbs
            Button310.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 13) Then
            customColorList(13, 0) = TrackBar1.Value * tbs
            customColorList(13, 1) = TrackBar2.Value * tbs
            customColorList(13, 2) = TrackBar3.Value * tbs
            Button309.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 14) Then
            customColorList(14, 0) = TrackBar1.Value * tbs
            customColorList(14, 1) = TrackBar2.Value * tbs
            customColorList(14, 2) = TrackBar3.Value * tbs
            Button308.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 15) Then
            customColorList(15, 0) = TrackBar1.Value * tbs
            customColorList(15, 1) = TrackBar2.Value * tbs
            customColorList(15, 2) = TrackBar3.Value * tbs
            Button307.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 16) Then
            customColorList(16, 0) = TrackBar1.Value * tbs
            customColorList(16, 1) = TrackBar2.Value * tbs
            customColorList(16, 2) = TrackBar3.Value * tbs
            Button306.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 17) Then
            customColorList(17, 0) = TrackBar1.Value * tbs
            customColorList(17, 1) = TrackBar2.Value * tbs
            customColorList(17, 2) = TrackBar3.Value * tbs
            Button305.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 18) Then
            customColorList(18, 0) = TrackBar1.Value * tbs
            customColorList(18, 1) = TrackBar2.Value * tbs
            customColorList(18, 2) = TrackBar3.Value * tbs
            Button304.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 19) Then
            customColorList(19, 0) = TrackBar1.Value * tbs
            customColorList(19, 1) = TrackBar2.Value * tbs
            customColorList(19, 2) = TrackBar3.Value * tbs
            Button303.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 20) Then
            customColorList(20, 0) = TrackBar1.Value * tbs
            customColorList(20, 1) = TrackBar2.Value * tbs
            customColorList(20, 2) = TrackBar3.Value * tbs
            Button302.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 21) Then
            customColorList(21, 0) = TrackBar1.Value * tbs
            customColorList(21, 1) = TrackBar2.Value * tbs
            customColorList(21, 2) = TrackBar3.Value * tbs
            Button321.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 22) Then
            customColorList(22, 0) = TrackBar1.Value * tbs
            customColorList(22, 1) = TrackBar2.Value * tbs
            customColorList(22, 2) = TrackBar3.Value * tbs
            Button320.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 23) Then
            customColorList(23, 0) = TrackBar1.Value * tbs
            customColorList(23, 1) = TrackBar2.Value * tbs
            customColorList(23, 2) = TrackBar3.Value * tbs
            Button319.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 24) Then
            customColorList(24, 0) = TrackBar1.Value * tbs
            customColorList(24, 1) = TrackBar2.Value * tbs
            customColorList(24, 2) = TrackBar3.Value * tbs
            Button318.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 25) Then
            customColorList(25, 0) = TrackBar1.Value * tbs
            customColorList(25, 1) = TrackBar2.Value * tbs
            customColorList(25, 2) = TrackBar3.Value * tbs
            Button317.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 26) Then
            customColorList(26, 0) = TrackBar1.Value * tbs
            customColorList(26, 1) = TrackBar2.Value * tbs
            customColorList(26, 2) = TrackBar3.Value * tbs
            Button316.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 27) Then
            customColorList(27, 0) = TrackBar1.Value * tbs
            customColorList(27, 1) = TrackBar2.Value * tbs
            customColorList(27, 2) = TrackBar3.Value * tbs
            Button315.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 28) Then
            customColorList(28, 0) = TrackBar1.Value * tbs
            customColorList(28, 1) = TrackBar2.Value * tbs
            customColorList(28, 2) = TrackBar3.Value * tbs
            Button314.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 29) Then
            customColorList(29, 0) = TrackBar1.Value * tbs
            customColorList(29, 1) = TrackBar2.Value * tbs
            customColorList(29, 2) = TrackBar3.Value * tbs
            Button313.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 30) Then
            customColorList(30, 0) = TrackBar1.Value * tbs
            customColorList(30, 1) = TrackBar2.Value * tbs
            customColorList(30, 2) = TrackBar3.Value * tbs
            Button312.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        End If


    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Label36.Text = TrackBar2.Value * tbs

        If (ccs = 1) Then
            customColorList(1, 0) = TrackBar1.Value * tbs
            customColorList(1, 1) = TrackBar2.Value * tbs
            customColorList(1, 2) = TrackBar3.Value * tbs
            Button285.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 2) Then
            customColorList(2, 0) = TrackBar1.Value * tbs
            customColorList(2, 1) = TrackBar2.Value * tbs
            customColorList(2, 2) = TrackBar3.Value * tbs
            Button284.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 3) Then
            customColorList(3, 0) = TrackBar1.Value * tbs
            customColorList(3, 1) = TrackBar2.Value * tbs
            customColorList(3, 2) = TrackBar3.Value * tbs
            Button283.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 4) Then
            customColorList(4, 0) = TrackBar1.Value * tbs
            customColorList(4, 1) = TrackBar2.Value * tbs
            customColorList(4, 2) = TrackBar3.Value * tbs
            Button282.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 5) Then
            customColorList(5, 0) = TrackBar1.Value * tbs
            customColorList(5, 1) = TrackBar2.Value * tbs
            customColorList(5, 2) = TrackBar3.Value * tbs
            Button275.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 6) Then
            customColorList(6, 0) = TrackBar1.Value * tbs
            customColorList(6, 1) = TrackBar2.Value * tbs
            customColorList(6, 2) = TrackBar3.Value * tbs
            Button287.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 7) Then
            customColorList(7, 0) = TrackBar1.Value * tbs
            customColorList(7, 1) = TrackBar2.Value * tbs
            customColorList(7, 2) = TrackBar3.Value * tbs
            Button286.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 8) Then
            customColorList(8, 0) = TrackBar1.Value * tbs
            customColorList(8, 1) = TrackBar2.Value * tbs
            customColorList(8, 2) = TrackBar3.Value * tbs
            Button288.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 9) Then
            customColorList(9, 0) = TrackBar1.Value * tbs
            customColorList(9, 1) = TrackBar2.Value * tbs
            customColorList(9, 2) = TrackBar3.Value * tbs
            Button301.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 10) Then
            customColorList(10, 0) = TrackBar1.Value * tbs
            customColorList(10, 1) = TrackBar2.Value * tbs
            customColorList(10, 2) = TrackBar3.Value * tbs
            Button300.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 11) Then
            customColorList(11, 0) = TrackBar1.Value * tbs
            customColorList(11, 1) = TrackBar2.Value * tbs
            customColorList(11, 2) = TrackBar3.Value * tbs
            Button311.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 12) Then
            customColorList(12, 0) = TrackBar1.Value * tbs
            customColorList(12, 1) = TrackBar2.Value * tbs
            customColorList(12, 2) = TrackBar3.Value * tbs
            Button310.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 13) Then
            customColorList(13, 0) = TrackBar1.Value * tbs
            customColorList(13, 1) = TrackBar2.Value * tbs
            customColorList(13, 2) = TrackBar3.Value * tbs
            Button309.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 14) Then
            customColorList(14, 0) = TrackBar1.Value * tbs
            customColorList(14, 1) = TrackBar2.Value * tbs
            customColorList(14, 2) = TrackBar3.Value * tbs
            Button308.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 15) Then
            customColorList(15, 0) = TrackBar1.Value * tbs
            customColorList(15, 1) = TrackBar2.Value * tbs
            customColorList(15, 2) = TrackBar3.Value * tbs
            Button307.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 16) Then
            customColorList(16, 0) = TrackBar1.Value * tbs
            customColorList(16, 1) = TrackBar2.Value * tbs
            customColorList(16, 2) = TrackBar3.Value * tbs
            Button306.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 17) Then
            customColorList(17, 0) = TrackBar1.Value * tbs
            customColorList(17, 1) = TrackBar2.Value * tbs
            customColorList(17, 2) = TrackBar3.Value * tbs
            Button305.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 18) Then
            customColorList(18, 0) = TrackBar1.Value * tbs
            customColorList(18, 1) = TrackBar2.Value * tbs
            customColorList(18, 2) = TrackBar3.Value * tbs
            Button304.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 19) Then
            customColorList(19, 0) = TrackBar1.Value * tbs
            customColorList(19, 1) = TrackBar2.Value * tbs
            customColorList(19, 2) = TrackBar3.Value * tbs
            Button303.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 20) Then
            customColorList(20, 0) = TrackBar1.Value * tbs
            customColorList(20, 1) = TrackBar2.Value * tbs
            customColorList(20, 2) = TrackBar3.Value * tbs
            Button302.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 21) Then
            customColorList(21, 0) = TrackBar1.Value * tbs
            customColorList(21, 1) = TrackBar2.Value * tbs
            customColorList(21, 2) = TrackBar3.Value * tbs
            Button321.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 22) Then
            customColorList(22, 0) = TrackBar1.Value * tbs
            customColorList(22, 1) = TrackBar2.Value * tbs
            customColorList(22, 2) = TrackBar3.Value * tbs
            Button320.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 23) Then
            customColorList(23, 0) = TrackBar1.Value * tbs
            customColorList(23, 1) = TrackBar2.Value * tbs
            customColorList(23, 2) = TrackBar3.Value * tbs
            Button319.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 24) Then
            customColorList(24, 0) = TrackBar1.Value * tbs
            customColorList(24, 1) = TrackBar2.Value * tbs
            customColorList(24, 2) = TrackBar3.Value * tbs
            Button318.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 25) Then
            customColorList(25, 0) = TrackBar1.Value * tbs
            customColorList(25, 1) = TrackBar2.Value * tbs
            customColorList(25, 2) = TrackBar3.Value * tbs
            Button317.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 26) Then
            customColorList(26, 0) = TrackBar1.Value * tbs
            customColorList(26, 1) = TrackBar2.Value * tbs
            customColorList(26, 2) = TrackBar3.Value * tbs
            Button316.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 27) Then
            customColorList(27, 0) = TrackBar1.Value * tbs
            customColorList(27, 1) = TrackBar2.Value * tbs
            customColorList(27, 2) = TrackBar3.Value * tbs
            Button315.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 28) Then
            customColorList(28, 0) = TrackBar1.Value * tbs
            customColorList(28, 1) = TrackBar2.Value * tbs
            customColorList(28, 2) = TrackBar3.Value * tbs
            Button314.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 29) Then
            customColorList(29, 0) = TrackBar1.Value * tbs
            customColorList(29, 1) = TrackBar2.Value * tbs
            customColorList(29, 2) = TrackBar3.Value * tbs
            Button313.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 30) Then
            customColorList(30, 0) = TrackBar1.Value * tbs
            customColorList(30, 1) = TrackBar2.Value * tbs
            customColorList(30, 2) = TrackBar3.Value * tbs
            Button312.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        End If

    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Label35.Text = TrackBar3.Value * tbs

        If (ccs = 1) Then
            customColorList(1, 0) = TrackBar1.Value * tbs
            customColorList(1, 1) = TrackBar2.Value * tbs
            customColorList(1, 2) = TrackBar3.Value * tbs
            Button285.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 2) Then
            customColorList(2, 0) = TrackBar1.Value * tbs
            customColorList(2, 1) = TrackBar2.Value * tbs
            customColorList(2, 2) = TrackBar3.Value * tbs
            Button284.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 3) Then
            customColorList(3, 0) = TrackBar1.Value * tbs
            customColorList(3, 1) = TrackBar2.Value * tbs
            customColorList(3, 2) = TrackBar3.Value * tbs
            Button283.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 4) Then
            customColorList(4, 0) = TrackBar1.Value * tbs
            customColorList(4, 1) = TrackBar2.Value * tbs
            customColorList(4, 2) = TrackBar3.Value * tbs
            Button282.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 5) Then
            customColorList(5, 0) = TrackBar1.Value * tbs
            customColorList(5, 1) = TrackBar2.Value * tbs
            customColorList(5, 2) = TrackBar3.Value * tbs
            Button275.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 6) Then
            customColorList(6, 0) = TrackBar1.Value * tbs
            customColorList(6, 1) = TrackBar2.Value * tbs
            customColorList(6, 2) = TrackBar3.Value * tbs
            Button287.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 7) Then
            customColorList(7, 0) = TrackBar1.Value * tbs
            customColorList(7, 1) = TrackBar2.Value * tbs
            customColorList(7, 2) = TrackBar3.Value * tbs
            Button286.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 8) Then
            customColorList(8, 0) = TrackBar1.Value * tbs
            customColorList(8, 1) = TrackBar2.Value * tbs
            customColorList(8, 2) = TrackBar3.Value * tbs
            Button288.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 9) Then
            customColorList(9, 0) = TrackBar1.Value * tbs
            customColorList(9, 1) = TrackBar2.Value * tbs
            customColorList(9, 2) = TrackBar3.Value * tbs
            Button301.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 10) Then
            customColorList(10, 0) = TrackBar1.Value * tbs
            customColorList(10, 1) = TrackBar2.Value * tbs
            customColorList(10, 2) = TrackBar3.Value * tbs
            Button300.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 11) Then
            customColorList(11, 0) = TrackBar1.Value * tbs
            customColorList(11, 1) = TrackBar2.Value * tbs
            customColorList(11, 2) = TrackBar3.Value * tbs
            Button311.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 12) Then
            customColorList(12, 0) = TrackBar1.Value * tbs
            customColorList(12, 1) = TrackBar2.Value * tbs
            customColorList(12, 2) = TrackBar3.Value * tbs
            Button310.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 13) Then
            customColorList(13, 0) = TrackBar1.Value * tbs
            customColorList(13, 1) = TrackBar2.Value * tbs
            customColorList(13, 2) = TrackBar3.Value * tbs
            Button309.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 14) Then
            customColorList(14, 0) = TrackBar1.Value * tbs
            customColorList(14, 1) = TrackBar2.Value * tbs
            customColorList(14, 2) = TrackBar3.Value * tbs
            Button308.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 15) Then
            customColorList(15, 0) = TrackBar1.Value * tbs
            customColorList(15, 1) = TrackBar2.Value * tbs
            customColorList(15, 2) = TrackBar3.Value * tbs
            Button307.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 16) Then
            customColorList(16, 0) = TrackBar1.Value * tbs
            customColorList(16, 1) = TrackBar2.Value * tbs
            customColorList(16, 2) = TrackBar3.Value * tbs
            Button306.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 17) Then
            customColorList(17, 0) = TrackBar1.Value * tbs
            customColorList(17, 1) = TrackBar2.Value * tbs
            customColorList(17, 2) = TrackBar3.Value * tbs
            Button305.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 18) Then
            customColorList(18, 0) = TrackBar1.Value * tbs
            customColorList(18, 1) = TrackBar2.Value * tbs
            customColorList(18, 2) = TrackBar3.Value * tbs
            Button304.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 19) Then
            customColorList(19, 0) = TrackBar1.Value * tbs
            customColorList(19, 1) = TrackBar2.Value * tbs
            customColorList(19, 2) = TrackBar3.Value * tbs
            Button303.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 20) Then
            customColorList(20, 0) = TrackBar1.Value * tbs
            customColorList(20, 1) = TrackBar2.Value * tbs
            customColorList(20, 2) = TrackBar3.Value * tbs
            Button302.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 21) Then
            customColorList(21, 0) = TrackBar1.Value * tbs
            customColorList(21, 1) = TrackBar2.Value * tbs
            customColorList(21, 2) = TrackBar3.Value * tbs
            Button321.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 22) Then
            customColorList(22, 0) = TrackBar1.Value * tbs
            customColorList(22, 1) = TrackBar2.Value * tbs
            customColorList(22, 2) = TrackBar3.Value * tbs
            Button320.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 23) Then
            customColorList(23, 0) = TrackBar1.Value * tbs
            customColorList(23, 1) = TrackBar2.Value * tbs
            customColorList(23, 2) = TrackBar3.Value * tbs
            Button319.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 24) Then
            customColorList(24, 0) = TrackBar1.Value * tbs
            customColorList(24, 1) = TrackBar2.Value * tbs
            customColorList(24, 2) = TrackBar3.Value * tbs
            Button318.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 25) Then
            customColorList(25, 0) = TrackBar1.Value * tbs
            customColorList(25, 1) = TrackBar2.Value * tbs
            customColorList(25, 2) = TrackBar3.Value * tbs
            Button317.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 26) Then
            customColorList(26, 0) = TrackBar1.Value * tbs
            customColorList(26, 1) = TrackBar2.Value * tbs
            customColorList(26, 2) = TrackBar3.Value * tbs
            Button316.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 27) Then
            customColorList(27, 0) = TrackBar1.Value * tbs
            customColorList(27, 1) = TrackBar2.Value * tbs
            customColorList(27, 2) = TrackBar3.Value * tbs
            Button315.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 28) Then
            customColorList(28, 0) = TrackBar1.Value * tbs
            customColorList(28, 1) = TrackBar2.Value * tbs
            customColorList(28, 2) = TrackBar3.Value * tbs
            Button314.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 29) Then
            customColorList(29, 0) = TrackBar1.Value * tbs
            customColorList(29, 1) = TrackBar2.Value * tbs
            customColorList(29, 2) = TrackBar3.Value * tbs
            Button313.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        ElseIf (ccs = 30) Then
            customColorList(30, 0) = TrackBar1.Value * tbs
            customColorList(30, 1) = TrackBar2.Value * tbs
            customColorList(30, 2) = TrackBar3.Value * tbs
            Button312.BackColor = Color.FromArgb(255, TrackBar1.Value * tbs, TrackBar2.Value * tbs, TrackBar3.Value * tbs)
        End If

    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles frameAnimator.Scroll
        Label42.Text = frameAnimator.Value + 1
        read((frameAnimator.Value) * 200)


    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles frameCount.ValueChanged
        frameAnimator.Maximum = frameCount.Value - 1
    End Sub

    Private Sub setFrame(count As Long, led As Integer)
        framesR(count + led) = patternLEDList(led + 1, 0)
        framesG(count + led) = patternLEDList(led + 1, 1)
        framesB(count + led) = patternLEDList(led + 1, 2)
    End Sub

    Sub add(i As Long)
        For k = 0 To 199
            setFrame(i, k)
        Next
    End Sub

    Private Function btnColor(i As Long, b As Integer) As Color
        ' Dim y As Long
        Dim ledColor As Color
        patternLEDList(1, 0) = framesR(i + b)
        patternLEDList(1, 1) = framesG(i + b)
        patternLEDList(1, 2) = framesB(i + b)
        ledColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))
        Return ledColor
    End Function
    Sub read(i As Long)

        Button1.BackColor = btnColor(i, 1)

        patternLEDList(2, 0) = framesR(i + 1)
        patternLEDList(2, 1) = framesG(i + 1)
        patternLEDList(2, 2) = framesB(i + 1)
        Button2.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 2)
        patternLEDList(3, 1) = framesG(i + 2)
        patternLEDList(3, 2) = framesB(i + 2)
        Button3.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 3)
        patternLEDList(4, 1) = framesG(i + 3)
        patternLEDList(4, 2) = framesB(i + 3)
        Button4.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 4)
        patternLEDList(5, 1) = framesG(i + 4)
        patternLEDList(5, 2) = framesB(i + 4)
        Button5.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 5)
        patternLEDList(6, 1) = framesG(i + 5)
        patternLEDList(6, 2) = framesB(i + 5)
        Button6.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 6)
        patternLEDList(7, 1) = framesG(i + 6)
        patternLEDList(7, 2) = framesB(i + 6)
        Button7.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 7)
        patternLEDList(8, 1) = framesG(i + 7)
        patternLEDList(8, 2) = framesB(i + 7)
        Button8.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 8)
        patternLEDList(9, 1) = framesG(i + 8)
        patternLEDList(9, 2) = framesB(i + 8)
        Button9.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 9)
        patternLEDList(0, 1) = framesG(i + 9)
        patternLEDList(0, 2) = framesB(i + 9)
        Button10.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 10)
        patternLEDList(1, 1) = framesG(i + 10)
        patternLEDList(1, 2) = framesB(i + 10)
        Button11.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 11)
        patternLEDList(2, 1) = framesG(i + 11)
        patternLEDList(2, 2) = framesB(i + 11)
        Button12.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 12)
        patternLEDList(3, 1) = framesG(i + 12)
        patternLEDList(3, 2) = framesB(i + 12)
        Button13.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 13)
        patternLEDList(4, 1) = framesG(i + 13)
        patternLEDList(4, 2) = framesB(i + 13)
        Button14.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 14)
        patternLEDList(5, 1) = framesG(i + 14)
        patternLEDList(5, 2) = framesB(i + 14)
        Button15.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 15)
        patternLEDList(6, 1) = framesG(i + 15)
        patternLEDList(6, 2) = framesB(i + 15)
        Button16.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 16)
        patternLEDList(7, 1) = framesG(i + 16)
        patternLEDList(7, 2) = framesB(i + 16)
        Button17.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 17)
        patternLEDList(8, 1) = framesG(i + 17)
        patternLEDList(8, 2) = framesB(i + 17)
        Button18.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 18)
        patternLEDList(9, 1) = framesG(i + 18)
        patternLEDList(9, 2) = framesB(i + 18)
        Button19.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 19)
        patternLEDList(0, 1) = framesG(i + 19)
        patternLEDList(0, 2) = framesB(i + 19)
        Button20.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 20)
        patternLEDList(1, 1) = framesG(i + 20)
        patternLEDList(1, 2) = framesB(i + 20)
        Button21.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 21)
        patternLEDList(2, 1) = framesG(i + 21)
        patternLEDList(2, 2) = framesB(i + 21)
        Button22.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 22)
        patternLEDList(3, 1) = framesG(i + 22)
        patternLEDList(3, 2) = framesB(i + 22)
        Button23.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 23)
        patternLEDList(4, 1) = framesG(i + 23)
        patternLEDList(4, 2) = framesB(i + 23)
        Button24.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 24)
        patternLEDList(5, 1) = framesG(i + 24)
        patternLEDList(5, 2) = framesB(i + 24)
        Button25.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 25)
        patternLEDList(6, 1) = framesG(i + 25)
        patternLEDList(6, 2) = framesB(i + 25)
        Button26.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 26)
        patternLEDList(7, 1) = framesG(i + 26)
        patternLEDList(7, 2) = framesB(i + 26)
        Button27.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 27)
        patternLEDList(8, 1) = framesG(i + 27)
        patternLEDList(8, 2) = framesB(i + 27)
        Button28.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 28)
        patternLEDList(9, 1) = framesG(i + 28)
        patternLEDList(9, 2) = framesB(i + 28)
        Button29.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 29)
        patternLEDList(0, 1) = framesG(i + 29)
        patternLEDList(0, 2) = framesB(i + 29)
        Button30.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 30)
        patternLEDList(1, 1) = framesG(i + 30)
        patternLEDList(1, 2) = framesB(i + 30)
        Button31.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 31)
        patternLEDList(2, 1) = framesG(i + 31)
        patternLEDList(2, 2) = framesB(i + 31)
        Button32.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 32)
        patternLEDList(3, 1) = framesG(i + 32)
        patternLEDList(3, 2) = framesB(i + 32)
        Button33.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 33)
        patternLEDList(4, 1) = framesG(i + 33)
        patternLEDList(4, 2) = framesB(i + 33)
        Button34.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 34)
        patternLEDList(5, 1) = framesG(i + 34)
        patternLEDList(5, 2) = framesB(i + 34)
        Button35.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 35)
        patternLEDList(6, 1) = framesG(i + 35)
        patternLEDList(6, 2) = framesB(i + 35)
        Button36.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 36)
        patternLEDList(7, 1) = framesG(i + 36)
        patternLEDList(7, 2) = framesB(i + 36)
        Button37.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 37)
        patternLEDList(8, 1) = framesG(i + 37)
        patternLEDList(8, 2) = framesB(i + 37)
        Button38.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 38)
        patternLEDList(9, 1) = framesG(i + 38)
        patternLEDList(9, 2) = framesB(i + 38)
        Button39.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 39)
        patternLEDList(0, 1) = framesG(i + 39)
        patternLEDList(0, 2) = framesB(i + 39)
        Button40.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 40)
        patternLEDList(1, 1) = framesG(i + 40)
        patternLEDList(1, 2) = framesB(i + 40)
        Button41.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 41)
        patternLEDList(2, 1) = framesG(i + 41)
        patternLEDList(2, 2) = framesB(i + 41)
        Button42.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 42)
        patternLEDList(3, 1) = framesG(i + 42)
        patternLEDList(3, 2) = framesB(i + 42)
        Button43.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 43)
        patternLEDList(4, 1) = framesG(i + 43)
        patternLEDList(4, 2) = framesB(i + 43)
        Button44.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 44)
        patternLEDList(5, 1) = framesG(i + 44)
        patternLEDList(5, 2) = framesB(i + 44)
        Button45.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 45)
        patternLEDList(6, 1) = framesG(i + 45)
        patternLEDList(6, 2) = framesB(i + 45)
        Button46.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 46)
        patternLEDList(7, 1) = framesG(i + 46)
        patternLEDList(7, 2) = framesB(i + 46)
        Button47.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 47)
        patternLEDList(8, 1) = framesG(i + 47)
        patternLEDList(8, 2) = framesB(i + 47)
        Button48.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 48)
        patternLEDList(9, 1) = framesG(i + 48)
        patternLEDList(9, 2) = framesB(i + 48)
        Button49.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 49)
        patternLEDList(0, 1) = framesG(i + 49)
        patternLEDList(0, 2) = framesB(i + 49)
        Button50.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 50)
        patternLEDList(1, 1) = framesG(i + 50)
        patternLEDList(1, 2) = framesB(i + 50)
        Button51.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 51)
        patternLEDList(2, 1) = framesG(i + 51)
        patternLEDList(2, 2) = framesB(i + 51)
        Button52.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 52)
        patternLEDList(3, 1) = framesG(i + 52)
        patternLEDList(3, 2) = framesB(i + 52)
        Button53.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 53)
        patternLEDList(4, 1) = framesG(i + 53)
        patternLEDList(4, 2) = framesB(i + 53)
        Button54.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 54)
        patternLEDList(5, 1) = framesG(i + 54)
        patternLEDList(5, 2) = framesB(i + 54)
        Button55.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 55)
        patternLEDList(6, 1) = framesG(i + 55)
        patternLEDList(6, 2) = framesB(i + 55)
        Button56.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 56)
        patternLEDList(7, 1) = framesG(i + 56)
        patternLEDList(7, 2) = framesB(i + 56)
        Button57.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 57)
        patternLEDList(8, 1) = framesG(i + 57)
        patternLEDList(8, 2) = framesB(i + 57)
        Button58.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 58)
        patternLEDList(9, 1) = framesG(i + 58)
        patternLEDList(9, 2) = framesB(i + 58)
        Button59.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 59)
        patternLEDList(0, 1) = framesG(i + 59)
        patternLEDList(0, 2) = framesB(i + 59)
        Button60.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 60)
        patternLEDList(1, 1) = framesG(i + 60)
        patternLEDList(1, 2) = framesB(i + 60)
        Button61.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 61)
        patternLEDList(2, 1) = framesG(i + 61)
        patternLEDList(2, 2) = framesB(i + 61)
        Button62.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 62)
        patternLEDList(3, 1) = framesG(i + 62)
        patternLEDList(3, 2) = framesB(i + 62)
        Button63.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 63)
        patternLEDList(4, 1) = framesG(i + 63)
        patternLEDList(4, 2) = framesB(i + 63)
        Button64.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 64)
        patternLEDList(5, 1) = framesG(i + 64)
        patternLEDList(5, 2) = framesB(i + 64)
        Button65.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 65)
        patternLEDList(6, 1) = framesG(i + 65)
        patternLEDList(6, 2) = framesB(i + 65)
        Button66.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 66)
        patternLEDList(7, 1) = framesG(i + 66)
        patternLEDList(7, 2) = framesB(i + 66)
        Button67.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 67)
        patternLEDList(8, 1) = framesG(i + 67)
        patternLEDList(8, 2) = framesB(i + 67)
        Button68.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 68)
        patternLEDList(9, 1) = framesG(i + 68)
        patternLEDList(9, 2) = framesB(i + 68)
        Button69.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 69)
        patternLEDList(0, 1) = framesG(i + 69)
        patternLEDList(0, 2) = framesB(i + 69)
        Button70.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 70)
        patternLEDList(1, 1) = framesG(i + 70)
        patternLEDList(1, 2) = framesB(i + 70)
        Button71.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 71)
        patternLEDList(2, 1) = framesG(i + 71)
        patternLEDList(2, 2) = framesB(i + 71)
        Button72.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 72)
        patternLEDList(3, 1) = framesG(i + 72)
        patternLEDList(3, 2) = framesB(i + 72)
        Button73.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 73)
        patternLEDList(4, 1) = framesG(i + 73)
        patternLEDList(4, 2) = framesB(i + 73)
        Button74.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 74)
        patternLEDList(5, 1) = framesG(i + 74)
        patternLEDList(5, 2) = framesB(i + 74)
        Button75.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 75)
        patternLEDList(6, 1) = framesG(i + 75)
        patternLEDList(6, 2) = framesB(i + 75)
        Button76.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 76)
        patternLEDList(7, 1) = framesG(i + 76)
        patternLEDList(7, 2) = framesB(i + 76)
        Button77.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 77)
        patternLEDList(8, 1) = framesG(i + 77)
        patternLEDList(8, 2) = framesB(i + 77)
        Button78.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 78)
        patternLEDList(9, 1) = framesG(i + 78)
        patternLEDList(9, 2) = framesB(i + 78)
        Button79.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 79)
        patternLEDList(0, 1) = framesG(i + 79)
        patternLEDList(0, 2) = framesB(i + 79)
        Button80.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 80)
        patternLEDList(1, 1) = framesG(i + 80)
        patternLEDList(1, 2) = framesB(i + 80)
        Button81.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 81)
        patternLEDList(2, 1) = framesG(i + 81)
        patternLEDList(2, 2) = framesB(i + 81)
        Button82.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 82)
        patternLEDList(3, 1) = framesG(i + 82)
        patternLEDList(3, 2) = framesB(i + 82)
        Button83.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 83)
        patternLEDList(4, 1) = framesG(i + 83)
        patternLEDList(4, 2) = framesB(i + 83)
        Button84.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 84)
        patternLEDList(5, 1) = framesG(i + 84)
        patternLEDList(5, 2) = framesB(i + 84)
        Button85.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 85)
        patternLEDList(6, 1) = framesG(i + 85)
        patternLEDList(6, 2) = framesB(i + 85)
        Button86.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 86)
        patternLEDList(7, 1) = framesG(i + 86)
        patternLEDList(7, 2) = framesB(i + 86)
        Button87.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 87)
        patternLEDList(8, 1) = framesG(i + 87)
        patternLEDList(8, 2) = framesB(i + 87)
        Button88.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 88)
        patternLEDList(9, 1) = framesG(i + 88)
        patternLEDList(9, 2) = framesB(i + 88)
        Button89.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 89)
        patternLEDList(0, 1) = framesG(i + 89)
        patternLEDList(0, 2) = framesB(i + 89)
        Button90.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 90)
        patternLEDList(1, 1) = framesG(i + 90)
        patternLEDList(1, 2) = framesB(i + 90)
        Button91.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 91)
        patternLEDList(2, 1) = framesG(i + 91)
        patternLEDList(2, 2) = framesB(i + 91)
        Button92.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 92)
        patternLEDList(3, 1) = framesG(i + 92)
        patternLEDList(3, 2) = framesB(i + 92)
        Button93.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 93)
        patternLEDList(4, 1) = framesG(i + 93)
        patternLEDList(4, 2) = framesB(i + 93)
        Button94.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 94)
        patternLEDList(5, 1) = framesG(i + 94)
        patternLEDList(5, 2) = framesB(i + 94)
        Button95.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 95)
        patternLEDList(6, 1) = framesG(i + 95)
        patternLEDList(6, 2) = framesB(i + 95)
        Button96.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 96)
        patternLEDList(7, 1) = framesG(i + 96)
        patternLEDList(7, 2) = framesB(i + 96)
        Button97.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 97)
        patternLEDList(8, 1) = framesG(i + 97)
        patternLEDList(8, 2) = framesB(i + 97)
        Button98.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 98)
        patternLEDList(9, 1) = framesG(i + 98)
        patternLEDList(9, 2) = framesB(i + 98)
        Button99.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(0, 0) = framesR(i + 99)
        patternLEDList(0, 1) = framesG(i + 99)
        patternLEDList(0, 2) = framesB(i + 99)
        Button100.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))

        patternLEDList(1, 0) = framesR(i + 100)
        patternLEDList(1, 1) = framesG(i + 100)
        patternLEDList(1, 2) = framesB(i + 100)
        Button101.BackColor = Color.FromArgb(255, patternLEDList(1, 0), patternLEDList(1, 1), patternLEDList(1, 2))

        patternLEDList(2, 0) = framesR(i + 101)
        patternLEDList(2, 1) = framesG(i + 101)
        patternLEDList(2, 2) = framesB(i + 101)
        Button102.BackColor = Color.FromArgb(255, patternLEDList(2, 0), patternLEDList(2, 1), patternLEDList(2, 2))

        patternLEDList(3, 0) = framesR(i + 102)
        patternLEDList(3, 1) = framesG(i + 102)
        patternLEDList(3, 2) = framesB(i + 102)
        Button103.BackColor = Color.FromArgb(255, patternLEDList(3, 0), patternLEDList(3, 1), patternLEDList(3, 2))

        patternLEDList(4, 0) = framesR(i + 103)
        patternLEDList(4, 1) = framesG(i + 103)
        patternLEDList(4, 2) = framesB(i + 103)
        Button104.BackColor = Color.FromArgb(255, patternLEDList(4, 0), patternLEDList(4, 1), patternLEDList(4, 2))

        patternLEDList(5, 0) = framesR(i + 104)
        patternLEDList(5, 1) = framesG(i + 104)
        patternLEDList(5, 2) = framesB(i + 104)
        Button105.BackColor = Color.FromArgb(255, patternLEDList(5, 0), patternLEDList(5, 1), patternLEDList(5, 2))

        patternLEDList(6, 0) = framesR(i + 105)
        patternLEDList(6, 1) = framesG(i + 105)
        patternLEDList(6, 2) = framesB(i + 105)
        Button106.BackColor = Color.FromArgb(255, patternLEDList(6, 0), patternLEDList(6, 1), patternLEDList(6, 2))

        patternLEDList(7, 0) = framesR(i + 106)
        patternLEDList(7, 1) = framesG(i + 106)
        patternLEDList(7, 2) = framesB(i + 106)
        Button107.BackColor = Color.FromArgb(255, patternLEDList(7, 0), patternLEDList(7, 1), patternLEDList(7, 2))

        patternLEDList(8, 0) = framesR(i + 107)
        patternLEDList(8, 1) = framesG(i + 107)
        patternLEDList(8, 2) = framesB(i + 107)
        Button108.BackColor = Color.FromArgb(255, patternLEDList(8, 0), patternLEDList(8, 1), patternLEDList(8, 2))

        patternLEDList(9, 0) = framesR(i + 108)
        patternLEDList(9, 1) = framesG(i + 108)
        patternLEDList(9, 2) = framesB(i + 108)
        Button109.BackColor = Color.FromArgb(255, patternLEDList(9, 0), patternLEDList(9, 1), patternLEDList(9, 2))

        patternLEDList(10, 0) = framesR(i + 109)
        patternLEDList(10, 1) = framesG(i + 109)
        patternLEDList(10, 2) = framesB(i + 109)
        Button110.BackColor = Color.FromArgb(255, patternLEDList(10, 0), patternLEDList(10, 1), patternLEDList(10, 2))

        patternLEDList(11, 0) = framesR(i + 110)
        patternLEDList(11, 1) = framesG(i + 110)
        patternLEDList(11, 2) = framesB(i + 110)
        Button111.BackColor = Color.FromArgb(255, patternLEDList(11, 0), patternLEDList(11, 1), patternLEDList(11, 2))

        patternLEDList(12, 0) = framesR(i + 111)
        patternLEDList(12, 1) = framesG(i + 111)
        patternLEDList(12, 2) = framesB(i + 111)
        Button112.BackColor = Color.FromArgb(255, patternLEDList(12, 0), patternLEDList(12, 1), patternLEDList(12, 2))

        patternLEDList(13, 0) = framesR(i + 112)
        patternLEDList(13, 1) = framesG(i + 112)
        patternLEDList(13, 2) = framesB(i + 112)
        Button113.BackColor = Color.FromArgb(255, patternLEDList(13, 0), patternLEDList(13, 1), patternLEDList(13, 2))

        patternLEDList(14, 0) = framesR(i + 113)
        patternLEDList(14, 1) = framesG(i + 113)
        patternLEDList(14, 2) = framesB(i + 113)
        Button114.BackColor = Color.FromArgb(255, patternLEDList(14, 0), patternLEDList(14, 1), patternLEDList(14, 2))

        patternLEDList(15, 0) = framesR(i + 114)
        patternLEDList(15, 1) = framesG(i + 114)
        patternLEDList(15, 2) = framesB(i + 114)
        Button115.BackColor = Color.FromArgb(255, patternLEDList(15, 0), patternLEDList(15, 1), patternLEDList(15, 2))

        patternLEDList(16, 0) = framesR(i + 115)
        patternLEDList(16, 1) = framesG(i + 115)
        patternLEDList(16, 2) = framesB(i + 115)
        Button116.BackColor = Color.FromArgb(255, patternLEDList(16, 0), patternLEDList(16, 1), patternLEDList(16, 2))

        patternLEDList(17, 0) = framesR(i + 116)
        patternLEDList(17, 1) = framesG(i + 116)
        patternLEDList(17, 2) = framesB(i + 116)
        Button117.BackColor = Color.FromArgb(255, patternLEDList(17, 0), patternLEDList(17, 1), patternLEDList(17, 2))

        patternLEDList(18, 0) = framesR(i + 117)
        patternLEDList(18, 1) = framesG(i + 117)
        patternLEDList(18, 2) = framesB(i + 117)
        Button118.BackColor = Color.FromArgb(255, patternLEDList(18, 0), patternLEDList(18, 1), patternLEDList(18, 2))

        patternLEDList(19, 0) = framesR(i + 118)
        patternLEDList(19, 1) = framesG(i + 118)
        patternLEDList(19, 2) = framesB(i + 118)
        Button119.BackColor = Color.FromArgb(255, patternLEDList(19, 0), patternLEDList(19, 1), patternLEDList(19, 2))

        patternLEDList(20, 0) = framesR(i + 119)
        patternLEDList(20, 1) = framesG(i + 119)
        patternLEDList(20, 2) = framesB(i + 119)
        Button120.BackColor = Color.FromArgb(255, patternLEDList(20, 0), patternLEDList(20, 1), patternLEDList(20, 2))

        patternLEDList(21, 0) = framesR(i + 120)
        patternLEDList(21, 1) = framesG(i + 120)
        patternLEDList(21, 2) = framesB(i + 120)
        Button121.BackColor = Color.FromArgb(255, patternLEDList(21, 0), patternLEDList(21, 1), patternLEDList(21, 2))

        patternLEDList(22, 0) = framesR(i + 121)
        patternLEDList(22, 1) = framesG(i + 121)
        patternLEDList(22, 2) = framesB(i + 121)
        Button122.BackColor = Color.FromArgb(255, patternLEDList(22, 0), patternLEDList(22, 1), patternLEDList(22, 2))

        patternLEDList(23, 0) = framesR(i + 122)
        patternLEDList(23, 1) = framesG(i + 122)
        patternLEDList(23, 2) = framesB(i + 122)
        Button123.BackColor = Color.FromArgb(255, patternLEDList(23, 0), patternLEDList(23, 1), patternLEDList(23, 2))

        patternLEDList(24, 0) = framesR(i + 123)
        patternLEDList(24, 1) = framesG(i + 123)
        patternLEDList(24, 2) = framesB(i + 123)
        Button124.BackColor = Color.FromArgb(255, patternLEDList(24, 0), patternLEDList(24, 1), patternLEDList(24, 2))

        patternLEDList(25, 0) = framesR(i + 124)
        patternLEDList(25, 1) = framesG(i + 124)
        patternLEDList(25, 2) = framesB(i + 124)
        Button125.BackColor = Color.FromArgb(255, patternLEDList(25, 0), patternLEDList(25, 1), patternLEDList(25, 2))

        patternLEDList(26, 0) = framesR(i + 125)
        patternLEDList(26, 1) = framesG(i + 125)
        patternLEDList(26, 2) = framesB(i + 125)
        Button126.BackColor = Color.FromArgb(255, patternLEDList(26, 0), patternLEDList(26, 1), patternLEDList(26, 2))

        patternLEDList(27, 0) = framesR(i + 126)
        patternLEDList(27, 1) = framesG(i + 126)
        patternLEDList(27, 2) = framesB(i + 126)
        Button127.BackColor = Color.FromArgb(255, patternLEDList(27, 0), patternLEDList(27, 1), patternLEDList(27, 2))

        patternLEDList(28, 0) = framesR(i + 127)
        patternLEDList(28, 1) = framesG(i + 127)
        patternLEDList(28, 2) = framesB(i + 127)
        Button128.BackColor = Color.FromArgb(255, patternLEDList(28, 0), patternLEDList(28, 1), patternLEDList(28, 2))

        patternLEDList(29, 0) = framesR(i + 128)
        patternLEDList(29, 1) = framesG(i + 128)
        patternLEDList(29, 2) = framesB(i + 128)
        Button129.BackColor = Color.FromArgb(255, patternLEDList(29, 0), patternLEDList(29, 1), patternLEDList(29, 2))

        patternLEDList(30, 0) = framesR(i + 129)
        patternLEDList(30, 1) = framesG(i + 129)
        patternLEDList(30, 2) = framesB(i + 129)
        Button130.BackColor = Color.FromArgb(255, patternLEDList(30, 0), patternLEDList(30, 1), patternLEDList(30, 2))

        patternLEDList(31, 0) = framesR(i + 130)
        patternLEDList(31, 1) = framesG(i + 130)
        patternLEDList(31, 2) = framesB(i + 130)
        Button131.BackColor = Color.FromArgb(255, patternLEDList(31, 0), patternLEDList(31, 1), patternLEDList(31, 2))

        patternLEDList(32, 0) = framesR(i + 131)
        patternLEDList(32, 1) = framesG(i + 131)
        patternLEDList(32, 2) = framesB(i + 131)
        Button132.BackColor = Color.FromArgb(255, patternLEDList(32, 0), patternLEDList(32, 1), patternLEDList(32, 2))

        patternLEDList(33, 0) = framesR(i + 132)
        patternLEDList(33, 1) = framesG(i + 132)
        patternLEDList(33, 2) = framesB(i + 132)
        Button133.BackColor = Color.FromArgb(255, patternLEDList(33, 0), patternLEDList(33, 1), patternLEDList(33, 2))

        patternLEDList(34, 0) = framesR(i + 133)
        patternLEDList(34, 1) = framesG(i + 133)
        patternLEDList(34, 2) = framesB(i + 133)
        Button134.BackColor = Color.FromArgb(255, patternLEDList(34, 0), patternLEDList(34, 1), patternLEDList(34, 2))

        patternLEDList(35, 0) = framesR(i + 134)
        patternLEDList(35, 1) = framesG(i + 134)
        patternLEDList(35, 2) = framesB(i + 134)
        Button135.BackColor = Color.FromArgb(255, patternLEDList(35, 0), patternLEDList(35, 1), patternLEDList(35, 2))

        patternLEDList(36, 0) = framesR(i + 135)
        patternLEDList(36, 1) = framesG(i + 135)
        patternLEDList(36, 2) = framesB(i + 135)
        Button136.BackColor = Color.FromArgb(255, patternLEDList(36, 0), patternLEDList(36, 1), patternLEDList(36, 2))

        patternLEDList(37, 0) = framesR(i + 136)
        patternLEDList(37, 1) = framesG(i + 136)
        patternLEDList(37, 2) = framesB(i + 136)
        Button137.BackColor = Color.FromArgb(255, patternLEDList(37, 0), patternLEDList(37, 1), patternLEDList(37, 2))

        patternLEDList(38, 0) = framesR(i + 137)
        patternLEDList(38, 1) = framesG(i + 137)
        patternLEDList(38, 2) = framesB(i + 137)
        Button138.BackColor = Color.FromArgb(255, patternLEDList(38, 0), patternLEDList(38, 1), patternLEDList(38, 2))

        patternLEDList(39, 0) = framesR(i + 138)
        patternLEDList(39, 1) = framesG(i + 138)
        patternLEDList(39, 2) = framesB(i + 138)
        Button139.BackColor = Color.FromArgb(255, patternLEDList(39, 0), patternLEDList(39, 1), patternLEDList(39, 2))

        patternLEDList(40, 0) = framesR(i + 139)
        patternLEDList(40, 1) = framesG(i + 139)
        patternLEDList(40, 2) = framesB(i + 139)
        Button140.BackColor = Color.FromArgb(255, patternLEDList(40, 0), patternLEDList(40, 1), patternLEDList(40, 2))

        patternLEDList(41, 0) = framesR(i + 140)
        patternLEDList(41, 1) = framesG(i + 140)
        patternLEDList(41, 2) = framesB(i + 140)
        Button141.BackColor = Color.FromArgb(255, patternLEDList(41, 0), patternLEDList(41, 1), patternLEDList(41, 2))

        patternLEDList(42, 0) = framesR(i + 141)
        patternLEDList(42, 1) = framesG(i + 141)
        patternLEDList(42, 2) = framesB(i + 141)
        Button142.BackColor = Color.FromArgb(255, patternLEDList(42, 0), patternLEDList(42, 1), patternLEDList(42, 2))

        patternLEDList(43, 0) = framesR(i + 142)
        patternLEDList(43, 1) = framesG(i + 142)
        patternLEDList(43, 2) = framesB(i + 142)
        Button143.BackColor = Color.FromArgb(255, patternLEDList(43, 0), patternLEDList(43, 1), patternLEDList(43, 2))

        patternLEDList(44, 0) = framesR(i + 143)
        patternLEDList(44, 1) = framesG(i + 143)
        patternLEDList(44, 2) = framesB(i + 143)
        Button144.BackColor = Color.FromArgb(255, patternLEDList(44, 0), patternLEDList(44, 1), patternLEDList(44, 2))

        patternLEDList(45, 0) = framesR(i + 144)
        patternLEDList(45, 1) = framesG(i + 144)
        patternLEDList(45, 2) = framesB(i + 144)
        Button145.BackColor = Color.FromArgb(255, patternLEDList(45, 0), patternLEDList(45, 1), patternLEDList(45, 2))

        patternLEDList(46, 0) = framesR(i + 145)
        patternLEDList(46, 1) = framesG(i + 145)
        patternLEDList(46, 2) = framesB(i + 145)
        Button146.BackColor = Color.FromArgb(255, patternLEDList(46, 0), patternLEDList(46, 1), patternLEDList(46, 2))

        patternLEDList(47, 0) = framesR(i + 146)
        patternLEDList(47, 1) = framesG(i + 146)
        patternLEDList(47, 2) = framesB(i + 146)
        Button147.BackColor = Color.FromArgb(255, patternLEDList(47, 0), patternLEDList(47, 1), patternLEDList(47, 2))

        patternLEDList(48, 0) = framesR(i + 147)
        patternLEDList(48, 1) = framesG(i + 147)
        patternLEDList(48, 2) = framesB(i + 147)
        Button148.BackColor = Color.FromArgb(255, patternLEDList(48, 0), patternLEDList(48, 1), patternLEDList(48, 2))

        patternLEDList(49, 0) = framesR(i + 148)
        patternLEDList(49, 1) = framesG(i + 148)
        patternLEDList(49, 2) = framesB(i + 148)
        Button149.BackColor = Color.FromArgb(255, patternLEDList(49, 0), patternLEDList(49, 1), patternLEDList(49, 2))

        patternLEDList(50, 0) = framesR(i + 149)
        patternLEDList(50, 1) = framesG(i + 149)
        patternLEDList(50, 2) = framesB(i + 149)
        Button150.BackColor = Color.FromArgb(255, patternLEDList(50, 0), patternLEDList(50, 1), patternLEDList(50, 2))

        patternLEDList(51, 0) = framesR(i + 150)
        patternLEDList(51, 1) = framesG(i + 150)
        patternLEDList(51, 2) = framesB(i + 150)
        Button151.BackColor = Color.FromArgb(255, patternLEDList(51, 0), patternLEDList(51, 1), patternLEDList(51, 2))

        patternLEDList(52, 0) = framesR(i + 151)
        patternLEDList(52, 1) = framesG(i + 151)
        patternLEDList(52, 2) = framesB(i + 151)
        Button152.BackColor = Color.FromArgb(255, patternLEDList(52, 0), patternLEDList(52, 1), patternLEDList(52, 2))

        patternLEDList(53, 0) = framesR(i + 152)
        patternLEDList(53, 1) = framesG(i + 152)
        patternLEDList(53, 2) = framesB(i + 152)
        Button153.BackColor = Color.FromArgb(255, patternLEDList(53, 0), patternLEDList(53, 1), patternLEDList(53, 2))

        patternLEDList(54, 0) = framesR(i + 153)
        patternLEDList(54, 1) = framesG(i + 153)
        patternLEDList(54, 2) = framesB(i + 153)
        Button154.BackColor = Color.FromArgb(255, patternLEDList(54, 0), patternLEDList(54, 1), patternLEDList(54, 2))

        patternLEDList(55, 0) = framesR(i + 154)
        patternLEDList(55, 1) = framesG(i + 154)
        patternLEDList(55, 2) = framesB(i + 154)
        Button155.BackColor = Color.FromArgb(255, patternLEDList(55, 0), patternLEDList(55, 1), patternLEDList(55, 2))

        patternLEDList(56, 0) = framesR(i + 155)
        patternLEDList(56, 1) = framesG(i + 155)
        patternLEDList(56, 2) = framesB(i + 155)
        Button156.BackColor = Color.FromArgb(255, patternLEDList(56, 0), patternLEDList(56, 1), patternLEDList(56, 2))

        patternLEDList(57, 0) = framesR(i + 156)
        patternLEDList(57, 1) = framesG(i + 156)
        patternLEDList(57, 2) = framesB(i + 156)
        Button157.BackColor = Color.FromArgb(255, patternLEDList(57, 0), patternLEDList(57, 1), patternLEDList(57, 2))

        patternLEDList(58, 0) = framesR(i + 157)
        patternLEDList(58, 1) = framesG(i + 157)
        patternLEDList(58, 2) = framesB(i + 157)
        Button158.BackColor = Color.FromArgb(255, patternLEDList(58, 0), patternLEDList(58, 1), patternLEDList(58, 2))

        patternLEDList(59, 0) = framesR(i + 158)
        patternLEDList(59, 1) = framesG(i + 158)
        patternLEDList(59, 2) = framesB(i + 158)
        Button159.BackColor = Color.FromArgb(255, patternLEDList(59, 0), patternLEDList(59, 1), patternLEDList(59, 2))

        patternLEDList(60, 0) = framesR(i + 159)
        patternLEDList(60, 1) = framesG(i + 159)
        patternLEDList(60, 2) = framesB(i + 159)
        Button160.BackColor = Color.FromArgb(255, patternLEDList(60, 0), patternLEDList(60, 1), patternLEDList(60, 2))

        patternLEDList(61, 0) = framesR(i + 160)
        patternLEDList(61, 1) = framesG(i + 160)
        patternLEDList(61, 2) = framesB(i + 160)
        Button161.BackColor = Color.FromArgb(255, patternLEDList(61, 0), patternLEDList(61, 1), patternLEDList(61, 2))

        patternLEDList(62, 0) = framesR(i + 161)
        patternLEDList(62, 1) = framesG(i + 161)
        patternLEDList(62, 2) = framesB(i + 161)
        Button162.BackColor = Color.FromArgb(255, patternLEDList(62, 0), patternLEDList(62, 1), patternLEDList(62, 2))

        patternLEDList(63, 0) = framesR(i + 162)
        patternLEDList(63, 1) = framesG(i + 162)
        patternLEDList(63, 2) = framesB(i + 162)
        Button163.BackColor = Color.FromArgb(255, patternLEDList(63, 0), patternLEDList(63, 1), patternLEDList(63, 2))

        patternLEDList(64, 0) = framesR(i + 163)
        patternLEDList(64, 1) = framesG(i + 163)
        patternLEDList(64, 2) = framesB(i + 163)
        Button164.BackColor = Color.FromArgb(255, patternLEDList(64, 0), patternLEDList(64, 1), patternLEDList(64, 2))

        patternLEDList(65, 0) = framesR(i + 164)
        patternLEDList(65, 1) = framesG(i + 164)
        patternLEDList(65, 2) = framesB(i + 164)
        Button165.BackColor = Color.FromArgb(255, patternLEDList(65, 0), patternLEDList(65, 1), patternLEDList(65, 2))

        patternLEDList(66, 0) = framesR(i + 165)
        patternLEDList(66, 1) = framesG(i + 165)
        patternLEDList(66, 2) = framesB(i + 165)
        Button166.BackColor = Color.FromArgb(255, patternLEDList(66, 0), patternLEDList(66, 1), patternLEDList(66, 2))

        patternLEDList(67, 0) = framesR(i + 166)
        patternLEDList(67, 1) = framesG(i + 166)
        patternLEDList(67, 2) = framesB(i + 166)
        Button167.BackColor = Color.FromArgb(255, patternLEDList(67, 0), patternLEDList(67, 1), patternLEDList(67, 2))

        patternLEDList(68, 0) = framesR(i + 167)
        patternLEDList(68, 1) = framesG(i + 167)
        patternLEDList(68, 2) = framesB(i + 167)
        Button168.BackColor = Color.FromArgb(255, patternLEDList(68, 0), patternLEDList(68, 1), patternLEDList(68, 2))

        patternLEDList(69, 0) = framesR(i + 168)
        patternLEDList(69, 1) = framesG(i + 168)
        patternLEDList(69, 2) = framesB(i + 168)
        Button169.BackColor = Color.FromArgb(255, patternLEDList(69, 0), patternLEDList(69, 1), patternLEDList(69, 2))

        patternLEDList(70, 0) = framesR(i + 169)
        patternLEDList(70, 1) = framesG(i + 169)
        patternLEDList(70, 2) = framesB(i + 169)
        Button170.BackColor = Color.FromArgb(255, patternLEDList(70, 0), patternLEDList(70, 1), patternLEDList(70, 2))

        patternLEDList(71, 0) = framesR(i + 170)
        patternLEDList(71, 1) = framesG(i + 170)
        patternLEDList(71, 2) = framesB(i + 170)
        Button171.BackColor = Color.FromArgb(255, patternLEDList(71, 0), patternLEDList(71, 1), patternLEDList(71, 2))

        patternLEDList(72, 0) = framesR(i + 171)
        patternLEDList(72, 1) = framesG(i + 171)
        patternLEDList(72, 2) = framesB(i + 171)
        Button172.BackColor = Color.FromArgb(255, patternLEDList(72, 0), patternLEDList(72, 1), patternLEDList(72, 2))

        patternLEDList(73, 0) = framesR(i + 172)
        patternLEDList(73, 1) = framesG(i + 172)
        patternLEDList(73, 2) = framesB(i + 172)
        Button173.BackColor = Color.FromArgb(255, patternLEDList(73, 0), patternLEDList(73, 1), patternLEDList(73, 2))

        patternLEDList(74, 0) = framesR(i + 173)
        patternLEDList(74, 1) = framesG(i + 173)
        patternLEDList(74, 2) = framesB(i + 173)
        Button174.BackColor = Color.FromArgb(255, patternLEDList(74, 0), patternLEDList(74, 1), patternLEDList(74, 2))

        patternLEDList(75, 0) = framesR(i + 174)
        patternLEDList(75, 1) = framesG(i + 174)
        patternLEDList(75, 2) = framesB(i + 174)
        Button175.BackColor = Color.FromArgb(255, patternLEDList(75, 0), patternLEDList(75, 1), patternLEDList(75, 2))

        patternLEDList(76, 0) = framesR(i + 175)
        patternLEDList(76, 1) = framesG(i + 175)
        patternLEDList(76, 2) = framesB(i + 175)
        Button176.BackColor = Color.FromArgb(255, patternLEDList(76, 0), patternLEDList(76, 1), patternLEDList(76, 2))

        patternLEDList(77, 0) = framesR(i + 176)
        patternLEDList(77, 1) = framesG(i + 176)
        patternLEDList(77, 2) = framesB(i + 176)
        Button177.BackColor = Color.FromArgb(255, patternLEDList(77, 0), patternLEDList(77, 1), patternLEDList(77, 2))

        patternLEDList(78, 0) = framesR(i + 177)
        patternLEDList(78, 1) = framesG(i + 177)
        patternLEDList(78, 2) = framesB(i + 177)
        Button178.BackColor = Color.FromArgb(255, patternLEDList(78, 0), patternLEDList(78, 1), patternLEDList(78, 2))

        patternLEDList(79, 0) = framesR(i + 178)
        patternLEDList(79, 1) = framesG(i + 178)
        patternLEDList(79, 2) = framesB(i + 178)
        Button179.BackColor = Color.FromArgb(255, patternLEDList(79, 0), patternLEDList(79, 1), patternLEDList(79, 2))

        patternLEDList(80, 0) = framesR(i + 179)
        patternLEDList(80, 1) = framesG(i + 179)
        patternLEDList(80, 2) = framesB(i + 179)
        Button180.BackColor = Color.FromArgb(255, patternLEDList(80, 0), patternLEDList(80, 1), patternLEDList(80, 2))

        patternLEDList(81, 0) = framesR(i + 180)
        patternLEDList(81, 1) = framesG(i + 180)
        patternLEDList(81, 2) = framesB(i + 180)
        Button181.BackColor = Color.FromArgb(255, patternLEDList(81, 0), patternLEDList(81, 1), patternLEDList(81, 2))

        patternLEDList(82, 0) = framesR(i + 181)
        patternLEDList(82, 1) = framesG(i + 181)
        patternLEDList(82, 2) = framesB(i + 181)
        Button182.BackColor = Color.FromArgb(255, patternLEDList(82, 0), patternLEDList(82, 1), patternLEDList(82, 2))

        patternLEDList(83, 0) = framesR(i + 182)
        patternLEDList(83, 1) = framesG(i + 182)
        patternLEDList(83, 2) = framesB(i + 182)
        Button183.BackColor = Color.FromArgb(255, patternLEDList(83, 0), patternLEDList(83, 1), patternLEDList(83, 2))

        patternLEDList(84, 0) = framesR(i + 183)
        patternLEDList(84, 1) = framesG(i + 183)
        patternLEDList(84, 2) = framesB(i + 183)
        Button184.BackColor = Color.FromArgb(255, patternLEDList(84, 0), patternLEDList(84, 1), patternLEDList(84, 2))

        patternLEDList(85, 0) = framesR(i + 184)
        patternLEDList(85, 1) = framesG(i + 184)
        patternLEDList(85, 2) = framesB(i + 184)
        Button185.BackColor = Color.FromArgb(255, patternLEDList(85, 0), patternLEDList(85, 1), patternLEDList(85, 2))

        patternLEDList(86, 0) = framesR(i + 185)
        patternLEDList(86, 1) = framesG(i + 185)
        patternLEDList(86, 2) = framesB(i + 185)
        Button186.BackColor = Color.FromArgb(255, patternLEDList(86, 0), patternLEDList(86, 1), patternLEDList(86, 2))

        patternLEDList(87, 0) = framesR(i + 186)
        patternLEDList(87, 1) = framesG(i + 186)
        patternLEDList(87, 2) = framesB(i + 186)
        Button187.BackColor = Color.FromArgb(255, patternLEDList(87, 0), patternLEDList(87, 1), patternLEDList(87, 2))

        patternLEDList(88, 0) = framesR(i + 187)
        patternLEDList(88, 1) = framesG(i + 187)
        patternLEDList(88, 2) = framesB(i + 187)
        Button188.BackColor = Color.FromArgb(255, patternLEDList(88, 0), patternLEDList(88, 1), patternLEDList(88, 2))

        patternLEDList(89, 0) = framesR(i + 188)
        patternLEDList(89, 1) = framesG(i + 188)
        patternLEDList(89, 2) = framesB(i + 188)
        Button189.BackColor = Color.FromArgb(255, patternLEDList(89, 0), patternLEDList(89, 1), patternLEDList(89, 2))

        patternLEDList(90, 0) = framesR(i + 189)
        patternLEDList(90, 1) = framesG(i + 189)
        patternLEDList(90, 2) = framesB(i + 189)
        Button190.BackColor = Color.FromArgb(255, patternLEDList(90, 0), patternLEDList(90, 1), patternLEDList(90, 2))

        patternLEDList(91, 0) = framesR(i + 190)
        patternLEDList(91, 1) = framesG(i + 190)
        patternLEDList(91, 2) = framesB(i + 190)
        Button191.BackColor = Color.FromArgb(255, patternLEDList(91, 0), patternLEDList(91, 1), patternLEDList(91, 2))

        patternLEDList(92, 0) = framesR(i + 191)
        patternLEDList(92, 1) = framesG(i + 191)
        patternLEDList(92, 2) = framesB(i + 191)
        Button192.BackColor = Color.FromArgb(255, patternLEDList(92, 0), patternLEDList(92, 1), patternLEDList(92, 2))

        patternLEDList(93, 0) = framesR(i + 192)
        patternLEDList(93, 1) = framesG(i + 192)
        patternLEDList(93, 2) = framesB(i + 192)
        Button193.BackColor = Color.FromArgb(255, patternLEDList(93, 0), patternLEDList(93, 1), patternLEDList(93, 2))

        patternLEDList(94, 0) = framesR(i + 193)
        patternLEDList(94, 1) = framesG(i + 193)
        patternLEDList(94, 2) = framesB(i + 193)
        Button194.BackColor = Color.FromArgb(255, patternLEDList(94, 0), patternLEDList(94, 1), patternLEDList(94, 2))

        patternLEDList(95, 0) = framesR(i + 194)
        patternLEDList(95, 1) = framesG(i + 194)
        patternLEDList(95, 2) = framesB(i + 194)
        Button195.BackColor = Color.FromArgb(255, patternLEDList(95, 0), patternLEDList(95, 1), patternLEDList(95, 2))

        patternLEDList(96, 0) = framesR(i + 195)
        patternLEDList(96, 1) = framesG(i + 195)
        patternLEDList(96, 2) = framesB(i + 195)
        Button196.BackColor = Color.FromArgb(255, patternLEDList(96, 0), patternLEDList(96, 1), patternLEDList(96, 2))

        patternLEDList(97, 0) = framesR(i + 196)
        patternLEDList(97, 1) = framesG(i + 196)
        patternLEDList(97, 2) = framesB(i + 196)
        Button197.BackColor = Color.FromArgb(255, patternLEDList(97, 0), patternLEDList(97, 1), patternLEDList(97, 2))

        patternLEDList(98, 0) = framesR(i + 197)
        patternLEDList(98, 1) = framesG(i + 197)
        patternLEDList(98, 2) = framesB(i + 197)
        Button198.BackColor = Color.FromArgb(255, patternLEDList(98, 0), patternLEDList(98, 1), patternLEDList(98, 2))

        patternLEDList(99, 0) = framesR(i + 198)
        patternLEDList(99, 1) = framesG(i + 198)
        patternLEDList(99, 2) = framesB(i + 198)
        Button199.BackColor = Color.FromArgb(255, patternLEDList(99, 0), patternLEDList(99, 1), patternLEDList(99, 2))

        patternLEDList(0, 0) = framesR(i + 199)
        patternLEDList(0, 1) = framesG(i + 199)
        patternLEDList(0, 2) = framesB(i + 199)
        Button200.BackColor = Color.FromArgb(255, patternLEDList(0, 0), patternLEDList(0, 1), patternLEDList(0, 2))


    End Sub
    Sub setbtncolor(i As Long)
        Dim y As Long
        For y = i * 200 To (i * 200) + 199
            f(y) = btn(y - i * 200).BackColor

        Next
    End Sub
    Sub setbtncolor2(i As Long)
        Dim y As Long
        y = i * 200

        Dim k As Long
        For k = 0 To 24
            f2(y + k) = btn(175 + k).BackColor
            f2(y + 25 + k) = btn(150 + k).BackColor
            f2(y + 50 + k) = btn(125 + k).BackColor
            f2(y + 75 + k) = btn(100 + k).BackColor
            f2(y + 100 + k) = btn(75 + k).BackColor
            f2(y + 125 + k) = btn(50 + k).BackColor
            f2(y + 150 + k) = btn(25 + k).BackColor
            f2(y + 175 + k) = btn(0 + k).BackColor
        Next

    End Sub
    Sub setbtncolor3(i As Long)
        Dim y As Integer
        Dim yy As Integer


        For y = 0 To 24
            For yy = 0 To 7
                f3(i * 200 + y * 8 + yy) = btn(yy * 25 + y).BackColor

            Next
        Next
    End Sub
    Sub setbtncolor4(i As Long)
        Dim y As Integer
        Dim yy As Integer


        For y = 0 To 24
            For yy = 0 To 7
                f4(i * 200 + y * 8 + yy) = btn((yy + 1) * 25 - y - 1).BackColor

            Next
        Next
    End Sub

    Private Sub Button271_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        copy = frameAnimator.Value * 200

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        read(copy)

    End Sub

    Private Sub Button290_Click(sender As Object, e As EventArgs)
        setarraydisply()
    End Sub
    Sub setarraydisply()
        PictureBox1.BackColor = Button1.BackColor
        PictureBox2.BackColor = Button2.BackColor
        PictureBox3.BackColor = Button3.BackColor
        PictureBox4.BackColor = Button4.BackColor
        PictureBox5.BackColor = Button5.BackColor
        PictureBox6.BackColor = Button6.BackColor
        PictureBox7.BackColor = Button7.BackColor
        PictureBox8.BackColor = Button8.BackColor

        PictureBox9.BackColor = Button9.BackColor
        PictureBox10.BackColor = Button10.BackColor
        PictureBox11.BackColor = Button11.BackColor
        PictureBox12.BackColor = Button12.BackColor
        PictureBox13.BackColor = Button13.BackColor
        PictureBox14.BackColor = Button14.BackColor
        PictureBox15.BackColor = Button15.BackColor
        PictureBox16.BackColor = Button16.BackColor
        PictureBox17.BackColor = Button17.BackColor
        PictureBox18.BackColor = Button18.BackColor
        PictureBox19.BackColor = Button19.BackColor
        PictureBox20.BackColor = Button20.BackColor
        PictureBox21.BackColor = Button21.BackColor
        PictureBox22.BackColor = Button22.BackColor
        PictureBox23.BackColor = Button23.BackColor
        PictureBox24.BackColor = Button24.BackColor
        PictureBox25.BackColor = Button25.BackColor
        PictureBox26.BackColor = Button26.BackColor
        PictureBox27.BackColor = Button27.BackColor
        PictureBox28.BackColor = Button28.BackColor
        PictureBox29.BackColor = Button29.BackColor
        PictureBox30.BackColor = Button30.BackColor
        PictureBox31.BackColor = Button31.BackColor
        PictureBox32.BackColor = Button32.BackColor
        PictureBox33.BackColor = Button33.BackColor
        PictureBox34.BackColor = Button34.BackColor
        PictureBox35.BackColor = Button35.BackColor
        PictureBox36.BackColor = Button36.BackColor
        PictureBox37.BackColor = Button37.BackColor
        PictureBox38.BackColor = Button38.BackColor
        PictureBox39.BackColor = Button39.BackColor
        PictureBox40.BackColor = Button40.BackColor
        PictureBox41.BackColor = Button41.BackColor
        PictureBox42.BackColor = Button42.BackColor
        PictureBox43.BackColor = Button43.BackColor
        PictureBox44.BackColor = Button44.BackColor
        PictureBox45.BackColor = Button45.BackColor
        PictureBox46.BackColor = Button46.BackColor
        PictureBox47.BackColor = Button47.BackColor
        PictureBox48.BackColor = Button48.BackColor
        PictureBox49.BackColor = Button49.BackColor
        PictureBox50.BackColor = Button50.BackColor
        PictureBox51.BackColor = Button51.BackColor
        PictureBox52.BackColor = Button52.BackColor
        PictureBox53.BackColor = Button53.BackColor
        PictureBox54.BackColor = Button54.BackColor
        PictureBox55.BackColor = Button55.BackColor
        PictureBox56.BackColor = Button56.BackColor
        PictureBox57.BackColor = Button57.BackColor
        PictureBox58.BackColor = Button58.BackColor
        PictureBox59.BackColor = Button59.BackColor
        PictureBox60.BackColor = Button60.BackColor
        PictureBox61.BackColor = Button61.BackColor
        PictureBox62.BackColor = Button62.BackColor
        PictureBox63.BackColor = Button63.BackColor
        PictureBox64.BackColor = Button64.BackColor
        PictureBox65.BackColor = Button65.BackColor
        PictureBox66.BackColor = Button66.BackColor
        PictureBox67.BackColor = Button67.BackColor
        PictureBox68.BackColor = Button68.BackColor
        PictureBox69.BackColor = Button69.BackColor
        PictureBox70.BackColor = Button70.BackColor
        PictureBox71.BackColor = Button71.BackColor
        PictureBox72.BackColor = Button72.BackColor
        PictureBox73.BackColor = Button73.BackColor
        PictureBox74.BackColor = Button74.BackColor
        PictureBox75.BackColor = Button75.BackColor
        PictureBox76.BackColor = Button76.BackColor
        PictureBox77.BackColor = Button77.BackColor
        PictureBox78.BackColor = Button78.BackColor
        PictureBox79.BackColor = Button79.BackColor
        PictureBox80.BackColor = Button80.BackColor
        PictureBox81.BackColor = Button81.BackColor
        PictureBox82.BackColor = Button82.BackColor
        PictureBox83.BackColor = Button83.BackColor
        PictureBox84.BackColor = Button84.BackColor
        PictureBox85.BackColor = Button85.BackColor
        PictureBox86.BackColor = Button86.BackColor
        PictureBox87.BackColor = Button87.BackColor
        PictureBox88.BackColor = Button88.BackColor
        PictureBox89.BackColor = Button89.BackColor
        PictureBox90.BackColor = Button90.BackColor
        PictureBox91.BackColor = Button91.BackColor
        PictureBox92.BackColor = Button92.BackColor
        PictureBox93.BackColor = Button93.BackColor
        PictureBox94.BackColor = Button94.BackColor
        PictureBox95.BackColor = Button95.BackColor
        PictureBox96.BackColor = Button96.BackColor
        PictureBox97.BackColor = Button97.BackColor
        PictureBox98.BackColor = Button98.BackColor
        PictureBox99.BackColor = Button99.BackColor
        PictureBox100.BackColor = Button100.BackColor
        PictureBox101.BackColor = Button101.BackColor
        PictureBox102.BackColor = Button102.BackColor
        PictureBox103.BackColor = Button103.BackColor
        PictureBox104.BackColor = Button104.BackColor
        PictureBox105.BackColor = Button105.BackColor
        PictureBox106.BackColor = Button106.BackColor
        PictureBox107.BackColor = Button107.BackColor
        PictureBox108.BackColor = Button108.BackColor
        PictureBox109.BackColor = Button109.BackColor
        PictureBox110.BackColor = Button110.BackColor
        PictureBox111.BackColor = Button111.BackColor
        PictureBox112.BackColor = Button112.BackColor
        PictureBox113.BackColor = Button113.BackColor
        PictureBox114.BackColor = Button114.BackColor
        PictureBox115.BackColor = Button115.BackColor
        PictureBox116.BackColor = Button116.BackColor
        PictureBox117.BackColor = Button117.BackColor
        PictureBox118.BackColor = Button118.BackColor
        PictureBox119.BackColor = Button119.BackColor
        PictureBox120.BackColor = Button120.BackColor
        PictureBox121.BackColor = Button121.BackColor
        PictureBox122.BackColor = Button122.BackColor
        PictureBox123.BackColor = Button123.BackColor
        PictureBox124.BackColor = Button124.BackColor
        PictureBox125.BackColor = Button125.BackColor
        PictureBox126.BackColor = Button126.BackColor
        PictureBox127.BackColor = Button127.BackColor
        PictureBox128.BackColor = Button128.BackColor
        PictureBox129.BackColor = Button129.BackColor
        PictureBox130.BackColor = Button130.BackColor
        PictureBox131.BackColor = Button131.BackColor
        PictureBox132.BackColor = Button132.BackColor
        PictureBox133.BackColor = Button133.BackColor
        PictureBox134.BackColor = Button134.BackColor
        PictureBox135.BackColor = Button135.BackColor
        PictureBox136.BackColor = Button136.BackColor
        PictureBox137.BackColor = Button137.BackColor
        PictureBox138.BackColor = Button138.BackColor
        PictureBox139.BackColor = Button139.BackColor
        PictureBox140.BackColor = Button140.BackColor
        PictureBox141.BackColor = Button141.BackColor
        PictureBox142.BackColor = Button142.BackColor
        PictureBox143.BackColor = Button143.BackColor
        PictureBox144.BackColor = Button144.BackColor
        PictureBox145.BackColor = Button145.BackColor
        PictureBox146.BackColor = Button146.BackColor
        PictureBox147.BackColor = Button147.BackColor
        PictureBox148.BackColor = Button148.BackColor
        PictureBox149.BackColor = Button149.BackColor
        PictureBox150.BackColor = Button150.BackColor
        PictureBox151.BackColor = Button151.BackColor
        PictureBox152.BackColor = Button152.BackColor
        PictureBox153.BackColor = Button153.BackColor
        PictureBox154.BackColor = Button154.BackColor
        PictureBox155.BackColor = Button155.BackColor
        PictureBox156.BackColor = Button156.BackColor
        PictureBox157.BackColor = Button157.BackColor
        PictureBox158.BackColor = Button158.BackColor
        PictureBox159.BackColor = Button159.BackColor
        PictureBox160.BackColor = Button160.BackColor
        PictureBox161.BackColor = Button161.BackColor
        PictureBox162.BackColor = Button162.BackColor
        PictureBox163.BackColor = Button163.BackColor
        PictureBox164.BackColor = Button164.BackColor
        PictureBox165.BackColor = Button165.BackColor
        PictureBox166.BackColor = Button166.BackColor
        PictureBox167.BackColor = Button167.BackColor
        PictureBox168.BackColor = Button168.BackColor
        PictureBox169.BackColor = Button169.BackColor
        PictureBox170.BackColor = Button170.BackColor
        PictureBox171.BackColor = Button171.BackColor
        PictureBox172.BackColor = Button172.BackColor
        PictureBox173.BackColor = Button173.BackColor
        PictureBox174.BackColor = Button174.BackColor
        PictureBox175.BackColor = Button175.BackColor
        PictureBox176.BackColor = Button176.BackColor
        PictureBox177.BackColor = Button177.BackColor
        PictureBox178.BackColor = Button178.BackColor
        PictureBox179.BackColor = Button179.BackColor
        PictureBox180.BackColor = Button180.BackColor
        PictureBox181.BackColor = Button181.BackColor
        PictureBox182.BackColor = Button182.BackColor
        PictureBox183.BackColor = Button183.BackColor
        PictureBox184.BackColor = Button184.BackColor
        PictureBox185.BackColor = Button185.BackColor
        PictureBox186.BackColor = Button186.BackColor
        PictureBox187.BackColor = Button187.BackColor
        PictureBox188.BackColor = Button188.BackColor
        PictureBox189.BackColor = Button189.BackColor
        PictureBox190.BackColor = Button190.BackColor
        PictureBox191.BackColor = Button191.BackColor
        PictureBox192.BackColor = Button192.BackColor
        PictureBox193.BackColor = Button193.BackColor
        PictureBox194.BackColor = Button194.BackColor
        PictureBox195.BackColor = Button195.BackColor
        PictureBox196.BackColor = Button196.BackColor
        PictureBox197.BackColor = Button197.BackColor
        PictureBox198.BackColor = Button198.BackColor
        PictureBox199.BackColor = Button199.BackColor
        PictureBox200.BackColor = Button200.BackColor


    End Sub

    Private Function clearLED(LED As Integer) As Color
        Dim offLED As Color
        patternLEDList(LED, 0) = 0
        patternLEDList(LED, 1) = 0
        patternLEDList(LED, 2) = 0
        offLED = Color.Black
        Return offLED
    End Function

    Sub clear()

        Button1.BackColor = clearLED(1)
        Button2.BackColor = clearLED(2)
        Button3.BackColor = clearLED(3)
        Button4.BackColor = clearLED(4)
        Button5.BackColor = clearLED(5)
        Button6.BackColor = clearLED(6)
        Button7.BackColor = clearLED(7)
        Button8.BackColor = clearLED(8)
        Button9.BackColor = clearLED(9)
        Button10.BackColor = clearLED(0)
        Button11.BackColor = clearLED(1)
        Button12.BackColor = clearLED(2)
        Button13.BackColor = clearLED(3)
        Button14.BackColor = clearLED(4)
        Button15.BackColor = clearLED(5)
        Button16.BackColor = clearLED(6)
        Button17.BackColor = clearLED(7)
        Button18.BackColor = clearLED(8)
        Button19.BackColor = clearLED(9)
        Button20.BackColor = clearLED(0)
        Button21.BackColor = clearLED(1)
        Button22.BackColor = clearLED(2)
        Button23.BackColor = clearLED(3)
        Button24.BackColor = clearLED(4)
        Button25.BackColor = clearLED(5)
        Button26.BackColor = clearLED(6)
        Button27.BackColor = clearLED(7)
        Button28.BackColor = clearLED(8)
        Button29.BackColor = clearLED(9)
        Button30.BackColor = clearLED(0)
        Button31.BackColor = clearLED(1)
        Button32.BackColor = clearLED(2)
        Button33.BackColor = clearLED(3)
        Button34.BackColor = clearLED(4)
        Button35.BackColor = clearLED(5)
        Button36.BackColor = clearLED(6)
        Button37.BackColor = clearLED(7)
        Button38.BackColor = clearLED(8)
        Button39.BackColor = clearLED(9)
        Button40.BackColor = clearLED(0)
        Button41.BackColor = clearLED(1)
        Button42.BackColor = clearLED(2)
        Button43.BackColor = clearLED(3)
        Button44.BackColor = clearLED(4)
        Button45.BackColor = clearLED(5)
        Button46.BackColor = clearLED(6)
        Button47.BackColor = clearLED(7)
        Button48.BackColor = clearLED(8)
        Button49.BackColor = clearLED(9)
        Button50.BackColor = clearLED(0)
        Button51.BackColor = clearLED(1)
        Button52.BackColor = clearLED(2)
        Button53.BackColor = clearLED(3)
        Button54.BackColor = clearLED(4)
        Button55.BackColor = clearLED(5)
        Button56.BackColor = clearLED(6)
        Button57.BackColor = clearLED(7)
        Button58.BackColor = clearLED(8)
        Button59.BackColor = clearLED(9)
        Button60.BackColor = clearLED(0)
        Button61.BackColor = clearLED(1)
        Button62.BackColor = clearLED(2)
        Button63.BackColor = clearLED(3)
        Button64.BackColor = clearLED(4)
        Button65.BackColor = clearLED(5)
        Button66.BackColor = clearLED(6)
        Button67.BackColor = clearLED(7)
        Button68.BackColor = clearLED(8)
        Button69.BackColor = clearLED(9)
        Button70.BackColor = clearLED(0)
        Button71.BackColor = clearLED(1)
        Button72.BackColor = clearLED(2)
        Button73.BackColor = clearLED(3)
        Button74.BackColor = clearLED(4)
        Button75.BackColor = clearLED(5)
        Button76.BackColor = clearLED(6)
        Button77.BackColor = clearLED(7)
        Button78.BackColor = clearLED(8)
        Button79.BackColor = clearLED(9)
        Button80.BackColor = clearLED(0)
        Button81.BackColor = clearLED(1)
        Button82.BackColor = clearLED(2)
        Button83.BackColor = clearLED(3)
        Button84.BackColor = clearLED(4)
        Button85.BackColor = clearLED(5)
        Button86.BackColor = clearLED(6)
        Button87.BackColor = clearLED(7)
        Button88.BackColor = clearLED(8)
        Button89.BackColor = clearLED(9)
        Button90.BackColor = clearLED(0)
        Button91.BackColor = clearLED(1)
        Button92.BackColor = clearLED(2)
        Button93.BackColor = clearLED(3)
        Button94.BackColor = clearLED(4)
        Button95.BackColor = clearLED(5)
        Button96.BackColor = clearLED(6)
        Button97.BackColor = clearLED(7)
        Button98.BackColor = clearLED(8)
        Button99.BackColor = clearLED(9)
        Button100.BackColor = clearLED(0)
        Button101.BackColor = clearLED(1)
        Button102.BackColor = clearLED(2)
        Button103.BackColor = clearLED(3)
        Button104.BackColor = clearLED(4)
        Button105.BackColor = clearLED(5)
        Button106.BackColor = clearLED(6)
        Button107.BackColor = clearLED(7)
        Button108.BackColor = clearLED(8)
        Button109.BackColor = clearLED(9)
        Button110.BackColor = clearLED(0)
        Button111.BackColor = clearLED(1)
        Button112.BackColor = clearLED(2)
        Button113.BackColor = clearLED(3)
        Button114.BackColor = clearLED(4)
        Button115.BackColor = clearLED(5)
        Button116.BackColor = clearLED(6)
        Button117.BackColor = clearLED(7)
        Button118.BackColor = clearLED(8)
        Button119.BackColor = clearLED(9)
        Button120.BackColor = clearLED(0)
        Button121.BackColor = clearLED(1)
        Button122.BackColor = clearLED(2)
        Button123.BackColor = clearLED(3)
        Button124.BackColor = clearLED(4)
        Button125.BackColor = clearLED(5)
        Button126.BackColor = clearLED(6)
        Button127.BackColor = clearLED(7)
        Button128.BackColor = clearLED(8)
        Button129.BackColor = clearLED(9)
        Button130.BackColor = clearLED(0)
        Button131.BackColor = clearLED(1)
        Button132.BackColor = clearLED(2)
        Button133.BackColor = clearLED(3)
        Button134.BackColor = clearLED(4)
        Button135.BackColor = clearLED(5)
        Button136.BackColor = clearLED(6)
        Button137.BackColor = clearLED(7)
        Button138.BackColor = clearLED(8)
        Button139.BackColor = clearLED(9)
        Button140.BackColor = clearLED(0)
        Button141.BackColor = clearLED(1)
        Button142.BackColor = clearLED(2)
        Button143.BackColor = clearLED(3)
        Button144.BackColor = clearLED(4)
        Button145.BackColor = clearLED(5)
        Button146.BackColor = clearLED(6)
        Button147.BackColor = clearLED(7)
        Button148.BackColor = clearLED(8)
        Button149.BackColor = clearLED(9)
        Button150.BackColor = clearLED(0)
        Button151.BackColor = clearLED(1)
        Button152.BackColor = clearLED(2)
        Button153.BackColor = clearLED(3)
        Button154.BackColor = clearLED(4)
        Button155.BackColor = clearLED(5)
        Button156.BackColor = clearLED(6)
        Button157.BackColor = clearLED(7)
        Button158.BackColor = clearLED(8)
        Button159.BackColor = clearLED(9)
        Button160.BackColor = clearLED(0)
        Button161.BackColor = clearLED(1)
        Button162.BackColor = clearLED(2)
        Button163.BackColor = clearLED(3)
        Button164.BackColor = clearLED(4)
        Button165.BackColor = clearLED(5)
        Button166.BackColor = clearLED(6)
        Button167.BackColor = clearLED(7)
        Button168.BackColor = clearLED(8)
        Button169.BackColor = clearLED(9)
        Button170.BackColor = clearLED(0)
        Button171.BackColor = clearLED(1)
        Button172.BackColor = clearLED(2)
        Button173.BackColor = clearLED(3)
        Button174.BackColor = clearLED(4)
        Button175.BackColor = clearLED(5)
        Button176.BackColor = clearLED(6)
        Button177.BackColor = clearLED(7)
        Button178.BackColor = clearLED(8)
        Button179.BackColor = clearLED(9)
        Button180.BackColor = clearLED(0)
        Button181.BackColor = clearLED(1)
        Button182.BackColor = clearLED(2)
        Button183.BackColor = clearLED(3)
        Button184.BackColor = clearLED(4)
        Button185.BackColor = clearLED(5)
        Button186.BackColor = clearLED(6)
        Button187.BackColor = clearLED(7)
        Button188.BackColor = clearLED(8)
        Button189.BackColor = clearLED(9)
        Button190.BackColor = clearLED(0)
        Button191.BackColor = clearLED(1)
        Button192.BackColor = clearLED(2)
        Button193.BackColor = clearLED(3)
        Button194.BackColor = clearLED(4)
        Button195.BackColor = clearLED(5)
        Button196.BackColor = clearLED(6)
        Button197.BackColor = clearLED(7)
        Button198.BackColor = clearLED(8)
        Button199.BackColor = clearLED(9)
        Button200.BackColor = clearLED(0)
       

    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        clear()
        Dim y As Long
        For y = 0 To duration
            framesR(y) = 0
            framesG(y) = 0
            framesB(y) = 0
        Next
        filepath = Nothing
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        clear()
        filepath = Nothing
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim res As MsgBoxResult
        res = MsgBox("Are You Sure Want to Continue", MsgBoxStyle.YesNo, "Confirm close")
        If (res = MsgBoxResult.Yes) Then
            End
        End If
    End Sub
    Sub readopen(fr As StreamReader)
        frameCount.Value = fr.ReadLine
        Dim g As Integer
        g = fr.ReadLine
        If (g = 1) Then
            CheckBoxIsArray.CheckState = CheckState.Checked
        Else
            CheckBoxIsArray.CheckState = CheckState.Unchecked
        End If
        Dim y As Long
        For y = 0 To duration
            framesR(y) = fr.ReadLine
            framesG(y) = fr.ReadLine
            framesB(y) = fr.ReadLine
        Next
    End Sub
    Sub write(fw As StreamWriter)
        fw.WriteLine(frameCount.Value)
        If (CheckBoxIsArray.CheckState = CheckState.Checked) Then
            fw.WriteLine(1)
        Else
            fw.WriteLine(0)
        End If
        Dim y As Long
        For y = 0 To duration
            fw.WriteLine(framesR(y) & vbTab)
            fw.WriteLine(framesG(y) & vbTab)
            fw.WriteLine(framesB(y))
        Next
    End Sub
    Sub writePattern(fw As StreamWriter)

        If (CheckBoxIsArray.CheckState = CheckState.Checked) Then
            fw.WriteLine(String.Format("{1}{0}{2}{0}{3}{0}{4}", ControlChars.NullChar, "m", 8, 8, 1)) 'array
        Else
            fw.WriteLine(String.Format("{1}{0}{2}{0}{3}{0}{4}", ControlChars.NullChar, "m", 8, 8, 0)) 'frame
        End If
        fw.WriteLine(String.Format("{1}{0}{2}{0}{3}", ControlChars.NullChar, "p", 1, frameCount.Value))
        Dim y As Long
        For y = 0 To duration
            fw.WriteLine(String.Format("{1}{0}{2}{0}{3}{0}{4}", ControlChars.NullChar, "p", framesR(y), framesG(y), framesB(y))) 'pattern
            'fw.Write(framesR(y) & vbTab)
            'fw.Write(framesG(y) & vbTab)
            'fw.WriteLine(framesB(y))
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim fr As StreamReader
        Dim result As DialogResult


        result = OpenFileDialog1.ShowDialog
        If (result = Windows.Forms.DialogResult.OK) Then
            fr = New StreamReader(OpenFileDialog1.FileName)
            readopen(fr)
            fr.Close()
        End If

        Dim k As Integer
        For k = 0 To 199
            read(k * 200)
            setbtncolor(k)
            setbtncolor2(k)
            setbtncolor3(k)
            setbtncolor4(k)
        Next

        frameAnimator.Maximum = frameCount.Value - 1
        frameAnimator.Value = 0
        Label42.Text = frameAnimator.Value + 1


        Button1.BackColor = Color.FromArgb(255, framesR(0), framesG(0), framesB(0))
        Button2.BackColor = Color.FromArgb(255, framesR(1), framesG(1), framesB(1))
        Button3.BackColor = Color.FromArgb(255, framesR(2), framesG(2), framesB(2))
        Button4.BackColor = Color.FromArgb(255, framesR(3), framesG(3), framesB(3))
        Button5.BackColor = Color.FromArgb(255, framesR(4), framesG(4), framesB(4))
        Button6.BackColor = Color.FromArgb(255, framesR(5), framesG(5), framesB(5))
        Button7.BackColor = Color.FromArgb(255, framesR(6), framesG(6), framesB(6))
        Button8.BackColor = Color.FromArgb(255, framesR(7), framesG(7), framesB(7))
        Button9.BackColor = Color.FromArgb(255, framesR(8), framesG(8), framesB(8))
        Button10.BackColor = Color.FromArgb(255, framesR(9), framesG(9), framesB(9))
        Button11.BackColor = Color.FromArgb(255, framesR(10), framesG(10), framesB(10))
        Button12.BackColor = Color.FromArgb(255, framesR(11), framesG(11), framesB(11))
        Button13.BackColor = Color.FromArgb(255, framesR(12), framesG(12), framesB(12))
        Button14.BackColor = Color.FromArgb(255, framesR(13), framesG(13), framesB(13))
        Button15.BackColor = Color.FromArgb(255, framesR(14), framesG(14), framesB(14))
        Button16.BackColor = Color.FromArgb(255, framesR(15), framesG(15), framesB(15))
        Button17.BackColor = Color.FromArgb(255, framesR(16), framesG(16), framesB(16))
        Button18.BackColor = Color.FromArgb(255, framesR(17), framesG(17), framesB(17))
        Button19.BackColor = Color.FromArgb(255, framesR(18), framesG(18), framesB(18))
        Button20.BackColor = Color.FromArgb(255, framesR(19), framesG(19), framesB(19))
        Button21.BackColor = Color.FromArgb(255, framesR(20), framesG(20), framesB(20))
        Button22.BackColor = Color.FromArgb(255, framesR(21), framesG(21), framesB(21))
        Button23.BackColor = Color.FromArgb(255, framesR(22), framesG(22), framesB(22))
        Button24.BackColor = Color.FromArgb(255, framesR(23), framesG(23), framesB(23))
        Button25.BackColor = Color.FromArgb(255, framesR(24), framesG(24), framesB(24))
        Button26.BackColor = Color.FromArgb(255, framesR(25), framesG(25), framesB(25))
        Button27.BackColor = Color.FromArgb(255, framesR(26), framesG(26), framesB(26))
        Button28.BackColor = Color.FromArgb(255, framesR(27), framesG(27), framesB(27))
        Button29.BackColor = Color.FromArgb(255, framesR(28), framesG(28), framesB(28))
        Button30.BackColor = Color.FromArgb(255, framesR(29), framesG(29), framesB(29))
        Button31.BackColor = Color.FromArgb(255, framesR(30), framesG(30), framesB(30))
        Button32.BackColor = Color.FromArgb(255, framesR(31), framesG(31), framesB(31))
        Button33.BackColor = Color.FromArgb(255, framesR(32), framesG(32), framesB(32))
        Button34.BackColor = Color.FromArgb(255, framesR(33), framesG(33), framesB(33))
        Button35.BackColor = Color.FromArgb(255, framesR(34), framesG(34), framesB(34))
        Button36.BackColor = Color.FromArgb(255, framesR(35), framesG(35), framesB(35))
        Button37.BackColor = Color.FromArgb(255, framesR(36), framesG(36), framesB(36))
        Button38.BackColor = Color.FromArgb(255, framesR(37), framesG(37), framesB(37))
        Button39.BackColor = Color.FromArgb(255, framesR(38), framesG(38), framesB(38))
        Button40.BackColor = Color.FromArgb(255, framesR(39), framesG(39), framesB(39))
        Button41.BackColor = Color.FromArgb(255, framesR(40), framesG(40), framesB(40))
        Button42.BackColor = Color.FromArgb(255, framesR(41), framesG(41), framesB(41))
        Button43.BackColor = Color.FromArgb(255, framesR(42), framesG(42), framesB(42))
        Button44.BackColor = Color.FromArgb(255, framesR(43), framesG(43), framesB(43))
        Button45.BackColor = Color.FromArgb(255, framesR(44), framesG(44), framesB(44))
        Button46.BackColor = Color.FromArgb(255, framesR(45), framesG(45), framesB(45))
        Button47.BackColor = Color.FromArgb(255, framesR(46), framesG(46), framesB(46))
        Button48.BackColor = Color.FromArgb(255, framesR(47), framesG(47), framesB(47))
        Button49.BackColor = Color.FromArgb(255, framesR(48), framesG(48), framesB(48))
        Button50.BackColor = Color.FromArgb(255, framesR(49), framesG(49), framesB(49))
        Button51.BackColor = Color.FromArgb(255, framesR(50), framesG(50), framesB(50))
        Button52.BackColor = Color.FromArgb(255, framesR(51), framesG(51), framesB(51))
        Button53.BackColor = Color.FromArgb(255, framesR(52), framesG(52), framesB(52))
        Button54.BackColor = Color.FromArgb(255, framesR(53), framesG(53), framesB(53))
        Button55.BackColor = Color.FromArgb(255, framesR(54), framesG(54), framesB(54))
        Button56.BackColor = Color.FromArgb(255, framesR(55), framesG(55), framesB(55))
        Button57.BackColor = Color.FromArgb(255, framesR(56), framesG(56), framesB(56))
        Button58.BackColor = Color.FromArgb(255, framesR(57), framesG(57), framesB(57))
        Button59.BackColor = Color.FromArgb(255, framesR(58), framesG(58), framesB(58))
        Button60.BackColor = Color.FromArgb(255, framesR(59), framesG(59), framesB(59))
        Button61.BackColor = Color.FromArgb(255, framesR(60), framesG(60), framesB(60))
        Button62.BackColor = Color.FromArgb(255, framesR(61), framesG(61), framesB(61))
        Button63.BackColor = Color.FromArgb(255, framesR(62), framesG(62), framesB(62))
        Button64.BackColor = Color.FromArgb(255, framesR(63), framesG(63), framesB(63))
        Button65.BackColor = Color.FromArgb(255, framesR(64), framesG(64), framesB(64))
        Button66.BackColor = Color.FromArgb(255, framesR(65), framesG(65), framesB(65))
        Button67.BackColor = Color.FromArgb(255, framesR(66), framesG(66), framesB(66))
        Button68.BackColor = Color.FromArgb(255, framesR(67), framesG(67), framesB(67))
        Button69.BackColor = Color.FromArgb(255, framesR(68), framesG(68), framesB(68))
        Button70.BackColor = Color.FromArgb(255, framesR(69), framesG(69), framesB(69))
        Button71.BackColor = Color.FromArgb(255, framesR(70), framesG(70), framesB(70))
        Button72.BackColor = Color.FromArgb(255, framesR(71), framesG(71), framesB(71))
        Button73.BackColor = Color.FromArgb(255, framesR(72), framesG(72), framesB(72))
        Button74.BackColor = Color.FromArgb(255, framesR(73), framesG(73), framesB(73))
        Button75.BackColor = Color.FromArgb(255, framesR(74), framesG(74), framesB(74))
        Button76.BackColor = Color.FromArgb(255, framesR(75), framesG(75), framesB(75))
        Button77.BackColor = Color.FromArgb(255, framesR(76), framesG(76), framesB(76))
        Button78.BackColor = Color.FromArgb(255, framesR(77), framesG(77), framesB(77))
        Button79.BackColor = Color.FromArgb(255, framesR(78), framesG(78), framesB(78))
        Button80.BackColor = Color.FromArgb(255, framesR(79), framesG(79), framesB(79))
        Button81.BackColor = Color.FromArgb(255, framesR(80), framesG(80), framesB(80))
        Button82.BackColor = Color.FromArgb(255, framesR(81), framesG(81), framesB(81))
        Button83.BackColor = Color.FromArgb(255, framesR(82), framesG(82), framesB(82))
        Button84.BackColor = Color.FromArgb(255, framesR(83), framesG(83), framesB(83))
        Button85.BackColor = Color.FromArgb(255, framesR(84), framesG(84), framesB(84))
        Button86.BackColor = Color.FromArgb(255, framesR(85), framesG(85), framesB(85))
        Button87.BackColor = Color.FromArgb(255, framesR(86), framesG(86), framesB(86))
        Button88.BackColor = Color.FromArgb(255, framesR(87), framesG(87), framesB(87))
        Button89.BackColor = Color.FromArgb(255, framesR(88), framesG(88), framesB(88))
        Button90.BackColor = Color.FromArgb(255, framesR(89), framesG(89), framesB(89))
        Button91.BackColor = Color.FromArgb(255, framesR(90), framesG(90), framesB(90))
        Button92.BackColor = Color.FromArgb(255, framesR(91), framesG(91), framesB(91))
        Button93.BackColor = Color.FromArgb(255, framesR(92), framesG(92), framesB(92))
        Button94.BackColor = Color.FromArgb(255, framesR(93), framesG(93), framesB(93))
        Button95.BackColor = Color.FromArgb(255, framesR(94), framesG(94), framesB(94))
        Button96.BackColor = Color.FromArgb(255, framesR(95), framesG(95), framesB(95))
        Button97.BackColor = Color.FromArgb(255, framesR(96), framesG(96), framesB(96))
        Button98.BackColor = Color.FromArgb(255, framesR(97), framesG(97), framesB(97))
        Button99.BackColor = Color.FromArgb(255, framesR(98), framesG(98), framesB(98))
        Button100.BackColor = Color.FromArgb(255, framesR(99), framesG(99), framesB(99))
        Button101.BackColor = Color.FromArgb(255, framesR(100), framesG(100), framesB(100))
        Button102.BackColor = Color.FromArgb(255, framesR(101), framesG(101), framesB(101))
        Button103.BackColor = Color.FromArgb(255, framesR(102), framesG(102), framesB(102))
        Button104.BackColor = Color.FromArgb(255, framesR(103), framesG(103), framesB(103))
        Button105.BackColor = Color.FromArgb(255, framesR(104), framesG(104), framesB(104))
        Button106.BackColor = Color.FromArgb(255, framesR(105), framesG(105), framesB(105))
        Button107.BackColor = Color.FromArgb(255, framesR(106), framesG(106), framesB(106))
        Button108.BackColor = Color.FromArgb(255, framesR(107), framesG(107), framesB(107))
        Button109.BackColor = Color.FromArgb(255, framesR(108), framesG(108), framesB(108))
        Button110.BackColor = Color.FromArgb(255, framesR(109), framesG(109), framesB(109))
        Button111.BackColor = Color.FromArgb(255, framesR(110), framesG(110), framesB(110))
        Button112.BackColor = Color.FromArgb(255, framesR(111), framesG(111), framesB(111))
        Button113.BackColor = Color.FromArgb(255, framesR(112), framesG(112), framesB(112))
        Button114.BackColor = Color.FromArgb(255, framesR(113), framesG(113), framesB(113))
        Button115.BackColor = Color.FromArgb(255, framesR(114), framesG(114), framesB(114))
        Button116.BackColor = Color.FromArgb(255, framesR(115), framesG(115), framesB(115))
        Button117.BackColor = Color.FromArgb(255, framesR(116), framesG(116), framesB(116))
        Button118.BackColor = Color.FromArgb(255, framesR(117), framesG(117), framesB(117))
        Button119.BackColor = Color.FromArgb(255, framesR(118), framesG(118), framesB(118))
        Button120.BackColor = Color.FromArgb(255, framesR(119), framesG(119), framesB(119))
        Button121.BackColor = Color.FromArgb(255, framesR(120), framesG(120), framesB(120))
        Button122.BackColor = Color.FromArgb(255, framesR(121), framesG(121), framesB(121))
        Button123.BackColor = Color.FromArgb(255, framesR(122), framesG(122), framesB(122))
        Button124.BackColor = Color.FromArgb(255, framesR(123), framesG(123), framesB(123))
        Button125.BackColor = Color.FromArgb(255, framesR(124), framesG(124), framesB(124))
        Button126.BackColor = Color.FromArgb(255, framesR(125), framesG(125), framesB(125))
        Button127.BackColor = Color.FromArgb(255, framesR(126), framesG(126), framesB(126))
        Button128.BackColor = Color.FromArgb(255, framesR(127), framesG(127), framesB(127))
        Button129.BackColor = Color.FromArgb(255, framesR(128), framesG(128), framesB(128))
        Button130.BackColor = Color.FromArgb(255, framesR(129), framesG(129), framesB(129))
        Button131.BackColor = Color.FromArgb(255, framesR(130), framesG(130), framesB(130))
        Button132.BackColor = Color.FromArgb(255, framesR(131), framesG(131), framesB(131))
        Button133.BackColor = Color.FromArgb(255, framesR(132), framesG(132), framesB(132))
        Button134.BackColor = Color.FromArgb(255, framesR(133), framesG(133), framesB(133))
        Button135.BackColor = Color.FromArgb(255, framesR(134), framesG(134), framesB(134))
        Button136.BackColor = Color.FromArgb(255, framesR(135), framesG(135), framesB(135))
        Button137.BackColor = Color.FromArgb(255, framesR(136), framesG(136), framesB(136))
        Button138.BackColor = Color.FromArgb(255, framesR(137), framesG(137), framesB(137))
        Button139.BackColor = Color.FromArgb(255, framesR(138), framesG(138), framesB(138))
        Button140.BackColor = Color.FromArgb(255, framesR(139), framesG(139), framesB(139))
        Button141.BackColor = Color.FromArgb(255, framesR(140), framesG(140), framesB(140))
        Button142.BackColor = Color.FromArgb(255, framesR(141), framesG(141), framesB(141))
        Button143.BackColor = Color.FromArgb(255, framesR(142), framesG(142), framesB(142))
        Button144.BackColor = Color.FromArgb(255, framesR(143), framesG(143), framesB(143))
        Button145.BackColor = Color.FromArgb(255, framesR(144), framesG(144), framesB(144))
        Button146.BackColor = Color.FromArgb(255, framesR(145), framesG(145), framesB(145))
        Button147.BackColor = Color.FromArgb(255, framesR(146), framesG(146), framesB(146))
        Button148.BackColor = Color.FromArgb(255, framesR(147), framesG(147), framesB(147))
        Button149.BackColor = Color.FromArgb(255, framesR(148), framesG(148), framesB(148))
        Button150.BackColor = Color.FromArgb(255, framesR(149), framesG(149), framesB(149))
        Button151.BackColor = Color.FromArgb(255, framesR(150), framesG(150), framesB(150))
        Button152.BackColor = Color.FromArgb(255, framesR(151), framesG(151), framesB(151))
        Button153.BackColor = Color.FromArgb(255, framesR(152), framesG(152), framesB(152))
        Button154.BackColor = Color.FromArgb(255, framesR(153), framesG(153), framesB(153))
        Button155.BackColor = Color.FromArgb(255, framesR(154), framesG(154), framesB(154))
        Button156.BackColor = Color.FromArgb(255, framesR(155), framesG(155), framesB(155))
        Button157.BackColor = Color.FromArgb(255, framesR(156), framesG(156), framesB(156))
        Button158.BackColor = Color.FromArgb(255, framesR(157), framesG(157), framesB(157))
        Button159.BackColor = Color.FromArgb(255, framesR(158), framesG(158), framesB(158))
        Button160.BackColor = Color.FromArgb(255, framesR(159), framesG(159), framesB(159))
        Button161.BackColor = Color.FromArgb(255, framesR(160), framesG(160), framesB(160))
        Button162.BackColor = Color.FromArgb(255, framesR(161), framesG(161), framesB(161))
        Button163.BackColor = Color.FromArgb(255, framesR(162), framesG(162), framesB(162))
        Button164.BackColor = Color.FromArgb(255, framesR(163), framesG(163), framesB(163))
        Button165.BackColor = Color.FromArgb(255, framesR(164), framesG(164), framesB(164))
        Button166.BackColor = Color.FromArgb(255, framesR(165), framesG(165), framesB(165))
        Button167.BackColor = Color.FromArgb(255, framesR(166), framesG(166), framesB(166))
        Button168.BackColor = Color.FromArgb(255, framesR(167), framesG(167), framesB(167))
        Button169.BackColor = Color.FromArgb(255, framesR(168), framesG(168), framesB(168))
        Button170.BackColor = Color.FromArgb(255, framesR(169), framesG(169), framesB(169))
        Button171.BackColor = Color.FromArgb(255, framesR(170), framesG(170), framesB(170))
        Button172.BackColor = Color.FromArgb(255, framesR(171), framesG(171), framesB(171))
        Button173.BackColor = Color.FromArgb(255, framesR(172), framesG(172), framesB(172))
        Button174.BackColor = Color.FromArgb(255, framesR(173), framesG(173), framesB(173))
        Button175.BackColor = Color.FromArgb(255, framesR(174), framesG(174), framesB(174))
        Button176.BackColor = Color.FromArgb(255, framesR(175), framesG(175), framesB(175))
        Button177.BackColor = Color.FromArgb(255, framesR(176), framesG(176), framesB(176))
        Button178.BackColor = Color.FromArgb(255, framesR(177), framesG(177), framesB(177))
        Button179.BackColor = Color.FromArgb(255, framesR(178), framesG(178), framesB(178))
        Button180.BackColor = Color.FromArgb(255, framesR(179), framesG(179), framesB(179))
        Button181.BackColor = Color.FromArgb(255, framesR(180), framesG(180), framesB(180))
        Button182.BackColor = Color.FromArgb(255, framesR(181), framesG(181), framesB(181))
        Button183.BackColor = Color.FromArgb(255, framesR(182), framesG(182), framesB(182))
        Button184.BackColor = Color.FromArgb(255, framesR(183), framesG(183), framesB(183))
        Button185.BackColor = Color.FromArgb(255, framesR(184), framesG(184), framesB(184))
        Button186.BackColor = Color.FromArgb(255, framesR(185), framesG(185), framesB(185))
        Button187.BackColor = Color.FromArgb(255, framesR(186), framesG(186), framesB(186))
        Button188.BackColor = Color.FromArgb(255, framesR(187), framesG(187), framesB(187))
        Button189.BackColor = Color.FromArgb(255, framesR(188), framesG(188), framesB(188))
        Button190.BackColor = Color.FromArgb(255, framesR(189), framesG(189), framesB(189))
        Button191.BackColor = Color.FromArgb(255, framesR(190), framesG(190), framesB(190))
        Button192.BackColor = Color.FromArgb(255, framesR(191), framesG(191), framesB(191))
        Button193.BackColor = Color.FromArgb(255, framesR(192), framesG(192), framesB(192))
        Button194.BackColor = Color.FromArgb(255, framesR(193), framesG(193), framesB(193))
        Button195.BackColor = Color.FromArgb(255, framesR(194), framesG(194), framesB(194))
        Button196.BackColor = Color.FromArgb(255, framesR(195), framesG(195), framesB(195))
        Button197.BackColor = Color.FromArgb(255, framesR(196), framesG(196), framesB(196))
        Button198.BackColor = Color.FromArgb(255, framesR(197), framesG(197), framesB(197))
        Button199.BackColor = Color.FromArgb(255, framesR(198), framesG(198), framesB(198))
        Button200.BackColor = Color.FromArgb(255, framesR(199), framesG(199), framesB(199))


        read(0)

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If (Not Directory.Exists("C:\LED Editor\8x25")) Then
            Directory.CreateDirectory("C:\LED Editor\8x25")
        End If
        If (filepath = Nothing) Then
            Dim fw As StreamWriter
            Dim result As DialogResult
            result = SaveFileDialog1.ShowDialog
            If (result = Windows.Forms.DialogResult.OK) Then
                fw = New StreamWriter(SaveFileDialog1.FileName, False)
                write(fw)
                filepath = SaveFileDialog1.FileName
                fw.Close()
            End If
        Else
            Dim fw As StreamWriter
            fw = New StreamWriter(filepath, False)
            write(fw)
            fw.Close()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim filepath = "C:\LED Editor\8x25"
        saveFile(filepath)
    End Sub

    Sub saveFile(filePath As String)
        If (Not Directory.Exists(filePath)) Then
            Directory.CreateDirectory(filePath)
        End If

        Dim fw As StreamWriter
        Dim result As DialogResult
        result = SaveFileDialog1.ShowDialog
        If (result = Windows.Forms.DialogResult.OK) Then
            fw = New StreamWriter(SaveFileDialog1.FileName, False)
            write(fw)
            filePath = SaveFileDialog1.FileName
            fw.Close()
        End If

    End Sub
    Private Sub fileParse(filePath As String)
        Dim stdFormat As Integer() = {5, 10, 11, -1}
        Dim errorFormat As Integer() = {5, 5, -1}
        Using MyReader As New FileIO.TextFieldParser(filePath)
            MyReader.TextFieldType = FileIO.FieldType.FixedWidth
            MyReader.FieldWidths = stdFormat
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    Dim rowType = MyReader.PeekChars(3)
                    If String.Compare(rowType, "Err") = 0 Then
                        ' If this line describes an error, the format of the row will be different.
                        MyReader.SetFieldWidths(errorFormat)
                    Else
                        ' Otherwise parse the fields normally
                        MyReader.SetFieldWidths(stdFormat)
                    End If
                    currentRow = MyReader.ReadFields
                    For Each newString In currentRow
                        Console.Write(newString & "|")
                    Next
                    Console.WriteLine()
                Catch ex As FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & " is invalid.  Skipping")
                End Try
            End While
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (selec = 0) Then
            patternLEDList(1, 0) = R
            patternLEDList(1, 1) = G
            patternLEDList(1, 2) = B
            Button1.BackColor = sc.BackColor
        Else
            R = patternLEDList(1, 0)
            G = patternLEDList(1, 1)
            B = patternLEDList(1, 2)
            sc.BackColor = Button1.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (selec = 0) Then
            patternLEDList(2, 0) = R
            patternLEDList(2, 1) = G
            patternLEDList(2, 2) = B
            Button2.BackColor = sc.BackColor
        Else
            R = patternLEDList(2, 0)
            G = patternLEDList(2, 1)
            B = patternLEDList(2, 2)
            sc.BackColor = Button2.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (selec = 0) Then
            patternLEDList(3, 0) = R
            patternLEDList(3, 1) = G
            patternLEDList(3, 2) = B
            Button3.BackColor = sc.BackColor
        Else
            R = patternLEDList(3, 0)
            G = patternLEDList(3, 1)
            B = patternLEDList(3, 2)
            sc.BackColor = Button3.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (selec = 0) Then
            patternLEDList(4, 0) = R
            patternLEDList(4, 1) = G
            patternLEDList(4, 2) = B
            Button4.BackColor = sc.BackColor
        Else
            R = patternLEDList(4, 0)
            G = patternLEDList(4, 1)
            B = patternLEDList(4, 2)
            sc.BackColor = Button4.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (selec = 0) Then
            patternLEDList(5, 0) = R
            patternLEDList(5, 1) = G
            patternLEDList(5, 2) = B
            Button5.BackColor = sc.BackColor
        Else
            R = patternLEDList(5, 0)
            G = patternLEDList(5, 1)
            B = patternLEDList(5, 2)
            sc.BackColor = Button5.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (selec = 0) Then
            patternLEDList(6, 0) = R
            patternLEDList(6, 1) = G
            patternLEDList(6, 2) = B
            Button6.BackColor = sc.BackColor
        Else
            R = patternLEDList(6, 0)
            G = patternLEDList(6, 1)
            B = patternLEDList(6, 2)
            sc.BackColor = Button6.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (selec = 0) Then
            patternLEDList(7, 0) = R
            patternLEDList(7, 1) = G
            patternLEDList(7, 2) = B
            Button7.BackColor = sc.BackColor
        Else
            R = patternLEDList(7, 0)
            G = patternLEDList(7, 1)
            B = patternLEDList(7, 2)
            sc.BackColor = Button7.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (selec = 0) Then
            patternLEDList(8, 0) = R
            patternLEDList(8, 1) = G
            patternLEDList(8, 2) = B
            Button8.BackColor = sc.BackColor
        Else
            R = patternLEDList(8, 0)
            G = patternLEDList(8, 1)
            B = patternLEDList(8, 2)
            sc.BackColor = Button8.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (selec = 0) Then
            patternLEDList(9, 0) = R
            patternLEDList(9, 1) = G
            patternLEDList(9, 2) = B
            Button9.BackColor = sc.BackColor
        Else
            R = patternLEDList(9, 0)
            G = patternLEDList(9, 1)
            B = patternLEDList(9, 2)
            sc.BackColor = Button9.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (selec = 0) Then
            patternLEDList(10, 0) = R
            patternLEDList(10, 1) = G
            patternLEDList(10, 2) = B
            Button10.BackColor = sc.BackColor
        Else
            R = patternLEDList(10, 0)
            G = patternLEDList(10, 1)
            B = patternLEDList(10, 2)
            sc.BackColor = Button10.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (selec = 0) Then
            patternLEDList(11, 0) = R
            patternLEDList(11, 1) = G
            patternLEDList(11, 2) = B
            Button11.BackColor = sc.BackColor
        Else
            R = patternLEDList(11, 0)
            G = patternLEDList(11, 1)
            B = patternLEDList(11, 2)
            sc.BackColor = Button11.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If (selec = 0) Then
            patternLEDList(12, 0) = R
            patternLEDList(12, 1) = G
            patternLEDList(12, 2) = B
            Button12.BackColor = sc.BackColor
        Else
            R = patternLEDList(12, 0)
            G = patternLEDList(12, 1)
            B = patternLEDList(12, 2)
            sc.BackColor = Button12.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (selec = 0) Then
            patternLEDList(13, 0) = R
            patternLEDList(13, 1) = G
            patternLEDList(13, 2) = B
            Button13.BackColor = sc.BackColor
        Else
            R = patternLEDList(13, 0)
            G = patternLEDList(13, 1)
            B = patternLEDList(13, 2)
            sc.BackColor = Button13.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (selec = 0) Then
            patternLEDList(14, 0) = R
            patternLEDList(14, 1) = G
            patternLEDList(14, 2) = B
            Button14.BackColor = sc.BackColor
        Else
            R = patternLEDList(14, 0)
            G = patternLEDList(14, 1)
            B = patternLEDList(14, 2)
            sc.BackColor = Button14.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (selec = 0) Then
            patternLEDList(15, 0) = R
            patternLEDList(15, 1) = G
            patternLEDList(15, 2) = B
            Button15.BackColor = sc.BackColor
        Else
            R = patternLEDList(15, 0)
            G = patternLEDList(15, 1)
            B = patternLEDList(15, 2)
            sc.BackColor = Button15.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (selec = 0) Then
            patternLEDList(16, 0) = R
            patternLEDList(16, 1) = G
            patternLEDList(16, 2) = B
            Button16.BackColor = sc.BackColor
        Else
            R = patternLEDList(16, 0)
            G = patternLEDList(16, 1)
            B = patternLEDList(16, 2)
            sc.BackColor = Button16.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (selec = 0) Then
            patternLEDList(17, 0) = R
            patternLEDList(17, 1) = G
            patternLEDList(17, 2) = B
            Button17.BackColor = sc.BackColor
        Else
            R = patternLEDList(17, 0)
            G = patternLEDList(17, 1)
            B = patternLEDList(17, 2)
            sc.BackColor = Button17.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (selec = 0) Then
            patternLEDList(18, 0) = R
            patternLEDList(18, 1) = G
            patternLEDList(18, 2) = B
            Button18.BackColor = sc.BackColor
        Else
            R = patternLEDList(18, 0)
            G = patternLEDList(18, 1)
            B = patternLEDList(18, 2)
            sc.BackColor = Button18.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (selec = 0) Then
            patternLEDList(19, 0) = R
            patternLEDList(19, 1) = G
            patternLEDList(19, 2) = B
            Button19.BackColor = sc.BackColor
        Else
            R = patternLEDList(19, 0)
            G = patternLEDList(19, 1)
            B = patternLEDList(19, 2)
            sc.BackColor = Button19.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If (selec = 0) Then
            patternLEDList(20, 0) = R
            patternLEDList(20, 1) = G
            patternLEDList(20, 2) = B
            Button20.BackColor = sc.BackColor
        Else
            R = patternLEDList(20, 0)
            G = patternLEDList(20, 1)
            B = patternLEDList(20, 2)
            sc.BackColor = Button20.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If (selec = 0) Then
            patternLEDList(21, 0) = R
            patternLEDList(21, 1) = G
            patternLEDList(21, 2) = B
            Button21.BackColor = sc.BackColor
        Else
            R = patternLEDList(21, 0)
            G = patternLEDList(21, 1)
            B = patternLEDList(21, 2)
            sc.BackColor = Button21.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If (selec = 0) Then
            patternLEDList(22, 0) = R
            patternLEDList(22, 1) = G
            patternLEDList(22, 2) = B
            Button22.BackColor = sc.BackColor
        Else
            R = patternLEDList(22, 0)
            G = patternLEDList(22, 1)
            B = patternLEDList(22, 2)
            sc.BackColor = Button22.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If (selec = 0) Then
            patternLEDList(23, 0) = R
            patternLEDList(23, 1) = G
            patternLEDList(23, 2) = B
            Button23.BackColor = sc.BackColor
        Else
            R = patternLEDList(23, 0)
            G = patternLEDList(23, 1)
            B = patternLEDList(23, 2)
            sc.BackColor = Button23.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If (selec = 0) Then
            patternLEDList(24, 0) = R
            patternLEDList(24, 1) = G
            patternLEDList(24, 2) = B
            Button24.BackColor = sc.BackColor
        Else
            R = patternLEDList(24, 0)
            G = patternLEDList(24, 1)
            B = patternLEDList(24, 2)
            sc.BackColor = Button24.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If (selec = 0) Then
            patternLEDList(25, 0) = R
            patternLEDList(25, 1) = G
            patternLEDList(25, 2) = B
            Button25.BackColor = sc.BackColor
        Else
            R = patternLEDList(25, 0)
            G = patternLEDList(25, 1)
            B = patternLEDList(25, 2)
            sc.BackColor = Button25.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If (selec = 0) Then
            patternLEDList(26, 0) = R
            patternLEDList(26, 1) = G
            patternLEDList(26, 2) = B
            Button26.BackColor = sc.BackColor
        Else
            R = patternLEDList(26, 0)
            G = patternLEDList(26, 1)
            B = patternLEDList(26, 2)
            sc.BackColor = Button26.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If (selec = 0) Then
            patternLEDList(27, 0) = R
            patternLEDList(27, 1) = G
            patternLEDList(27, 2) = B
            Button27.BackColor = sc.BackColor
        Else
            R = patternLEDList(27, 0)
            G = patternLEDList(27, 1)
            B = patternLEDList(27, 2)
            sc.BackColor = Button27.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If (selec = 0) Then
            patternLEDList(28, 0) = R
            patternLEDList(28, 1) = G
            patternLEDList(28, 2) = B
            Button28.BackColor = sc.BackColor
        Else
            R = patternLEDList(28, 0)
            G = patternLEDList(28, 1)
            B = patternLEDList(28, 2)
            sc.BackColor = Button28.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If (selec = 0) Then
            patternLEDList(29, 0) = R
            patternLEDList(29, 1) = G
            patternLEDList(29, 2) = B
            Button29.BackColor = sc.BackColor
        Else
            R = patternLEDList(29, 0)
            G = patternLEDList(29, 1)
            B = patternLEDList(29, 2)
            sc.BackColor = Button29.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        If (selec = 0) Then
            patternLEDList(30, 0) = R
            patternLEDList(30, 1) = G
            patternLEDList(30, 2) = B
            Button30.BackColor = sc.BackColor
        Else
            R = patternLEDList(30, 0)
            G = patternLEDList(30, 1)
            B = patternLEDList(30, 2)
            sc.BackColor = Button30.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        If (selec = 0) Then
            patternLEDList(31, 0) = R
            patternLEDList(31, 1) = G
            patternLEDList(31, 2) = B
            Button31.BackColor = sc.BackColor
        Else
            R = patternLEDList(31, 0)
            G = patternLEDList(31, 1)
            B = patternLEDList(31, 2)
            sc.BackColor = Button31.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        If (selec = 0) Then
            patternLEDList(32, 0) = R
            patternLEDList(32, 1) = G
            patternLEDList(32, 2) = B
            Button32.BackColor = sc.BackColor
        Else
            R = patternLEDList(32, 0)
            G = patternLEDList(32, 1)
            B = patternLEDList(32, 2)
            sc.BackColor = Button32.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        If (selec = 0) Then
            patternLEDList(33, 0) = R
            patternLEDList(33, 1) = G
            patternLEDList(33, 2) = B
            Button33.BackColor = sc.BackColor
        Else
            R = patternLEDList(33, 0)
            G = patternLEDList(33, 1)
            B = patternLEDList(33, 2)
            sc.BackColor = Button33.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        If (selec = 0) Then
            patternLEDList(34, 0) = R
            patternLEDList(34, 1) = G
            patternLEDList(34, 2) = B
            Button34.BackColor = sc.BackColor
        Else
            R = patternLEDList(34, 0)
            G = patternLEDList(34, 1)
            B = patternLEDList(34, 2)
            sc.BackColor = Button34.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        If (selec = 0) Then
            patternLEDList(35, 0) = R
            patternLEDList(35, 1) = G
            patternLEDList(35, 2) = B
            Button35.BackColor = sc.BackColor
        Else
            R = patternLEDList(35, 0)
            G = patternLEDList(35, 1)
            B = patternLEDList(35, 2)
            sc.BackColor = Button35.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        If (selec = 0) Then
            patternLEDList(36, 0) = R
            patternLEDList(36, 1) = G
            patternLEDList(36, 2) = B
            Button36.BackColor = sc.BackColor
        Else
            R = patternLEDList(36, 0)
            G = patternLEDList(36, 1)
            B = patternLEDList(36, 2)
            sc.BackColor = Button36.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        If (selec = 0) Then
            patternLEDList(37, 0) = R
            patternLEDList(37, 1) = G
            patternLEDList(37, 2) = B
            Button37.BackColor = sc.BackColor
        Else
            R = patternLEDList(37, 0)
            G = patternLEDList(37, 1)
            B = patternLEDList(37, 2)
            sc.BackColor = Button37.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        If (selec = 0) Then
            patternLEDList(38, 0) = R
            patternLEDList(38, 1) = G
            patternLEDList(38, 2) = B
            Button38.BackColor = sc.BackColor
        Else
            R = patternLEDList(38, 0)
            G = patternLEDList(38, 1)
            B = patternLEDList(38, 2)
            sc.BackColor = Button38.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        If (selec = 0) Then
            patternLEDList(39, 0) = R
            patternLEDList(39, 1) = G
            patternLEDList(39, 2) = B
            Button39.BackColor = sc.BackColor
        Else
            R = patternLEDList(39, 0)
            G = patternLEDList(39, 1)
            B = patternLEDList(39, 2)
            sc.BackColor = Button39.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If (selec = 0) Then
            patternLEDList(40, 0) = R
            patternLEDList(40, 1) = G
            patternLEDList(40, 2) = B
            Button40.BackColor = sc.BackColor
        Else
            R = patternLEDList(40, 0)
            G = patternLEDList(40, 1)
            B = patternLEDList(40, 2)
            sc.BackColor = Button40.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If (selec = 0) Then
            patternLEDList(41, 0) = R
            patternLEDList(41, 1) = G
            patternLEDList(41, 2) = B
            Button41.BackColor = sc.BackColor
        Else
            R = patternLEDList(41, 0)
            G = patternLEDList(41, 1)
            B = patternLEDList(41, 2)
            sc.BackColor = Button41.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        If (selec = 0) Then
            patternLEDList(42, 0) = R
            patternLEDList(42, 1) = G
            patternLEDList(42, 2) = B
            Button42.BackColor = sc.BackColor
        Else
            R = patternLEDList(42, 0)
            G = patternLEDList(42, 1)
            B = patternLEDList(42, 2)
            sc.BackColor = Button42.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        If (selec = 0) Then
            patternLEDList(43, 0) = R
            patternLEDList(43, 1) = G
            patternLEDList(43, 2) = B
            Button43.BackColor = sc.BackColor
        Else
            R = patternLEDList(43, 0)
            G = patternLEDList(43, 1)
            B = patternLEDList(43, 2)
            sc.BackColor = Button43.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        If (selec = 0) Then
            patternLEDList(44, 0) = R
            patternLEDList(44, 1) = G
            patternLEDList(44, 2) = B
            Button44.BackColor = sc.BackColor
        Else
            R = patternLEDList(44, 0)
            G = patternLEDList(44, 1)
            B = patternLEDList(44, 2)
            sc.BackColor = Button44.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If (selec = 0) Then
            patternLEDList(45, 0) = R
            patternLEDList(45, 1) = G
            patternLEDList(45, 2) = B
            Button45.BackColor = sc.BackColor
        Else
            R = patternLEDList(45, 0)
            G = patternLEDList(45, 1)
            B = patternLEDList(45, 2)
            sc.BackColor = Button45.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        If (selec = 0) Then
            patternLEDList(46, 0) = R
            patternLEDList(46, 1) = G
            patternLEDList(46, 2) = B
            Button46.BackColor = sc.BackColor
        Else
            R = patternLEDList(46, 0)
            G = patternLEDList(46, 1)
            B = patternLEDList(46, 2)
            sc.BackColor = Button46.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        If (selec = 0) Then
            patternLEDList(47, 0) = R
            patternLEDList(47, 1) = G
            patternLEDList(47, 2) = B
            Button47.BackColor = sc.BackColor
        Else
            R = patternLEDList(47, 0)
            G = patternLEDList(47, 1)
            B = patternLEDList(47, 2)
            sc.BackColor = Button47.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        If (selec = 0) Then
            patternLEDList(48, 0) = R
            patternLEDList(48, 1) = G
            patternLEDList(48, 2) = B
            Button48.BackColor = sc.BackColor
        Else
            R = patternLEDList(48, 0)
            G = patternLEDList(48, 1)
            B = patternLEDList(48, 2)
            sc.BackColor = Button48.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        If (selec = 0) Then
            patternLEDList(49, 0) = R
            patternLEDList(49, 1) = G
            patternLEDList(49, 2) = B
            Button49.BackColor = sc.BackColor
        Else
            R = patternLEDList(49, 0)
            G = patternLEDList(49, 1)
            B = patternLEDList(49, 2)
            sc.BackColor = Button49.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        If (selec = 0) Then
            patternLEDList(50, 0) = R
            patternLEDList(50, 1) = G
            patternLEDList(50, 2) = B
            Button50.BackColor = sc.BackColor
        Else
            R = patternLEDList(50, 0)
            G = patternLEDList(50, 1)
            B = patternLEDList(50, 2)
            sc.BackColor = Button50.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        If (selec = 0) Then
            patternLEDList(51, 0) = R
            patternLEDList(51, 1) = G
            patternLEDList(51, 2) = B
            Button51.BackColor = sc.BackColor
        Else
            R = patternLEDList(51, 0)
            G = patternLEDList(51, 1)
            B = patternLEDList(51, 2)
            sc.BackColor = Button51.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        If (selec = 0) Then
            patternLEDList(52, 0) = R
            patternLEDList(52, 1) = G
            patternLEDList(52, 2) = B
            Button52.BackColor = sc.BackColor
        Else
            R = patternLEDList(52, 0)
            G = patternLEDList(52, 1)
            B = patternLEDList(52, 2)
            sc.BackColor = Button52.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        If (selec = 0) Then
            patternLEDList(53, 0) = R
            patternLEDList(53, 1) = G
            patternLEDList(53, 2) = B
            Button53.BackColor = sc.BackColor
        Else
            R = patternLEDList(53, 0)
            G = patternLEDList(53, 1)
            B = patternLEDList(53, 2)
            sc.BackColor = Button53.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        If (selec = 0) Then
            patternLEDList(54, 0) = R
            patternLEDList(54, 1) = G
            patternLEDList(54, 2) = B
            Button54.BackColor = sc.BackColor
        Else
            R = patternLEDList(54, 0)
            G = patternLEDList(54, 1)
            B = patternLEDList(554, 2)
            sc.BackColor = Button54.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        If (selec = 0) Then
            patternLEDList(55, 0) = R
            patternLEDList(55, 1) = G
            patternLEDList(55, 2) = B
            Button55.BackColor = sc.BackColor
        Else
            R = patternLEDList(55, 0)
            G = patternLEDList(55, 1)
            B = patternLEDList(55, 2)
            sc.BackColor = Button55.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        If (selec = 0) Then
            patternLEDList(56, 0) = R
            patternLEDList(56, 1) = G
            patternLEDList(56, 2) = B
            Button56.BackColor = sc.BackColor
        Else
            R = patternLEDList(56, 0)
            G = patternLEDList(56, 1)
            B = patternLEDList(56, 2)
            sc.BackColor = Button56.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        If (selec = 0) Then
            patternLEDList(57, 0) = R
            patternLEDList(57, 1) = G
            patternLEDList(57, 2) = B
            Button57.BackColor = sc.BackColor
        Else
            R = patternLEDList(57, 0)
            G = patternLEDList(57, 1)
            B = patternLEDList(57, 2)
            sc.BackColor = Button57.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button58_Click(sender As Object, e As EventArgs) Handles Button58.Click
        If (selec = 0) Then
            patternLEDList(58, 0) = R
            patternLEDList(58, 1) = G
            patternLEDList(58, 2) = B
            Button58.BackColor = sc.BackColor
        Else
            R = patternLEDList(58, 0)
            G = patternLEDList(58, 1)
            B = patternLEDList(58, 2)
            sc.BackColor = Button58.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button59_Click(sender As Object, e As EventArgs) Handles Button59.Click
        If (selec = 0) Then
            patternLEDList(59, 0) = R
            patternLEDList(59, 1) = G
            patternLEDList(59, 2) = B
            Button59.BackColor = sc.BackColor
        Else
            R = patternLEDList(59, 0)
            G = patternLEDList(59, 1)
            B = patternLEDList(59, 2)
            sc.BackColor = Button59.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button60_Click(sender As Object, e As EventArgs) Handles Button60.Click
        If (selec = 0) Then
            patternLEDList(60, 0) = R
            patternLEDList(60, 1) = G
            patternLEDList(60, 2) = B
            Button60.BackColor = sc.BackColor
        Else
            R = patternLEDList(60, 0)
            G = patternLEDList(60, 1)
            B = patternLEDList(60, 2)
            sc.BackColor = Button60.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button61_Click(sender As Object, e As EventArgs) Handles Button61.Click
        If (selec = 0) Then
            patternLEDList(61, 0) = R
            patternLEDList(61, 1) = G
            patternLEDList(61, 2) = B
            Button61.BackColor = sc.BackColor
        Else
            R = patternLEDList(61, 0)
            G = patternLEDList(61, 1)
            B = patternLEDList(61, 2)
            sc.BackColor = Button61.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button62_Click(sender As Object, e As EventArgs) Handles Button62.Click
        If (selec = 0) Then
            patternLEDList(62, 0) = R
            patternLEDList(62, 1) = G
            patternLEDList(62, 2) = B
            Button62.BackColor = sc.BackColor
        Else
            R = patternLEDList(62, 0)
            G = patternLEDList(62, 1)
            B = patternLEDList(62, 2)
            sc.BackColor = Button62.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button63_Click(sender As Object, e As EventArgs) Handles Button63.Click
        If (selec = 0) Then
            patternLEDList(63, 0) = R
            patternLEDList(63, 1) = G
            patternLEDList(63, 2) = B
            Button63.BackColor = sc.BackColor
        Else
            R = patternLEDList(63, 0)
            G = patternLEDList(63, 1)
            B = patternLEDList(63, 2)
            sc.BackColor = Button63.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button64_Click(sender As Object, e As EventArgs) Handles Button64.Click
        If (selec = 0) Then
            patternLEDList(64, 0) = R
            patternLEDList(64, 1) = G
            patternLEDList(64, 2) = B
            Button64.BackColor = sc.BackColor
        Else
            R = patternLEDList(64, 0)
            G = patternLEDList(64, 1)
            B = patternLEDList(64, 2)
            sc.BackColor = Button64.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button65_Click(sender As Object, e As EventArgs) Handles Button65.Click
        If (selec = 0) Then
            patternLEDList(65, 0) = R
            patternLEDList(65, 1) = G
            patternLEDList(65, 2) = B
            Button65.BackColor = sc.BackColor
        Else
            R = patternLEDList(65, 0)
            G = patternLEDList(65, 1)
            B = patternLEDList(65, 2)
            sc.BackColor = Button65.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button66_Click(sender As Object, e As EventArgs) Handles Button66.Click
        If (selec = 0) Then
            patternLEDList(66, 0) = R
            patternLEDList(66, 1) = G
            patternLEDList(66, 2) = B
            Button66.BackColor = sc.BackColor
        Else
            R = patternLEDList(66, 0)
            G = patternLEDList(66, 1)
            B = patternLEDList(66, 2)
            sc.BackColor = Button66.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button67_Click(sender As Object, e As EventArgs) Handles Button67.Click
        If (selec = 0) Then
            patternLEDList(67, 0) = R
            patternLEDList(67, 1) = G
            patternLEDList(67, 2) = B
            Button67.BackColor = sc.BackColor
        Else
            R = patternLEDList(67, 0)
            G = patternLEDList(67, 1)
            B = patternLEDList(67, 2)
            sc.BackColor = Button67.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button68_Click(sender As Object, e As EventArgs) Handles Button68.Click
        If (selec = 0) Then
            patternLEDList(68, 0) = R
            patternLEDList(68, 1) = G
            patternLEDList(68, 2) = B
            Button68.BackColor = sc.BackColor
        Else
            R = patternLEDList(68, 0)
            G = patternLEDList(68, 1)
            B = patternLEDList(68, 2)
            sc.BackColor = Button68.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button69_Click(sender As Object, e As EventArgs) Handles Button69.Click
        If (selec = 0) Then
            patternLEDList(69, 0) = R
            patternLEDList(69, 1) = G
            patternLEDList(69, 2) = B
            Button69.BackColor = sc.BackColor
        Else
            R = patternLEDList(69, 0)
            G = patternLEDList(69, 1)
            B = patternLEDList(69, 2)
            sc.BackColor = Button69.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button70_Click(sender As Object, e As EventArgs) Handles Button70.Click
        If (selec = 0) Then
            patternLEDList(70, 0) = R
            patternLEDList(70, 1) = G
            patternLEDList(70, 2) = B
            Button70.BackColor = sc.BackColor
        Else
            R = patternLEDList(70, 0)
            G = patternLEDList(70, 1)
            B = patternLEDList(70, 2)
            sc.BackColor = Button70.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button71_Click(sender As Object, e As EventArgs) Handles Button71.Click
        If (selec = 0) Then
            patternLEDList(71, 0) = R
            patternLEDList(71, 1) = G
            patternLEDList(71, 2) = B
            Button71.BackColor = sc.BackColor
        Else
            R = patternLEDList(71, 0)
            G = patternLEDList(71, 1)
            B = patternLEDList(71, 2)
            sc.BackColor = Button71.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button72_Click(sender As Object, e As EventArgs) Handles Button72.Click
        If (selec = 0) Then
            patternLEDList(72, 0) = R
            patternLEDList(72, 1) = G
            patternLEDList(72, 2) = B
            Button72.BackColor = sc.BackColor
        Else
            R = patternLEDList(72, 0)
            G = patternLEDList(72, 1)
            B = patternLEDList(72, 2)
            sc.BackColor = Button72.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button73_Click(sender As Object, e As EventArgs) Handles Button73.Click
        If (selec = 0) Then
            patternLEDList(73, 0) = R
            patternLEDList(73, 1) = G
            patternLEDList(73, 2) = B
            Button73.BackColor = sc.BackColor
        Else
            R = patternLEDList(73, 0)
            G = patternLEDList(73, 1)
            B = patternLEDList(73, 2)
            sc.BackColor = Button73.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button74_Click(sender As Object, e As EventArgs) Handles Button74.Click
        If (selec = 0) Then
            patternLEDList(74, 0) = R
            patternLEDList(74, 1) = G
            patternLEDList(74, 2) = B
            Button74.BackColor = sc.BackColor
        Else
            R = patternLEDList(74, 0)
            G = patternLEDList(74, 1)
            B = patternLEDList(74, 2)
            sc.BackColor = Button74.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles Button75.Click
        If (selec = 0) Then
            patternLEDList(75, 0) = R
            patternLEDList(75, 1) = G
            patternLEDList(75, 2) = B
            Button75.BackColor = sc.BackColor
        Else
            R = patternLEDList(75, 0)
            G = patternLEDList(75, 1)
            B = patternLEDList(75, 2)
            sc.BackColor = Button75.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button76_Click(sender As Object, e As EventArgs) Handles Button76.Click
        If (selec = 0) Then
            patternLEDList(76, 0) = R
            patternLEDList(76, 1) = G
            patternLEDList(76, 2) = B
            Button76.BackColor = sc.BackColor
        Else
            R = patternLEDList(76, 0)
            G = patternLEDList(76, 1)
            B = patternLEDList(76, 2)
            sc.BackColor = Button76.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button77_Click(sender As Object, e As EventArgs) Handles Button77.Click
        If (selec = 0) Then
            patternLEDList(77, 0) = R
            patternLEDList(77, 1) = G
            patternLEDList(77, 2) = B
            Button77.BackColor = sc.BackColor
        Else
            R = patternLEDList(77, 0)
            G = patternLEDList(77, 1)
            B = patternLEDList(77, 2)
            sc.BackColor = Button77.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button78_Click(sender As Object, e As EventArgs) Handles Button78.Click
        If (selec = 0) Then
            patternLEDList(78, 0) = R
            patternLEDList(78, 1) = G
            patternLEDList(78, 2) = B
            Button78.BackColor = sc.BackColor
        Else
            R = patternLEDList(78, 0)
            G = patternLEDList(78, 1)
            B = patternLEDList(78, 2)
            sc.BackColor = Button78.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button79_Click(sender As Object, e As EventArgs) Handles Button79.Click
        If (selec = 0) Then
            patternLEDList(79, 0) = R
            patternLEDList(79, 1) = G
            patternLEDList(79, 2) = B
            Button79.BackColor = sc.BackColor
        Else
            R = patternLEDList(79, 0)
            G = patternLEDList(79, 1)
            B = patternLEDList(79, 2)
            sc.BackColor = Button79.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button80_Click(sender As Object, e As EventArgs) Handles Button80.Click
        If (selec = 0) Then
            patternLEDList(80, 0) = R
            patternLEDList(80, 1) = G
            patternLEDList(80, 2) = B
            Button80.BackColor = sc.BackColor
        Else
            R = patternLEDList(80, 0)
            G = patternLEDList(80, 1)
            B = patternLEDList(80, 2)
            sc.BackColor = Button80.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button81_Click(sender As Object, e As EventArgs) Handles Button81.Click
        If (selec = 0) Then
            patternLEDList(81, 0) = R
            patternLEDList(81, 1) = G
            patternLEDList(81, 2) = B
            Button81.BackColor = sc.BackColor
        Else
            R = patternLEDList(81, 0)
            G = patternLEDList(81, 1)
            B = patternLEDList(81, 2)
            sc.BackColor = Button81.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button82_Click(sender As Object, e As EventArgs) Handles Button82.Click
        If (selec = 0) Then
            patternLEDList(82, 0) = R
            patternLEDList(82, 1) = G
            patternLEDList(82, 2) = B
            Button82.BackColor = sc.BackColor
        Else
            R = patternLEDList(82, 0)
            G = patternLEDList(82, 1)
            B = patternLEDList(82, 2)
            sc.BackColor = Button82.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button83_Click(sender As Object, e As EventArgs) Handles Button83.Click
        If (selec = 0) Then
            patternLEDList(83, 0) = R
            patternLEDList(83, 1) = G
            patternLEDList(83, 2) = B
            Button83.BackColor = sc.BackColor
        Else
            R = patternLEDList(83, 0)
            G = patternLEDList(83, 1)
            B = patternLEDList(83, 2)
            sc.BackColor = Button83.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button84_Click(sender As Object, e As EventArgs) Handles Button84.Click
        If (selec = 0) Then
            patternLEDList(84, 0) = R
            patternLEDList(84, 1) = G
            patternLEDList(84, 2) = B
            Button84.BackColor = sc.BackColor
        Else
            R = patternLEDList(84, 0)
            G = patternLEDList(84, 1)
            B = patternLEDList(84, 2)
            sc.BackColor = Button84.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button85_Click(sender As Object, e As EventArgs) Handles Button85.Click
        If (selec = 0) Then
            patternLEDList(85, 0) = R
            patternLEDList(85, 1) = G
            patternLEDList(85, 2) = B
            Button85.BackColor = sc.BackColor
        Else
            R = patternLEDList(85, 0)
            G = patternLEDList(85, 1)
            B = patternLEDList(85, 2)
            sc.BackColor = Button85.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button86_Click(sender As Object, e As EventArgs) Handles Button86.Click
        If (selec = 0) Then
            patternLEDList(86, 0) = R
            patternLEDList(86, 1) = G
            patternLEDList(86, 2) = B
            Button86.BackColor = sc.BackColor
        Else
            R = patternLEDList(86, 0)
            G = patternLEDList(86, 1)
            B = patternLEDList(86, 2)
            sc.BackColor = Button86.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button87_Click(sender As Object, e As EventArgs) Handles Button87.Click
        If (selec = 0) Then
            patternLEDList(87, 0) = R
            patternLEDList(87, 1) = G
            patternLEDList(87, 2) = B
            Button87.BackColor = sc.BackColor
        Else
            R = patternLEDList(87, 0)
            G = patternLEDList(87, 1)
            B = patternLEDList(87, 2)
            sc.BackColor = Button87.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button88_Click(sender As Object, e As EventArgs) Handles Button88.Click
        If (selec = 0) Then
            patternLEDList(88, 0) = R
            patternLEDList(88, 1) = G
            patternLEDList(88, 2) = B
            Button88.BackColor = sc.BackColor
        Else
            R = patternLEDList(88, 0)
            G = patternLEDList(88, 1)
            B = patternLEDList(88, 2)
            sc.BackColor = Button88.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button89_Click(sender As Object, e As EventArgs) Handles Button89.Click
        If (selec = 0) Then
            patternLEDList(89, 0) = R
            patternLEDList(89, 1) = G
            patternLEDList(89, 2) = B
            Button89.BackColor = sc.BackColor
        Else
            R = patternLEDList(89, 0)
            G = patternLEDList(89, 1)
            B = patternLEDList(89, 2)
            sc.BackColor = Button89.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button90_Click(sender As Object, e As EventArgs) Handles Button90.Click
        If (selec = 0) Then
            patternLEDList(90, 0) = R
            patternLEDList(90, 1) = G
            patternLEDList(90, 2) = B
            Button90.BackColor = sc.BackColor
        Else
            R = patternLEDList(90, 0)
            G = patternLEDList(90, 1)
            B = patternLEDList(90, 2)
            sc.BackColor = Button90.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button91_Click(sender As Object, e As EventArgs) Handles Button91.Click
        If (selec = 0) Then
            patternLEDList(91, 0) = R
            patternLEDList(91, 1) = G
            patternLEDList(91, 2) = B
            Button91.BackColor = sc.BackColor
        Else
            R = patternLEDList(91, 0)
            G = patternLEDList(91, 1)
            B = patternLEDList(91, 2)
            sc.BackColor = Button91.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button92_Click(sender As Object, e As EventArgs) Handles Button92.Click
        If (selec = 0) Then
            patternLEDList(92, 0) = R
            patternLEDList(92, 1) = G
            patternLEDList(92, 2) = B
            Button92.BackColor = sc.BackColor
        Else
            R = patternLEDList(92, 0)
            G = patternLEDList(92, 1)
            B = patternLEDList(92, 2)
            sc.BackColor = Button92.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button93_Click(sender As Object, e As EventArgs) Handles Button93.Click
        If (selec = 0) Then
            patternLEDList(93, 0) = R
            patternLEDList(93, 1) = G
            patternLEDList(93, 2) = B
            Button93.BackColor = sc.BackColor
        Else
            R = patternLEDList(93, 0)
            G = patternLEDList(93, 1)
            B = patternLEDList(93, 2)
            sc.BackColor = Button93.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button94_Click(sender As Object, e As EventArgs) Handles Button94.Click
        If (selec = 0) Then
            patternLEDList(94, 0) = R
            patternLEDList(94, 1) = G
            patternLEDList(94, 2) = B
            Button94.BackColor = sc.BackColor
        Else
            R = patternLEDList(94, 0)
            G = patternLEDList(94, 1)
            B = patternLEDList(94, 2)
            sc.BackColor = Button94.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button95_Click(sender As Object, e As EventArgs) Handles Button95.Click
        If (selec = 0) Then
            patternLEDList(95, 0) = R
            patternLEDList(95, 1) = G
            patternLEDList(95, 2) = B
            Button95.BackColor = sc.BackColor
        Else
            R = patternLEDList(95, 0)
            G = patternLEDList(95, 1)
            B = patternLEDList(95, 2)
            sc.BackColor = Button95.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button96_Click(sender As Object, e As EventArgs) Handles Button96.Click
        If (selec = 0) Then
            patternLEDList(96, 0) = R
            patternLEDList(96, 1) = G
            patternLEDList(96, 2) = B
            Button96.BackColor = sc.BackColor
        Else
            R = patternLEDList(96, 0)
            G = patternLEDList(96, 1)
            B = patternLEDList(96, 2)
            sc.BackColor = Button96.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button97_Click(sender As Object, e As EventArgs) Handles Button97.Click
        If (selec = 0) Then
            patternLEDList(97, 0) = R
            patternLEDList(97, 1) = G
            patternLEDList(97, 2) = B
            Button97.BackColor = sc.BackColor
        Else
            R = patternLEDList(97, 0)
            G = patternLEDList(97, 1)
            B = patternLEDList(97, 2)
            sc.BackColor = Button97.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button98_Click(sender As Object, e As EventArgs) Handles Button98.Click
        If (selec = 0) Then
            patternLEDList(98, 0) = R
            patternLEDList(98, 1) = G
            patternLEDList(98, 2) = B
            Button98.BackColor = sc.BackColor
        Else
            R = patternLEDList(98, 0)
            G = patternLEDList(98, 1)
            B = patternLEDList(98, 2)
            sc.BackColor = Button98.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button99_Click(sender As Object, e As EventArgs) Handles Button99.Click
        If (selec = 0) Then
            patternLEDList(99, 0) = R
            patternLEDList(99, 1) = G
            patternLEDList(99, 2) = B
            Button99.BackColor = sc.BackColor
        Else
            R = patternLEDList(99, 0)
            G = patternLEDList(99, 1)
            B = patternLEDList(99, 2)
            sc.BackColor = Button99.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        If (selec = 0) Then
            patternLEDList(100, 0) = R
            patternLEDList(100, 1) = G
            patternLEDList(100, 2) = B
            Button100.BackColor = sc.BackColor
        Else
            R = patternLEDList(100, 0)
            G = patternLEDList(100, 1)
            B = patternLEDList(100, 2)
            sc.BackColor = Button100.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button101_Click(sender As Object, e As EventArgs) Handles Button101.Click
        If (selec = 0) Then
            patternLEDList(101, 0) = R
            patternLEDList(101, 1) = G
            patternLEDList(101, 2) = B
            Button101.BackColor = sc.BackColor
        Else
            R = patternLEDList(101, 0)
            G = patternLEDList(101, 1)
            B = patternLEDList(101, 2)
            sc.BackColor = Button101.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button102_Click(sender As Object, e As EventArgs) Handles Button102.Click
        If (selec = 0) Then
            patternLEDList(102, 0) = R
            patternLEDList(102, 1) = G
            patternLEDList(102, 2) = B
            Button102.BackColor = sc.BackColor
        Else
            R = patternLEDList(102, 0)
            G = patternLEDList(102, 1)
            B = patternLEDList(102, 2)
            sc.BackColor = Button102.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button103_Click(sender As Object, e As EventArgs) Handles Button103.Click
        If (selec = 0) Then
            patternLEDList(103, 0) = R
            patternLEDList(103, 1) = G
            patternLEDList(103, 2) = B
            Button103.BackColor = sc.BackColor
        Else
            R = patternLEDList(103, 0)
            G = patternLEDList(103, 1)
            B = patternLEDList(103, 2)
            sc.BackColor = Button103.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button104.Click
        If (selec = 0) Then
            patternLEDList(104, 0) = R
            patternLEDList(104, 1) = G
            patternLEDList(104, 2) = B
            Button104.BackColor = sc.BackColor
        Else
            R = patternLEDList(104, 0)
            G = patternLEDList(104, 1)
            B = patternLEDList(104, 2)
            sc.BackColor = Button104.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button105_Click(sender As Object, e As EventArgs) Handles Button105.Click
        If (selec = 0) Then
            patternLEDList(105, 0) = R
            patternLEDList(105, 1) = G
            patternLEDList(105, 2) = B
            Button105.BackColor = sc.BackColor
        Else
            R = patternLEDList(105, 0)
            G = patternLEDList(105, 1)
            B = patternLEDList(105, 2)
            sc.BackColor = Button105.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button106_Click(sender As Object, e As EventArgs) Handles Button106.Click
        If (selec = 0) Then
            patternLEDList(106, 0) = R
            patternLEDList(106, 1) = G
            patternLEDList(106, 2) = B
            Button106.BackColor = sc.BackColor
        Else
            R = patternLEDList(106, 0)
            G = patternLEDList(106, 1)
            B = patternLEDList(106, 2)
            sc.BackColor = Button106.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button107_Click(sender As Object, e As EventArgs) Handles Button107.Click
        If (selec = 0) Then
            patternLEDList(107, 0) = R
            patternLEDList(107, 1) = G
            patternLEDList(107, 2) = B
            Button107.BackColor = sc.BackColor
        Else
            R = patternLEDList(107, 0)
            G = patternLEDList(107, 1)
            B = patternLEDList(107, 2)
            sc.BackColor = Button107.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button108_Click(sender As Object, e As EventArgs) Handles Button108.Click
        If (selec = 0) Then
            patternLEDList(108, 0) = R
            patternLEDList(108, 1) = G
            patternLEDList(108, 2) = B
            Button108.BackColor = sc.BackColor
        Else
            R = patternLEDList(108, 0)
            G = patternLEDList(108, 1)
            B = patternLEDList(108, 2)
            sc.BackColor = Button108.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button109_Click(sender As Object, e As EventArgs) Handles Button109.Click
        If (selec = 0) Then
            patternLEDList(109, 0) = R
            patternLEDList(109, 1) = G
            patternLEDList(109, 2) = B
            Button109.BackColor = sc.BackColor
        Else
            R = patternLEDList(109, 0)
            G = patternLEDList(109, 1)
            B = patternLEDList(109, 2)
            sc.BackColor = Button109.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button110_Click(sender As Object, e As EventArgs) Handles Button110.Click
        If (selec = 0) Then
            patternLEDList(110, 0) = R
            patternLEDList(110, 1) = G
            patternLEDList(110, 2) = B
            Button110.BackColor = sc.BackColor
        Else
            R = patternLEDList(110, 0)
            G = patternLEDList(110, 1)
            B = patternLEDList(110, 2)
            sc.BackColor = Button110.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button111_Click(sender As Object, e As EventArgs) Handles Button111.Click
        If (selec = 0) Then
            patternLEDList(111, 0) = R
            patternLEDList(111, 1) = G
            patternLEDList(111, 2) = B
            Button111.BackColor = sc.BackColor
        Else
            R = patternLEDList(111, 0)
            G = patternLEDList(111, 1)
            B = patternLEDList(111, 2)
            sc.BackColor = Button111.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button112_Click(sender As Object, e As EventArgs) Handles Button112.Click
        If (selec = 0) Then
            patternLEDList(112, 0) = R
            patternLEDList(112, 1) = G
            patternLEDList(112, 2) = B
            Button112.BackColor = sc.BackColor
        Else
            R = patternLEDList(112, 0)
            G = patternLEDList(112, 1)
            B = patternLEDList(112, 2)
            sc.BackColor = Button112.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button113_Click(sender As Object, e As EventArgs) Handles Button113.Click
        If (selec = 0) Then
            patternLEDList(113, 0) = R
            patternLEDList(113, 1) = G
            patternLEDList(113, 2) = B
            Button113.BackColor = sc.BackColor
        Else
            R = patternLEDList(113, 0)
            G = patternLEDList(113, 1)
            B = patternLEDList(113, 2)
            sc.BackColor = Button113.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button114_Click(sender As Object, e As EventArgs) Handles Button114.Click
        If (selec = 0) Then
            patternLEDList(114, 0) = R
            patternLEDList(114, 1) = G
            patternLEDList(114, 2) = B
            Button114.BackColor = sc.BackColor
        Else
            R = patternLEDList(114, 0)
            G = patternLEDList(114, 1)
            B = patternLEDList(114, 2)
            sc.BackColor = Button114.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button115_Click(sender As Object, e As EventArgs) Handles Button115.Click
        If (selec = 0) Then
            patternLEDList(115, 0) = R
            patternLEDList(115, 1) = G
            patternLEDList(115, 2) = B
            Button115.BackColor = sc.BackColor
        Else
            R = patternLEDList(115, 0)
            G = patternLEDList(115, 1)
            B = patternLEDList(115, 2)
            sc.BackColor = Button115.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button116_Click(sender As Object, e As EventArgs) Handles Button116.Click
        If (selec = 0) Then
            patternLEDList(116, 0) = R
            patternLEDList(116, 1) = G
            patternLEDList(116, 2) = B
            Button116.BackColor = sc.BackColor
        Else
            R = patternLEDList(116, 0)
            G = patternLEDList(116, 1)
            B = patternLEDList(116, 2)
            sc.BackColor = Button116.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button117_Click(sender As Object, e As EventArgs) Handles Button117.Click
        If (selec = 0) Then
            patternLEDList(117, 0) = R
            patternLEDList(117, 1) = G
            patternLEDList(117, 2) = B
            Button117.BackColor = sc.BackColor
        Else
            R = patternLEDList(117, 0)
            G = patternLEDList(117, 1)
            B = patternLEDList(117, 2)
            sc.BackColor = Button117.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button118_Click(sender As Object, e As EventArgs) Handles Button118.Click
        If (selec = 0) Then
            patternLEDList(118, 0) = R
            patternLEDList(118, 1) = G
            patternLEDList(118, 2) = B
            Button118.BackColor = sc.BackColor
        Else
            R = patternLEDList(118, 0)
            G = patternLEDList(118, 1)
            B = patternLEDList(118, 2)
            sc.BackColor = Button118.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button119_Click(sender As Object, e As EventArgs) Handles Button119.Click
        If (selec = 0) Then
            patternLEDList(119, 0) = R
            patternLEDList(119, 1) = G
            patternLEDList(119, 2) = B
            Button119.BackColor = sc.BackColor
        Else
            R = patternLEDList(119, 0)
            G = patternLEDList(119, 1)
            B = patternLEDList(119, 2)
            sc.BackColor = Button119.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button120_Click(sender As Object, e As EventArgs) Handles Button120.Click
        If (selec = 0) Then
            patternLEDList(120, 0) = R
            patternLEDList(120, 1) = G
            patternLEDList(120, 2) = B
            Button120.BackColor = sc.BackColor
        Else
            R = patternLEDList(120, 0)
            G = patternLEDList(120, 1)
            B = patternLEDList(120, 2)
            sc.BackColor = Button120.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button121_Click(sender As Object, e As EventArgs) Handles Button121.Click
        If (selec = 0) Then
            patternLEDList(121, 0) = R
            patternLEDList(121, 1) = G
            patternLEDList(121, 2) = B
            Button121.BackColor = sc.BackColor
        Else
            R = patternLEDList(121, 0)
            G = patternLEDList(121, 1)
            B = patternLEDList(121, 2)
            sc.BackColor = Button121.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button122_Click(sender As Object, e As EventArgs) Handles Button122.Click
        If (selec = 0) Then
            patternLEDList(122, 0) = R
            patternLEDList(122, 1) = G
            patternLEDList(122, 2) = B
            Button122.BackColor = sc.BackColor
        Else
            R = patternLEDList(122, 0)
            G = patternLEDList(122, 1)
            B = patternLEDList(122, 2)
            sc.BackColor = Button122.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button123_Click(sender As Object, e As EventArgs) Handles Button123.Click
        If (selec = 0) Then
            patternLEDList(123, 0) = R
            patternLEDList(123, 1) = G
            patternLEDList(123, 2) = B
            Button123.BackColor = sc.BackColor
        Else
            R = patternLEDList(123, 0)
            G = patternLEDList(123, 1)
            B = patternLEDList(123, 2)
            sc.BackColor = Button123.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button124_Click(sender As Object, e As EventArgs) Handles Button124.Click
        If (selec = 0) Then
            patternLEDList(124, 0) = R
            patternLEDList(124, 1) = G
            patternLEDList(124, 2) = B
            Button124.BackColor = sc.BackColor
        Else
            R = patternLEDList(124, 0)
            G = patternLEDList(124, 1)
            B = patternLEDList(124, 2)
            sc.BackColor = Button124.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button125_Click(sender As Object, e As EventArgs) Handles Button125.Click
        If (selec = 0) Then
            patternLEDList(125, 0) = R
            patternLEDList(125, 1) = G
            patternLEDList(125, 2) = B
            Button125.BackColor = sc.BackColor
        Else
            R = patternLEDList(125, 0)
            G = patternLEDList(125, 1)
            B = patternLEDList(125, 2)
            sc.BackColor = Button125.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button126_Click(sender As Object, e As EventArgs) Handles Button126.Click
        If (selec = 0) Then
            patternLEDList(126, 0) = R
            patternLEDList(126, 1) = G
            patternLEDList(126, 2) = B
            Button126.BackColor = sc.BackColor
        Else
            R = patternLEDList(126, 0)
            G = patternLEDList(126, 1)
            B = patternLEDList(126, 2)
            sc.BackColor = Button126.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button127_Click(sender As Object, e As EventArgs) Handles Button127.Click
        If (selec = 0) Then
            patternLEDList(127, 0) = R
            patternLEDList(127, 1) = G
            patternLEDList(127, 2) = B
            Button127.BackColor = sc.BackColor
        Else
            R = patternLEDList(127, 0)
            G = patternLEDList(127, 1)
            B = patternLEDList(127, 2)
            sc.BackColor = Button127.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button128_Click(sender As Object, e As EventArgs) Handles Button128.Click
        If (selec = 0) Then
            patternLEDList(128, 0) = R
            patternLEDList(128, 1) = G
            patternLEDList(128, 2) = B
            Button128.BackColor = sc.BackColor
        Else
            R = patternLEDList(128, 0)
            G = patternLEDList(128, 1)
            B = patternLEDList(128, 2)
            sc.BackColor = Button128.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button129_Click(sender As Object, e As EventArgs) Handles Button129.Click
        If (selec = 0) Then
            patternLEDList(129, 0) = R
            patternLEDList(129, 1) = G
            patternLEDList(129, 2) = B
            Button129.BackColor = sc.BackColor
        Else
            R = patternLEDList(129, 0)
            G = patternLEDList(129, 1)
            B = patternLEDList(129, 2)
            sc.BackColor = Button129.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button130_Click(sender As Object, e As EventArgs) Handles Button130.Click
        If (selec = 0) Then
            patternLEDList(130, 0) = R
            patternLEDList(130, 1) = G
            patternLEDList(130, 2) = B
            Button130.BackColor = sc.BackColor
        Else
            R = patternLEDList(130, 0)
            G = patternLEDList(130, 1)
            B = patternLEDList(130, 2)
            sc.BackColor = Button130.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button131_Click(sender As Object, e As EventArgs) Handles Button131.Click
        If (selec = 0) Then
            patternLEDList(131, 0) = R
            patternLEDList(131, 1) = G
            patternLEDList(131, 2) = B
            Button131.BackColor = sc.BackColor
        Else
            R = patternLEDList(131, 0)
            G = patternLEDList(131, 1)
            B = patternLEDList(131, 2)
            sc.BackColor = Button131.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button132_Click(sender As Object, e As EventArgs) Handles Button132.Click
        If (selec = 0) Then
            patternLEDList(132, 0) = R
            patternLEDList(132, 1) = G
            patternLEDList(132, 2) = B
            Button132.BackColor = sc.BackColor
        Else
            R = patternLEDList(132, 0)
            G = patternLEDList(132, 1)
            B = patternLEDList(132, 2)
            sc.BackColor = Button132.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button133_Click(sender As Object, e As EventArgs) Handles Button133.Click
        If (selec = 0) Then
            patternLEDList(133, 0) = R
            patternLEDList(133, 1) = G
            patternLEDList(133, 2) = B
            Button133.BackColor = sc.BackColor
        Else
            R = patternLEDList(133, 0)
            G = patternLEDList(133, 1)
            B = patternLEDList(133, 2)
            sc.BackColor = Button133.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button134_Click(sender As Object, e As EventArgs) Handles Button134.Click
        If (selec = 0) Then
            patternLEDList(134, 0) = R
            patternLEDList(134, 1) = G
            patternLEDList(134, 2) = B
            Button134.BackColor = sc.BackColor
        Else
            R = patternLEDList(134, 0)
            G = patternLEDList(134, 1)
            B = patternLEDList(134, 2)
            sc.BackColor = Button134.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button135_Click(sender As Object, e As EventArgs) Handles Button135.Click
        If (selec = 0) Then
            patternLEDList(135, 0) = R
            patternLEDList(135, 1) = G
            patternLEDList(135, 2) = B
            Button135.BackColor = sc.BackColor
        Else
            R = patternLEDList(135, 0)
            G = patternLEDList(135, 1)
            B = patternLEDList(135, 2)
            sc.BackColor = Button135.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button136_Click(sender As Object, e As EventArgs) Handles Button136.Click
        If (selec = 0) Then
            patternLEDList(136, 0) = R
            patternLEDList(136, 1) = G
            patternLEDList(136, 2) = B
            Button136.BackColor = sc.BackColor
        Else
            R = patternLEDList(136, 0)
            G = patternLEDList(136, 1)
            B = patternLEDList(136, 2)
            sc.BackColor = Button136.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button137_Click(sender As Object, e As EventArgs) Handles Button137.Click
        If (selec = 0) Then
            patternLEDList(137, 0) = R
            patternLEDList(137, 1) = G
            patternLEDList(137, 2) = B
            Button137.BackColor = sc.BackColor
        Else
            R = patternLEDList(137, 0)
            G = patternLEDList(137, 1)
            B = patternLEDList(137, 2)
            sc.BackColor = Button137.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button138_Click(sender As Object, e As EventArgs) Handles Button138.Click
        If (selec = 0) Then
            patternLEDList(138, 0) = R
            patternLEDList(138, 1) = G
            patternLEDList(138, 2) = B
            Button138.BackColor = sc.BackColor
        Else
            R = patternLEDList(138, 0)
            G = patternLEDList(138, 1)
            B = patternLEDList(138, 2)
            sc.BackColor = Button138.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button139_Click(sender As Object, e As EventArgs) Handles Button139.Click
        If (selec = 0) Then
            patternLEDList(139, 0) = R
            patternLEDList(139, 1) = G
            patternLEDList(139, 2) = B
            Button139.BackColor = sc.BackColor
        Else
            R = patternLEDList(139, 0)
            G = patternLEDList(139, 1)
            B = patternLEDList(139, 2)
            sc.BackColor = Button139.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button140_Click(sender As Object, e As EventArgs) Handles Button140.Click
        If (selec = 0) Then
            patternLEDList(140, 0) = R
            patternLEDList(140, 1) = G
            patternLEDList(140, 2) = B
            Button140.BackColor = sc.BackColor
        Else
            R = patternLEDList(140, 0)
            G = patternLEDList(140, 1)
            B = patternLEDList(140, 2)
            sc.BackColor = Button140.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button141_Click(sender As Object, e As EventArgs) Handles Button141.Click
        If (selec = 0) Then
            patternLEDList(141, 0) = R
            patternLEDList(141, 1) = G
            patternLEDList(141, 2) = B
            Button141.BackColor = sc.BackColor
        Else
            R = patternLEDList(141, 0)
            G = patternLEDList(141, 1)
            B = patternLEDList(141, 2)
            sc.BackColor = Button141.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button142_Click(sender As Object, e As EventArgs) Handles Button142.Click
        If (selec = 0) Then
            patternLEDList(142, 0) = R
            patternLEDList(142, 1) = G
            patternLEDList(142, 2) = B
            Button142.BackColor = sc.BackColor
        Else
            R = patternLEDList(142, 0)
            G = patternLEDList(142, 1)
            B = patternLEDList(142, 2)
            sc.BackColor = Button142.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button143_Click(sender As Object, e As EventArgs) Handles Button143.Click
        If (selec = 0) Then
            patternLEDList(143, 0) = R
            patternLEDList(143, 1) = G
            patternLEDList(143, 2) = B
            Button143.BackColor = sc.BackColor
        Else
            R = patternLEDList(143, 0)
            G = patternLEDList(143, 1)
            B = patternLEDList(143, 2)
            sc.BackColor = Button143.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button144_Click(sender As Object, e As EventArgs) Handles Button144.Click
        If (selec = 0) Then
            patternLEDList(144, 0) = R
            patternLEDList(144, 1) = G
            patternLEDList(144, 2) = B
            Button144.BackColor = sc.BackColor
        Else
            R = patternLEDList(144, 0)
            G = patternLEDList(144, 1)
            B = patternLEDList(144, 2)
            sc.BackColor = Button144.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button145_Click(sender As Object, e As EventArgs) Handles Button145.Click
        If (selec = 0) Then
            patternLEDList(145, 0) = R
            patternLEDList(145, 1) = G
            patternLEDList(145, 2) = B
            Button145.BackColor = sc.BackColor
        Else
            R = patternLEDList(145, 0)
            G = patternLEDList(145, 1)
            B = patternLEDList(145, 2)
            sc.BackColor = Button145.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button146_Click(sender As Object, e As EventArgs) Handles Button146.Click
        If (selec = 0) Then
            patternLEDList(146, 0) = R
            patternLEDList(146, 1) = G
            patternLEDList(146, 2) = B
            Button146.BackColor = sc.BackColor
        Else
            R = patternLEDList(146, 0)
            G = patternLEDList(146, 1)
            B = patternLEDList(146, 2)
            sc.BackColor = Button146.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button147_Click(sender As Object, e As EventArgs) Handles Button147.Click
        If (selec = 0) Then
            patternLEDList(147, 0) = R
            patternLEDList(147, 1) = G
            patternLEDList(147, 2) = B
            Button147.BackColor = sc.BackColor
        Else
            R = patternLEDList(147, 0)
            G = patternLEDList(147, 1)
            B = patternLEDList(147, 2)
            sc.BackColor = Button147.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button148_Click(sender As Object, e As EventArgs) Handles Button148.Click
        If (selec = 0) Then
            patternLEDList(148, 0) = R
            patternLEDList(148, 1) = G
            patternLEDList(148, 2) = B
            Button148.BackColor = sc.BackColor
        Else
            R = patternLEDList(148, 0)
            G = patternLEDList(148, 1)
            B = patternLEDList(148, 2)
            sc.BackColor = Button148.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button149_Click(sender As Object, e As EventArgs) Handles Button149.Click
        If (selec = 0) Then
            patternLEDList(149, 0) = R
            patternLEDList(149, 1) = G
            patternLEDList(149, 2) = B
            Button149.BackColor = sc.BackColor
        Else
            R = patternLEDList(149, 0)
            G = patternLEDList(149, 1)
            B = patternLEDList(149, 2)
            sc.BackColor = Button149.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button150_Click(sender As Object, e As EventArgs) Handles Button150.Click
        If (selec = 0) Then
            patternLEDList(150, 0) = R
            patternLEDList(150, 1) = G
            patternLEDList(150, 2) = B
            Button150.BackColor = sc.BackColor
        Else
            R = patternLEDList(150, 0)
            G = patternLEDList(150, 1)
            B = patternLEDList(150, 2)
            sc.BackColor = Button150.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button151_Click(sender As Object, e As EventArgs) Handles Button151.Click
        If (selec = 0) Then
            patternLEDList(151, 0) = R
            patternLEDList(151, 1) = G
            patternLEDList(151, 2) = B
            Button151.BackColor = sc.BackColor
        Else
            R = patternLEDList(151, 0)
            G = patternLEDList(151, 1)
            B = patternLEDList(151, 2)
            sc.BackColor = Button151.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button152_Click(sender As Object, e As EventArgs) Handles Button152.Click
        If (selec = 0) Then
            patternLEDList(152, 0) = R
            patternLEDList(152, 1) = G
            patternLEDList(152, 2) = B
            Button152.BackColor = sc.BackColor
        Else
            R = patternLEDList(152, 0)
            G = patternLEDList(152, 1)
            B = patternLEDList(152, 2)
            sc.BackColor = Button152.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button153_Click(sender As Object, e As EventArgs) Handles Button153.Click
        If (selec = 0) Then
            patternLEDList(153, 0) = R
            patternLEDList(153, 1) = G
            patternLEDList(153, 2) = B
            Button153.BackColor = sc.BackColor
        Else
            R = patternLEDList(153, 0)
            G = patternLEDList(153, 1)
            B = patternLEDList(153, 2)
            sc.BackColor = Button153.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button154_Click(sender As Object, e As EventArgs) Handles Button154.Click
        If (selec = 0) Then
            patternLEDList(154, 0) = R
            patternLEDList(154, 1) = G
            patternLEDList(154, 2) = B
            Button154.BackColor = sc.BackColor
        Else
            R = patternLEDList(154, 0)
            G = patternLEDList(154, 1)
            B = patternLEDList(154, 2)
            sc.BackColor = Button154.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button155_Click(sender As Object, e As EventArgs) Handles Button155.Click
        If (selec = 0) Then
            patternLEDList(155, 0) = R
            patternLEDList(155, 1) = G
            patternLEDList(155, 2) = B
            Button155.BackColor = sc.BackColor
        Else
            R = patternLEDList(155, 0)
            G = patternLEDList(155, 1)
            B = patternLEDList(155, 2)
            sc.BackColor = Button155.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button156_Click(sender As Object, e As EventArgs) Handles Button156.Click
        If (selec = 0) Then
            patternLEDList(156, 0) = R
            patternLEDList(156, 1) = G
            patternLEDList(156, 2) = B
            Button156.BackColor = sc.BackColor
        Else
            R = patternLEDList(156, 0)
            G = patternLEDList(156, 1)
            B = patternLEDList(156, 2)
            sc.BackColor = Button156.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button157_Click(sender As Object, e As EventArgs) Handles Button157.Click
        If (selec = 0) Then
            patternLEDList(157, 0) = R
            patternLEDList(157, 1) = G
            patternLEDList(157, 2) = B
            Button157.BackColor = sc.BackColor
        Else
            R = patternLEDList(157, 0)
            G = patternLEDList(157, 1)
            B = patternLEDList(157, 2)
            sc.BackColor = Button157.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button158_Click(sender As Object, e As EventArgs) Handles Button158.Click
        If (selec = 0) Then
            patternLEDList(158, 0) = R
            patternLEDList(158, 1) = G
            patternLEDList(158, 2) = B
            Button158.BackColor = sc.BackColor
        Else
            R = patternLEDList(158, 0)
            G = patternLEDList(158, 1)
            B = patternLEDList(158, 2)
            sc.BackColor = Button158.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button159_Click(sender As Object, e As EventArgs) Handles Button159.Click
        If (selec = 0) Then
            patternLEDList(159, 0) = R
            patternLEDList(159, 1) = G
            patternLEDList(159, 2) = B
            Button159.BackColor = sc.BackColor
        Else
            R = patternLEDList(159, 0)
            G = patternLEDList(159, 1)
            B = patternLEDList(159, 2)
            sc.BackColor = Button159.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button160_Click(sender As Object, e As EventArgs) Handles Button160.Click
        If (selec = 0) Then
            patternLEDList(160, 0) = R
            patternLEDList(160, 1) = G
            patternLEDList(160, 2) = B
            Button160.BackColor = sc.BackColor
        Else
            R = patternLEDList(160, 0)
            G = patternLEDList(160, 1)
            B = patternLEDList(160, 2)
            sc.BackColor = Button160.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button161_Click(sender As Object, e As EventArgs) Handles Button161.Click
        If (selec = 0) Then
            patternLEDList(161, 0) = R
            patternLEDList(161, 1) = G
            patternLEDList(161, 2) = B
            Button161.BackColor = sc.BackColor
        Else
            R = patternLEDList(161, 0)
            G = patternLEDList(161, 1)
            B = patternLEDList(161, 2)
            sc.BackColor = Button161.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button162_Click(sender As Object, e As EventArgs) Handles Button162.Click
        If (selec = 0) Then
            patternLEDList(162, 0) = R
            patternLEDList(162, 1) = G
            patternLEDList(162, 2) = B
            Button162.BackColor = sc.BackColor
        Else
            R = patternLEDList(162, 0)
            G = patternLEDList(162, 1)
            B = patternLEDList(162, 2)
            sc.BackColor = Button162.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button163_Click(sender As Object, e As EventArgs) Handles Button163.Click
        If (selec = 0) Then
            patternLEDList(163, 0) = R
            patternLEDList(163, 1) = G
            patternLEDList(163, 2) = B
            Button163.BackColor = sc.BackColor
        Else
            R = patternLEDList(163, 0)
            G = patternLEDList(163, 1)
            B = patternLEDList(163, 2)
            sc.BackColor = Button163.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button164_Click(sender As Object, e As EventArgs) Handles Button164.Click
        If (selec = 0) Then
            patternLEDList(164, 0) = R
            patternLEDList(164, 1) = G
            patternLEDList(164, 2) = B
            Button164.BackColor = sc.BackColor
        Else
            R = patternLEDList(164, 0)
            G = patternLEDList(164, 1)
            B = patternLEDList(164, 2)
            sc.BackColor = Button164.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button165_Click(sender As Object, e As EventArgs) Handles Button165.Click
        If (selec = 0) Then
            patternLEDList(165, 0) = R
            patternLEDList(165, 1) = G
            patternLEDList(165, 2) = B
            Button165.BackColor = sc.BackColor
        Else
            R = patternLEDList(165, 0)
            G = patternLEDList(165, 1)
            B = patternLEDList(165, 2)
            sc.BackColor = Button165.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button166_Click(sender As Object, e As EventArgs) Handles Button166.Click
        If (selec = 0) Then
            patternLEDList(166, 0) = R
            patternLEDList(166, 1) = G
            patternLEDList(166, 2) = B
            Button166.BackColor = sc.BackColor
        Else
            R = patternLEDList(166, 0)
            G = patternLEDList(166, 1)
            B = patternLEDList(166, 2)
            sc.BackColor = Button166.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button167_Click(sender As Object, e As EventArgs) Handles Button167.Click
        If (selec = 0) Then
            patternLEDList(167, 0) = R
            patternLEDList(167, 1) = G
            patternLEDList(167, 2) = B
            Button167.BackColor = sc.BackColor
        Else
            R = patternLEDList(167, 0)
            G = patternLEDList(167, 1)
            B = patternLEDList(167, 2)
            sc.BackColor = Button167.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button168_Click(sender As Object, e As EventArgs) Handles Button168.Click
        If (selec = 0) Then
            patternLEDList(168, 0) = R
            patternLEDList(168, 1) = G
            patternLEDList(168, 2) = B
            Button168.BackColor = sc.BackColor
        Else
            R = patternLEDList(168, 0)
            G = patternLEDList(168, 1)
            B = patternLEDList(168, 2)
            sc.BackColor = Button168.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button169_Click(sender As Object, e As EventArgs) Handles Button169.Click
        If (selec = 0) Then
            patternLEDList(169, 0) = R
            patternLEDList(169, 1) = G
            patternLEDList(169, 2) = B
            Button169.BackColor = sc.BackColor
        Else
            R = patternLEDList(169, 0)
            G = patternLEDList(169, 1)
            B = patternLEDList(169, 2)
            sc.BackColor = Button169.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button170_Click(sender As Object, e As EventArgs) Handles Button170.Click
        If (selec = 0) Then
            patternLEDList(170, 0) = R
            patternLEDList(170, 1) = G
            patternLEDList(170, 2) = B
            Button170.BackColor = sc.BackColor
        Else
            R = patternLEDList(170, 0)
            G = patternLEDList(170, 1)
            B = patternLEDList(170, 2)
            sc.BackColor = Button170.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button171_Click(sender As Object, e As EventArgs) Handles Button171.Click
        If (selec = 0) Then
            patternLEDList(171, 0) = R
            patternLEDList(171, 1) = G
            patternLEDList(171, 2) = B
            Button171.BackColor = sc.BackColor
        Else
            R = patternLEDList(171, 0)
            G = patternLEDList(171, 1)
            B = patternLEDList(171, 2)
            sc.BackColor = Button171.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button172_Click(sender As Object, e As EventArgs) Handles Button172.Click
        If (selec = 0) Then
            patternLEDList(172, 0) = R
            patternLEDList(172, 1) = G
            patternLEDList(172, 2) = B
            Button172.BackColor = sc.BackColor
        Else
            R = patternLEDList(172, 0)
            G = patternLEDList(172, 1)
            B = patternLEDList(172, 2)
            sc.BackColor = Button172.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button173_Click(sender As Object, e As EventArgs) Handles Button173.Click
        If (selec = 0) Then
            patternLEDList(173, 0) = R
            patternLEDList(173, 1) = G
            patternLEDList(173, 2) = B
            Button173.BackColor = sc.BackColor
        Else
            R = patternLEDList(173, 0)
            G = patternLEDList(173, 1)
            B = patternLEDList(173, 2)
            sc.BackColor = Button173.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button174_Click(sender As Object, e As EventArgs) Handles Button174.Click
        If (selec = 0) Then
            patternLEDList(174, 0) = R
            patternLEDList(174, 1) = G
            patternLEDList(174, 2) = B
            Button174.BackColor = sc.BackColor
        Else
            R = patternLEDList(174, 0)
            G = patternLEDList(174, 1)
            B = patternLEDList(174, 2)
            sc.BackColor = Button174.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button175_Click(sender As Object, e As EventArgs) Handles Button175.Click
        If (selec = 0) Then
            patternLEDList(175, 0) = R
            patternLEDList(175, 1) = G
            patternLEDList(175, 2) = B
            Button175.BackColor = sc.BackColor
        Else
            R = patternLEDList(175, 0)
            G = patternLEDList(175, 1)
            B = patternLEDList(175, 2)
            sc.BackColor = Button175.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button176_Click(sender As Object, e As EventArgs) Handles Button176.Click
        If (selec = 0) Then
            patternLEDList(176, 0) = R
            patternLEDList(176, 1) = G
            patternLEDList(176, 2) = B
            Button176.BackColor = sc.BackColor
        Else
            R = patternLEDList(176, 0)
            G = patternLEDList(176, 1)
            B = patternLEDList(176, 2)
            sc.BackColor = Button176.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button177_Click(sender As Object, e As EventArgs) Handles Button177.Click
        If (selec = 0) Then
            patternLEDList(177, 0) = R
            patternLEDList(177, 1) = G
            patternLEDList(177, 2) = B
            Button177.BackColor = sc.BackColor
        Else
            R = patternLEDList(177, 0)
            G = patternLEDList(177, 1)
            B = patternLEDList(177, 2)
            sc.BackColor = Button177.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button178_Click(sender As Object, e As EventArgs) Handles Button178.Click
        If (selec = 0) Then
            patternLEDList(178, 0) = R
            patternLEDList(178, 1) = G
            patternLEDList(178, 2) = B
            Button178.BackColor = sc.BackColor
        Else
            R = patternLEDList(178, 0)
            G = patternLEDList(178, 1)
            B = patternLEDList(178, 2)
            sc.BackColor = Button178.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button179_Click(sender As Object, e As EventArgs) Handles Button179.Click
        If (selec = 0) Then
            patternLEDList(179, 0) = R
            patternLEDList(179, 1) = G
            patternLEDList(179, 2) = B
            Button179.BackColor = sc.BackColor
        Else
            R = patternLEDList(179, 0)
            G = patternLEDList(179, 1)
            B = patternLEDList(179, 2)
            sc.BackColor = Button179.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button180_Click(sender As Object, e As EventArgs) Handles Button180.Click
        If (selec = 0) Then
            patternLEDList(180, 0) = R
            patternLEDList(180, 1) = G
            patternLEDList(180, 2) = B
            Button180.BackColor = sc.BackColor
        Else
            R = patternLEDList(180, 0)
            G = patternLEDList(180, 1)
            B = patternLEDList(180, 2)
            sc.BackColor = Button180.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button181_Click(sender As Object, e As EventArgs) Handles Button181.Click
        If (selec = 0) Then
            patternLEDList(181, 0) = R
            patternLEDList(181, 1) = G
            patternLEDList(181, 2) = B
            Button181.BackColor = sc.BackColor
        Else
            R = patternLEDList(181, 0)
            G = patternLEDList(181, 1)
            B = patternLEDList(181, 2)
            sc.BackColor = Button181.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button182_Click(sender As Object, e As EventArgs) Handles Button182.Click
        If (selec = 0) Then
            patternLEDList(182, 0) = R
            patternLEDList(182, 1) = G
            patternLEDList(182, 2) = B
            Button182.BackColor = sc.BackColor
        Else
            R = patternLEDList(182, 0)
            G = patternLEDList(182, 1)
            B = patternLEDList(182, 2)
            sc.BackColor = Button182.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button183_Click(sender As Object, e As EventArgs) Handles Button183.Click
        If (selec = 0) Then
            patternLEDList(183, 0) = R
            patternLEDList(183, 1) = G
            patternLEDList(183, 2) = B
            Button183.BackColor = sc.BackColor
        Else
            R = patternLEDList(183, 0)
            G = patternLEDList(183, 1)
            B = patternLEDList(183, 2)
            sc.BackColor = Button183.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button184_Click(sender As Object, e As EventArgs) Handles Button184.Click
        If (selec = 0) Then
            patternLEDList(184, 0) = R
            patternLEDList(184, 1) = G
            patternLEDList(184, 2) = B
            Button184.BackColor = sc.BackColor
        Else
            R = patternLEDList(184, 0)
            G = patternLEDList(184, 1)
            B = patternLEDList(184, 2)
            sc.BackColor = Button184.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button185_Click(sender As Object, e As EventArgs) Handles Button185.Click
        If (selec = 0) Then
            patternLEDList(185, 0) = R
            patternLEDList(185, 1) = G
            patternLEDList(185, 2) = B
            Button185.BackColor = sc.BackColor
        Else
            R = patternLEDList(185, 0)
            G = patternLEDList(185, 1)
            B = patternLEDList(185, 2)
            sc.BackColor = Button185.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button186_Click(sender As Object, e As EventArgs) Handles Button186.Click
        If (selec = 0) Then
            patternLEDList(186, 0) = R
            patternLEDList(186, 1) = G
            patternLEDList(186, 2) = B
            Button186.BackColor = sc.BackColor
        Else
            R = patternLEDList(186, 0)
            G = patternLEDList(186, 1)
            B = patternLEDList(186, 2)
            sc.BackColor = Button186.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button187_Click(sender As Object, e As EventArgs) Handles Button187.Click
        If (selec = 0) Then
            patternLEDList(187, 0) = R
            patternLEDList(187, 1) = G
            patternLEDList(187, 2) = B
            Button187.BackColor = sc.BackColor
        Else
            R = patternLEDList(187, 0)
            G = patternLEDList(187, 1)
            B = patternLEDList(187, 2)
            sc.BackColor = Button187.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button188_Click(sender As Object, e As EventArgs) Handles Button188.Click
        If (selec = 0) Then
            patternLEDList(188, 0) = R
            patternLEDList(188, 1) = G
            patternLEDList(188, 2) = B
            Button188.BackColor = sc.BackColor
        Else
            R = patternLEDList(188, 0)
            G = patternLEDList(188, 1)
            B = patternLEDList(188, 2)
            sc.BackColor = Button188.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button189_Click(sender As Object, e As EventArgs) Handles Button189.Click
        If (selec = 0) Then
            patternLEDList(189, 0) = R
            patternLEDList(189, 1) = G
            patternLEDList(189, 2) = B
            Button189.BackColor = sc.BackColor
        Else
            R = patternLEDList(189, 0)
            G = patternLEDList(189, 1)
            B = patternLEDList(189, 2)
            sc.BackColor = Button189.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button190_Click(sender As Object, e As EventArgs) Handles Button190.Click
        If (selec = 0) Then
            patternLEDList(190, 0) = R
            patternLEDList(190, 1) = G
            patternLEDList(190, 2) = B
            Button190.BackColor = sc.BackColor
        Else
            R = patternLEDList(190, 0)
            G = patternLEDList(190, 1)
            B = patternLEDList(190, 2)
            sc.BackColor = Button190.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button191_Click(sender As Object, e As EventArgs) Handles Button191.Click
        If (selec = 0) Then
            patternLEDList(191, 0) = R
            patternLEDList(191, 1) = G
            patternLEDList(191, 2) = B
            Button191.BackColor = sc.BackColor
        Else
            R = patternLEDList(191, 0)
            G = patternLEDList(191, 1)
            B = patternLEDList(191, 2)
            sc.BackColor = Button191.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button192_Click(sender As Object, e As EventArgs) Handles Button192.Click
        If (selec = 0) Then
            patternLEDList(192, 0) = R
            patternLEDList(192, 1) = G
            patternLEDList(192, 2) = B
            Button192.BackColor = sc.BackColor
        Else
            R = patternLEDList(192, 0)
            G = patternLEDList(192, 1)
            B = patternLEDList(192, 2)
            sc.BackColor = Button192.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button193_Click(sender As Object, e As EventArgs) Handles Button193.Click
        If (selec = 0) Then
            patternLEDList(193, 0) = R
            patternLEDList(193, 1) = G
            patternLEDList(193, 2) = B
            Button193.BackColor = sc.BackColor
        Else
            R = patternLEDList(193, 0)
            G = patternLEDList(193, 1)
            B = patternLEDList(193, 2)
            sc.BackColor = Button193.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button194_Click(sender As Object, e As EventArgs) Handles Button194.Click
        If (selec = 0) Then
            patternLEDList(194, 0) = R
            patternLEDList(194, 1) = G
            patternLEDList(194, 2) = B
            Button194.BackColor = sc.BackColor
        Else
            R = patternLEDList(194, 0)
            G = patternLEDList(194, 1)
            B = patternLEDList(194, 2)
            sc.BackColor = Button194.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button195_Click(sender As Object, e As EventArgs) Handles Button195.Click
        If (selec = 0) Then
            patternLEDList(195, 0) = R
            patternLEDList(195, 1) = G
            patternLEDList(195, 2) = B
            Button195.BackColor = sc.BackColor
        Else
            R = patternLEDList(195, 0)
            G = patternLEDList(195, 1)
            B = patternLEDList(195, 2)
            sc.BackColor = Button195.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button196_Click(sender As Object, e As EventArgs) Handles Button196.Click
        If (selec = 0) Then
            patternLEDList(196, 0) = R
            patternLEDList(196, 1) = G
            patternLEDList(196, 2) = B
            Button196.BackColor = sc.BackColor
        Else
            R = patternLEDList(196, 0)
            G = patternLEDList(196, 1)
            B = patternLEDList(196, 2)
            sc.BackColor = Button196.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button197_Click(sender As Object, e As EventArgs) Handles Button197.Click
        If (selec = 0) Then
            patternLEDList(197, 0) = R
            patternLEDList(197, 1) = G
            patternLEDList(197, 2) = B
            Button197.BackColor = sc.BackColor
        Else
            R = patternLEDList(197, 0)
            G = patternLEDList(197, 1)
            B = patternLEDList(197, 2)
            sc.BackColor = Button197.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button198_Click(sender As Object, e As EventArgs) Handles Button198.Click
        If (selec = 0) Then
            patternLEDList(198, 0) = R
            patternLEDList(198, 1) = G
            patternLEDList(198, 2) = B
            Button198.BackColor = sc.BackColor
        Else
            R = patternLEDList(198, 0)
            G = patternLEDList(198, 1)
            B = patternLEDList(198, 2)
            sc.BackColor = Button198.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button199_Click(sender As Object, e As EventArgs) Handles Button199.Click
        If (selec = 0) Then
            patternLEDList(199, 0) = R
            patternLEDList(199, 1) = G
            patternLEDList(199, 2) = B
            Button199.BackColor = sc.BackColor
        Else
            R = patternLEDList(199, 0)
            G = patternLEDList(199, 1)
            B = patternLEDList(199, 2)
            sc.BackColor = Button199.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Private Sub Button200_Click(sender As Object, e As EventArgs) Handles Button200.Click
        If (selec = 0) Then
            patternLEDList(200, 0) = R
            patternLEDList(200, 1) = G
            patternLEDList(200, 2) = B
            Button200.BackColor = sc.BackColor
        Else
            R = patternLEDList(200, 0)
            G = patternLEDList(200, 1)
            B = patternLEDList(200, 2)
            sc.BackColor = Button200.BackColor
            Label47.Text = R
            Label48.Text = G
            Label49.Text = B
        End If
        setarraydisply()
    End Sub
    Sub open()
        Dim fr As StreamReader
        fr = New StreamReader("C:\Windows\Temp\datacount546\datafdhgf.txt")
        readopen(fr)
        fr.Close()

        Dim k As Integer
        For k = 0 To 199
            read(k * 200)
            setbtncolor(k)
            setbtncolor2(k)
            setbtncolor3(k)
            setbtncolor4(k)
        Next

        frameAnimator.Maximum = frameCount.Value - 1
        frameAnimator.Value = 0
        Label42.Text = frameAnimator.Value + 1

        Button1.BackColor = Color.FromArgb(255, framesR(0), framesG(0), framesB(0))
        Button2.BackColor = Color.FromArgb(255, framesR(1), framesG(1), framesB(1))
        Button3.BackColor = Color.FromArgb(255, framesR(2), framesG(2), framesB(2))
        Button4.BackColor = Color.FromArgb(255, framesR(3), framesG(3), framesB(3))
        Button5.BackColor = Color.FromArgb(255, framesR(4), framesG(4), framesB(4))
        Button6.BackColor = Color.FromArgb(255, framesR(5), framesG(5), framesB(5))
        Button7.BackColor = Color.FromArgb(255, framesR(6), framesG(6), framesB(6))
        Button8.BackColor = Color.FromArgb(255, framesR(7), framesG(7), framesB(7))
        Button9.BackColor = Color.FromArgb(255, framesR(8), framesG(8), framesB(8))
        Button10.BackColor = Color.FromArgb(255, framesR(9), framesG(9), framesB(9))
        Button11.BackColor = Color.FromArgb(255, framesR(10), framesG(10), framesB(10))
        Button12.BackColor = Color.FromArgb(255, framesR(11), framesG(11), framesB(11))
        Button13.BackColor = Color.FromArgb(255, framesR(12), framesG(12), framesB(12))
        Button14.BackColor = Color.FromArgb(255, framesR(13), framesG(13), framesB(13))
        Button15.BackColor = Color.FromArgb(255, framesR(14), framesG(14), framesB(14))
        Button16.BackColor = Color.FromArgb(255, framesR(15), framesG(15), framesB(15))
        Button17.BackColor = Color.FromArgb(255, framesR(16), framesG(16), framesB(16))
        Button18.BackColor = Color.FromArgb(255, framesR(17), framesG(17), framesB(17))
        Button19.BackColor = Color.FromArgb(255, framesR(18), framesG(18), framesB(18))
        Button20.BackColor = Color.FromArgb(255, framesR(19), framesG(19), framesB(19))
        Button21.BackColor = Color.FromArgb(255, framesR(20), framesG(20), framesB(20))
        Button22.BackColor = Color.FromArgb(255, framesR(21), framesG(21), framesB(21))
        Button23.BackColor = Color.FromArgb(255, framesR(22), framesG(22), framesB(22))
        Button24.BackColor = Color.FromArgb(255, framesR(23), framesG(23), framesB(23))
        Button25.BackColor = Color.FromArgb(255, framesR(24), framesG(24), framesB(24))
        Button26.BackColor = Color.FromArgb(255, framesR(25), framesG(25), framesB(25))
        Button27.BackColor = Color.FromArgb(255, framesR(26), framesG(26), framesB(26))
        Button28.BackColor = Color.FromArgb(255, framesR(27), framesG(27), framesB(27))
        Button29.BackColor = Color.FromArgb(255, framesR(28), framesG(28), framesB(28))
        Button30.BackColor = Color.FromArgb(255, framesR(29), framesG(29), framesB(29))
        Button31.BackColor = Color.FromArgb(255, framesR(30), framesG(30), framesB(30))
        Button32.BackColor = Color.FromArgb(255, framesR(31), framesG(31), framesB(31))
        Button33.BackColor = Color.FromArgb(255, framesR(32), framesG(32), framesB(32))
        Button34.BackColor = Color.FromArgb(255, framesR(33), framesG(33), framesB(33))
        Button35.BackColor = Color.FromArgb(255, framesR(34), framesG(34), framesB(34))
        Button36.BackColor = Color.FromArgb(255, framesR(35), framesG(35), framesB(35))
        Button37.BackColor = Color.FromArgb(255, framesR(36), framesG(36), framesB(36))
        Button38.BackColor = Color.FromArgb(255, framesR(37), framesG(37), framesB(37))
        Button39.BackColor = Color.FromArgb(255, framesR(38), framesG(38), framesB(38))
        Button40.BackColor = Color.FromArgb(255, framesR(39), framesG(39), framesB(39))
        Button41.BackColor = Color.FromArgb(255, framesR(40), framesG(40), framesB(40))
        Button42.BackColor = Color.FromArgb(255, framesR(41), framesG(41), framesB(41))
        Button43.BackColor = Color.FromArgb(255, framesR(42), framesG(42), framesB(42))
        Button44.BackColor = Color.FromArgb(255, framesR(43), framesG(43), framesB(43))
        Button45.BackColor = Color.FromArgb(255, framesR(44), framesG(44), framesB(44))
        Button46.BackColor = Color.FromArgb(255, framesR(45), framesG(45), framesB(45))
        Button47.BackColor = Color.FromArgb(255, framesR(46), framesG(46), framesB(46))
        Button48.BackColor = Color.FromArgb(255, framesR(47), framesG(47), framesB(47))
        Button49.BackColor = Color.FromArgb(255, framesR(48), framesG(48), framesB(48))
        Button50.BackColor = Color.FromArgb(255, framesR(49), framesG(49), framesB(49))
        Button51.BackColor = Color.FromArgb(255, framesR(50), framesG(50), framesB(50))
        Button52.BackColor = Color.FromArgb(255, framesR(51), framesG(51), framesB(51))
        Button53.BackColor = Color.FromArgb(255, framesR(52), framesG(52), framesB(52))
        Button54.BackColor = Color.FromArgb(255, framesR(53), framesG(53), framesB(53))
        Button55.BackColor = Color.FromArgb(255, framesR(54), framesG(54), framesB(54))
        Button56.BackColor = Color.FromArgb(255, framesR(55), framesG(55), framesB(55))
        Button57.BackColor = Color.FromArgb(255, framesR(56), framesG(56), framesB(56))
        Button58.BackColor = Color.FromArgb(255, framesR(57), framesG(57), framesB(57))
        Button59.BackColor = Color.FromArgb(255, framesR(58), framesG(58), framesB(58))
        Button60.BackColor = Color.FromArgb(255, framesR(59), framesG(59), framesB(59))
        Button61.BackColor = Color.FromArgb(255, framesR(60), framesG(60), framesB(60))
        Button62.BackColor = Color.FromArgb(255, framesR(61), framesG(61), framesB(61))
        Button63.BackColor = Color.FromArgb(255, framesR(62), framesG(62), framesB(62))
        Button64.BackColor = Color.FromArgb(255, framesR(63), framesG(63), framesB(63))
        Button65.BackColor = Color.FromArgb(255, framesR(64), framesG(64), framesB(64))
        Button66.BackColor = Color.FromArgb(255, framesR(65), framesG(65), framesB(65))
        Button67.BackColor = Color.FromArgb(255, framesR(66), framesG(66), framesB(66))
        Button68.BackColor = Color.FromArgb(255, framesR(67), framesG(67), framesB(67))
        Button69.BackColor = Color.FromArgb(255, framesR(68), framesG(68), framesB(68))
        Button70.BackColor = Color.FromArgb(255, framesR(69), framesG(69), framesB(69))
        Button71.BackColor = Color.FromArgb(255, framesR(70), framesG(70), framesB(70))
        Button72.BackColor = Color.FromArgb(255, framesR(71), framesG(71), framesB(71))
        Button73.BackColor = Color.FromArgb(255, framesR(72), framesG(72), framesB(72))
        Button74.BackColor = Color.FromArgb(255, framesR(73), framesG(73), framesB(73))
        Button75.BackColor = Color.FromArgb(255, framesR(74), framesG(74), framesB(74))
        Button76.BackColor = Color.FromArgb(255, framesR(75), framesG(75), framesB(75))
        Button77.BackColor = Color.FromArgb(255, framesR(76), framesG(76), framesB(76))
        Button78.BackColor = Color.FromArgb(255, framesR(77), framesG(77), framesB(77))
        Button79.BackColor = Color.FromArgb(255, framesR(78), framesG(78), framesB(78))
        Button80.BackColor = Color.FromArgb(255, framesR(79), framesG(79), framesB(79))
        Button81.BackColor = Color.FromArgb(255, framesR(80), framesG(80), framesB(80))
        Button82.BackColor = Color.FromArgb(255, framesR(81), framesG(81), framesB(81))
        Button83.BackColor = Color.FromArgb(255, framesR(82), framesG(82), framesB(82))
        Button84.BackColor = Color.FromArgb(255, framesR(83), framesG(83), framesB(83))
        Button85.BackColor = Color.FromArgb(255, framesR(84), framesG(84), framesB(84))
        Button86.BackColor = Color.FromArgb(255, framesR(85), framesG(85), framesB(85))
        Button87.BackColor = Color.FromArgb(255, framesR(86), framesG(86), framesB(86))
        Button88.BackColor = Color.FromArgb(255, framesR(87), framesG(87), framesB(87))
        Button89.BackColor = Color.FromArgb(255, framesR(88), framesG(88), framesB(88))
        Button90.BackColor = Color.FromArgb(255, framesR(89), framesG(89), framesB(89))
        Button91.BackColor = Color.FromArgb(255, framesR(90), framesG(90), framesB(90))
        Button92.BackColor = Color.FromArgb(255, framesR(91), framesG(91), framesB(91))
        Button93.BackColor = Color.FromArgb(255, framesR(92), framesG(92), framesB(92))
        Button94.BackColor = Color.FromArgb(255, framesR(93), framesG(93), framesB(93))
        Button95.BackColor = Color.FromArgb(255, framesR(94), framesG(94), framesB(94))
        Button96.BackColor = Color.FromArgb(255, framesR(95), framesG(95), framesB(95))
        Button97.BackColor = Color.FromArgb(255, framesR(96), framesG(96), framesB(96))
        Button98.BackColor = Color.FromArgb(255, framesR(97), framesG(97), framesB(97))
        Button99.BackColor = Color.FromArgb(255, framesR(98), framesG(98), framesB(98))
        Button100.BackColor = Color.FromArgb(255, framesR(99), framesG(99), framesB(99))
        Button101.BackColor = Color.FromArgb(255, framesR(100), framesG(100), framesB(100))
        Button102.BackColor = Color.FromArgb(255, framesR(101), framesG(101), framesB(101))
        Button103.BackColor = Color.FromArgb(255, framesR(102), framesG(102), framesB(102))
        Button104.BackColor = Color.FromArgb(255, framesR(103), framesG(103), framesB(103))
        Button105.BackColor = Color.FromArgb(255, framesR(104), framesG(104), framesB(104))
        Button106.BackColor = Color.FromArgb(255, framesR(105), framesG(105), framesB(105))
        Button107.BackColor = Color.FromArgb(255, framesR(106), framesG(106), framesB(106))
        Button108.BackColor = Color.FromArgb(255, framesR(107), framesG(107), framesB(107))
        Button109.BackColor = Color.FromArgb(255, framesR(108), framesG(108), framesB(108))
        Button110.BackColor = Color.FromArgb(255, framesR(109), framesG(109), framesB(109))
        Button111.BackColor = Color.FromArgb(255, framesR(110), framesG(110), framesB(110))
        Button112.BackColor = Color.FromArgb(255, framesR(111), framesG(111), framesB(111))
        Button113.BackColor = Color.FromArgb(255, framesR(112), framesG(112), framesB(112))
        Button114.BackColor = Color.FromArgb(255, framesR(113), framesG(113), framesB(113))
        Button115.BackColor = Color.FromArgb(255, framesR(114), framesG(114), framesB(114))
        Button116.BackColor = Color.FromArgb(255, framesR(115), framesG(115), framesB(115))
        Button117.BackColor = Color.FromArgb(255, framesR(116), framesG(116), framesB(116))
        Button118.BackColor = Color.FromArgb(255, framesR(117), framesG(117), framesB(117))
        Button119.BackColor = Color.FromArgb(255, framesR(118), framesG(118), framesB(118))
        Button120.BackColor = Color.FromArgb(255, framesR(119), framesG(119), framesB(119))
        Button121.BackColor = Color.FromArgb(255, framesR(120), framesG(120), framesB(120))
        Button122.BackColor = Color.FromArgb(255, framesR(121), framesG(121), framesB(121))
        Button123.BackColor = Color.FromArgb(255, framesR(122), framesG(122), framesB(122))
        Button124.BackColor = Color.FromArgb(255, framesR(123), framesG(123), framesB(123))
        Button125.BackColor = Color.FromArgb(255, framesR(124), framesG(124), framesB(124))
        Button126.BackColor = Color.FromArgb(255, framesR(125), framesG(125), framesB(125))
        Button127.BackColor = Color.FromArgb(255, framesR(126), framesG(126), framesB(126))
        Button128.BackColor = Color.FromArgb(255, framesR(127), framesG(127), framesB(127))
        Button129.BackColor = Color.FromArgb(255, framesR(128), framesG(128), framesB(128))
        Button130.BackColor = Color.FromArgb(255, framesR(129), framesG(129), framesB(129))
        Button131.BackColor = Color.FromArgb(255, framesR(130), framesG(130), framesB(130))
        Button132.BackColor = Color.FromArgb(255, framesR(131), framesG(131), framesB(131))
        Button133.BackColor = Color.FromArgb(255, framesR(132), framesG(132), framesB(132))
        Button134.BackColor = Color.FromArgb(255, framesR(133), framesG(133), framesB(133))
        Button135.BackColor = Color.FromArgb(255, framesR(134), framesG(134), framesB(134))
        Button136.BackColor = Color.FromArgb(255, framesR(135), framesG(135), framesB(135))
        Button137.BackColor = Color.FromArgb(255, framesR(136), framesG(136), framesB(136))
        Button138.BackColor = Color.FromArgb(255, framesR(137), framesG(137), framesB(137))
        Button139.BackColor = Color.FromArgb(255, framesR(138), framesG(138), framesB(138))
        Button140.BackColor = Color.FromArgb(255, framesR(139), framesG(139), framesB(139))
        Button141.BackColor = Color.FromArgb(255, framesR(140), framesG(140), framesB(140))
        Button142.BackColor = Color.FromArgb(255, framesR(141), framesG(141), framesB(141))
        Button143.BackColor = Color.FromArgb(255, framesR(142), framesG(142), framesB(142))
        Button144.BackColor = Color.FromArgb(255, framesR(143), framesG(143), framesB(143))
        Button145.BackColor = Color.FromArgb(255, framesR(144), framesG(144), framesB(144))
        Button146.BackColor = Color.FromArgb(255, framesR(145), framesG(145), framesB(145))
        Button147.BackColor = Color.FromArgb(255, framesR(146), framesG(146), framesB(146))
        Button148.BackColor = Color.FromArgb(255, framesR(147), framesG(147), framesB(147))
        Button149.BackColor = Color.FromArgb(255, framesR(148), framesG(148), framesB(148))
        Button150.BackColor = Color.FromArgb(255, framesR(149), framesG(149), framesB(149))
        Button151.BackColor = Color.FromArgb(255, framesR(150), framesG(150), framesB(150))
        Button152.BackColor = Color.FromArgb(255, framesR(151), framesG(151), framesB(151))
        Button153.BackColor = Color.FromArgb(255, framesR(152), framesG(152), framesB(152))
        Button154.BackColor = Color.FromArgb(255, framesR(153), framesG(153), framesB(153))
        Button155.BackColor = Color.FromArgb(255, framesR(154), framesG(154), framesB(154))
        Button156.BackColor = Color.FromArgb(255, framesR(155), framesG(155), framesB(155))
        Button157.BackColor = Color.FromArgb(255, framesR(156), framesG(156), framesB(156))
        Button158.BackColor = Color.FromArgb(255, framesR(157), framesG(157), framesB(157))
        Button159.BackColor = Color.FromArgb(255, framesR(158), framesG(158), framesB(158))
        Button160.BackColor = Color.FromArgb(255, framesR(159), framesG(159), framesB(159))
        Button161.BackColor = Color.FromArgb(255, framesR(160), framesG(160), framesB(160))
        Button162.BackColor = Color.FromArgb(255, framesR(161), framesG(161), framesB(161))
        Button163.BackColor = Color.FromArgb(255, framesR(162), framesG(162), framesB(162))
        Button164.BackColor = Color.FromArgb(255, framesR(163), framesG(163), framesB(163))
        Button165.BackColor = Color.FromArgb(255, framesR(164), framesG(164), framesB(164))
        Button166.BackColor = Color.FromArgb(255, framesR(165), framesG(165), framesB(165))
        Button167.BackColor = Color.FromArgb(255, framesR(166), framesG(166), framesB(166))
        Button168.BackColor = Color.FromArgb(255, framesR(167), framesG(167), framesB(167))
        Button169.BackColor = Color.FromArgb(255, framesR(168), framesG(168), framesB(168))
        Button170.BackColor = Color.FromArgb(255, framesR(169), framesG(169), framesB(169))
        Button171.BackColor = Color.FromArgb(255, framesR(170), framesG(170), framesB(170))
        Button172.BackColor = Color.FromArgb(255, framesR(171), framesG(171), framesB(171))
        Button173.BackColor = Color.FromArgb(255, framesR(172), framesG(172), framesB(172))
        Button174.BackColor = Color.FromArgb(255, framesR(173), framesG(173), framesB(173))
        Button175.BackColor = Color.FromArgb(255, framesR(174), framesG(174), framesB(174))
        Button176.BackColor = Color.FromArgb(255, framesR(175), framesG(175), framesB(175))
        Button177.BackColor = Color.FromArgb(255, framesR(176), framesG(176), framesB(176))
        Button178.BackColor = Color.FromArgb(255, framesR(177), framesG(177), framesB(177))
        Button179.BackColor = Color.FromArgb(255, framesR(178), framesG(178), framesB(178))
        Button180.BackColor = Color.FromArgb(255, framesR(179), framesG(179), framesB(179))
        Button181.BackColor = Color.FromArgb(255, framesR(180), framesG(180), framesB(180))
        Button182.BackColor = Color.FromArgb(255, framesR(181), framesG(181), framesB(181))
        Button183.BackColor = Color.FromArgb(255, framesR(182), framesG(182), framesB(182))
        Button184.BackColor = Color.FromArgb(255, framesR(183), framesG(183), framesB(183))
        Button185.BackColor = Color.FromArgb(255, framesR(184), framesG(184), framesB(184))
        Button186.BackColor = Color.FromArgb(255, framesR(185), framesG(185), framesB(185))
        Button187.BackColor = Color.FromArgb(255, framesR(186), framesG(186), framesB(186))
        Button188.BackColor = Color.FromArgb(255, framesR(187), framesG(187), framesB(187))
        Button189.BackColor = Color.FromArgb(255, framesR(188), framesG(188), framesB(188))
        Button190.BackColor = Color.FromArgb(255, framesR(189), framesG(189), framesB(189))
        Button191.BackColor = Color.FromArgb(255, framesR(190), framesG(190), framesB(190))
        Button192.BackColor = Color.FromArgb(255, framesR(191), framesG(191), framesB(191))
        Button193.BackColor = Color.FromArgb(255, framesR(192), framesG(192), framesB(192))
        Button194.BackColor = Color.FromArgb(255, framesR(193), framesG(193), framesB(193))
        Button195.BackColor = Color.FromArgb(255, framesR(194), framesG(194), framesB(194))
        Button196.BackColor = Color.FromArgb(255, framesR(195), framesG(195), framesB(195))
        Button197.BackColor = Color.FromArgb(255, framesR(196), framesG(196), framesB(196))
        Button198.BackColor = Color.FromArgb(255, framesR(197), framesG(197), framesB(197))
        Button199.BackColor = Color.FromArgb(255, framesR(198), framesG(198), framesB(198))
        Button200.BackColor = Color.FromArgb(255, framesR(199), framesG(199), framesB(199))


        read(0)
    End Sub

    Private Sub Example1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example2ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example3ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example4ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example5ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example6ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example7ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Example8ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SaveColorBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveColorBoxToolStripMenuItem.Click
        Dim fw As StreamWriter
        Dim result As DialogResult
        result = SaveFileDialog2.ShowDialog
        If (result = Windows.Forms.DialogResult.OK) Then
            fw = New StreamWriter(SaveFileDialog2.FileName, False)

            For c = 1 To 30
                fw.WriteLine(customColorList(c, 0))
                fw.WriteLine(customColorList(c, 1))
                fw.WriteLine(customColorList(c, 2))
            Next

            fw.Close()
        End If
    End Sub

    Private Sub OpenColorBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenColorBoxToolStripMenuItem.Click
        Dim fr As StreamReader
        Dim result As DialogResult
        result = OpenFileDialog2.ShowDialog
        If (result = Windows.Forms.DialogResult.OK) Then
            fr = New StreamReader(OpenFileDialog2.FileName)
            For c = 1 To 30
                customColorList(c, 0) = fr.ReadLine
                customColorList(c, 1) = fr.ReadLine
                customColorList(c, 2) = fr.ReadLine
            Next

            fr.Close()
        End If
        ccs = 1
        R = customColorList(1, 0)
        G = customColorList(1, 1)
        B = customColorList(1, 2)
        sc.BackColor = Color.FromArgb(255, R, G, B)
        Label47.Text = R
        Label48.Text = G
        Label49.Text = B

        Button285.BackColor = Color.FromArgb(255, customColorList(1, 0), customColorList(1, 1), customColorList(1, 2))
        Button284.BackColor = Color.FromArgb(255, customColorList(2, 0), customColorList(2, 1), customColorList(2, 2))
        Button283.BackColor = Color.FromArgb(255, customColorList(3, 0), customColorList(3, 1), customColorList(3, 2))
        Button282.BackColor = Color.FromArgb(255, customColorList(4, 0), customColorList(4, 1), customColorList(4, 2))
        Button275.BackColor = Color.FromArgb(255, customColorList(5, 0), customColorList(5, 1), customColorList(5, 2))
        Button287.BackColor = Color.FromArgb(255, customColorList(6, 0), customColorList(6, 1), customColorList(6, 2))
        Button286.BackColor = Color.FromArgb(255, customColorList(7, 0), customColorList(7, 1), customColorList(7, 2))
        Button288.BackColor = Color.FromArgb(255, customColorList(8, 0), customColorList(8, 1), customColorList(8, 2))
        Button301.BackColor = Color.FromArgb(255, customColorList(9, 0), customColorList(9, 1), customColorList(9, 2))
        Button300.BackColor = Color.FromArgb(255, customColorList(10, 0), customColorList(10, 1), customColorList(10, 2))
        Button311.BackColor = Color.FromArgb(255, customColorList(11, 0), customColorList(11, 1), customColorList(11, 2))
        Button310.BackColor = Color.FromArgb(255, customColorList(12, 0), customColorList(12, 1), customColorList(12, 2))
        Button309.BackColor = Color.FromArgb(255, customColorList(13, 0), customColorList(13, 1), customColorList(13, 2))
        Button308.BackColor = Color.FromArgb(255, customColorList(14, 0), customColorList(14, 1), customColorList(14, 2))
        Button307.BackColor = Color.FromArgb(255, customColorList(15, 0), customColorList(15, 1), customColorList(15, 2))
        Button306.BackColor = Color.FromArgb(255, customColorList(16, 0), customColorList(16, 1), customColorList(16, 2))
        Button305.BackColor = Color.FromArgb(255, customColorList(17, 0), customColorList(17, 1), customColorList(17, 2))
        Button304.BackColor = Color.FromArgb(255, customColorList(18, 0), customColorList(18, 1), customColorList(18, 2))
        Button303.BackColor = Color.FromArgb(255, customColorList(19, 0), customColorList(19, 1), customColorList(19, 2))
        Button302.BackColor = Color.FromArgb(255, customColorList(20, 0), customColorList(20, 1), customColorList(20, 2))
        Button321.BackColor = Color.FromArgb(255, customColorList(21, 0), customColorList(21, 1), customColorList(21, 2))
        Button320.BackColor = Color.FromArgb(255, customColorList(22, 0), customColorList(22, 1), customColorList(22, 2))
        Button319.BackColor = Color.FromArgb(255, customColorList(23, 0), customColorList(23, 1), customColorList(23, 2))
        Button318.BackColor = Color.FromArgb(255, customColorList(24, 0), customColorList(24, 1), customColorList(24, 2))
        Button317.BackColor = Color.FromArgb(255, customColorList(25, 0), customColorList(25, 1), customColorList(25, 2))
        Button316.BackColor = Color.FromArgb(255, customColorList(26, 0), customColorList(26, 1), customColorList(26, 2))
        Button315.BackColor = Color.FromArgb(255, customColorList(27, 0), customColorList(27, 1), customColorList(27, 2))
        Button314.BackColor = Color.FromArgb(255, customColorList(28, 0), customColorList(28, 1), customColorList(28, 2))
        Button313.BackColor = Color.FromArgb(255, customColorList(29, 0), customColorList(29, 1), customColorList(29, 2))
        Button312.BackColor = Color.FromArgb(255, customColorList(30, 0), customColorList(30, 1), customColorList(30, 2))


    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        tbs = 1
        TrackBar1.Maximum = 255
        TrackBar2.Maximum = 255
        TrackBar3.Maximum = 255

        Label37.Text = TrackBar1.Value * tbs
        Label36.Text = TrackBar2.Value * tbs
        Label35.Text = TrackBar3.Value * tbs
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        tbs = 3
        TrackBar1.Maximum = 85
        TrackBar2.Maximum = 85
        TrackBar3.Maximum = 85

        Label37.Text = TrackBar1.Value * tbs
        Label36.Text = TrackBar2.Value * tbs
        Label35.Text = TrackBar3.Value * tbs
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        tbs = 5
        TrackBar1.Maximum = 51
        TrackBar2.Maximum = 51
        TrackBar3.Maximum = 51

        Label37.Text = TrackBar1.Value * tbs
        Label36.Text = TrackBar2.Value * tbs
        Label35.Text = TrackBar3.Value * tbs
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        tbs = 15
        TrackBar1.Maximum = 17
        TrackBar2.Maximum = 17
        TrackBar3.Maximum = 17

        Label37.Text = TrackBar1.Value * tbs
        Label36.Text = TrackBar2.Value * tbs
        Label35.Text = TrackBar3.Value * tbs
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        tbs = 17
        TrackBar1.Maximum = 15
        TrackBar2.Maximum = 15
        TrackBar3.Maximum = 15

        Label37.Text = TrackBar1.Value * tbs
        Label36.Text = TrackBar2.Value * tbs
        Label35.Text = TrackBar3.Value * tbs

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutPS.ShowDialog()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripAdd_Click(sender As Object, e As EventArgs) Handles ToolStripAdd.Click
        add((frameAnimator.Value) * 200)
        setbtncolor(frameAnimator.Value)
        setbtncolor2(frameAnimator.Value)
        setbtncolor3(frameAnimator.Value)
        setbtncolor4(frameAnimator.Value)
    End Sub

    Private Sub ToolStripGenerate_Click(sender As Object, e As EventArgs) Handles ToolStripGenerate.Click
        If (TextBox1.Text = Nothing) Then
            MsgBox("Please Enter Design Name", MsgBoxStyle.Exclamation, "Error")
        Else
            CodeView.Show()


        End If
    End Sub



    Private Sub CopyToolStripButton_Click(sender As Object, e As EventArgs) Handles CopyToolStripButton.Click
        copy = frameAnimator.Value * 200
    End Sub

    Private Sub PasteToolStripButton_Click(sender As Object, e As EventArgs) Handles PasteToolStripButton.Click
        read(copy)
    End Sub

    Private Sub ToolStripButtonLeft_Click(sender As Object, e As EventArgs) Handles ToolStripButtonLeft.Click
        colorList(1) = Button1.BackColor
        moveColorList(1, 0) = patternLEDList(1, 0)
        moveColorList(1, 1) = patternLEDList(1, 1)
        moveColorList(1, 2) = patternLEDList(1, 2)
        colorList(2) = Button2.BackColor
        moveColorList(2, 0) = patternLEDList(2, 0)
        moveColorList(2, 1) = patternLEDList(2, 1)
        moveColorList(2, 2) = patternLEDList(2, 2)
        colorList(3) = Button3.BackColor
        moveColorList(3, 0) = patternLEDList(3, 0)
        moveColorList(3, 1) = patternLEDList(3, 1)
        moveColorList(3, 2) = patternLEDList(3, 2)
        colorList(4) = Button4.BackColor
        moveColorList(4, 0) = patternLEDList(4, 0)
        moveColorList(4, 1) = patternLEDList(4, 1)
        moveColorList(4, 2) = patternLEDList(4, 2)
        colorList(5) = Button5.BackColor
        moveColorList(5, 0) = patternLEDList(5, 0)
        moveColorList(5, 1) = patternLEDList(5, 1)
        moveColorList(5, 2) = patternLEDList(5, 2)
        colorList(6) = Button6.BackColor
        moveColorList(6, 0) = patternLEDList(6, 0)
        moveColorList(6, 1) = patternLEDList(6, 1)
        moveColorList(6, 2) = patternLEDList(6, 2)
        colorList(7) = Button7.BackColor
        moveColorList(7, 0) = patternLEDList(7, 0)
        moveColorList(7, 1) = patternLEDList(7, 1)
        moveColorList(7, 2) = patternLEDList(7, 2)
        colorList(8) = Button8.BackColor
        moveColorList(8, 0) = patternLEDList(8, 0)
        moveColorList(8, 1) = patternLEDList(8, 1)
        moveColorList(8, 2) = patternLEDList(8, 2)

        leftr1()
        leftr2()
        leftr3()
        leftr4()
        leftr5()
        leftr6()
        leftr7()
        leftr8()

        Button193.BackColor = colorList(1)
        patternLEDList(193, 0) = moveColorList(1, 0)
        patternLEDList(193, 1) = moveColorList(1, 1)
        patternLEDList(193, 2) = moveColorList(1, 2)
        Button194.BackColor = colorList(2)
        patternLEDList(194, 0) = moveColorList(2, 0)
        patternLEDList(194, 1) = moveColorList(2, 1)
        patternLEDList(194, 2) = moveColorList(2, 2)
        Button195.BackColor = colorList(3)
        patternLEDList(195, 0) = moveColorList(3, 0)
        patternLEDList(195, 1) = moveColorList(3, 1)
        patternLEDList(195, 2) = moveColorList(3, 2)
        Button196.BackColor = colorList(4)
        patternLEDList(196, 0) = moveColorList(4, 0)
        patternLEDList(196, 1) = moveColorList(4, 1)
        patternLEDList(196, 2) = moveColorList(4, 2)
        Button197.BackColor = colorList(5)
        patternLEDList(197, 0) = moveColorList(5, 0)
        patternLEDList(197, 1) = moveColorList(5, 1)
        patternLEDList(197, 2) = moveColorList(5, 2)
        Button198.BackColor = colorList(6)
        patternLEDList(198, 0) = moveColorList(6, 0)
        patternLEDList(198, 1) = moveColorList(6, 1)
        patternLEDList(198, 2) = moveColorList(6, 2)
        Button199.BackColor = colorList(7)
        patternLEDList(199, 0) = moveColorList(7, 0)
        patternLEDList(199, 1) = moveColorList(7, 1)
        patternLEDList(199, 2) = moveColorList(7, 2)
        Button200.BackColor = colorList(8)
        patternLEDList(200, 0) = moveColorList(8, 0)
        patternLEDList(200, 1) = moveColorList(8, 1)
        patternLEDList(200, 2) = moveColorList(8, 2)

        setarraydisply()


    End Sub

    Private Sub LeftToolStripButton5_Click(sender As Object, e As EventArgs) Handles LeftToolStripButton5.Click
        leftr1()
        leftr2()
        leftr3()
        leftr4()
        leftr5()
        leftr6()
        leftr7()
        leftr8()
        setarraydisply()
    End Sub

    Private Sub RightToolStripButton6_Click(sender As Object, e As EventArgs) Handles RightToolStripButton6.Click
        rightr1()
        rightr2()
        rightr3()
        rightr4()
        rightr5()
        rightr6()
        rightr7()
        rightr8()
        setarraydisply()
    End Sub

    Private Sub UpToolStripButton7_Click(sender As Object, e As EventArgs) Handles UpToolStripButton7.Click
        upc1()
        upc2()
        upc3()
        upc4()
        upc5()
        upc6()
        upc7()
        upc8()
        upc9()
        upc10()
        upc11()
        upc12()
        upc13()
        upc14()
        upc15()
        upc16()
        upc17()
        upc18()
        upc19()
        upc20()
        upc21()
        upc22()
        upc23()
        upc24()
        upc25()
        setarraydisply()
    End Sub

    Private Sub DownToolStripButton8_Click(sender As Object, e As EventArgs) Handles DownToolStripButton8.Click
        downc1()
        downc2()
        downc3()
        downc4()
        downc5()
        downc6()
        downc7()
        downc8()
        downc9()
        downc10()
        downc11()
        downc12()
        downc13()
        downc14()
        downc15()
        downc16()
        downc17()
        downc18()
        downc19()
        downc20()
        downc21()
        downc22()
        downc23()
        downc24()
        downc25()
        setarraydisply()
    End Sub

    Private Sub ToolStripButtonUp_Click(sender As Object, e As EventArgs) Handles ToolStripButtonUp.Click
        colorList(1) = Button1.BackColor
        moveColorList(1, 0) = patternLEDList(1, 0)
        moveColorList(1, 1) = patternLEDList(1, 1)
        moveColorList(1, 2) = patternLEDList(1, 2)
        colorList(2) = Button16.BackColor
        moveColorList(2, 0) = patternLEDList(16, 0)
        moveColorList(2, 1) = patternLEDList(16, 1)
        moveColorList(2, 2) = patternLEDList(16, 2)
        colorList(3) = Button17.BackColor
        moveColorList(3, 0) = patternLEDList(17, 0)
        moveColorList(3, 1) = patternLEDList(17, 1)
        moveColorList(3, 2) = patternLEDList(17, 2)
        colorList(4) = Button32.BackColor
        moveColorList(4, 0) = patternLEDList(32, 0)
        moveColorList(4, 1) = patternLEDList(32, 1)
        moveColorList(4, 2) = patternLEDList(32, 2)
        colorList(5) = Button33.BackColor
        moveColorList(5, 0) = patternLEDList(33, 0)
        moveColorList(5, 1) = patternLEDList(33, 1)
        moveColorList(5, 2) = patternLEDList(33, 2)
        colorList(6) = Button48.BackColor
        moveColorList(6, 0) = patternLEDList(48, 0)
        moveColorList(6, 1) = patternLEDList(48, 1)
        moveColorList(6, 2) = patternLEDList(48, 2)
        colorList(7) = Button49.BackColor
        moveColorList(7, 0) = patternLEDList(49, 0)
        moveColorList(7, 1) = patternLEDList(49, 1)
        moveColorList(7, 2) = patternLEDList(49, 2)
        colorList(8) = Button64.BackColor
        moveColorList(8, 0) = patternLEDList(64, 0)
        moveColorList(8, 1) = patternLEDList(64, 1)
        moveColorList(8, 2) = patternLEDList(64, 2)
        colorList(9) = Button65.BackColor
        moveColorList(9, 0) = patternLEDList(65, 0)
        moveColorList(9, 1) = patternLEDList(65, 1)
        moveColorList(9, 2) = patternLEDList(65, 2)
        colorList(10) = Button80.BackColor
        moveColorList(10, 0) = patternLEDList(80, 0)
        moveColorList(10, 1) = patternLEDList(80, 1)
        moveColorList(10, 2) = patternLEDList(80, 2)
        colorList(11) = Button81.BackColor
        moveColorList(11, 0) = patternLEDList(81, 0)
        moveColorList(11, 1) = patternLEDList(81, 1)
        moveColorList(11, 2) = patternLEDList(81, 2)
        colorList(12) = Button96.BackColor
        moveColorList(12, 0) = patternLEDList(96, 0)
        moveColorList(12, 1) = patternLEDList(96, 1)
        moveColorList(12, 2) = patternLEDList(96, 2)
        colorList(13) = Button97.BackColor
        moveColorList(13, 0) = patternLEDList(97, 0)
        moveColorList(13, 1) = patternLEDList(97, 1)
        moveColorList(13, 2) = patternLEDList(97, 2)
        colorList(14) = Button112.BackColor
        moveColorList(14, 0) = patternLEDList(112, 0)
        moveColorList(14, 1) = patternLEDList(112, 1)
        moveColorList(14, 2) = patternLEDList(112, 2)
        colorList(15) = Button113.BackColor
        moveColorList(15, 0) = patternLEDList(113, 0)
        moveColorList(15, 1) = patternLEDList(113, 1)
        moveColorList(15, 2) = patternLEDList(113, 2)
        colorList(16) = Button128.BackColor
        moveColorList(16, 0) = patternLEDList(128, 0)
        moveColorList(16, 1) = patternLEDList(128, 1)
        moveColorList(16, 2) = patternLEDList(128, 2)
        colorList(17) = Button129.BackColor
        moveColorList(17, 0) = patternLEDList(129, 0)
        moveColorList(17, 1) = patternLEDList(129, 1)
        moveColorList(17, 2) = patternLEDList(129, 2)
        colorList(18) = Button144.BackColor
        moveColorList(18, 0) = patternLEDList(144, 0)
        moveColorList(18, 1) = patternLEDList(144, 1)
        moveColorList(18, 2) = patternLEDList(144, 2)
        colorList(19) = Button145.BackColor
        moveColorList(19, 0) = patternLEDList(145, 0)
        moveColorList(19, 1) = patternLEDList(145, 1)
        moveColorList(19, 2) = patternLEDList(145, 2)
        colorList(20) = Button160.BackColor
        moveColorList(20, 0) = patternLEDList(160, 0)
        moveColorList(20, 1) = patternLEDList(160, 1)
        moveColorList(20, 2) = patternLEDList(160, 2)
        colorList(21) = Button161.BackColor
        moveColorList(21, 0) = patternLEDList(161, 0)
        moveColorList(21, 1) = patternLEDList(161, 1)
        moveColorList(21, 2) = patternLEDList(161, 2)
        colorList(22) = Button176.BackColor
        moveColorList(22, 0) = patternLEDList(176, 0)
        moveColorList(22, 1) = patternLEDList(176, 1)
        moveColorList(22, 2) = patternLEDList(176, 2)
        colorList(23) = Button177.BackColor
        moveColorList(23, 0) = patternLEDList(177, 0)
        moveColorList(23, 1) = patternLEDList(177, 1)
        moveColorList(23, 2) = patternLEDList(177, 2)
        colorList(24) = Button192.BackColor
        moveColorList(24, 0) = patternLEDList(192, 0)
        moveColorList(24, 1) = patternLEDList(192, 1)
        moveColorList(24, 2) = patternLEDList(192, 2)
        colorList(25) = Button193.BackColor
        moveColorList(25, 0) = patternLEDList(193, 0)
        moveColorList(25, 1) = patternLEDList(193, 1)
        moveColorList(25, 2) = patternLEDList(193, 2)

        upc1()
        upc2()
        upc3()
        upc4()
        upc5()
        upc6()
        upc7()
        upc8()
        upc9()
        upc10()
        upc11()
        upc12()
        upc13()
        upc14()
        upc15()
        upc16()
        upc17()
        upc18()
        upc19()
        upc20()
        upc21()
        upc22()
        upc23()
        upc24()
        upc25()


        Button8.BackColor = colorList(1)
        patternLEDList(8, 0) = moveColorList(1, 0)
        patternLEDList(8, 1) = moveColorList(1, 1)
        patternLEDList(8, 2) = moveColorList(1, 2)
        Button9.BackColor = colorList(2)
        patternLEDList(9, 0) = moveColorList(2, 0)
        patternLEDList(9, 1) = moveColorList(2, 1)
        patternLEDList(9, 2) = moveColorList(2, 2)
        Button24.BackColor = colorList(3)
        patternLEDList(24, 0) = moveColorList(3, 0)
        patternLEDList(24, 1) = moveColorList(3, 1)
        patternLEDList(24, 2) = moveColorList(3, 2)
        Button25.BackColor = colorList(4)
        patternLEDList(25, 0) = moveColorList(4, 0)
        patternLEDList(25, 1) = moveColorList(4, 1)
        patternLEDList(25, 2) = moveColorList(4, 2)
        Button40.BackColor = colorList(5)
        patternLEDList(40, 0) = moveColorList(5, 0)
        patternLEDList(40, 1) = moveColorList(5, 1)
        patternLEDList(40, 2) = moveColorList(5, 2)
        Button41.BackColor = colorList(6)
        patternLEDList(41, 0) = moveColorList(6, 0)
        patternLEDList(41, 1) = moveColorList(6, 1)
        patternLEDList(41, 2) = moveColorList(6, 2)
        Button56.BackColor = colorList(7)
        patternLEDList(56, 0) = moveColorList(7, 0)
        patternLEDList(56, 1) = moveColorList(7, 1)
        patternLEDList(56, 2) = moveColorList(7, 2)
        Button57.BackColor = colorList(8)
        patternLEDList(57, 0) = moveColorList(8, 0)
        patternLEDList(57, 1) = moveColorList(8, 1)
        patternLEDList(57, 2) = moveColorList(8, 2)
        Button72.BackColor = colorList(9)
        patternLEDList(72, 0) = moveColorList(9, 0)
        patternLEDList(72, 1) = moveColorList(9, 1)
        patternLEDList(72, 2) = moveColorList(9, 2)
        Button73.BackColor = colorList(10)
        patternLEDList(73, 0) = moveColorList(10, 0)
        patternLEDList(73, 1) = moveColorList(10, 1)
        patternLEDList(73, 2) = moveColorList(10, 2)
        Button88.BackColor = colorList(11)
        patternLEDList(88, 0) = moveColorList(11, 0)
        patternLEDList(88, 1) = moveColorList(11, 1)
        patternLEDList(88, 2) = moveColorList(11, 2)
        Button89.BackColor = colorList(12)
        patternLEDList(89, 0) = moveColorList(12, 0)
        patternLEDList(89, 1) = moveColorList(12, 1)
        patternLEDList(89, 2) = moveColorList(12, 2)
        Button104.BackColor = colorList(13)
        patternLEDList(104, 0) = moveColorList(13, 0)
        patternLEDList(104, 1) = moveColorList(13, 1)
        patternLEDList(104, 2) = moveColorList(13, 2)
        Button105.BackColor = colorList(14)
        patternLEDList(105, 0) = moveColorList(14, 0)
        patternLEDList(105, 1) = moveColorList(14, 1)
        patternLEDList(105, 2) = moveColorList(14, 2)
        Button120.BackColor = colorList(15)
        patternLEDList(120, 0) = moveColorList(15, 0)
        patternLEDList(120, 1) = moveColorList(15, 1)
        patternLEDList(120, 2) = moveColorList(15, 2)
        Button121.BackColor = colorList(16)
        patternLEDList(121, 0) = moveColorList(16, 0)
        patternLEDList(121, 1) = moveColorList(16, 1)
        patternLEDList(121, 2) = moveColorList(16, 2)
        Button136.BackColor = colorList(17)
        patternLEDList(136, 0) = moveColorList(17, 0)
        patternLEDList(136, 1) = moveColorList(17, 1)
        patternLEDList(136, 2) = moveColorList(17, 2)
        Button137.BackColor = colorList(18)
        patternLEDList(137, 0) = moveColorList(18, 0)
        patternLEDList(137, 1) = moveColorList(18, 1)
        patternLEDList(137, 2) = moveColorList(18, 2)
        Button152.BackColor = colorList(19)
        patternLEDList(152, 0) = moveColorList(19, 0)
        patternLEDList(152, 1) = moveColorList(19, 1)
        patternLEDList(152, 2) = moveColorList(19, 2)
        Button153.BackColor = colorList(20)
        patternLEDList(153, 0) = moveColorList(20, 0)
        patternLEDList(153, 1) = moveColorList(20, 1)
        patternLEDList(153, 2) = moveColorList(20, 2)
        Button168.BackColor = colorList(21)
        patternLEDList(168, 0) = moveColorList(21, 0)
        patternLEDList(168, 1) = moveColorList(21, 1)
        patternLEDList(168, 2) = moveColorList(21, 2)
        Button169.BackColor = colorList(22)
        patternLEDList(169, 0) = moveColorList(22, 0)
        patternLEDList(169, 1) = moveColorList(22, 1)
        patternLEDList(169, 2) = moveColorList(22, 2)
        Button184.BackColor = colorList(23)
        patternLEDList(184, 0) = moveColorList(23, 0)
        patternLEDList(184, 1) = moveColorList(23, 1)
        patternLEDList(184, 2) = moveColorList(23, 2)
        Button185.BackColor = colorList(24)
        patternLEDList(185, 0) = moveColorList(24, 0)
        patternLEDList(185, 1) = moveColorList(24, 1)
        patternLEDList(185, 2) = moveColorList(24, 2)
        Button200.BackColor = colorList(25)
        patternLEDList(200, 0) = moveColorList(25, 0)
        patternLEDList(200, 1) = moveColorList(25, 1)
        patternLEDList(200, 2) = moveColorList(25, 2)

        setarraydisply()
    End Sub

    Private Sub ToolStripButtonDown_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDown.Click
        colorList(1) = Button8.BackColor
        moveColorList(1, 0) = patternLEDList(8, 0)
        moveColorList(1, 1) = patternLEDList(8, 1)
        moveColorList(1, 2) = patternLEDList(8, 2)
        colorList(2) = Button9.BackColor
        moveColorList(2, 0) = patternLEDList(9, 0)
        moveColorList(2, 1) = patternLEDList(9, 1)
        moveColorList(2, 2) = patternLEDList(9, 2)
        colorList(3) = Button24.BackColor
        moveColorList(3, 0) = patternLEDList(24, 0)
        moveColorList(3, 1) = patternLEDList(24, 1)
        moveColorList(3, 2) = patternLEDList(24, 2)
        colorList(4) = Button25.BackColor
        moveColorList(4, 0) = patternLEDList(25, 0)
        moveColorList(4, 1) = patternLEDList(25, 1)
        moveColorList(4, 2) = patternLEDList(25, 2)
        colorList(5) = Button40.BackColor
        moveColorList(5, 0) = patternLEDList(40, 0)
        moveColorList(5, 1) = patternLEDList(40, 1)
        moveColorList(5, 2) = patternLEDList(40, 2)
        colorList(6) = Button41.BackColor
        moveColorList(6, 0) = patternLEDList(41, 0)
        moveColorList(6, 1) = patternLEDList(41, 1)
        moveColorList(6, 2) = patternLEDList(41, 2)
        colorList(7) = Button56.BackColor
        moveColorList(7, 0) = patternLEDList(56, 0)
        moveColorList(7, 1) = patternLEDList(56, 1)
        moveColorList(7, 2) = patternLEDList(56, 2)
        colorList(8) = Button57.BackColor
        moveColorList(8, 0) = patternLEDList(57, 0)
        moveColorList(8, 1) = patternLEDList(57, 1)
        moveColorList(8, 2) = patternLEDList(57, 2)
        colorList(9) = Button72.BackColor
        moveColorList(9, 0) = patternLEDList(72, 0)
        moveColorList(9, 1) = patternLEDList(72, 1)
        moveColorList(9, 2) = patternLEDList(72, 2)
        colorList(10) = Button73.BackColor
        moveColorList(10, 0) = patternLEDList(73, 0)
        moveColorList(10, 1) = patternLEDList(73, 1)
        moveColorList(10, 2) = patternLEDList(73, 2)
        colorList(11) = Button88.BackColor
        moveColorList(11, 0) = patternLEDList(88, 0)
        moveColorList(11, 1) = patternLEDList(88, 1)
        moveColorList(11, 2) = patternLEDList(88, 2)
        colorList(12) = Button89.BackColor
        moveColorList(12, 0) = patternLEDList(89, 0)
        moveColorList(12, 1) = patternLEDList(89, 1)
        moveColorList(12, 2) = patternLEDList(89, 2)
        colorList(13) = Button104.BackColor
        moveColorList(13, 0) = patternLEDList(104, 0)
        moveColorList(13, 1) = patternLEDList(104, 1)
        moveColorList(13, 2) = patternLEDList(104, 2)
        colorList(14) = Button105.BackColor
        moveColorList(14, 0) = patternLEDList(105, 0)
        moveColorList(14, 1) = patternLEDList(105, 1)
        moveColorList(14, 2) = patternLEDList(105, 2)
        colorList(15) = Button120.BackColor
        moveColorList(15, 0) = patternLEDList(120, 0)
        moveColorList(15, 1) = patternLEDList(120, 1)
        moveColorList(15, 2) = patternLEDList(120, 2)
        colorList(16) = Button121.BackColor
        moveColorList(16, 0) = patternLEDList(121, 0)
        moveColorList(16, 1) = patternLEDList(121, 1)
        moveColorList(16, 2) = patternLEDList(121, 2)
        colorList(17) = Button136.BackColor
        moveColorList(17, 0) = patternLEDList(136, 0)
        moveColorList(17, 1) = patternLEDList(136, 1)
        moveColorList(17, 2) = patternLEDList(136, 2)
        colorList(18) = Button137.BackColor
        moveColorList(18, 0) = patternLEDList(137, 0)
        moveColorList(18, 1) = patternLEDList(137, 1)
        moveColorList(18, 2) = patternLEDList(137, 2)
        colorList(19) = Button152.BackColor
        moveColorList(19, 0) = patternLEDList(152, 0)
        moveColorList(19, 1) = patternLEDList(152, 1)
        moveColorList(19, 2) = patternLEDList(152, 2)
        colorList(20) = Button153.BackColor
        moveColorList(20, 0) = patternLEDList(153, 0)
        moveColorList(20, 1) = patternLEDList(153, 1)
        moveColorList(20, 2) = patternLEDList(153, 2)
        colorList(21) = Button168.BackColor
        moveColorList(21, 0) = patternLEDList(168, 0)
        moveColorList(21, 1) = patternLEDList(168, 1)
        moveColorList(21, 2) = patternLEDList(168, 2)
        colorList(22) = Button169.BackColor
        moveColorList(22, 0) = patternLEDList(169, 0)
        moveColorList(22, 1) = patternLEDList(169, 1)
        moveColorList(22, 2) = patternLEDList(169, 2)
        colorList(23) = Button184.BackColor
        moveColorList(23, 0) = patternLEDList(184, 0)
        moveColorList(23, 1) = patternLEDList(184, 1)
        moveColorList(23, 2) = patternLEDList(184, 2)
        colorList(24) = Button185.BackColor
        moveColorList(24, 0) = patternLEDList(185, 0)
        moveColorList(24, 1) = patternLEDList(185, 1)
        moveColorList(24, 2) = patternLEDList(185, 2)
        colorList(25) = Button200.BackColor
        moveColorList(25, 0) = patternLEDList(200, 0)
        moveColorList(25, 1) = patternLEDList(200, 1)
        moveColorList(25, 2) = patternLEDList(200, 2)


        downc1()
        downc2()
        downc3()
        downc4()
        downc5()
        downc6()
        downc7()
        downc8()
        downc9()
        downc10()
        downc11()
        downc12()
        downc13()
        downc14()
        downc15()
        downc16()
        downc17()
        downc18()
        downc19()
        downc20()
        downc21()
        downc22()
        downc23()
        downc24()
        downc25()

        Button1.BackColor = colorList(1)
        patternLEDList(1, 0) = moveColorList(1, 0)
        patternLEDList(1, 1) = moveColorList(1, 1)
        patternLEDList(1, 2) = moveColorList(1, 2)
        Button16.BackColor = colorList(2)
        patternLEDList(16, 0) = moveColorList(2, 0)
        patternLEDList(16, 1) = moveColorList(2, 1)
        patternLEDList(16, 2) = moveColorList(2, 2)
        Button17.BackColor = colorList(3)
        patternLEDList(17, 0) = moveColorList(3, 0)
        patternLEDList(17, 1) = moveColorList(3, 1)
        patternLEDList(17, 2) = moveColorList(3, 2)
        Button32.BackColor = colorList(4)
        patternLEDList(32, 0) = moveColorList(4, 0)
        patternLEDList(32, 1) = moveColorList(4, 1)
        patternLEDList(32, 2) = moveColorList(4, 2)
        Button33.BackColor = colorList(5)
        patternLEDList(33, 0) = moveColorList(5, 0)
        patternLEDList(33, 1) = moveColorList(5, 1)
        patternLEDList(33, 2) = moveColorList(5, 2)
        Button48.BackColor = colorList(6)
        patternLEDList(48, 0) = moveColorList(6, 0)
        patternLEDList(48, 1) = moveColorList(6, 1)
        patternLEDList(48, 2) = moveColorList(6, 2)
        Button49.BackColor = colorList(7)
        patternLEDList(49, 0) = moveColorList(7, 0)
        patternLEDList(49, 1) = moveColorList(7, 1)
        patternLEDList(49, 2) = moveColorList(7, 2)
        Button64.BackColor = colorList(8)
        patternLEDList(64, 0) = moveColorList(8, 0)
        patternLEDList(64, 1) = moveColorList(8, 1)
        patternLEDList(64, 2) = moveColorList(8, 2)
        Button65.BackColor = colorList(9)
        patternLEDList(65, 0) = moveColorList(9, 0)
        patternLEDList(65, 1) = moveColorList(9, 1)
        patternLEDList(65, 2) = moveColorList(9, 2)
        Button80.BackColor = colorList(10)
        patternLEDList(80, 0) = moveColorList(10, 0)
        patternLEDList(80, 1) = moveColorList(10, 1)
        patternLEDList(80, 2) = moveColorList(10, 2)
        Button81.BackColor = colorList(11)
        patternLEDList(81, 0) = moveColorList(11, 0)
        patternLEDList(81, 1) = moveColorList(11, 1)
        patternLEDList(81, 2) = moveColorList(11, 2)
        Button96.BackColor = colorList(12)
        patternLEDList(96, 0) = moveColorList(12, 0)
        patternLEDList(96, 1) = moveColorList(12, 1)
        patternLEDList(96, 2) = moveColorList(12, 2)
        Button97.BackColor = colorList(13)
        patternLEDList(97, 0) = moveColorList(13, 0)
        patternLEDList(97, 1) = moveColorList(13, 1)
        patternLEDList(97, 2) = moveColorList(13, 2)
        Button112.BackColor = colorList(14)
        patternLEDList(112, 0) = moveColorList(14, 0)
        patternLEDList(112, 1) = moveColorList(14, 1)
        patternLEDList(112, 2) = moveColorList(14, 2)
        Button113.BackColor = colorList(15)
        patternLEDList(113, 0) = moveColorList(15, 0)
        patternLEDList(113, 1) = moveColorList(15, 1)
        patternLEDList(113, 2) = moveColorList(15, 2)
        Button128.BackColor = colorList(16)
        patternLEDList(128, 0) = moveColorList(16, 0)
        patternLEDList(128, 1) = moveColorList(16, 1)
        patternLEDList(128, 2) = moveColorList(16, 2)
        Button129.BackColor = colorList(17)
        patternLEDList(129, 0) = moveColorList(17, 0)
        patternLEDList(129, 1) = moveColorList(17, 1)
        patternLEDList(129, 2) = moveColorList(17, 2)
        Button144.BackColor = colorList(18)
        patternLEDList(144, 0) = moveColorList(18, 0)
        patternLEDList(144, 1) = moveColorList(18, 1)
        patternLEDList(144, 2) = moveColorList(18, 2)
        Button145.BackColor = colorList(19)
        patternLEDList(145, 0) = moveColorList(19, 0)
        patternLEDList(145, 1) = moveColorList(19, 1)
        patternLEDList(145, 2) = moveColorList(19, 2)
        Button160.BackColor = colorList(20)
        patternLEDList(160, 0) = moveColorList(20, 0)
        patternLEDList(160, 1) = moveColorList(20, 1)
        patternLEDList(160, 2) = moveColorList(20, 2)
        Button161.BackColor = colorList(21)
        patternLEDList(161, 0) = moveColorList(21, 0)
        patternLEDList(161, 1) = moveColorList(21, 1)
        patternLEDList(161, 2) = moveColorList(21, 2)
        Button176.BackColor = colorList(22)
        patternLEDList(176, 0) = moveColorList(22, 0)
        patternLEDList(176, 1) = moveColorList(22, 1)
        patternLEDList(176, 2) = moveColorList(22, 2)
        Button177.BackColor = colorList(23)
        patternLEDList(177, 0) = moveColorList(23, 0)
        patternLEDList(177, 1) = moveColorList(23, 1)
        patternLEDList(177, 2) = moveColorList(23, 2)
        Button192.BackColor = colorList(24)
        patternLEDList(192, 0) = moveColorList(24, 0)
        patternLEDList(192, 1) = moveColorList(24, 1)
        patternLEDList(192, 2) = moveColorList(24, 2)
        Button193.BackColor = colorList(25)
        patternLEDList(193, 0) = moveColorList(25, 0)
        patternLEDList(193, 1) = moveColorList(25, 1)
        patternLEDList(193, 2) = moveColorList(25, 2)

        setarraydisply()
    End Sub

    Private Sub ToolStripButtonRight_Click(sender As Object, e As EventArgs) Handles ToolStripButtonRight.Click
        colorList(1) = Button193.BackColor
        moveColorList(1, 0) = patternLEDList(193, 0)
        moveColorList(1, 1) = patternLEDList(193, 1)
        moveColorList(1, 2) = patternLEDList(193, 2)
        colorList(2) = Button194.BackColor
        moveColorList(2, 0) = patternLEDList(194, 0)
        moveColorList(2, 1) = patternLEDList(194, 1)
        moveColorList(2, 2) = patternLEDList(194, 2)
        colorList(3) = Button195.BackColor
        moveColorList(3, 0) = patternLEDList(195, 0)
        moveColorList(3, 1) = patternLEDList(195, 1)
        moveColorList(3, 2) = patternLEDList(195, 2)
        colorList(4) = Button196.BackColor
        moveColorList(4, 0) = patternLEDList(196, 0)
        moveColorList(4, 1) = patternLEDList(196, 1)
        moveColorList(4, 2) = patternLEDList(196, 2)
        colorList(5) = Button197.BackColor
        moveColorList(5, 0) = patternLEDList(197, 0)
        moveColorList(5, 1) = patternLEDList(197, 1)
        moveColorList(5, 2) = patternLEDList(197, 2)
        colorList(6) = Button198.BackColor
        moveColorList(6, 0) = patternLEDList(198, 0)
        moveColorList(6, 1) = patternLEDList(198, 1)
        moveColorList(6, 2) = patternLEDList(198, 2)
        colorList(7) = Button199.BackColor
        moveColorList(7, 0) = patternLEDList(199, 0)
        moveColorList(7, 1) = patternLEDList(199, 1)
        moveColorList(7, 2) = patternLEDList(199, 2)
        colorList(8) = Button200.BackColor
        moveColorList(8, 0) = patternLEDList(200, 0)
        moveColorList(8, 1) = patternLEDList(200, 1)
        moveColorList(8, 2) = patternLEDList(200, 2)

        rightr1()
        rightr2()
        rightr3()
        rightr4()
        rightr5()
        rightr6()
        rightr7()
        rightr8()


        Button1.BackColor = colorList(1)
        patternLEDList(1, 0) = moveColorList(1, 0)
        patternLEDList(1, 1) = moveColorList(1, 1)
        patternLEDList(1, 2) = moveColorList(1, 2)
        Button2.BackColor = colorList(2)
        patternLEDList(2, 0) = moveColorList(2, 0)
        patternLEDList(2, 1) = moveColorList(2, 1)
        patternLEDList(2, 2) = moveColorList(2, 2)
        Button3.BackColor = colorList(3)
        patternLEDList(3, 0) = moveColorList(3, 0)
        patternLEDList(3, 1) = moveColorList(3, 1)
        patternLEDList(3, 2) = moveColorList(3, 2)
        Button4.BackColor = colorList(4)
        patternLEDList(4, 0) = moveColorList(4, 0)
        patternLEDList(4, 1) = moveColorList(4, 1)
        patternLEDList(4, 2) = moveColorList(4, 2)
        Button5.BackColor = colorList(5)
        patternLEDList(5, 0) = moveColorList(5, 0)
        patternLEDList(5, 1) = moveColorList(5, 1)
        patternLEDList(5, 2) = moveColorList(5, 2)
        Button6.BackColor = colorList(6)
        patternLEDList(6, 0) = moveColorList(6, 0)
        patternLEDList(6, 1) = moveColorList(6, 1)
        patternLEDList(6, 2) = moveColorList(6, 2)
        Button7.BackColor = colorList(7)
        patternLEDList(7, 0) = moveColorList(7, 0)
        patternLEDList(7, 1) = moveColorList(7, 1)
        patternLEDList(7, 2) = moveColorList(7, 2)
        Button8.BackColor = colorList(8)
        patternLEDList(8, 0) = moveColorList(8, 0)
        patternLEDList(8, 1) = moveColorList(8, 1)
        patternLEDList(8, 2) = moveColorList(8, 2)


        setarraydisply()
    End Sub

    ''
    ''' <summary>
    ''' Sample design loading area
    ''' </summary>
    ''' <remarks>
    ''' Load Pattern from file
    ''' 
    ''' 
    ''' </remarks>

    Private Sub setButtonColor()
        Button1.BackColor = Color.FromArgb(255, framesR(0), framesG(0), framesB(0))
        Button2.BackColor = Color.FromArgb(255, framesR(1), framesG(1), framesB(1))
        Button3.BackColor = Color.FromArgb(255, framesR(2), framesG(2), framesB(2))
        Button4.BackColor = Color.FromArgb(255, framesR(3), framesG(3), framesB(3))
        Button5.BackColor = Color.FromArgb(255, framesR(4), framesG(4), framesB(4))
        Button6.BackColor = Color.FromArgb(255, framesR(5), framesG(5), framesB(5))
        Button7.BackColor = Color.FromArgb(255, framesR(6), framesG(6), framesB(6))
        Button8.BackColor = Color.FromArgb(255, framesR(7), framesG(7), framesB(7))
        Button9.BackColor = Color.FromArgb(255, framesR(8), framesG(8), framesB(8))
        Button10.BackColor = Color.FromArgb(255, framesR(9), framesG(9), framesB(9))
        Button11.BackColor = Color.FromArgb(255, framesR(10), framesG(10), framesB(10))
        Button12.BackColor = Color.FromArgb(255, framesR(11), framesG(11), framesB(11))
        Button13.BackColor = Color.FromArgb(255, framesR(12), framesG(12), framesB(12))
        Button14.BackColor = Color.FromArgb(255, framesR(13), framesG(13), framesB(13))
        Button15.BackColor = Color.FromArgb(255, framesR(14), framesG(14), framesB(14))
        Button16.BackColor = Color.FromArgb(255, framesR(15), framesG(15), framesB(15))
        Button17.BackColor = Color.FromArgb(255, framesR(16), framesG(16), framesB(16))
        Button18.BackColor = Color.FromArgb(255, framesR(17), framesG(17), framesB(17))
        Button19.BackColor = Color.FromArgb(255, framesR(18), framesG(18), framesB(18))
        Button20.BackColor = Color.FromArgb(255, framesR(19), framesG(19), framesB(19))
        Button21.BackColor = Color.FromArgb(255, framesR(20), framesG(20), framesB(20))
        Button22.BackColor = Color.FromArgb(255, framesR(21), framesG(21), framesB(21))
        Button23.BackColor = Color.FromArgb(255, framesR(22), framesG(22), framesB(22))
        Button24.BackColor = Color.FromArgb(255, framesR(23), framesG(23), framesB(23))
        Button25.BackColor = Color.FromArgb(255, framesR(24), framesG(24), framesB(24))
        Button26.BackColor = Color.FromArgb(255, framesR(25), framesG(25), framesB(25))
        Button27.BackColor = Color.FromArgb(255, framesR(26), framesG(26), framesB(26))
        Button28.BackColor = Color.FromArgb(255, framesR(27), framesG(27), framesB(27))
        Button29.BackColor = Color.FromArgb(255, framesR(28), framesG(28), framesB(28))
        Button30.BackColor = Color.FromArgb(255, framesR(29), framesG(29), framesB(29))
        Button31.BackColor = Color.FromArgb(255, framesR(30), framesG(30), framesB(30))
        Button32.BackColor = Color.FromArgb(255, framesR(31), framesG(31), framesB(31))
        Button33.BackColor = Color.FromArgb(255, framesR(32), framesG(32), framesB(32))
        Button34.BackColor = Color.FromArgb(255, framesR(33), framesG(33), framesB(33))
        Button35.BackColor = Color.FromArgb(255, framesR(34), framesG(34), framesB(34))
        Button36.BackColor = Color.FromArgb(255, framesR(35), framesG(35), framesB(35))
        Button37.BackColor = Color.FromArgb(255, framesR(36), framesG(36), framesB(36))
        Button38.BackColor = Color.FromArgb(255, framesR(37), framesG(37), framesB(37))
        Button39.BackColor = Color.FromArgb(255, framesR(38), framesG(38), framesB(38))
        Button40.BackColor = Color.FromArgb(255, framesR(39), framesG(39), framesB(39))
        Button41.BackColor = Color.FromArgb(255, framesR(40), framesG(40), framesB(40))
        Button42.BackColor = Color.FromArgb(255, framesR(41), framesG(41), framesB(41))
        Button43.BackColor = Color.FromArgb(255, framesR(42), framesG(42), framesB(42))
        Button44.BackColor = Color.FromArgb(255, framesR(43), framesG(43), framesB(43))
        Button45.BackColor = Color.FromArgb(255, framesR(44), framesG(44), framesB(44))
        Button46.BackColor = Color.FromArgb(255, framesR(45), framesG(45), framesB(45))
        Button47.BackColor = Color.FromArgb(255, framesR(46), framesG(46), framesB(46))
        Button48.BackColor = Color.FromArgb(255, framesR(47), framesG(47), framesB(47))
        Button49.BackColor = Color.FromArgb(255, framesR(48), framesG(48), framesB(48))
        Button50.BackColor = Color.FromArgb(255, framesR(49), framesG(49), framesB(49))
        Button51.BackColor = Color.FromArgb(255, framesR(50), framesG(50), framesB(50))
        Button52.BackColor = Color.FromArgb(255, framesR(51), framesG(51), framesB(51))
        Button53.BackColor = Color.FromArgb(255, framesR(52), framesG(52), framesB(52))
        Button54.BackColor = Color.FromArgb(255, framesR(53), framesG(53), framesB(53))
        Button55.BackColor = Color.FromArgb(255, framesR(54), framesG(54), framesB(54))
        Button56.BackColor = Color.FromArgb(255, framesR(55), framesG(55), framesB(55))
        Button57.BackColor = Color.FromArgb(255, framesR(56), framesG(56), framesB(56))
        Button58.BackColor = Color.FromArgb(255, framesR(57), framesG(57), framesB(57))
        Button59.BackColor = Color.FromArgb(255, framesR(58), framesG(58), framesB(58))
        Button60.BackColor = Color.FromArgb(255, framesR(59), framesG(59), framesB(59))
        Button61.BackColor = Color.FromArgb(255, framesR(60), framesG(60), framesB(60))
        Button62.BackColor = Color.FromArgb(255, framesR(61), framesG(61), framesB(61))
        Button63.BackColor = Color.FromArgb(255, framesR(62), framesG(62), framesB(62))
        Button64.BackColor = Color.FromArgb(255, framesR(63), framesG(63), framesB(63))
        Button65.BackColor = Color.FromArgb(255, framesR(64), framesG(64), framesB(64))
        Button66.BackColor = Color.FromArgb(255, framesR(65), framesG(65), framesB(65))
        Button67.BackColor = Color.FromArgb(255, framesR(66), framesG(66), framesB(66))
        Button68.BackColor = Color.FromArgb(255, framesR(67), framesG(67), framesB(67))
        Button69.BackColor = Color.FromArgb(255, framesR(68), framesG(68), framesB(68))
        Button70.BackColor = Color.FromArgb(255, framesR(69), framesG(69), framesB(69))
        Button71.BackColor = Color.FromArgb(255, framesR(70), framesG(70), framesB(70))
        Button72.BackColor = Color.FromArgb(255, framesR(71), framesG(71), framesB(71))
        Button73.BackColor = Color.FromArgb(255, framesR(72), framesG(72), framesB(72))
        Button74.BackColor = Color.FromArgb(255, framesR(73), framesG(73), framesB(73))
        Button75.BackColor = Color.FromArgb(255, framesR(74), framesG(74), framesB(74))
        Button76.BackColor = Color.FromArgb(255, framesR(75), framesG(75), framesB(75))
        Button77.BackColor = Color.FromArgb(255, framesR(76), framesG(76), framesB(76))
        Button78.BackColor = Color.FromArgb(255, framesR(77), framesG(77), framesB(77))
        Button79.BackColor = Color.FromArgb(255, framesR(78), framesG(78), framesB(78))
        Button80.BackColor = Color.FromArgb(255, framesR(79), framesG(79), framesB(79))
        Button81.BackColor = Color.FromArgb(255, framesR(80), framesG(80), framesB(80))
        Button82.BackColor = Color.FromArgb(255, framesR(81), framesG(81), framesB(81))
        Button83.BackColor = Color.FromArgb(255, framesR(82), framesG(82), framesB(82))
        Button84.BackColor = Color.FromArgb(255, framesR(83), framesG(83), framesB(83))
        Button85.BackColor = Color.FromArgb(255, framesR(84), framesG(84), framesB(84))
        Button86.BackColor = Color.FromArgb(255, framesR(85), framesG(85), framesB(85))
        Button87.BackColor = Color.FromArgb(255, framesR(86), framesG(86), framesB(86))
        Button88.BackColor = Color.FromArgb(255, framesR(87), framesG(87), framesB(87))
        Button89.BackColor = Color.FromArgb(255, framesR(88), framesG(88), framesB(88))
        Button90.BackColor = Color.FromArgb(255, framesR(89), framesG(89), framesB(89))
        Button91.BackColor = Color.FromArgb(255, framesR(90), framesG(90), framesB(90))
        Button92.BackColor = Color.FromArgb(255, framesR(91), framesG(91), framesB(91))
        Button93.BackColor = Color.FromArgb(255, framesR(92), framesG(92), framesB(92))
        Button94.BackColor = Color.FromArgb(255, framesR(93), framesG(93), framesB(93))
        Button95.BackColor = Color.FromArgb(255, framesR(94), framesG(94), framesB(94))
        Button96.BackColor = Color.FromArgb(255, framesR(95), framesG(95), framesB(95))
        Button97.BackColor = Color.FromArgb(255, framesR(96), framesG(96), framesB(96))
        Button98.BackColor = Color.FromArgb(255, framesR(97), framesG(97), framesB(97))
        Button99.BackColor = Color.FromArgb(255, framesR(98), framesG(98), framesB(98))
        Button100.BackColor = Color.FromArgb(255, framesR(99), framesG(99), framesB(99))
        Button101.BackColor = Color.FromArgb(255, framesR(100), framesG(100), framesB(100))
        Button102.BackColor = Color.FromArgb(255, framesR(101), framesG(101), framesB(101))
        Button103.BackColor = Color.FromArgb(255, framesR(102), framesG(102), framesB(102))
        Button104.BackColor = Color.FromArgb(255, framesR(103), framesG(103), framesB(103))
        Button105.BackColor = Color.FromArgb(255, framesR(104), framesG(104), framesB(104))
        Button106.BackColor = Color.FromArgb(255, framesR(105), framesG(105), framesB(105))
        Button107.BackColor = Color.FromArgb(255, framesR(106), framesG(106), framesB(106))
        Button108.BackColor = Color.FromArgb(255, framesR(107), framesG(107), framesB(107))
        Button109.BackColor = Color.FromArgb(255, framesR(108), framesG(108), framesB(108))
        Button110.BackColor = Color.FromArgb(255, framesR(109), framesG(109), framesB(109))
        Button111.BackColor = Color.FromArgb(255, framesR(110), framesG(110), framesB(110))
        Button112.BackColor = Color.FromArgb(255, framesR(111), framesG(111), framesB(111))
        Button113.BackColor = Color.FromArgb(255, framesR(112), framesG(112), framesB(112))
        Button114.BackColor = Color.FromArgb(255, framesR(113), framesG(113), framesB(113))
        Button115.BackColor = Color.FromArgb(255, framesR(114), framesG(114), framesB(114))
        Button116.BackColor = Color.FromArgb(255, framesR(115), framesG(115), framesB(115))
        Button117.BackColor = Color.FromArgb(255, framesR(116), framesG(116), framesB(116))
        Button118.BackColor = Color.FromArgb(255, framesR(117), framesG(117), framesB(117))
        Button119.BackColor = Color.FromArgb(255, framesR(118), framesG(118), framesB(118))
        Button120.BackColor = Color.FromArgb(255, framesR(119), framesG(119), framesB(119))
        Button121.BackColor = Color.FromArgb(255, framesR(120), framesG(120), framesB(120))
        Button122.BackColor = Color.FromArgb(255, framesR(121), framesG(121), framesB(121))
        Button123.BackColor = Color.FromArgb(255, framesR(122), framesG(122), framesB(122))
        Button124.BackColor = Color.FromArgb(255, framesR(123), framesG(123), framesB(123))
        Button125.BackColor = Color.FromArgb(255, framesR(124), framesG(124), framesB(124))
        Button126.BackColor = Color.FromArgb(255, framesR(125), framesG(125), framesB(125))
        Button127.BackColor = Color.FromArgb(255, framesR(126), framesG(126), framesB(126))
        Button128.BackColor = Color.FromArgb(255, framesR(127), framesG(127), framesB(127))
        Button129.BackColor = Color.FromArgb(255, framesR(128), framesG(128), framesB(128))
        Button130.BackColor = Color.FromArgb(255, framesR(129), framesG(129), framesB(129))
        Button131.BackColor = Color.FromArgb(255, framesR(130), framesG(130), framesB(130))
        Button132.BackColor = Color.FromArgb(255, framesR(131), framesG(131), framesB(131))
        Button133.BackColor = Color.FromArgb(255, framesR(132), framesG(132), framesB(132))
        Button134.BackColor = Color.FromArgb(255, framesR(133), framesG(133), framesB(133))
        Button135.BackColor = Color.FromArgb(255, framesR(134), framesG(134), framesB(134))
        Button136.BackColor = Color.FromArgb(255, framesR(135), framesG(135), framesB(135))
        Button137.BackColor = Color.FromArgb(255, framesR(136), framesG(136), framesB(136))
        Button138.BackColor = Color.FromArgb(255, framesR(137), framesG(137), framesB(137))
        Button139.BackColor = Color.FromArgb(255, framesR(138), framesG(138), framesB(138))
        Button140.BackColor = Color.FromArgb(255, framesR(139), framesG(139), framesB(139))
        Button141.BackColor = Color.FromArgb(255, framesR(140), framesG(140), framesB(140))
        Button142.BackColor = Color.FromArgb(255, framesR(141), framesG(141), framesB(141))
        Button143.BackColor = Color.FromArgb(255, framesR(142), framesG(142), framesB(142))
        Button144.BackColor = Color.FromArgb(255, framesR(143), framesG(143), framesB(143))
        Button145.BackColor = Color.FromArgb(255, framesR(144), framesG(144), framesB(144))
        Button146.BackColor = Color.FromArgb(255, framesR(145), framesG(145), framesB(145))
        Button147.BackColor = Color.FromArgb(255, framesR(146), framesG(146), framesB(146))
        Button148.BackColor = Color.FromArgb(255, framesR(147), framesG(147), framesB(147))
        Button149.BackColor = Color.FromArgb(255, framesR(148), framesG(148), framesB(148))
        Button150.BackColor = Color.FromArgb(255, framesR(149), framesG(149), framesB(149))
        Button151.BackColor = Color.FromArgb(255, framesR(150), framesG(150), framesB(150))
        Button152.BackColor = Color.FromArgb(255, framesR(151), framesG(151), framesB(151))
        Button153.BackColor = Color.FromArgb(255, framesR(152), framesG(152), framesB(152))
        Button154.BackColor = Color.FromArgb(255, framesR(153), framesG(153), framesB(153))
        Button155.BackColor = Color.FromArgb(255, framesR(154), framesG(154), framesB(154))
        Button156.BackColor = Color.FromArgb(255, framesR(155), framesG(155), framesB(155))
        Button157.BackColor = Color.FromArgb(255, framesR(156), framesG(156), framesB(156))
        Button158.BackColor = Color.FromArgb(255, framesR(157), framesG(157), framesB(157))
        Button159.BackColor = Color.FromArgb(255, framesR(158), framesG(158), framesB(158))
        Button160.BackColor = Color.FromArgb(255, framesR(159), framesG(159), framesB(159))
        Button161.BackColor = Color.FromArgb(255, framesR(160), framesG(160), framesB(160))
        Button162.BackColor = Color.FromArgb(255, framesR(161), framesG(161), framesB(161))
        Button163.BackColor = Color.FromArgb(255, framesR(162), framesG(162), framesB(162))
        Button164.BackColor = Color.FromArgb(255, framesR(163), framesG(163), framesB(163))
        Button165.BackColor = Color.FromArgb(255, framesR(164), framesG(164), framesB(164))
        Button166.BackColor = Color.FromArgb(255, framesR(165), framesG(165), framesB(165))
        Button167.BackColor = Color.FromArgb(255, framesR(166), framesG(166), framesB(166))
        Button168.BackColor = Color.FromArgb(255, framesR(167), framesG(167), framesB(167))
        Button169.BackColor = Color.FromArgb(255, framesR(168), framesG(168), framesB(168))
        Button170.BackColor = Color.FromArgb(255, framesR(169), framesG(169), framesB(169))
        Button171.BackColor = Color.FromArgb(255, framesR(170), framesG(170), framesB(170))
        Button172.BackColor = Color.FromArgb(255, framesR(171), framesG(171), framesB(171))
        Button173.BackColor = Color.FromArgb(255, framesR(172), framesG(172), framesB(172))
        Button174.BackColor = Color.FromArgb(255, framesR(173), framesG(173), framesB(173))
        Button175.BackColor = Color.FromArgb(255, framesR(174), framesG(174), framesB(174))
        Button176.BackColor = Color.FromArgb(255, framesR(175), framesG(175), framesB(175))
        Button177.BackColor = Color.FromArgb(255, framesR(176), framesG(176), framesB(176))
        Button178.BackColor = Color.FromArgb(255, framesR(177), framesG(177), framesB(177))
        Button179.BackColor = Color.FromArgb(255, framesR(178), framesG(178), framesB(178))
        Button180.BackColor = Color.FromArgb(255, framesR(179), framesG(179), framesB(179))
        Button181.BackColor = Color.FromArgb(255, framesR(180), framesG(180), framesB(180))
        Button182.BackColor = Color.FromArgb(255, framesR(181), framesG(181), framesB(181))
        Button183.BackColor = Color.FromArgb(255, framesR(182), framesG(182), framesB(182))
        Button184.BackColor = Color.FromArgb(255, framesR(183), framesG(183), framesB(183))
        Button185.BackColor = Color.FromArgb(255, framesR(184), framesG(184), framesB(184))
        Button186.BackColor = Color.FromArgb(255, framesR(185), framesG(185), framesB(185))
        Button187.BackColor = Color.FromArgb(255, framesR(186), framesG(186), framesB(186))
        Button188.BackColor = Color.FromArgb(255, framesR(187), framesG(187), framesB(187))
        Button189.BackColor = Color.FromArgb(255, framesR(188), framesG(188), framesB(188))
        Button190.BackColor = Color.FromArgb(255, framesR(189), framesG(189), framesB(189))
        Button191.BackColor = Color.FromArgb(255, framesR(190), framesG(190), framesB(190))
        Button192.BackColor = Color.FromArgb(255, framesR(191), framesG(191), framesB(191))
        Button193.BackColor = Color.FromArgb(255, framesR(192), framesG(192), framesB(192))
        Button194.BackColor = Color.FromArgb(255, framesR(193), framesG(193), framesB(193))
        Button195.BackColor = Color.FromArgb(255, framesR(194), framesG(194), framesB(194))
        Button196.BackColor = Color.FromArgb(255, framesR(195), framesG(195), framesB(195))
        Button197.BackColor = Color.FromArgb(255, framesR(196), framesG(196), framesB(196))
        Button198.BackColor = Color.FromArgb(255, framesR(197), framesG(197), framesB(197))
        Button199.BackColor = Color.FromArgb(255, framesR(198), framesG(198), framesB(198))
        Button200.BackColor = Color.FromArgb(255, framesR(199), framesG(199), framesB(199))

    End Sub

    Private Sub readPattern(pattern As String)
        Dim fr As StreamReader
        Dim fileName As String
        fileName = pattern
        Try
            fr = New StreamReader(fileName)
            readopen(fr)
            fr.Close()
            read(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Pattern loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub setupButtons(btnCount As Integer)
        Dim k As Integer
        For k = 0 To btnCount - 1
            read(k * btnCount)
            setbtncolor(k)
            setbtncolor2(k)
            setbtncolor3(k)
            setbtncolor4(k)
        Next
    End Sub

    Private Sub setTiming()
        frameAnimator.Maximum = frameCount.Value - 1
        frameAnimator.Value = 0
        Label42.Text = frameAnimator.Value + 1
    End Sub

    Private Sub loadPatterns(patternFile As String)
        readPattern(patternFile)
        setupButtons(200)
        setTiming()
        setButtonColor()
        setarraydisply()
    End Sub

    Private Sub LotusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LotusToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_1.txt")
    End Sub

    Private Sub FlagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlagToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_2.txt")
    End Sub

    Private Sub CycloneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CycloneToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_3.txt")
    End Sub

    Private Sub Pattern01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pattern01ToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_4.txt")
    End Sub

    Private Sub Pattern02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pattern02ToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_5.txt")
    End Sub

    Private Sub Pattern03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pattern03ToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_6.txt")
    End Sub

    Private Sub Pattern04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pattern04ToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_7.txt")
    End Sub

    Private Sub Pattern05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pattern05ToolStripMenuItem.Click
        loadPatterns(patterFilePath + "Pattern_8.txt")

    End Sub

    Sub run(i As Long)
        PictureBox1.BackColor = Color.FromArgb(255, framesR(i + 0), framesG(i + 0), framesB(i + 0))
        PictureBox2.BackColor = Color.FromArgb(255, framesR(i + 1), framesG(i + 1), framesB(i + 1))
        PictureBox3.BackColor = Color.FromArgb(255, framesR(i + 2), framesG(i + 2), framesB(i + 2))
        PictureBox4.BackColor = Color.FromArgb(255, framesR(i + 3), framesG(i + 3), framesB(i + 3))
        PictureBox5.BackColor = Color.FromArgb(255, framesR(i + 4), framesG(i + 4), framesB(i + 4))
        PictureBox6.BackColor = Color.FromArgb(255, framesR(i + 5), framesG(i + 5), framesB(i + 5))
        PictureBox7.BackColor = Color.FromArgb(255, framesR(i + 6), framesG(i + 6), framesB(i + 6))
        PictureBox8.BackColor = Color.FromArgb(255, framesR(i + 7), framesG(i + 7), framesB(i + 7))
        PictureBox9.BackColor = Color.FromArgb(255, framesR(i + 8), framesG(i + 8), framesB(i + 8))
        PictureBox10.BackColor = Color.FromArgb(255, framesR(i + 9), framesG(i + 9), framesB(i + 9))
        PictureBox11.BackColor = Color.FromArgb(255, framesR(i + 10), framesG(i + 10), framesB(i + 10))
        PictureBox12.BackColor = Color.FromArgb(255, framesR(i + 11), framesG(i + 11), framesB(i + 11))
        PictureBox13.BackColor = Color.FromArgb(255, framesR(i + 12), framesG(i + 12), framesB(i + 12))
        PictureBox14.BackColor = Color.FromArgb(255, framesR(i + 13), framesG(i + 13), framesB(i + 13))
        PictureBox15.BackColor = Color.FromArgb(255, framesR(i + 14), framesG(i + 14), framesB(i + 14))
        PictureBox16.BackColor = Color.FromArgb(255, framesR(i + 15), framesG(i + 15), framesB(i + 15))
        PictureBox17.BackColor = Color.FromArgb(255, framesR(i + 16), framesG(i + 16), framesB(i + 16))
        PictureBox18.BackColor = Color.FromArgb(255, framesR(i + 17), framesG(i + 17), framesB(i + 17))
        PictureBox19.BackColor = Color.FromArgb(255, framesR(i + 18), framesG(i + 18), framesB(i + 18))
        PictureBox20.BackColor = Color.FromArgb(255, framesR(i + 19), framesG(i + 19), framesB(i + 19))
        PictureBox21.BackColor = Color.FromArgb(255, framesR(i + 20), framesG(i + 20), framesB(i + 20))
        PictureBox22.BackColor = Color.FromArgb(255, framesR(i + 21), framesG(i + 21), framesB(i + 21))
        PictureBox23.BackColor = Color.FromArgb(255, framesR(i + 22), framesG(i + 22), framesB(i + 22))
        PictureBox24.BackColor = Color.FromArgb(255, framesR(i + 23), framesG(i + 23), framesB(i + 23))
        PictureBox25.BackColor = Color.FromArgb(255, framesR(i + 24), framesG(i + 24), framesB(i + 24))
        PictureBox26.BackColor = Color.FromArgb(255, framesR(i + 25), framesG(i + 25), framesB(i + 25))
        PictureBox27.BackColor = Color.FromArgb(255, framesR(i + 26), framesG(i + 26), framesB(i + 26))
        PictureBox28.BackColor = Color.FromArgb(255, framesR(i + 27), framesG(i + 27), framesB(i + 27))
        PictureBox29.BackColor = Color.FromArgb(255, framesR(i + 28), framesG(i + 28), framesB(i + 28))
        PictureBox30.BackColor = Color.FromArgb(255, framesR(i + 29), framesG(i + 29), framesB(i + 29))
        PictureBox31.BackColor = Color.FromArgb(255, framesR(i + 30), framesG(i + 30), framesB(i + 30))
        PictureBox32.BackColor = Color.FromArgb(255, framesR(i + 31), framesG(i + 31), framesB(i + 31))
        PictureBox33.BackColor = Color.FromArgb(255, framesR(i + 32), framesG(i + 32), framesB(i + 32))
        PictureBox34.BackColor = Color.FromArgb(255, framesR(i + 33), framesG(i + 33), framesB(i + 33))
        PictureBox35.BackColor = Color.FromArgb(255, framesR(i + 34), framesG(i + 34), framesB(i + 34))
        PictureBox36.BackColor = Color.FromArgb(255, framesR(i + 35), framesG(i + 35), framesB(i + 35))
        PictureBox37.BackColor = Color.FromArgb(255, framesR(i + 36), framesG(i + 36), framesB(i + 36))
        PictureBox38.BackColor = Color.FromArgb(255, framesR(i + 37), framesG(i + 37), framesB(i + 37))
        PictureBox39.BackColor = Color.FromArgb(255, framesR(i + 38), framesG(i + 38), framesB(i + 38))
        PictureBox40.BackColor = Color.FromArgb(255, framesR(i + 39), framesG(i + 39), framesB(i + 39))
        PictureBox41.BackColor = Color.FromArgb(255, framesR(i + 40), framesG(i + 40), framesB(i + 40))
        PictureBox42.BackColor = Color.FromArgb(255, framesR(i + 41), framesG(i + 41), framesB(i + 41))
        PictureBox43.BackColor = Color.FromArgb(255, framesR(i + 42), framesG(i + 42), framesB(i + 42))
        PictureBox44.BackColor = Color.FromArgb(255, framesR(i + 43), framesG(i + 43), framesB(i + 43))
        PictureBox45.BackColor = Color.FromArgb(255, framesR(i + 44), framesG(i + 44), framesB(i + 44))
        PictureBox46.BackColor = Color.FromArgb(255, framesR(i + 45), framesG(i + 45), framesB(i + 45))
        PictureBox47.BackColor = Color.FromArgb(255, framesR(i + 46), framesG(i + 46), framesB(i + 46))
        PictureBox48.BackColor = Color.FromArgb(255, framesR(i + 47), framesG(i + 47), framesB(i + 47))
        PictureBox49.BackColor = Color.FromArgb(255, framesR(i + 48), framesG(i + 48), framesB(i + 48))
        PictureBox50.BackColor = Color.FromArgb(255, framesR(i + 49), framesG(i + 49), framesB(i + 49))
        PictureBox51.BackColor = Color.FromArgb(255, framesR(i + 50), framesG(i + 50), framesB(i + 50))
        PictureBox52.BackColor = Color.FromArgb(255, framesR(i + 51), framesG(i + 51), framesB(i + 51))
        PictureBox53.BackColor = Color.FromArgb(255, framesR(i + 52), framesG(i + 52), framesB(i + 52))
        PictureBox54.BackColor = Color.FromArgb(255, framesR(i + 53), framesG(i + 53), framesB(i + 53))
        PictureBox55.BackColor = Color.FromArgb(255, framesR(i + 54), framesG(i + 54), framesB(i + 54))
        PictureBox56.BackColor = Color.FromArgb(255, framesR(i + 55), framesG(i + 55), framesB(i + 55))
        PictureBox57.BackColor = Color.FromArgb(255, framesR(i + 56), framesG(i + 56), framesB(i + 56))
        PictureBox58.BackColor = Color.FromArgb(255, framesR(i + 57), framesG(i + 57), framesB(i + 57))
        PictureBox59.BackColor = Color.FromArgb(255, framesR(i + 58), framesG(i + 58), framesB(i + 58))
        PictureBox60.BackColor = Color.FromArgb(255, framesR(i + 59), framesG(i + 59), framesB(i + 59))
        PictureBox61.BackColor = Color.FromArgb(255, framesR(i + 60), framesG(i + 60), framesB(i + 60))
        PictureBox62.BackColor = Color.FromArgb(255, framesR(i + 61), framesG(i + 61), framesB(i + 61))
        PictureBox63.BackColor = Color.FromArgb(255, framesR(i + 62), framesG(i + 62), framesB(i + 62))
        PictureBox64.BackColor = Color.FromArgb(255, framesR(i + 63), framesG(i + 63), framesB(i + 63))
        PictureBox65.BackColor = Color.FromArgb(255, framesR(i + 64), framesG(i + 64), framesB(i + 64))
        PictureBox66.BackColor = Color.FromArgb(255, framesR(i + 65), framesG(i + 65), framesB(i + 65))
        PictureBox67.BackColor = Color.FromArgb(255, framesR(i + 66), framesG(i + 66), framesB(i + 66))
        PictureBox68.BackColor = Color.FromArgb(255, framesR(i + 67), framesG(i + 67), framesB(i + 67))
        PictureBox69.BackColor = Color.FromArgb(255, framesR(i + 68), framesG(i + 68), framesB(i + 68))
        PictureBox70.BackColor = Color.FromArgb(255, framesR(i + 69), framesG(i + 69), framesB(i + 69))
        PictureBox71.BackColor = Color.FromArgb(255, framesR(i + 70), framesG(i + 70), framesB(i + 70))
        PictureBox72.BackColor = Color.FromArgb(255, framesR(i + 71), framesG(i + 71), framesB(i + 71))
        PictureBox73.BackColor = Color.FromArgb(255, framesR(i + 72), framesG(i + 72), framesB(i + 72))
        PictureBox74.BackColor = Color.FromArgb(255, framesR(i + 73), framesG(i + 73), framesB(i + 73))
        PictureBox75.BackColor = Color.FromArgb(255, framesR(i + 74), framesG(i + 74), framesB(i + 74))
        PictureBox76.BackColor = Color.FromArgb(255, framesR(i + 75), framesG(i + 75), framesB(i + 75))
        PictureBox77.BackColor = Color.FromArgb(255, framesR(i + 76), framesG(i + 76), framesB(i + 76))
        PictureBox78.BackColor = Color.FromArgb(255, framesR(i + 77), framesG(i + 77), framesB(i + 77))
        PictureBox79.BackColor = Color.FromArgb(255, framesR(i + 78), framesG(i + 78), framesB(i + 78))
        PictureBox80.BackColor = Color.FromArgb(255, framesR(i + 79), framesG(i + 79), framesB(i + 79))
        PictureBox81.BackColor = Color.FromArgb(255, framesR(i + 80), framesG(i + 80), framesB(i + 80))
        PictureBox82.BackColor = Color.FromArgb(255, framesR(i + 81), framesG(i + 81), framesB(i + 81))
        PictureBox83.BackColor = Color.FromArgb(255, framesR(i + 82), framesG(i + 82), framesB(i + 82))
        PictureBox84.BackColor = Color.FromArgb(255, framesR(i + 83), framesG(i + 83), framesB(i + 83))
        PictureBox85.BackColor = Color.FromArgb(255, framesR(i + 84), framesG(i + 84), framesB(i + 84))
        PictureBox86.BackColor = Color.FromArgb(255, framesR(i + 85), framesG(i + 85), framesB(i + 85))
        PictureBox87.BackColor = Color.FromArgb(255, framesR(i + 86), framesG(i + 86), framesB(i + 86))
        PictureBox88.BackColor = Color.FromArgb(255, framesR(i + 87), framesG(i + 87), framesB(i + 87))
        PictureBox89.BackColor = Color.FromArgb(255, framesR(i + 88), framesG(i + 88), framesB(i + 88))
        PictureBox90.BackColor = Color.FromArgb(255, framesR(i + 89), framesG(i + 89), framesB(i + 89))
        PictureBox91.BackColor = Color.FromArgb(255, framesR(i + 90), framesG(i + 90), framesB(i + 90))
        PictureBox92.BackColor = Color.FromArgb(255, framesR(i + 91), framesG(i + 91), framesB(i + 91))
        PictureBox93.BackColor = Color.FromArgb(255, framesR(i + 92), framesG(i + 92), framesB(i + 92))
        PictureBox94.BackColor = Color.FromArgb(255, framesR(i + 93), framesG(i + 93), framesB(i + 93))
        PictureBox95.BackColor = Color.FromArgb(255, framesR(i + 94), framesG(i + 94), framesB(i + 94))
        PictureBox96.BackColor = Color.FromArgb(255, framesR(i + 95), framesG(i + 95), framesB(i + 95))
        PictureBox97.BackColor = Color.FromArgb(255, framesR(i + 96), framesG(i + 96), framesB(i + 96))
        PictureBox98.BackColor = Color.FromArgb(255, framesR(i + 97), framesG(i + 97), framesB(i + 97))
        PictureBox99.BackColor = Color.FromArgb(255, framesR(i + 98), framesG(i + 98), framesB(i + 98))
        PictureBox100.BackColor = Color.FromArgb(255, framesR(i + 99), framesG(i + 99), framesB(i + 99))
        PictureBox101.BackColor = Color.FromArgb(255, framesR(i + 100), framesG(i + 100), framesB(i + 100))
        PictureBox102.BackColor = Color.FromArgb(255, framesR(i + 101), framesG(i + 101), framesB(i + 101))
        PictureBox103.BackColor = Color.FromArgb(255, framesR(i + 102), framesG(i + 102), framesB(i + 102))
        PictureBox104.BackColor = Color.FromArgb(255, framesR(i + 103), framesG(i + 103), framesB(i + 103))
        PictureBox105.BackColor = Color.FromArgb(255, framesR(i + 104), framesG(i + 104), framesB(i + 104))
        PictureBox106.BackColor = Color.FromArgb(255, framesR(i + 105), framesG(i + 105), framesB(i + 105))
        PictureBox107.BackColor = Color.FromArgb(255, framesR(i + 106), framesG(i + 106), framesB(i + 106))
        PictureBox108.BackColor = Color.FromArgb(255, framesR(i + 107), framesG(i + 107), framesB(i + 107))
        PictureBox109.BackColor = Color.FromArgb(255, framesR(i + 108), framesG(i + 108), framesB(i + 108))
        PictureBox110.BackColor = Color.FromArgb(255, framesR(i + 109), framesG(i + 109), framesB(i + 109))
        PictureBox111.BackColor = Color.FromArgb(255, framesR(i + 110), framesG(i + 110), framesB(i + 110))
        PictureBox112.BackColor = Color.FromArgb(255, framesR(i + 111), framesG(i + 111), framesB(i + 111))
        PictureBox113.BackColor = Color.FromArgb(255, framesR(i + 112), framesG(i + 112), framesB(i + 112))
        PictureBox114.BackColor = Color.FromArgb(255, framesR(i + 113), framesG(i + 113), framesB(i + 113))
        PictureBox115.BackColor = Color.FromArgb(255, framesR(i + 114), framesG(i + 114), framesB(i + 114))
        PictureBox116.BackColor = Color.FromArgb(255, framesR(i + 115), framesG(i + 115), framesB(i + 115))
        PictureBox117.BackColor = Color.FromArgb(255, framesR(i + 116), framesG(i + 116), framesB(i + 116))
        PictureBox118.BackColor = Color.FromArgb(255, framesR(i + 117), framesG(i + 117), framesB(i + 117))
        PictureBox119.BackColor = Color.FromArgb(255, framesR(i + 118), framesG(i + 118), framesB(i + 118))
        PictureBox120.BackColor = Color.FromArgb(255, framesR(i + 119), framesG(i + 119), framesB(i + 119))
        PictureBox121.BackColor = Color.FromArgb(255, framesR(i + 120), framesG(i + 120), framesB(i + 120))
        PictureBox122.BackColor = Color.FromArgb(255, framesR(i + 121), framesG(i + 121), framesB(i + 121))
        PictureBox123.BackColor = Color.FromArgb(255, framesR(i + 122), framesG(i + 122), framesB(i + 122))
        PictureBox124.BackColor = Color.FromArgb(255, framesR(i + 123), framesG(i + 123), framesB(i + 123))
        PictureBox125.BackColor = Color.FromArgb(255, framesR(i + 124), framesG(i + 124), framesB(i + 124))
        PictureBox126.BackColor = Color.FromArgb(255, framesR(i + 125), framesG(i + 125), framesB(i + 125))
        PictureBox127.BackColor = Color.FromArgb(255, framesR(i + 126), framesG(i + 126), framesB(i + 126))
        PictureBox128.BackColor = Color.FromArgb(255, framesR(i + 127), framesG(i + 127), framesB(i + 127))
        PictureBox129.BackColor = Color.FromArgb(255, framesR(i + 128), framesG(i + 128), framesB(i + 128))
        PictureBox130.BackColor = Color.FromArgb(255, framesR(i + 129), framesG(i + 129), framesB(i + 129))
        PictureBox131.BackColor = Color.FromArgb(255, framesR(i + 130), framesG(i + 130), framesB(i + 130))
        PictureBox132.BackColor = Color.FromArgb(255, framesR(i + 131), framesG(i + 131), framesB(i + 131))
        PictureBox133.BackColor = Color.FromArgb(255, framesR(i + 132), framesG(i + 132), framesB(i + 132))
        PictureBox134.BackColor = Color.FromArgb(255, framesR(i + 133), framesG(i + 133), framesB(i + 133))
        PictureBox135.BackColor = Color.FromArgb(255, framesR(i + 134), framesG(i + 134), framesB(i + 134))
        PictureBox136.BackColor = Color.FromArgb(255, framesR(i + 135), framesG(i + 135), framesB(i + 135))
        PictureBox137.BackColor = Color.FromArgb(255, framesR(i + 136), framesG(i + 136), framesB(i + 136))
        PictureBox138.BackColor = Color.FromArgb(255, framesR(i + 137), framesG(i + 137), framesB(i + 137))
        PictureBox139.BackColor = Color.FromArgb(255, framesR(i + 138), framesG(i + 138), framesB(i + 138))
        PictureBox140.BackColor = Color.FromArgb(255, framesR(i + 139), framesG(i + 139), framesB(i + 139))
        PictureBox141.BackColor = Color.FromArgb(255, framesR(i + 140), framesG(i + 140), framesB(i + 140))
        PictureBox142.BackColor = Color.FromArgb(255, framesR(i + 141), framesG(i + 141), framesB(i + 141))
        PictureBox143.BackColor = Color.FromArgb(255, framesR(i + 142), framesG(i + 142), framesB(i + 142))
        PictureBox144.BackColor = Color.FromArgb(255, framesR(i + 143), framesG(i + 143), framesB(i + 143))
        PictureBox145.BackColor = Color.FromArgb(255, framesR(i + 144), framesG(i + 144), framesB(i + 144))
        PictureBox146.BackColor = Color.FromArgb(255, framesR(i + 145), framesG(i + 145), framesB(i + 145))
        PictureBox147.BackColor = Color.FromArgb(255, framesR(i + 146), framesG(i + 146), framesB(i + 146))
        PictureBox148.BackColor = Color.FromArgb(255, framesR(i + 147), framesG(i + 147), framesB(i + 147))
        PictureBox149.BackColor = Color.FromArgb(255, framesR(i + 148), framesG(i + 148), framesB(i + 148))
        PictureBox150.BackColor = Color.FromArgb(255, framesR(i + 149), framesG(i + 149), framesB(i + 149))
        PictureBox151.BackColor = Color.FromArgb(255, framesR(i + 150), framesG(i + 150), framesB(i + 150))
        PictureBox152.BackColor = Color.FromArgb(255, framesR(i + 151), framesG(i + 151), framesB(i + 151))
        PictureBox153.BackColor = Color.FromArgb(255, framesR(i + 152), framesG(i + 152), framesB(i + 152))
        PictureBox154.BackColor = Color.FromArgb(255, framesR(i + 153), framesG(i + 153), framesB(i + 153))
        PictureBox155.BackColor = Color.FromArgb(255, framesR(i + 154), framesG(i + 154), framesB(i + 154))
        PictureBox156.BackColor = Color.FromArgb(255, framesR(i + 155), framesG(i + 155), framesB(i + 155))
        PictureBox157.BackColor = Color.FromArgb(255, framesR(i + 156), framesG(i + 156), framesB(i + 156))
        PictureBox158.BackColor = Color.FromArgb(255, framesR(i + 157), framesG(i + 157), framesB(i + 157))
        PictureBox159.BackColor = Color.FromArgb(255, framesR(i + 158), framesG(i + 158), framesB(i + 158))
        PictureBox160.BackColor = Color.FromArgb(255, framesR(i + 159), framesG(i + 159), framesB(i + 159))
        PictureBox161.BackColor = Color.FromArgb(255, framesR(i + 160), framesG(i + 160), framesB(i + 160))
        PictureBox162.BackColor = Color.FromArgb(255, framesR(i + 161), framesG(i + 161), framesB(i + 161))
        PictureBox163.BackColor = Color.FromArgb(255, framesR(i + 162), framesG(i + 162), framesB(i + 162))
        PictureBox164.BackColor = Color.FromArgb(255, framesR(i + 163), framesG(i + 163), framesB(i + 163))
        PictureBox165.BackColor = Color.FromArgb(255, framesR(i + 164), framesG(i + 164), framesB(i + 164))
        PictureBox166.BackColor = Color.FromArgb(255, framesR(i + 165), framesG(i + 165), framesB(i + 165))
        PictureBox167.BackColor = Color.FromArgb(255, framesR(i + 166), framesG(i + 166), framesB(i + 166))
        PictureBox168.BackColor = Color.FromArgb(255, framesR(i + 167), framesG(i + 167), framesB(i + 167))
        PictureBox169.BackColor = Color.FromArgb(255, framesR(i + 168), framesG(i + 168), framesB(i + 168))
        PictureBox170.BackColor = Color.FromArgb(255, framesR(i + 169), framesG(i + 169), framesB(i + 169))
        PictureBox171.BackColor = Color.FromArgb(255, framesR(i + 170), framesG(i + 170), framesB(i + 170))
        PictureBox172.BackColor = Color.FromArgb(255, framesR(i + 171), framesG(i + 171), framesB(i + 171))
        PictureBox173.BackColor = Color.FromArgb(255, framesR(i + 172), framesG(i + 172), framesB(i + 172))
        PictureBox174.BackColor = Color.FromArgb(255, framesR(i + 173), framesG(i + 173), framesB(i + 173))
        PictureBox175.BackColor = Color.FromArgb(255, framesR(i + 174), framesG(i + 174), framesB(i + 174))
        PictureBox176.BackColor = Color.FromArgb(255, framesR(i + 175), framesG(i + 175), framesB(i + 175))
        PictureBox177.BackColor = Color.FromArgb(255, framesR(i + 176), framesG(i + 176), framesB(i + 176))
        PictureBox178.BackColor = Color.FromArgb(255, framesR(i + 177), framesG(i + 177), framesB(i + 177))
        PictureBox179.BackColor = Color.FromArgb(255, framesR(i + 178), framesG(i + 178), framesB(i + 178))
        PictureBox180.BackColor = Color.FromArgb(255, framesR(i + 179), framesG(i + 179), framesB(i + 179))
        PictureBox181.BackColor = Color.FromArgb(255, framesR(i + 180), framesG(i + 180), framesB(i + 180))
        PictureBox182.BackColor = Color.FromArgb(255, framesR(i + 181), framesG(i + 181), framesB(i + 181))
        PictureBox183.BackColor = Color.FromArgb(255, framesR(i + 182), framesG(i + 182), framesB(i + 182))
        PictureBox184.BackColor = Color.FromArgb(255, framesR(i + 183), framesG(i + 183), framesB(i + 183))
        PictureBox185.BackColor = Color.FromArgb(255, framesR(i + 184), framesG(i + 184), framesB(i + 184))
        PictureBox186.BackColor = Color.FromArgb(255, framesR(i + 185), framesG(i + 185), framesB(i + 185))
        PictureBox187.BackColor = Color.FromArgb(255, framesR(i + 186), framesG(i + 186), framesB(i + 186))
        PictureBox188.BackColor = Color.FromArgb(255, framesR(i + 187), framesG(i + 187), framesB(i + 187))
        PictureBox189.BackColor = Color.FromArgb(255, framesR(i + 188), framesG(i + 188), framesB(i + 188))
        PictureBox190.BackColor = Color.FromArgb(255, framesR(i + 189), framesG(i + 189), framesB(i + 189))
        PictureBox191.BackColor = Color.FromArgb(255, framesR(i + 190), framesG(i + 190), framesB(i + 190))
        PictureBox192.BackColor = Color.FromArgb(255, framesR(i + 191), framesG(i + 191), framesB(i + 191))
        PictureBox193.BackColor = Color.FromArgb(255, framesR(i + 192), framesG(i + 192), framesB(i + 192))
        PictureBox194.BackColor = Color.FromArgb(255, framesR(i + 193), framesG(i + 193), framesB(i + 193))
        PictureBox195.BackColor = Color.FromArgb(255, framesR(i + 194), framesG(i + 194), framesB(i + 194))
        PictureBox196.BackColor = Color.FromArgb(255, framesR(i + 195), framesG(i + 195), framesB(i + 195))
        PictureBox197.BackColor = Color.FromArgb(255, framesR(i + 196), framesG(i + 196), framesB(i + 196))
        PictureBox198.BackColor = Color.FromArgb(255, framesR(i + 197), framesG(i + 197), framesB(i + 197))
        PictureBox199.BackColor = Color.FromArgb(255, framesR(i + 198), framesG(i + 198), framesB(i + 198))
        PictureBox200.BackColor = Color.FromArgb(255, framesR(i + 199), framesG(i + 199), framesB(i + 199))

    End Sub


    Sub setdisplay()
        PictureBox1.BackColor = pixel1(0)
        PictureBox16.BackColor = pixel1(1)
        PictureBox17.BackColor = pixel1(2)
        PictureBox32.BackColor = pixel1(3)
        PictureBox33.BackColor = pixel1(4)
        PictureBox48.BackColor = pixel1(5)
        PictureBox49.BackColor = pixel1(6)
        PictureBox64.BackColor = pixel1(7)
        PictureBox65.BackColor = pixel1(8)
        PictureBox80.BackColor = pixel1(9)
        PictureBox81.BackColor = pixel1(10)
        PictureBox96.BackColor = pixel1(11)
        PictureBox97.BackColor = pixel1(12)
        PictureBox112.BackColor = pixel1(13)
        PictureBox113.BackColor = pixel1(14)
        PictureBox128.BackColor = pixel1(15)
        PictureBox129.BackColor = pixel1(16)
        PictureBox144.BackColor = pixel1(17)
        PictureBox145.BackColor = pixel1(18)
        PictureBox160.BackColor = pixel1(19)
        PictureBox161.BackColor = pixel1(20)
        PictureBox176.BackColor = pixel1(21)
        PictureBox177.BackColor = pixel1(22)
        PictureBox192.BackColor = pixel1(23)
        PictureBox193.BackColor = pixel1(24)
        PictureBox2.BackColor = pixel2(0)
        PictureBox15.BackColor = pixel2(1)
        PictureBox18.BackColor = pixel2(2)
        PictureBox31.BackColor = pixel2(3)
        PictureBox34.BackColor = pixel2(4)
        PictureBox47.BackColor = pixel2(5)
        PictureBox50.BackColor = pixel2(6)
        PictureBox63.BackColor = pixel2(7)
        PictureBox66.BackColor = pixel2(8)
        PictureBox79.BackColor = pixel2(9)
        PictureBox82.BackColor = pixel2(10)
        PictureBox95.BackColor = pixel2(11)
        PictureBox98.BackColor = pixel2(12)
        PictureBox111.BackColor = pixel2(13)
        PictureBox114.BackColor = pixel2(14)
        PictureBox127.BackColor = pixel2(15)
        PictureBox130.BackColor = pixel2(16)
        PictureBox143.BackColor = pixel2(17)
        PictureBox146.BackColor = pixel2(18)
        PictureBox159.BackColor = pixel2(19)
        PictureBox162.BackColor = pixel2(20)
        PictureBox175.BackColor = pixel2(21)
        PictureBox178.BackColor = pixel2(22)
        PictureBox191.BackColor = pixel2(23)
        PictureBox194.BackColor = pixel2(24)
        PictureBox3.BackColor = pixel3(0)
        PictureBox14.BackColor = pixel3(1)
        PictureBox19.BackColor = pixel3(2)
        PictureBox30.BackColor = pixel3(3)
        PictureBox35.BackColor = pixel3(4)
        PictureBox46.BackColor = pixel3(5)
        PictureBox51.BackColor = pixel3(6)
        PictureBox62.BackColor = pixel3(7)
        PictureBox67.BackColor = pixel3(8)
        PictureBox78.BackColor = pixel3(9)
        PictureBox83.BackColor = pixel3(10)
        PictureBox94.BackColor = pixel3(11)
        PictureBox99.BackColor = pixel3(12)
        PictureBox110.BackColor = pixel3(13)
        PictureBox115.BackColor = pixel3(14)
        PictureBox126.BackColor = pixel3(15)
        PictureBox131.BackColor = pixel3(16)
        PictureBox142.BackColor = pixel3(17)
        PictureBox147.BackColor = pixel3(18)
        PictureBox158.BackColor = pixel3(19)
        PictureBox163.BackColor = pixel3(20)
        PictureBox174.BackColor = pixel3(21)
        PictureBox179.BackColor = pixel3(22)
        PictureBox190.BackColor = pixel3(23)
        PictureBox195.BackColor = pixel3(24)
        PictureBox4.BackColor = pixel4(0)
        PictureBox13.BackColor = pixel4(1)
        PictureBox20.BackColor = pixel4(2)
        PictureBox29.BackColor = pixel4(3)
        PictureBox36.BackColor = pixel4(4)
        PictureBox45.BackColor = pixel4(5)
        PictureBox52.BackColor = pixel4(6)
        PictureBox61.BackColor = pixel4(7)
        PictureBox68.BackColor = pixel4(8)
        PictureBox77.BackColor = pixel4(9)
        PictureBox84.BackColor = pixel4(10)
        PictureBox93.BackColor = pixel4(11)
        PictureBox100.BackColor = pixel4(12)
        PictureBox109.BackColor = pixel4(13)
        PictureBox116.BackColor = pixel4(14)
        PictureBox125.BackColor = pixel4(15)
        PictureBox132.BackColor = pixel4(16)
        PictureBox141.BackColor = pixel4(17)
        PictureBox148.BackColor = pixel4(18)
        PictureBox157.BackColor = pixel4(19)
        PictureBox164.BackColor = pixel4(20)
        PictureBox173.BackColor = pixel4(21)
        PictureBox180.BackColor = pixel4(22)
        PictureBox189.BackColor = pixel4(23)
        PictureBox196.BackColor = pixel4(24)
        PictureBox5.BackColor = pixel5(0)
        PictureBox12.BackColor = pixel5(1)
        PictureBox21.BackColor = pixel5(2)
        PictureBox28.BackColor = pixel5(3)
        PictureBox37.BackColor = pixel5(4)
        PictureBox44.BackColor = pixel5(5)
        PictureBox53.BackColor = pixel5(6)
        PictureBox60.BackColor = pixel5(7)
        PictureBox69.BackColor = pixel5(8)
        PictureBox76.BackColor = pixel5(9)
        PictureBox85.BackColor = pixel5(10)
        PictureBox92.BackColor = pixel5(11)
        PictureBox101.BackColor = pixel5(12)
        PictureBox108.BackColor = pixel5(13)
        PictureBox117.BackColor = pixel5(14)
        PictureBox124.BackColor = pixel5(15)
        PictureBox133.BackColor = pixel5(16)
        PictureBox140.BackColor = pixel5(17)
        PictureBox149.BackColor = pixel5(18)
        PictureBox156.BackColor = pixel5(19)
        PictureBox165.BackColor = pixel5(20)
        PictureBox172.BackColor = pixel5(21)
        PictureBox181.BackColor = pixel5(22)
        PictureBox188.BackColor = pixel5(23)
        PictureBox197.BackColor = pixel5(24)
        PictureBox6.BackColor = pixel6(0)
        PictureBox11.BackColor = pixel6(1)
        PictureBox22.BackColor = pixel6(2)
        PictureBox27.BackColor = pixel6(3)
        PictureBox38.BackColor = pixel6(4)
        PictureBox43.BackColor = pixel6(5)
        PictureBox54.BackColor = pixel6(6)
        PictureBox59.BackColor = pixel6(7)
        PictureBox70.BackColor = pixel6(8)
        PictureBox75.BackColor = pixel6(9)
        PictureBox86.BackColor = pixel6(10)
        PictureBox91.BackColor = pixel6(11)
        PictureBox102.BackColor = pixel6(12)
        PictureBox107.BackColor = pixel6(13)
        PictureBox118.BackColor = pixel6(14)
        PictureBox123.BackColor = pixel6(15)
        PictureBox134.BackColor = pixel6(16)
        PictureBox139.BackColor = pixel6(17)
        PictureBox150.BackColor = pixel6(18)
        PictureBox155.BackColor = pixel6(19)
        PictureBox166.BackColor = pixel6(20)
        PictureBox171.BackColor = pixel6(21)
        PictureBox182.BackColor = pixel6(22)
        PictureBox187.BackColor = pixel6(23)
        PictureBox198.BackColor = pixel6(24)
        PictureBox7.BackColor = pixel7(0)
        PictureBox10.BackColor = pixel7(1)
        PictureBox23.BackColor = pixel7(2)
        PictureBox26.BackColor = pixel7(3)
        PictureBox39.BackColor = pixel7(4)
        PictureBox42.BackColor = pixel7(5)
        PictureBox55.BackColor = pixel7(6)
        PictureBox58.BackColor = pixel7(7)
        PictureBox71.BackColor = pixel7(8)
        PictureBox74.BackColor = pixel7(9)
        PictureBox87.BackColor = pixel7(10)
        PictureBox90.BackColor = pixel7(11)
        PictureBox103.BackColor = pixel7(12)
        PictureBox106.BackColor = pixel7(13)
        PictureBox119.BackColor = pixel7(14)
        PictureBox122.BackColor = pixel7(15)
        PictureBox135.BackColor = pixel7(16)
        PictureBox138.BackColor = pixel7(17)
        PictureBox151.BackColor = pixel7(18)
        PictureBox154.BackColor = pixel7(19)
        PictureBox167.BackColor = pixel7(20)
        PictureBox170.BackColor = pixel7(21)
        PictureBox183.BackColor = pixel7(22)
        PictureBox186.BackColor = pixel7(23)
        PictureBox199.BackColor = pixel7(24)
        PictureBox8.BackColor = pixel8(0)
        PictureBox9.BackColor = pixel8(1)
        PictureBox24.BackColor = pixel8(2)
        PictureBox25.BackColor = pixel8(3)
        PictureBox40.BackColor = pixel8(4)
        PictureBox41.BackColor = pixel8(5)
        PictureBox56.BackColor = pixel8(6)
        PictureBox57.BackColor = pixel8(7)
        PictureBox72.BackColor = pixel8(8)
        PictureBox73.BackColor = pixel8(9)
        PictureBox88.BackColor = pixel8(10)
        PictureBox89.BackColor = pixel8(11)
        PictureBox104.BackColor = pixel8(12)
        PictureBox105.BackColor = pixel8(13)
        PictureBox120.BackColor = pixel8(14)
        PictureBox121.BackColor = pixel8(15)
        PictureBox136.BackColor = pixel8(16)
        PictureBox137.BackColor = pixel8(17)
        PictureBox152.BackColor = pixel8(18)
        PictureBox153.BackColor = pixel8(19)
        PictureBox168.BackColor = pixel8(20)
        PictureBox169.BackColor = pixel8(21)
        PictureBox184.BackColor = pixel8(22)
        PictureBox185.BackColor = pixel8(23)
        PictureBox200.BackColor = pixel8(24)

    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        x = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ''if Is Array 
        ''frameAnimator.Value = Timer1.Interval / frameCount.Value

        If (CheckBoxIsArray.CheckState = CheckState.Unchecked) Then
            run(x * 200)
            x = x + 1
            If (x = frameCount.Value) Then
                x = 0
            End If
        Else
            If (direction = 1) Then
                moveup()
                setbottom(x)
                setdisplay()
                x = x + 1
                If (frameCount.Value * 8 = x) Then
                    x = 0
                End If
            ElseIf (direction = 2) Then
                movedown()
                settop(x)
                setdisplay()
                x = x + 1
                If (frameCount.Value * 8 = x) Then
                    x = 0
                End If
            ElseIf (direction = 3) Then
                moveleft()
                setright(x)
                setdisplay()
                x = x + 1
                If (frameCount.Value * 25 = x) Then
                    x = 0
                End If
            ElseIf (direction = 4) Then
                moveright()
                setleft(x)
                setdisplay()
                x = x + 1
                If (frameCount.Value * 25 = x) Then
                    x = 0
                End If
            End If
        End If
    End Sub

    Sub moveup()
        Dim y As Integer
        For y = 0 To 24
            pixel1(y) = pixel2(y)
            pixel2(y) = pixel3(y)
            pixel3(y) = pixel4(y)
            pixel4(y) = pixel5(y)
            pixel5(y) = pixel6(y)
            pixel6(y) = pixel7(y)
            pixel7(y) = pixel8(y)
        Next
    End Sub
    Sub movedown()
        Dim y As Integer
        For y = 0 To 24
            pixel8(y) = pixel7(y)
            pixel7(y) = pixel6(y)
            pixel6(y) = pixel5(y)
            pixel5(y) = pixel4(y)
            pixel4(y) = pixel3(y)
            pixel3(y) = pixel2(y)
            pixel2(y) = pixel1(y)
        Next
    End Sub

    Sub moveleft()
        Dim y As Integer
        For y = 0 To 23
            pixel1(y) = pixel1(y + 1)
            pixel2(y) = pixel2(y + 1)
            pixel3(y) = pixel3(y + 1)
            pixel4(y) = pixel4(y + 1)
            pixel5(y) = pixel5(y + 1)
            pixel6(y) = pixel6(y + 1)
            pixel7(y) = pixel7(y + 1)
            pixel8(y) = pixel8(y + 1)
        Next
    End Sub
    Sub moveright()
        Dim y As Integer
        For y = 0 To 23
            pixel1(24 - y) = pixel1(24 - y - 1)
            pixel2(24 - y) = pixel2(24 - y - 1)
            pixel3(24 - y) = pixel3(24 - y - 1)
            pixel4(24 - y) = pixel4(24 - y - 1)
            pixel5(24 - y) = pixel5(24 - y - 1)
            pixel6(24 - y) = pixel6(24 - y - 1)
            pixel7(24 - y) = pixel7(24 - y - 1)
            pixel8(24 - y) = pixel8(24 - y - 1)
        Next
    End Sub

    Sub setbottom(x As Long)
        Dim yy As Integer
        For yy = 0 To 24
            pixel8(yy) = f(x * 25 + yy)

        Next
    End Sub
    Sub settop(x As Long)
        Dim yy As Integer
        Dim h As Integer
        h = x Mod 8


        For yy = 0 To 24
            pixel1(yy) = f2(x * 25 + yy)

        Next

    End Sub
    Sub setright(x As Long)
        Dim j As Integer
        j = x Mod 25
        pixel1(24) = f3(x * 8 + 0)
        pixel2(24) = f3(x * 8 + 1)
        pixel3(24) = f3(x * 8 + 2)
        pixel4(24) = f3(x * 8 + 3)
        pixel5(24) = f3(x * 8 + 4)
        pixel6(24) = f3(x * 8 + 5)
        pixel7(24) = f3(x * 8 + 6)
        pixel8(24) = f3(x * 8 + 7)

    End Sub
    Sub setleft(x As Long)
        Dim j As Integer
        j = x Mod 25
        pixel1(0) = f4(x * 8 + 0)
        pixel2(0) = f4(x * 8 + 1)
        pixel3(0) = f4(x * 8 + 2)
        pixel4(0) = f4(x * 8 + 3)
        pixel5(0) = f4(x * 8 + 4)
        pixel6(0) = f4(x * 8 + 5)
        pixel7(0) = f4(x * 8 + 6)
        pixel8(0) = f4(x * 8 + 7)

    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer1.Stop()
    End Sub

    Private Sub TrackBarInterval_Scroll(sender As Object, e As EventArgs) Handles TrackBarInterval.Scroll
        IntervalCount.Text = (TrackBarInterval.Value * 0.1) & "s"
        Timer1.Interval = TrackBarInterval.Value * 100
    End Sub

    Private Sub ButtonDown_Click(sender As Object, e As EventArgs) Handles ButtonDown.Click
        Timer1.Stop()
        direction = 2
        ButtonUp.BackColor = Color.White
        ButtonDown.BackColor = Color.Gray
        ButtonLeft.BackColor = Color.White
        ButtonRight.BackColor = Color.White
    End Sub

    Private Sub ButtonLeft_Click(sender As Object, e As EventArgs) Handles ButtonLeft.Click
        Timer1.Stop()
        direction = 3
        ButtonUp.BackColor = Color.White
        ButtonDown.BackColor = Color.White
        ButtonLeft.BackColor = Color.Gray
        ButtonRight.BackColor = Color.White
    End Sub

    Private Sub ButtonRight_Click(sender As Object, e As EventArgs) Handles ButtonRight.Click
        Timer1.Stop()
        direction = 4
        ButtonUp.BackColor = Color.White
        ButtonDown.BackColor = Color.White
        ButtonLeft.BackColor = Color.White
        ButtonRight.BackColor = Color.Gray
    End Sub

    Private Sub ButtonUp_Click(sender As Object, e As EventArgs) Handles ButtonUp.Click
        Timer1.Stop()
        direction = 1
        ButtonUp.BackColor = Color.Gray
        ButtonDown.BackColor = Color.White
        ButtonLeft.BackColor = Color.White
        ButtonRight.BackColor = Color.White
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        If (Not Directory.Exists("C:\LED Editor\8x25")) Then
            Directory.CreateDirectory("C:\LED Editor\8x25")
        End If
        If (filepath = Nothing) Then
            Dim fw As StreamWriter
            Dim result As DialogResult
            result = SaveFileDialog1.ShowDialog
            If (result = Windows.Forms.DialogResult.OK) Then
                fw = New StreamWriter(SaveFileDialog1.FileName, False)
                write(fw)
                filepath = SaveFileDialog1.FileName
                fw.Close()
            End If
        Else
            Dim fw As StreamWriter
            fw = New StreamWriter(filepath, False)
            write(fw)
            fw.Close()
        End If
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        clear()
        Dim y As Long
        For y = 0 To duration
            framesR(y) = 0
            framesG(y) = 0
            framesB(y) = 0
        Next
        filepath = Nothing
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        Dim fr As StreamReader
        Dim result As DialogResult


        result = OpenFileDialog1.ShowDialog
        If (result = Windows.Forms.DialogResult.OK) Then
            fr = New StreamReader(OpenFileDialog1.FileName)
            readopen(fr)
            fr.Close()
        End If

        Dim k As Integer
        For k = 0 To 199
            read(k * 200)
            setbtncolor(k)
            setbtncolor2(k)
            setbtncolor3(k)
            setbtncolor4(k)
        Next

        frameAnimator.Maximum = frameCount.Value - 1
        frameAnimator.Value = 0
        Label42.Text = frameAnimator.Value + 1


        Button1.BackColor = Color.FromArgb(255, framesR(0), framesG(0), framesB(0))
        Button2.BackColor = Color.FromArgb(255, framesR(1), framesG(1), framesB(1))
        Button3.BackColor = Color.FromArgb(255, framesR(2), framesG(2), framesB(2))
        Button4.BackColor = Color.FromArgb(255, framesR(3), framesG(3), framesB(3))
        Button5.BackColor = Color.FromArgb(255, framesR(4), framesG(4), framesB(4))
        Button6.BackColor = Color.FromArgb(255, framesR(5), framesG(5), framesB(5))
        Button7.BackColor = Color.FromArgb(255, framesR(6), framesG(6), framesB(6))
        Button8.BackColor = Color.FromArgb(255, framesR(7), framesG(7), framesB(7))
        Button9.BackColor = Color.FromArgb(255, framesR(8), framesG(8), framesB(8))
        Button10.BackColor = Color.FromArgb(255, framesR(9), framesG(9), framesB(9))
        Button11.BackColor = Color.FromArgb(255, framesR(10), framesG(10), framesB(10))
        Button12.BackColor = Color.FromArgb(255, framesR(11), framesG(11), framesB(11))
        Button13.BackColor = Color.FromArgb(255, framesR(12), framesG(12), framesB(12))
        Button14.BackColor = Color.FromArgb(255, framesR(13), framesG(13), framesB(13))
        Button15.BackColor = Color.FromArgb(255, framesR(14), framesG(14), framesB(14))
        Button16.BackColor = Color.FromArgb(255, framesR(15), framesG(15), framesB(15))
        Button17.BackColor = Color.FromArgb(255, framesR(16), framesG(16), framesB(16))
        Button18.BackColor = Color.FromArgb(255, framesR(17), framesG(17), framesB(17))
        Button19.BackColor = Color.FromArgb(255, framesR(18), framesG(18), framesB(18))
        Button20.BackColor = Color.FromArgb(255, framesR(19), framesG(19), framesB(19))
        Button21.BackColor = Color.FromArgb(255, framesR(20), framesG(20), framesB(20))
        Button22.BackColor = Color.FromArgb(255, framesR(21), framesG(21), framesB(21))
        Button23.BackColor = Color.FromArgb(255, framesR(22), framesG(22), framesB(22))
        Button24.BackColor = Color.FromArgb(255, framesR(23), framesG(23), framesB(23))
        Button25.BackColor = Color.FromArgb(255, framesR(24), framesG(24), framesB(24))
        Button26.BackColor = Color.FromArgb(255, framesR(25), framesG(25), framesB(25))
        Button27.BackColor = Color.FromArgb(255, framesR(26), framesG(26), framesB(26))
        Button28.BackColor = Color.FromArgb(255, framesR(27), framesG(27), framesB(27))
        Button29.BackColor = Color.FromArgb(255, framesR(28), framesG(28), framesB(28))
        Button30.BackColor = Color.FromArgb(255, framesR(29), framesG(29), framesB(29))
        Button31.BackColor = Color.FromArgb(255, framesR(30), framesG(30), framesB(30))
        Button32.BackColor = Color.FromArgb(255, framesR(31), framesG(31), framesB(31))
        Button33.BackColor = Color.FromArgb(255, framesR(32), framesG(32), framesB(32))
        Button34.BackColor = Color.FromArgb(255, framesR(33), framesG(33), framesB(33))
        Button35.BackColor = Color.FromArgb(255, framesR(34), framesG(34), framesB(34))
        Button36.BackColor = Color.FromArgb(255, framesR(35), framesG(35), framesB(35))
        Button37.BackColor = Color.FromArgb(255, framesR(36), framesG(36), framesB(36))
        Button38.BackColor = Color.FromArgb(255, framesR(37), framesG(37), framesB(37))
        Button39.BackColor = Color.FromArgb(255, framesR(38), framesG(38), framesB(38))
        Button40.BackColor = Color.FromArgb(255, framesR(39), framesG(39), framesB(39))
        Button41.BackColor = Color.FromArgb(255, framesR(40), framesG(40), framesB(40))
        Button42.BackColor = Color.FromArgb(255, framesR(41), framesG(41), framesB(41))
        Button43.BackColor = Color.FromArgb(255, framesR(42), framesG(42), framesB(42))
        Button44.BackColor = Color.FromArgb(255, framesR(43), framesG(43), framesB(43))
        Button45.BackColor = Color.FromArgb(255, framesR(44), framesG(44), framesB(44))
        Button46.BackColor = Color.FromArgb(255, framesR(45), framesG(45), framesB(45))
        Button47.BackColor = Color.FromArgb(255, framesR(46), framesG(46), framesB(46))
        Button48.BackColor = Color.FromArgb(255, framesR(47), framesG(47), framesB(47))
        Button49.BackColor = Color.FromArgb(255, framesR(48), framesG(48), framesB(48))
        Button50.BackColor = Color.FromArgb(255, framesR(49), framesG(49), framesB(49))
        Button51.BackColor = Color.FromArgb(255, framesR(50), framesG(50), framesB(50))
        Button52.BackColor = Color.FromArgb(255, framesR(51), framesG(51), framesB(51))
        Button53.BackColor = Color.FromArgb(255, framesR(52), framesG(52), framesB(52))
        Button54.BackColor = Color.FromArgb(255, framesR(53), framesG(53), framesB(53))
        Button55.BackColor = Color.FromArgb(255, framesR(54), framesG(54), framesB(54))
        Button56.BackColor = Color.FromArgb(255, framesR(55), framesG(55), framesB(55))
        Button57.BackColor = Color.FromArgb(255, framesR(56), framesG(56), framesB(56))
        Button58.BackColor = Color.FromArgb(255, framesR(57), framesG(57), framesB(57))
        Button59.BackColor = Color.FromArgb(255, framesR(58), framesG(58), framesB(58))
        Button60.BackColor = Color.FromArgb(255, framesR(59), framesG(59), framesB(59))
        Button61.BackColor = Color.FromArgb(255, framesR(60), framesG(60), framesB(60))
        Button62.BackColor = Color.FromArgb(255, framesR(61), framesG(61), framesB(61))
        Button63.BackColor = Color.FromArgb(255, framesR(62), framesG(62), framesB(62))
        Button64.BackColor = Color.FromArgb(255, framesR(63), framesG(63), framesB(63))
        Button65.BackColor = Color.FromArgb(255, framesR(64), framesG(64), framesB(64))
        Button66.BackColor = Color.FromArgb(255, framesR(65), framesG(65), framesB(65))
        Button67.BackColor = Color.FromArgb(255, framesR(66), framesG(66), framesB(66))
        Button68.BackColor = Color.FromArgb(255, framesR(67), framesG(67), framesB(67))
        Button69.BackColor = Color.FromArgb(255, framesR(68), framesG(68), framesB(68))
        Button70.BackColor = Color.FromArgb(255, framesR(69), framesG(69), framesB(69))
        Button71.BackColor = Color.FromArgb(255, framesR(70), framesG(70), framesB(70))
        Button72.BackColor = Color.FromArgb(255, framesR(71), framesG(71), framesB(71))
        Button73.BackColor = Color.FromArgb(255, framesR(72), framesG(72), framesB(72))
        Button74.BackColor = Color.FromArgb(255, framesR(73), framesG(73), framesB(73))
        Button75.BackColor = Color.FromArgb(255, framesR(74), framesG(74), framesB(74))
        Button76.BackColor = Color.FromArgb(255, framesR(75), framesG(75), framesB(75))
        Button77.BackColor = Color.FromArgb(255, framesR(76), framesG(76), framesB(76))
        Button78.BackColor = Color.FromArgb(255, framesR(77), framesG(77), framesB(77))
        Button79.BackColor = Color.FromArgb(255, framesR(78), framesG(78), framesB(78))
        Button80.BackColor = Color.FromArgb(255, framesR(79), framesG(79), framesB(79))
        Button81.BackColor = Color.FromArgb(255, framesR(80), framesG(80), framesB(80))
        Button82.BackColor = Color.FromArgb(255, framesR(81), framesG(81), framesB(81))
        Button83.BackColor = Color.FromArgb(255, framesR(82), framesG(82), framesB(82))
        Button84.BackColor = Color.FromArgb(255, framesR(83), framesG(83), framesB(83))
        Button85.BackColor = Color.FromArgb(255, framesR(84), framesG(84), framesB(84))
        Button86.BackColor = Color.FromArgb(255, framesR(85), framesG(85), framesB(85))
        Button87.BackColor = Color.FromArgb(255, framesR(86), framesG(86), framesB(86))
        Button88.BackColor = Color.FromArgb(255, framesR(87), framesG(87), framesB(87))
        Button89.BackColor = Color.FromArgb(255, framesR(88), framesG(88), framesB(88))
        Button90.BackColor = Color.FromArgb(255, framesR(89), framesG(89), framesB(89))
        Button91.BackColor = Color.FromArgb(255, framesR(90), framesG(90), framesB(90))
        Button92.BackColor = Color.FromArgb(255, framesR(91), framesG(91), framesB(91))
        Button93.BackColor = Color.FromArgb(255, framesR(92), framesG(92), framesB(92))
        Button94.BackColor = Color.FromArgb(255, framesR(93), framesG(93), framesB(93))
        Button95.BackColor = Color.FromArgb(255, framesR(94), framesG(94), framesB(94))
        Button96.BackColor = Color.FromArgb(255, framesR(95), framesG(95), framesB(95))
        Button97.BackColor = Color.FromArgb(255, framesR(96), framesG(96), framesB(96))
        Button98.BackColor = Color.FromArgb(255, framesR(97), framesG(97), framesB(97))
        Button99.BackColor = Color.FromArgb(255, framesR(98), framesG(98), framesB(98))
        Button100.BackColor = Color.FromArgb(255, framesR(99), framesG(99), framesB(99))
        Button101.BackColor = Color.FromArgb(255, framesR(100), framesG(100), framesB(100))
        Button102.BackColor = Color.FromArgb(255, framesR(101), framesG(101), framesB(101))
        Button103.BackColor = Color.FromArgb(255, framesR(102), framesG(102), framesB(102))
        Button104.BackColor = Color.FromArgb(255, framesR(103), framesG(103), framesB(103))
        Button105.BackColor = Color.FromArgb(255, framesR(104), framesG(104), framesB(104))
        Button106.BackColor = Color.FromArgb(255, framesR(105), framesG(105), framesB(105))
        Button107.BackColor = Color.FromArgb(255, framesR(106), framesG(106), framesB(106))
        Button108.BackColor = Color.FromArgb(255, framesR(107), framesG(107), framesB(107))
        Button109.BackColor = Color.FromArgb(255, framesR(108), framesG(108), framesB(108))
        Button110.BackColor = Color.FromArgb(255, framesR(109), framesG(109), framesB(109))
        Button111.BackColor = Color.FromArgb(255, framesR(110), framesG(110), framesB(110))
        Button112.BackColor = Color.FromArgb(255, framesR(111), framesG(111), framesB(111))
        Button113.BackColor = Color.FromArgb(255, framesR(112), framesG(112), framesB(112))
        Button114.BackColor = Color.FromArgb(255, framesR(113), framesG(113), framesB(113))
        Button115.BackColor = Color.FromArgb(255, framesR(114), framesG(114), framesB(114))
        Button116.BackColor = Color.FromArgb(255, framesR(115), framesG(115), framesB(115))
        Button117.BackColor = Color.FromArgb(255, framesR(116), framesG(116), framesB(116))
        Button118.BackColor = Color.FromArgb(255, framesR(117), framesG(117), framesB(117))
        Button119.BackColor = Color.FromArgb(255, framesR(118), framesG(118), framesB(118))
        Button120.BackColor = Color.FromArgb(255, framesR(119), framesG(119), framesB(119))
        Button121.BackColor = Color.FromArgb(255, framesR(120), framesG(120), framesB(120))
        Button122.BackColor = Color.FromArgb(255, framesR(121), framesG(121), framesB(121))
        Button123.BackColor = Color.FromArgb(255, framesR(122), framesG(122), framesB(122))
        Button124.BackColor = Color.FromArgb(255, framesR(123), framesG(123), framesB(123))
        Button125.BackColor = Color.FromArgb(255, framesR(124), framesG(124), framesB(124))
        Button126.BackColor = Color.FromArgb(255, framesR(125), framesG(125), framesB(125))
        Button127.BackColor = Color.FromArgb(255, framesR(126), framesG(126), framesB(126))
        Button128.BackColor = Color.FromArgb(255, framesR(127), framesG(127), framesB(127))
        Button129.BackColor = Color.FromArgb(255, framesR(128), framesG(128), framesB(128))
        Button130.BackColor = Color.FromArgb(255, framesR(129), framesG(129), framesB(129))
        Button131.BackColor = Color.FromArgb(255, framesR(130), framesG(130), framesB(130))
        Button132.BackColor = Color.FromArgb(255, framesR(131), framesG(131), framesB(131))
        Button133.BackColor = Color.FromArgb(255, framesR(132), framesG(132), framesB(132))
        Button134.BackColor = Color.FromArgb(255, framesR(133), framesG(133), framesB(133))
        Button135.BackColor = Color.FromArgb(255, framesR(134), framesG(134), framesB(134))
        Button136.BackColor = Color.FromArgb(255, framesR(135), framesG(135), framesB(135))
        Button137.BackColor = Color.FromArgb(255, framesR(136), framesG(136), framesB(136))
        Button138.BackColor = Color.FromArgb(255, framesR(137), framesG(137), framesB(137))
        Button139.BackColor = Color.FromArgb(255, framesR(138), framesG(138), framesB(138))
        Button140.BackColor = Color.FromArgb(255, framesR(139), framesG(139), framesB(139))
        Button141.BackColor = Color.FromArgb(255, framesR(140), framesG(140), framesB(140))
        Button142.BackColor = Color.FromArgb(255, framesR(141), framesG(141), framesB(141))
        Button143.BackColor = Color.FromArgb(255, framesR(142), framesG(142), framesB(142))
        Button144.BackColor = Color.FromArgb(255, framesR(143), framesG(143), framesB(143))
        Button145.BackColor = Color.FromArgb(255, framesR(144), framesG(144), framesB(144))
        Button146.BackColor = Color.FromArgb(255, framesR(145), framesG(145), framesB(145))
        Button147.BackColor = Color.FromArgb(255, framesR(146), framesG(146), framesB(146))
        Button148.BackColor = Color.FromArgb(255, framesR(147), framesG(147), framesB(147))
        Button149.BackColor = Color.FromArgb(255, framesR(148), framesG(148), framesB(148))
        Button150.BackColor = Color.FromArgb(255, framesR(149), framesG(149), framesB(149))
        Button151.BackColor = Color.FromArgb(255, framesR(150), framesG(150), framesB(150))
        Button152.BackColor = Color.FromArgb(255, framesR(151), framesG(151), framesB(151))
        Button153.BackColor = Color.FromArgb(255, framesR(152), framesG(152), framesB(152))
        Button154.BackColor = Color.FromArgb(255, framesR(153), framesG(153), framesB(153))
        Button155.BackColor = Color.FromArgb(255, framesR(154), framesG(154), framesB(154))
        Button156.BackColor = Color.FromArgb(255, framesR(155), framesG(155), framesB(155))
        Button157.BackColor = Color.FromArgb(255, framesR(156), framesG(156), framesB(156))
        Button158.BackColor = Color.FromArgb(255, framesR(157), framesG(157), framesB(157))
        Button159.BackColor = Color.FromArgb(255, framesR(158), framesG(158), framesB(158))
        Button160.BackColor = Color.FromArgb(255, framesR(159), framesG(159), framesB(159))
        Button161.BackColor = Color.FromArgb(255, framesR(160), framesG(160), framesB(160))
        Button162.BackColor = Color.FromArgb(255, framesR(161), framesG(161), framesB(161))
        Button163.BackColor = Color.FromArgb(255, framesR(162), framesG(162), framesB(162))
        Button164.BackColor = Color.FromArgb(255, framesR(163), framesG(163), framesB(163))
        Button165.BackColor = Color.FromArgb(255, framesR(164), framesG(164), framesB(164))
        Button166.BackColor = Color.FromArgb(255, framesR(165), framesG(165), framesB(165))
        Button167.BackColor = Color.FromArgb(255, framesR(166), framesG(166), framesB(166))
        Button168.BackColor = Color.FromArgb(255, framesR(167), framesG(167), framesB(167))
        Button169.BackColor = Color.FromArgb(255, framesR(168), framesG(168), framesB(168))
        Button170.BackColor = Color.FromArgb(255, framesR(169), framesG(169), framesB(169))
        Button171.BackColor = Color.FromArgb(255, framesR(170), framesG(170), framesB(170))
        Button172.BackColor = Color.FromArgb(255, framesR(171), framesG(171), framesB(171))
        Button173.BackColor = Color.FromArgb(255, framesR(172), framesG(172), framesB(172))
        Button174.BackColor = Color.FromArgb(255, framesR(173), framesG(173), framesB(173))
        Button175.BackColor = Color.FromArgb(255, framesR(174), framesG(174), framesB(174))
        Button176.BackColor = Color.FromArgb(255, framesR(175), framesG(175), framesB(175))
        Button177.BackColor = Color.FromArgb(255, framesR(176), framesG(176), framesB(176))
        Button178.BackColor = Color.FromArgb(255, framesR(177), framesG(177), framesB(177))
        Button179.BackColor = Color.FromArgb(255, framesR(178), framesG(178), framesB(178))
        Button180.BackColor = Color.FromArgb(255, framesR(179), framesG(179), framesB(179))
        Button181.BackColor = Color.FromArgb(255, framesR(180), framesG(180), framesB(180))
        Button182.BackColor = Color.FromArgb(255, framesR(181), framesG(181), framesB(181))
        Button183.BackColor = Color.FromArgb(255, framesR(182), framesG(182), framesB(182))
        Button184.BackColor = Color.FromArgb(255, framesR(183), framesG(183), framesB(183))
        Button185.BackColor = Color.FromArgb(255, framesR(184), framesG(184), framesB(184))
        Button186.BackColor = Color.FromArgb(255, framesR(185), framesG(185), framesB(185))
        Button187.BackColor = Color.FromArgb(255, framesR(186), framesG(186), framesB(186))
        Button188.BackColor = Color.FromArgb(255, framesR(187), framesG(187), framesB(187))
        Button189.BackColor = Color.FromArgb(255, framesR(188), framesG(188), framesB(188))
        Button190.BackColor = Color.FromArgb(255, framesR(189), framesG(189), framesB(189))
        Button191.BackColor = Color.FromArgb(255, framesR(190), framesG(190), framesB(190))
        Button192.BackColor = Color.FromArgb(255, framesR(191), framesG(191), framesB(191))
        Button193.BackColor = Color.FromArgb(255, framesR(192), framesG(192), framesB(192))
        Button194.BackColor = Color.FromArgb(255, framesR(193), framesG(193), framesB(193))
        Button195.BackColor = Color.FromArgb(255, framesR(194), framesG(194), framesB(194))
        Button196.BackColor = Color.FromArgb(255, framesR(195), framesG(195), framesB(195))
        Button197.BackColor = Color.FromArgb(255, framesR(196), framesG(196), framesB(196))
        Button198.BackColor = Color.FromArgb(255, framesR(197), framesG(197), framesB(197))
        Button199.BackColor = Color.FromArgb(255, framesR(198), framesG(198), framesB(198))
        Button200.BackColor = Color.FromArgb(255, framesR(199), framesG(199), framesB(199))


        read(0)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

    End Sub
End Class
