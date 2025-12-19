namespace nutritionist.Tabs
{
    partial class NutritionDashboardControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.layoutDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblCurrentServeDate = new System.Windows.Forms.Label();
            this.lblServeDateTitle = new System.Windows.Forms.Label();
            this.lblNotMealValue = new System.Windows.Forms.Label();
            this.lblNotMeal = new System.Windows.Forms.Label();
            this.lblTodayMealValue = new System.Windows.Forms.Label();
            this.lblTodayMeal = new System.Windows.Forms.Label();
            this.lblTotalStudentValue = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.grpTodayMeals = new System.Windows.Forms.GroupBox();
            this.dgvTodayMealBoard = new System.Windows.Forms.DataGridView();
            this.colTodayMealBoard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTodayRaw = new System.Windows.Forms.GroupBox();
            this.lvTodayRawNeeds = new System.Windows.Forms.ListView();
            this.grpShortage = new System.Windows.Forms.GroupBox();
            this.lvShortageRaw = new System.Windows.Forms.ListView();
            this.grpMealLogs = new System.Windows.Forms.GroupBox();
            this.lvMealLogs = new System.Windows.Forms.ListView();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.lvRawMaterials = new System.Windows.Forms.ListView();
            this.grpMenus = new System.Windows.Forms.GroupBox();
            this.lvMenus = new System.Windows.Forms.ListView();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            this.btnServeMeal = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.layoutDashboard.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpTodayMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMealBoard)).BeginInit();
            this.grpTodayRaw.SuspendLayout();
            this.grpShortage.SuspendLayout();
            this.grpMealLogs.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.grpMenus.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutDashboard
            // 
            this.layoutDashboard.ColumnCount = 2;
            this.layoutDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDashboard.Controls.Add(this.grpSummary, 0, 0);
            this.layoutDashboard.Controls.Add(this.grpTodayMeals, 0, 1);
            this.layoutDashboard.Controls.Add(this.grpTodayRaw, 1, 1);
            this.layoutDashboard.Controls.Add(this.grpShortage, 0, 2);
            this.layoutDashboard.Controls.Add(this.grpMealLogs, 1, 2);
            this.layoutDashboard.Controls.Add(this.grpStudents, 0, 3);
            this.layoutDashboard.Controls.Add(this.grpMenus, 1, 3);
            this.layoutDashboard.Controls.Add(this.grpAction, 0, 4);
            this.layoutDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDashboard.Location = new System.Drawing.Point(3, 2);
            this.layoutDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDashboard.Name = "layoutDashboard";
            this.layoutDashboard.RowCount = 5;
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.layoutDashboard.Size = new System.Drawing.Size(944, 496);
            this.layoutDashboard.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.layoutDashboard.SetColumnSpan(this.grpSummary, 2);
            this.grpSummary.Controls.Add(this.lblCurrentServeDate);
            this.grpSummary.Controls.Add(this.lblServeDateTitle);
            this.grpSummary.Controls.Add(this.lblNotMealValue);
            this.grpSummary.Controls.Add(this.lblNotMeal);
            this.grpSummary.Controls.Add(this.lblTodayMealValue);
            this.grpSummary.Controls.Add(this.lblTodayMeal);
            this.grpSummary.Controls.Add(this.lblTotalStudentValue);
            this.grpSummary.Controls.Add(this.lblTotalStudent);
            this.grpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpSummary.Location = new System.Drawing.Point(3, 2);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(938, 76);
            this.grpSummary.TabIndex = 0;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "급식 현황";
            // 
            // lblCurrentServeDate
            // 
            this.lblCurrentServeDate.AutoSize = true;
            this.lblCurrentServeDate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentServeDate.Location = new System.Drawing.Point(82, 32);
            this.lblCurrentServeDate.Name = "lblCurrentServeDate";
            this.lblCurrentServeDate.Size = new System.Drawing.Size(60, 28);
            this.lblCurrentServeDate.TabIndex = 7;
            this.lblCurrentServeDate.Text = "0000";
            // 
            // lblServeDateTitle
            // 
            this.lblServeDateTitle.AutoSize = true;
            this.lblServeDateTitle.Location = new System.Drawing.Point(18, 35);
            this.lblServeDateTitle.Name = "lblServeDateTitle";
            this.lblServeDateTitle.Size = new System.Drawing.Size(94, 25);
            this.lblServeDateTitle.TabIndex = 6;
            this.lblServeDateTitle.Text = "기준 일자:";
            // 
            // lblNotMealValue
            // 
            this.lblNotMealValue.AutoSize = true;
            this.lblNotMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotMealValue.Location = new System.Drawing.Point(768, 32);
            this.lblNotMealValue.Name = "lblNotMealValue";
            this.lblNotMealValue.Size = new System.Drawing.Size(24, 28);
            this.lblNotMealValue.TabIndex = 5;
            this.lblNotMealValue.Text = "0";
            // 
            // lblNotMeal
            // 
            this.lblNotMeal.AutoSize = true;
            this.lblNotMeal.Location = new System.Drawing.Point(650, 35);
            this.lblNotMeal.Name = "lblNotMeal";
            this.lblNotMeal.Size = new System.Drawing.Size(154, 25);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "발주 대기 원재료:";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.AutoSize = true;
            this.lblTodayMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayMealValue.Location = new System.Drawing.Point(520, 32);
            this.lblTodayMealValue.Name = "lblTodayMealValue";
            this.lblTodayMealValue.Size = new System.Drawing.Size(24, 28);
            this.lblTodayMealValue.TabIndex = 3;
            this.lblTodayMealValue.Text = "0";
            // 
            // lblTodayMeal
            // 
            this.lblTodayMeal.AutoSize = true;
            this.lblTodayMeal.Location = new System.Drawing.Point(403, 35);
            this.lblTodayMeal.Name = "lblTodayMeal";
            this.lblTodayMeal.Size = new System.Drawing.Size(142, 25);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "승인 대기 식단 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.AutoSize = true;
            this.lblTotalStudentValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentValue.Location = new System.Drawing.Point(289, 32);
            this.lblTotalStudentValue.Name = "lblTotalStudentValue";
            this.lblTotalStudentValue.Size = new System.Drawing.Size(24, 28);
            this.lblTotalStudentValue.TabIndex = 1;
            this.lblTotalStudentValue.Text = "0";
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Location = new System.Drawing.Point(186, 35);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(128, 25);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "오늘 식단(건) :";
            // 
            // grpTodayMeals
            // 
            this.grpTodayMeals.Controls.Add(this.dgvTodayMealBoard);
            this.grpTodayMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayMeals.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpTodayMeals.Location = new System.Drawing.Point(3, 82);
            this.grpTodayMeals.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpTodayMeals.Name = "grpTodayMeals";
            this.grpTodayMeals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayMeals.Size = new System.Drawing.Size(463, 97);
            this.grpTodayMeals.TabIndex = 1;
            this.grpTodayMeals.TabStop = false;
            this.grpTodayMeals.Text = "오늘의 식단";
            // 
            // dgvTodayMealBoard
            // 
            this.dgvTodayMealBoard.AllowUserToAddRows = false;
            this.dgvTodayMealBoard.AllowUserToDeleteRows = false;
            this.dgvTodayMealBoard.AllowUserToResizeColumns = false;
            this.dgvTodayMealBoard.AllowUserToResizeRows = false;
            this.dgvTodayMealBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayMealBoard.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodayMealBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayMealBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTodayMealBoard});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayMealBoard.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodayMealBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayMealBoard.Location = new System.Drawing.Point(3, 26);
            this.dgvTodayMealBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayMealBoard.MultiSelect = false;
            this.dgvTodayMealBoard.Name = "dgvTodayMealBoard";
            this.dgvTodayMealBoard.ReadOnly = true;
            this.dgvTodayMealBoard.RowHeadersVisible = false;
            this.dgvTodayMealBoard.RowHeadersWidth = 62;
            this.dgvTodayMealBoard.RowTemplate.Height = 80;
            this.dgvTodayMealBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTodayMealBoard.Size = new System.Drawing.Size(457, 69);
            this.dgvTodayMealBoard.TabIndex = 0;
            // 
            // colTodayMealBoard
            // 
            this.colTodayMealBoard.HeaderText = "오늘의 식단";
            this.colTodayMealBoard.MinimumWidth = 8;
            this.colTodayMealBoard.Name = "colTodayMealBoard";
            this.colTodayMealBoard.ReadOnly = true;
            // 
            // grpTodayRaw
            // 
            this.grpTodayRaw.Controls.Add(this.lvTodayRawNeeds);
            this.grpTodayRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayRaw.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpTodayRaw.Location = new System.Drawing.Point(478, 82);
            this.grpTodayRaw.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpTodayRaw.Name = "grpTodayRaw";
            this.grpTodayRaw.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayRaw.Size = new System.Drawing.Size(463, 97);
            this.grpTodayRaw.TabIndex = 2;
            this.grpTodayRaw.TabStop = false;
            this.grpTodayRaw.Text = "오늘 필요한 원재료";
            // 
            // lvTodayRawNeeds
            // 
            this.lvTodayRawNeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTodayRawNeeds.FullRowSelect = true;
            this.lvTodayRawNeeds.HideSelection = false;
            this.lvTodayRawNeeds.Location = new System.Drawing.Point(3, 26);
            this.lvTodayRawNeeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvTodayRawNeeds.MultiSelect = false;
            this.lvTodayRawNeeds.Name = "lvTodayRawNeeds";
            this.lvTodayRawNeeds.Size = new System.Drawing.Size(457, 69);
            this.lvTodayRawNeeds.TabIndex = 0;
            this.lvTodayRawNeeds.UseCompatibleStateImageBehavior = false;
            this.lvTodayRawNeeds.View = System.Windows.Forms.View.Details;
            // 
            // grpShortage
            // 
            this.grpShortage.Controls.Add(this.lvShortageRaw);
            this.grpShortage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShortage.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpShortage.Location = new System.Drawing.Point(3, 183);
            this.grpShortage.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpShortage.Name = "grpShortage";
            this.grpShortage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShortage.Size = new System.Drawing.Size(463, 98);
            this.grpShortage.TabIndex = 3;
            this.grpShortage.TabStop = false;
            this.grpShortage.Text = "발주 대기 / 부족 원재료";
            // 
            // lvShortageRaw
            // 
            this.lvShortageRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShortageRaw.FullRowSelect = true;
            this.lvShortageRaw.HideSelection = false;
            this.lvShortageRaw.Location = new System.Drawing.Point(3, 26);
            this.lvShortageRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvShortageRaw.MultiSelect = false;
            this.lvShortageRaw.Name = "lvShortageRaw";
            this.lvShortageRaw.Size = new System.Drawing.Size(457, 70);
            this.lvShortageRaw.TabIndex = 0;
            this.lvShortageRaw.UseCompatibleStateImageBehavior = false;
            this.lvShortageRaw.View = System.Windows.Forms.View.Details;
            // 
            // grpMealLogs
            // 
            this.grpMealLogs.Controls.Add(this.lvMealLogs);
            this.grpMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealLogs.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpMealLogs.Location = new System.Drawing.Point(478, 183);
            this.grpMealLogs.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpMealLogs.Name = "grpMealLogs";
            this.grpMealLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Size = new System.Drawing.Size(463, 98);
            this.grpMealLogs.TabIndex = 4;
            this.grpMealLogs.TabStop = false;
            this.grpMealLogs.Text = "식단 계획 승인 현황";
            // 
            // lvMealLogs
            // 
            this.lvMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMealLogs.FullRowSelect = true;
            this.lvMealLogs.HideSelection = false;
            this.lvMealLogs.Location = new System.Drawing.Point(3, 26);
            this.lvMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMealLogs.MultiSelect = false;
            this.lvMealLogs.Name = "lvMealLogs";
            this.lvMealLogs.Size = new System.Drawing.Size(457, 70);
            this.lvMealLogs.TabIndex = 0;
            this.lvMealLogs.UseCompatibleStateImageBehavior = false;
            this.lvMealLogs.View = System.Windows.Forms.View.Details;
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.lvRawMaterials);
            this.grpStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudents.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpStudents.Location = new System.Drawing.Point(3, 285);
            this.grpStudents.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Size = new System.Drawing.Size(463, 97);
            this.grpStudents.TabIndex = 5;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "원재료 목록";
            // 
            // lvRawMaterials
            // 
            this.lvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRawMaterials.FullRowSelect = true;
            this.lvRawMaterials.HideSelection = false;
            this.lvRawMaterials.Location = new System.Drawing.Point(3, 26);
            this.lvRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvRawMaterials.MultiSelect = false;
            this.lvRawMaterials.Name = "lvRawMaterials";
            this.lvRawMaterials.Size = new System.Drawing.Size(457, 69);
            this.lvRawMaterials.TabIndex = 0;
            this.lvRawMaterials.UseCompatibleStateImageBehavior = false;
            this.lvRawMaterials.View = System.Windows.Forms.View.Details;
            // 
            // grpMenus
            // 
            this.grpMenus.Controls.Add(this.lvMenus);
            this.grpMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMenus.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpMenus.Location = new System.Drawing.Point(478, 285);
            this.grpMenus.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpMenus.Name = "grpMenus";
            this.grpMenus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Size = new System.Drawing.Size(463, 97);
            this.grpMenus.TabIndex = 6;
            this.grpMenus.TabStop = false;
            this.grpMenus.Text = "최종 메뉴";
            // 
            // lvMenus
            // 
            this.lvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMenus.FullRowSelect = true;
            this.lvMenus.HideSelection = false;
            this.lvMenus.Location = new System.Drawing.Point(3, 26);
            this.lvMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMenus.MultiSelect = false;
            this.lvMenus.Name = "lvMenus";
            this.lvMenus.Size = new System.Drawing.Size(457, 69);
            this.lvMenus.TabIndex = 0;
            this.lvMenus.UseCompatibleStateImageBehavior = false;
            this.lvMenus.View = System.Windows.Forms.View.Details;
            // 
            // grpAction
            // 
            this.layoutDashboard.SetColumnSpan(this.grpAction, 2);
            this.grpAction.Controls.Add(this.btnCancelMeal);
            this.grpAction.Controls.Add(this.btnServeMeal);
            this.grpAction.Controls.Add(this.txtStudentId);
            this.grpAction.Controls.Add(this.lblStudentId);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAction.Enabled = false;
            this.grpAction.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.grpAction.Location = new System.Drawing.Point(3, 386);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Size = new System.Drawing.Size(938, 108);
            this.grpAction.TabIndex = 7;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "업무 작업";
            this.grpAction.Visible = false;
            this.grpAction.Enter += new System.EventHandler(this.grpAction_Enter);
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelMeal.Location = new System.Drawing.Point(170, 57);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(120, 32);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "발주 요청 등록";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            this.btnCancelMeal.Visible = false;
            this.btnCancelMeal.Click += new System.EventHandler(this.btnCancelMeal_Click);
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnServeMeal.Location = new System.Drawing.Point(219, 32);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(120, 32);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "식단 계획 등록";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            this.btnServeMeal.Visible = false;
            this.btnServeMeal.Click += new System.EventHandler(this.btnServeMeal_Click);
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStudentId.Location = new System.Drawing.Point(125, 29);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(190, 31);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TabStop = false;
            this.txtStudentId.Visible = false;
            this.txtStudentId.TextChanged += new System.EventHandler(this.txtStudentId_TextChanged);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(21, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(112, 25);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "선택 원재료:";
            this.lblStudentId.Visible = false;
            // 
            // NutritionDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutDashboard);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "NutritionDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(950, 500);
            this.layoutDashboard.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpTodayMeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMealBoard)).EndInit();
            this.grpTodayRaw.ResumeLayout(false);
            this.grpShortage.ResumeLayout(false);
            this.grpMealLogs.ResumeLayout(false);
            this.grpStudents.ResumeLayout(false);
            this.grpMenus.ResumeLayout(false);
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel layoutDashboard;
        internal System.Windows.Forms.GroupBox grpSummary;
        internal System.Windows.Forms.Label lblCurrentServeDate;
        internal System.Windows.Forms.Label lblServeDateTitle;
        internal System.Windows.Forms.Label lblNotMealValue;
        internal System.Windows.Forms.Label lblNotMeal;
        internal System.Windows.Forms.Label lblTodayMealValue;
        internal System.Windows.Forms.Label lblTodayMeal;
        internal System.Windows.Forms.Label lblTotalStudentValue;
        internal System.Windows.Forms.Label lblTotalStudent;
        internal System.Windows.Forms.GroupBox grpTodayMeals;
        internal System.Windows.Forms.DataGridView dgvTodayMealBoard;
        internal System.Windows.Forms.DataGridViewTextBoxColumn colTodayMealBoard;
        internal System.Windows.Forms.GroupBox grpTodayRaw;
        internal System.Windows.Forms.ListView lvTodayRawNeeds;
        internal System.Windows.Forms.GroupBox grpShortage;
        internal System.Windows.Forms.ListView lvShortageRaw;
        internal System.Windows.Forms.GroupBox grpMealLogs;
        internal System.Windows.Forms.ListView lvMealLogs;
        internal System.Windows.Forms.GroupBox grpStudents;
        internal System.Windows.Forms.ListView lvRawMaterials;
        internal System.Windows.Forms.GroupBox grpMenus;
        internal System.Windows.Forms.ListView lvMenus;
        internal System.Windows.Forms.GroupBox grpAction;
        internal System.Windows.Forms.Button btnCancelMeal;
        internal System.Windows.Forms.Button btnServeMeal;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblStudentId;
    }
}
