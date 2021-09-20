<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.chkMultiPart = New System.Windows.Forms.CheckBox()
        Me.rdbTextFormat = New System.Windows.Forms.RadioButton()
        Me.rdbHtmlFormat = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSampleBody = New System.Windows.Forms.Button()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTo = New System.Windows.Forms.Button()
        Me.btnCc = New System.Windows.Forms.Button()
        Me.btnBcc = New System.Windows.Forms.Button()
        Me.btnAttachment = New System.Windows.Forms.Button()
        Me.lblAttach = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(12, 66)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBody.Size = New System.Drawing.Size(495, 219)
        Me.txtBody.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(432, 313)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 313)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 23)
        Me.btnSend.TabIndex = 2
        Me.btnSend.Text = "送信！"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'chkMultiPart
        '
        Me.chkMultiPart.AutoSize = True
        Me.chkMultiPart.Location = New System.Drawing.Point(171, 290)
        Me.chkMultiPart.Name = "chkMultiPart"
        Me.chkMultiPart.Size = New System.Drawing.Size(104, 16)
        Me.chkMultiPart.TabIndex = 3
        Me.chkMultiPart.Text = "マルチパート形式"
        Me.chkMultiPart.UseVisualStyleBackColor = True
        '
        'rdbTextFormat
        '
        Me.rdbTextFormat.AutoSize = True
        Me.rdbTextFormat.Location = New System.Drawing.Point(47, 291)
        Me.rdbTextFormat.Name = "rdbTextFormat"
        Me.rdbTextFormat.Size = New System.Drawing.Size(59, 16)
        Me.rdbTextFormat.TabIndex = 4
        Me.rdbTextFormat.TabStop = True
        Me.rdbTextFormat.Text = "テキスト"
        Me.rdbTextFormat.UseVisualStyleBackColor = True
        '
        'rdbHtmlFormat
        '
        Me.rdbHtmlFormat.AutoSize = True
        Me.rdbHtmlFormat.Location = New System.Drawing.Point(112, 289)
        Me.rdbHtmlFormat.Name = "rdbHtmlFormat"
        Me.rdbHtmlFormat.Size = New System.Drawing.Size(53, 16)
        Me.rdbHtmlFormat.TabIndex = 5
        Me.rdbHtmlFormat.TabStop = True
        Me.rdbHtmlFormat.Text = "HTML"
        Me.rdbHtmlFormat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "形式"
        '
        'btnSampleBody
        '
        Me.btnSampleBody.Location = New System.Drawing.Point(297, 288)
        Me.btnSampleBody.Name = "btnSampleBody"
        Me.btnSampleBody.Size = New System.Drawing.Size(113, 23)
        Me.btnSampleBody.TabIndex = 7
        Me.btnSampleBody.Text = "サンプル文面表示"
        Me.btnSampleBody.UseVisualStyleBackColor = True
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(47, 12)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(460, 19)
        Me.txtSubject.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "件名"
        '
        'btnTo
        '
        Me.btnTo.Location = New System.Drawing.Point(12, 37)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(51, 23)
        Me.btnTo.TabIndex = 11
        Me.btnTo.Text = "宛先"
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'btnCc
        '
        Me.btnCc.Location = New System.Drawing.Point(69, 37)
        Me.btnCc.Name = "btnCc"
        Me.btnCc.Size = New System.Drawing.Size(51, 23)
        Me.btnCc.TabIndex = 12
        Me.btnCc.Text = "CC"
        Me.btnCc.UseVisualStyleBackColor = True
        '
        'btnBcc
        '
        Me.btnBcc.Location = New System.Drawing.Point(126, 37)
        Me.btnBcc.Name = "btnBcc"
        Me.btnBcc.Size = New System.Drawing.Size(51, 23)
        Me.btnBcc.TabIndex = 13
        Me.btnBcc.Text = "BCC"
        Me.btnBcc.UseVisualStyleBackColor = True
        '
        'btnAttachment
        '
        Me.btnAttachment.Location = New System.Drawing.Point(224, 37)
        Me.btnAttachment.Name = "btnAttachment"
        Me.btnAttachment.Size = New System.Drawing.Size(51, 23)
        Me.btnAttachment.TabIndex = 14
        Me.btnAttachment.Text = "添付"
        Me.btnAttachment.UseVisualStyleBackColor = True
        '
        'lblAttach
        '
        Me.lblAttach.AutoSize = True
        Me.lblAttach.Location = New System.Drawing.Point(281, 42)
        Me.lblAttach.Name = "lblAttach"
        Me.lblAttach.Size = New System.Drawing.Size(87, 12)
        Me.lblAttach.TabIndex = 15
        Me.lblAttach.Text = "添付ファイル：あり"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 360)
        Me.Controls.Add(Me.lblAttach)
        Me.Controls.Add(Me.btnAttachment)
        Me.Controls.Add(Me.btnBcc)
        Me.Controls.Add(Me.btnCc)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.btnSampleBody)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdbHtmlFormat)
        Me.Controls.Add(Me.rdbTextFormat)
        Me.Controls.Add(Me.chkMultiPart)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.txtBody)
        Me.Name = "Form1"
        Me.Text = "SampleMailer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBody As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents chkMultiPart As CheckBox
    Friend WithEvents rdbTextFormat As RadioButton
    Friend WithEvents rdbHtmlFormat As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSampleBody As Button
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTo As Button
    Friend WithEvents btnCc As Button
    Friend WithEvents btnBcc As Button
    Friend WithEvents btnAttachment As Button
    Friend WithEvents lblAttach As Label
End Class
