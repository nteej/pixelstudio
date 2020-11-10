Imports System.IO

Public Class CodeView

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Function generateCode(pattern As String, pattern_func As String) As String
        Dim resourcePath As String = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
        Dim textFile As String = resourcePath + "BaseCode.ino"
        Dim text As String = File.ReadAllText(textFile)
        text = text.Replace("//method_define", "void " & pattern & "();" & vbNewLine & "//method_define")
        text = text.Replace("//method_call", pattern & "();" & vbNewLine & " pt8x25(0, DELAY);" & vbNewLine & "//method_call")
        text = text.Replace("//pattern_1", pattern_func & vbNewLine & "//pattern_1")
        File.WriteAllText(textFile, text)
        text = File.ReadAllText(textFile)

        Return text


    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Dashboard.CheckBoxIsArray.CheckState = CheckState.Checked) Then

            F.Text = "void " & Dashboard.TextBox1.Text & "() {"
            F.Text = F.Text & vbNewLine & "  cleara8x25();"

            If (Dashboard.patternLEDList(1, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][0] = " & Dashboard.patternLEDList(1, 0) & ";"
            End If
            If (Dashboard.patternLEDList(1, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][1] = " & Dashboard.patternLEDList(1, 1) & ";"
            End If
            If (Dashboard.patternLEDList(1, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][2] = " & Dashboard.patternLEDList(1, 2) & ";"
            End If
            If (Dashboard.patternLEDList(2, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][0] = " & Dashboard.patternLEDList(2, 0) & ";"
            End If
            If (Dashboard.patternLEDList(2, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][1] = " & Dashboard.patternLEDList(2, 1) & ";"
            End If
            If (Dashboard.patternLEDList(2, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][2] = " & Dashboard.patternLEDList(2, 2) & ";"
            End If
            If (Dashboard.patternLEDList(3, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][0] = " & Dashboard.patternLEDList(3, 0) & ";"
            End If
            If (Dashboard.patternLEDList(3, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][1] = " & Dashboard.patternLEDList(3, 1) & ";"
            End If
            If (Dashboard.patternLEDList(3, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][2] = " & Dashboard.patternLEDList(3, 2) & ";"
            End If
            If (Dashboard.patternLEDList(4, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][0] = " & Dashboard.patternLEDList(4, 0) & ";"
            End If
            If (Dashboard.patternLEDList(4, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][1] = " & Dashboard.patternLEDList(4, 1) & ";"
            End If
            If (Dashboard.patternLEDList(4, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][2] = " & Dashboard.patternLEDList(4, 2) & ";"
            End If
            If (Dashboard.patternLEDList(5, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][0] = " & Dashboard.patternLEDList(5, 0) & ";"
            End If
            If (Dashboard.patternLEDList(5, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][1] = " & Dashboard.patternLEDList(5, 1) & ";"
            End If
            If (Dashboard.patternLEDList(5, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][2] = " & Dashboard.patternLEDList(5, 2) & ";"
            End If
            If (Dashboard.patternLEDList(6, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][0] = " & Dashboard.patternLEDList(6, 0) & ";"
            End If
            If (Dashboard.patternLEDList(6, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][1] = " & Dashboard.patternLEDList(6, 1) & ";"
            End If
            If (Dashboard.patternLEDList(6, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][2] = " & Dashboard.patternLEDList(6, 2) & ";"
            End If
            If (Dashboard.patternLEDList(7, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][0] = " & Dashboard.patternLEDList(7, 0) & ";"
            End If
            If (Dashboard.patternLEDList(7, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][1] = " & Dashboard.patternLEDList(7, 1) & ";"
            End If
            If (Dashboard.patternLEDList(7, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][2] = " & Dashboard.patternLEDList(7, 2) & ";"
            End If
            If (Dashboard.patternLEDList(8, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][0] = " & Dashboard.patternLEDList(8, 0) & ";"
            End If
            If (Dashboard.patternLEDList(8, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][1] = " & Dashboard.patternLEDList(8, 1) & ";"
            End If
            If (Dashboard.patternLEDList(8, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][2] = " & Dashboard.patternLEDList(8, 2) & ";"
            End If

            If (Dashboard.patternLEDList(17, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][0] = " & Dashboard.patternLEDList(17, 0) & ";"
            End If
            If (Dashboard.patternLEDList(17, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][1] = " & Dashboard.patternLEDList(17, 1) & ";"
            End If
            If (Dashboard.patternLEDList(17, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][2] = " & Dashboard.patternLEDList(17, 2) & ";"
            End If
            If (Dashboard.patternLEDList(18, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][0] = " & Dashboard.patternLEDList(18, 0) & ";"
            End If
            If (Dashboard.patternLEDList(18, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][1] = " & Dashboard.patternLEDList(18, 1) & ";"
            End If
            If (Dashboard.patternLEDList(18, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][2] = " & Dashboard.patternLEDList(18, 2) & ";"
            End If
            If (Dashboard.patternLEDList(19, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][0] = " & Dashboard.patternLEDList(19, 0) & ";"
            End If
            If (Dashboard.patternLEDList(19, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][1] = " & Dashboard.patternLEDList(19, 1) & ";"
            End If
            If (Dashboard.patternLEDList(19, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][2] = " & Dashboard.patternLEDList(19, 2) & ";"
            End If
            If (Dashboard.patternLEDList(20, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][0] = " & Dashboard.patternLEDList(20, 0) & ";"
            End If
            If (Dashboard.patternLEDList(20, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][1] = " & Dashboard.patternLEDList(20, 1) & ";"
            End If
            If (Dashboard.patternLEDList(20, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][2] = " & Dashboard.patternLEDList(20, 2) & ";"
            End If
            If (Dashboard.patternLEDList(21, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][0] = " & Dashboard.patternLEDList(21, 0) & ";"
            End If
            If (Dashboard.patternLEDList(21, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][1] = " & Dashboard.patternLEDList(21, 1) & ";"
            End If
            If (Dashboard.patternLEDList(21, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][2] = " & Dashboard.patternLEDList(21, 2) & ";"
            End If
            If (Dashboard.patternLEDList(22, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][0] = " & Dashboard.patternLEDList(22, 0) & ";"
            End If
            If (Dashboard.patternLEDList(22, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][1] = " & Dashboard.patternLEDList(22, 1) & ";"
            End If
            If (Dashboard.patternLEDList(22, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][2] = " & Dashboard.patternLEDList(22, 2) & ";"
            End If
            If (Dashboard.patternLEDList(23, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][0] = " & Dashboard.patternLEDList(23, 0) & ";"
            End If
            If (Dashboard.patternLEDList(23, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][1] = " & Dashboard.patternLEDList(23, 1) & ";"
            End If
            If (Dashboard.patternLEDList(23, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][2] = " & Dashboard.patternLEDList(23, 2) & ";"
            End If
            If (Dashboard.patternLEDList(24, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][0] = " & Dashboard.patternLEDList(24, 0) & ";"
            End If
            If (Dashboard.patternLEDList(24, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][1] = " & Dashboard.patternLEDList(24, 1) & ";"
            End If
            If (Dashboard.patternLEDList(24, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][2] = " & Dashboard.patternLEDList(24, 2) & ";"
            End If
            If (Dashboard.patternLEDList(33, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][0] = " & Dashboard.patternLEDList(33, 0) & ";"
            End If
            If (Dashboard.patternLEDList(33, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][1] = " & Dashboard.patternLEDList(33, 1) & ";"
            End If
            If (Dashboard.patternLEDList(33, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][2] = " & Dashboard.patternLEDList(33, 2) & ";"
            End If
            If (Dashboard.patternLEDList(34, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][0] = " & Dashboard.patternLEDList(34, 0) & ";"
            End If
            If (Dashboard.patternLEDList(34, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][1] = " & Dashboard.patternLEDList(34, 1) & ";"
            End If
            If (Dashboard.patternLEDList(34, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][2] = " & Dashboard.patternLEDList(34, 2) & ";"
            End If
            If (Dashboard.patternLEDList(35, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][0] = " & Dashboard.patternLEDList(35, 0) & ";"
            End If
            If (Dashboard.patternLEDList(35, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][1] = " & Dashboard.patternLEDList(35, 1) & ";"
            End If
            If (Dashboard.patternLEDList(35, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][2] = " & Dashboard.patternLEDList(35, 2) & ";"
            End If
            If (Dashboard.patternLEDList(36, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][0] = " & Dashboard.patternLEDList(36, 0) & ";"
            End If
            If (Dashboard.patternLEDList(36, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][1] = " & Dashboard.patternLEDList(36, 1) & ";"
            End If
            If (Dashboard.patternLEDList(36, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][2] = " & Dashboard.patternLEDList(36, 2) & ";"
            End If
            If (Dashboard.patternLEDList(37, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][0] = " & Dashboard.patternLEDList(37, 0) & ";"
            End If
            If (Dashboard.patternLEDList(37, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][1] = " & Dashboard.patternLEDList(37, 1) & ";"
            End If
            If (Dashboard.patternLEDList(37, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][2] = " & Dashboard.patternLEDList(37, 2) & ";"
            End If
            If (Dashboard.patternLEDList(38, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][0] = " & Dashboard.patternLEDList(38, 0) & ";"
            End If
            If (Dashboard.patternLEDList(38, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][1] = " & Dashboard.patternLEDList(38, 1) & ";"
            End If
            If (Dashboard.patternLEDList(38, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][2] = " & Dashboard.patternLEDList(38, 2) & ";"
            End If
            If (Dashboard.patternLEDList(39, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][0] = " & Dashboard.patternLEDList(39, 0) & ";"
            End If
            If (Dashboard.patternLEDList(39, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][1] = " & Dashboard.patternLEDList(39, 1) & ";"
            End If
            If (Dashboard.patternLEDList(39, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][2] = " & Dashboard.patternLEDList(39, 2) & ";"
            End If
            If (Dashboard.patternLEDList(40, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][0] = " & Dashboard.patternLEDList(40, 0) & ";"
            End If
            If (Dashboard.patternLEDList(40, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][1] = " & Dashboard.patternLEDList(40, 1) & ";"
            End If
            If (Dashboard.patternLEDList(40, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][2] = " & Dashboard.patternLEDList(40, 2) & ";"
            End If
            If (Dashboard.patternLEDList(49, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][0] = " & Dashboard.patternLEDList(49, 0) & ";"
            End If
            If (Dashboard.patternLEDList(49, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][1] = " & Dashboard.patternLEDList(49, 1) & ";"
            End If
            If (Dashboard.patternLEDList(49, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][2] = " & Dashboard.patternLEDList(49, 2) & ";"
            End If
            If (Dashboard.patternLEDList(50, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][0] = " & Dashboard.patternLEDList(50, 0) & ";"
            End If
            If (Dashboard.patternLEDList(50, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][1] = " & Dashboard.patternLEDList(50, 1) & ";"
            End If
            If (Dashboard.patternLEDList(50, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][2] = " & Dashboard.patternLEDList(50, 2) & ";"
            End If
            If (Dashboard.patternLEDList(51, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][0] = " & Dashboard.patternLEDList(51, 0) & ";"
            End If
            If (Dashboard.patternLEDList(51, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][1] = " & Dashboard.patternLEDList(51, 1) & ";"
            End If
            If (Dashboard.patternLEDList(51, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][2] = " & Dashboard.patternLEDList(51, 2) & ";"
            End If
            If (Dashboard.patternLEDList(52, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][0] = " & Dashboard.patternLEDList(52, 0) & ";"
            End If
            If (Dashboard.patternLEDList(52, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][1] = " & Dashboard.patternLEDList(52, 1) & ";"
            End If
            If (Dashboard.patternLEDList(52, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][2] = " & Dashboard.patternLEDList(52, 2) & ";"
            End If
            If (Dashboard.patternLEDList(53, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][0] = " & Dashboard.patternLEDList(53, 0) & ";"
            End If
            If (Dashboard.patternLEDList(53, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][1] = " & Dashboard.patternLEDList(53, 1) & ";"
            End If
            If (Dashboard.patternLEDList(53, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][2] = " & Dashboard.patternLEDList(53, 2) & ";"
            End If
            If (Dashboard.patternLEDList(54, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][0] = " & Dashboard.patternLEDList(54, 0) & ";"
            End If
            If (Dashboard.patternLEDList(54, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][1] = " & Dashboard.patternLEDList(54, 1) & ";"
            End If
            If (Dashboard.patternLEDList(54, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][2] = " & Dashboard.patternLEDList(54, 2) & ";"
            End If
            If (Dashboard.patternLEDList(55, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][0] = " & Dashboard.patternLEDList(55, 0) & ";"
            End If
            If (Dashboard.patternLEDList(55, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][1] = " & Dashboard.patternLEDList(55, 1) & ";"
            End If
            If (Dashboard.patternLEDList(55, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][2] = " & Dashboard.patternLEDList(55, 2) & ";"
            End If
            If (Dashboard.patternLEDList(56, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][0] = " & Dashboard.patternLEDList(56, 0) & ";"
            End If
            If (Dashboard.patternLEDList(56, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][1] = " & Dashboard.patternLEDList(56, 1) & ";"
            End If
            If (Dashboard.patternLEDList(56, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][2] = " & Dashboard.patternLEDList(56, 2) & ";"
            End If
            If (Dashboard.patternLEDList(65, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][0] = " & Dashboard.patternLEDList(65, 0) & ";"
            End If
            If (Dashboard.patternLEDList(65, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][1] = " & Dashboard.patternLEDList(65, 1) & ";"
            End If
            If (Dashboard.patternLEDList(65, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][2] = " & Dashboard.patternLEDList(65, 2) & ";"
            End If
            If (Dashboard.patternLEDList(66, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][0] = " & Dashboard.patternLEDList(66, 0) & ";"
            End If
            If (Dashboard.patternLEDList(66, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][1] = " & Dashboard.patternLEDList(66, 1) & ";"
            End If
            If (Dashboard.patternLEDList(66, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][2] = " & Dashboard.patternLEDList(66, 2) & ";"
            End If
            If (Dashboard.patternLEDList(67, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][0] = " & Dashboard.patternLEDList(67, 0) & ";"
            End If
            If (Dashboard.patternLEDList(67, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][1] = " & Dashboard.patternLEDList(67, 1) & ";"
            End If
            If (Dashboard.patternLEDList(67, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][2] = " & Dashboard.patternLEDList(67, 2) & ";"
            End If
            If (Dashboard.patternLEDList(68, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][0] = " & Dashboard.patternLEDList(68, 0) & ";"
            End If
            If (Dashboard.patternLEDList(68, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][1] = " & Dashboard.patternLEDList(68, 1) & ";"
            End If
            If (Dashboard.patternLEDList(68, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][2] = " & Dashboard.patternLEDList(68, 2) & ";"
            End If
            If (Dashboard.patternLEDList(69, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][0] = " & Dashboard.patternLEDList(69, 0) & ";"
            End If
            If (Dashboard.patternLEDList(69, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][1] = " & Dashboard.patternLEDList(69, 1) & ";"
            End If
            If (Dashboard.patternLEDList(69, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][2] = " & Dashboard.patternLEDList(69, 2) & ";"
            End If
            If (Dashboard.patternLEDList(70, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][0] = " & Dashboard.patternLEDList(70, 0) & ";"
            End If
            If (Dashboard.patternLEDList(70, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][1] = " & Dashboard.patternLEDList(70, 1) & ";"
            End If
            If (Dashboard.patternLEDList(70, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][2] = " & Dashboard.patternLEDList(70, 2) & ";"
            End If
            If (Dashboard.patternLEDList(71, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][0] = " & Dashboard.patternLEDList(71, 0) & ";"
            End If
            If (Dashboard.patternLEDList(71, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][1] = " & Dashboard.patternLEDList(71, 1) & ";"
            End If
            If (Dashboard.patternLEDList(71, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][2] = " & Dashboard.patternLEDList(71, 2) & ";"
            End If
            If (Dashboard.patternLEDList(72, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][0] = " & Dashboard.patternLEDList(72, 0) & ";"
            End If
            If (Dashboard.patternLEDList(72, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][1] = " & Dashboard.patternLEDList(72, 1) & ";"
            End If
            If (Dashboard.patternLEDList(72, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][2] = " & Dashboard.patternLEDList(72, 2) & ";"
            End If
            If (Dashboard.patternLEDList(81, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][0] = " & Dashboard.patternLEDList(81, 0) & ";"
            End If
            If (Dashboard.patternLEDList(81, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][1] = " & Dashboard.patternLEDList(81, 1) & ";"
            End If
            If (Dashboard.patternLEDList(81, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][2] = " & Dashboard.patternLEDList(81, 2) & ";"
            End If
            If (Dashboard.patternLEDList(82, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][0] = " & Dashboard.patternLEDList(82, 0) & ";"
            End If
            If (Dashboard.patternLEDList(82, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][1] = " & Dashboard.patternLEDList(82, 1) & ";"
            End If
            If (Dashboard.patternLEDList(82, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][2] = " & Dashboard.patternLEDList(82, 2) & ";"
            End If
            If (Dashboard.patternLEDList(83, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][0] = " & Dashboard.patternLEDList(83, 0) & ";"
            End If
            If (Dashboard.patternLEDList(83, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][1] = " & Dashboard.patternLEDList(83, 1) & ";"
            End If
            If (Dashboard.patternLEDList(83, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][2] = " & Dashboard.patternLEDList(83, 2) & ";"
            End If
            If (Dashboard.patternLEDList(84, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][0] = " & Dashboard.patternLEDList(84, 0) & ";"
            End If
            If (Dashboard.patternLEDList(84, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][1] = " & Dashboard.patternLEDList(84, 1) & ";"
            End If
            If (Dashboard.patternLEDList(84, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][2] = " & Dashboard.patternLEDList(84, 2) & ";"
            End If
            If (Dashboard.patternLEDList(85, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][0] = " & Dashboard.patternLEDList(85, 0) & ";"
            End If
            If (Dashboard.patternLEDList(85, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][1] = " & Dashboard.patternLEDList(85, 1) & ";"
            End If
            If (Dashboard.patternLEDList(85, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][2] = " & Dashboard.patternLEDList(85, 2) & ";"
            End If
            If (Dashboard.patternLEDList(86, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][0] = " & Dashboard.patternLEDList(86, 0) & ";"
            End If
            If (Dashboard.patternLEDList(86, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][1] = " & Dashboard.patternLEDList(86, 1) & ";"
            End If
            If (Dashboard.patternLEDList(86, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][2] = " & Dashboard.patternLEDList(86, 2) & ";"
            End If
            If (Dashboard.patternLEDList(87, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][0] = " & Dashboard.patternLEDList(87, 0) & ";"
            End If
            If (Dashboard.patternLEDList(87, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][1] = " & Dashboard.patternLEDList(87, 1) & ";"
            End If
            If (Dashboard.patternLEDList(87, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][2] = " & Dashboard.patternLEDList(87, 2) & ";"
            End If
            If (Dashboard.patternLEDList(88, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][0] = " & Dashboard.patternLEDList(88, 0) & ";"
            End If
            If (Dashboard.patternLEDList(88, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][1] = " & Dashboard.patternLEDList(88, 1) & ";"
            End If
            If (Dashboard.patternLEDList(88, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][2] = " & Dashboard.patternLEDList(88, 2) & ";"
            End If
            If (Dashboard.patternLEDList(97, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][0] = " & Dashboard.patternLEDList(97, 0) & ";"
            End If
            If (Dashboard.patternLEDList(97, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][1] = " & Dashboard.patternLEDList(97, 1) & ";"
            End If
            If (Dashboard.patternLEDList(97, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][2] = " & Dashboard.patternLEDList(97, 2) & ";"
            End If
            If (Dashboard.patternLEDList(98, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][0] = " & Dashboard.patternLEDList(98, 0) & ";"
            End If
            If (Dashboard.patternLEDList(98, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][1] = " & Dashboard.patternLEDList(98, 1) & ";"
            End If
            If (Dashboard.patternLEDList(98, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][2] = " & Dashboard.patternLEDList(98, 2) & ";"
            End If
            If (Dashboard.patternLEDList(99, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][0] = " & Dashboard.patternLEDList(99, 0) & ";"
            End If
            If (Dashboard.patternLEDList(99, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][1] = " & Dashboard.patternLEDList(99, 1) & ";"
            End If
            If (Dashboard.patternLEDList(99, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][2] = " & Dashboard.patternLEDList(99, 2) & ";"
            End If
            If (Dashboard.patternLEDList(100, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][0] = " & Dashboard.patternLEDList(100, 0) & ";"
            End If
            If (Dashboard.patternLEDList(100, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][1] = " & Dashboard.patternLEDList(100, 1) & ";"
            End If
            If (Dashboard.patternLEDList(100, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][2] = " & Dashboard.patternLEDList(100, 2) & ";"
            End If
            If (Dashboard.patternLEDList(101, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][0] = " & Dashboard.patternLEDList(101, 0) & ";"
            End If
            If (Dashboard.patternLEDList(101, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][1] = " & Dashboard.patternLEDList(101, 1) & ";"
            End If
            If (Dashboard.patternLEDList(101, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][2] = " & Dashboard.patternLEDList(101, 2) & ";"
            End If
            If (Dashboard.patternLEDList(102, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][0] = " & Dashboard.patternLEDList(102, 0) & ";"
            End If
            If (Dashboard.patternLEDList(102, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][1] = " & Dashboard.patternLEDList(102, 1) & ";"
            End If
            If (Dashboard.patternLEDList(102, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][2] = " & Dashboard.patternLEDList(102, 2) & ";"
            End If
            If (Dashboard.patternLEDList(103, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][0] = " & Dashboard.patternLEDList(103, 0) & ";"
            End If
            If (Dashboard.patternLEDList(103, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][1] = " & Dashboard.patternLEDList(103, 1) & ";"
            End If
            If (Dashboard.patternLEDList(103, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][2] = " & Dashboard.patternLEDList(103, 2) & ";"
            End If
            If (Dashboard.patternLEDList(104, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][0] = " & Dashboard.patternLEDList(104, 0) & ";"
            End If
            If (Dashboard.patternLEDList(104, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][1] = " & Dashboard.patternLEDList(104, 1) & ";"
            End If
            If (Dashboard.patternLEDList(104, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][2] = " & Dashboard.patternLEDList(104, 2) & ";"
            End If
            If (Dashboard.patternLEDList(113, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][0] = " & Dashboard.patternLEDList(113, 0) & ";"
            End If
            If (Dashboard.patternLEDList(113, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][1] = " & Dashboard.patternLEDList(113, 1) & ";"
            End If
            If (Dashboard.patternLEDList(113, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][2] = " & Dashboard.patternLEDList(113, 2) & ";"
            End If
            If (Dashboard.patternLEDList(114, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][0] = " & Dashboard.patternLEDList(114, 0) & ";"
            End If
            If (Dashboard.patternLEDList(114, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][1] = " & Dashboard.patternLEDList(114, 1) & ";"
            End If
            If (Dashboard.patternLEDList(114, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][2] = " & Dashboard.patternLEDList(114, 2) & ";"
            End If
            If (Dashboard.patternLEDList(115, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][0] = " & Dashboard.patternLEDList(115, 0) & ";"
            End If
            If (Dashboard.patternLEDList(115, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][1] = " & Dashboard.patternLEDList(115, 1) & ";"
            End If
            If (Dashboard.patternLEDList(115, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][2] = " & Dashboard.patternLEDList(115, 2) & ";"
            End If
            If (Dashboard.patternLEDList(116, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][0] = " & Dashboard.patternLEDList(116, 0) & ";"
            End If
            If (Dashboard.patternLEDList(116, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][1] = " & Dashboard.patternLEDList(116, 1) & ";"
            End If
            If (Dashboard.patternLEDList(116, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][2] = " & Dashboard.patternLEDList(116, 2) & ";"
            End If
            If (Dashboard.patternLEDList(117, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][0] = " & Dashboard.patternLEDList(117, 0) & ";"
            End If
            If (Dashboard.patternLEDList(117, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][1] = " & Dashboard.patternLEDList(117, 1) & ";"
            End If
            If (Dashboard.patternLEDList(117, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][2] = " & Dashboard.patternLEDList(117, 2) & ";"
            End If
            If (Dashboard.patternLEDList(118, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][0] = " & Dashboard.patternLEDList(118, 0) & ";"
            End If
            If (Dashboard.patternLEDList(118, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][1] = " & Dashboard.patternLEDList(118, 1) & ";"
            End If
            If (Dashboard.patternLEDList(118, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][2] = " & Dashboard.patternLEDList(118, 2) & ";"
            End If
            If (Dashboard.patternLEDList(119, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][0] = " & Dashboard.patternLEDList(119, 0) & ";"
            End If
            If (Dashboard.patternLEDList(119, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][1] = " & Dashboard.patternLEDList(119, 1) & ";"
            End If
            If (Dashboard.patternLEDList(119, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][2] = " & Dashboard.patternLEDList(119, 2) & ";"
            End If
            If (Dashboard.patternLEDList(120, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][0] = " & Dashboard.patternLEDList(120, 0) & ";"
            End If
            If (Dashboard.patternLEDList(120, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][1] = " & Dashboard.patternLEDList(120, 1) & ";"
            End If
            If (Dashboard.patternLEDList(120, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][2] = " & Dashboard.patternLEDList(120, 2) & ";"
            End If
            If (Dashboard.patternLEDList(129, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][0] = " & Dashboard.patternLEDList(129, 0) & ";"
            End If
            If (Dashboard.patternLEDList(129, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][1] = " & Dashboard.patternLEDList(129, 1) & ";"
            End If
            If (Dashboard.patternLEDList(129, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][2] = " & Dashboard.patternLEDList(129, 2) & ";"
            End If
            If (Dashboard.patternLEDList(130, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][0] = " & Dashboard.patternLEDList(130, 0) & ";"
            End If
            If (Dashboard.patternLEDList(130, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][1] = " & Dashboard.patternLEDList(130, 1) & ";"
            End If
            If (Dashboard.patternLEDList(130, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][2] = " & Dashboard.patternLEDList(130, 2) & ";"
            End If
            If (Dashboard.patternLEDList(131, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][0] = " & Dashboard.patternLEDList(131, 0) & ";"
            End If
            If (Dashboard.patternLEDList(131, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][1] = " & Dashboard.patternLEDList(131, 1) & ";"
            End If
            If (Dashboard.patternLEDList(131, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][2] = " & Dashboard.patternLEDList(131, 2) & ";"
            End If
            If (Dashboard.patternLEDList(132, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][0] = " & Dashboard.patternLEDList(132, 0) & ";"
            End If
            If (Dashboard.patternLEDList(132, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][1] = " & Dashboard.patternLEDList(132, 1) & ";"
            End If
            If (Dashboard.patternLEDList(132, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][2] = " & Dashboard.patternLEDList(132, 2) & ";"
            End If
            If (Dashboard.patternLEDList(133, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][0] = " & Dashboard.patternLEDList(133, 0) & ";"
            End If
            If (Dashboard.patternLEDList(133, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][1] = " & Dashboard.patternLEDList(133, 1) & ";"
            End If
            If (Dashboard.patternLEDList(133, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][2] = " & Dashboard.patternLEDList(133, 2) & ";"
            End If
            If (Dashboard.patternLEDList(134, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][0] = " & Dashboard.patternLEDList(134, 0) & ";"
            End If
            If (Dashboard.patternLEDList(134, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][1] = " & Dashboard.patternLEDList(134, 1) & ";"
            End If
            If (Dashboard.patternLEDList(134, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][2] = " & Dashboard.patternLEDList(134, 2) & ";"
            End If
            If (Dashboard.patternLEDList(135, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][0] = " & Dashboard.patternLEDList(135, 0) & ";"
            End If
            If (Dashboard.patternLEDList(135, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][1] = " & Dashboard.patternLEDList(135, 1) & ";"
            End If
            If (Dashboard.patternLEDList(135, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][2] = " & Dashboard.patternLEDList(135, 2) & ";"
            End If
            If (Dashboard.patternLEDList(136, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][0] = " & Dashboard.patternLEDList(136, 0) & ";"
            End If
            If (Dashboard.patternLEDList(136, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][1] = " & Dashboard.patternLEDList(136, 1) & ";"
            End If
            If (Dashboard.patternLEDList(136, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][2] = " & Dashboard.patternLEDList(136, 2) & ";"
            End If
            If (Dashboard.patternLEDList(145, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][0] = " & Dashboard.patternLEDList(145, 0) & ";"
            End If
            If (Dashboard.patternLEDList(145, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][1] = " & Dashboard.patternLEDList(145, 1) & ";"
            End If
            If (Dashboard.patternLEDList(145, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][2] = " & Dashboard.patternLEDList(145, 2) & ";"
            End If
            If (Dashboard.patternLEDList(146, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][0] = " & Dashboard.patternLEDList(146, 0) & ";"
            End If
            If (Dashboard.patternLEDList(146, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][1] = " & Dashboard.patternLEDList(146, 1) & ";"
            End If
            If (Dashboard.patternLEDList(146, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][2] = " & Dashboard.patternLEDList(146, 2) & ";"
            End If
            If (Dashboard.patternLEDList(147, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][0] = " & Dashboard.patternLEDList(147, 0) & ";"
            End If
            If (Dashboard.patternLEDList(147, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][1] = " & Dashboard.patternLEDList(147, 1) & ";"
            End If
            If (Dashboard.patternLEDList(147, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][2] = " & Dashboard.patternLEDList(147, 2) & ";"
            End If
            If (Dashboard.patternLEDList(148, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][0] = " & Dashboard.patternLEDList(148, 0) & ";"
            End If
            If (Dashboard.patternLEDList(148, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][1] = " & Dashboard.patternLEDList(148, 1) & ";"
            End If
            If (Dashboard.patternLEDList(148, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][2] = " & Dashboard.patternLEDList(148, 2) & ";"
            End If
            If (Dashboard.patternLEDList(149, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][0] = " & Dashboard.patternLEDList(149, 0) & ";"
            End If
            If (Dashboard.patternLEDList(149, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][1] = " & Dashboard.patternLEDList(149, 1) & ";"
            End If
            If (Dashboard.patternLEDList(149, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][2] = " & Dashboard.patternLEDList(149, 2) & ";"
            End If
            If (Dashboard.patternLEDList(150, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][0] = " & Dashboard.patternLEDList(150, 0) & ";"
            End If
            If (Dashboard.patternLEDList(150, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][1] = " & Dashboard.patternLEDList(150, 1) & ";"
            End If
            If (Dashboard.patternLEDList(150, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][2] = " & Dashboard.patternLEDList(150, 2) & ";"
            End If
            If (Dashboard.patternLEDList(151, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][0] = " & Dashboard.patternLEDList(151, 0) & ";"
            End If
            If (Dashboard.patternLEDList(151, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][1] = " & Dashboard.patternLEDList(151, 1) & ";"
            End If
            If (Dashboard.patternLEDList(151, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][2] = " & Dashboard.patternLEDList(151, 2) & ";"
            End If
            If (Dashboard.patternLEDList(152, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][0] = " & Dashboard.patternLEDList(152, 0) & ";"
            End If
            If (Dashboard.patternLEDList(152, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][1] = " & Dashboard.patternLEDList(152, 1) & ";"
            End If
            If (Dashboard.patternLEDList(152, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][2] = " & Dashboard.patternLEDList(152, 2) & ";"
            End If
            If (Dashboard.patternLEDList(161, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][0] = " & Dashboard.patternLEDList(161, 0) & ";"
            End If
            If (Dashboard.patternLEDList(161, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][1] = " & Dashboard.patternLEDList(161, 1) & ";"
            End If
            If (Dashboard.patternLEDList(161, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][2] = " & Dashboard.patternLEDList(161, 2) & ";"
            End If
            If (Dashboard.patternLEDList(162, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][0] = " & Dashboard.patternLEDList(162, 0) & ";"
            End If
            If (Dashboard.patternLEDList(162, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][1] = " & Dashboard.patternLEDList(162, 1) & ";"
            End If
            If (Dashboard.patternLEDList(162, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][2] = " & Dashboard.patternLEDList(162, 2) & ";"
            End If
            If (Dashboard.patternLEDList(163, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][0] = " & Dashboard.patternLEDList(163, 0) & ";"
            End If
            If (Dashboard.patternLEDList(163, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][1] = " & Dashboard.patternLEDList(163, 1) & ";"
            End If
            If (Dashboard.patternLEDList(163, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][2] = " & Dashboard.patternLEDList(163, 2) & ";"
            End If
            If (Dashboard.patternLEDList(164, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][0] = " & Dashboard.patternLEDList(164, 0) & ";"
            End If
            If (Dashboard.patternLEDList(164, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][1] = " & Dashboard.patternLEDList(164, 1) & ";"
            End If
            If (Dashboard.patternLEDList(164, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][2] = " & Dashboard.patternLEDList(164, 2) & ";"
            End If
            If (Dashboard.patternLEDList(165, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][0] = " & Dashboard.patternLEDList(165, 0) & ";"
            End If
            If (Dashboard.patternLEDList(165, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][1] = " & Dashboard.patternLEDList(165, 1) & ";"
            End If
            If (Dashboard.patternLEDList(165, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][2] = " & Dashboard.patternLEDList(165, 2) & ";"
            End If
            If (Dashboard.patternLEDList(166, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][0] = " & Dashboard.patternLEDList(166, 0) & ";"
            End If
            If (Dashboard.patternLEDList(166, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][1] = " & Dashboard.patternLEDList(166, 1) & ";"
            End If
            If (Dashboard.patternLEDList(166, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][2] = " & Dashboard.patternLEDList(166, 2) & ";"
            End If
            If (Dashboard.patternLEDList(167, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][0] = " & Dashboard.patternLEDList(167, 0) & ";"
            End If
            If (Dashboard.patternLEDList(167, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][1] = " & Dashboard.patternLEDList(167, 1) & ";"
            End If
            If (Dashboard.patternLEDList(167, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][2] = " & Dashboard.patternLEDList(167, 2) & ";"
            End If
            If (Dashboard.patternLEDList(168, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][0] = " & Dashboard.patternLEDList(168, 0) & ";"
            End If
            If (Dashboard.patternLEDList(168, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][1] = " & Dashboard.patternLEDList(168, 1) & ";"
            End If
            If (Dashboard.patternLEDList(168, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][2] = " & Dashboard.patternLEDList(168, 2) & ";"
            End If
            If (Dashboard.patternLEDList(177, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][0] = " & Dashboard.patternLEDList(177, 0) & ";"
            End If
            If (Dashboard.patternLEDList(177, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][1] = " & Dashboard.patternLEDList(177, 1) & ";"
            End If
            If (Dashboard.patternLEDList(177, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][2] = " & Dashboard.patternLEDList(177, 2) & ";"
            End If
            If (Dashboard.patternLEDList(178, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][0] = " & Dashboard.patternLEDList(178, 0) & ";"
            End If
            If (Dashboard.patternLEDList(178, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][1] = " & Dashboard.patternLEDList(178, 1) & ";"
            End If
            If (Dashboard.patternLEDList(178, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][2] = " & Dashboard.patternLEDList(178, 2) & ";"
            End If
            If (Dashboard.patternLEDList(179, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][0] = " & Dashboard.patternLEDList(179, 0) & ";"
            End If
            If (Dashboard.patternLEDList(179, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][1] = " & Dashboard.patternLEDList(179, 1) & ";"
            End If
            If (Dashboard.patternLEDList(179, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][2] = " & Dashboard.patternLEDList(179, 2) & ";"
            End If
            If (Dashboard.patternLEDList(180, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][0] = " & Dashboard.patternLEDList(180, 0) & ";"
            End If
            If (Dashboard.patternLEDList(180, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][1] = " & Dashboard.patternLEDList(180, 1) & ";"
            End If
            If (Dashboard.patternLEDList(180, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][2] = " & Dashboard.patternLEDList(180, 2) & ";"
            End If
            If (Dashboard.patternLEDList(181, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][0] = " & Dashboard.patternLEDList(181, 0) & ";"
            End If
            If (Dashboard.patternLEDList(181, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][1] = " & Dashboard.patternLEDList(181, 1) & ";"
            End If
            If (Dashboard.patternLEDList(181, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][2] = " & Dashboard.patternLEDList(181, 2) & ";"
            End If
            If (Dashboard.patternLEDList(182, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][0] = " & Dashboard.patternLEDList(182, 0) & ";"
            End If
            If (Dashboard.patternLEDList(182, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][1] = " & Dashboard.patternLEDList(182, 1) & ";"
            End If
            If (Dashboard.patternLEDList(182, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][2] = " & Dashboard.patternLEDList(182, 2) & ";"
            End If
            If (Dashboard.patternLEDList(183, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][0] = " & Dashboard.patternLEDList(183, 0) & ";"
            End If
            If (Dashboard.patternLEDList(183, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][1] = " & Dashboard.patternLEDList(183, 1) & ";"
            End If
            If (Dashboard.patternLEDList(183, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][2] = " & Dashboard.patternLEDList(183, 2) & ";"
            End If
            If (Dashboard.patternLEDList(184, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][0] = " & Dashboard.patternLEDList(184, 0) & ";"
            End If
            If (Dashboard.patternLEDList(184, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][1] = " & Dashboard.patternLEDList(184, 1) & ";"
            End If
            If (Dashboard.patternLEDList(184, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][2] = " & Dashboard.patternLEDList(184, 2) & ";"
            End If
            If (Dashboard.patternLEDList(193, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][0] = " & Dashboard.patternLEDList(193, 0) & ";"
            End If
            If (Dashboard.patternLEDList(193, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][1] = " & Dashboard.patternLEDList(193, 1) & ";"
            End If
            If (Dashboard.patternLEDList(193, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][2] = " & Dashboard.patternLEDList(193, 2) & ";"
            End If
            If (Dashboard.patternLEDList(194, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][0] = " & Dashboard.patternLEDList(194, 0) & ";"
            End If
            If (Dashboard.patternLEDList(194, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][1] = " & Dashboard.patternLEDList(194, 1) & ";"
            End If
            If (Dashboard.patternLEDList(194, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][2] = " & Dashboard.patternLEDList(194, 2) & ";"
            End If
            If (Dashboard.patternLEDList(195, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][0] = " & Dashboard.patternLEDList(195, 0) & ";"
            End If
            If (Dashboard.patternLEDList(195, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][1] = " & Dashboard.patternLEDList(195, 1) & ";"
            End If
            If (Dashboard.patternLEDList(195, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][2] = " & Dashboard.patternLEDList(195, 2) & ";"
            End If
            If (Dashboard.patternLEDList(196, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][0] = " & Dashboard.patternLEDList(196, 0) & ";"
            End If
            If (Dashboard.patternLEDList(196, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][1] = " & Dashboard.patternLEDList(196, 1) & ";"
            End If
            If (Dashboard.patternLEDList(196, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][2] = " & Dashboard.patternLEDList(196, 2) & ";"
            End If
            If (Dashboard.patternLEDList(197, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][0] = " & Dashboard.patternLEDList(197, 0) & ";"
            End If
            If (Dashboard.patternLEDList(197, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][1] = " & Dashboard.patternLEDList(197, 1) & ";"
            End If
            If (Dashboard.patternLEDList(197, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][2] = " & Dashboard.patternLEDList(197, 2) & ";"
            End If
            If (Dashboard.patternLEDList(198, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][0] = " & Dashboard.patternLEDList(198, 0) & ";"
            End If
            If (Dashboard.patternLEDList(198, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][1] = " & Dashboard.patternLEDList(198, 1) & ";"
            End If
            If (Dashboard.patternLEDList(198, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][2] = " & Dashboard.patternLEDList(198, 2) & ";"
            End If
            If (Dashboard.patternLEDList(199, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][0] = " & Dashboard.patternLEDList(199, 0) & ";"
            End If
            If (Dashboard.patternLEDList(199, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][1] = " & Dashboard.patternLEDList(199, 1) & ";"
            End If
            If (Dashboard.patternLEDList(199, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][2] = " & Dashboard.patternLEDList(199, 2) & ";"
            End If
            If (Dashboard.patternLEDList(200, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][0] = " & Dashboard.patternLEDList(200, 0) & ";"
            End If
            If (Dashboard.patternLEDList(200, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][1] = " & Dashboard.patternLEDList(200, 1) & ";"
            End If
            If (Dashboard.patternLEDList(200, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][2] = " & Dashboard.patternLEDList(200, 2) & ";"
            End If




            If (Dashboard.patternLEDList(16, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][0] = " & Dashboard.patternLEDList(16, 0) & ";"
            End If
            If (Dashboard.patternLEDList(16, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][1] = " & Dashboard.patternLEDList(16, 1) & ";"
            End If
            If (Dashboard.patternLEDList(16, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][2] = " & Dashboard.patternLEDList(16, 2) & ";"
            End If
            If (Dashboard.patternLEDList(15, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][0] = " & Dashboard.patternLEDList(15, 0) & ";"
            End If
            If (Dashboard.patternLEDList(15, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][1] = " & Dashboard.patternLEDList(15, 1) & ";"
            End If
            If (Dashboard.patternLEDList(15, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][2] = " & Dashboard.patternLEDList(15, 2) & ";"
            End If
            If (Dashboard.patternLEDList(14, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][0] = " & Dashboard.patternLEDList(14, 0) & ";"
            End If
            If (Dashboard.patternLEDList(14, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][1] = " & Dashboard.patternLEDList(14, 1) & ";"
            End If
            If (Dashboard.patternLEDList(14, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][2] = " & Dashboard.patternLEDList(14, 2) & ";"
            End If
            If (Dashboard.patternLEDList(13, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][0] = " & Dashboard.patternLEDList(13, 0) & ";"
            End If
            If (Dashboard.patternLEDList(13, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][1] = " & Dashboard.patternLEDList(13, 1) & ";"
            End If
            If (Dashboard.patternLEDList(13, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][2] = " & Dashboard.patternLEDList(13, 2) & ";"
            End If
            If (Dashboard.patternLEDList(12, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][0] = " & Dashboard.patternLEDList(12, 0) & ";"
            End If
            If (Dashboard.patternLEDList(12, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][1] = " & Dashboard.patternLEDList(12, 1) & ";"
            End If
            If (Dashboard.patternLEDList(12, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][2] = " & Dashboard.patternLEDList(12, 2) & ";"
            End If
            If (Dashboard.patternLEDList(11, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][0] = " & Dashboard.patternLEDList(11, 0) & ";"
            End If
            If (Dashboard.patternLEDList(11, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][1] = " & Dashboard.patternLEDList(11, 1) & ";"
            End If
            If (Dashboard.patternLEDList(11, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][2] = " & Dashboard.patternLEDList(11, 2) & ";"
            End If
            If (Dashboard.patternLEDList(10, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][0] = " & Dashboard.patternLEDList(10, 0) & ";"
            End If
            If (Dashboard.patternLEDList(10, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][1] = " & Dashboard.patternLEDList(10, 1) & ";"
            End If
            If (Dashboard.patternLEDList(10, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][2] = " & Dashboard.patternLEDList(10, 2) & ";"
            End If
            If (Dashboard.patternLEDList(9, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][0] = " & Dashboard.patternLEDList(9, 0) & ";"
            End If
            If (Dashboard.patternLEDList(9, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][1] = " & Dashboard.patternLEDList(9, 1) & ";"
            End If
            If (Dashboard.patternLEDList(9, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][2] = " & Dashboard.patternLEDList(9, 2) & ";"
            End If
            If (Dashboard.patternLEDList(32, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][0] = " & Dashboard.patternLEDList(32, 0) & ";"
            End If
            If (Dashboard.patternLEDList(32, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][1] = " & Dashboard.patternLEDList(32, 1) & ";"
            End If
            If (Dashboard.patternLEDList(32, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][2] = " & Dashboard.patternLEDList(32, 2) & ";"
            End If
            If (Dashboard.patternLEDList(31, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][0] = " & Dashboard.patternLEDList(31, 0) & ";"
            End If
            If (Dashboard.patternLEDList(31, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][1] = " & Dashboard.patternLEDList(31, 1) & ";"
            End If
            If (Dashboard.patternLEDList(31, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][2] = " & Dashboard.patternLEDList(31, 2) & ";"
            End If
            If (Dashboard.patternLEDList(30, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][0] = " & Dashboard.patternLEDList(30, 0) & ";"
            End If
            If (Dashboard.patternLEDList(30, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][1] = " & Dashboard.patternLEDList(30, 1) & ";"
            End If
            If (Dashboard.patternLEDList(30, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][2] = " & Dashboard.patternLEDList(30, 2) & ";"
            End If
            If (Dashboard.patternLEDList(29, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][0] = " & Dashboard.patternLEDList(29, 0) & ";"
            End If
            If (Dashboard.patternLEDList(29, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][1] = " & Dashboard.patternLEDList(29, 1) & ";"
            End If
            If (Dashboard.patternLEDList(29, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][2] = " & Dashboard.patternLEDList(29, 2) & ";"
            End If
            If (Dashboard.patternLEDList(28, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][0] = " & Dashboard.patternLEDList(28, 0) & ";"
            End If
            If (Dashboard.patternLEDList(28, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][1] = " & Dashboard.patternLEDList(28, 1) & ";"
            End If
            If (Dashboard.patternLEDList(28, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][2] = " & Dashboard.patternLEDList(28, 2) & ";"
            End If
            If (Dashboard.patternLEDList(27, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][0] = " & Dashboard.patternLEDList(27, 0) & ";"
            End If
            If (Dashboard.patternLEDList(27, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][1] = " & Dashboard.patternLEDList(27, 1) & ";"
            End If
            If (Dashboard.patternLEDList(27, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][2] = " & Dashboard.patternLEDList(27, 2) & ";"
            End If
            If (Dashboard.patternLEDList(26, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][0] = " & Dashboard.patternLEDList(26, 0) & ";"
            End If
            If (Dashboard.patternLEDList(26, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][1] = " & Dashboard.patternLEDList(26, 1) & ";"
            End If
            If (Dashboard.patternLEDList(26, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][2] = " & Dashboard.patternLEDList(26, 2) & ";"
            End If
            If (Dashboard.patternLEDList(25, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][0] = " & Dashboard.patternLEDList(25, 0) & ";"
            End If
            If (Dashboard.patternLEDList(25, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][1] = " & Dashboard.patternLEDList(25, 1) & ";"
            End If
            If (Dashboard.patternLEDList(25, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][2] = " & Dashboard.patternLEDList(25, 2) & ";"
            End If
            If (Dashboard.patternLEDList(48, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][0] = " & Dashboard.patternLEDList(48, 0) & ";"
            End If
            If (Dashboard.patternLEDList(48, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][1] = " & Dashboard.patternLEDList(48, 1) & ";"
            End If
            If (Dashboard.patternLEDList(48, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][2] = " & Dashboard.patternLEDList(48, 2) & ";"
            End If
            If (Dashboard.patternLEDList(47, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][0] = " & Dashboard.patternLEDList(47, 0) & ";"
            End If
            If (Dashboard.patternLEDList(47, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][1] = " & Dashboard.patternLEDList(47, 1) & ";"
            End If
            If (Dashboard.patternLEDList(47, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][2] = " & Dashboard.patternLEDList(47, 2) & ";"
            End If
            If (Dashboard.patternLEDList(46, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][0] = " & Dashboard.patternLEDList(46, 0) & ";"
            End If
            If (Dashboard.patternLEDList(46, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][1] = " & Dashboard.patternLEDList(46, 1) & ";"
            End If
            If (Dashboard.patternLEDList(46, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][2] = " & Dashboard.patternLEDList(46, 2) & ";"
            End If
            If (Dashboard.patternLEDList(45, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][0] = " & Dashboard.patternLEDList(45, 0) & ";"
            End If
            If (Dashboard.patternLEDList(45, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][1] = " & Dashboard.patternLEDList(45, 1) & ";"
            End If
            If (Dashboard.patternLEDList(45, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][2] = " & Dashboard.patternLEDList(45, 2) & ";"
            End If
            If (Dashboard.patternLEDList(44, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][0] = " & Dashboard.patternLEDList(44, 0) & ";"
            End If
            If (Dashboard.patternLEDList(44, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][1] = " & Dashboard.patternLEDList(44, 1) & ";"
            End If
            If (Dashboard.patternLEDList(44, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][2] = " & Dashboard.patternLEDList(44, 2) & ";"
            End If
            If (Dashboard.patternLEDList(43, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][0] = " & Dashboard.patternLEDList(43, 0) & ";"
            End If
            If (Dashboard.patternLEDList(43, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][1] = " & Dashboard.patternLEDList(43, 1) & ";"
            End If
            If (Dashboard.patternLEDList(43, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][2] = " & Dashboard.patternLEDList(43, 2) & ";"
            End If
            If (Dashboard.patternLEDList(42, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][0] = " & Dashboard.patternLEDList(42, 0) & ";"
            End If
            If (Dashboard.patternLEDList(42, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][1] = " & Dashboard.patternLEDList(42, 1) & ";"
            End If
            If (Dashboard.patternLEDList(42, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][2] = " & Dashboard.patternLEDList(42, 2) & ";"
            End If
            If (Dashboard.patternLEDList(41, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][0] = " & Dashboard.patternLEDList(41, 0) & ";"
            End If
            If (Dashboard.patternLEDList(41, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][1] = " & Dashboard.patternLEDList(41, 1) & ";"
            End If
            If (Dashboard.patternLEDList(41, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][2] = " & Dashboard.patternLEDList(41, 2) & ";"
            End If
            If (Dashboard.patternLEDList(64, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][0] = " & Dashboard.patternLEDList(64, 0) & ";"
            End If
            If (Dashboard.patternLEDList(64, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][1] = " & Dashboard.patternLEDList(64, 1) & ";"
            End If
            If (Dashboard.patternLEDList(64, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][2] = " & Dashboard.patternLEDList(64, 2) & ";"
            End If
            If (Dashboard.patternLEDList(63, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][0] = " & Dashboard.patternLEDList(63, 0) & ";"
            End If
            If (Dashboard.patternLEDList(63, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][1] = " & Dashboard.patternLEDList(63, 1) & ";"
            End If
            If (Dashboard.patternLEDList(63, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][2] = " & Dashboard.patternLEDList(63, 2) & ";"
            End If
            If (Dashboard.patternLEDList(62, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][0] = " & Dashboard.patternLEDList(62, 0) & ";"
            End If
            If (Dashboard.patternLEDList(62, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][1] = " & Dashboard.patternLEDList(62, 1) & ";"
            End If
            If (Dashboard.patternLEDList(62, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][2] = " & Dashboard.patternLEDList(62, 2) & ";"
            End If
            If (Dashboard.patternLEDList(61, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][0] = " & Dashboard.patternLEDList(61, 0) & ";"
            End If
            If (Dashboard.patternLEDList(61, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][1] = " & Dashboard.patternLEDList(61, 1) & ";"
            End If
            If (Dashboard.patternLEDList(61, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][2] = " & Dashboard.patternLEDList(61, 2) & ";"
            End If
            If (Dashboard.patternLEDList(60, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][0] = " & Dashboard.patternLEDList(60, 0) & ";"
            End If
            If (Dashboard.patternLEDList(60, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][1] = " & Dashboard.patternLEDList(60, 1) & ";"
            End If
            If (Dashboard.patternLEDList(60, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][2] = " & Dashboard.patternLEDList(60, 2) & ";"
            End If
            If (Dashboard.patternLEDList(59, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][0] = " & Dashboard.patternLEDList(59, 0) & ";"
            End If
            If (Dashboard.patternLEDList(59, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][1] = " & Dashboard.patternLEDList(59, 1) & ";"
            End If
            If (Dashboard.patternLEDList(59, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][2] = " & Dashboard.patternLEDList(59, 2) & ";"
            End If
            If (Dashboard.patternLEDList(58, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][0] = " & Dashboard.patternLEDList(58, 0) & ";"
            End If
            If (Dashboard.patternLEDList(58, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][1] = " & Dashboard.patternLEDList(58, 1) & ";"
            End If
            If (Dashboard.patternLEDList(58, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][2] = " & Dashboard.patternLEDList(58, 2) & ";"
            End If
            If (Dashboard.patternLEDList(57, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][0] = " & Dashboard.patternLEDList(57, 0) & ";"
            End If
            If (Dashboard.patternLEDList(57, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][1] = " & Dashboard.patternLEDList(57, 1) & ";"
            End If
            If (Dashboard.patternLEDList(57, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][2] = " & Dashboard.patternLEDList(57, 2) & ";"
            End If
            If (Dashboard.patternLEDList(80, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][0] = " & Dashboard.patternLEDList(80, 0) & ";"
            End If
            If (Dashboard.patternLEDList(80, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][1] = " & Dashboard.patternLEDList(80, 1) & ";"
            End If
            If (Dashboard.patternLEDList(80, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][2] = " & Dashboard.patternLEDList(80, 2) & ";"
            End If
            If (Dashboard.patternLEDList(79, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][0] = " & Dashboard.patternLEDList(79, 0) & ";"
            End If
            If (Dashboard.patternLEDList(79, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][1] = " & Dashboard.patternLEDList(79, 1) & ";"
            End If
            If (Dashboard.patternLEDList(79, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][2] = " & Dashboard.patternLEDList(79, 2) & ";"
            End If
            If (Dashboard.patternLEDList(78, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][0] = " & Dashboard.patternLEDList(78, 0) & ";"
            End If
            If (Dashboard.patternLEDList(78, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][1] = " & Dashboard.patternLEDList(78, 1) & ";"
            End If
            If (Dashboard.patternLEDList(78, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][2] = " & Dashboard.patternLEDList(78, 2) & ";"
            End If
            If (Dashboard.patternLEDList(77, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][0] = " & Dashboard.patternLEDList(77, 0) & ";"
            End If
            If (Dashboard.patternLEDList(77, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][1] = " & Dashboard.patternLEDList(77, 1) & ";"
            End If
            If (Dashboard.patternLEDList(77, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][2] = " & Dashboard.patternLEDList(77, 2) & ";"
            End If
            If (Dashboard.patternLEDList(76, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][0] = " & Dashboard.patternLEDList(76, 0) & ";"
            End If
            If (Dashboard.patternLEDList(76, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][1] = " & Dashboard.patternLEDList(76, 1) & ";"
            End If
            If (Dashboard.patternLEDList(76, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][2] = " & Dashboard.patternLEDList(76, 2) & ";"
            End If
            If (Dashboard.patternLEDList(75, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][0] = " & Dashboard.patternLEDList(75, 0) & ";"
            End If
            If (Dashboard.patternLEDList(75, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][1] = " & Dashboard.patternLEDList(75, 1) & ";"
            End If
            If (Dashboard.patternLEDList(75, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][2] = " & Dashboard.patternLEDList(75, 2) & ";"
            End If
            If (Dashboard.patternLEDList(74, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][0] = " & Dashboard.patternLEDList(74, 0) & ";"
            End If
            If (Dashboard.patternLEDList(74, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][1] = " & Dashboard.patternLEDList(74, 1) & ";"
            End If
            If (Dashboard.patternLEDList(74, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][2] = " & Dashboard.patternLEDList(74, 2) & ";"
            End If
            If (Dashboard.patternLEDList(73, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][0] = " & Dashboard.patternLEDList(73, 0) & ";"
            End If
            If (Dashboard.patternLEDList(73, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][1] = " & Dashboard.patternLEDList(73, 1) & ";"
            End If
            If (Dashboard.patternLEDList(73, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][2] = " & Dashboard.patternLEDList(73, 2) & ";"
            End If
            If (Dashboard.patternLEDList(96, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][0] = " & Dashboard.patternLEDList(96, 0) & ";"
            End If
            If (Dashboard.patternLEDList(96, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][1] = " & Dashboard.patternLEDList(96, 1) & ";"
            End If
            If (Dashboard.patternLEDList(96, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][2] = " & Dashboard.patternLEDList(96, 2) & ";"
            End If
            If (Dashboard.patternLEDList(95, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][0] = " & Dashboard.patternLEDList(95, 0) & ";"
            End If
            If (Dashboard.patternLEDList(95, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][1] = " & Dashboard.patternLEDList(95, 1) & ";"
            End If
            If (Dashboard.patternLEDList(95, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][2] = " & Dashboard.patternLEDList(95, 2) & ";"
            End If
            If (Dashboard.patternLEDList(94, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][0] = " & Dashboard.patternLEDList(94, 0) & ";"
            End If
            If (Dashboard.patternLEDList(94, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][1] = " & Dashboard.patternLEDList(94, 1) & ";"
            End If
            If (Dashboard.patternLEDList(94, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][2] = " & Dashboard.patternLEDList(94, 2) & ";"
            End If
            If (Dashboard.patternLEDList(93, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][0] = " & Dashboard.patternLEDList(93, 0) & ";"
            End If
            If (Dashboard.patternLEDList(93, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][1] = " & Dashboard.patternLEDList(93, 1) & ";"
            End If
            If (Dashboard.patternLEDList(93, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][2] = " & Dashboard.patternLEDList(93, 2) & ";"
            End If
            If (Dashboard.patternLEDList(92, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][0] = " & Dashboard.patternLEDList(92, 0) & ";"
            End If
            If (Dashboard.patternLEDList(92, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][1] = " & Dashboard.patternLEDList(92, 1) & ";"
            End If
            If (Dashboard.patternLEDList(92, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][2] = " & Dashboard.patternLEDList(92, 2) & ";"
            End If
            If (Dashboard.patternLEDList(91, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][0] = " & Dashboard.patternLEDList(91, 0) & ";"
            End If
            If (Dashboard.patternLEDList(91, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][1] = " & Dashboard.patternLEDList(91, 1) & ";"
            End If
            If (Dashboard.patternLEDList(91, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][2] = " & Dashboard.patternLEDList(91, 2) & ";"
            End If
            If (Dashboard.patternLEDList(90, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][0] = " & Dashboard.patternLEDList(90, 0) & ";"
            End If
            If (Dashboard.patternLEDList(90, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][1] = " & Dashboard.patternLEDList(90, 1) & ";"
            End If
            If (Dashboard.patternLEDList(90, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][2] = " & Dashboard.patternLEDList(90, 2) & ";"
            End If
            If (Dashboard.patternLEDList(89, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][0] = " & Dashboard.patternLEDList(89, 0) & ";"
            End If
            If (Dashboard.patternLEDList(89, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][1] = " & Dashboard.patternLEDList(89, 1) & ";"
            End If
            If (Dashboard.patternLEDList(89, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][2] = " & Dashboard.patternLEDList(89, 2) & ";"
            End If
            If (Dashboard.patternLEDList(112, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][0] = " & Dashboard.patternLEDList(112, 0) & ";"
            End If
            If (Dashboard.patternLEDList(112, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][1] = " & Dashboard.patternLEDList(112, 1) & ";"
            End If
            If (Dashboard.patternLEDList(112, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][2] = " & Dashboard.patternLEDList(112, 2) & ";"
            End If
            If (Dashboard.patternLEDList(111, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][0] = " & Dashboard.patternLEDList(111, 0) & ";"
            End If
            If (Dashboard.patternLEDList(111, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][1] = " & Dashboard.patternLEDList(111, 1) & ";"
            End If
            If (Dashboard.patternLEDList(111, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][2] = " & Dashboard.patternLEDList(111, 2) & ";"
            End If
            If (Dashboard.patternLEDList(110, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][0] = " & Dashboard.patternLEDList(110, 0) & ";"
            End If
            If (Dashboard.patternLEDList(110, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][1] = " & Dashboard.patternLEDList(110, 1) & ";"
            End If
            If (Dashboard.patternLEDList(110, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][2] = " & Dashboard.patternLEDList(110, 2) & ";"
            End If
            If (Dashboard.patternLEDList(109, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][0] = " & Dashboard.patternLEDList(109, 0) & ";"
            End If
            If (Dashboard.patternLEDList(109, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][1] = " & Dashboard.patternLEDList(109, 1) & ";"
            End If
            If (Dashboard.patternLEDList(109, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][2] = " & Dashboard.patternLEDList(109, 2) & ";"
            End If
            If (Dashboard.patternLEDList(108, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][0] = " & Dashboard.patternLEDList(108, 0) & ";"
            End If
            If (Dashboard.patternLEDList(108, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][1] = " & Dashboard.patternLEDList(108, 1) & ";"
            End If
            If (Dashboard.patternLEDList(108, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][2] = " & Dashboard.patternLEDList(108, 2) & ";"
            End If
            If (Dashboard.patternLEDList(107, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][0] = " & Dashboard.patternLEDList(107, 0) & ";"
            End If
            If (Dashboard.patternLEDList(107, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][1] = " & Dashboard.patternLEDList(107, 1) & ";"
            End If
            If (Dashboard.patternLEDList(107, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][2] = " & Dashboard.patternLEDList(107, 2) & ";"
            End If
            If (Dashboard.patternLEDList(106, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][0] = " & Dashboard.patternLEDList(106, 0) & ";"
            End If
            If (Dashboard.patternLEDList(106, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][1] = " & Dashboard.patternLEDList(106, 1) & ";"
            End If
            If (Dashboard.patternLEDList(106, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][2] = " & Dashboard.patternLEDList(106, 2) & ";"
            End If
            If (Dashboard.patternLEDList(105, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][0] = " & Dashboard.patternLEDList(105, 0) & ";"
            End If
            If (Dashboard.patternLEDList(105, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][1] = " & Dashboard.patternLEDList(105, 1) & ";"
            End If
            If (Dashboard.patternLEDList(105, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][2] = " & Dashboard.patternLEDList(105, 2) & ";"
            End If
            If (Dashboard.patternLEDList(128, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][0] = " & Dashboard.patternLEDList(128, 0) & ";"
            End If
            If (Dashboard.patternLEDList(128, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][1] = " & Dashboard.patternLEDList(128, 1) & ";"
            End If
            If (Dashboard.patternLEDList(128, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][2] = " & Dashboard.patternLEDList(128, 2) & ";"
            End If
            If (Dashboard.patternLEDList(127, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][0] = " & Dashboard.patternLEDList(127, 0) & ";"
            End If
            If (Dashboard.patternLEDList(127, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][1] = " & Dashboard.patternLEDList(127, 1) & ";"
            End If
            If (Dashboard.patternLEDList(127, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][2] = " & Dashboard.patternLEDList(127, 2) & ";"
            End If
            If (Dashboard.patternLEDList(126, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][0] = " & Dashboard.patternLEDList(126, 0) & ";"
            End If
            If (Dashboard.patternLEDList(126, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][1] = " & Dashboard.patternLEDList(126, 1) & ";"
            End If
            If (Dashboard.patternLEDList(126, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][2] = " & Dashboard.patternLEDList(126, 2) & ";"
            End If
            If (Dashboard.patternLEDList(125, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][0] = " & Dashboard.patternLEDList(125, 0) & ";"
            End If
            If (Dashboard.patternLEDList(125, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][1] = " & Dashboard.patternLEDList(125, 1) & ";"
            End If
            If (Dashboard.patternLEDList(125, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][2] = " & Dashboard.patternLEDList(125, 2) & ";"
            End If
            If (Dashboard.patternLEDList(124, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][0] = " & Dashboard.patternLEDList(124, 0) & ";"
            End If
            If (Dashboard.patternLEDList(124, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][1] = " & Dashboard.patternLEDList(124, 1) & ";"
            End If
            If (Dashboard.patternLEDList(124, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][2] = " & Dashboard.patternLEDList(124, 2) & ";"
            End If
            If (Dashboard.patternLEDList(123, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][0] = " & Dashboard.patternLEDList(123, 0) & ";"
            End If
            If (Dashboard.patternLEDList(123, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][1] = " & Dashboard.patternLEDList(123, 1) & ";"
            End If
            If (Dashboard.patternLEDList(123, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][2] = " & Dashboard.patternLEDList(123, 2) & ";"
            End If
            If (Dashboard.patternLEDList(122, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][0] = " & Dashboard.patternLEDList(122, 0) & ";"
            End If
            If (Dashboard.patternLEDList(122, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][1] = " & Dashboard.patternLEDList(122, 1) & ";"
            End If
            If (Dashboard.patternLEDList(122, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][2] = " & Dashboard.patternLEDList(122, 2) & ";"
            End If
            If (Dashboard.patternLEDList(121, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][0] = " & Dashboard.patternLEDList(121, 0) & ";"
            End If
            If (Dashboard.patternLEDList(121, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][1] = " & Dashboard.patternLEDList(121, 1) & ";"
            End If
            If (Dashboard.patternLEDList(121, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][2] = " & Dashboard.patternLEDList(121, 2) & ";"
            End If
            If (Dashboard.patternLEDList(144, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][0] = " & Dashboard.patternLEDList(144, 0) & ";"
            End If
            If (Dashboard.patternLEDList(144, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][1] = " & Dashboard.patternLEDList(144, 1) & ";"
            End If
            If (Dashboard.patternLEDList(144, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][2] = " & Dashboard.patternLEDList(144, 2) & ";"
            End If
            If (Dashboard.patternLEDList(143, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][0] = " & Dashboard.patternLEDList(143, 0) & ";"
            End If
            If (Dashboard.patternLEDList(143, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][1] = " & Dashboard.patternLEDList(143, 1) & ";"
            End If
            If (Dashboard.patternLEDList(143, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][2] = " & Dashboard.patternLEDList(143, 2) & ";"
            End If
            If (Dashboard.patternLEDList(142, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][0] = " & Dashboard.patternLEDList(142, 0) & ";"
            End If
            If (Dashboard.patternLEDList(142, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][1] = " & Dashboard.patternLEDList(142, 1) & ";"
            End If
            If (Dashboard.patternLEDList(142, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][2] = " & Dashboard.patternLEDList(142, 2) & ";"
            End If
            If (Dashboard.patternLEDList(141, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][0] = " & Dashboard.patternLEDList(141, 0) & ";"
            End If
            If (Dashboard.patternLEDList(141, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][1] = " & Dashboard.patternLEDList(141, 1) & ";"
            End If
            If (Dashboard.patternLEDList(141, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][2] = " & Dashboard.patternLEDList(141, 2) & ";"
            End If
            If (Dashboard.patternLEDList(140, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][0] = " & Dashboard.patternLEDList(140, 0) & ";"
            End If
            If (Dashboard.patternLEDList(140, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][1] = " & Dashboard.patternLEDList(140, 1) & ";"
            End If
            If (Dashboard.patternLEDList(140, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][2] = " & Dashboard.patternLEDList(140, 2) & ";"
            End If
            If (Dashboard.patternLEDList(139, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][0] = " & Dashboard.patternLEDList(139, 0) & ";"
            End If
            If (Dashboard.patternLEDList(139, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][1] = " & Dashboard.patternLEDList(139, 1) & ";"
            End If
            If (Dashboard.patternLEDList(139, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][2] = " & Dashboard.patternLEDList(139, 2) & ";"
            End If
            If (Dashboard.patternLEDList(138, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][0] = " & Dashboard.patternLEDList(138, 0) & ";"
            End If
            If (Dashboard.patternLEDList(138, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][1] = " & Dashboard.patternLEDList(138, 1) & ";"
            End If
            If (Dashboard.patternLEDList(138, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][2] = " & Dashboard.patternLEDList(138, 2) & ";"
            End If
            If (Dashboard.patternLEDList(137, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][0] = " & Dashboard.patternLEDList(137, 0) & ";"
            End If
            If (Dashboard.patternLEDList(137, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][1] = " & Dashboard.patternLEDList(137, 1) & ";"
            End If
            If (Dashboard.patternLEDList(137, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][2] = " & Dashboard.patternLEDList(137, 2) & ";"
            End If
            If (Dashboard.patternLEDList(160, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][0] = " & Dashboard.patternLEDList(160, 0) & ";"
            End If
            If (Dashboard.patternLEDList(160, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][1] = " & Dashboard.patternLEDList(160, 1) & ";"
            End If
            If (Dashboard.patternLEDList(160, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][2] = " & Dashboard.patternLEDList(160, 2) & ";"
            End If
            If (Dashboard.patternLEDList(159, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][0] = " & Dashboard.patternLEDList(159, 0) & ";"
            End If
            If (Dashboard.patternLEDList(159, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][1] = " & Dashboard.patternLEDList(159, 1) & ";"
            End If
            If (Dashboard.patternLEDList(159, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][2] = " & Dashboard.patternLEDList(159, 2) & ";"
            End If
            If (Dashboard.patternLEDList(158, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][0] = " & Dashboard.patternLEDList(158, 0) & ";"
            End If
            If (Dashboard.patternLEDList(158, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][1] = " & Dashboard.patternLEDList(158, 1) & ";"
            End If
            If (Dashboard.patternLEDList(158, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][2] = " & Dashboard.patternLEDList(158, 2) & ";"
            End If
            If (Dashboard.patternLEDList(157, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][0] = " & Dashboard.patternLEDList(157, 0) & ";"
            End If
            If (Dashboard.patternLEDList(157, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][1] = " & Dashboard.patternLEDList(157, 1) & ";"
            End If
            If (Dashboard.patternLEDList(157, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][2] = " & Dashboard.patternLEDList(157, 2) & ";"
            End If
            If (Dashboard.patternLEDList(156, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][0] = " & Dashboard.patternLEDList(156, 0) & ";"
            End If
            If (Dashboard.patternLEDList(156, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][1] = " & Dashboard.patternLEDList(156, 1) & ";"
            End If
            If (Dashboard.patternLEDList(156, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][2] = " & Dashboard.patternLEDList(156, 2) & ";"
            End If
            If (Dashboard.patternLEDList(155, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][0] = " & Dashboard.patternLEDList(155, 0) & ";"
            End If
            If (Dashboard.patternLEDList(155, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][1] = " & Dashboard.patternLEDList(155, 1) & ";"
            End If
            If (Dashboard.patternLEDList(155, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][2] = " & Dashboard.patternLEDList(155, 2) & ";"
            End If
            If (Dashboard.patternLEDList(154, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][0] = " & Dashboard.patternLEDList(154, 0) & ";"
            End If
            If (Dashboard.patternLEDList(154, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][1] = " & Dashboard.patternLEDList(154, 1) & ";"
            End If
            If (Dashboard.patternLEDList(154, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][2] = " & Dashboard.patternLEDList(154, 2) & ";"
            End If
            If (Dashboard.patternLEDList(153, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][0] = " & Dashboard.patternLEDList(153, 0) & ";"
            End If
            If (Dashboard.patternLEDList(153, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][1] = " & Dashboard.patternLEDList(153, 1) & ";"
            End If
            If (Dashboard.patternLEDList(153, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][2] = " & Dashboard.patternLEDList(153, 2) & ";"
            End If
            If (Dashboard.patternLEDList(176, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][0] = " & Dashboard.patternLEDList(176, 0) & ";"
            End If
            If (Dashboard.patternLEDList(176, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][1] = " & Dashboard.patternLEDList(176, 1) & ";"
            End If
            If (Dashboard.patternLEDList(176, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][2] = " & Dashboard.patternLEDList(176, 2) & ";"
            End If
            If (Dashboard.patternLEDList(175, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][0] = " & Dashboard.patternLEDList(175, 0) & ";"
            End If
            If (Dashboard.patternLEDList(175, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][1] = " & Dashboard.patternLEDList(175, 1) & ";"
            End If
            If (Dashboard.patternLEDList(175, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][2] = " & Dashboard.patternLEDList(175, 2) & ";"
            End If
            If (Dashboard.patternLEDList(174, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][0] = " & Dashboard.patternLEDList(174, 0) & ";"
            End If
            If (Dashboard.patternLEDList(174, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][1] = " & Dashboard.patternLEDList(174, 1) & ";"
            End If
            If (Dashboard.patternLEDList(174, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][2] = " & Dashboard.patternLEDList(174, 2) & ";"
            End If
            If (Dashboard.patternLEDList(173, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][0] = " & Dashboard.patternLEDList(173, 0) & ";"
            End If
            If (Dashboard.patternLEDList(173, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][1] = " & Dashboard.patternLEDList(173, 1) & ";"
            End If
            If (Dashboard.patternLEDList(173, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][2] = " & Dashboard.patternLEDList(173, 2) & ";"
            End If
            If (Dashboard.patternLEDList(172, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][0] = " & Dashboard.patternLEDList(172, 0) & ";"
            End If
            If (Dashboard.patternLEDList(172, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][1] = " & Dashboard.patternLEDList(172, 1) & ";"
            End If
            If (Dashboard.patternLEDList(172, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][2] = " & Dashboard.patternLEDList(172, 2) & ";"
            End If
            If (Dashboard.patternLEDList(171, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][0] = " & Dashboard.patternLEDList(171, 0) & ";"
            End If
            If (Dashboard.patternLEDList(171, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][1] = " & Dashboard.patternLEDList(171, 1) & ";"
            End If
            If (Dashboard.patternLEDList(171, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][2] = " & Dashboard.patternLEDList(171, 2) & ";"
            End If
            If (Dashboard.patternLEDList(170, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][0] = " & Dashboard.patternLEDList(170, 0) & ";"
            End If
            If (Dashboard.patternLEDList(170, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][1] = " & Dashboard.patternLEDList(170, 1) & ";"
            End If
            If (Dashboard.patternLEDList(170, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][2] = " & Dashboard.patternLEDList(170, 2) & ";"
            End If
            If (Dashboard.patternLEDList(169, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][0] = " & Dashboard.patternLEDList(169, 0) & ";"
            End If
            If (Dashboard.patternLEDList(169, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][1] = " & Dashboard.patternLEDList(169, 1) & ";"
            End If
            If (Dashboard.patternLEDList(169, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][2] = " & Dashboard.patternLEDList(169, 2) & ";"
            End If
            If (Dashboard.patternLEDList(192, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][0] = " & Dashboard.patternLEDList(192, 0) & ";"
            End If
            If (Dashboard.patternLEDList(192, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][1] = " & Dashboard.patternLEDList(192, 1) & ";"
            End If
            If (Dashboard.patternLEDList(192, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][2] = " & Dashboard.patternLEDList(192, 2) & ";"
            End If
            If (Dashboard.patternLEDList(191, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][0] = " & Dashboard.patternLEDList(191, 0) & ";"
            End If
            If (Dashboard.patternLEDList(191, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][1] = " & Dashboard.patternLEDList(191, 1) & ";"
            End If
            If (Dashboard.patternLEDList(191, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][2] = " & Dashboard.patternLEDList(191, 2) & ";"
            End If
            If (Dashboard.patternLEDList(190, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][0] = " & Dashboard.patternLEDList(190, 0) & ";"
            End If
            If (Dashboard.patternLEDList(190, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][1] = " & Dashboard.patternLEDList(190, 1) & ";"
            End If
            If (Dashboard.patternLEDList(190, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][2] = " & Dashboard.patternLEDList(190, 2) & ";"
            End If
            If (Dashboard.patternLEDList(189, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][0] = " & Dashboard.patternLEDList(189, 0) & ";"
            End If
            If (Dashboard.patternLEDList(189, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][1] = " & Dashboard.patternLEDList(189, 1) & ";"
            End If
            If (Dashboard.patternLEDList(189, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][2] = " & Dashboard.patternLEDList(189, 2) & ";"
            End If
            If (Dashboard.patternLEDList(188, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][0] = " & Dashboard.patternLEDList(188, 0) & ";"
            End If
            If (Dashboard.patternLEDList(188, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][1] = " & Dashboard.patternLEDList(188, 1) & ";"
            End If
            If (Dashboard.patternLEDList(188, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][2] = " & Dashboard.patternLEDList(188, 2) & ";"
            End If
            If (Dashboard.patternLEDList(187, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][0] = " & Dashboard.patternLEDList(187, 0) & ";"
            End If
            If (Dashboard.patternLEDList(187, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][1] = " & Dashboard.patternLEDList(187, 1) & ";"
            End If
            If (Dashboard.patternLEDList(187, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][2] = " & Dashboard.patternLEDList(187, 2) & ";"
            End If
            If (Dashboard.patternLEDList(186, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][0] = " & Dashboard.patternLEDList(186, 0) & ";"
            End If
            If (Dashboard.patternLEDList(186, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][1] = " & Dashboard.patternLEDList(186, 1) & ";"
            End If
            If (Dashboard.patternLEDList(186, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][2] = " & Dashboard.patternLEDList(186, 2) & ";"
            End If
            If (Dashboard.patternLEDList(185, 0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][0] = " & Dashboard.patternLEDList(185, 0) & ";"
            End If
            If (Dashboard.patternLEDList(185, 1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][1] = " & Dashboard.patternLEDList(185, 1) & ";"
            End If
            If (Dashboard.patternLEDList(185, 2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][2] = " & Dashboard.patternLEDList(185, 2) & ";"
            End If


            F.Text = F.Text & vbNewLine & "}"
            F.Text = F.Text & vbNewLine & ""
            F.Text = F.Text & vbNewLine & ""


            Dim textContent As String = generateCode(Dashboard.TextBox1.Text, F.Text)


            F.Text = textContent



        Else
            F.Text = "void " & Dashboard.TextBox1.Text & "(int sp, int rep) {"
            F.Text = F.Text & vbNewLine & "  FastLED.clear();"
            F.Text = F.Text & vbNewLine & "  for (int i = 0; i < rep; i++) {"

            Dim y As Long = 0
            For y = 0 To Dashboard.frameCount.Value - 1
                If (y = 0) Then
                    Dim yy As Integer
                    For yy = 0 To 199
                        If (Dashboard.framesR(yy) <> 0 Or Dashboard.framesG(yy) <> 0 Or Dashboard.framesB(yy) <> 0) Then
                            F.Text = F.Text & vbNewLine & "    leds[" & yy & "] = CRGB(" & Dashboard.framesR(yy) & ", " & Dashboard.framesG(yy) & ", " & Dashboard.framesB(yy) & ");"
                        End If
                    Next
                    F.Text = F.Text & vbNewLine & "    FastLED.show();"
                    F.Text = F.Text & vbNewLine & "    delay(sp);"
                Else
                    Dim yy As Integer
                    For yy = y * 200 To (y * 200) + 199
                        If (Dashboard.framesR(yy) <> Dashboard.framesR(yy - 200) Or Dashboard.framesG(yy) <> Dashboard.framesG(yy - 200) Or Dashboard.framesB(yy) <> Dashboard.framesB(yy - 200)) Then
                            F.Text = F.Text & vbNewLine & "    leds[" & yy - (y * 200) & "] = CRGB(" & Dashboard.framesR(yy) & ", " & Dashboard.framesG(yy) & ", " & Dashboard.framesB(yy) & ");"
                        End If
                    Next
                    F.Text = F.Text & vbNewLine & "    FastLED.show();"
                    F.Text = F.Text & vbNewLine & "    delay(sp);"
                End If
            Next
            F.Text = F.Text & vbNewLine & "  }"
            F.Text = F.Text & vbNewLine & "}"
            F.Text = F.Text & vbNewLine & ""
            F.Text = F.Text & vbNewLine & ""

        End If


    End Sub
End Class