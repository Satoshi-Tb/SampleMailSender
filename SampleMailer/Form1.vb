Imports MailKit
Imports MailKit.Net.Smtp
Imports MimeKit
Public Class Form1

#Region "文面サンプル"
    Private Const SAMPLE_TEXT_BODY =
"★☆★これはテストメールです★☆★

営業時間変更のお知らせ

〇〇様
お世話になっております。

貴社ますますのご清栄のこととお喜び申し上げます。
平素は格別のご高配を賜り感謝申し上げます。

さて、○○では○○○○により営業時間変更を変更させて頂きます。
〇〇様には、大変ご不便をおかけ致しますが、何卒ご了承のほど宜しくお願い申し上げます。

■変更予定日：YYYY年MM月DD日（月）
■変更営業時間：10：00～19：00
 
※YYYY年MM月DD日（月）より通常の営業時間となります。
※ご不明な点等がございましたらお問い合わせ下さい。

----------------------------------------------------
株式会社○○○○○○
テスト　太郎
住所：〒XXX-XXXX　ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ
TEL：**-****-****　／　FAX：**-****-****
URL：http://www.test-unknown.co.jp
Mail：test_taro@test-unknown.co.jp
----------------------------------------------------"

    Private Const SAMPLE_HTML_BODY =
"<!DOCTYPE HTML PUBLIC ""-//W3C//DTD HTML 4.0 Transitional//EN"">
<HTML><HEAD>
<META content=""text/html; charset=Shift_JIS"" http-equiv=Content-Type>
</HEAD>
<BODY>
<DIV>★☆★これはテストメールです★☆★</DIV>
<DIV><STRONG><FONT color=#ff0000>営業時間変更のお知らせ</FONT></STRONG></DIV>
<DIV>&nbsp;</DIV>
<DIV>〇〇様</DIV>
<DIV>お世話になっております。</DIV>
<DIV>&nbsp;</DIV>
<DIV>貴社ますますのご清栄のこととお喜び申し上げます。</DIV>
<DIV>平素は格別のご高配を賜り感謝申し上げます。</DIV>
<DIV>&nbsp;</DIV>
<DIV>さて、○○では○○○○により営業時間変更を変更させて頂きます。</DIV>
<DIV>〇〇様には、大変ご不便をおかけ致しますが、何卒ご了承のほど宜しくお願い申し上げます。</DIV>
<DIV>&nbsp;</DIV>
<DIV><STRONG>■変更予定日：YYYY年MM月DD日（月）</STRONG></DIV>
<DIV><STRONG>■変更営業時間：10：00～19：00</STRONG></DIV>
<DIV>&nbsp;</DIV>
<DIV>※YYYY年MM月DD日（月）より通常の営業時間となります。</DIV>
<DIV>※ご不明な点等がございましたらお問い合わせ下さい。</DIV>
<DIV>&nbsp;</DIV>
<DIV>----------------------------------------------------</DIV>
<DIV>株式会社○○○○○○</DIV>
<DIV>テスト　太郎</DIV>
<DIV>住所：〒XXX-XXXX　ＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮＮ</DIV>
<DIV>TEL：**-****-****　／　FAX：**-****-****</DIV>
<DIV>URL：<A 
href='http://www.test-unknown.co.jp'>こちらをクリック</A></DIV>
<DIV>Mail：<A 
href='mailto:test_taro@test-unknown.co.jp'>test_taro@test-unknown.co.jp</A></DIV>
<DIV>----------------------------------------------------</DIV></BODY></HTML>"

