Public Class AttachmentForm

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAttachmentFilePathlist() As List(Of String)
        Dim dt = Table()
        Return dt.AsEnumerable.Select(Of String)(Function(r) r(1)).ToList()
    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="pathList"></param>
    Public Sub SetAttachmentFilePathList(pathList As List(Of String))
        Dim dt = Table()

        For Each path In pathList
            Dim r = dt.NewRow
            r(0) = False
            r(1) = path
            dt.Rows.Add(r)
        Next

        dgvAttachmentFilePath.Refresh()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnItemAdd_Click(sender As Object, e As EventArgs) Handles btnItemAdd.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            SetAttachmentFilePathList(New List(Of String)(OpenFileDialog1.FileNames))
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        Dim dt = Table()
        dt.Clear()
        dgvAttachmentFilePath.Refresh()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Private Function Table() As DataTable
        Return DirectCast(BindingSource1.DataSource, DataSet).Tables(0)
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDeleteTarget_Click(sender As Object, e As EventArgs) Handles btnDeleteTarget.Click
        Dim dt = Table()

        Dim deleteRowList As New List(Of DataRow)

        For Each r In dt.Rows()
            If DirectCast(r(0), Boolean) Then
                deleteRowList.Add(r)
            End If
        Next

        For Each r In deleteRowList
            dt.Rows.Remove(r)
        Next

        dgvAttachmentFilePath.Refresh()
    End Sub
End Class