<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttachmentForm
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
        Me.components = New System.ComponentModel.Container()
        Dim dsData As System.Data.DataSet
        Me.dgvAttachmentFilePath = New System.Windows.Forms.DataGridView()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.btnItemAdd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.対象DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ファイルパスDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteTarget = New System.Windows.Forms.Button()
        Me.btnAll = New System.Windows.Forms.Button()
        dsData = New System.Data.DataSet()
        CType(Me.dgvAttachmentFilePath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(dsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAttachmentFilePath
        '
        Me.dgvAttachmentFilePath.AllowUserToAddRows = False
        Me.dgvAttachmentFilePath.AllowUserToDeleteRows = False
        Me.dgvAttachmentFilePath.AllowUserToResizeColumns = False
        Me.dgvAttachmentFilePath.AllowUserToResizeRows = False
        Me.dgvAttachmentFilePath.AutoGenerateColumns = False
        Me.dgvAttachmentFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAttachmentFilePath.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.対象DataGridViewCheckBoxColumn, Me.ファイルパスDataGridViewTextBoxColumn})
        Me.dgvAttachmentFilePath.DataSource = Me.BindingSource1
        Me.dgvAttachmentFilePath.Location = New System.Drawing.Point(12, 12)
        Me.dgvAttachmentFilePath.MultiSelect = False
        Me.dgvAttachmentFilePath.Name = "dgvAttachmentFilePath"
        Me.dgvAttachmentFilePath.RowHeadersVisible = False
        Me.dgvAttachmentFilePath.RowTemplate.Height = 21
        Me.dgvAttachmentFilePath.Size = New System.Drawing.Size(396, 116)
        Me.dgvAttachmentFilePath.TabIndex = 0
        '
        'dsData
        '
        dsData.DataSetName = "NewDataSet"
        dsData.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "対象"
        Me.DataColumn1.DataType = GetType(Boolean)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "ファイルパス"
        '
        'btnItemAdd
        '
        Me.btnItemAdd.Location = New System.Drawing.Point(12, 134)
        Me.btnItemAdd.Name = "btnItemAdd"
        Me.btnItemAdd.Size = New System.Drawing.Size(51, 23)
        Me.btnItemAdd.TabIndex = 2
        Me.btnItemAdd.Text = "追加"
        Me.btnItemAdd.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(93, 176)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(76, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 176)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 5
        Me.btnOk.Text = "決定"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Table1"
        Me.BindingSource1.DataSource = dsData
        '
        '対象DataGridViewCheckBoxColumn
        '
        Me.対象DataGridViewCheckBoxColumn.DataPropertyName = "対象"
        Me.対象DataGridViewCheckBoxColumn.HeaderText = "対象"
        Me.対象DataGridViewCheckBoxColumn.Name = "対象DataGridViewCheckBoxColumn"
        Me.対象DataGridViewCheckBoxColumn.Width = 40
        '
        'ファイルパスDataGridViewTextBoxColumn
        '
        Me.ファイルパスDataGridViewTextBoxColumn.DataPropertyName = "ファイルパス"
        Me.ファイルパスDataGridViewTextBoxColumn.HeaderText = "ファイルパス"
        Me.ファイルパスDataGridViewTextBoxColumn.Name = "ファイルパスDataGridViewTextBoxColumn"
        Me.ファイルパスDataGridViewTextBoxColumn.ReadOnly = True
        Me.ファイルパスDataGridViewTextBoxColumn.Width = 350
        '
        'btnDeleteTarget
        '
        Me.btnDeleteTarget.Location = New System.Drawing.Point(69, 134)
        Me.btnDeleteTarget.Name = "btnDeleteTarget"
        Me.btnDeleteTarget.Size = New System.Drawing.Size(83, 23)
        Me.btnDeleteTarget.TabIndex = 6
        Me.btnDeleteTarget.Text = "対象を削除"
        Me.btnDeleteTarget.UseVisualStyleBackColor = True
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(158, 134)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAll.TabIndex = 7
        Me.btnAll.Text = "全て削除"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'AttachmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 211)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.btnDeleteTarget)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnItemAdd)
        Me.Controls.Add(Me.dgvAttachmentFilePath)
        Me.Name = "AttachmentForm"
        Me.Text = "添付ファイルの選択"
        CType(Me.dgvAttachmentFilePath, System.ComponentModel.ISupportInitialize).EndInit()
        CType(dsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAttachmentFilePath As DataGridView
    Friend WithEvents btnItemAdd As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents DataTable1 As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents DataColumn2 As DataColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents 対象DataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ファイルパスDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDeleteTarget As Button
    Friend WithEvents btnAll As Button
End Class
