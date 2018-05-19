Namespace BindingListForServerMode
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.session1 = New DevExpress.Xpo.Session()
            Me.xpServerCollectionSource1 = New DevExpress.Xpo.XPServerCollectionSource()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFrom = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSent = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSize = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHasAttachment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.SubjectTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.serverModeBindingComponent1 = New BindinListForServerMode.ServerModeBindingComponent()
            Me.FromTextEdit = New DevExpress.XtraEditors.TextEdit()
            Me.SentDateEdit = New DevExpress.XtraEditors.DateEdit()
            Me.SizeSpinEdit = New DevExpress.XtraEditors.SpinEdit()
            Me.HasAttachmentCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForSubject = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForFrom = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForHasAttachment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            DirectCast(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xpServerCollectionSource1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            DirectCast(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.FromTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.SentDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.SentDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.SizeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.HasAttachmentCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForSubject, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForFrom, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForSent, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForHasAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ItemForSize, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' session1
            ' 
            Me.session1.IsObjectModifiedOnNonPersistentPropertyChange = Nothing
            Me.session1.TrackPropertiesModifications = False
            ' 
            ' xpServerCollectionSource1
            ' 
            Me.xpServerCollectionSource1.DisplayableProperties = "Subject;From;Sent;Size;HasAttachment"
            Me.xpServerCollectionSource1.ObjectType = GetType(ServerModeGridProjects.ServerSideGridTest)
            Me.xpServerCollectionSource1.Session = Me.session1
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.xpServerCollectionSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(452, 330)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colSubject, Me.colFrom, Me.colSent, Me.colSize, Me.colHasAttachment})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colSubject
            ' 
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 0
            ' 
            ' colFrom
            ' 
            Me.colFrom.FieldName = "From"
            Me.colFrom.Name = "colFrom"
            Me.colFrom.Visible = True
            Me.colFrom.VisibleIndex = 1
            ' 
            ' colSent
            ' 
            Me.colSent.FieldName = "Sent"
            Me.colSent.Name = "colSent"
            Me.colSent.Visible = True
            Me.colSent.VisibleIndex = 2
            ' 
            ' colSize
            ' 
            Me.colSize.FieldName = "Size"
            Me.colSize.Name = "colSize"
            Me.colSize.Visible = True
            Me.colSize.VisibleIndex = 3
            ' 
            ' colHasAttachment
            ' 
            Me.colHasAttachment.FieldName = "HasAttachment"
            Me.colHasAttachment.Name = "colHasAttachment"
            Me.colHasAttachment.Visible = True
            Me.colHasAttachment.VisibleIndex = 4
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.gridControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.dataLayoutControl1)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(961, 330)
            Me.splitContainerControl1.SplitterPosition = 452
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' dataLayoutControl1
            ' 
            Me.dataLayoutControl1.Controls.Add(Me.SubjectTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.FromTextEdit)
            Me.dataLayoutControl1.Controls.Add(Me.SentDateEdit)
            Me.dataLayoutControl1.Controls.Add(Me.SizeSpinEdit)
            Me.dataLayoutControl1.Controls.Add(Me.HasAttachmentCheckEdit)
            Me.dataLayoutControl1.DataSource = Me.serverModeBindingComponent1
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(504, 330)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            ' 
            ' SubjectTextEdit
            ' 
            Me.SubjectTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.serverModeBindingComponent1, "Subject", True))
            Me.SubjectTextEdit.Location = New System.Drawing.Point(58, 12)
            Me.SubjectTextEdit.Name = "SubjectTextEdit"
            Me.SubjectTextEdit.Size = New System.Drawing.Size(434, 22)
            Me.SubjectTextEdit.StyleController = Me.dataLayoutControl1
            Me.SubjectTextEdit.TabIndex = 4
            ' 
            ' serverModeBindingComponent1
            ' 
            Me.serverModeBindingComponent1.Grid = Me.gridControl1
            ' 
            ' FromTextEdit
            ' 
            Me.FromTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.serverModeBindingComponent1, "From", True))
            Me.FromTextEdit.Location = New System.Drawing.Point(58, 38)
            Me.FromTextEdit.Name = "FromTextEdit"
            Me.FromTextEdit.Size = New System.Drawing.Size(434, 22)
            Me.FromTextEdit.StyleController = Me.dataLayoutControl1
            Me.FromTextEdit.TabIndex = 5
            ' 
            ' SentDateEdit
            ' 
            Me.SentDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.serverModeBindingComponent1, "Sent", True))
            Me.SentDateEdit.EditValue = Nothing
            Me.SentDateEdit.Location = New System.Drawing.Point(58, 64)
            Me.SentDateEdit.Name = "SentDateEdit"
            Me.SentDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.SentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.SentDateEdit.Size = New System.Drawing.Size(193, 22)
            Me.SentDateEdit.StyleController = Me.dataLayoutControl1
            Me.SentDateEdit.TabIndex = 6
            ' 
            ' SizeSpinEdit
            ' 
            Me.SizeSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.serverModeBindingComponent1, "Size", True))
            Me.SizeSpinEdit.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
            Me.SizeSpinEdit.Location = New System.Drawing.Point(301, 64)
            Me.SizeSpinEdit.Name = "SizeSpinEdit"
            Me.SizeSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.SizeSpinEdit.Size = New System.Drawing.Size(191, 22)
            Me.SizeSpinEdit.StyleController = Me.dataLayoutControl1
            Me.SizeSpinEdit.TabIndex = 7
            ' 
            ' HasAttachmentCheckEdit
            ' 
            Me.HasAttachmentCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.serverModeBindingComponent1, "HasAttachment", True))
            Me.HasAttachmentCheckEdit.Location = New System.Drawing.Point(12, 90)
            Me.HasAttachmentCheckEdit.Name = "HasAttachmentCheckEdit"
            Me.HasAttachmentCheckEdit.Properties.Caption = "Has Attachment"
            Me.HasAttachmentCheckEdit.Size = New System.Drawing.Size(239, 20)
            Me.HasAttachmentCheckEdit.StyleController = Me.dataLayoutControl1
            Me.HasAttachmentCheckEdit.TabIndex = 8
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(504, 330)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.ItemForSubject, Me.ItemForFrom, Me.ItemForSent, Me.ItemForHasAttachment, Me.ItemForSize, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "autoGeneratedGroup0"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(484, 310)
            ' 
            ' ItemForSubject
            ' 
            Me.ItemForSubject.Control = Me.SubjectTextEdit
            Me.ItemForSubject.CustomizationFormText = "Subject"
            Me.ItemForSubject.Location = New System.Drawing.Point(0, 0)
            Me.ItemForSubject.Name = "ItemForSubject"
            Me.ItemForSubject.Size = New System.Drawing.Size(484, 26)
            Me.ItemForSubject.Text = "Subject"
            Me.ItemForSubject.TextSize = New System.Drawing.Size(43, 16)
            ' 
            ' ItemForFrom
            ' 
            Me.ItemForFrom.Control = Me.FromTextEdit
            Me.ItemForFrom.CustomizationFormText = "From"
            Me.ItemForFrom.Location = New System.Drawing.Point(0, 26)
            Me.ItemForFrom.Name = "ItemForFrom"
            Me.ItemForFrom.Size = New System.Drawing.Size(484, 26)
            Me.ItemForFrom.Text = "From"
            Me.ItemForFrom.TextSize = New System.Drawing.Size(43, 16)
            ' 
            ' ItemForSent
            ' 
            Me.ItemForSent.Control = Me.SentDateEdit
            Me.ItemForSent.CustomizationFormText = "Sent"
            Me.ItemForSent.Location = New System.Drawing.Point(0, 52)
            Me.ItemForSent.Name = "ItemForSent"
            Me.ItemForSent.Size = New System.Drawing.Size(243, 26)
            Me.ItemForSent.Text = "Sent"
            Me.ItemForSent.TextSize = New System.Drawing.Size(43, 16)
            ' 
            ' ItemForHasAttachment
            ' 
            Me.ItemForHasAttachment.Control = Me.HasAttachmentCheckEdit
            Me.ItemForHasAttachment.CustomizationFormText = "Has Attachment"
            Me.ItemForHasAttachment.Location = New System.Drawing.Point(0, 78)
            Me.ItemForHasAttachment.Name = "ItemForHasAttachment"
            Me.ItemForHasAttachment.Size = New System.Drawing.Size(243, 24)
            Me.ItemForHasAttachment.Text = "Has Attachment"
            Me.ItemForHasAttachment.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForHasAttachment.TextVisible = False
            ' 
            ' ItemForSize
            ' 
            Me.ItemForSize.Control = Me.SizeSpinEdit
            Me.ItemForSize.CustomizationFormText = "Size"
            Me.ItemForSize.Location = New System.Drawing.Point(243, 52)
            Me.ItemForSize.Name = "ItemForSize"
            Me.ItemForSize.Size = New System.Drawing.Size(241, 26)
            Me.ItemForSize.Text = "Size"
            Me.ItemForSize.TextSize = New System.Drawing.Size(43, 16)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 102)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(484, 208)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(243, 78)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(241, 24)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(961, 330)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "MainForm"
            Me.Text = "Form1"
            DirectCast(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xpServerCollectionSource1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            DirectCast(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            DirectCast(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.FromTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.SentDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.SentDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.SizeSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.HasAttachmentCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForSubject, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForFrom, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForSent, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForHasAttachment, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ItemForSize, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private session1 As DevExpress.Xpo.Session
        Private xpServerCollectionSource1 As DevExpress.Xpo.XPServerCollectionSource
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colSubject As DevExpress.XtraGrid.Columns.GridColumn
        Private colFrom As DevExpress.XtraGrid.Columns.GridColumn
        Private colSent As DevExpress.XtraGrid.Columns.GridColumn
        Private colSize As DevExpress.XtraGrid.Columns.GridColumn
        Private colHasAttachment As DevExpress.XtraGrid.Columns.GridColumn
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Private serverModeBindingComponent1 As BindinListForServerMode.ServerModeBindingComponent
        Private dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private SubjectTextEdit As DevExpress.XtraEditors.TextEdit
        Private FromTextEdit As DevExpress.XtraEditors.TextEdit
        Private SentDateEdit As DevExpress.XtraEditors.DateEdit
        Private SizeSpinEdit As DevExpress.XtraEditors.SpinEdit
        Private HasAttachmentCheckEdit As DevExpress.XtraEditors.CheckEdit
        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Private ItemForSubject As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForFrom As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForSent As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForHasAttachment As DevExpress.XtraLayout.LayoutControlItem
        Private ItemForSize As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace

