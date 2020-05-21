Imports System.Text

Public Class LedgerHack

    Public Const CYPHER_HEX1 As String = "F4 DD BF C9 D6 D2 85 A4 F5 E0 8F E7 B4 C7 E2 EA " &
                                         "DF E8 BF F0 DF E9 E8 C2 CE C5 95 C2 B2 C8 DE F3 " &
                                         "B5 B0 E9 D5 B9 E4 FA DD D6 DA E7 BF D9 6D D9 C8 " &
                                         "87 CE F2 E8 BE E9 B0 D3 DF C4 D7 F3 DC D5 EA DE " &
                                         "C4 D5 9C 78 C0 C8 A6 E6 E1 E4 BE B4 ED B4 E8 D9 " &
                                         "EA C1 DE C1 C8 FA C2 C5 B5"

    Public Const CYPHER_HEX2 As String = "EC DD F3 B5 D9 9D A6 AF EF C7 8F DE 8F CA E7 E5 " &
                                         "B1 EF EE F0 B7 ED D6 ED BF 9D A4 BC DB C2 AF E3 " &
                                         "D6 C2 F0 BC B9 EE F5 E7 D4 DA C3 E8 B8 A2 DF C4 " &
                                         "84 A6 F2 E6 ED C6 B1 D0 ED F7 DA F4 B7 EB E8 ED " &
                                         "BA C7 D0 AF C2 8F D9 E3 F0 D1 F0 AC EE D9 B9 DE " &
                                         "E9 FA DD A0"

    Public Const CYPHER_HEX3 As String = "F4 B7 F2 C5 D9 C2 85 AB F2 EB B4 B5 C6 CB BE E4 " &
                                         "D2 EF BF E4 D8 F6 DA C2 BB 9D A4 B5 DE BA AF DF " &
                                         "D7 BE EC E4 B9 E3 FB F0 B1 EE F2 F4 B8 8E DC CF " &
                                         "92 D5 DF D2 E6 EB A5 AF DE E9 D8 EA E7 DC E4 EB " &
                                         "BB F5 C3 78 C7 B7 CF F1 C0 DD E3 BE ED D5 E0 D8 " &
                                         "D2 C1 AA"

    Public Const CYPHER_HEX4 As String = "EC E3 F2 BF B3 9D B7 A8 F0 E0 BC D7 B4 D8 BE F5 " &
                                         "E0 C1 E3 EE E0 EE E0 C2 D3 CC A5 C6 B2 BE E5 DF " &
                                         "E1 C3 E0 DE DE BC"


    Public formInitializing As Boolean = True
    Public encryptionFlag As Boolean = False
    Public textInputFlag As Boolean = False


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InputHexTextBox1.Text = CYPHER_HEX1
        InputHexTextBox2.Text = CYPHER_HEX2
        InputHexTextBox3.Text = CYPHER_HEX3
        InputHexTextBox4.Text = CYPHER_HEX4
    End Sub


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        formInitializing = False
    End Sub


    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click
        HandleEncrypyDecrypt()
    End Sub


    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        HandleEncrypyDecrypt()
    End Sub


    Private Sub PlainInputTextBox_TextChanged(sender As Object, e As EventArgs) Handles PlainInputTextBox.TextChanged
        If Not textInputFlag Then
            InputHexTextBox.Text = TextToHex(PlainInputTextBox.Text)
        End If
        HandleEncrypyDecrypt()
    End Sub


    Private Function TextToHex(ByVal inString As String) As String
        Dim newString As StringBuilder = New StringBuilder

        If inString.Length = 0 Then
            Return ""
        End If

        For i As Integer = 0 To (inString.Length - 1)
            Dim newChar As Char = inString.Substring(i, 1)
            newString.Append(Asc(newChar).ToString("X2") & " ")
        Next

        Return newString.ToString
    End Function


    Private Function EncryptString(ByVal inString As String, ByVal inKey As String) As String
        Dim outString As String = ""
        Dim tempString As String = ""
        Dim skipPreProcess As Boolean = True

        Dim bValue As Integer
        Dim cValue As Integer

        If inKey.Length < 1 Or inString.Length < 2 Then
            Return inString
        End If

        If inKey.Length > inString.Length Then
            tempString = inKey.Substring(0, inString.Length)
            skipPreProcess = False

        ElseIf inKey.Length = inString.Length Then
            tempString = inKey
            skipPreProcess = False

        End If


        If skipPreProcess Then
            bValue = Math.Truncate(inString.Length / inKey.Length)
            cValue = inString.Length - (bValue * inKey.Length)

            For i As Integer = 0 To (bValue - 1)
                tempString += inKey
            Next

            If tempString.Length <> inString.Length Then
                tempString += inKey.Substring(0, cValue)
            End If
        End If

        For i As Integer = 0 To (inString.Length - 1)
            bValue = Asc(inString.Substring(i, 1)) + Asc(tempString.Substring(i, 1))

            If bValue > 255 Then
                bValue -= 255
            End If

            outString += Chr(bValue)
        Next

        Return outString
    End Function


    Private Function DecryptString(ByVal inString As String, ByVal inKey As String) As String
        Dim outString As String = ""
        Dim tempString As String = ""
        Dim skipPreProcess As Boolean = True

        Dim bValue As Integer
        Dim cValue As Integer

        If inKey.Length < 1 Or inString.Length < 2 Then
            Return inString
        End If

        If inKey.Length > inString.Length Then
            tempString = inKey.Substring(0, inString.Length)
            skipPreProcess = False

        ElseIf inKey.Length = inString.Length Then
            tempString = inKey
            skipPreProcess = False

        End If

        If skipPreProcess Then
            bValue = Math.Truncate(inString.Length / inKey.Length)
            cValue = inString.Length - (bValue * inKey.Length)

            For i As Integer = 0 To (bValue - 1)
                tempString += inKey
            Next

            If tempString.Length <> inString.Length Then
                tempString += inKey.Substring(0, cValue)
            End If
        End If

        For i As Integer = 0 To (inString.Length - 1)
            bValue = Asc(inString.Substring(i, 1)) - Asc(tempString.Substring(i, 1))

            If bValue < 0 Then
                bValue += 255
            End If

            outString += Chr(bValue)
        Next

        Return outString
    End Function


    Private Sub HandleEncrypyDecrypt()
        Dim tempString As String

        If encryptionFlag Then

            tempString = EncryptString(PlainInputTextBox.Text, Key1TextBox.Text)
            OutputTextBox.Text = EncryptString(tempString, Key2TextBox.Text)

            tempString = EncryptString(PlainInputTextBox1.Text, Key1TextBox.Text)
            OutputTextBox1.Text = EncryptString(tempString, Key2TextBox.Text)

            tempString = EncryptString(PlainInputTextBox2.Text, Key1TextBox.Text)
            OutputTextBox2.Text = EncryptString(tempString, Key2TextBox.Text)

            tempString = EncryptString(PlainInputTextBox3.Text, Key1TextBox.Text)
            OutputTextBox3.Text = EncryptString(tempString, Key2TextBox.Text)

            tempString = EncryptString(PlainInputTextBox4.Text, Key1TextBox.Text)
            OutputTextBox4.Text = EncryptString(tempString, Key2TextBox.Text)

        Else

            tempString = DecryptString(PlainInputTextBox.Text, Key2TextBox.Text)
            OutputTextBox.Text = DecryptString(tempString, Key1TextBox.Text)

            tempString = DecryptString(PlainInputTextBox1.Text, Key2TextBox.Text)
            OutputTextBox1.Text = DecryptString(tempString, Key1TextBox.Text)

            tempString = DecryptString(PlainInputTextBox2.Text, Key2TextBox.Text)
            OutputTextBox2.Text = DecryptString(tempString, Key1TextBox.Text)

            tempString = DecryptString(PlainInputTextBox3.Text, Key2TextBox.Text)
            OutputTextBox3.Text = DecryptString(tempString, Key1TextBox.Text)

            tempString = DecryptString(PlainInputTextBox4.Text, Key2TextBox.Text)
            OutputTextBox4.Text = DecryptString(tempString, Key1TextBox.Text)

        End If

    End Sub


    Private Sub OutputTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox.TextChanged
        OutputHexTextBox.Text = TextToHex(OutputTextBox.Text)
    End Sub


    Private Sub Key1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Key1TextBox.TextChanged
        If (Not formInitializing) AndAlso (Key1TextBox.Text <> "") Then
            HandleEncrypyDecrypt()
        End If
    End Sub


    Private Sub Key2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Key2TextBox.TextChanged
        If (Not formInitializing) AndAlso (Key2TextBox.Text <> "") Then
            HandleEncrypyDecrypt()
        End If
    End Sub


    Private Sub EncryptRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles EncryptRadioButton.CheckedChanged
        If (Not formInitializing) Then
            encryptionFlag = EncryptRadioButton.Checked
        End If
    End Sub


    Private Sub InputHexTextBox_TextChanged(sender As Object, e As EventArgs) Handles InputHexTextBox.TextChanged
        PlainInputTextBox.Text = HexStringToAsc(InputHexTextBox.Text)
        InputHexTextBox.Text = InputHexTextBox.Text.ToUpper
    End Sub

    Private Sub TextInputRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TextInputRadioButton.CheckedChanged
        If (Not formInitializing) Then
            textInputFlag = Not TextInputRadioButton.Checked
        End If

        PlainInputTextBox.ReadOnly = textInputFlag
        InputHexTextBox.ReadOnly = Not textInputFlag
    End Sub


    Private Function HexStringToAsc(ByVal inString As String) As String
        Dim outString As String = ""
        Dim tempString As String = StripSpaces(inString)

        If (tempString.Length) < 2 Or (tempString.Length Mod 2 <> 0) Then
            Return outString
        End If

        For i As Integer = 0 To (tempString.Length - 1) Step 2
            Dim byteString As String = tempString.Substring(i, 2)
            Try
                outString += Chr(Convert.ToInt32(byteString, 16))
            Catch ex As Exception

            End Try

        Next

        Return outString
    End Function


    Private Function StripSpaces(ByVal inString As String) As String
        Dim outString As String = inString.Replace(" ", "")

        Return outString
    End Function


    Private Sub FindKeyButton_Click(sender As Object, e As EventArgs) Handles FindKeyButton.Click
        If SearchWordTextBox.Text <> "" Then
            PossibleKeyTextBox.Text = HandleSearchKey(SearchWordTextBox.Text, PlainInputTextBox.Text)
        End If
    End Sub


    Public Function HandleSearchKey(ByVal searchWord As String, ByVal searchBlock As String) As String

        Dim foundKey As String = ""
        Dim returnKey As String = ""

        Dim testKey As String

        Dim firstFoundKey As Boolean = True

        HackProgressBar.Visible = True

        Console.WriteLine("")
        Console.WriteLine("NEW SEARCH ---> " & searchWord)
        Console.WriteLine("------------------------------")

        For i As Integer = 0 To (searchBlock.Length - searchWord.Length)

            HackProgressBar.Value = 100 * (i / (searchBlock.Length - searchWord.Length + 1))
            HackStatusLabel.TextAlign = ContentAlignment.MiddleCenter
            HackStatusLabel.Text = (100 * (i / (searchBlock.Length - searchWord.Length + 1))).ToString("00") & "%"

            Dim searchSubBlock As String = searchBlock.Substring(i, searchWord.Length)

            For j As Integer = 0 To (searchWord.Length - 1)
                Application.DoEvents()

                For k As Integer = 0 To 255

                    testKey = foundKey & Chr(k)

                    Dim tempStringOne As String = DecryptString(searchSubBlock, testKey)
                    Dim tempStringTwo As String = DecryptString(tempStringOne, Key2TextBox.Text)

                    If Mid(tempStringTwo, (j + 1), 1) = searchWord.Substring(j, 1) Then
                        foundKey += Chr(k)
                        Exit For
                    End If

                    If k = 255 Then
                        'Console.WriteLine("unable to find matching character for: " & Chr(j))
                    End If

                Next

                If foundKey.Length = searchWord.Length Then
                    Dim tempStringOne As String = DecryptString(searchBlock, foundKey)
                    Dim tempStringTwo As String = DecryptString(tempStringOne, Key2TextBox.Text)

                    If tempStringTwo.IndexOf(searchWord) >= 0 Then
                        Console.WriteLine("found a possible key with value: " & foundKey & " :: " & tempStringTwo)

                        If firstFoundKey Then
                            returnKey = foundKey
                            firstFoundKey = False
                        End If

                    End If

                    Exit For
                End If

            Next
            foundKey = ""
        Next

        HackProgressBar.Value = 0
        HackProgressBar.Visible = False
        HackStatusLabel.Text = "Ready..."

        Return returnKey
    End Function


    Private Sub PlainInputTextBox1_TextChanged(sender As Object, e As EventArgs) Handles PlainInputTextBox1.TextChanged
        If textInputFlag Then
            InputHexTextBox1.Text = TextToHex(PlainInputTextBox1.Text)
        End If
        HandleEncrypyDecrypt()
    End Sub


    Private Sub PlainInputTextBox2_TextChanged(sender As Object, e As EventArgs) Handles PlainInputTextBox2.TextChanged
        If textInputFlag Then
            InputHexTextBox2.Text = TextToHex(PlainInputTextBox2.Text)
        End If
        HandleEncrypyDecrypt()
    End Sub


    Private Sub PlainInputTextBox3_TextChanged(sender As Object, e As EventArgs) Handles PlainInputTextBox3.TextChanged
        If textInputFlag Then
            InputHexTextBox3.Text = TextToHex(PlainInputTextBox3.Text)
        End If
        HandleEncrypyDecrypt()
    End Sub


    Private Sub PlainInputTextBox4_TextChanged(sender As Object, e As EventArgs) Handles PlainInputTextBox4.TextChanged
        If PlainInputTextBox4.Text <> "" Then
            InputHexTextBox4.Text = TextToHex(PlainInputTextBox4.Text)
        End If
        HandleEncrypyDecrypt()
    End Sub


    Private Sub InputHexTextBox1_TextChanged(sender As Object, e As EventArgs) Handles InputHexTextBox1.TextChanged
        If Not textInputFlag Then
            PlainInputTextBox1.Text = HexStringToAsc(InputHexTextBox1.Text)
        End If
    End Sub


    Private Sub InputHexTextBox2_TextChanged(sender As Object, e As EventArgs) Handles InputHexTextBox2.TextChanged
        If Not textInputFlag Then
            PlainInputTextBox2.Text = HexStringToAsc(InputHexTextBox2.Text)
        End If
    End Sub


    Private Sub InputHexTextBox3_TextChanged(sender As Object, e As EventArgs) Handles InputHexTextBox3.TextChanged
        If Not textInputFlag Then
            PlainInputTextBox3.Text = HexStringToAsc(InputHexTextBox3.Text)
        End If
    End Sub


    Private Sub InputHexTextBox4_TextChanged(sender As Object, e As EventArgs) Handles InputHexTextBox4.TextChanged
        If Not textInputFlag Then
            PlainInputTextBox4.Text = HexStringToAsc(InputHexTextBox4.Text)
        End If
    End Sub


    Private Sub OutputTextBox1_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox1.TextChanged
        OutputHexTextBox1.Text = TextToHex(OutputTextBox1.Text)
    End Sub


    Private Sub OutputTextBox2_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox2.TextChanged
        OutputHexTextBox2.Text = TextToHex(OutputTextBox2.Text)
    End Sub


    Private Sub OutputTextBox3_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox3.TextChanged
        OutputHexTextBox3.Text = TextToHex(OutputTextBox3.Text)
    End Sub


    Private Sub OutputTextBox4_TextChanged(sender As Object, e As EventArgs) Handles OutputTextBox4.TextChanged
        OutputHexTextBox4.Text = TextToHex(OutputTextBox4.Text)
    End Sub


    Private Sub Work1Button_Click(sender As Object, e As EventArgs) Handles Work1Button.Click
        InputHexTextBox.Text = InputHexTextBox1.Text
    End Sub


    Private Sub Work2Button_Click(sender As Object, e As EventArgs) Handles Work2Button.Click
        InputHexTextBox.Text = InputHexTextBox2.Text
    End Sub


    Private Sub Work3Button_Click(sender As Object, e As EventArgs) Handles Work3Button.Click
        InputHexTextBox.Text = InputHexTextBox3.Text
    End Sub


    Private Sub Work4Button_Click(sender As Object, e As EventArgs) Handles Work4Button.Click
        InputHexTextBox.Text = InputHexTextBox4.Text
    End Sub


    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Key1TextBox.Text = PossibleKeyTextBox.Text
    End Sub


    Private Sub InputHexTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InputHexTextBox.KeyPress
        Dim HexLetters As String = "0123456789abcdefABCDEF " & vbBack

        If Not HexLetters.Contains(e.KeyChar) Then e.Handled = True

    End Sub


End Class