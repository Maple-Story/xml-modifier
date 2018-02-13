Imports System.Xml
Imports System.IO
Public Class Form1
    Public XPath As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        重設()
        ProgressBar1.Value = 100
    End Sub
    Private Sub BF_Click(sender As Object, e As EventArgs) Handles BFolder.Click
        選取資料夾()
    End Sub
    Private Sub TFolder_Click(sender As Object, e As EventArgs) Handles TFolder.Click
        選取資料夾()
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        重設()
    End Sub
    Private Sub BB_Click(sender As Object, e As EventArgs) Handles BBind.Click
        If BBind.Text = "綁定" Then
            TFolder.Enabled = False
            CAttr.Enabled = False
            TBe.Enabled = False
            CI.Enabled = False
            BFolder.Enabled = False
            Reset.Enabled = False
            BBind.Text = "解綁"
        Else
            TFolder.Enabled = True
            CAttr.Enabled = True
            TBe.Enabled = True
            CI.Enabled = True
            BFolder.Enabled = True
            Reset.Enabled = True
            BBind.Text = "綁定"
        End If
    End Sub
    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        '檢查
        ProgressBar1.Value = 0
        If BBind.Text = "綁定" Then
            MessageBox.Show("尚未綁定", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProgressBar1.Value = 100
            Exit Sub
        End If
        If TFolder.Text = "" Then
            MessageBox.Show("尚未選取資料夾", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProgressBar1.Value = 100
            Exit Sub
        End If
        Dim DirInfo As DirectoryInfo
        If Directory.Exists(XPath) Then
            DirInfo = New DirectoryInfo(XPath)
            If DirInfo.GetFiles("*.XML").Count > 0 Then
                If MessageBox.Show("資料夾內一共有" & DirInfo.GetFiles("*.XML").Count & "個xml檔案" & vbNewLine & "請問是否要進行修改?", Modify.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    For Each filex In DirInfo.GetFiles("*.XML")
                        Call 修改(filex.Name)
                        ProgressBar1.Value += Int(100 / DirInfo.GetFiles("*.XML").Count)
                    Next filex
                    ProgressBar1.Value = 100
                    MessageBox.Show("檔案修改已完畢", "修改完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
            Else
                MessageBox.Show("資料夾內沒有xml檔案", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ProgressBar1.Value = 100
                Exit Sub
            End If
        Else
            MessageBox.Show("無此資料夾", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ProgressBar1.Value = 100
            Exit Sub
        End If

    End Sub
    Sub 選取資料夾()
        FolderBrowserDialog1.ShowDialog()
        TFolder.Text = FolderBrowserDialog1.SelectedPath
        XPath = TFolder.Text
    End Sub
    Sub 重設()
        ProgressBar1.Value = 0
        TFolder.Text = ""
        CAttr.Text = CAttr.Items(0)
        CI.Text = CI.Items(0)
        TBe.Text = "1"
        XPath = ""
        TFolder.Enabled = True
        CAttr.Enabled = True
        TBe.Enabled = True
        CI.Enabled = True
        BBind.Text = "綁定"

        ProgressBar1.Value = 100
    End Sub

    Sub 修改(FileName As String)
        Try
            Dim xDoc As XmlDocument = New XmlDocument
            xDoc.Load(XPath & "\" & FileName) '讀取單一檔案
            Dim xRoot As XmlNode
            Dim xNode As XmlNode
            Dim xIntNodeList As XmlNodeList
            Dim xIntNode As XmlNode
            Dim xElem As XmlElement
            xRoot = CType(xDoc.DocumentElement, XmlNode)
            '選擇imgdir
            xNode = xRoot.SelectSingleNode("imgdir[@name='info']")
            '節點篩選條件
            xIntNodeList = xNode.SelectNodes("int[@name='" & 屬性判定(CAttr.Text) & "']")
            For i = 0 To xIntNodeList.Count - 1
                xIntNode = xIntNodeList.Item(i)
                xElem = CType(xIntNode, XmlElement)
                'TBe.text 沒有經過檢查 有待觀察
                Select Case CI.Text
                    Case "無條件捨去"
                        xElem.SetAttribute("value", Math.Floor(xElem.GetAttribute("value") * Val(TBe.Text)))
                    Case "四捨五入"
                        xElem.SetAttribute("value", Math.Round(xElem.GetAttribute("value") * Val(TBe.Text)))
                    Case "無條件進位"
                        xElem.SetAttribute("value", Math.Ceiling(xElem.GetAttribute("value") * Val(TBe.Text)))
                End Select
                'Console.WriteLine(xElem.GetAttribute("name") & "：" & xElem.GetAttribute("value"))
            Next
            xDoc.Save(XPath & "\" & FileName)
        Catch ex As Exception
            'Console.WriteLine(testfile & "此檔案沒有節點" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)
            'MsgBox(testfile & "此檔案沒有節點" & vbNewLine & ex.Message & vbNewLine & ex.StackTrace)
        End Try
    End Sub

    Function 屬性判定(Attr As String)
        Select Case Attr
            Case "血量"
                Attr = "maxHP"
            Case "魔力"
                Attr = "maxMP"
            Case "物理傷害"
                Attr = "PADamage"
            Case "物理防禦"
                Attr = "PDDamage"
            Case "魔法傷害"
                Attr = "MADamage"
            Case "魔法防禦"
                Attr = "MDDamage"
            Case "命中值"
                Attr = "acc"
            Case "迴避值"
                Attr = "eva"
            Case "經驗值"
                Attr = "exp"
            Case Else '此狀況不可能發生 發生一定錯誤
                Attr = ""
        End Select
        Return Attr
    End Function


End Class
