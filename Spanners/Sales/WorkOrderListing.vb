Public Class WorkOrderListForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents WOGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents RevisedBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents DelBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents EditBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(WorkOrderListForm))
        Me.WOGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.RevisedBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.DelBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.EditBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WOGrid
        '
        Me.WOGrid.EditorsRepository = Me.PersistentRepository1
        Me.WOGrid.Location = New System.Drawing.Point(8, 8)
        Me.WOGrid.MainView = Me.GridView1
        Me.WOGrid.Name = "WOGrid"
        Me.WOGrid.Size = New System.Drawing.Size(776, 368)
        Me.WOGrid.TabIndex = 2
        '
        'PersistentRepository1
        '
        Me.PersistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.Properties.AllowFocused = False
        Me.RepositoryItemTextEdit1.Properties.AutoHeight = False
        Me.RepositoryItemTextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        '
        'GridView1
        '
        Me.GridView1.DefaultEdit = Me.RepositoryItemTextEdit1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.VertScrollTipFieldName = Nothing
        '
        'RevisedBtn
        '
        Me.RevisedBtn.AutoSize = False
        Me.RevisedBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.RevisedBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RevisedBtn.Image = Nothing
        Me.RevisedBtn.Location = New System.Drawing.Point(304, 384)
        Me.RevisedBtn.Name = "RevisedBtn"
        Me.RevisedBtn.Size = New System.Drawing.Size(168, 32)
        Me.RevisedBtn.TabIndex = 14
        Me.RevisedBtn.Text = " Create Revised Work Order"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 392)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(64, 24)
        Me.RefreshBtn.TabIndex = 13
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'DelBtn
        '
        Me.DelBtn.AutoSize = False
        Me.DelBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.DelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelBtn.Image = Nothing
        Me.DelBtn.Location = New System.Drawing.Point(560, 384)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(72, 32)
        Me.DelBtn.TabIndex = 12
        Me.DelBtn.Text = "&Delete"
        '
        'EditBtn
        '
        Me.EditBtn.AutoSize = False
        Me.EditBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.EditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBtn.Image = Nothing
        Me.EditBtn.Location = New System.Drawing.Point(480, 384)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(72, 32)
        Me.EditBtn.TabIndex = 11
        Me.EditBtn.Text = "&Edit"
        '
        'Timer1
        '
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(640, 384)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 32)
        Me.CloseBtn.TabIndex = 15
        Me.CloseBtn.Text = "Close"
        '
        'PrintBtn
        '
        Me.PrintBtn.AutoSize = False
        Me.PrintBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBtn.Image = Nothing
        Me.PrintBtn.Location = New System.Drawing.Point(192, 384)
        Me.PrintBtn.Name = "PrintBtn"
        Me.PrintBtn.Size = New System.Drawing.Size(104, 32)
        Me.PrintBtn.TabIndex = 16
        Me.PrintBtn.Text = "Print (Production)"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(8, 384)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        '
        'XtraButton1
        '
        Me.XtraButton1.AutoSize = False
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(88, 384)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(96, 32)
        Me.XtraButton1.TabIndex = 18
        Me.XtraButton1.Text = "Print (Sales)"
        '
        'WorkOrderListForm
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.XtraButton1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.PrintBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.RevisedBtn)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.WOGrid)
        Me.Location = New System.Drawing.Point(8, 8)
        Me.Name = "WorkOrderListForm"
        Me.Text = "Work Order Listing"
        CType(Me.WOGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public UserID As String = Common.CommonConn.Config.USERID
    Public data As System.Data.DataTable

#Region " Form Load "
    Private Sub WorkOrderListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadWorkOrderList()
        'Timer1.Interval = 60000
        'Timer1.Start()
        WOGrid_Click(sender, e)
    End Sub

    Private Sub LoadWorkOrderList()
        Dim ds As DataSet
        Dim dsParent As DataSet
        Dim dsProject As DataSet

        With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
            If .GetWOHeader(ds) Then
                InitGrid()
                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentConfirmQuotationNo As String
                Dim ProjectTitle As String

                If ds.Tables(0).Rows.Count > 0 Then
                    For Each oRow In ds.Tables(0).Rows
                        i = i + 1

                        Select Case (oRow("Status"))
                            Case "10" : Status = "Preparing"
                            Case "20" : Status = "Pending"
                            Case "30" : Status = "Confirmed"
                            Case "40" : Status = "Revised"
                            Case "50" : Status = "Cancel"
                            Case "60" : Status = "Lost"
                        End Select

                        With New BusinessRules.SystemBusRules.ProjectBusLogic
                            If IsDBNull(oRow("Project")) Then
                                .GetProject(dsProject, "")
                            Else
                                If .GetProject(dsProject, oRow("Project")) Then
                                    If Not dsProject Is Nothing Then
                                        ProjectTitle = oRow("ProjectSub") & " " & dsProject.Tables(0).Rows(0)("Project_Name")
                                    End If
                                End If
                            End If
                        End With

                        data.Rows.Add(New Object() {oRow("WO_ID"), i, oRow("WO_No"), ChangeDateFormat(oRow("WO_Date")), oRow("Status"), Status, ProjectTitle, oRow("CustomerName"), oRow("Initial"), oRow("Login_ID")})
                    Next
                    WOGrid.DataSource = data
                    WOGrid.DefaultView.PopulateColumns()
                    GridView1.BestFitColumns()
                    GridView1.Columns.Item(0).VisibleIndex = -1 'hide 1st column Quotation_ID
                    GridView1.Columns.Item(4).VisibleIndex = -1 'hide 4th. Status
                    SetButtonsControl(True)
                Else
                    GridView1.Columns.Clear()
                    SetButtonsControl(False)
                End If
            End If
        End With
    End Sub

    Private Sub InitGrid()
        data = New DataTable("ColumnsTable")
        data.BeginInit()
        AddColumn(data, "WOID", System.Type.GetType("System.Int16"), True)
        AddColumn(data, " ", System.Type.GetType("System.Int16"), True)
        AddColumn(data, "Work Order No", System.Type.GetType("System.String"), True)
        AddColumn(data, "Date", System.Type.GetType("System.String"), True)
        AddColumn(data, "StatusCode", System.Type.GetType("System.String"), True)
        AddColumn(data, "Status", System.Type.GetType("System.String"), True)
        AddColumn(data, "Project", System.Type.GetType("System.String"), True)
        AddColumn(data, "Customer Name", System.Type.GetType("System.String"), True)
        AddColumn(data, "Code", System.Type.GetType("System.String"), True)
        AddColumn(data, "Updated by", System.Type.GetType("System.String"), True)
        data.EndInit()
    End Sub

    Private Sub AddColumn(ByVal data As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro
        data.Columns.Add(col)
    End Sub
#End Region

    Private Sub WOGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WOGrid.Click
        If GridView1.RowCount > 0 Then
            If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
                Dim Row As Integer = GridView1.GetSelectedRows(0)
                Dim dr As DataRow
                dr = GridView1.GetDataRow(Row)
                Dim Status As Integer = dr(4)

                Select Case (Status)
                    Case "30"
                        RevisedBtn.Enabled = True
                        EditBtn.Text = "View"
                        DelBtn.Enabled = False
                    Case "10", "20", "40", "50", "60"
                        RevisedBtn.Enabled = False
                        EditBtn.Text = "Edit"
                        DelBtn.Enabled = True
                End Select
            End If
        End If
    End Sub

#Region " Button Event"
    Private Sub RevisedBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RevisedBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to create a revised Work Order?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                Dim a As MainForm = Me.ParentForm
                Dim controlToAdd As Control = Nothing
                Me.Cursor = Cursors.WaitCursor

                Dim page As Crownwood.Magic.Controls.TabPage
                'YG 16.09.2003
                'controlToAdd = New WorkOrderForm("REVISED", , , WO_ID)
                controlToAdd = New WorkOrderForm("REVISED", , , , WO_ID)
                page = New Crownwood.Magic.Controls.TabPage("Revised Work Order", controlToAdd, ImageList1, 0)

                page.Selected = True
                a.MainTabControl.TabPages.Add(page)
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub DelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)
            Dim Result As DialogResult = MessageBox.Show("Are you sure you want to delete this Work Order?", "Order Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Result = DialogResult.Yes Then
                With New BusinessRules.WorkOrderBusRules.WorkLogicBusLogic
                    .WO_ID = WO_ID
                    .UserID = UserID
                    If .DeleteOneWorkOrder() Then
                        MessageBox.Show("Work Order Deleted.", "Work Order", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End With
            End If
            Me.LoadWorkOrderList()
        End If
    End Sub

    Private Sub EditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)
            Dim Status As String = dr(4)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage

            If Status = "30" Then       'COnfirmed. View only
                controlToAdd = New WorkOrderForm("VIEW", , , WO_ID)
                page = New Crownwood.Magic.Controls.TabPage("View Work Order", controlToAdd, ImageList1, 0)
            Else
                controlToAdd = New WorkOrderForm("EDIT", , , WO_ID)
                page = New Crownwood.Magic.Controls.TabPage("Edit Work Order", controlToAdd, ImageList1, 0)
            End If

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region " Timer"
    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            Timer1.Interval = 60000
            Timer1.Start()
        Else
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LoadWorkOrderList()
        WOGrid_Click(sender, e)
    End Sub
#End Region

#Region " Other Code "
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then
            pDate = Date.Parse(pInputDate)
            tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
        End If

        Return tempsDate
    End Function

    Private Sub SetButtonsControl(ByVal State As Boolean)
        RevisedBtn.Enabled = State
        PrintBtn.Enabled = State
        EditBtn.Enabled = State
        DelBtn.Enabled = State
    End Sub
#End Region

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub WorkOrderListForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadWorkOrderList()
        End If
    End Sub

    Private Sub WOGrid_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles WOGrid.KeyUp
        If e.KeyValue = 116 Then    'F5 key
            LoadWorkOrderList()
        End If
    End Sub

    Private Sub PrintBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintBtn.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New WorkOrderReportForm(WO_ID, 0)
            page = New Crownwood.Magic.Controls.TabPage("Print Work Order", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadWorkOrderList()
        WOGrid_Click(sender, e)
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        WOGrid_Click(sender, e)
    End Sub

    Private Sub WorkOrderListForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub XtraButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        If Not GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) Then
            Dim Row As Integer = GridView1.GetSelectedRows(0)
            Dim dr As DataRow
            dr = GridView1.GetDataRow(Row)
            Dim WO_ID As Integer = dr(0)

            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor

            Dim page As Crownwood.Magic.Controls.TabPage
            controlToAdd = New WorkOrderReportForm(WO_ID, 1)
            page = New Crownwood.Magic.Controls.TabPage("Print Work Order", controlToAdd, ImageList1, 0)

            page.Selected = True
            a.MainTabControl.TabPages.Add(page)
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class
