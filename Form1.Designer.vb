<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.P1 = New System.Windows.Forms.PictureBox()
        Me.P2 = New System.Windows.Forms.PictureBox()
        Me.P3 = New System.Windows.Forms.PictureBox()
        Me.P4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TQR = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtW = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TxtH = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TThr = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TTX = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtQB = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tsp2 = New System.Windows.Forms.NumericUpDown()
        Me.TxtZ = New System.Windows.Forms.NumericUpDown()
        Me.Tsp1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.P1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.TThr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.TxtQB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tsp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tsp1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1
        '
        Me.P1.Image = CType(resources.GetObject("P1.Image"), System.Drawing.Image)
        Me.P1.Location = New System.Drawing.Point(9, 156)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(350, 220)
        Me.P1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P1.TabIndex = 0
        Me.P1.TabStop = False
        '
        'P2
        '
        Me.P2.Location = New System.Drawing.Point(727, 12)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(125, 98)
        Me.P2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P2.TabIndex = 1
        Me.P2.TabStop = False
        Me.P2.Visible = False
        '
        'P3
        '
        Me.P3.Location = New System.Drawing.Point(727, 119)
        Me.P3.Name = "P3"
        Me.P3.Size = New System.Drawing.Size(125, 98)
        Me.P3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P3.TabIndex = 2
        Me.P3.TabStop = False
        Me.P3.Visible = False
        '
        'P4
        '
        Me.P4.Location = New System.Drawing.Point(9, 156)
        Me.P4.Name = "P4"
        Me.P4.Size = New System.Drawing.Size(125, 98)
        Me.P4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.P4.TabIndex = 3
        Me.P4.TabStop = False
        Me.P4.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "生成拼图"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TQR
        '
        Me.TQR.Location = New System.Drawing.Point(6, 6)
        Me.TQR.Multiline = True
        Me.TQR.Name = "TQR"
        Me.TQR.Size = New System.Drawing.Size(340, 70)
        Me.TQR.TabIndex = 6
        Me.TQR.Text = "输入文字"
        Me.TQR.WordWrap = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(9, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(473, 138)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtW)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ComboBox1)
        Me.TabPage1.Controls.Add(Me.TxtH)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(465, 112)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "图像拼图"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "↓↓↓ 拖放载入图片"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "抖动阈值"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(265, 6)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(47, 21)
        Me.TextBox2.TabIndex = 20
        Me.TextBox2.Text = "5"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "转换模式"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "宽度×高度"
        '
        'TxtW
        '
        Me.TxtW.Location = New System.Drawing.Point(77, 6)
        Me.TxtW.Name = "TxtW"
        Me.TxtW.Size = New System.Drawing.Size(47, 21)
        Me.TxtW.TabIndex = 13
        Me.TxtW.Text = "350"
        Me.TxtW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtW.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(379, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "生成拼图"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"抖动", "灰度M", "灰度V", "灰度G", "近似A", "近似L"})
        Me.ComboBox1.Location = New System.Drawing.Point(77, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 20)
        Me.ComboBox1.TabIndex = 15
        '
        'TxtH
        '
        Me.TxtH.Location = New System.Drawing.Point(130, 6)
        Me.TxtH.Name = "TxtH"
        Me.TxtH.Size = New System.Drawing.Size(47, 21)
        Me.TxtH.TabIndex = 14
        Me.TxtH.Text = "220"
        Me.TxtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtH.WordWrap = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TThr)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.ComboBox4)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.ComboBox5)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.TTX)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(465, 112)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "文字拼图"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TThr
        '
        Me.TThr.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.TThr.Location = New System.Drawing.Point(293, 81)
        Me.TThr.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.TThr.Name = "TThr"
        Me.TThr.Size = New System.Drawing.Size(53, 21)
        Me.TThr.TabIndex = 36
        Me.TThr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TThr.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(379, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(80, 30)
        Me.Button4.TabIndex = 35
        Me.Button4.Text = "字体"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(379, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 30)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "生成拼图"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "背景色"
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"白", "绿", "红", "橙", "蓝", "黄"})
        Me.ComboBox4.Location = New System.Drawing.Point(166, 81)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox4.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "前景色"
        '
        'ComboBox5
        '
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"白", "绿", "红", "橙", "蓝", "黄"})
        Me.ComboBox5.Location = New System.Drawing.Point(51, 81)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox5.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "灰度阈值"
        '
        'TTX
        '
        Me.TTX.Location = New System.Drawing.Point(6, 6)
        Me.TTX.Multiline = True
        Me.TTX.Name = "TTX"
        Me.TTX.Size = New System.Drawing.Size(340, 70)
        Me.TTX.TabIndex = 27
        Me.TTX.Text = "输入文字"
        Me.TTX.WordWrap = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TxtQB)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.ComboBox3)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.ComboBox2)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.TQR)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(465, 112)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "二维码拼图"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TxtQB
        '
        Me.TxtQB.Location = New System.Drawing.Point(293, 80)
        Me.TxtQB.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.TxtQB.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtQB.Name = "TxtQB"
        Me.TxtQB.Size = New System.Drawing.Size(51, 21)
        Me.TxtQB.TabIndex = 27
        Me.TxtQB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtQB.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 12)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "背景色"
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"白", "绿", "红", "橙", "蓝", "黄"})
        Me.ComboBox3.Location = New System.Drawing.Point(166, 81)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox3.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "前景色"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"白", "绿", "红", "橙", "蓝", "黄"})
        Me.ComboBox2.Location = New System.Drawing.Point(51, 81)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox2.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "边框宽度"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "缩放倍数"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(114, 98)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(80, 30)
        Me.ButtonSave.TabIndex = 20
        Me.ButtonSave.Text = "导出拼图"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 91)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "边框"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 69)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(60, 16)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "分隔线"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(8, 47)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox3.TabIndex = 25
        Me.CheckBox3.Text = "拼图拆分"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tsp2)
        Me.GroupBox1.Controls.Add(Me.TxtZ)
        Me.GroupBox1.Controls.Add(Me.Tsp1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.ButtonSave)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 138)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "保存"
        '
        'Tsp2
        '
        Me.Tsp2.Location = New System.Drawing.Point(143, 46)
        Me.Tsp2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Tsp2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tsp2.Name = "Tsp2"
        Me.Tsp2.Size = New System.Drawing.Size(51, 21)
        Me.Tsp2.TabIndex = 30
        Me.Tsp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tsp2.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'TxtZ
        '
        Me.TxtZ.Location = New System.Drawing.Point(65, 19)
        Me.TxtZ.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.TxtZ.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtZ.Name = "TxtZ"
        Me.TxtZ.Size = New System.Drawing.Size(51, 21)
        Me.TxtZ.TabIndex = 28
        Me.TxtZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtZ.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Tsp1
        '
        Me.Tsp1.Location = New System.Drawing.Point(86, 45)
        Me.Tsp1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.Tsp1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tsp1.Name = "Tsp1"
        Me.Tsp1.Size = New System.Drawing.Size(51, 21)
        Me.Tsp1.TabIndex = 29
        Me.Tsp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Tsp1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.P4)
        Me.Controls.Add(Me.P3)
        Me.Controls.Add(Me.P2)
        Me.Controls.Add(Me.P1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "魔方拼图 v4.0"
        CType(Me.P1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.TThr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.TxtQB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tsp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tsp1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents P1 As PictureBox
    Friend WithEvents P2 As PictureBox
    Friend WithEvents P3 As PictureBox
    Friend WithEvents P4 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TQR As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtW As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TxtH As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TTX As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TThr As NumericUpDown
    Friend WithEvents ButtonSave As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtQB As NumericUpDown
    Friend WithEvents TxtZ As NumericUpDown
    Friend WithEvents Tsp2 As NumericUpDown
    Friend WithEvents Tsp1 As NumericUpDown
End Class