#End Region

    ''' <summary>
    ''' 
    ''' </summary>
    Private AttachmentFileList As List(Of String)


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If txtSubject.Text = "" AndAlso MsgBox("件名を入力してください", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly) Then Return
        If txtBody.Text = "" AndAlso MsgBox("本文を入力してください", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly) Then Return

        If MsgBox("メールを送信します。よろしいですか？", MsgBoxStyle.Information + MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then Return


        Dim message = New MimeMessage()
        message.From.Add(New MailboxAddress("From 太郎", "from-taro@test.ne.jp"))
        message.To.Add(New MailboxAddress("To 花子", "to-hanako@test.co.jp"))
        message.To.Add(New MailboxAddress("", "to-no-name@test.co.jp"))
        message.Subject = txtSubject.Text
        message.Body = CreateMailBody()

        Dim host = "localhost"
        Dim port As Integer = 25
        Dim userName = "test_name"
        Dim password = "test_password"
        Using client = New SmtpClient()
            client.Connect(host, port:=port, options:=Security.SecureSocketOptions.None)
            client.Authenticate(userName, password)
            client.Send(message)
            client.Disconnect(True)
        End Using
        MsgBox("送信完了！", MsgBoxStyle.OkOnly)
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function CreatePlainTextPart(body As String) As TextPart
        Dim enc = System.Text.Encoding.GetEncoding("iso-2022-jp")
        Dim textPart = New TextPart(MimeKit.Text.TextFormat.Plain)
        textPart.SetText(enc, body)
        textPart.ContentTransferEncoding = ContentEncoding.SevenBit
        Return textPart
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="body"></param>
    ''' <returns></returns>
    Private Function CreateHtmlTextPart(body As String) As TextPart
        Dim enc = System.Text.Encoding.GetEncoding("iso-2022-jp")
        Dim textPart = New TextPart(MimeKit.Text.TextFormat.Html)
        textPart.SetText(enc, body)
        textPart.ContentTransferEncoding = ContentEncoding.Base64
        Return textPart
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function CreateAttachment(filePath As String) As MimePart
        Dim enc = System.Text.Encoding.GetEncoding("iso-2022-jp")
        Dim mimeType = MimeTypes.GetMimeType(filePath)
        Dim attachment = New MimePart(mimeType)
        attachment.Content = New MimeContent(System.IO.File.OpenRead(filePath))
        attachment.ContentDisposition = New ContentDisposition()
        attachment.ContentTransferEncoding = ContentEncoding.Base64

        '日本語の添付ファイル名について。エンコーディング形式がRFC2231とRFC2047の２通りある。
        'デフォルトはRFC2231であり、多くのモダンなメーラー（GMailなど）は対応している？
        'ただし、Outlookなどの一部対応していない（古い？）メーラーの場合、正しく表示できない。
        'これを回避するため、RFC2047形式を指定する必要がある。
        attachment.FileName = System.IO.Path.GetFileName(filePath)
        Dim setRfc2047 As Action(Of ParameterList, String) =
            Sub(plist, key)
                Dim param = plist.Where(Function(p) p.Name = key).FirstOrDefault
                If Not param Is Nothing Then param.EncodingMethod = ParameterEncodingMethod.Rfc2047
            End Sub

        setRfc2047(attachment.ContentType.Parameters, "name")
        setRfc2047(attachment.ContentDisposition.Parameters, "filename")

        Return attachment
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function CreateMailBody() As MimeEntity

        ' 本文パート作成
        Dim documentPart As MimeEntity

        If rdbTextFormat.Checked Then
            documentPart = CreatePlainTextPart(txtBody.Text)
        Else
            If chkMultiPart.Checked Then
                'Multipart/Alternative
                Dim alternative = New MultipartAlternative()
                alternative.Add(CreatePlainTextPart("これはHTML代替テキストです"))
                alternative.Add(CreateHtmlTextPart(txtBody.Text))
                documentPart = alternative
            Else
                'マルチパート（代替テキスト）無しのHTML送信
                documentPart = CreateHtmlTextPart(txtBody.Text)
            End If
        End If

        '添付ファイル
        Return AddAttachment(documentPart)

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="body"></param>
    ''' <returns></returns>
    Private Function AddAttachment(body As MimeEntity) As MimeEntity
        '添付ファイルなし
        If AttachmentFileList.Count = 0 Then Return body

        '添付ファイルあり
        Dim multiPart = New Multipart("mixed")
        multiPart.Add(body)
        For Each fPath In AttachmentFileList
            multiPart.Add(CreateAttachment(fPath))
        Next

        Return multiPart
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub rdbTextFormat_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTextFormat.CheckedChanged, rdbHtmlFormat.CheckedChanged
        If rdbTextFormat.Checked Then
            chkMultiPart.Enabled = False
        Else
            chkMultiPart.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        rdbTextFormat.Checked = True
        chkMultiPart.Checked = True
        AttachmentFileList = New List(Of String)
        UpdateAttachLabel()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSampleBody_Click(sender As Object, e As EventArgs) Handles btnSampleBody.Click
        If rdbTextFormat.Checked Then
            txtBody.Text = SAMPLE_TEXT_BODY
        Else
            txtBody.Text = SAMPLE_HTML_BODY
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles btnTo.Click

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAttachment_Click(sender As Object, e As EventArgs) Handles btnAttachment.Click
        Using dlg = New AttachmentForm()
            dlg.SetAttachmentFilePathList(AttachmentFileList)
            If dlg.ShowDialog(Me) = DialogResult.OK Then
                AttachmentFileList = dlg.GetAttachmentFilePathlist
            End If
        End Using

        UpdateAttachLabel()

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub UpdateAttachLabel()
        lblAttach.Text = IIf(AttachmentFileList.Count() = 0, "添付ファイル：無し", "添付ファイル：有り")
    End Sub

End Class
