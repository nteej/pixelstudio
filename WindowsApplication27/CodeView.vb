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

            If (Dashboard.b1(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][0] = " & Dashboard.b1(0) & ";"
            End If
            If (Dashboard.b1(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][1] = " & Dashboard.b1(1) & ";"
            End If
            If (Dashboard.b1(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][0][2] = " & Dashboard.b1(2) & ";"
            End If
            If (Dashboard.b2(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][0] = " & Dashboard.b2(0) & ";"
            End If
            If (Dashboard.b2(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][1] = " & Dashboard.b2(1) & ";"
            End If
            If (Dashboard.b2(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][0][2] = " & Dashboard.b2(2) & ";"
            End If
            If (Dashboard.b3(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][0] = " & Dashboard.b3(0) & ";"
            End If
            If (Dashboard.b3(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][1] = " & Dashboard.b3(1) & ";"
            End If
            If (Dashboard.b3(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][0][2] = " & Dashboard.b3(2) & ";"
            End If
            If (Dashboard.b4(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][0] = " & Dashboard.b4(0) & ";"
            End If
            If (Dashboard.b4(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][1] = " & Dashboard.b4(1) & ";"
            End If
            If (Dashboard.b4(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][0][2] = " & Dashboard.b4(2) & ";"
            End If
            If (Dashboard.b5(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][0] = " & Dashboard.b5(0) & ";"
            End If
            If (Dashboard.b5(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][1] = " & Dashboard.b5(1) & ";"
            End If
            If (Dashboard.b5(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][0][2] = " & Dashboard.b5(2) & ";"
            End If
            If (Dashboard.b6(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][0] = " & Dashboard.b6(0) & ";"
            End If
            If (Dashboard.b6(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][1] = " & Dashboard.b6(1) & ";"
            End If
            If (Dashboard.b6(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][0][2] = " & Dashboard.b6(2) & ";"
            End If
            If (Dashboard.b7(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][0] = " & Dashboard.b7(0) & ";"
            End If
            If (Dashboard.b7(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][1] = " & Dashboard.b7(1) & ";"
            End If
            If (Dashboard.b7(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][0][2] = " & Dashboard.b7(2) & ";"
            End If
            If (Dashboard.b8(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][0] = " & Dashboard.b8(0) & ";"
            End If
            If (Dashboard.b8(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][1] = " & Dashboard.b8(1) & ";"
            End If
            If (Dashboard.b8(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][0][2] = " & Dashboard.b8(2) & ";"
            End If
            If (Dashboard.b17(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][0] = " & Dashboard.b17(0) & ";"
            End If
            If (Dashboard.b17(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][1] = " & Dashboard.b17(1) & ";"
            End If
            If (Dashboard.b17(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][2][2] = " & Dashboard.b17(2) & ";"
            End If
            If (Dashboard.b18(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][0] = " & Dashboard.b18(0) & ";"
            End If
            If (Dashboard.b18(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][1] = " & Dashboard.b18(1) & ";"
            End If
            If (Dashboard.b18(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][2][2] = " & Dashboard.b18(2) & ";"
            End If
            If (Dashboard.b19(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][0] = " & Dashboard.b19(0) & ";"
            End If
            If (Dashboard.b19(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][1] = " & Dashboard.b19(1) & ";"
            End If
            If (Dashboard.b19(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][2][2] = " & Dashboard.b19(2) & ";"
            End If
            If (Dashboard.b20(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][0] = " & Dashboard.b20(0) & ";"
            End If
            If (Dashboard.b20(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][1] = " & Dashboard.b20(1) & ";"
            End If
            If (Dashboard.b20(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][2][2] = " & Dashboard.b20(2) & ";"
            End If
            If (Dashboard.b21(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][0] = " & Dashboard.b21(0) & ";"
            End If
            If (Dashboard.b21(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][1] = " & Dashboard.b21(1) & ";"
            End If
            If (Dashboard.b21(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][2][2] = " & Dashboard.b21(2) & ";"
            End If
            If (Dashboard.b22(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][0] = " & Dashboard.b22(0) & ";"
            End If
            If (Dashboard.b22(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][1] = " & Dashboard.b22(1) & ";"
            End If
            If (Dashboard.b22(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][2][2] = " & Dashboard.b22(2) & ";"
            End If
            If (Dashboard.b23(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][0] = " & Dashboard.b23(0) & ";"
            End If
            If (Dashboard.b23(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][1] = " & Dashboard.b23(1) & ";"
            End If
            If (Dashboard.b23(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][2][2] = " & Dashboard.b23(2) & ";"
            End If
            If (Dashboard.b24(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][0] = " & Dashboard.b24(0) & ";"
            End If
            If (Dashboard.b24(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][1] = " & Dashboard.b24(1) & ";"
            End If
            If (Dashboard.b24(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][2][2] = " & Dashboard.b24(2) & ";"
            End If
            If (Dashboard.b33(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][0] = " & Dashboard.b33(0) & ";"
            End If
            If (Dashboard.b33(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][1] = " & Dashboard.b33(1) & ";"
            End If
            If (Dashboard.b33(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][4][2] = " & Dashboard.b33(2) & ";"
            End If
            If (Dashboard.b34(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][0] = " & Dashboard.b34(0) & ";"
            End If
            If (Dashboard.b34(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][1] = " & Dashboard.b34(1) & ";"
            End If
            If (Dashboard.b34(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][4][2] = " & Dashboard.b34(2) & ";"
            End If
            If (Dashboard.b35(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][0] = " & Dashboard.b35(0) & ";"
            End If
            If (Dashboard.b35(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][1] = " & Dashboard.b35(1) & ";"
            End If
            If (Dashboard.b35(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][4][2] = " & Dashboard.b35(2) & ";"
            End If
            If (Dashboard.b36(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][0] = " & Dashboard.b36(0) & ";"
            End If
            If (Dashboard.b36(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][1] = " & Dashboard.b36(1) & ";"
            End If
            If (Dashboard.b36(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][4][2] = " & Dashboard.b36(2) & ";"
            End If
            If (Dashboard.b37(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][0] = " & Dashboard.b37(0) & ";"
            End If
            If (Dashboard.b37(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][1] = " & Dashboard.b37(1) & ";"
            End If
            If (Dashboard.b37(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][4][2] = " & Dashboard.b37(2) & ";"
            End If
            If (Dashboard.b38(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][0] = " & Dashboard.b38(0) & ";"
            End If
            If (Dashboard.b38(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][1] = " & Dashboard.b38(1) & ";"
            End If
            If (Dashboard.b38(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][4][2] = " & Dashboard.b38(2) & ";"
            End If
            If (Dashboard.b39(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][0] = " & Dashboard.b39(0) & ";"
            End If
            If (Dashboard.b39(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][1] = " & Dashboard.b39(1) & ";"
            End If
            If (Dashboard.b39(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][4][2] = " & Dashboard.b39(2) & ";"
            End If
            If (Dashboard.b40(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][0] = " & Dashboard.b40(0) & ";"
            End If
            If (Dashboard.b40(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][1] = " & Dashboard.b40(1) & ";"
            End If
            If (Dashboard.b40(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][4][2] = " & Dashboard.b40(2) & ";"
            End If
            If (Dashboard.b49(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][0] = " & Dashboard.b49(0) & ";"
            End If
            If (Dashboard.b49(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][1] = " & Dashboard.b49(1) & ";"
            End If
            If (Dashboard.b49(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][6][2] = " & Dashboard.b49(2) & ";"
            End If
            If (Dashboard.b50(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][0] = " & Dashboard.b50(0) & ";"
            End If
            If (Dashboard.b50(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][1] = " & Dashboard.b50(1) & ";"
            End If
            If (Dashboard.b50(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][6][2] = " & Dashboard.b50(2) & ";"
            End If
            If (Dashboard.b51(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][0] = " & Dashboard.b51(0) & ";"
            End If
            If (Dashboard.b51(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][1] = " & Dashboard.b51(1) & ";"
            End If
            If (Dashboard.b51(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][6][2] = " & Dashboard.b51(2) & ";"
            End If
            If (Dashboard.b52(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][0] = " & Dashboard.b52(0) & ";"
            End If
            If (Dashboard.b52(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][1] = " & Dashboard.b52(1) & ";"
            End If
            If (Dashboard.b52(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][6][2] = " & Dashboard.b52(2) & ";"
            End If
            If (Dashboard.b53(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][0] = " & Dashboard.b53(0) & ";"
            End If
            If (Dashboard.b53(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][1] = " & Dashboard.b53(1) & ";"
            End If
            If (Dashboard.b53(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][6][2] = " & Dashboard.b53(2) & ";"
            End If
            If (Dashboard.b54(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][0] = " & Dashboard.b54(0) & ";"
            End If
            If (Dashboard.b54(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][1] = " & Dashboard.b54(1) & ";"
            End If
            If (Dashboard.b54(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][6][2] = " & Dashboard.b54(2) & ";"
            End If
            If (Dashboard.b55(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][0] = " & Dashboard.b55(0) & ";"
            End If
            If (Dashboard.b55(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][1] = " & Dashboard.b55(1) & ";"
            End If
            If (Dashboard.b55(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][6][2] = " & Dashboard.b55(2) & ";"
            End If
            If (Dashboard.b56(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][0] = " & Dashboard.b56(0) & ";"
            End If
            If (Dashboard.b56(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][1] = " & Dashboard.b56(1) & ";"
            End If
            If (Dashboard.b56(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][6][2] = " & Dashboard.b56(2) & ";"
            End If
            If (Dashboard.b65(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][0] = " & Dashboard.b65(0) & ";"
            End If
            If (Dashboard.b65(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][1] = " & Dashboard.b65(1) & ";"
            End If
            If (Dashboard.b65(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][8][2] = " & Dashboard.b65(2) & ";"
            End If
            If (Dashboard.b66(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][0] = " & Dashboard.b66(0) & ";"
            End If
            If (Dashboard.b66(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][1] = " & Dashboard.b66(1) & ";"
            End If
            If (Dashboard.b66(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][8][2] = " & Dashboard.b66(2) & ";"
            End If
            If (Dashboard.b67(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][0] = " & Dashboard.b67(0) & ";"
            End If
            If (Dashboard.b67(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][1] = " & Dashboard.b67(1) & ";"
            End If
            If (Dashboard.b67(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][8][2] = " & Dashboard.b67(2) & ";"
            End If
            If (Dashboard.b68(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][0] = " & Dashboard.b68(0) & ";"
            End If
            If (Dashboard.b68(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][1] = " & Dashboard.b68(1) & ";"
            End If
            If (Dashboard.b68(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][8][2] = " & Dashboard.b68(2) & ";"
            End If
            If (Dashboard.b69(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][0] = " & Dashboard.b69(0) & ";"
            End If
            If (Dashboard.b69(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][1] = " & Dashboard.b69(1) & ";"
            End If
            If (Dashboard.b69(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][8][2] = " & Dashboard.b69(2) & ";"
            End If
            If (Dashboard.b70(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][0] = " & Dashboard.b70(0) & ";"
            End If
            If (Dashboard.b70(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][1] = " & Dashboard.b70(1) & ";"
            End If
            If (Dashboard.b70(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][8][2] = " & Dashboard.b70(2) & ";"
            End If
            If (Dashboard.b71(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][0] = " & Dashboard.b71(0) & ";"
            End If
            If (Dashboard.b71(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][1] = " & Dashboard.b71(1) & ";"
            End If
            If (Dashboard.b71(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][8][2] = " & Dashboard.b71(2) & ";"
            End If
            If (Dashboard.b72(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][0] = " & Dashboard.b72(0) & ";"
            End If
            If (Dashboard.b72(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][1] = " & Dashboard.b72(1) & ";"
            End If
            If (Dashboard.b72(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][8][2] = " & Dashboard.b72(2) & ";"
            End If
            If (Dashboard.b81(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][0] = " & Dashboard.b81(0) & ";"
            End If
            If (Dashboard.b81(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][1] = " & Dashboard.b81(1) & ";"
            End If
            If (Dashboard.b81(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][10][2] = " & Dashboard.b81(2) & ";"
            End If
            If (Dashboard.b82(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][0] = " & Dashboard.b82(0) & ";"
            End If
            If (Dashboard.b82(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][1] = " & Dashboard.b82(1) & ";"
            End If
            If (Dashboard.b82(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][10][2] = " & Dashboard.b82(2) & ";"
            End If
            If (Dashboard.b83(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][0] = " & Dashboard.b83(0) & ";"
            End If
            If (Dashboard.b83(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][1] = " & Dashboard.b83(1) & ";"
            End If
            If (Dashboard.b83(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][10][2] = " & Dashboard.b83(2) & ";"
            End If
            If (Dashboard.b84(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][0] = " & Dashboard.b84(0) & ";"
            End If
            If (Dashboard.b84(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][1] = " & Dashboard.b84(1) & ";"
            End If
            If (Dashboard.b84(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][10][2] = " & Dashboard.b84(2) & ";"
            End If
            If (Dashboard.b85(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][0] = " & Dashboard.b85(0) & ";"
            End If
            If (Dashboard.b85(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][1] = " & Dashboard.b85(1) & ";"
            End If
            If (Dashboard.b85(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][10][2] = " & Dashboard.b85(2) & ";"
            End If
            If (Dashboard.b86(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][0] = " & Dashboard.b86(0) & ";"
            End If
            If (Dashboard.b86(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][1] = " & Dashboard.b86(1) & ";"
            End If
            If (Dashboard.b86(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][10][2] = " & Dashboard.b86(2) & ";"
            End If
            If (Dashboard.b87(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][0] = " & Dashboard.b87(0) & ";"
            End If
            If (Dashboard.b87(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][1] = " & Dashboard.b87(1) & ";"
            End If
            If (Dashboard.b87(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][10][2] = " & Dashboard.b87(2) & ";"
            End If
            If (Dashboard.b88(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][0] = " & Dashboard.b88(0) & ";"
            End If
            If (Dashboard.b88(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][1] = " & Dashboard.b88(1) & ";"
            End If
            If (Dashboard.b88(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][10][2] = " & Dashboard.b88(2) & ";"
            End If
            If (Dashboard.b97(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][0] = " & Dashboard.b97(0) & ";"
            End If
            If (Dashboard.b97(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][1] = " & Dashboard.b97(1) & ";"
            End If
            If (Dashboard.b97(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][12][2] = " & Dashboard.b97(2) & ";"
            End If
            If (Dashboard.b98(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][0] = " & Dashboard.b98(0) & ";"
            End If
            If (Dashboard.b98(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][1] = " & Dashboard.b98(1) & ";"
            End If
            If (Dashboard.b98(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][12][2] = " & Dashboard.b98(2) & ";"
            End If
            If (Dashboard.b99(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][0] = " & Dashboard.b99(0) & ";"
            End If
            If (Dashboard.b99(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][1] = " & Dashboard.b99(1) & ";"
            End If
            If (Dashboard.b99(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][12][2] = " & Dashboard.b99(2) & ";"
            End If
            If (Dashboard.b100(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][0] = " & Dashboard.b100(0) & ";"
            End If
            If (Dashboard.b100(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][1] = " & Dashboard.b100(1) & ";"
            End If
            If (Dashboard.b100(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][12][2] = " & Dashboard.b100(2) & ";"
            End If
            If (Dashboard.b101(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][0] = " & Dashboard.b101(0) & ";"
            End If
            If (Dashboard.b101(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][1] = " & Dashboard.b101(1) & ";"
            End If
            If (Dashboard.b101(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][12][2] = " & Dashboard.b101(2) & ";"
            End If
            If (Dashboard.b102(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][0] = " & Dashboard.b102(0) & ";"
            End If
            If (Dashboard.b102(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][1] = " & Dashboard.b102(1) & ";"
            End If
            If (Dashboard.b102(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][12][2] = " & Dashboard.b102(2) & ";"
            End If
            If (Dashboard.b103(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][0] = " & Dashboard.b103(0) & ";"
            End If
            If (Dashboard.b103(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][1] = " & Dashboard.b103(1) & ";"
            End If
            If (Dashboard.b103(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][12][2] = " & Dashboard.b103(2) & ";"
            End If
            If (Dashboard.b104(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][0] = " & Dashboard.b104(0) & ";"
            End If
            If (Dashboard.b104(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][1] = " & Dashboard.b104(1) & ";"
            End If
            If (Dashboard.b104(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][12][2] = " & Dashboard.b104(2) & ";"
            End If
            If (Dashboard.b113(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][0] = " & Dashboard.b113(0) & ";"
            End If
            If (Dashboard.b113(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][1] = " & Dashboard.b113(1) & ";"
            End If
            If (Dashboard.b113(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][14][2] = " & Dashboard.b113(2) & ";"
            End If
            If (Dashboard.b114(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][0] = " & Dashboard.b114(0) & ";"
            End If
            If (Dashboard.b114(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][1] = " & Dashboard.b114(1) & ";"
            End If
            If (Dashboard.b114(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][14][2] = " & Dashboard.b114(2) & ";"
            End If
            If (Dashboard.b115(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][0] = " & Dashboard.b115(0) & ";"
            End If
            If (Dashboard.b115(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][1] = " & Dashboard.b115(1) & ";"
            End If
            If (Dashboard.b115(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][14][2] = " & Dashboard.b115(2) & ";"
            End If
            If (Dashboard.b116(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][0] = " & Dashboard.b116(0) & ";"
            End If
            If (Dashboard.b116(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][1] = " & Dashboard.b116(1) & ";"
            End If
            If (Dashboard.b116(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][14][2] = " & Dashboard.b116(2) & ";"
            End If
            If (Dashboard.b117(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][0] = " & Dashboard.b117(0) & ";"
            End If
            If (Dashboard.b117(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][1] = " & Dashboard.b117(1) & ";"
            End If
            If (Dashboard.b117(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][14][2] = " & Dashboard.b117(2) & ";"
            End If
            If (Dashboard.b118(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][0] = " & Dashboard.b118(0) & ";"
            End If
            If (Dashboard.b118(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][1] = " & Dashboard.b118(1) & ";"
            End If
            If (Dashboard.b118(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][14][2] = " & Dashboard.b118(2) & ";"
            End If
            If (Dashboard.b119(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][0] = " & Dashboard.b119(0) & ";"
            End If
            If (Dashboard.b119(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][1] = " & Dashboard.b119(1) & ";"
            End If
            If (Dashboard.b119(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][14][2] = " & Dashboard.b119(2) & ";"
            End If
            If (Dashboard.b120(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][0] = " & Dashboard.b120(0) & ";"
            End If
            If (Dashboard.b120(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][1] = " & Dashboard.b120(1) & ";"
            End If
            If (Dashboard.b120(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][14][2] = " & Dashboard.b120(2) & ";"
            End If
            If (Dashboard.b129(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][0] = " & Dashboard.b129(0) & ";"
            End If
            If (Dashboard.b129(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][1] = " & Dashboard.b129(1) & ";"
            End If
            If (Dashboard.b129(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][16][2] = " & Dashboard.b129(2) & ";"
            End If
            If (Dashboard.b130(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][0] = " & Dashboard.b130(0) & ";"
            End If
            If (Dashboard.b130(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][1] = " & Dashboard.b130(1) & ";"
            End If
            If (Dashboard.b130(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][16][2] = " & Dashboard.b130(2) & ";"
            End If
            If (Dashboard.b131(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][0] = " & Dashboard.b131(0) & ";"
            End If
            If (Dashboard.b131(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][1] = " & Dashboard.b131(1) & ";"
            End If
            If (Dashboard.b131(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][16][2] = " & Dashboard.b131(2) & ";"
            End If
            If (Dashboard.b132(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][0] = " & Dashboard.b132(0) & ";"
            End If
            If (Dashboard.b132(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][1] = " & Dashboard.b132(1) & ";"
            End If
            If (Dashboard.b132(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][16][2] = " & Dashboard.b132(2) & ";"
            End If
            If (Dashboard.b133(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][0] = " & Dashboard.b133(0) & ";"
            End If
            If (Dashboard.b133(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][1] = " & Dashboard.b133(1) & ";"
            End If
            If (Dashboard.b133(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][16][2] = " & Dashboard.b133(2) & ";"
            End If
            If (Dashboard.b134(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][0] = " & Dashboard.b134(0) & ";"
            End If
            If (Dashboard.b134(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][1] = " & Dashboard.b134(1) & ";"
            End If
            If (Dashboard.b134(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][16][2] = " & Dashboard.b134(2) & ";"
            End If
            If (Dashboard.b135(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][0] = " & Dashboard.b135(0) & ";"
            End If
            If (Dashboard.b135(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][1] = " & Dashboard.b135(1) & ";"
            End If
            If (Dashboard.b135(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][16][2] = " & Dashboard.b135(2) & ";"
            End If
            If (Dashboard.b136(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][0] = " & Dashboard.b136(0) & ";"
            End If
            If (Dashboard.b136(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][1] = " & Dashboard.b136(1) & ";"
            End If
            If (Dashboard.b136(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][16][2] = " & Dashboard.b136(2) & ";"
            End If
            If (Dashboard.b145(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][0] = " & Dashboard.b145(0) & ";"
            End If
            If (Dashboard.b145(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][1] = " & Dashboard.b145(1) & ";"
            End If
            If (Dashboard.b145(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][18][2] = " & Dashboard.b145(2) & ";"
            End If
            If (Dashboard.b146(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][0] = " & Dashboard.b146(0) & ";"
            End If
            If (Dashboard.b146(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][1] = " & Dashboard.b146(1) & ";"
            End If
            If (Dashboard.b146(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][18][2] = " & Dashboard.b146(2) & ";"
            End If
            If (Dashboard.b147(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][0] = " & Dashboard.b147(0) & ";"
            End If
            If (Dashboard.b147(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][1] = " & Dashboard.b147(1) & ";"
            End If
            If (Dashboard.b147(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][18][2] = " & Dashboard.b147(2) & ";"
            End If
            If (Dashboard.b148(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][0] = " & Dashboard.b148(0) & ";"
            End If
            If (Dashboard.b148(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][1] = " & Dashboard.b148(1) & ";"
            End If
            If (Dashboard.b148(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][18][2] = " & Dashboard.b148(2) & ";"
            End If
            If (Dashboard.b149(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][0] = " & Dashboard.b149(0) & ";"
            End If
            If (Dashboard.b149(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][1] = " & Dashboard.b149(1) & ";"
            End If
            If (Dashboard.b149(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][18][2] = " & Dashboard.b149(2) & ";"
            End If
            If (Dashboard.b150(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][0] = " & Dashboard.b150(0) & ";"
            End If
            If (Dashboard.b150(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][1] = " & Dashboard.b150(1) & ";"
            End If
            If (Dashboard.b150(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][18][2] = " & Dashboard.b150(2) & ";"
            End If
            If (Dashboard.b151(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][0] = " & Dashboard.b151(0) & ";"
            End If
            If (Dashboard.b151(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][1] = " & Dashboard.b151(1) & ";"
            End If
            If (Dashboard.b151(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][18][2] = " & Dashboard.b151(2) & ";"
            End If
            If (Dashboard.b152(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][0] = " & Dashboard.b152(0) & ";"
            End If
            If (Dashboard.b152(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][1] = " & Dashboard.b152(1) & ";"
            End If
            If (Dashboard.b152(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][18][2] = " & Dashboard.b152(2) & ";"
            End If
            If (Dashboard.b161(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][0] = " & Dashboard.b161(0) & ";"
            End If
            If (Dashboard.b161(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][1] = " & Dashboard.b161(1) & ";"
            End If
            If (Dashboard.b161(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][20][2] = " & Dashboard.b161(2) & ";"
            End If
            If (Dashboard.b162(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][0] = " & Dashboard.b162(0) & ";"
            End If
            If (Dashboard.b162(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][1] = " & Dashboard.b162(1) & ";"
            End If
            If (Dashboard.b162(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][20][2] = " & Dashboard.b162(2) & ";"
            End If
            If (Dashboard.b163(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][0] = " & Dashboard.b163(0) & ";"
            End If
            If (Dashboard.b163(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][1] = " & Dashboard.b163(1) & ";"
            End If
            If (Dashboard.b163(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][20][2] = " & Dashboard.b163(2) & ";"
            End If
            If (Dashboard.b164(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][0] = " & Dashboard.b164(0) & ";"
            End If
            If (Dashboard.b164(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][1] = " & Dashboard.b164(1) & ";"
            End If
            If (Dashboard.b164(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][20][2] = " & Dashboard.b164(2) & ";"
            End If
            If (Dashboard.b165(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][0] = " & Dashboard.b165(0) & ";"
            End If
            If (Dashboard.b165(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][1] = " & Dashboard.b165(1) & ";"
            End If
            If (Dashboard.b165(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][20][2] = " & Dashboard.b165(2) & ";"
            End If
            If (Dashboard.b166(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][0] = " & Dashboard.b166(0) & ";"
            End If
            If (Dashboard.b166(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][1] = " & Dashboard.b166(1) & ";"
            End If
            If (Dashboard.b166(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][20][2] = " & Dashboard.b166(2) & ";"
            End If
            If (Dashboard.b167(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][0] = " & Dashboard.b167(0) & ";"
            End If
            If (Dashboard.b167(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][1] = " & Dashboard.b167(1) & ";"
            End If
            If (Dashboard.b167(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][20][2] = " & Dashboard.b167(2) & ";"
            End If
            If (Dashboard.b168(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][0] = " & Dashboard.b168(0) & ";"
            End If
            If (Dashboard.b168(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][1] = " & Dashboard.b168(1) & ";"
            End If
            If (Dashboard.b168(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][20][2] = " & Dashboard.b168(2) & ";"
            End If
            If (Dashboard.b177(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][0] = " & Dashboard.b177(0) & ";"
            End If
            If (Dashboard.b177(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][1] = " & Dashboard.b177(1) & ";"
            End If
            If (Dashboard.b177(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][22][2] = " & Dashboard.b177(2) & ";"
            End If
            If (Dashboard.b178(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][0] = " & Dashboard.b178(0) & ";"
            End If
            If (Dashboard.b178(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][1] = " & Dashboard.b178(1) & ";"
            End If
            If (Dashboard.b178(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][22][2] = " & Dashboard.b178(2) & ";"
            End If
            If (Dashboard.b179(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][0] = " & Dashboard.b179(0) & ";"
            End If
            If (Dashboard.b179(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][1] = " & Dashboard.b179(1) & ";"
            End If
            If (Dashboard.b179(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][22][2] = " & Dashboard.b179(2) & ";"
            End If
            If (Dashboard.b180(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][0] = " & Dashboard.b180(0) & ";"
            End If
            If (Dashboard.b180(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][1] = " & Dashboard.b180(1) & ";"
            End If
            If (Dashboard.b180(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][22][2] = " & Dashboard.b180(2) & ";"
            End If
            If (Dashboard.b181(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][0] = " & Dashboard.b181(0) & ";"
            End If
            If (Dashboard.b181(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][1] = " & Dashboard.b181(1) & ";"
            End If
            If (Dashboard.b181(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][22][2] = " & Dashboard.b181(2) & ";"
            End If
            If (Dashboard.b182(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][0] = " & Dashboard.b182(0) & ";"
            End If
            If (Dashboard.b182(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][1] = " & Dashboard.b182(1) & ";"
            End If
            If (Dashboard.b182(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][22][2] = " & Dashboard.b182(2) & ";"
            End If
            If (Dashboard.b183(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][0] = " & Dashboard.b183(0) & ";"
            End If
            If (Dashboard.b183(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][1] = " & Dashboard.b183(1) & ";"
            End If
            If (Dashboard.b183(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][22][2] = " & Dashboard.b183(2) & ";"
            End If
            If (Dashboard.b184(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][0] = " & Dashboard.b184(0) & ";"
            End If
            If (Dashboard.b184(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][1] = " & Dashboard.b184(1) & ";"
            End If
            If (Dashboard.b184(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][22][2] = " & Dashboard.b184(2) & ";"
            End If
            If (Dashboard.b193(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][0] = " & Dashboard.b193(0) & ";"
            End If
            If (Dashboard.b193(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][1] = " & Dashboard.b193(1) & ";"
            End If
            If (Dashboard.b193(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][24][2] = " & Dashboard.b193(2) & ";"
            End If
            If (Dashboard.b194(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][0] = " & Dashboard.b194(0) & ";"
            End If
            If (Dashboard.b194(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][1] = " & Dashboard.b194(1) & ";"
            End If
            If (Dashboard.b194(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][24][2] = " & Dashboard.b194(2) & ";"
            End If
            If (Dashboard.b195(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][0] = " & Dashboard.b195(0) & ";"
            End If
            If (Dashboard.b195(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][1] = " & Dashboard.b195(1) & ";"
            End If
            If (Dashboard.b195(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][24][2] = " & Dashboard.b195(2) & ";"
            End If
            If (Dashboard.b196(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][0] = " & Dashboard.b196(0) & ";"
            End If
            If (Dashboard.b196(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][1] = " & Dashboard.b196(1) & ";"
            End If
            If (Dashboard.b196(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][24][2] = " & Dashboard.b196(2) & ";"
            End If
            If (Dashboard.b197(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][0] = " & Dashboard.b197(0) & ";"
            End If
            If (Dashboard.b197(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][1] = " & Dashboard.b197(1) & ";"
            End If
            If (Dashboard.b197(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][24][2] = " & Dashboard.b197(2) & ";"
            End If
            If (Dashboard.b198(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][0] = " & Dashboard.b198(0) & ";"
            End If
            If (Dashboard.b198(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][1] = " & Dashboard.b198(1) & ";"
            End If
            If (Dashboard.b198(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][24][2] = " & Dashboard.b198(2) & ";"
            End If
            If (Dashboard.b199(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][0] = " & Dashboard.b199(0) & ";"
            End If
            If (Dashboard.b199(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][1] = " & Dashboard.b199(1) & ";"
            End If
            If (Dashboard.b199(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][24][2] = " & Dashboard.b199(2) & ";"
            End If
            If (Dashboard.b200(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][0] = " & Dashboard.b200(0) & ";"
            End If
            If (Dashboard.b200(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][1] = " & Dashboard.b200(1) & ";"
            End If
            If (Dashboard.b200(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][24][2] = " & Dashboard.b200(2) & ";"
            End If




            If (Dashboard.b16(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][0] = " & Dashboard.b16(0) & ";"
            End If
            If (Dashboard.b16(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][1] = " & Dashboard.b16(1) & ";"
            End If
            If (Dashboard.b16(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][1][2] = " & Dashboard.b16(2) & ";"
            End If
            If (Dashboard.b15(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][0] = " & Dashboard.b15(0) & ";"
            End If
            If (Dashboard.b15(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][1] = " & Dashboard.b15(1) & ";"
            End If
            If (Dashboard.b15(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][1][2] = " & Dashboard.b15(2) & ";"
            End If
            If (Dashboard.b14(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][0] = " & Dashboard.b14(0) & ";"
            End If
            If (Dashboard.b14(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][1] = " & Dashboard.b14(1) & ";"
            End If
            If (Dashboard.b14(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][1][2] = " & Dashboard.b14(2) & ";"
            End If
            If (Dashboard.b13(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][0] = " & Dashboard.b13(0) & ";"
            End If
            If (Dashboard.b13(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][1] = " & Dashboard.b13(1) & ";"
            End If
            If (Dashboard.b13(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][1][2] = " & Dashboard.b13(2) & ";"
            End If
            If (Dashboard.b12(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][0] = " & Dashboard.b12(0) & ";"
            End If
            If (Dashboard.b12(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][1] = " & Dashboard.b12(1) & ";"
            End If
            If (Dashboard.b12(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][1][2] = " & Dashboard.b12(2) & ";"
            End If
            If (Dashboard.b11(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][0] = " & Dashboard.b11(0) & ";"
            End If
            If (Dashboard.b11(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][1] = " & Dashboard.b11(1) & ";"
            End If
            If (Dashboard.b11(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][1][2] = " & Dashboard.b11(2) & ";"
            End If
            If (Dashboard.b10(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][0] = " & Dashboard.b10(0) & ";"
            End If
            If (Dashboard.b10(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][1] = " & Dashboard.b10(1) & ";"
            End If
            If (Dashboard.b10(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][1][2] = " & Dashboard.b10(2) & ";"
            End If
            If (Dashboard.b9(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][0] = " & Dashboard.b9(0) & ";"
            End If
            If (Dashboard.b9(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][1] = " & Dashboard.b9(1) & ";"
            End If
            If (Dashboard.b9(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][1][2] = " & Dashboard.b9(2) & ";"
            End If
            If (Dashboard.b32(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][0] = " & Dashboard.b32(0) & ";"
            End If
            If (Dashboard.b32(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][1] = " & Dashboard.b32(1) & ";"
            End If
            If (Dashboard.b32(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][3][2] = " & Dashboard.b32(2) & ";"
            End If
            If (Dashboard.b31(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][0] = " & Dashboard.b31(0) & ";"
            End If
            If (Dashboard.b31(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][1] = " & Dashboard.b31(1) & ";"
            End If
            If (Dashboard.b31(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][3][2] = " & Dashboard.b31(2) & ";"
            End If
            If (Dashboard.b30(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][0] = " & Dashboard.b30(0) & ";"
            End If
            If (Dashboard.b30(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][1] = " & Dashboard.b30(1) & ";"
            End If
            If (Dashboard.b30(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][3][2] = " & Dashboard.b30(2) & ";"
            End If
            If (Dashboard.b29(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][0] = " & Dashboard.b29(0) & ";"
            End If
            If (Dashboard.b29(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][1] = " & Dashboard.b29(1) & ";"
            End If
            If (Dashboard.b29(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][3][2] = " & Dashboard.b29(2) & ";"
            End If
            If (Dashboard.b28(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][0] = " & Dashboard.b28(0) & ";"
            End If
            If (Dashboard.b28(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][1] = " & Dashboard.b28(1) & ";"
            End If
            If (Dashboard.b28(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][3][2] = " & Dashboard.b28(2) & ";"
            End If
            If (Dashboard.b27(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][0] = " & Dashboard.b27(0) & ";"
            End If
            If (Dashboard.b27(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][1] = " & Dashboard.b27(1) & ";"
            End If
            If (Dashboard.b27(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][3][2] = " & Dashboard.b27(2) & ";"
            End If
            If (Dashboard.b26(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][0] = " & Dashboard.b26(0) & ";"
            End If
            If (Dashboard.b26(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][1] = " & Dashboard.b26(1) & ";"
            End If
            If (Dashboard.b26(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][3][2] = " & Dashboard.b26(2) & ";"
            End If
            If (Dashboard.b25(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][0] = " & Dashboard.b25(0) & ";"
            End If
            If (Dashboard.b25(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][1] = " & Dashboard.b25(1) & ";"
            End If
            If (Dashboard.b25(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][3][2] = " & Dashboard.b25(2) & ";"
            End If
            If (Dashboard.b48(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][0] = " & Dashboard.b48(0) & ";"
            End If
            If (Dashboard.b48(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][1] = " & Dashboard.b48(1) & ";"
            End If
            If (Dashboard.b48(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][5][2] = " & Dashboard.b48(2) & ";"
            End If
            If (Dashboard.b47(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][0] = " & Dashboard.b47(0) & ";"
            End If
            If (Dashboard.b47(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][1] = " & Dashboard.b47(1) & ";"
            End If
            If (Dashboard.b47(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][5][2] = " & Dashboard.b47(2) & ";"
            End If
            If (Dashboard.b46(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][0] = " & Dashboard.b46(0) & ";"
            End If
            If (Dashboard.b46(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][1] = " & Dashboard.b46(1) & ";"
            End If
            If (Dashboard.b46(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][5][2] = " & Dashboard.b46(2) & ";"
            End If
            If (Dashboard.b45(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][0] = " & Dashboard.b45(0) & ";"
            End If
            If (Dashboard.b45(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][1] = " & Dashboard.b45(1) & ";"
            End If
            If (Dashboard.b45(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][5][2] = " & Dashboard.b45(2) & ";"
            End If
            If (Dashboard.b44(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][0] = " & Dashboard.b44(0) & ";"
            End If
            If (Dashboard.b44(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][1] = " & Dashboard.b44(1) & ";"
            End If
            If (Dashboard.b44(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][5][2] = " & Dashboard.b44(2) & ";"
            End If
            If (Dashboard.b43(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][0] = " & Dashboard.b43(0) & ";"
            End If
            If (Dashboard.b43(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][1] = " & Dashboard.b43(1) & ";"
            End If
            If (Dashboard.b43(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][5][2] = " & Dashboard.b43(2) & ";"
            End If
            If (Dashboard.b42(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][0] = " & Dashboard.b42(0) & ";"
            End If
            If (Dashboard.b42(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][1] = " & Dashboard.b42(1) & ";"
            End If
            If (Dashboard.b42(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][5][2] = " & Dashboard.b42(2) & ";"
            End If
            If (Dashboard.b41(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][0] = " & Dashboard.b41(0) & ";"
            End If
            If (Dashboard.b41(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][1] = " & Dashboard.b41(1) & ";"
            End If
            If (Dashboard.b41(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][5][2] = " & Dashboard.b41(2) & ";"
            End If
            If (Dashboard.b64(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][0] = " & Dashboard.b64(0) & ";"
            End If
            If (Dashboard.b64(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][1] = " & Dashboard.b64(1) & ";"
            End If
            If (Dashboard.b64(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][7][2] = " & Dashboard.b64(2) & ";"
            End If
            If (Dashboard.b63(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][0] = " & Dashboard.b63(0) & ";"
            End If
            If (Dashboard.b63(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][1] = " & Dashboard.b63(1) & ";"
            End If
            If (Dashboard.b63(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][7][2] = " & Dashboard.b63(2) & ";"
            End If
            If (Dashboard.b62(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][0] = " & Dashboard.b62(0) & ";"
            End If
            If (Dashboard.b62(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][1] = " & Dashboard.b62(1) & ";"
            End If
            If (Dashboard.b62(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][7][2] = " & Dashboard.b62(2) & ";"
            End If
            If (Dashboard.b61(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][0] = " & Dashboard.b61(0) & ";"
            End If
            If (Dashboard.b61(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][1] = " & Dashboard.b61(1) & ";"
            End If
            If (Dashboard.b61(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][7][2] = " & Dashboard.b61(2) & ";"
            End If
            If (Dashboard.b60(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][0] = " & Dashboard.b60(0) & ";"
            End If
            If (Dashboard.b60(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][1] = " & Dashboard.b60(1) & ";"
            End If
            If (Dashboard.b60(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][7][2] = " & Dashboard.b60(2) & ";"
            End If
            If (Dashboard.b59(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][0] = " & Dashboard.b59(0) & ";"
            End If
            If (Dashboard.b59(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][1] = " & Dashboard.b59(1) & ";"
            End If
            If (Dashboard.b59(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][7][2] = " & Dashboard.b59(2) & ";"
            End If
            If (Dashboard.b58(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][0] = " & Dashboard.b58(0) & ";"
            End If
            If (Dashboard.b58(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][1] = " & Dashboard.b58(1) & ";"
            End If
            If (Dashboard.b58(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][7][2] = " & Dashboard.b58(2) & ";"
            End If
            If (Dashboard.b57(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][0] = " & Dashboard.b57(0) & ";"
            End If
            If (Dashboard.b57(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][1] = " & Dashboard.b57(1) & ";"
            End If
            If (Dashboard.b57(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][7][2] = " & Dashboard.b57(2) & ";"
            End If
            If (Dashboard.b80(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][0] = " & Dashboard.b80(0) & ";"
            End If
            If (Dashboard.b80(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][1] = " & Dashboard.b80(1) & ";"
            End If
            If (Dashboard.b80(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][9][2] = " & Dashboard.b80(2) & ";"
            End If
            If (Dashboard.b79(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][0] = " & Dashboard.b79(0) & ";"
            End If
            If (Dashboard.b79(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][1] = " & Dashboard.b79(1) & ";"
            End If
            If (Dashboard.b79(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][9][2] = " & Dashboard.b79(2) & ";"
            End If
            If (Dashboard.b78(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][0] = " & Dashboard.b78(0) & ";"
            End If
            If (Dashboard.b78(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][1] = " & Dashboard.b78(1) & ";"
            End If
            If (Dashboard.b78(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][9][2] = " & Dashboard.b78(2) & ";"
            End If
            If (Dashboard.b77(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][0] = " & Dashboard.b77(0) & ";"
            End If
            If (Dashboard.b77(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][1] = " & Dashboard.b77(1) & ";"
            End If
            If (Dashboard.b77(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][9][2] = " & Dashboard.b77(2) & ";"
            End If
            If (Dashboard.b76(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][0] = " & Dashboard.b76(0) & ";"
            End If
            If (Dashboard.b76(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][1] = " & Dashboard.b76(1) & ";"
            End If
            If (Dashboard.b76(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][9][2] = " & Dashboard.b76(2) & ";"
            End If
            If (Dashboard.b75(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][0] = " & Dashboard.b75(0) & ";"
            End If
            If (Dashboard.b75(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][1] = " & Dashboard.b75(1) & ";"
            End If
            If (Dashboard.b75(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][9][2] = " & Dashboard.b75(2) & ";"
            End If
            If (Dashboard.b74(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][0] = " & Dashboard.b74(0) & ";"
            End If
            If (Dashboard.b74(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][1] = " & Dashboard.b74(1) & ";"
            End If
            If (Dashboard.b74(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][9][2] = " & Dashboard.b74(2) & ";"
            End If
            If (Dashboard.b73(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][0] = " & Dashboard.b73(0) & ";"
            End If
            If (Dashboard.b73(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][1] = " & Dashboard.b73(1) & ";"
            End If
            If (Dashboard.b73(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][9][2] = " & Dashboard.b73(2) & ";"
            End If
            If (Dashboard.b96(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][0] = " & Dashboard.b96(0) & ";"
            End If
            If (Dashboard.b96(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][1] = " & Dashboard.b96(1) & ";"
            End If
            If (Dashboard.b96(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][11][2] = " & Dashboard.b96(2) & ";"
            End If
            If (Dashboard.b95(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][0] = " & Dashboard.b95(0) & ";"
            End If
            If (Dashboard.b95(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][1] = " & Dashboard.b95(1) & ";"
            End If
            If (Dashboard.b95(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][11][2] = " & Dashboard.b95(2) & ";"
            End If
            If (Dashboard.b94(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][0] = " & Dashboard.b94(0) & ";"
            End If
            If (Dashboard.b94(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][1] = " & Dashboard.b94(1) & ";"
            End If
            If (Dashboard.b94(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][11][2] = " & Dashboard.b94(2) & ";"
            End If
            If (Dashboard.b93(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][0] = " & Dashboard.b93(0) & ";"
            End If
            If (Dashboard.b93(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][1] = " & Dashboard.b93(1) & ";"
            End If
            If (Dashboard.b93(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][11][2] = " & Dashboard.b93(2) & ";"
            End If
            If (Dashboard.b92(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][0] = " & Dashboard.b92(0) & ";"
            End If
            If (Dashboard.b92(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][1] = " & Dashboard.b92(1) & ";"
            End If
            If (Dashboard.b92(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][11][2] = " & Dashboard.b92(2) & ";"
            End If
            If (Dashboard.b91(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][0] = " & Dashboard.b91(0) & ";"
            End If
            If (Dashboard.b91(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][1] = " & Dashboard.b91(1) & ";"
            End If
            If (Dashboard.b91(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][11][2] = " & Dashboard.b91(2) & ";"
            End If
            If (Dashboard.b90(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][0] = " & Dashboard.b90(0) & ";"
            End If
            If (Dashboard.b90(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][1] = " & Dashboard.b90(1) & ";"
            End If
            If (Dashboard.b90(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][11][2] = " & Dashboard.b90(2) & ";"
            End If
            If (Dashboard.b89(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][0] = " & Dashboard.b89(0) & ";"
            End If
            If (Dashboard.b89(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][1] = " & Dashboard.b89(1) & ";"
            End If
            If (Dashboard.b89(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][11][2] = " & Dashboard.b89(2) & ";"
            End If
            If (Dashboard.b112(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][0] = " & Dashboard.b112(0) & ";"
            End If
            If (Dashboard.b112(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][1] = " & Dashboard.b112(1) & ";"
            End If
            If (Dashboard.b112(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][13][2] = " & Dashboard.b112(2) & ";"
            End If
            If (Dashboard.b111(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][0] = " & Dashboard.b111(0) & ";"
            End If
            If (Dashboard.b111(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][1] = " & Dashboard.b111(1) & ";"
            End If
            If (Dashboard.b111(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][13][2] = " & Dashboard.b111(2) & ";"
            End If
            If (Dashboard.b110(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][0] = " & Dashboard.b110(0) & ";"
            End If
            If (Dashboard.b110(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][1] = " & Dashboard.b110(1) & ";"
            End If
            If (Dashboard.b110(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][13][2] = " & Dashboard.b110(2) & ";"
            End If
            If (Dashboard.b109(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][0] = " & Dashboard.b109(0) & ";"
            End If
            If (Dashboard.b109(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][1] = " & Dashboard.b109(1) & ";"
            End If
            If (Dashboard.b109(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][13][2] = " & Dashboard.b109(2) & ";"
            End If
            If (Dashboard.b108(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][0] = " & Dashboard.b108(0) & ";"
            End If
            If (Dashboard.b108(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][1] = " & Dashboard.b108(1) & ";"
            End If
            If (Dashboard.b108(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][13][2] = " & Dashboard.b108(2) & ";"
            End If
            If (Dashboard.b107(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][0] = " & Dashboard.b107(0) & ";"
            End If
            If (Dashboard.b107(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][1] = " & Dashboard.b107(1) & ";"
            End If
            If (Dashboard.b107(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][13][2] = " & Dashboard.b107(2) & ";"
            End If
            If (Dashboard.b106(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][0] = " & Dashboard.b106(0) & ";"
            End If
            If (Dashboard.b106(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][1] = " & Dashboard.b106(1) & ";"
            End If
            If (Dashboard.b106(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][13][2] = " & Dashboard.b106(2) & ";"
            End If
            If (Dashboard.b105(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][0] = " & Dashboard.b105(0) & ";"
            End If
            If (Dashboard.b105(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][1] = " & Dashboard.b105(1) & ";"
            End If
            If (Dashboard.b105(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][13][2] = " & Dashboard.b105(2) & ";"
            End If
            If (Dashboard.b128(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][0] = " & Dashboard.b128(0) & ";"
            End If
            If (Dashboard.b128(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][1] = " & Dashboard.b128(1) & ";"
            End If
            If (Dashboard.b128(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][15][2] = " & Dashboard.b128(2) & ";"
            End If
            If (Dashboard.b127(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][0] = " & Dashboard.b127(0) & ";"
            End If
            If (Dashboard.b127(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][1] = " & Dashboard.b127(1) & ";"
            End If
            If (Dashboard.b127(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][15][2] = " & Dashboard.b127(2) & ";"
            End If
            If (Dashboard.b126(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][0] = " & Dashboard.b126(0) & ";"
            End If
            If (Dashboard.b126(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][1] = " & Dashboard.b126(1) & ";"
            End If
            If (Dashboard.b126(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][15][2] = " & Dashboard.b126(2) & ";"
            End If
            If (Dashboard.b125(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][0] = " & Dashboard.b125(0) & ";"
            End If
            If (Dashboard.b125(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][1] = " & Dashboard.b125(1) & ";"
            End If
            If (Dashboard.b125(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][15][2] = " & Dashboard.b125(2) & ";"
            End If
            If (Dashboard.b124(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][0] = " & Dashboard.b124(0) & ";"
            End If
            If (Dashboard.b124(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][1] = " & Dashboard.b124(1) & ";"
            End If
            If (Dashboard.b124(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][15][2] = " & Dashboard.b124(2) & ";"
            End If
            If (Dashboard.b123(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][0] = " & Dashboard.b123(0) & ";"
            End If
            If (Dashboard.b123(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][1] = " & Dashboard.b123(1) & ";"
            End If
            If (Dashboard.b123(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][15][2] = " & Dashboard.b123(2) & ";"
            End If
            If (Dashboard.b122(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][0] = " & Dashboard.b122(0) & ";"
            End If
            If (Dashboard.b122(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][1] = " & Dashboard.b122(1) & ";"
            End If
            If (Dashboard.b122(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][15][2] = " & Dashboard.b122(2) & ";"
            End If
            If (Dashboard.b121(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][0] = " & Dashboard.b121(0) & ";"
            End If
            If (Dashboard.b121(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][1] = " & Dashboard.b121(1) & ";"
            End If
            If (Dashboard.b121(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][15][2] = " & Dashboard.b121(2) & ";"
            End If
            If (Dashboard.b144(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][0] = " & Dashboard.b144(0) & ";"
            End If
            If (Dashboard.b144(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][1] = " & Dashboard.b144(1) & ";"
            End If
            If (Dashboard.b144(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][17][2] = " & Dashboard.b144(2) & ";"
            End If
            If (Dashboard.b143(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][0] = " & Dashboard.b143(0) & ";"
            End If
            If (Dashboard.b143(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][1] = " & Dashboard.b143(1) & ";"
            End If
            If (Dashboard.b143(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][17][2] = " & Dashboard.b143(2) & ";"
            End If
            If (Dashboard.b142(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][0] = " & Dashboard.b142(0) & ";"
            End If
            If (Dashboard.b142(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][1] = " & Dashboard.b142(1) & ";"
            End If
            If (Dashboard.b142(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][17][2] = " & Dashboard.b142(2) & ";"
            End If
            If (Dashboard.b141(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][0] = " & Dashboard.b141(0) & ";"
            End If
            If (Dashboard.b141(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][1] = " & Dashboard.b141(1) & ";"
            End If
            If (Dashboard.b141(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][17][2] = " & Dashboard.b141(2) & ";"
            End If
            If (Dashboard.b140(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][0] = " & Dashboard.b140(0) & ";"
            End If
            If (Dashboard.b140(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][1] = " & Dashboard.b140(1) & ";"
            End If
            If (Dashboard.b140(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][17][2] = " & Dashboard.b140(2) & ";"
            End If
            If (Dashboard.b139(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][0] = " & Dashboard.b139(0) & ";"
            End If
            If (Dashboard.b139(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][1] = " & Dashboard.b139(1) & ";"
            End If
            If (Dashboard.b139(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][17][2] = " & Dashboard.b139(2) & ";"
            End If
            If (Dashboard.b138(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][0] = " & Dashboard.b138(0) & ";"
            End If
            If (Dashboard.b138(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][1] = " & Dashboard.b138(1) & ";"
            End If
            If (Dashboard.b138(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][17][2] = " & Dashboard.b138(2) & ";"
            End If
            If (Dashboard.b137(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][0] = " & Dashboard.b137(0) & ";"
            End If
            If (Dashboard.b137(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][1] = " & Dashboard.b137(1) & ";"
            End If
            If (Dashboard.b137(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][17][2] = " & Dashboard.b137(2) & ";"
            End If
            If (Dashboard.b160(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][0] = " & Dashboard.b160(0) & ";"
            End If
            If (Dashboard.b160(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][1] = " & Dashboard.b160(1) & ";"
            End If
            If (Dashboard.b160(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][19][2] = " & Dashboard.b160(2) & ";"
            End If
            If (Dashboard.b159(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][0] = " & Dashboard.b159(0) & ";"
            End If
            If (Dashboard.b159(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][1] = " & Dashboard.b159(1) & ";"
            End If
            If (Dashboard.b159(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][19][2] = " & Dashboard.b159(2) & ";"
            End If
            If (Dashboard.b158(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][0] = " & Dashboard.b158(0) & ";"
            End If
            If (Dashboard.b158(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][1] = " & Dashboard.b158(1) & ";"
            End If
            If (Dashboard.b158(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][19][2] = " & Dashboard.b158(2) & ";"
            End If
            If (Dashboard.b157(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][0] = " & Dashboard.b157(0) & ";"
            End If
            If (Dashboard.b157(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][1] = " & Dashboard.b157(1) & ";"
            End If
            If (Dashboard.b157(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][19][2] = " & Dashboard.b157(2) & ";"
            End If
            If (Dashboard.b156(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][0] = " & Dashboard.b156(0) & ";"
            End If
            If (Dashboard.b156(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][1] = " & Dashboard.b156(1) & ";"
            End If
            If (Dashboard.b156(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][19][2] = " & Dashboard.b156(2) & ";"
            End If
            If (Dashboard.b155(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][0] = " & Dashboard.b155(0) & ";"
            End If
            If (Dashboard.b155(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][1] = " & Dashboard.b155(1) & ";"
            End If
            If (Dashboard.b155(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][19][2] = " & Dashboard.b155(2) & ";"
            End If
            If (Dashboard.b154(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][0] = " & Dashboard.b154(0) & ";"
            End If
            If (Dashboard.b154(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][1] = " & Dashboard.b154(1) & ";"
            End If
            If (Dashboard.b154(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][19][2] = " & Dashboard.b154(2) & ";"
            End If
            If (Dashboard.b153(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][0] = " & Dashboard.b153(0) & ";"
            End If
            If (Dashboard.b153(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][1] = " & Dashboard.b153(1) & ";"
            End If
            If (Dashboard.b153(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][19][2] = " & Dashboard.b153(2) & ";"
            End If
            If (Dashboard.b176(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][0] = " & Dashboard.b176(0) & ";"
            End If
            If (Dashboard.b176(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][1] = " & Dashboard.b176(1) & ";"
            End If
            If (Dashboard.b176(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][21][2] = " & Dashboard.b176(2) & ";"
            End If
            If (Dashboard.b175(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][0] = " & Dashboard.b175(0) & ";"
            End If
            If (Dashboard.b175(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][1] = " & Dashboard.b175(1) & ";"
            End If
            If (Dashboard.b175(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][21][2] = " & Dashboard.b175(2) & ";"
            End If
            If (Dashboard.b174(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][0] = " & Dashboard.b174(0) & ";"
            End If
            If (Dashboard.b174(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][1] = " & Dashboard.b174(1) & ";"
            End If
            If (Dashboard.b174(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][21][2] = " & Dashboard.b174(2) & ";"
            End If
            If (Dashboard.b173(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][0] = " & Dashboard.b173(0) & ";"
            End If
            If (Dashboard.b173(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][1] = " & Dashboard.b173(1) & ";"
            End If
            If (Dashboard.b173(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][21][2] = " & Dashboard.b173(2) & ";"
            End If
            If (Dashboard.b172(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][0] = " & Dashboard.b172(0) & ";"
            End If
            If (Dashboard.b172(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][1] = " & Dashboard.b172(1) & ";"
            End If
            If (Dashboard.b172(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][21][2] = " & Dashboard.b172(2) & ";"
            End If
            If (Dashboard.b171(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][0] = " & Dashboard.b171(0) & ";"
            End If
            If (Dashboard.b171(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][1] = " & Dashboard.b171(1) & ";"
            End If
            If (Dashboard.b171(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][21][2] = " & Dashboard.b171(2) & ";"
            End If
            If (Dashboard.b170(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][0] = " & Dashboard.b170(0) & ";"
            End If
            If (Dashboard.b170(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][1] = " & Dashboard.b170(1) & ";"
            End If
            If (Dashboard.b170(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][21][2] = " & Dashboard.b170(2) & ";"
            End If
            If (Dashboard.b169(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][0] = " & Dashboard.b169(0) & ";"
            End If
            If (Dashboard.b169(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][1] = " & Dashboard.b169(1) & ";"
            End If
            If (Dashboard.b169(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][21][2] = " & Dashboard.b169(2) & ";"
            End If
            If (Dashboard.b192(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][0] = " & Dashboard.b192(0) & ";"
            End If
            If (Dashboard.b192(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][1] = " & Dashboard.b192(1) & ";"
            End If
            If (Dashboard.b192(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[0][23][2] = " & Dashboard.b192(2) & ";"
            End If
            If (Dashboard.b191(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][0] = " & Dashboard.b191(0) & ";"
            End If
            If (Dashboard.b191(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][1] = " & Dashboard.b191(1) & ";"
            End If
            If (Dashboard.b191(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[1][23][2] = " & Dashboard.b191(2) & ";"
            End If
            If (Dashboard.b190(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][0] = " & Dashboard.b190(0) & ";"
            End If
            If (Dashboard.b190(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][1] = " & Dashboard.b190(1) & ";"
            End If
            If (Dashboard.b190(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[2][23][2] = " & Dashboard.b190(2) & ";"
            End If
            If (Dashboard.b189(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][0] = " & Dashboard.b189(0) & ";"
            End If
            If (Dashboard.b189(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][1] = " & Dashboard.b189(1) & ";"
            End If
            If (Dashboard.b189(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[3][23][2] = " & Dashboard.b189(2) & ";"
            End If
            If (Dashboard.b188(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][0] = " & Dashboard.b188(0) & ";"
            End If
            If (Dashboard.b188(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][1] = " & Dashboard.b188(1) & ";"
            End If
            If (Dashboard.b188(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[4][23][2] = " & Dashboard.b188(2) & ";"
            End If
            If (Dashboard.b187(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][0] = " & Dashboard.b187(0) & ";"
            End If
            If (Dashboard.b187(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][1] = " & Dashboard.b187(1) & ";"
            End If
            If (Dashboard.b187(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[5][23][2] = " & Dashboard.b187(2) & ";"
            End If
            If (Dashboard.b186(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][0] = " & Dashboard.b186(0) & ";"
            End If
            If (Dashboard.b186(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][1] = " & Dashboard.b186(1) & ";"
            End If
            If (Dashboard.b186(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[6][23][2] = " & Dashboard.b186(2) & ";"
            End If
            If (Dashboard.b185(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][0] = " & Dashboard.b185(0) & ";"
            End If
            If (Dashboard.b185(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][1] = " & Dashboard.b185(1) & ";"
            End If
            If (Dashboard.b185(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Dashboard.TextBox2.Text & "[7][23][2] = " & Dashboard.b185(2) & ";"
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