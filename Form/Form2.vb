Imports DateTimeExtensions
Imports System
Public Class Form2
    Const Gap As Integer = 2
    Const MaxD As Integer = 18
    Const MaxMC As Integer = 20
    Const MaxMat As Integer = MaxD * MaxMC
    Const xWidth As Integer = 70
    Const xHieght As Integer = 20
    Const yWidth As Integer = 30
    Const yHieght As Integer = 30
    Private LabelD(MaxD) As Label
    Private LabelD1(MaxD) As Label
    Private LabelMC(MaxMC) As Label
    Private LabelPlan(MaxMat) As Label
    Private xbox As Integer
    Private xboxcheck As Integer
    Private xText As String
    Private xTextArray As New ArrayList
    Private S As String
    Const maxtextboxpanel1 As Integer = 999
    Private lbFGOutPlan(maxtextboxpanel1) As Label
    Private listctrlFGOutPlan As New Dictionary(Of Control, Integer)
    Private listctrlMCDict As New Dictionary(Of Control, Integer)
    Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Application.ChangeCulture("en-US")
        listctrlFGOutPlan.Clear()
        pnFG.Controls.Clear()
        Me.BackColor = Color.GreenYellow
        pnFG.AutoScroll = True

        For i = 1 To 10
            lbFGOutPlan(i) = New Label
            With lbFGOutPlan(i)
                .Font = New Font("Tahoma", 12)
                .Text = "FG " & i.ToString
                .Tag = i
                .Name = i
            End With
            listctrlFGOutPlan.Add(lbFGOutPlan(i), i)
            pnFG.Controls.Add(lbFGOutPlan(i))
            AddHandler lbFGOutPlan(i).MouseDown, AddressOf lbFGOutPlan_MouseDown
            AddHandler lbFGOutPlan(i).MouseHover, AddressOf lbFGOutPlan_MouseHover
            AddHandler lbFGOutPlan(i).MouseLeave, AddressOf lbFGOutPlan_MouseLeave
        Next

        With dTpicker1
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "dd.MMM.yyyy"
            .Value = Now.Next(DayOfWeek.Tuesday).AddDays(-7)
        End With

        AddHandler cmdShow.Click, AddressOf cmdShow_Click
        AddHandler dTpicker1.ValueChanged, AddressOf dTPicker1_ValueChanged
        dTPicker1_ValueChanged(sender:=dTpicker1, e:=Nothing)

        For i As Integer = 1 To MaxMC
            LabelMC(i) = New Label
            With LabelMC(i)
                .Width = yWidth
                .Height = yHieght
                .Left = 10
                .Top = 20 + ((.Height + Gap) * i)
                .BorderStyle = BorderStyle.Fixed3D
                .TextAlign = ContentAlignment.MiddleCenter
                .Text = i.ToString
                .Name = i
            End With
            For n As Integer = 1 + ((i - 1) * MaxD) To i * MaxD
                LabelPlan(n) = New Label
                With LabelPlan(n)
                    .Width = xWidth
                    .Height = yHieght
                    .Left = -30 + ((.Width + Gap) * (n - ((i - 1) * MaxD)))
                    .Top = LabelMC(i).Top
                    .BorderStyle = BorderStyle.Fixed3D
                    .TextAlign = ContentAlignment.MiddleCenter
                    .BackColor = Color.Aquamarine
                    .ForeColor = Color.IndianRed
                    .AllowDrop = True
                    .Name = n
                    .Tag = n.ToString + "/0"
                    .Text = n
                End With
                Panel1.Controls.Add(LabelPlan(n))
                AddHandler LabelPlan(n).DragEnter, AddressOf LabelPlan_DragEnter
                AddHandler LabelPlan(n).DragLeave, AddressOf LabelPlan_DragLeave
                AddHandler LabelPlan(n).DragDrop, AddressOf LabelPlan_DragDrop
                AddHandler LabelPlan(n).MouseDown, AddressOf LabelPlan_MouseDown
                listctrlMCDict.Add(LabelPlan(n), i)
            Next
            Panel1.Controls.Add(LabelMC(i))
            listctrlMCDict.Add(LabelMC(i), i)
        Next
    End Sub
    Private Sub dTPicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 1 To MaxD
            Try
                Panel1.Controls.Remove(LabelD(i))
                Panel1.Controls.Remove(LabelD1(i))
            Catch ex As Exception

            End Try
            LabelD(i) = New Label
            With LabelD(i)
                .Width = xWidth
                .Height = xHieght
                .Left = -30 + ((.Width + Gap) * i)
                .Top = 10
                .BorderStyle = BorderStyle.Fixed3D
                .TextAlign = ContentAlignment.MiddleCenter
                Panel1.Controls.Add(LabelD(i))
                .Text = DateAdd(DateInterval.Day, i - 1, dTpicker1.Value).ToString
            End With
            LabelD1(i) = New Label
            With LabelD1(i)
                .Width = xWidth
                .Height = xHieght
                .Left = -30 + ((.Width + Gap) * i)
                .Top = 30
                .BorderStyle = BorderStyle.Fixed3D
                .TextAlign = ContentAlignment.MiddleCenter
                Panel1.Controls.Add(LabelD1(i))
                .Text = Format(CDate(LabelD(i).Text), "ddd")
            End With
        Next
    End Sub
    Private Sub lbFGOutPlan_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub lbFGOutPlan_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub lbFGOutPlan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        S = "New"
        Dim LM As Label = sender

        For Each ctrl In listctrlFGOutPlan
            If ctrl.Key.Name = LM.Name Then ctrl.Key.BackColor = Color.Red Else ctrl.Key.BackColor = Color.GreenYellow
        Next

        For Each ctrl In listctrlMCDict
            ctrl.Key.Visible = False
        Next

        Dim rowID As New ArrayList
        For Each ctrl In listctrlMCDict
            If ctrl.Value Mod 3 = LM.Name Mod 3 Then
                ctrl.Key.Visible = True
                rowID.Add(ctrl.Value.ToString)
            End If
        Next

        Dim DistinctrowID() As String = CType(rowID.ToArray(GetType(String)), String())
        Dim newrowid() As String = DistinctrowID.Distinct.ToArray

        For r As Integer = 0 To newrowid.GetUpperBound(0)
            For Each ctrl In listctrlMCDict
                If ctrl.Value = newrowid(r) Then
                    ctrl.Key.Top = 20 + ((yHieght + Gap) * (r + 1))
                End If
            Next
        Next

        LM.DoDragDrop(LM.Text & "/" & LM.Tag, DragDropEffects.Copy)
        xTextArray.Clear()
    End Sub
    Private Sub LabelPlan_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        S = "Change"
        Dim LM As Label = sender
        Dim LMtext() As String = LM.Tag.ToString.Split("/")
        If LMtext(1) > 0 Then LM.DoDragDrop(LM.Text & "/" & LM.Tag, DragDropEffects.Copy)
        xTextArray.Clear()
    End Sub
    Private Sub LabelPlan_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim LM As Label = sender
        xText = e.Data.GetData(DataFormats.Text) ' ค่าที่ติดมาจาก MouseDown
        Dim xTextsplit() As String = xText.Split("/")
        For i As Integer = 0 To xTextsplit.Length - 1
            xTextArray.Add(xTextsplit(i))
        Next
        Dim xTextS() As Object = xTextArray.ToArray

        Select Case S
            Case "New"
                xbox = CalEndData(LM.Name, xTextS(1))
            Case "Change"
                xbox = CalEndData(LM.Name, xTextS(2))
        End Select

        xboxcheck = 0
        For i As Integer = LM.Name To xbox
            Dim NextPlan As Label = LabelPlan(i)
            Dim NextPlantext() As String = NextPlan.Tag.ToString.Split("/")
            If NextPlantext(1) > 0 Then xboxcheck += 1
        Next

        Select Case xboxcheck
            Case 0
                e.Effect = DragDropEffects.Copy
                For i As Integer = LM.Name To xbox
                    With LabelPlan(i)
                        Select Case i
                            Case Is = LM.Name
                                .BackColor = Color.Beige
                            Case Is = xbox
                                .BackColor = Color.Beige
                                .Image = My.Resources._end
                            Case Else
                                .BackColor = Color.Beige
                                .Image = My.Resources.equal
                        End Select
                    End With
                Next
            Case Else
                e.Effect = DragDropEffects.None
        End Select
    End Sub
    Private Sub LabelPlan_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim LM As Label = sender
        Dim xTextS() As Object = xTextArray.ToArray

        Select Case xboxcheck
            Case 0
                For i As Integer = LM.Name To xbox
                    With LabelPlan(i)
                        .BackColor = Color.Aquamarine
                        .Image = Nothing
                    End With
                Next
            Case Else
                For i As Integer = xTextS(1) To CalEndData(xTextS(1), xTextS(2))
                    With LabelPlan(i)
                        .BackColor = Color.Aquamarine
                        .Image = Nothing
                        .Text = i.ToString
                        .Tag = i.ToString + "/0"
                    End With
                Next
        End Select
    End Sub
    Private Sub LabelPlan_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim LM As Label = sender
        Dim xTextS() As Object = xTextArray.ToArray

        Select Case S
            Case "Change"
                For i As Integer = xTextS(1) To CalEndData(xTextS(1), xTextS(2))
                    With LabelPlan(i)
                        .BackColor = Color.Aquamarine
                        .Image = Nothing
                        .Text = i.ToString
                        .Tag = i.ToString + "/0"
                    End With
                Next
        End Select

        For i As Integer = LM.Name To xbox
            With LabelPlan(i)
                If i = LM.Name Then
                    .Text = xTextS(0)
                ElseIf i = xbox Then
                    .Text = Nothing
                Else
                    .Text = Nothing
                    .Image = My.Resources.equal
                End If
                Select Case S
                    Case "New"
                        .Tag = LM.Name + "/" + xTextS(1)
                    Case "Change"
                        .Tag = LM.Name + "/" + xTextS(2)
                End Select
                .BackColor = Color.Beige
            End With
        Next
    End Sub
    Private Function CalEndData(ByVal A As Integer, ByVal B As Integer) As Integer
        Dim X, Y As Integer
        X = Math.Ceiling(A / MaxD) * MaxD
        Y = A + B
        If Y >= X Then Y = X
        Return Y
    End Function
    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each ctrl In listctrlMCDict
            ctrl.Key.Top = 20 + ((yHieght + Gap) * ctrl.Value)
            ctrl.Key.Visible = True
        Next
    End Sub
End Class