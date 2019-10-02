Public Class POList
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
    Friend WithEvents PRListGrp As System.Windows.Forms.GroupBox
    Friend WithEvents CreateBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents POListGrid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ViewPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RefreshBtn As System.Windows.Forms.CheckBox
    Friend WithEvents CloseBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents PrintPOBtn As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents btnRefresh As DevExpress.XtraEditors.Controls.XtraButton
    Friend WithEvents XtraButton1 As DevExpress.XtraEditors.Controls.XtraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(POList))
        Me.PRListGrp = New System.Windows.Forms.GroupBox
        Me.XtraButton1 = New DevExpress.XtraEditors.Controls.XtraButton
        Me.btnRefresh = New DevExpress.XtraEditors.Controls.XtraButton
        Me.PrintPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CloseBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.RefreshBtn = New System.Windows.Forms.CheckBox
        Me.ViewPOBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.CreateBtn = New DevExpress.XtraEditors.Controls.XtraButton
        Me.POListGrid = New DevExpress.XtraGrid.GridControl
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PRListGrp.SuspendLayout()
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRListGrp
        '
        Me.PRListGrp.Controls.Add(Me.XtraButton1)
        Me.PRListGrp.Controls.Add(Me.btnRefresh)
        Me.PRListGrp.Controls.Add(Me.PrintPOBtn)
        Me.PRListGrp.Controls.Add(Me.CloseBtn)
        Me.PRListGrp.Controls.Add(Me.RefreshBtn)
        Me.PRListGrp.Controls.Add(Me.ViewPOBtn)
        Me.PRListGrp.Controls.Add(Me.CreateBtn)
        Me.PRListGrp.Controls.Add(Me.POListGrid)
        Me.PRListGrp.Location = New System.Drawing.Point(8, 8)
        Me.PRListGrp.Name = "PRListGrp"
        Me.PRListGrp.Size = New System.Drawing.Size(776, 408)
        Me.PRListGrp.TabIndex = 3
        Me.PRListGrp.TabStop = False
        Me.PRListGrp.Text = "PO List"
        '
        'XtraButton1
        '
        Me.XtraButton1.AutoSize = False
        Me.XtraButton1.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.XtraButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XtraButton1.Image = Nothing
        Me.XtraButton1.Location = New System.Drawing.Point(264, 368)
        Me.XtraButton1.Name = "XtraButton1"
        Me.XtraButton1.Size = New System.Drawing.Size(104, 32)
        Me.XtraButton1.TabIndex = 26
        Me.XtraButton1.Text = "Print PO Basic"
        '
        'btnRefresh
        '
        Me.btnRefresh.AutoSize = False
        Me.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(624, 368)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(72, 32)
        Me.btnRefresh.TabIndex = 25
        Me.btnRefresh.Text = "Refresh"
        '
        'PrintPOBtn
        '
        Me.PrintPOBtn.AutoSize = False
        Me.PrintPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PrintPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintPOBtn.Image = Nothing
        Me.PrintPOBtn.Location = New System.Drawing.Point(184, 368)
        Me.PrintPOBtn.Name = "PrintPOBtn"
        Me.PrintPOBtn.Size = New System.Drawing.Size(72, 32)
        Me.PrintPOBtn.TabIndex = 24
        Me.PrintPOBtn.Text = "Print PO"
        '
        'CloseBtn
        '
        Me.CloseBtn.AutoSize = False
        Me.CloseBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Image = Nothing
        Me.CloseBtn.Location = New System.Drawing.Point(704, 368)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(64, 32)
        Me.CloseBtn.TabIndex = 23
        Me.CloseBtn.Text = "&Close"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Checked = True
        Me.RefreshBtn.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RefreshBtn.Location = New System.Drawing.Point(8, 368)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.TabIndex = 6
        Me.RefreshBtn.Text = "Auto Refresh"
        Me.RefreshBtn.Visible = False
        '
        'ViewPOBtn
        '
        Me.ViewPOBtn.AutoSize = False
        Me.ViewPOBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.ViewPOBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewPOBtn.Image = Nothing
        Me.ViewPOBtn.Location = New System.Drawing.Point(112, 368)
        Me.ViewPOBtn.Name = "ViewPOBtn"
        Me.ViewPOBtn.Size = New System.Drawing.Size(64, 32)
        Me.ViewPOBtn.TabIndex = 5
        Me.ViewPOBtn.Text = "View PO"
        '
        'CreateBtn
        '
        Me.CreateBtn.AutoSize = False
        Me.CreateBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.CreateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateBtn.Image = Nothing
        Me.CreateBtn.Location = New System.Drawing.Point(512, 368)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(104, 32)
        Me.CreateBtn.TabIndex = 4
        Me.CreateBtn.Text = "Generate New PO"
        Me.CreateBtn.Visible = False
        '
        'POListGrid
        '
        Me.POListGrid.EditorsRepository = Me.PersistentRepository1
        Me.POListGrid.Location = New System.Drawing.Point(8, 24)
        Me.POListGrid.MainView = Me.GridView1
        Me.POListGrid.Name = "POListGrid"
        Me.POListGrid.Size = New System.Drawing.Size(760, 336)
        Me.POListGrid.TabIndex = 2
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
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        '
        'POList
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(792, 423)
        Me.Controls.Add(Me.PRListGrp)
        Me.Name = "POList"
        Me.Text = "Purchase Order List"
        Me.PRListGrp.ResumeLayout(False)
        CType(Me.POListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Variable Initialization"

    Public PO_ID As Integer
    Public dataPOGrid As System.Data.DataTable

#End Region

#Region " Event "

    Private Sub POList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ViewOptions = Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowFooter And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowGroupPanel And Not DevExpress.XtraGrid.Views.Grid.ViewOptionsFlags.ShowNewItemRow

        LoadPOFrmDB()

        CheckExistingPR()

        'Timer1.Interval = 60000
        'Timer1.Start()
    End Sub

    Private Sub POListGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles POListGrid.Click
        POClick()
    End Sub

    Private Sub CreateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateBtn.Click

        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim page As Crownwood.Magic.Controls.TabPage

        controlToAdd = New POForm
        page = New Crownwood.Magic.Controls.TabPage("Generate PO", controlToAdd, ImageList1, 0)

        page.Selected = True

        a.MainTabControl.TabPages.Add(page)

        Me.Cursor = Cursors.Default


        'Dim form As New POForm("NEW")

        'form.PO_ID = PO_ID

        'form.ShowDialog()
        'form.Dispose()

        'Reload PO list
        'ClearGrid(GridView1)
        'LoadPOFrmDB()

        'CheckExistingPR()

    End Sub

    Private Sub ViewPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPOBtn.Click

        If PO_ID <> Nothing And PO_ID <> 0 Then


            Dim a As MainForm = Me.ParentForm
            Dim controlToAdd As Control = Nothing
            Me.Cursor = Cursors.WaitCursor
            Dim page As Crownwood.Magic.Controls.TabPage

            controlToAdd = New POViewForm("VIEW", PO_ID)
            page = New Crownwood.Magic.Controls.TabPage("View PO", controlToAdd, ImageList1, 0)

            page.Selected = True

            a.MainTabControl.TabPages.Add(page)

            Me.Cursor = Cursors.Default

            'Dim form As New POForm("VIEW")

            'form.PO_ID = PO_ID

            'form.ShowDialog()
            'form.Dispose()

        End If

    End Sub

    Private Sub RefreshBtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshBtn.CheckedChanged
        If RefreshBtn.Checked = True Then
            'Timer1.Interval = 60000
            'Timer1.Start()
        Else
            'Timer1.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'ClearGrid(GridView1)
        LoadPOFrmDB()

        CheckExistingPR()

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        'Dim Result As DialogResult = MessageBox.Show("Are you sure you want to exit this PO?", "PO", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If Result = DialogResult.Yes Then
            'Me.Close()
        Me.Close()
        'End If
    End Sub

    Private Sub PrintPOBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPOBtn.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor
        Dim PrintTitle As Boolean = False

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New POReportForm(PO_ID, PrintTitle)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region " Grid Code "

    'Call once form load, Initalize PO Columns
    Private Sub InitPOList()

        dataPOGrid = New DataTable("ColumnsTable")
        dataPOGrid.BeginInit()

        AddColumn(dataPOGrid, "PO_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(dataPOGrid, "PO NO", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Delivery", System.Type.GetType("System.String"), True)
        AddColumn(dataPOGrid, "Supplier_ID", System.Type.GetType("System.Int16"), True)
        AddColumn(dataPOGrid, "Supplier", System.Type.GetType("System.String"), True)

        dataPOGrid.EndInit()

    End Sub

    Private Sub AddColumn(ByVal data1 As DataTable, ByVal name As String, ByVal type As System.Type, ByVal ro As Boolean)
        Dim col As New DataColumn(name, type)
        col.Caption = name
        col.ReadOnly = ro

        data1.Columns.Add(col)
    End Sub

    Private Sub ClearGrid(ByVal GridView As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim i

        If GridView.RowCount() <> 0 Then
            GridView.FocusedRowHandle = 0
            For i = 0 To GridView.RowCount() - 1
                If GridView1.IsGroupRow(i) = False Then

                    GridView.DeleteRow(GridView.GetSelectedRows(0))
                    If GridView.RowCount() <> 0 Then
                        GridView.FocusedRowHandle = 0
                    End If

                End If
            Next
        End If
    End Sub

#End Region

#Region " Other Codes "

    'Change date format
    Private Function ChangeDateFormat(ByVal pInputDate As Object) As String
        Dim pDate As Date
        Dim tempsDate As String = ""

        If Not pInputDate Is System.DBNull.Value Then

            If pInputDate.ToString <> "" Then
                pDate = Date.Parse(pInputDate)
                tempsDate = pDate.Day & " " & MonthName(pDate.Month) & " " & pDate.Year
            End If

        End If

        Return tempsDate

    End Function

    Private Sub LoadPOFrmDB()
        Dim ds As DataSet
        Dim dsParent As DataSet
        With New BusinessRules.POBusRules.POHeaderBusLogic
            If .LoadList(ds) Then

                InitPOList()

                Dim oRow As DataRow
                Dim i As Integer = 0
                Dim Status As String
                Dim ParentQuotationNo As String

                For Each oRow In ds.Tables(0).Rows
                    dataPOGrid.Rows.Add(New Object() {oRow("PO_ID"), _
                                                        oRow("PO_NO"), _
                                                        ChangeDateFormat(oRow("Shipment_Date")), _
                                                        oRow("Supplier_ID"), _
                                                        oRow("Supplier_Name")})
                Next


                POListGrid.DataSource = dataPOGrid
                POListGrid.DefaultView.PopulateColumns()

                GridView1.BestFitColumns()
                GridView1.Columns.Item(0).VisibleIndex = -1 'hide column
                GridView1.Columns.Item(3).VisibleIndex = -1 'hide column
            End If
        End With

        If GridView1.RowCount() <> 0 Then
            GridView1.MoveFirst()
            POClick()
        End If
    End Sub

    'Check if there is existing PR to add to PO, show Generate New PO button
    Private Sub CheckExistingPR()

        Dim ds As DataSet

        With New BusinessRules.POBusRules.POBusLogic
            If Not .LoadPRList(ds, "0", "40") Then
                CreateBtn.Visible = False
            Else
                CreateBtn.Visible = True
            End If
        End With

    End Sub

    Private Sub POClick()
        If GridView1.SelectedRowsCount <> 0 Then

            If GridView1.IsGroupRow(GridView1.GetSelectedRows(0)) = False Then
                Me.Cursor = Cursors.WaitCursor
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.GetSelectedRows(0))

                Dim items As Object() = dr.ItemArray

                PO_ID = items(0)

                Me.Cursor = Cursors.Default

            End If
        End If
    End Sub

#End Region

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadPOFrmDB()
    End Sub

    Private Sub POList_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim a As MainForm = Me.ParentForm
        If (a.MainTabControl.TabPages.Count > 0) Then
            If Not (a.MainTabControl.SelectedTab Is Nothing) Then
                a.MainTabControl.TabPages.Remove(a.MainTabControl.SelectedTab)
            End If
        End If
    End Sub

    Private Sub XtraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraButton1.Click
        Dim a As MainForm = Me.ParentForm
        Dim controlToAdd As Control = Nothing
        Me.Cursor = Cursors.WaitCursor

        Dim page As Crownwood.Magic.Controls.TabPage
        controlToAdd = New POReportForm(PO_ID,True)
        page = New Crownwood.Magic.Controls.TabPage("PO Report", controlToAdd, ImageList1, 0)

        page.Selected = True
        a.MainTabControl.TabPages.Add(page)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub POListGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles POListGrid.DoubleClick
        ViewPOBtn_Click(sender, e)
    End Sub
End Class
