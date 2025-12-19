namespace nutritionist.Forms
{
    partial class MealPlansForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegisterMealPlan = new System.Windows.Forms.Button();
            this.btnResetMenuFilter = new System.Windows.Forms.Button();
            this.btnRequestMealApproval = new System.Windows.Forms.Button();
            this.clbMenuTags = new System.Windows.Forms.CheckedListBox();
            this.cmbMenuSort = new System.Windows.Forms.ComboBox();
            this.cmbMenuTypeFilter = new System.Windows.Forms.ComboBox();
            this.colMealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMealTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMealType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNutrientCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNutrientUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMealNutrition = new System.Windows.Forms.DataGridView();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMealMonth = new System.Windows.Forms.DateTimePicker();
            this.cmbMealWeek = new System.Windows.Forms.ComboBox();
            this.lblSelectedMealDay = new System.Windows.Forms.Label();
            this.tablePlanButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartMealPlan = new System.Windows.Forms.Button();
            this.planListRow = new System.Windows.Forms.TableLayoutPanel();
            this.lstWeekMealPlans = new System.Windows.Forms.ListBox();
            this.flowMealPeriodRow = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMealMonthTitle = new System.Windows.Forms.Label();
            this.lblMealWeekTitle = new System.Windows.Forms.Label();
            this.tableMealDaySelector = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealDayTitle = new System.Windows.Forms.Label();
            this.flowMealButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMenuSortBar = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAvailableMenus = new System.Windows.Forms.Label();
            this.flowMenuTypeFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMenuTypeFilter = new System.Windows.Forms.Label();
            this.flowMealPeriodSelector = new System.Windows.Forms.TableLayoutPanel();
            this.grpPlanSelector = new System.Windows.Forms.GroupBox();
            this.tablePlanSelector = new System.Windows.Forms.TableLayoutPanel();
            this.grpMealPlanDetail = new System.Windows.Forms.GroupBox();
            this.tableMealPlanDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tableMealRecipeLists = new System.Windows.Forms.TableLayoutPanel();
            this.tableMenuLibrary = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenuTags = new System.Windows.Forms.Label();
            this.lstAvailableMenus = new System.Windows.Forms.ListBox();
            this.tableMealBuilder = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectedMenus = new System.Windows.Forms.Label();
            this.lvMealBoard = new System.Windows.Forms.ListView();
            this.lblNutrientSummary = new System.Windows.Forms.Label();
            this.lblMealNotes = new System.Windows.Forms.Label();
            this.txtMealNotes = new System.Windows.Forms.TextBox();
            this.splitContainerMealPlans = new System.Windows.Forms.SplitContainer();
            this.grpMealSchedule = new System.Windows.Forms.GroupBox();
            this.tableMealSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.dgvWeeklyMeals = new System.Windows.Forms.DataGridView();
            this.colWeekMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeekFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAllergyStatus = new System.Windows.Forms.GroupBox();
            this.lvAllergyAlerts = new System.Windows.Forms.ListView();
            this.colAllergyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllergyMenus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllergyRiskCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllergyAltCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAllergyAltSummary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMealPlanStatus = new System.Windows.Forms.Label();
            this.lblWeeklyMeals = new System.Windows.Forms.Label();
            this.btnDeleteMealPlan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealNutrition)).BeginInit();
            this.planListRow.SuspendLayout();
            this.flowMealPeriodRow.SuspendLayout();
            this.tableMealDaySelector.SuspendLayout();
            this.flowMealButtons.SuspendLayout();
            this.flowMenuSortBar.SuspendLayout();
            this.flowMenuTypeFilter.SuspendLayout();
            this.flowMealPeriodSelector.SuspendLayout();
            this.grpPlanSelector.SuspendLayout();
            this.tablePlanSelector.SuspendLayout();
            this.grpMealPlanDetail.SuspendLayout();
            this.tableMealPlanDetail.SuspendLayout();
            this.tableMealRecipeLists.SuspendLayout();
            this.tableMenuLibrary.SuspendLayout();
            this.tableMealBuilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).BeginInit();
            this.splitContainerMealPlans.Panel1.SuspendLayout();
            this.splitContainerMealPlans.Panel2.SuspendLayout();
            this.splitContainerMealPlans.SuspendLayout();
            this.grpMealSchedule.SuspendLayout();
            this.tableMealSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMeals)).BeginInit();
            this.grpAllergyStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterMealPlan
            // 
            this.btnRegisterMealPlan.Location = new System.Drawing.Point(531, 10);
            this.btnRegisterMealPlan.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRegisterMealPlan.Name = "btnRegisterMealPlan";
            this.btnRegisterMealPlan.Size = new System.Drawing.Size(134, 30);
            this.btnRegisterMealPlan.TabIndex = 0;
            this.btnRegisterMealPlan.Text = "식단 등록";
            this.btnRegisterMealPlan.UseVisualStyleBackColor = true;
            // 
            // btnResetMenuFilter
            // 
            this.btnResetMenuFilter.AutoSize = true;
            this.btnResetMenuFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResetMenuFilter.Location = new System.Drawing.Point(4, 36);
            this.btnResetMenuFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnResetMenuFilter.Name = "btnResetMenuFilter";
            this.btnResetMenuFilter.Size = new System.Drawing.Size(142, 30);
            this.btnResetMenuFilter.TabIndex = 2;
            this.btnResetMenuFilter.Text = "필터 초기화";
            this.btnResetMenuFilter.UseVisualStyleBackColor = true;
            // 
            // btnRequestMealApproval
            // 
            this.btnRequestMealApproval.Enabled = false;
            this.btnRequestMealApproval.Location = new System.Drawing.Point(386, 10);
            this.btnRequestMealApproval.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRequestMealApproval.Name = "btnRequestMealApproval";
            this.btnRequestMealApproval.Size = new System.Drawing.Size(134, 30);
            this.btnRequestMealApproval.TabIndex = 1;
            this.btnRequestMealApproval.Text = "식단 승인 요청";
            this.btnRequestMealApproval.UseVisualStyleBackColor = true;
            // 
            // clbMenuTags
            // 
            this.clbMenuTags.CheckOnClick = true;
            this.clbMenuTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbMenuTags.FormattingEnabled = true;
            this.clbMenuTags.Location = new System.Drawing.Point(4, 95);
            this.clbMenuTags.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.clbMenuTags.Name = "clbMenuTags";
            this.clbMenuTags.Size = new System.Drawing.Size(283, 70);
            this.clbMenuTags.TabIndex = 2;
            // 
            // cmbMenuSort
            // 
            this.cmbMenuSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuSort.FormattingEnabled = true;
            this.cmbMenuSort.Location = new System.Drawing.Point(4, 0);
            this.cmbMenuSort.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.cmbMenuSort.Name = "cmbMenuSort";
            this.cmbMenuSort.Size = new System.Drawing.Size(143, 26);
            this.cmbMenuSort.TabIndex = 0;
            // 
            // cmbMenuTypeFilter
            // 
            this.cmbMenuTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuTypeFilter.FormattingEnabled = true;
            this.cmbMenuTypeFilter.Location = new System.Drawing.Point(102, 2);
            this.cmbMenuTypeFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cmbMenuTypeFilter.Name = "cmbMenuTypeFilter";
            this.cmbMenuTypeFilter.Size = new System.Drawing.Size(136, 26);
            this.cmbMenuTypeFilter.TabIndex = 1;
            // 
            // colMealName
            // 
            this.colMealName.Text = "메뉴명";
            this.colMealName.Width = 120;
            // 
            // colMealTags
            // 
            this.colMealTags.Text = "태그";
            this.colMealTags.Width = 120;
            // 
            // colMealType
            // 
            this.colMealType.Text = "분류";
            this.colMealType.Width = 80;
            // 
            // colNutrientCurrent
            // 
            this.colNutrientCurrent.DataPropertyName = "CurrentAmount";
            this.colNutrientCurrent.HeaderText = "현재량";
            this.colNutrientCurrent.MinimumWidth = 8;
            this.colNutrientCurrent.Name = "colNutrientCurrent";
            this.colNutrientCurrent.ReadOnly = true;
            // 
            // colNutrientName
            // 
            this.colNutrientName.DataPropertyName = "Nutrient";
            this.colNutrientName.HeaderText = "영양소";
            this.colNutrientName.MinimumWidth = 8;
            this.colNutrientName.Name = "colNutrientName";
            this.colNutrientName.ReadOnly = true;
            // 
            // colNutrientStatus
            // 
            this.colNutrientStatus.DataPropertyName = "CompletionText";
            this.colNutrientStatus.HeaderText = "충족률";
            this.colNutrientStatus.MinimumWidth = 8;
            this.colNutrientStatus.Name = "colNutrientStatus";
            this.colNutrientStatus.ReadOnly = true;
            // 
            // colNutrientTarget
            // 
            this.colNutrientTarget.DataPropertyName = "TargetAmount";
            this.colNutrientTarget.HeaderText = "권장량";
            this.colNutrientTarget.MinimumWidth = 8;
            this.colNutrientTarget.Name = "colNutrientTarget";
            this.colNutrientTarget.ReadOnly = true;
            // 
            // colNutrientUnit
            // 
            this.colNutrientUnit.DataPropertyName = "Unit";
            this.colNutrientUnit.HeaderText = "단위";
            this.colNutrientUnit.MinimumWidth = 8;
            this.colNutrientUnit.Name = "colNutrientUnit";
            this.colNutrientUnit.ReadOnly = true;
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
            this.dgvMealNutrition.Location = new System.Drawing.Point(4, 353);
            this.dgvMealNutrition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvMealNutrition.MultiSelect = false;
            this.dgvMealNutrition.Name = "dgvMealNutrition";
            this.dgvMealNutrition.ReadOnly = true;
            this.dgvMealNutrition.RowHeadersVisible = false;
            this.dgvMealNutrition.RowHeadersWidth = 62;
            this.dgvMealNutrition.RowTemplate.Height = 25;
            this.dgvMealNutrition.Size = new System.Drawing.Size(350, 197);
            this.dgvMealNutrition.TabIndex = 3;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Location = new System.Drawing.Point(434, 2);
            this.dtpMealDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(190, 28);
            this.dtpMealDate.TabIndex = 1;
            this.dtpMealDate.Visible = false;
            // 
            // dtpMealMonth
            // 
            this.dtpMealMonth.CustomFormat = "yyyy-MM";
            this.dtpMealMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMealMonth.Location = new System.Drawing.Point(76, 2);
            this.dtpMealMonth.Margin = new System.Windows.Forms.Padding(4, 2, 12, 2);
            this.dtpMealMonth.Name = "dtpMealMonth";
            this.dtpMealMonth.ShowUpDown = true;
            this.dtpMealMonth.Size = new System.Drawing.Size(120, 28);
            this.dtpMealMonth.TabIndex = 11;
            // 
            // cmbMealWeek
            // 
            this.cmbMealWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealWeek.FormattingEnabled = true;
            this.cmbMealWeek.Location = new System.Drawing.Point(256, 2);
            this.cmbMealWeek.Margin = new System.Windows.Forms.Padding(4, 2, 12, 2);
            this.cmbMealWeek.Name = "cmbMealWeek";
            this.cmbMealWeek.Size = new System.Drawing.Size(134, 26);
            this.cmbMealWeek.TabIndex = 12;
            // 
            // lblSelectedMealDay
            // 
            this.lblSelectedMealDay.AutoSize = true;
            this.lblSelectedMealDay.Location = new System.Drawing.Point(0, 4);
            this.lblSelectedMealDay.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblSelectedMealDay.Name = "lblSelectedMealDay";
            this.lblSelectedMealDay.Size = new System.Drawing.Size(17, 18);
            this.lblSelectedMealDay.TabIndex = 13;
            this.lblSelectedMealDay.Text = "-";
            // 
            // tablePlanButtons
            // 
            this.tablePlanButtons.AutoSize = true;
            this.tablePlanButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePlanButtons.ColumnCount = 2;
            this.tablePlanButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePlanButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePlanButtons.Location = new System.Drawing.Point(677, 0);
            this.tablePlanButtons.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tablePlanButtons.Name = "tablePlanButtons";
            this.tablePlanButtons.RowCount = 1;
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePlanButtons.Size = new System.Drawing.Size(0, 0);
            this.tablePlanButtons.TabIndex = 19;
            // 
            // btnStartMealPlan
            // 
            this.btnStartMealPlan.AutoSize = true;
            this.btnStartMealPlan.Location = new System.Drawing.Point(0, 72);
            this.btnStartMealPlan.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartMealPlan.Name = "btnStartMealPlan";
            this.btnStartMealPlan.Size = new System.Drawing.Size(237, 28);
            this.btnStartMealPlan.TabIndex = 1;
            this.btnStartMealPlan.Text = "식단 계획 시작";
            this.btnStartMealPlan.UseVisualStyleBackColor = true;
            // 
            // planListRow
            // 
            this.planListRow.AutoSize = true;
            this.planListRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.planListRow.ColumnCount = 2;
            this.planListRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.planListRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.planListRow.Controls.Add(this.lstWeekMealPlans, 0, 0);
            this.planListRow.Controls.Add(this.tablePlanButtons, 1, 0);
            this.planListRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planListRow.Location = new System.Drawing.Point(0, 111);
            this.planListRow.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.planListRow.Name = "planListRow";
            this.planListRow.RowCount = 1;
            this.planListRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.planListRow.Size = new System.Drawing.Size(677, 1);
            this.planListRow.TabIndex = 20;
            // 
            // lstWeekMealPlans
            // 
            this.lstWeekMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstWeekMealPlans.FormattingEnabled = true;
            this.lstWeekMealPlans.ItemHeight = 18;
            this.lstWeekMealPlans.Location = new System.Drawing.Point(4, 2);
            this.lstWeekMealPlans.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstWeekMealPlans.Name = "lstWeekMealPlans";
            this.lstWeekMealPlans.Size = new System.Drawing.Size(657, 1);
            this.lstWeekMealPlans.TabIndex = 2;
            // 
            // flowMealPeriodRow
            // 
            this.flowMealPeriodRow.AutoSize = true;
            this.flowMealPeriodRow.Controls.Add(this.lblMealMonthTitle);
            this.flowMealPeriodRow.Controls.Add(this.dtpMealMonth);
            this.flowMealPeriodRow.Controls.Add(this.lblMealWeekTitle);
            this.flowMealPeriodRow.Controls.Add(this.cmbMealWeek);
            this.flowMealPeriodRow.Controls.Add(this.tableMealDaySelector);
            this.flowMealPeriodRow.Controls.Add(this.dtpMealDate);
            this.flowMealPeriodRow.Location = new System.Drawing.Point(0, 0);
            this.flowMealPeriodRow.Margin = new System.Windows.Forms.Padding(0);
            this.flowMealPeriodRow.Name = "flowMealPeriodRow";
            this.flowMealPeriodRow.Size = new System.Drawing.Size(628, 44);
            this.flowMealPeriodRow.TabIndex = 19;
            this.flowMealPeriodRow.WrapContents = false;
            // 
            // lblMealMonthTitle
            // 
            this.lblMealMonthTitle.AutoSize = true;
            this.lblMealMonthTitle.Location = new System.Drawing.Point(4, 6);
            this.lblMealMonthTitle.Margin = new System.Windows.Forms.Padding(4, 6, 0, 0);
            this.lblMealMonthTitle.Name = "lblMealMonthTitle";
            this.lblMealMonthTitle.Size = new System.Drawing.Size(68, 18);
            this.lblMealMonthTitle.TabIndex = 15;
            this.lblMealMonthTitle.Text = "식단 월";
            this.lblMealMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMealWeekTitle
            // 
            this.lblMealWeekTitle.AutoSize = true;
            this.lblMealWeekTitle.Location = new System.Drawing.Point(208, 6);
            this.lblMealWeekTitle.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblMealWeekTitle.Name = "lblMealWeekTitle";
            this.lblMealWeekTitle.Size = new System.Drawing.Size(44, 18);
            this.lblMealWeekTitle.TabIndex = 16;
            this.lblMealWeekTitle.Text = "주차";
            this.lblMealWeekTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableMealDaySelector
            // 
            this.tableMealDaySelector.AutoSize = true;
            this.tableMealDaySelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableMealDaySelector.ColumnCount = 1;
            this.tableMealDaySelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableMealDaySelector.Controls.Add(this.lblMealDayTitle, 0, 1);
            this.tableMealDaySelector.Controls.Add(this.lblSelectedMealDay, 0, 0);
            this.tableMealDaySelector.Location = new System.Drawing.Point(402, 2);
            this.tableMealDaySelector.Margin = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.tableMealDaySelector.Name = "tableMealDaySelector";
            this.tableMealDaySelector.RowCount = 2;
            this.tableMealDaySelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMealDaySelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMealDaySelector.Size = new System.Drawing.Size(26, 40);
            this.tableMealDaySelector.TabIndex = 18;
            // 
            // lblMealDayTitle
            // 
            this.lblMealDayTitle.AutoSize = true;
            this.lblMealDayTitle.Location = new System.Drawing.Point(0, 22);
            this.lblMealDayTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblMealDayTitle.Name = "lblMealDayTitle";
            this.lblMealDayTitle.Size = new System.Drawing.Size(44, 18);
            this.lblMealDayTitle.TabIndex = 17;
            this.lblMealDayTitle.Text = "요일";
            this.lblMealDayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowMealButtons
            // 
            this.flowMealButtons.AutoSize = true;
            this.flowMealButtons.Controls.Add(this.btnRegisterMealPlan);
            this.flowMealButtons.Controls.Add(this.btnRequestMealApproval);
            this.flowMealButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMealButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowMealButtons.Location = new System.Drawing.Point(4, 689);
            this.flowMealButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowMealButtons.Name = "flowMealButtons";
            this.flowMealButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowMealButtons.Size = new System.Drawing.Size(665, 42);
            this.flowMealButtons.TabIndex = 8;
            // 
            // flowMenuSortBar
            // 
            this.flowMenuSortBar.AutoSize = true;
            this.flowMenuSortBar.Controls.Add(this.cmbMenuSort);
            this.flowMenuSortBar.Controls.Add(this.lblAvailableMenus);
            this.flowMenuSortBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuSortBar.Location = new System.Drawing.Point(4, 167);
            this.flowMenuSortBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flowMenuSortBar.Name = "flowMenuSortBar";
            this.flowMenuSortBar.Size = new System.Drawing.Size(283, 25);
            this.flowMenuSortBar.TabIndex = 3;
            this.flowMenuSortBar.WrapContents = false;
            // 
            // lblAvailableMenus
            // 
            this.lblAvailableMenus.AutoSize = true;
            this.lblAvailableMenus.Location = new System.Drawing.Point(155, 4);
            this.lblAvailableMenus.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblAvailableMenus.Name = "lblAvailableMenus";
            this.lblAvailableMenus.Size = new System.Drawing.Size(86, 18);
            this.lblAvailableMenus.TabIndex = 1;
            this.lblAvailableMenus.Text = "메뉴 목록";
            this.lblAvailableMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowMenuTypeFilter
            // 
            this.flowMenuTypeFilter.AutoSize = true;
            this.flowMenuTypeFilter.Controls.Add(this.lblMenuTypeFilter);
            this.flowMenuTypeFilter.Controls.Add(this.cmbMenuTypeFilter);
            this.flowMenuTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMenuTypeFilter.Location = new System.Drawing.Point(4, 2);
            this.flowMenuTypeFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowMenuTypeFilter.Name = "flowMenuTypeFilter";
            this.flowMenuTypeFilter.Size = new System.Drawing.Size(283, 30);
            this.flowMenuTypeFilter.TabIndex = 0;
            this.flowMenuTypeFilter.WrapContents = false;
            // 
            // lblMenuTypeFilter
            // 
            this.lblMenuTypeFilter.AutoSize = true;
            this.lblMenuTypeFilter.Location = new System.Drawing.Point(4, 0);
            this.lblMenuTypeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblMenuTypeFilter.Name = "lblMenuTypeFilter";
            this.lblMenuTypeFilter.Size = new System.Drawing.Size(86, 18);
            this.lblMenuTypeFilter.TabIndex = 0;
            this.lblMenuTypeFilter.Text = "메뉴 종류";
            this.lblMenuTypeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowMealPeriodSelector
            // 
            this.flowMealPeriodSelector.ColumnCount = 1;
            this.flowMealPeriodSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowMealPeriodSelector.Controls.Add(this.flowMealPeriodRow, 0, 0);
            this.flowMealPeriodSelector.Controls.Add(this.planListRow, 0, 1);
            this.flowMealPeriodSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMealPeriodSelector.Location = new System.Drawing.Point(0, 0);
            this.flowMealPeriodSelector.Margin = new System.Windows.Forms.Padding(0);
            this.flowMealPeriodSelector.Name = "flowMealPeriodSelector";
            this.flowMealPeriodSelector.RowCount = 2;
            this.flowMealPeriodSelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.flowMealPeriodSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flowMealPeriodSelector.Size = new System.Drawing.Size(677, 105);
            this.flowMealPeriodSelector.TabIndex = 14;
            // 
            // grpPlanSelector
            // 
            this.grpPlanSelector.Controls.Add(this.tablePlanSelector);
            this.grpPlanSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPlanSelector.Location = new System.Drawing.Point(4, 2);
            this.grpPlanSelector.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpPlanSelector.Name = "grpPlanSelector";
            this.grpPlanSelector.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpPlanSelector.Size = new System.Drawing.Size(683, 130);
            this.grpPlanSelector.TabIndex = 18;
            this.grpPlanSelector.TabStop = false;
            this.grpPlanSelector.Text = "주차 및 계획 선택";
            // 
            // tablePlanSelector
            // 
            this.tablePlanSelector.ColumnCount = 1;
            this.tablePlanSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePlanSelector.Controls.Add(this.flowMealPeriodSelector, 0, 0);
            this.tablePlanSelector.Controls.Add(this.planListRow, 0, 1);
            this.tablePlanSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePlanSelector.Location = new System.Drawing.Point(3, 23);
            this.tablePlanSelector.Margin = new System.Windows.Forms.Padding(0);
            this.tablePlanSelector.Name = "tablePlanSelector";
            this.tablePlanSelector.RowCount = 2;
            this.tablePlanSelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablePlanSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePlanSelector.Size = new System.Drawing.Size(677, 105);
            this.tablePlanSelector.TabIndex = 0;
            // 
            // grpMealPlanDetail
            // 
            this.grpMealPlanDetail.Controls.Add(this.tableMealPlanDetail);
            this.grpMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealPlanDetail.Location = new System.Drawing.Point(0, 0);
            this.grpMealPlanDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpMealPlanDetail.Name = "grpMealPlanDetail";
            this.grpMealPlanDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpMealPlanDetail.Size = new System.Drawing.Size(681, 763);
            this.grpMealPlanDetail.TabIndex = 0;
            this.grpMealPlanDetail.TabStop = false;
            this.grpMealPlanDetail.Text = "식단 정보";
            // 
            // tableMealPlanDetail
            // 
            this.tableMealPlanDetail.ColumnCount = 1;
            this.tableMealPlanDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.Controls.Add(this.tableMealRecipeLists, 0, 0);
            this.tableMealPlanDetail.Controls.Add(this.lblMealNotes, 0, 1);
            this.tableMealPlanDetail.Controls.Add(this.txtMealNotes, 0, 2);
            this.tableMealPlanDetail.Controls.Add(this.flowMealButtons, 0, 3);
            this.tableMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealPlanDetail.Location = new System.Drawing.Point(4, 23);
            this.tableMealPlanDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableMealPlanDetail.Name = "tableMealPlanDetail";
            this.tableMealPlanDetail.RowCount = 4;
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableMealPlanDetail.Size = new System.Drawing.Size(673, 738);
            this.tableMealPlanDetail.TabIndex = 0;
            // 
            // tableMealRecipeLists
            // 
            this.tableMealRecipeLists.ColumnCount = 2;
            this.tableMealRecipeLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableMealRecipeLists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableMealRecipeLists.Controls.Add(this.tableMenuLibrary, 0, 0);
            this.tableMealRecipeLists.Controls.Add(this.tableMealBuilder, 1, 0);
            this.tableMealRecipeLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealRecipeLists.Location = new System.Drawing.Point(4, 2);
            this.tableMealRecipeLists.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableMealRecipeLists.Name = "tableMealRecipeLists";
            this.tableMealRecipeLists.RowCount = 1;
            this.tableMealRecipeLists.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealRecipeLists.Size = new System.Drawing.Size(665, 556);
            this.tableMealRecipeLists.TabIndex = 5;
            // 
            // tableMenuLibrary
            // 
            this.tableMenuLibrary.ColumnCount = 1;
            this.tableMenuLibrary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuLibrary.Controls.Add(this.flowMenuTypeFilter, 0, 0);
            this.tableMenuLibrary.Controls.Add(this.btnResetMenuFilter, 0, 1);
            this.tableMenuLibrary.Controls.Add(this.lblMenuTags, 0, 2);
            this.tableMenuLibrary.Controls.Add(this.clbMenuTags, 0, 3);
            this.tableMenuLibrary.Controls.Add(this.flowMenuSortBar, 0, 4);
            this.tableMenuLibrary.Controls.Add(this.lstAvailableMenus, 0, 5);
            this.tableMenuLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMenuLibrary.Location = new System.Drawing.Point(4, 2);
            this.tableMenuLibrary.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableMenuLibrary.Name = "tableMenuLibrary";
            this.tableMenuLibrary.RowCount = 6;
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMenuLibrary.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMenuLibrary.Size = new System.Drawing.Size(291, 552);
            this.tableMenuLibrary.TabIndex = 0;
            // 
            // lblMenuTags
            // 
            this.lblMenuTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenuTags.Location = new System.Drawing.Point(4, 68);
            this.lblMenuTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMenuTags.Name = "lblMenuTags";
            this.lblMenuTags.Size = new System.Drawing.Size(283, 25);
            this.lblMenuTags.TabIndex = 1;
            this.lblMenuTags.Text = "태그 필터";
            this.lblMenuTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstAvailableMenus
            // 
            this.lstAvailableMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAvailableMenus.FormattingEnabled = true;
            this.lstAvailableMenus.ItemHeight = 18;
            this.lstAvailableMenus.Location = new System.Drawing.Point(4, 194);
            this.lstAvailableMenus.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lstAvailableMenus.Name = "lstAvailableMenus";
            this.lstAvailableMenus.Size = new System.Drawing.Size(283, 356);
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
            this.tableMealBuilder.Location = new System.Drawing.Point(303, 2);
            this.tableMealBuilder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableMealBuilder.Name = "tableMealBuilder";
            this.tableMealBuilder.RowCount = 4;
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableMealBuilder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableMealBuilder.Size = new System.Drawing.Size(358, 552);
            this.tableMealBuilder.TabIndex = 1;
            // 
            // lblSelectedMenus
            // 
            this.lblSelectedMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedMenus.Location = new System.Drawing.Point(4, 0);
            this.lblSelectedMenus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedMenus.Name = "lblSelectedMenus";
            this.lblSelectedMenus.Size = new System.Drawing.Size(350, 25);
            this.lblSelectedMenus.TabIndex = 1;
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
            this.lvMealBoard.Location = new System.Drawing.Point(4, 27);
            this.lvMealBoard.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvMealBoard.MultiSelect = false;
            this.lvMealBoard.Name = "lvMealBoard";
            this.lvMealBoard.Size = new System.Drawing.Size(350, 297);
            this.lvMealBoard.TabIndex = 1;
            this.lvMealBoard.UseCompatibleStateImageBehavior = false;
            this.lvMealBoard.View = System.Windows.Forms.View.Details;
            // 
            // lblNutrientSummary
            // 
            this.lblNutrientSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientSummary.Location = new System.Drawing.Point(4, 326);
            this.lblNutrientSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutrientSummary.Name = "lblNutrientSummary";
            this.lblNutrientSummary.Size = new System.Drawing.Size(350, 25);
            this.lblNutrientSummary.TabIndex = 2;
            this.lblNutrientSummary.Text = "필수 영양소 충족 현황";
            this.lblNutrientSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMealNotes
            // 
            this.lblMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealNotes.Location = new System.Drawing.Point(4, 564);
            this.lblMealNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.lblMealNotes.Name = "lblMealNotes";
            this.lblMealNotes.Size = new System.Drawing.Size(665, 21);
            this.lblMealNotes.TabIndex = 6;
            this.lblMealNotes.Text = "비고";
            this.lblMealNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMealNotes
            // 
            this.txtMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMealNotes.Location = new System.Drawing.Point(4, 587);
            this.txtMealNotes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtMealNotes.Multiline = true;
            this.txtMealNotes.Name = "txtMealNotes";
            this.txtMealNotes.Size = new System.Drawing.Size(665, 98);
            this.txtMealNotes.TabIndex = 7;
            // 
            // splitContainerMealPlans
            // 
            this.splitContainerMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMealPlans.Location = new System.Drawing.Point(4, 2);
            this.splitContainerMealPlans.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerMealPlans.Name = "splitContainerMealPlans";
            // 
            // splitContainerMealPlans.Panel1
            // 
            this.splitContainerMealPlans.Panel1.Controls.Add(this.grpMealSchedule);
            // 
            // splitContainerMealPlans.Panel2
            // 
            this.splitContainerMealPlans.Panel2.Controls.Add(this.grpMealPlanDetail);
            this.splitContainerMealPlans.Size = new System.Drawing.Size(1385, 763);
            this.splitContainerMealPlans.SplitterDistance = 699;
            this.splitContainerMealPlans.SplitterWidth = 5;
            this.splitContainerMealPlans.TabIndex = 0;
            // grpMealSchedule
            // 
            this.grpMealSchedule.Controls.Add(this.tableMealSchedule);
            this.grpMealSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealSchedule.Location = new System.Drawing.Point(0, 0);
            this.grpMealSchedule.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpMealSchedule.Name = "grpMealSchedule";
            this.grpMealSchedule.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpMealSchedule.Size = new System.Drawing.Size(699, 763);
            this.grpMealSchedule.TabIndex = 0;
            this.grpMealSchedule.TabStop = false;
            this.grpMealSchedule.Text = "주간 식단 현황";
            // 
            // tableMealSchedule
            // 
            this.tableMealSchedule.ColumnCount = 1;
            this.tableMealSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealSchedule.Controls.Add(this.grpPlanSelector, 0, 0);
            this.tableMealSchedule.Controls.Add(this.dgvWeeklyMeals, 0, 3);
            this.tableMealSchedule.Controls.Add(this.grpAllergyStatus, 0, 4);
            this.tableMealSchedule.Controls.Add(this.lblWeeklyMeals, 0, 2);
            this.tableMealSchedule.Controls.Add(this.lblMealPlanStatus, 0, 1);
            this.tableMealSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealSchedule.Location = new System.Drawing.Point(4, 23);
            this.tableMealSchedule.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableMealSchedule.Name = "tableMealSchedule";
            this.tableMealSchedule.RowCount = 5;
            this.tableMealSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMealSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableMealSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableMealSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableMealSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableMealSchedule.Size = new System.Drawing.Size(691, 738);
            this.tableMealSchedule.TabIndex = 0;
            // 
            // dgvWeeklyMeals
            // 
            this.dgvWeeklyMeals.AllowUserToAddRows = false;
            this.dgvWeeklyMeals.AllowUserToDeleteRows = false;
            this.dgvWeeklyMeals.AllowUserToResizeColumns = false;
            this.dgvWeeklyMeals.AllowUserToResizeRows = false;
            this.dgvWeeklyMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWeeklyMeals.BackgroundColor = System.Drawing.Color.White;
            this.dgvWeeklyMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeklyMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWeekMonday,
            this.colWeekTuesday,
            this.colWeekWednesday,
            this.colWeekThursday,
            this.colWeekFriday});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeeklyMeals.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWeeklyMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeeklyMeals.Location = new System.Drawing.Point(4, 190);
            this.dgvWeeklyMeals.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvWeeklyMeals.MultiSelect = false;
            this.dgvWeeklyMeals.Name = "dgvWeeklyMeals";
            this.dgvWeeklyMeals.ReadOnly = true;
            this.dgvWeeklyMeals.RowHeadersVisible = false;
            this.dgvWeeklyMeals.RowHeadersWidth = 62;
            this.dgvWeeklyMeals.RowTemplate.Height = 80;
            this.dgvWeeklyMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvWeeklyMeals.Size = new System.Drawing.Size(683, 381);
            this.dgvWeeklyMeals.TabIndex = 2;
            // 
            // colWeekMonday
            // 
            this.colWeekMonday.HeaderText = "월";
            this.colWeekMonday.MinimumWidth = 8;
            this.colWeekMonday.Name = "colWeekMonday";
            this.colWeekMonday.ReadOnly = true;
            // 
            // colWeekTuesday
            // 
            this.colWeekTuesday.HeaderText = "화";
            this.colWeekTuesday.MinimumWidth = 8;
            this.colWeekTuesday.Name = "colWeekTuesday";
            this.colWeekTuesday.ReadOnly = true;
            // 
            // colWeekWednesday
            // 
            this.colWeekWednesday.HeaderText = "수";
            this.colWeekWednesday.MinimumWidth = 8;
            this.colWeekWednesday.Name = "colWeekWednesday";
            this.colWeekWednesday.ReadOnly = true;
            // 
            // colWeekThursday
            // 
            this.colWeekThursday.HeaderText = "목";
            this.colWeekThursday.MinimumWidth = 8;
            this.colWeekThursday.Name = "colWeekThursday";
            this.colWeekThursday.ReadOnly = true;
            // 
            // colWeekFriday
            // 
            this.colWeekFriday.HeaderText = "금";
            this.colWeekFriday.MinimumWidth = 8;
            this.colWeekFriday.Name = "colWeekFriday";
            this.colWeekFriday.ReadOnly = true;
            // 
            // grpAllergyStatus
            // 
            this.grpAllergyStatus.Controls.Add(this.lvAllergyAlerts);
            this.grpAllergyStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyStatus.Location = new System.Drawing.Point(3, 576);
            this.grpAllergyStatus.Name = "grpAllergyStatus";
            this.grpAllergyStatus.Size = new System.Drawing.Size(685, 159);
            this.grpAllergyStatus.TabIndex = 4;
            this.grpAllergyStatus.TabStop = false;
            this.grpAllergyStatus.Text = "알레르기 경고";
            // 
            // lvAllergyAlerts
            // 
            this.lvAllergyAlerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAllergyName,
            this.colAllergyMenus,
            this.colAllergyRiskCount,
            this.colAllergyAltCount,
            this.colAllergyAltSummary});
            this.lvAllergyAlerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAllergyAlerts.FullRowSelect = true;
            this.lvAllergyAlerts.HideSelection = false;
            this.lvAllergyAlerts.Location = new System.Drawing.Point(3, 24);
            this.lvAllergyAlerts.MultiSelect = false;
            this.lvAllergyAlerts.Name = "lvAllergyAlerts";
            this.lvAllergyAlerts.Size = new System.Drawing.Size(679, 132);
            this.lvAllergyAlerts.TabIndex = 0;
            this.lvAllergyAlerts.UseCompatibleStateImageBehavior = false;
            this.lvAllergyAlerts.View = System.Windows.Forms.View.Details;
            // 
            // colAllergyName
            // 
            this.colAllergyName.Text = "알레르기";
            this.colAllergyName.Width = 120;
            // 
            // colAllergyMenus
            // 
            this.colAllergyMenus.Text = "문제 메뉴";
            this.colAllergyMenus.Width = 220;
            // 
            // colAllergyRiskCount
            // 
            this.colAllergyRiskCount.Text = "위험 인원";
            this.colAllergyRiskCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAllergyRiskCount.Width = 90;
            // 
            // colAllergyAltCount
            // 
            this.colAllergyAltCount.Text = "대체 필요";
            this.colAllergyAltCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAllergyAltCount.Width = 100;
            // 
            // colAllergyAltSummary
            // 
            this.colAllergyAltSummary.Text = "대체 메뉴";
            this.colAllergyAltSummary.Width = 200;
            // 
            // lblMealPlanStatus
            // 
            this.lblMealPlanStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealPlanStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblMealPlanStatus.Location = new System.Drawing.Point(4, 134);
            this.lblMealPlanStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.lblMealPlanStatus.Name = "lblMealPlanStatus";
            this.lblMealPlanStatus.Size = new System.Drawing.Size(683, 22);
            this.lblMealPlanStatus.TabIndex = 17;
            this.lblMealPlanStatus.Text = "계획 상태: -";
            this.lblMealPlanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeeklyMeals
            // 
            this.lblWeeklyMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeeklyMeals.Location = new System.Drawing.Point(4, 160);
            this.lblWeeklyMeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyMeals.Name = "lblWeeklyMeals";
            this.lblWeeklyMeals.Size = new System.Drawing.Size(683, 28);
            this.lblWeeklyMeals.TabIndex = 1;
            this.lblWeeklyMeals.Text = "주간 식단표";
            this.lblWeeklyMeals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteMealPlan
            // 
            this.btnDeleteMealPlan.Enabled = false;
            this.btnDeleteMealPlan.Location = new System.Drawing.Point(0, 44);
            this.btnDeleteMealPlan.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.btnDeleteMealPlan.Name = "btnDeleteMealPlan";
            this.btnDeleteMealPlan.Size = new System.Drawing.Size(237, 28);
            this.btnDeleteMealPlan.TabIndex = 0;
            this.btnDeleteMealPlan.Text = "식단 계획 삭제";
            this.btnDeleteMealPlan.UseVisualStyleBackColor = true;
            // 
            // MealPlansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1393, 767);
            this.Controls.Add(this.splitContainerMealPlans);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MealPlansForm";
            this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Text = "MealPlansForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealNutrition)).EndInit();
            this.planListRow.ResumeLayout(false);
            this.planListRow.PerformLayout();
            this.flowMealPeriodRow.ResumeLayout(false);
            this.flowMealPeriodRow.PerformLayout();
            this.tableMealDaySelector.ResumeLayout(false);
            this.tableMealDaySelector.PerformLayout();
            this.flowMealButtons.ResumeLayout(false);
            this.flowMenuSortBar.ResumeLayout(false);
            this.flowMenuSortBar.PerformLayout();
            this.flowMenuTypeFilter.ResumeLayout(false);
            this.flowMenuTypeFilter.PerformLayout();
            this.flowMealPeriodSelector.ResumeLayout(false);
            this.flowMealPeriodSelector.PerformLayout();
            this.grpPlanSelector.ResumeLayout(false);
            this.tablePlanSelector.ResumeLayout(false);
            this.tablePlanSelector.PerformLayout();
            this.grpMealPlanDetail.ResumeLayout(false);
            this.tableMealPlanDetail.ResumeLayout(false);
            this.tableMealPlanDetail.PerformLayout();
            this.tableMealRecipeLists.ResumeLayout(false);
            this.tableMenuLibrary.ResumeLayout(false);
            this.tableMenuLibrary.PerformLayout();
            this.tableMealBuilder.ResumeLayout(false);
            this.splitContainerMealPlans.Panel1.ResumeLayout(false);
            this.splitContainerMealPlans.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).EndInit();
            this.splitContainerMealPlans.ResumeLayout(false);
            this.grpMealSchedule.ResumeLayout(false);
            this.tableMealSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeklyMeals)).EndInit();
            this.grpAllergyStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.Button btnRegisterMealPlan;
        internal System.Windows.Forms.Button btnResetMenuFilter;
        internal System.Windows.Forms.Button btnRequestMealApproval;
        internal System.Windows.Forms.Button btnStartMealPlan;
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
        internal System.Windows.Forms.DateTimePicker dtpMealDate;
        internal System.Windows.Forms.FlowLayoutPanel flowMealButtons;
        internal System.Windows.Forms.FlowLayoutPanel flowMenuSortBar;
        internal System.Windows.Forms.FlowLayoutPanel flowMenuTypeFilter;
        internal System.Windows.Forms.TableLayoutPanel flowMealPeriodSelector;
        internal System.Windows.Forms.FlowLayoutPanel flowMealPeriodRow;
        internal System.Windows.Forms.TableLayoutPanel planListRow;
        internal System.Windows.Forms.GroupBox grpPlanSelector;
        internal System.Windows.Forms.TableLayoutPanel tablePlanSelector;
        internal System.Windows.Forms.GroupBox grpMealPlanDetail;
        internal System.Windows.Forms.Label lblAvailableMenus;
        internal System.Windows.Forms.Label lblMealNotes;
        internal System.Windows.Forms.Label lblMenuTags;
        internal System.Windows.Forms.Label lblMenuTypeFilter;
        internal System.Windows.Forms.Label lblNutrientSummary;
        internal System.Windows.Forms.Label lblSelectedMenus;
        internal System.Windows.Forms.ListBox lstAvailableMenus;
        internal System.Windows.Forms.ListView lvMealBoard;
        internal System.Windows.Forms.GroupBox grpAllergyStatus;
        internal System.Windows.Forms.ListView lvAllergyAlerts;
        internal System.Windows.Forms.SplitContainer splitContainerMealPlans;
        internal System.Windows.Forms.TableLayoutPanel tableMealBuilder;
        internal System.Windows.Forms.TableLayoutPanel tableMealPlanDetail;
        internal System.Windows.Forms.TableLayoutPanel tableMealRecipeLists;
        internal System.Windows.Forms.TableLayoutPanel tableMenuLibrary;
        internal System.Windows.Forms.TextBox txtMealNotes;
        internal System.Windows.Forms.DateTimePicker dtpMealMonth;
        internal System.Windows.Forms.ComboBox cmbMealWeek;
        internal System.Windows.Forms.ListBox lstWeekMealPlans;
        internal System.Windows.Forms.TableLayoutPanel tablePlanButtons;
        internal System.Windows.Forms.Label lblSelectedMealDay;
        internal System.Windows.Forms.DataGridView dgvWeeklyMeals;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colWeekMonday;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colWeekTuesday;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colWeekWednesday;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colWeekThursday;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colWeekFriday;
        internal System.Windows.Forms.ColumnHeader colAllergyName;
        internal System.Windows.Forms.ColumnHeader colAllergyMenus;
        internal System.Windows.Forms.ColumnHeader colAllergyRiskCount;
        internal System.Windows.Forms.ColumnHeader colAllergyAltCount;
        internal System.Windows.Forms.ColumnHeader colAllergyAltSummary;
        internal System.Windows.Forms.Label lblMealMonthTitle;
        internal System.Windows.Forms.Label lblMealWeekTitle;
        internal System.Windows.Forms.TableLayoutPanel tableMealDaySelector;
        internal System.Windows.Forms.GroupBox grpMealSchedule;
        internal System.Windows.Forms.TableLayoutPanel tableMealSchedule;
        internal System.Windows.Forms.Label lblMealDayTitle;
        internal System.Windows.Forms.Button btnDeleteMealPlan;
        internal System.Windows.Forms.Label lblWeeklyMeals;
        internal System.Windows.Forms.Label lblMealPlanStatus;
    }
}
