namespace nutritionist.Tabs.Management
{
    partial class MealPlansTabPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRegisterMealPlan = new System.Windows.Forms.Button();
            this.btnResetMenuFilter = new System.Windows.Forms.Button();
            this.btnUpdateMealPlan = new System.Windows.Forms.Button();
            this.clbMenuTags = new System.Windows.Forms.CheckedListBox();
            this.cmbMenuSort = new System.Windows.Forms.ComboBox();
            this.cmbMenuTypeFilter = new System.Windows.Forms.ComboBox();
            this.colMealName = new System.Windows.Forms.ColumnHeader();
            this.colMealTags = new System.Windows.Forms.ColumnHeader();
            this.colMealType = new System.Windows.Forms.ColumnHeader();
            this.colNutrientCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMealNutrition = new System.Windows.Forms.DataGridView();
            this.dgvMealPlans = new System.Windows.Forms.DataGridView();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.flowMealButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMenuSortBar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMenuTypeFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.grpMealPlanDetail = new System.Windows.Forms.GroupBox();
            this.lblAvailableMenus = new System.Windows.Forms.Label();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.lblMealNotes = new System.Windows.Forms.Label();
            this.lblMealRecipes = new System.Windows.Forms.Label();
            this.lblMenuTags = new System.Windows.Forms.Label();
            this.lblMenuTypeFilter = new System.Windows.Forms.Label();
            this.lblNutrientSummary = new System.Windows.Forms.Label();
            this.lblSelectedMenus = new System.Windows.Forms.Label();
            this.lstAvailableMenus = new System.Windows.Forms.ListBox();
            this.lvMealBoard = new System.Windows.Forms.ListView();
            this.splitContainerMealPlans = new System.Windows.Forms.SplitContainer();
            this.tableMealBuilder = new System.Windows.Forms.TableLayoutPanel();
            this.tableMealPlanDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tableMealRecipeLists = new System.Windows.Forms.TableLayoutPanel();
            this.tableMenuLibrary = new System.Windows.Forms.TableLayoutPanel();
            this.txtMealNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealNutrition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).BeginInit();
            this.SuspendLayout();
            // MealPlansTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerMealPlans);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MealPlansTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
            // 
            // splitContainerMealPlans
            // 
            this.splitContainerMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMealPlans.Location = new System.Drawing.Point(3, 2);
            this.splitContainerMealPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMealPlans.Name = "splitContainerMealPlans";
            // 
            // splitContainerMealPlans.Panel1
            // 
            this.splitContainerMealPlans.Panel1.Controls.Add(this.dgvMealPlans);
            // 
            // splitContainerMealPlans.Panel2
            // 
            this.splitContainerMealPlans.Panel2.Controls.Add(this.grpMealPlanDetail);
            this.splitContainerMealPlans.Size = new System.Drawing.Size(934, 449);
            this.splitContainerMealPlans.SplitterDistance = 472;
            this.splitContainerMealPlans.TabIndex = 0;
            // 
            // dgvMealPlans
            // 
            this.dgvMealPlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvMealPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealPlans.Name = "dgvMealPlans";
            this.dgvMealPlans.RowHeadersWidth = 51;
            this.dgvMealPlans.RowTemplate.Height = 27;
            this.dgvMealPlans.Size = new System.Drawing.Size(472, 449);
            this.dgvMealPlans.TabIndex = 0;
            // 
            // grpMealPlanDetail
            // 
            this.grpMealPlanDetail.Controls.Add(this.tableMealPlanDetail);
            this.grpMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealPlanDetail.Location = new System.Drawing.Point(0, 0);
            this.grpMealPlanDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealPlanDetail.Name = "grpMealPlanDetail";
            this.grpMealPlanDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealPlanDetail.Size = new System.Drawing.Size(458, 449);
            this.grpMealPlanDetail.TabIndex = 0;
            this.grpMealPlanDetail.TabStop = false;
            this.grpMealPlanDetail.Text = "식단 정보";
            // 
            // tableMealPlanDetail
            // 
            this.tableMealPlanDetail.ColumnCount = 2;
            this.tableMealPlanDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableMealPlanDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.Controls.Add(this.lblMealDate, 0, 0);
            this.tableMealPlanDetail.Controls.Add(this.dtpMealDate, 1, 0);
            this.tableMealPlanDetail.Controls.Add(this.lblMealRecipes, 0, 1);
            this.tableMealPlanDetail.Controls.Add(this.tableMealRecipeLists, 1, 1);
            this.tableMealPlanDetail.Controls.Add(this.lblMealNotes, 0, 2);
            this.tableMealPlanDetail.Controls.Add(this.txtMealNotes, 1, 2);
            this.tableMealPlanDetail.Controls.Add(this.flowMealButtons, 1, 3);
            this.tableMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealPlanDetail.Location = new System.Drawing.Point(3, 20);
            this.tableMealPlanDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealPlanDetail.Name = "tableMealPlanDetail";
            this.tableMealPlanDetail.RowCount = 4;
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableMealPlanDetail.Size = new System.Drawing.Size(452, 427);
            this.tableMealPlanDetail.TabIndex = 0;
            // 
            // lblMealDate
            // 
            this.lblMealDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealDate.Location = new System.Drawing.Point(3, 0);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(99, 32);
            this.lblMealDate.TabIndex = 0;
            this.lblMealDate.Text = "식단 날짜";
            this.lblMealDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpMealDate.Location = new System.Drawing.Point(108, 2);
            this.dtpMealDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(176, 25);
            this.dtpMealDate.TabIndex = 1;
            // 
            // lblMealRecipes
            // 
            this.lblMealRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealRecipes.Location = new System.Drawing.Point(3, 32);
            this.lblMealRecipes.Name = "lblMealRecipes";
            this.lblMealRecipes.Size = new System.Drawing.Size(99, 160);
            this.lblMealRecipes.TabIndex = 4;
            this.lblMealRecipes.Text = "메뉴 선택/식단 구성";
            this.lblMealRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableMealRecipeLists
            // 
            this.tableMealRecipeLists.ColumnCount = 2;
            this.tableMealRecipeLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableMealRecipeLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableMealRecipeLists.Controls.Add(this.tableMenuLibrary, 0, 0);
            this.tableMealRecipeLists.Controls.Add(this.tableMealBuilder, 1, 0);
            this.tableMealRecipeLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealRecipeLists.Location = new System.Drawing.Point(108, 66);
            this.tableMealRecipeLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealRecipeLists.Name = "tableMealRecipeLists";
            this.tableMealRecipeLists.RowCount = 1;
            this.tableMealRecipeLists.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealRecipeLists.Size = new System.Drawing.Size(341, 156);
            this.tableMealRecipeLists.TabIndex = 5;
            // 
            // tableMenuLibrary
            // 
            this.tableMenuLibrary.ColumnCount = 1;
            this.tableMenuLibrary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuLibrary.Controls.Add(this.flowMenuTypeFilter, 0, 0);
            this.tableMenuLibrary.Controls.Add(this.lblMenuTags, 0, 1);
            this.tableMenuLibrary.Controls.Add(this.clbMenuTags, 0, 2);
            this.tableMenuLibrary.Controls.Add(this.flowMenuSortBar, 0, 3);
            this.tableMenuLibrary.Controls.Add(this.lstAvailableMenus, 0, 4);
            this.tableMenuLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenuLibrary.Location = new System.Drawing.Point(3, 2);
            this.tableMenuLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMenuLibrary.Name = "tableMenuLibrary";
            this.tableMenuLibrary.RowCount = 5;
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuLibrary.Size = new System.Drawing.Size(164, 152);
            this.tableMenuLibrary.TabIndex = 0;
            // 
            // flowMenuTypeFilter
            // 
            this.flowMenuTypeFilter.AutoSize = true;
            this.flowMenuTypeFilter.Controls.Add(this.lblMenuTypeFilter);
            this.flowMenuTypeFilter.Controls.Add(this.cmbMenuTypeFilter);
            this.flowMenuTypeFilter.Controls.Add(this.btnResetMenuFilter);
            this.flowMenuTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuTypeFilter.Location = new System.Drawing.Point(3, 2);
            this.flowMenuTypeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowMenuTypeFilter.Name = "flowMenuTypeFilter";
            this.flowMenuTypeFilter.Size = new System.Drawing.Size(158, 30);
            this.flowMenuTypeFilter.TabIndex = 0;
            // 
            // lblMenuTypeFilter
            // 
            this.lblMenuTypeFilter.AutoSize = true;
            this.lblMenuTypeFilter.Location = new System.Drawing.Point(3, 0);
            this.lblMenuTypeFilter.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblMenuTypeFilter.Name = "lblMenuTypeFilter";
            this.lblMenuTypeFilter.Size = new System.Drawing.Size(74, 19);
            this.lblMenuTypeFilter.TabIndex = 0;
            this.lblMenuTypeFilter.Text = "메뉴 종류";
            this.lblMenuTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMenuTypeFilter
            // 
            this.cmbMenuTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuTypeFilter.FormattingEnabled = true;
            this.cmbMenuTypeFilter.Location = new System.Drawing.Point(86, 2);
            this.cmbMenuTypeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMenuTypeFilter.Name = "cmbMenuTypeFilter";
            this.cmbMenuTypeFilter.Size = new System.Drawing.Size(110, 25);
            this.cmbMenuTypeFilter.TabIndex = 1;
            // 
            // btnResetMenuFilter
            // 
            this.btnResetMenuFilter.AutoSize = true;
            this.btnResetMenuFilter.Location = new System.Drawing.Point(212, 2);
            this.btnResetMenuFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetMenuFilter.Name = "btnResetMenuFilter";
            this.btnResetMenuFilter.Size = new System.Drawing.Size(79, 27);
            this.btnResetMenuFilter.TabIndex = 2;
            this.btnResetMenuFilter.Text = "필터 초기화";
            this.btnResetMenuFilter.UseVisualStyleBackColor = true;
            // 
            // lblMenuTags
            // 
            this.lblMenuTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuTags.Location = new System.Drawing.Point(3, 34);
            this.lblMenuTags.Name = "lblMenuTags";
            this.lblMenuTags.Size = new System.Drawing.Size(158, 24);
            this.lblMenuTags.TabIndex = 1;
            this.lblMenuTags.Text = "태그 필터";
            this.lblMenuTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clbMenuTags
            // 
            this.clbMenuTags.CheckOnClick = true;
            this.clbMenuTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbMenuTags.FormattingEnabled = true;
            this.clbMenuTags.Location = new System.Drawing.Point(3, 60);
            this.clbMenuTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMenuTags.Name = "clbMenuTags";
            this.clbMenuTags.Size = new System.Drawing.Size(158, 24);
            this.clbMenuTags.TabIndex = 2;
            // 
            // flowMenuSortBar
            // 
            this.flowMenuSortBar.AutoSize = true;
            this.flowMenuSortBar.Controls.Add(this.cmbMenuSort);
            this.flowMenuSortBar.Controls.Add(this.lblAvailableMenus);
            this.flowMenuSortBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuSortBar.Location = new System.Drawing.Point(3, 86);
            this.flowMenuSortBar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowMenuSortBar.Name = "flowMenuSortBar";
            this.flowMenuSortBar.Size = new System.Drawing.Size(158, 24);
            this.flowMenuSortBar.TabIndex = 3;
            this.flowMenuSortBar.WrapContents = false;
            // 
            // cmbMenuSort
            // 
            this.cmbMenuSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuSort.FormattingEnabled = true;
            this.cmbMenuSort.Location = new System.Drawing.Point(3, 0);
            this.cmbMenuSort.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.cmbMenuSort.Name = "cmbMenuSort";
            this.cmbMenuSort.Size = new System.Drawing.Size(115, 25);
            this.cmbMenuSort.TabIndex = 0;
            // 
            // lblAvailableMenus
            // 
            this.lblAvailableMenus.AutoSize = true;
            this.lblAvailableMenus.Location = new System.Drawing.Point(124, 0);
            this.lblAvailableMenus.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblAvailableMenus.Name = "lblAvailableMenus";
            this.lblAvailableMenus.Size = new System.Drawing.Size(65, 19);
            this.lblAvailableMenus.TabIndex = 1;
            this.lblAvailableMenus.Text = "메뉴 목록";
            this.lblAvailableMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstAvailableMenus
            // 
            this.lstAvailableMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailableMenus.FormattingEnabled = true;
            this.lstAvailableMenus.ItemHeight = 17;
            this.lstAvailableMenus.Location = new System.Drawing.Point(3, 112);
            this.lstAvailableMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAvailableMenus.Name = "lstAvailableMenus";
            this.lstAvailableMenus.Size = new System.Drawing.Size(158, 38);
            this.lstAvailableMenus.TabIndex = 4;
            // 
            // tableMealBuilder
            // 
            this.tableMealBuilder.ColumnCount = 1;
            this.tableMealBuilder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealBuilder.Controls.Add(this.lblSelectedMenus, 0, 0);
            this.tableMealBuilder.Controls.Add(this.lvMealBoard, 0, 1);
            this.tableMealBuilder.Controls.Add(this.lblNutrientSummary, 0, 2);
            this.tableMealBuilder.Controls.Add(this.dgvMealNutrition, 0, 3);
            this.tableMealBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealBuilder.Location = new System.Drawing.Point(173, 2);
            this.tableMealBuilder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealBuilder.Name = "tableMealBuilder";
            this.tableMealBuilder.RowCount = 4;
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMealBuilder.Size = new System.Drawing.Size(165, 152);
            this.tableMealBuilder.TabIndex = 1;
            // 
            // lblSelectedMenus
            // 
            this.lblSelectedMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedMenus.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedMenus.Name = "lblSelectedMenus";
            this.lblSelectedMenus.Size = new System.Drawing.Size(159, 24);
            this.lblSelectedMenus.TabIndex = 0;
            this.lblSelectedMenus.Text = "식단 보드";
            this.lblSelectedMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvMealBoard
            // 
            this.lvMealBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMealName,
            this.colMealType,
            this.colMealTags});
            this.lvMealBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMealBoard.FullRowSelect = true;
            this.lvMealBoard.HideSelection = false;
            this.lvMealBoard.Location = new System.Drawing.Point(3, 26);
            this.lvMealBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMealBoard.MultiSelect = false;
            this.lvMealBoard.Name = "lvMealBoard";
            this.lvMealBoard.Size = new System.Drawing.Size(159, 60);
            this.lvMealBoard.TabIndex = 1;
            this.lvMealBoard.UseCompatibleStateImageBehavior = false;
            this.lvMealBoard.View = System.Windows.Forms.View.Details;
            // 
            // colMealName
            // 
            this.colMealName.Text = "메뉴명";
            this.colMealName.Width = 120;
            // 
            // colMealType
            // 
            this.colMealType.Text = "분류";
            this.colMealType.Width = 80;
            // 
            // colMealTags
            // 
            this.colMealTags.Text = "태그";
            this.colMealTags.Width = 120;
            // 
            // lblNutrientSummary
            // 
            this.lblNutrientSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientSummary.Location = new System.Drawing.Point(3, 88);
            this.lblNutrientSummary.Name = "lblNutrientSummary";
            this.lblNutrientSummary.Size = new System.Drawing.Size(159, 24);
            this.lblNutrientSummary.TabIndex = 2;
            this.lblNutrientSummary.Text = "필수 영양소 충족 현황";
            this.lblNutrientSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMealNutrition
            // 
            this.dgvMealNutrition.AllowUserToAddRows = false;
            this.dgvMealNutrition.AllowUserToDeleteRows = false;
            this.dgvMealNutrition.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealNutrition.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealNutrition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealNutrition.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNutrientName,
            this.colNutrientUnit,
            this.colNutrientTarget,
            this.colNutrientCurrent,
            this.colNutrientStatus});
            this.dgvMealNutrition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealNutrition.Location = new System.Drawing.Point(3, 114);
            this.dgvMealNutrition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealNutrition.MultiSelect = false;
            this.dgvMealNutrition.Name = "dgvMealNutrition";
            this.dgvMealNutrition.ReadOnly = true;
            this.dgvMealNutrition.RowHeadersVisible = false;
            this.dgvMealNutrition.RowTemplate.Height = 25;
            this.dgvMealNutrition.Size = new System.Drawing.Size(159, 36);
            this.dgvMealNutrition.TabIndex = 3;
            // 
            // colNutrientName
            // 
            this.colNutrientName.DataPropertyName = "Nutrient";
            this.colNutrientName.HeaderText = "영양소";
            this.colNutrientName.Name = "colNutrientName";
            this.colNutrientName.ReadOnly = true;
            // 
            // colNutrientUnit
            // 
            this.colNutrientUnit.DataPropertyName = "Unit";
            this.colNutrientUnit.HeaderText = "단위";
            this.colNutrientUnit.Name = "colNutrientUnit";
            this.colNutrientUnit.ReadOnly = true;
            this.colNutrientUnit.Width = 60;
            // 
            // colNutrientTarget
            // 
            this.colNutrientTarget.DataPropertyName = "TargetAmount";
            this.colNutrientTarget.HeaderText = "권장량";
            this.colNutrientTarget.Name = "colNutrientTarget";
            this.colNutrientTarget.ReadOnly = true;
            // 
            // colNutrientCurrent
            // 
            this.colNutrientCurrent.DataPropertyName = "CurrentAmount";
            this.colNutrientCurrent.HeaderText = "현재량";
            this.colNutrientCurrent.Name = "colNutrientCurrent";
            this.colNutrientCurrent.ReadOnly = true;
            // 
            // colNutrientStatus
            // 
            this.colNutrientStatus.DataPropertyName = "CompletionText";
            this.colNutrientStatus.HeaderText = "충족률";
            this.colNutrientStatus.Name = "colNutrientStatus";
            this.colNutrientStatus.ReadOnly = true;
            // 
            // lblMealNotes
            // 
            this.lblMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealNotes.Location = new System.Drawing.Point(3, 192);
            this.lblMealNotes.Name = "lblMealNotes";
            this.lblMealNotes.Size = new System.Drawing.Size(99, 96);
            this.lblMealNotes.TabIndex = 6;
            this.lblMealNotes.Text = "비고";
            this.lblMealNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMealNotes
            // 
            this.txtMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMealNotes.Location = new System.Drawing.Point(108, 194);
            this.txtMealNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMealNotes.Multiline = true;
            this.txtMealNotes.Name = "txtMealNotes";
            this.txtMealNotes.Size = new System.Drawing.Size(341, 92);
            this.txtMealNotes.TabIndex = 7;
            // 
            // flowMealButtons
            // 
            this.flowMealButtons.AutoSize = true;
            this.flowMealButtons.Controls.Add(this.btnRegisterMealPlan);
            this.flowMealButtons.Controls.Add(this.btnUpdateMealPlan);
            this.flowMealButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMealButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowMealButtons.Location = new System.Drawing.Point(3, 290);
            this.flowMealButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowMealButtons.Name = "flowMealButtons";
            this.flowMealButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowMealButtons.Size = new System.Drawing.Size(446, 40);
            this.flowMealButtons.TabIndex = 8;
            // 
            // btnRegisterMealPlan
            // 
            this.btnRegisterMealPlan.Location = new System.Drawing.Point(339, 10);
            this.btnRegisterMealPlan.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRegisterMealPlan.Name = "btnRegisterMealPlan";
            this.btnRegisterMealPlan.Size = new System.Drawing.Size(107, 28);
            this.btnRegisterMealPlan.TabIndex = 0;
            this.btnRegisterMealPlan.Text = "식단 등록";
            this.btnRegisterMealPlan.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMealPlan
            // 
            this.btnUpdateMealPlan.Location = new System.Drawing.Point(232, 10);
            this.btnUpdateMealPlan.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnUpdateMealPlan.Name = "btnUpdateMealPlan";
            this.btnUpdateMealPlan.Size = new System.Drawing.Size(98, 28);
            this.btnUpdateMealPlan.TabIndex = 1;
            this.btnUpdateMealPlan.Text = "식단 수정";
            this.btnUpdateMealPlan.UseVisualStyleBackColor = true;
            // 
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealNutrition)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal System.Windows.Forms.Button btnRegisterMealPlan;
        internal System.Windows.Forms.Button btnResetMenuFilter;
        internal System.Windows.Forms.Button btnUpdateMealPlan;
        internal System.Windows.Forms.CheckedListBox clbMenuTags;
        internal System.Windows.Forms.ComboBox cmbMenuSort;
        internal System.Windows.Forms.ComboBox cmbMenuTypeFilter;
        internal System.Windows.Forms.ColumnHeader colMealName;
        internal System.Windows.Forms.ColumnHeader colMealTags;
        internal System.Windows.Forms.ColumnHeader colMealType;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNutrientCurrent;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNutrientName;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNutrientStatus;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNutrientTarget;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colNutrientUnit;
        internal System.Windows.Forms.DataGridView dgvMealNutrition;
        internal System.Windows.Forms.DataGridView dgvMealPlans;
        internal System.Windows.Forms.DateTimePicker dtpMealDate;
        internal System.Windows.Forms.FlowLayoutPanel flowMealButtons;
        internal System.Windows.Forms.FlowLayoutPanel flowMenuSortBar;
        internal System.Windows.Forms.FlowLayoutPanel flowMenuTypeFilter;
        internal System.Windows.Forms.GroupBox grpMealPlanDetail;
        internal System.Windows.Forms.Label lblAvailableMenus;
        internal System.Windows.Forms.Label lblMealDate;
        internal System.Windows.Forms.Label lblMealNotes;
        internal System.Windows.Forms.Label lblMealRecipes;
        internal System.Windows.Forms.Label lblMenuTags;
        internal System.Windows.Forms.Label lblMenuTypeFilter;
        internal System.Windows.Forms.Label lblNutrientSummary;
        internal System.Windows.Forms.Label lblSelectedMenus;
        internal System.Windows.Forms.ListBox lstAvailableMenus;
        internal System.Windows.Forms.ListView lvMealBoard;
        internal System.Windows.Forms.SplitContainer splitContainerMealPlans;
        internal System.Windows.Forms.TableLayoutPanel tableMealBuilder;
        internal System.Windows.Forms.TableLayoutPanel tableMealPlanDetail;
        internal System.Windows.Forms.TableLayoutPanel tableMealRecipeLists;
        internal System.Windows.Forms.TableLayoutPanel tableMenuLibrary;
        internal System.Windows.Forms.TextBox txtMealNotes;
    }
}
