Public Class Form1
    'Variables
    Dim cusName As String
    Dim cusID As Integer
    Dim sbQuantity As Integer
    Dim bootsQuantity As Integer
    Dim sbCost As Integer
    Dim bootCost As Integer
    Dim cumCost As Integer
    Dim dailySummary As ArrayList = New ArrayList()
    Dim avgPCus As Double
    Dim sbTotal As Integer
    Dim sbwbTotal As Integer
    Dim dailyTotal As Integer
    Dim cumSB As Integer
    Dim cumSBwB As Integer

    Private Const snowboards As Integer = 20
    Private Const sbwBoots As Integer = 30

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Transparent Panel BG
        InputPanel.BackColor = Color.FromArgb(200, Color.AliceBlue)
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'Check for value and type
        DisplayBox.Clear()
        Dim booName As Boolean = False
        Dim booID As Boolean = False
        Dim booSB As Boolean = False
        Dim booBoot As Boolean = False

        If (nameBox.Text.Length = 0) Then
            booName = True
            nameBox.BackColor = Color.Pink
            DisplayBox.Text += "Missing Name" + vbCrLf
        End If
        If (idBox.Text.Length = 0 Or Int16.TryParse(idBox.Text, cusID) <> True) Then
            booID = True
            idBox.BackColor = Color.Pink
            If idBox.Text.Length = 0 Then
                DisplayBox.Text += "Missing ID" + vbCrLf
            Else
                DisplayBox.Text += "Invalid ID" + vbCrLf
            End If
        End If
        If (sbBox.Text.Length = 0 Or Int16.TryParse(sbBox.Text, sbQuantity) <> True) Then
            booSB = True
            sbBox.BackColor = Color.Pink
            If idBox.Text.Length = 0 Then
                DisplayBox.Text += "Missing Snowboards quantity" + vbCrLf
            Else
                DisplayBox.Text += "Invalid Snowboards quantity" + vbCrLf
            End If
        End If
        If (sbwbBox.Text.Length = 0 Or Int16.TryParse(sbwbBox.Text, bootsQuantity) <> True) Then
            booBoot = True
            sbwbBox.BackColor = Color.Pink
            If idBox.Text.Length = 0 Then
                DisplayBox.Text += "Missing Boots quantity" + vbCrLf
            Else
                DisplayBox.Text += "Invalid Boots quantity" + vbCrLf
            End If
        End If
        If (booName Or booID Or booSB Or booBoot) Then
            MessageBox.Show("Input Error Detected", "Error")
        Else
            'Turn box back to white in case is red
            entryWhitening()
            'calculating step
            cusName = nameBox.Text
            cusID = idBox.Text
            sbQuantity = sbBox.Text
            bootsQuantity = sbwbBox.Text
            sbCost = sbQuantity * snowboards
            bootCost = bootsQuantity * sbwBoots
            cumCost = sbCost + bootCost
            Dim transc As String() = New String(7) {dailySummary.Count + 1, cusName, cusID, sbQuantity, bootsQuantity, sbCost, bootCost, cumCost}
            dailySummary.Add(transc)
            'Display Result
            totalSBbox.Text = "$" + sbCost.ToString
            totalSBwBbox.Text = "$" + bootCost.ToString
            totalBox.Text = "$" + cumCost.ToString
            DisplayBox.Text += "Here is your order:" + vbCrLf
            DisplayBox.Text += "Order # " + transc(0).ToString + vbCrLf
            DisplayBox.Text += "Name: " + transc(1) + vbCrLf
            DisplayBox.Text += "ID: " + transc(2).ToString + vbCrLf
            DisplayBox.Text += transc(3) + " * Snowboards = $" + transc(5).ToString + vbCrLf
            DisplayBox.Text += transc(4).ToString + " * Snowboards w/ Boots = $" + transc(6).ToString + vbCrLf
            DisplayBox.Text += "Your Total is $" + transc(7).ToString + vbCrLf
            DisplayBox.Text += "Thank you for renting with Very Very Boards" + vbCrLf

        End If
        'DisplayBox.Text += "Hello World"
        'DisplayBox.Text += dailySummary.Count.ToString


    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        emptyEntry()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Dim exitAnswer = MessageBox.Show("Do you want to exit this program?", "Exit Application", MessageBoxButtons.YesNo)
        If exitAnswer = DialogResult.Yes Then
            Me.Close()
        ElseIf exitAnswer = DialogResult.No Then
            nameBox.Select()
        End If
    End Sub

    Private Sub clearAllButton_Click(sender As Object, e As EventArgs) Handles clearAllButton.Click
        emptyEntry()
        dailySummary.Clear()
        sbTotalBox.Clear()
        sbwbTotalBox.Clear()
        dailyTotalBox.Clear()
        avgPCusBox.Clear()
    End Sub

    Private Sub calcSummary()
        avgPCus = 0
        sbTotal = 0
        sbwbTotal = 0
        dailyTotal = 0
        cumSB = 0
        cumSBwB = 0
        Dim arry As String()
        For i As Integer = 0 To dailySummary.Count - 1
            arry = dailySummary.Item(i)
            cumSB += arry(3)
            cumSBwB += arry(4)
            sbTotal += arry(5)
            sbwbTotal += arry(6)
            dailyTotal += arry(7)
            avgPCus = dailyTotal / dailySummary.Count
        Next

    End Sub

    Private Sub loopPrintLine(s As String, i As Integer)
        For j As Integer = 1 To i
            DisplayBox.Text += s
        Next
        DisplayBox.Text += vbCrLf
    End Sub

    Private Sub sumButton_Click(sender As Object, e As EventArgs) Handles sumButton.Click
        'Show Summary Info
        DisplayBox.Clear()
        calcSummary()
        sbTotalBox.Text = sbTotal
        sbwbTotalBox.Text = sbwbTotal
        dailyTotalBox.Text = dailyTotal
        avgPCusBox.Text = avgPCus
        DisplayBox.Text += "Summary: " + vbCrLf
        DisplayBox.Text += String.Format("Today's Total Order: {0}" + vbCrLf, dailySummary.Count)
        DisplayBox.Text += String.Format("Today's Total Snowboards Only: {0}" + vbCrLf, cumSB)
        DisplayBox.Text += String.Format("Today's Total Snowboards with Boots: {0}" + vbCrLf, cumSBwB)
        DisplayBox.Text += String.Format("Today's Total Snowboards Only Revenue: {0}" + vbCrLf, sbTotal)
        DisplayBox.Text += String.Format("Today's Total Snowboards with Boots Revenue: {0}" + vbCrLf, sbwbTotal)
        DisplayBox.Text += String.Format("Today's Cumulative TotalRevenue: {0}" + vbCrLf, dailyTotal)
        'Show Detail Info
        Dim arry As String()
        Dim msgL As String
        DisplayBox.Text += vbCrLf + vbCrLf + "Detail Page" + vbCrLf
        msgL = "Name   ID   SB(q)   SBWB(q)   SB(c)   SBWB(c)   Cumu(c)"
        DisplayBox.Text += msgL + vbCrLf
        loopPrintLine("=", msgL.Length)
        'DisplayBox.Text += "=" * msgL.Length + vbCrLf
        For i As Integer = 0 To dailySummary.Count - 1
            arry = dailySummary.Item(i)
            msgL = String.Format("{0}   {1}   #{2}   #{3}   ${4}   ${5}   ${6}", arry(1).ToString, arry(2).ToString, arry(3).ToString, arry(4).ToString, arry(5).ToString, arry(6).ToString, arry(7).ToString)
            DisplayBox.Text += msgL + vbCrLf
            loopPrintLine("--", msgL.Length)
            'DisplayBox.Text += "-" * msgL.Length + vbCrLf

        Next

    End Sub

    Private Sub emptyEntry()
        'remove values on input
        nameBox.Clear()
        idBox.Clear()
        sbBox.Clear()
        sbwbBox.Clear()
        totalSBbox.Clear()
        totalSBwBbox.Clear()
        totalBox.Clear()
        DisplayBox.Clear()
        entryWhitening()
    End Sub

    Private Sub entryWhitening()
        'Turn box back to white
        nameBox.BackColor = Color.White
        idBox.BackColor = Color.White
        sbBox.BackColor = Color.White
        sbwbBox.BackColor = Color.White
    End Sub

End Class
