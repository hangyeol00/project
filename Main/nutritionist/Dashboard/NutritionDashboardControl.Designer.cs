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
            this.dgvTodayMeals = new System.Windows.Forms.DataGridView();
            this.grpTodayRaw = new System.Windows.Forms.GroupBox();
            this.dgvTodayRawNeeds = new System.Windows.Forms.DataGridView();
            this.grpShortage = new System.Windows.Forms.GroupBox();
            this.dgvShortageRaw = new System.Windows.Forms.DataGridView();
            this.grpMealLogs = new System.Windows.Forms.GroupBox();
            this.dgvMealLogs = new System.Windows.Forms.DataGridView();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpMenus = new System.Windows.Forms.GroupBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            this.btnServeMeal = new System.Windows.Forms.Button();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.layoutDashboard.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMeals)).BeginInit();
            this.grpTodayMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayRawNeeds)).BeginInit();
            this.grpTodayRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortageRaw)).BeginInit();
            this.grpShortage.SuspendLayout();
            this.grpMealLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).BeginInit();
            this.grpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
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
            this.grpSummary.Font = new System.Drawing.Font("Malgun Gothic", 9F);
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
            this.lblCurrentServeDate.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentServeDate.Location = new System.Drawing.Point(82, 32);
            this.lblCurrentServeDate.Name = "lblCurrentServeDate";
            this.lblCurrentServeDate.Size = new System.Drawing.Size(54, 19);
            this.lblCurrentServeDate.TabIndex = 7;
            this.lblCurrentServeDate.Text = "0000";
            // 
            // lblServeDateTitle
            // 
            this.lblServeDateTitle.AutoSize = true;
            this.lblServeDateTitle.Location = new System.Drawing.Point(18, 35);
            this.lblServeDateTitle.Name = "lblServeDateTitle";
            this.lblServeDateTitle.Size = new System.Drawing.Size(63, 15);
            this.lblServeDateTitle.TabIndex = 6;
            this.lblServeDateTitle.Text = "기준 일자:";
            // 
            // lblNotMealValue
            // 
            this.lblNotMealValue.AutoSize = true;
            this.lblNotMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotMealValue.Location = new System.Drawing.Point(768, 32);
            this.lblNotMealValue.Name = "lblNotMealValue";
            this.lblNotMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblNotMealValue.TabIndex = 5;
            this.lblNotMealValue.Text = "0";
            // 
            // lblNotMeal
            // 
            this.lblNotMeal.AutoSize = true;
            this.lblNotMeal.Location = new System.Drawing.Point(650, 35);
            this.lblNotMeal.Name = "lblNotMeal";
            this.lblNotMeal.Size = new System.Drawing.Size(113, 15);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "발주 대기 원재료:";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.AutoSize = true;
            this.lblTodayMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayMealValue.Location = new System.Drawing.Point(520, 32);
            this.lblTodayMealValue.Name = "lblTodayMealValue";
            this.lblTodayMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblTodayMealValue.TabIndex = 3;
            this.lblTodayMealValue.Text = "0";
            // 
            // lblTodayMeal
            // 
            this.lblTodayMeal.AutoSize = true;
            this.lblTodayMeal.Location = new System.Drawing.Point(403, 35);
            this.lblTodayMeal.Name = "lblTodayMeal";
            this.lblTodayMeal.Size = new System.Drawing.Size(115, 15);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "승인 대기 식단 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.AutoSize = true;
            this.lblTotalStudentValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentValue.Location = new System.Drawing.Point(289, 32);
            this.lblTotalStudentValue.Name = "lblTotalStudentValue";
            this.lblTotalStudentValue.Size = new System.Drawing.Size(17, 19);
            this.lblTotalStudentValue.TabIndex = 1;
            this.lblTotalStudentValue.Text = "0";
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Location = new System.Drawing.Point(186, 35);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(99, 15);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "오늘 식단(건) :";
            // 
            // grpTodayMeals
            // 
            this.grpTodayMeals.Controls.Add(this.dgvTodayMeals);
            this.grpTodayMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayMeals.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpTodayMeals.Location = new System.Drawing.Point(3, 82);
            this.grpTodayMeals.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpTodayMeals.Name = "grpTodayMeals";
            this.grpTodayMeals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayMeals.Size = new System.Drawing.Size(463, 129);
            this.grpTodayMeals.TabIndex = 1;
            this.grpTodayMeals.TabStop = false;
            this.grpTodayMeals.Text = "오늘의 식단";
            // 
            // dgvTodayMeals
            // 
            this.dgvTodayMeals.AllowUserToAddRows = false;
            this.dgvTodayMeals.AllowUserToDeleteRows = false;
            this.dgvTodayMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayMeals.Location = new System.Drawing.Point(3, 18);
            this.dgvTodayMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayMeals.MultiSelect = false;
            this.dgvTodayMeals.Name = "dgvTodayMeals";
            this.dgvTodayMeals.ReadOnly = true;
            this.dgvTodayMeals.RowHeadersWidth = 51;
            this.dgvTodayMeals.RowTemplate.Height = 27;
            this.dgvTodayMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayMeals.Size = new System.Drawing.Size(457, 109);
            this.dgvTodayMeals.TabIndex = 0;
            // 
            // grpTodayRaw
            // 
            this.grpTodayRaw.Controls.Add(this.dgvTodayRawNeeds);
            this.grpTodayRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayRaw.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpTodayRaw.Location = new System.Drawing.Point(474, 82);
            this.grpTodayRaw.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpTodayRaw.Name = "grpTodayRaw";
            this.grpTodayRaw.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayRaw.Size = new System.Drawing.Size(467, 129);
            this.grpTodayRaw.TabIndex = 2;
            this.grpTodayRaw.TabStop = false;
            this.grpTodayRaw.Text = "오늘 필요한 원재료";
            // 
            // dgvTodayRawNeeds
            // 
            this.dgvTodayRawNeeds.AllowUserToAddRows = false;
            this.dgvTodayRawNeeds.AllowUserToDeleteRows = false;
            this.dgvTodayRawNeeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayRawNeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayRawNeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayRawNeeds.Location = new System.Drawing.Point(3, 18);
            this.dgvTodayRawNeeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayRawNeeds.MultiSelect = false;
            this.dgvTodayRawNeeds.Name = "dgvTodayRawNeeds";
            this.dgvTodayRawNeeds.ReadOnly = true;
            this.dgvTodayRawNeeds.RowHeadersWidth = 51;
            this.dgvTodayRawNeeds.RowTemplate.Height = 27;
            this.dgvTodayRawNeeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayRawNeeds.Size = new System.Drawing.Size(461, 109);
            this.dgvTodayRawNeeds.TabIndex = 0;
            // 
            // grpShortage
            // 
            this.grpShortage.Controls.Add(this.dgvShortageRaw);
            this.grpShortage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShortage.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpShortage.Location = new System.Drawing.Point(3, 215);
            this.grpShortage.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpShortage.Name = "grpShortage";
            this.grpShortage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShortage.Size = new System.Drawing.Size(463, 129);
            this.grpShortage.TabIndex = 3;
            this.grpShortage.TabStop = false;
            this.grpShortage.Text = "발주 대기 / 부족 원재료";
            // 
            // dgvShortageRaw
            // 
            this.dgvShortageRaw.AllowUserToAddRows = false;
            this.dgvShortageRaw.AllowUserToDeleteRows = false;
            this.dgvShortageRaw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShortageRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortageRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShortageRaw.Location = new System.Drawing.Point(3, 18);
            this.dgvShortageRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShortageRaw.MultiSelect = false;
            this.dgvShortageRaw.Name = "dgvShortageRaw";
            this.dgvShortageRaw.ReadOnly = true;
            this.dgvShortageRaw.RowHeadersWidth = 51;
            this.dgvShortageRaw.RowTemplate.Height = 27;
            this.dgvShortageRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShortageRaw.Size = new System.Drawing.Size(457, 109);
            this.dgvShortageRaw.TabIndex = 0;
            // 
            // grpMealLogs
            // 
            this.grpMealLogs.Controls.Add(this.dgvMealLogs);
            this.grpMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealLogs.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpMealLogs.Location = new System.Drawing.Point(474, 215);
            this.grpMealLogs.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpMealLogs.Name = "grpMealLogs";
            this.grpMealLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Size = new System.Drawing.Size(467, 129);
            this.grpMealLogs.TabIndex = 4;
            this.grpMealLogs.TabStop = false;
            this.grpMealLogs.Text = "식단 계획 승인 현황";
            // 
            // dgvMealLogs
            // 
            this.dgvMealLogs.AllowUserToAddRows = false;
            this.dgvMealLogs.AllowUserToDeleteRows = false;
            this.dgvMealLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealLogs.Location = new System.Drawing.Point(3, 18);
            this.dgvMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealLogs.MultiSelect = false;
            this.dgvMealLogs.Name = "dgvMealLogs";
            this.dgvMealLogs.ReadOnly = true;
            this.dgvMealLogs.RowHeadersWidth = 51;
            this.dgvMealLogs.RowTemplate.Height = 27;
            this.dgvMealLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealLogs.Size = new System.Drawing.Size(461, 109);
            this.dgvMealLogs.TabIndex = 0;
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.dgvStudents);
            this.grpStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudents.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpStudents.Location = new System.Drawing.Point(3, 348);
            this.grpStudents.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Size = new System.Drawing.Size(463, 135);
            this.grpStudents.TabIndex = 5;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "원재료 목록";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 18);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 27;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(457, 115);
            this.dgvStudents.TabIndex = 0;
            // 
            // grpMenus
            // 
            this.grpMenus.Controls.Add(this.dgvMenus);
            this.grpMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMenus.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpMenus.Location = new System.Drawing.Point(474, 348);
            this.grpMenus.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpMenus.Name = "grpMenus";
            this.grpMenus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Size = new System.Drawing.Size(467, 135);
            this.grpMenus.TabIndex = 6;
            this.grpMenus.TabStop = false;
            this.grpMenus.Text = "최종 메뉴";
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.Location = new System.Drawing.Point(3, 18);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMenus.MultiSelect = false;
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.RowTemplate.Height = 27;
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Size = new System.Drawing.Size(461, 115);
            this.dgvMenus.TabIndex = 0;
            // 
            // grpAction
            // 
            this.layoutDashboard.SetColumnSpan(this.grpAction, 2);
            this.grpAction.Controls.Add(this.btnCancelMeal);
            this.grpAction.Controls.Add(this.btnServeMeal);
            this.grpAction.Controls.Add(this.txtStudentId);
            this.grpAction.Controls.Add(this.lblStudentId);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAction.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.grpAction.Location = new System.Drawing.Point(3, 487);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Size = new System.Drawing.Size(938, 107);
            this.grpAction.TabIndex = 7;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "업무 작업";
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelMeal.Location = new System.Drawing.Point(478, 56);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(120, 32);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "발주 요청 등록";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnServeMeal.Location = new System.Drawing.Point(338, 56);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(120, 32);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "식단 계획 등록";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            // 
            // 
            // 
            // txtStudentId
            // 
            this.txtStudentId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStudentId.Location = new System.Drawing.Point(125, 28);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(190, 23);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TabStop = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(21, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(87, 15);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "선택 원재료:";
            // 
            // NutritionDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.layoutDashboard);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "NutritionDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(950, 500);
            this.layoutDashboard.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpTodayMeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMeals)).EndInit();
            this.grpTodayRaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayRawNeeds)).EndInit();
            this.grpShortage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortageRaw)).EndInit();
            this.grpMealLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).EndInit();
            this.grpStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
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
        internal System.Windows.Forms.DataGridView dgvTodayMeals;
        internal System.Windows.Forms.GroupBox grpTodayRaw;
        internal System.Windows.Forms.DataGridView dgvTodayRawNeeds;
        internal System.Windows.Forms.GroupBox grpShortage;
        internal System.Windows.Forms.DataGridView dgvShortageRaw;
        internal System.Windows.Forms.GroupBox grpMealLogs;
        internal System.Windows.Forms.DataGridView dgvMealLogs;
        internal System.Windows.Forms.GroupBox grpStudents;
        internal System.Windows.Forms.DataGridView dgvStudents;
        internal System.Windows.Forms.GroupBox grpMenus;
        internal System.Windows.Forms.DataGridView dgvMenus;
        internal System.Windows.Forms.GroupBox grpAction;
        internal System.Windows.Forms.Button btnCancelMeal;
        internal System.Windows.Forms.Button btnServeMeal;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblStudentId;
    }
}
