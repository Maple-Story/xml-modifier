<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CAttr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TFolder = New System.Windows.Forms.TextBox()
        Me.BFolder = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBe = New System.Windows.Forms.TextBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CI = New System.Windows.Forms.ComboBox()
        Me.BBind = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CAttr
        '
        Me.CAttr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CAttr.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CAttr.FormattingEnabled = True
        Me.CAttr.Items.AddRange(New Object() {"血量", "魔力", "物理傷害", "物理防禦", "魔法傷害", "魔法防禦", "命中值", "迴避值", "經驗值"})
        Me.CAttr.Location = New System.Drawing.Point(199, 62)
        Me.CAttr.Name = "CAttr"
        Me.CAttr.Size = New System.Drawing.Size(212, 38)
        Me.CAttr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "逾修改的屬性："
        '
        'TFolder
        '
        Me.TFolder.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TFolder.Location = New System.Drawing.Point(12, 12)
        Me.TFolder.Name = "TFolder"
        Me.TFolder.ReadOnly = True
        Me.TFolder.Size = New System.Drawing.Size(399, 39)
        Me.TFolder.TabIndex = 2
        '
        'BFolder
        '
        Me.BFolder.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BFolder.Location = New System.Drawing.Point(417, 12)
        Me.BFolder.Name = "BFolder"
        Me.BFolder.Size = New System.Drawing.Size(149, 42)
        Me.BFolder.TabIndex = 3
        Me.BFolder.Text = "選取資料夾"
        Me.BFolder.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "逾修改的倍數："
        '
        'TBe
        '
        Me.TBe.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TBe.Location = New System.Drawing.Point(199, 109)
        Me.TBe.Name = "TBe"
        Me.TBe.Size = New System.Drawing.Size(212, 39)
        Me.TBe.TabIndex = 6
        '
        'Reset
        '
        Me.Reset.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Reset.Location = New System.Drawing.Point(417, 62)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(149, 42)
        Me.Reset.TabIndex = 7
        Me.Reset.Text = "重設"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Modify.Location = New System.Drawing.Point(417, 158)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(149, 42)
        Me.Modify.TabIndex = 8
        Me.Modify.Text = "修改"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 206)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(554, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "遇到　非整數："
        '
        'CI
        '
        Me.CI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CI.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CI.FormattingEnabled = True
        Me.CI.Items.AddRange(New Object() {"無條件捨去", "四捨五入", "無條件進位"})
        Me.CI.Location = New System.Drawing.Point(199, 158)
        Me.CI.Name = "CI"
        Me.CI.Size = New System.Drawing.Size(212, 38)
        Me.CI.TabIndex = 12
        '
        'BBind
        '
        Me.BBind.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.BBind.Location = New System.Drawing.Point(417, 110)
        Me.BBind.Name = "BBind"
        Me.BBind.Size = New System.Drawing.Size(149, 42)
        Me.BBind.TabIndex = 13
        Me.BBind.Text = "綁定"
        Me.BBind.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 237)
        Me.Controls.Add(Me.BBind)
        Me.Controls.Add(Me.CI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.TBe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BFolder)
        Me.Controls.Add(Me.TFolder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CAttr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MapleXmlModifier By雪楓月舞"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CAttr As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TFolder As TextBox
    Friend WithEvents BFolder As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TBe As TextBox
    Friend WithEvents Reset As Button
    Friend WithEvents Modify As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents CI As ComboBox
    Friend WithEvents BBind As Button
End Class
