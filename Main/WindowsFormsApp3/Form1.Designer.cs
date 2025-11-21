namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.grpMealLogs = new System.Windows.Forms.GroupBox();
            this.dgvMealLogs = new System.Windows.Forms.DataGridView();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            this.btnServeMeal = new System.Windows.Forms.Button();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.lblMenuCode = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.grpMenus = new System.Windows.Forms.GroupBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblNotMealValue = new System.Windows.Forms.Label();
            this.lblNotMeal = new System.Windows.Forms.Label();
            this.lblTodayMealValue = new System.Windows.Forms.Label();
            this.lblTodayMeal = new System.Windows.Forms.Label();
            this.lblTotalStudentValue = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.tabManagement = new System.Windows.Forms.TabPage();
            this.tabControlManagement = new System.Windows.Forms.TabControl();
            this.tabIngredients = new System.Windows.Forms.TabPage();
            this.splitContainerIngredients = new System.Windows.Forms.SplitContainer();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.grpIngredientDetail = new System.Windows.Forms.GroupBox();
            this.tableIngredientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.lblIngredientUnit = new System.Windows.Forms.Label();
            this.txtIngredientUnit = new System.Windows.Forms.TextBox();
            this.lblIngredientNutrient = new System.Windows.Forms.Label();
            this.txtIngredientNutrient = new System.Windows.Forms.TextBox();
            this.flowIngredientButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.tabNutrients = new System.Windows.Forms.TabPage();
            this.splitContainerNutrients = new System.Windows.Forms.SplitContainer();
            this.dgvNutrients = new System.Windows.Forms.DataGridView();
            this.grpNutrientDetail = new System.Windows.Forms.GroupBox();
            this.tableNutrientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblNutrientCode = new System.Windows.Forms.Label();
            this.txtNutrientCode = new System.Windows.Forms.TextBox();
            this.lblNutrientName = new System.Windows.Forms.Label();
            this.txtNutrientName = new System.Windows.Forms.TextBox();
            this.lblNutrientUnit = new System.Windows.Forms.Label();
            this.txtNutrientUnit = new System.Windows.Forms.TextBox();
            this.btnSearchNutrient = new System.Windows.Forms.Button();
            this.tabRecipes = new System.Windows.Forms.TabPage();
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.grpRecipeDetail = new System.Windows.Forms.GroupBox();
            this.tableRecipeDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeDescription = new System.Windows.Forms.Label();
            this.txtRecipeDescription = new System.Windows.Forms.TextBox();
            this.lblRecipeIngredient = new System.Windows.Forms.Label();
            this.cmbRecipeIngredient = new System.Windows.Forms.ComboBox();
            this.lblRecipeAmount = new System.Windows.Forms.Label();
            this.txtRecipeAmount = new System.Windows.Forms.TextBox();
            this.btnAddRecipeIngredient = new System.Windows.Forms.Button();
            this.lstRecipeIngredients = new System.Windows.Forms.ListBox();
            this.flowRecipeButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.btnUpdateRecipe = new System.Windows.Forms.Button();
            this.tabMealPlans = new System.Windows.Forms.TabPage();
            this.splitContainerMealPlans = new System.Windows.Forms.SplitContainer();
            this.dgvMealPlans = new System.Windows.Forms.DataGridView();
            this.grpMealPlanDetail = new System.Windows.Forms.GroupBox();
            this.tableMealPlanDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealType = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.lblMealRecipes = new System.Windows.Forms.Label();
            this.lstMealRecipes = new System.Windows.Forms.ListBox();
            this.lblMealNotes = new System.Windows.Forms.Label();
            this.txtMealNotes = new System.Windows.Forms.TextBox();
            this.flowMealButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterMealPlan = new System.Windows.Forms.Button();
            this.btnUpdateMealPlan = new System.Windows.Forms.Button();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.splitContainerUsers = new System.Windows.Forms.SplitContainer();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.tableUserDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserGrade = new System.Windows.Forms.Label();
            this.txtUserGrade = new System.Windows.Forms.TextBox();
            this.lblUserClass = new System.Windows.Forms.Label();
            this.txtUserClass = new System.Windows.Forms.TextBox();
            this.lblUserAllergy = new System.Windows.Forms.Label();
            this.txtUserAllergyNotes = new System.Windows.Forms.TextBox();
            this.flowUserButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnManageUserAllergies = new System.Windows.Forms.Button();
            this.tabAllergies = new System.Windows.Forms.TabPage();
            this.splitContainerAllergies = new System.Windows.Forms.SplitContainer();
            this.dgvAllergies = new System.Windows.Forms.DataGridView();
            this.grpAllergyDetail = new System.Windows.Forms.GroupBox();
            this.tableAllergyDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllergyCode = new System.Windows.Forms.Label();
            this.txtAllergyCode = new System.Windows.Forms.TextBox();
            this.lblAllergyName = new System.Windows.Forms.Label();
            this.txtAllergyName = new System.Windows.Forms.TextBox();
            this.lblAllergyDescription = new System.Windows.Forms.Label();
            this.txtAllergyDescription = new System.Windows.Forms.TextBox();
            this.flowAllergyButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterAllergy = new System.Windows.Forms.Button();
            this.btnUpdateAllergy = new System.Windows.Forms.Button();
            this.tabAllergyRelations = new System.Windows.Forms.TabPage();
            this.splitContainerAllergyRelations = new System.Windows.Forms.SplitContainer();
            this.dgvAllergyRelations = new System.Windows.Forms.DataGridView();
            this.grpAllergyRelationDetail = new System.Windows.Forms.GroupBox();
            this.tableAllergyRelationDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRelationUser = new System.Windows.Forms.Label();
            this.cmbRelationUser = new System.Windows.Forms.ComboBox();
            this.lblRelationAllergy = new System.Windows.Forms.Label();
            this.cmbRelationAllergy = new System.Windows.Forms.ComboBox();
            this.lblRelationNotes = new System.Windows.Forms.Label();
            this.txtRelationNotes = new System.Windows.Forms.TextBox();
            this.flowRelationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLinkAllergy = new System.Windows.Forms.Button();
            this.btnRemoveAllergy = new System.Windows.Forms.Button();
            this.tabMealEvaluations = new System.Windows.Forms.TabPage();
            this.splitContainerMealEvaluations = new System.Windows.Forms.SplitContainer();
            this.dgvMealEvaluations = new System.Windows.Forms.DataGridView();
            this.grpMealEvaluationDetail = new System.Windows.Forms.GroupBox();
            this.tableMealEvaluationDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblEvaluationMeal = new System.Windows.Forms.Label();
            this.cmbEvaluationMeal = new System.Windows.Forms.ComboBox();
            this.lblEvaluationUser = new System.Windows.Forms.Label();
            this.cmbEvaluationUser = new System.Windows.Forms.ComboBox();
            this.lblEvaluationScore = new System.Windows.Forms.Label();
            this.nudEvaluationScore = new System.Windows.Forms.NumericUpDown();
            this.lblEvaluationComment = new System.Windows.Forms.Label();
            this.txtEvaluationComment = new System.Windows.Forms.TextBox();
            this.flowEvaluationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRegisterEvaluation = new System.Windows.Forms.Button();
            this.btnRefreshEvaluation = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.grpMealLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).BeginInit();
            this.grpAction.SuspendLayout();
            this.grpMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            this.grpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.tabManagement.SuspendLayout();
            this.tabControlManagement.SuspendLayout();
            this.tabIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).BeginInit();
            this.splitContainerIngredients.Panel1.SuspendLayout();
            this.splitContainerIngredients.Panel2.SuspendLayout();
            this.splitContainerIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.grpIngredientDetail.SuspendLayout();
            this.tableIngredientDetail.SuspendLayout();
            this.flowIngredientButtons.SuspendLayout();
            this.tabNutrients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).BeginInit();
            this.splitContainerNutrients.Panel1.SuspendLayout();
            this.splitContainerNutrients.Panel2.SuspendLayout();
            this.splitContainerNutrients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).BeginInit();
            this.grpNutrientDetail.SuspendLayout();
            this.tableNutrientDetail.SuspendLayout();
            this.tabRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).BeginInit();
            this.splitContainerRecipes.Panel1.SuspendLayout();
            this.splitContainerRecipes.Panel2.SuspendLayout();
            this.splitContainerRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.grpRecipeDetail.SuspendLayout();
            this.tableRecipeDetail.SuspendLayout();
            this.flowRecipeButtons.SuspendLayout();
            this.tabMealPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).BeginInit();
            this.splitContainerMealPlans.Panel1.SuspendLayout();
            this.splitContainerMealPlans.Panel2.SuspendLayout();
            this.splitContainerMealPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).BeginInit();
            this.grpMealPlanDetail.SuspendLayout();
            this.tableMealPlanDetail.SuspendLayout();
            this.flowMealButtons.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).BeginInit();
            this.splitContainerUsers.Panel1.SuspendLayout();
            this.splitContainerUsers.Panel2.SuspendLayout();
            this.splitContainerUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpUserDetail.SuspendLayout();
            this.tableUserDetail.SuspendLayout();
            this.flowUserButtons.SuspendLayout();
            this.tabAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).BeginInit();
            this.splitContainerAllergies.Panel1.SuspendLayout();
            this.splitContainerAllergies.Panel2.SuspendLayout();
            this.splitContainerAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).BeginInit();
            this.grpAllergyDetail.SuspendLayout();
            this.tableAllergyDetail.SuspendLayout();
            this.flowAllergyButtons.SuspendLayout();
            this.tabAllergyRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).BeginInit();
            this.splitContainerAllergyRelations.Panel1.SuspendLayout();
            this.splitContainerAllergyRelations.Panel2.SuspendLayout();
            this.splitContainerAllergyRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).BeginInit();
            this.grpAllergyRelationDetail.SuspendLayout();
            this.tableAllergyRelationDetail.SuspendLayout();
            this.flowRelationButtons.SuspendLayout();
            this.tabMealEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).BeginInit();
            this.splitContainerMealEvaluations.Panel1.SuspendLayout();
            this.splitContainerMealEvaluations.Panel2.SuspendLayout();
            this.splitContainerMealEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).BeginInit();
            this.grpMealEvaluationDetail.SuspendLayout();
            this.tableMealEvaluationDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).BeginInit();
            this.flowEvaluationButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(962, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReload,
            this.menuSeparator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(43, 20);
            this.menuFile.Text = "메뉴";
            // 
            // menuReload
            // 
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(122, 22);
            this.menuReload.Text = "새로고침";
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(122, 22);
            this.menuExit.Text = "종료";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabDashboard);
            this.tabMain.Controls.Add(this.tabManagement);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(962, 496);
            this.tabMain.TabIndex = 1;
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.grpMealLogs);
            this.tabDashboard.Controls.Add(this.grpAction);
            this.tabDashboard.Controls.Add(this.grpMenus);
            this.tabDashboard.Controls.Add(this.grpStudents);
            this.tabDashboard.Controls.Add(this.grpSummary);
            this.tabDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Size = new System.Drawing.Size(954, 470);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "메인 현황";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // grpMealLogs
            // 
            this.grpMealLogs.Controls.Add(this.dgvMealLogs);
            this.grpMealLogs.Location = new System.Drawing.Point(9, 296);
            this.grpMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Name = "grpMealLogs";
            this.grpMealLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Size = new System.Drawing.Size(928, 168);
            this.grpMealLogs.TabIndex = 5;
            this.grpMealLogs.TabStop = false;
            this.grpMealLogs.Text = "급식 기록";
            // 
            // dgvMealLogs
            // 
            this.dgvMealLogs.AllowUserToAddRows = false;
            this.dgvMealLogs.AllowUserToDeleteRows = false;
            this.dgvMealLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealLogs.Location = new System.Drawing.Point(3, 16);
            this.dgvMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealLogs.MultiSelect = false;
            this.dgvMealLogs.Name = "dgvMealLogs";
            this.dgvMealLogs.ReadOnly = true;
            this.dgvMealLogs.RowHeadersWidth = 51;
            this.dgvMealLogs.RowTemplate.Height = 27;
            this.dgvMealLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealLogs.Size = new System.Drawing.Size(922, 150);
            this.dgvMealLogs.TabIndex = 0;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnCancelMeal);
            this.grpAction.Controls.Add(this.btnServeMeal);
            this.grpAction.Controls.Add(this.txtMenuCode);
            this.grpAction.Controls.Add(this.lblMenuCode);
            this.grpAction.Controls.Add(this.txtStudentId);
            this.grpAction.Controls.Add(this.lblStudentId);
            this.grpAction.Location = new System.Drawing.Point(656, 92);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Size = new System.Drawing.Size(280, 184);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "급식 처리";
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Location = new System.Drawing.Point(149, 104);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(96, 32);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "급식 취소";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Location = new System.Drawing.Point(26, 104);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(96, 32);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "급식 처리";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(105, 60);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(149, 21);
            this.txtMenuCode.TabIndex = 3;
            // 
            // lblMenuCode
            // 
            this.lblMenuCode.AutoSize = true;
            this.lblMenuCode.Location = new System.Drawing.Point(13, 64);
            this.lblMenuCode.Name = "lblMenuCode";
            this.lblMenuCode.Size = new System.Drawing.Size(61, 12);
            this.lblMenuCode.TabIndex = 2;
            this.lblMenuCode.Text = "메뉴 코드:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(105, 28);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(149, 21);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(13, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(86, 12);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "학생 ID (학번):";
            // 
            // grpMenus
            // 
            this.grpMenus.Controls.Add(this.dgvMenus);
            this.grpMenus.Location = new System.Drawing.Point(376, 92);
            this.grpMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Name = "grpMenus";
            this.grpMenus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Size = new System.Drawing.Size(262, 184);
            this.grpMenus.TabIndex = 3;
            this.grpMenus.TabStop = false;
            this.grpMenus.Text = "식단 / 메뉴 목록";
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.Location = new System.Drawing.Point(3, 16);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMenus.MultiSelect = false;
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.RowTemplate.Height = 27;
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Size = new System.Drawing.Size(256, 166);
            this.dgvMenus.TabIndex = 0;
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.dgvStudents);
            this.grpStudents.Location = new System.Drawing.Point(9, 92);
            this.grpStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Size = new System.Drawing.Size(350, 184);
            this.grpStudents.TabIndex = 2;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "학생 목록";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 16);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 27;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(344, 166);
            this.dgvStudents.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblNotMealValue);
            this.grpSummary.Controls.Add(this.lblNotMeal);
            this.grpSummary.Controls.Add(this.lblTodayMealValue);
            this.grpSummary.Controls.Add(this.lblTodayMeal);
            this.grpSummary.Controls.Add(this.lblTotalStudentValue);
            this.grpSummary.Controls.Add(this.lblTotalStudent);
            this.grpSummary.Location = new System.Drawing.Point(9, 8);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(928, 72);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "급식 현황";
            // 
            // lblNotMealValue
            // 
            this.lblNotMealValue.AutoSize = true;
            this.lblNotMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotMealValue.Location = new System.Drawing.Point(542, 32);
            this.lblNotMealValue.Name = "lblNotMealValue";
            this.lblNotMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblNotMealValue.TabIndex = 5;
            this.lblNotMealValue.Text = "0";
            // 
            // lblNotMeal
            // 
            this.lblNotMeal.AutoSize = true;
            this.lblNotMeal.Location = new System.Drawing.Point(438, 35);
            this.lblNotMeal.Name = "lblNotMeal";
            this.lblNotMeal.Size = new System.Drawing.Size(105, 12);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "오늘 미급식 인원 :";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.AutoSize = true;
            this.lblTodayMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayMealValue.Location = new System.Drawing.Point(315, 32);
            this.lblTodayMealValue.Name = "lblTodayMealValue";
            this.lblTodayMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblTodayMealValue.TabIndex = 3;
            this.lblTodayMealValue.Text = "0";
            // 
            // lblTodayMeal
            // 
            this.lblTodayMeal.AutoSize = true;
            this.lblTodayMeal.Location = new System.Drawing.Point(219, 35);
            this.lblTodayMeal.Name = "lblTodayMeal";
            this.lblTodayMeal.Size = new System.Drawing.Size(93, 12);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "오늘 급식 인원 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.AutoSize = true;
            this.lblTotalStudentValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentValue.Location = new System.Drawing.Point(96, 32);
            this.lblTotalStudentValue.Name = "lblTotalStudentValue";
            this.lblTotalStudentValue.Size = new System.Drawing.Size(17, 19);
            this.lblTotalStudentValue.TabIndex = 1;
            this.lblTotalStudentValue.Text = "0";
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Location = new System.Drawing.Point(18, 35);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(69, 12);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "총 학생 수 :";
            // 
            // tabManagement
            // 
            this.tabManagement.Controls.Add(this.tabControlManagement);
            this.tabManagement.Location = new System.Drawing.Point(4, 22);
            this.tabManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManagement.Size = new System.Drawing.Size(954, 470);
            this.tabManagement.TabIndex = 1;
            this.tabManagement.Text = "상세 관리";
            this.tabManagement.UseVisualStyleBackColor = true;
            // 
            // tabControlManagement
            // 
            this.tabControlManagement.Controls.Add(this.tabIngredients);
            this.tabControlManagement.Controls.Add(this.tabNutrients);
            this.tabControlManagement.Controls.Add(this.tabRecipes);
            this.tabControlManagement.Controls.Add(this.tabMealPlans);
            this.tabControlManagement.Controls.Add(this.tabUsers);
            this.tabControlManagement.Controls.Add(this.tabAllergies);
            this.tabControlManagement.Controls.Add(this.tabAllergyRelations);
            this.tabControlManagement.Controls.Add(this.tabMealEvaluations);
            this.tabControlManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManagement.Location = new System.Drawing.Point(3, 2);
            this.tabControlManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlManagement.Name = "tabControlManagement";
            this.tabControlManagement.SelectedIndex = 0;
            this.tabControlManagement.Size = new System.Drawing.Size(948, 466);
            this.tabControlManagement.TabIndex = 0;
            // 
            // tabIngredients
            // 
            this.tabIngredients.Controls.Add(this.splitContainerIngredients);
            this.tabIngredients.Location = new System.Drawing.Point(4, 22);
            this.tabIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Name = "tabIngredients";
            this.tabIngredients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Size = new System.Drawing.Size(940, 440);
            this.tabIngredients.TabIndex = 0;
            this.tabIngredients.Text = "재료 관리";
            this.tabIngredients.UseVisualStyleBackColor = true;
            // 
            // splitContainerIngredients
            // 
            this.splitContainerIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerIngredients.Location = new System.Drawing.Point(3, 2);
            this.splitContainerIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerIngredients.Name = "splitContainerIngredients";
            // 
            // splitContainerIngredients.Panel1
            // 
            this.splitContainerIngredients.Panel1.Controls.Add(this.dgvIngredients);
            // 
            // splitContainerIngredients.Panel2
            // 
            this.splitContainerIngredients.Panel2.Controls.Add(this.grpIngredientDetail);
            this.splitContainerIngredients.Size = new System.Drawing.Size(934, 436);
            this.splitContainerIngredients.SplitterDistance = 472;
            this.splitContainerIngredients.TabIndex = 0;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.Location = new System.Drawing.Point(0, 0);
            this.dgvIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.RowHeadersWidth = 51;
            this.dgvIngredients.RowTemplate.Height = 27;
            this.dgvIngredients.Size = new System.Drawing.Size(472, 436);
            this.dgvIngredients.TabIndex = 0;
            // 
            // grpIngredientDetail
            // 
            this.grpIngredientDetail.Controls.Add(this.tableIngredientDetail);
            this.grpIngredientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIngredientDetail.Location = new System.Drawing.Point(0, 0);
            this.grpIngredientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIngredientDetail.Name = "grpIngredientDetail";
            this.grpIngredientDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIngredientDetail.Size = new System.Drawing.Size(458, 436);
            this.grpIngredientDetail.TabIndex = 0;
            this.grpIngredientDetail.TabStop = false;
            this.grpIngredientDetail.Text = "재료 정보";
            // 
            // tableIngredientDetail
            // 
            this.tableIngredientDetail.ColumnCount = 2;
            this.tableIngredientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableIngredientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIngredientDetail.Controls.Add(this.lblIngredientName, 0, 0);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientName, 1, 0);
            this.tableIngredientDetail.Controls.Add(this.lblIngredientUnit, 0, 1);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientUnit, 1, 1);
            this.tableIngredientDetail.Controls.Add(this.lblIngredientNutrient, 0, 2);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientNutrient, 1, 2);
            this.tableIngredientDetail.Controls.Add(this.flowIngredientButtons, 0, 3);
            this.tableIngredientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableIngredientDetail.Location = new System.Drawing.Point(3, 16);
            this.tableIngredientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableIngredientDetail.Name = "tableIngredientDetail";
            this.tableIngredientDetail.RowCount = 4;
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIngredientDetail.Size = new System.Drawing.Size(452, 418);
            this.tableIngredientDetail.TabIndex = 0;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientName.Location = new System.Drawing.Point(3, 0);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(99, 32);
            this.lblIngredientName.TabIndex = 0;
            this.lblIngredientName.Text = "재료명";
            this.lblIngredientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientName.Location = new System.Drawing.Point(108, 2);
            this.txtIngredientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(341, 21);
            this.txtIngredientName.TabIndex = 1;
            // 
            // lblIngredientUnit
            // 
            this.lblIngredientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientUnit.Location = new System.Drawing.Point(3, 32);
            this.lblIngredientUnit.Name = "lblIngredientUnit";
            this.lblIngredientUnit.Size = new System.Drawing.Size(99, 32);
            this.lblIngredientUnit.TabIndex = 2;
            this.lblIngredientUnit.Text = "단위 (g)";
            this.lblIngredientUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientUnit
            // 
            this.txtIngredientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientUnit.Location = new System.Drawing.Point(108, 34);
            this.txtIngredientUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientUnit.Name = "txtIngredientUnit";
            this.txtIngredientUnit.Size = new System.Drawing.Size(341, 21);
            this.txtIngredientUnit.TabIndex = 3;
            // 
            // lblIngredientNutrient
            // 
            this.lblIngredientNutrient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientNutrient.Location = new System.Drawing.Point(3, 64);
            this.lblIngredientNutrient.Name = "lblIngredientNutrient";
            this.lblIngredientNutrient.Size = new System.Drawing.Size(99, 96);
            this.lblIngredientNutrient.TabIndex = 4;
            this.lblIngredientNutrient.Text = "영양 정보 (예: 100g 당 단백질 5g)";
            this.lblIngredientNutrient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientNutrient
            // 
            this.txtIngredientNutrient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientNutrient.Location = new System.Drawing.Point(108, 66);
            this.txtIngredientNutrient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientNutrient.Multiline = true;
            this.txtIngredientNutrient.Name = "txtIngredientNutrient";
            this.txtIngredientNutrient.Size = new System.Drawing.Size(341, 92);
            this.txtIngredientNutrient.TabIndex = 5;
            // 
            // flowIngredientButtons
            // 
            this.flowIngredientButtons.AutoSize = true;
            this.tableIngredientDetail.SetColumnSpan(this.flowIngredientButtons, 2);
            this.flowIngredientButtons.Controls.Add(this.btnAddIngredient);
            this.flowIngredientButtons.Controls.Add(this.btnUpdateIngredient);
            this.flowIngredientButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowIngredientButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowIngredientButtons.Location = new System.Drawing.Point(3, 162);
            this.flowIngredientButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowIngredientButtons.Name = "flowIngredientButtons";
            this.flowIngredientButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowIngredientButtons.Size = new System.Drawing.Size(446, 40);
            this.flowIngredientButtons.TabIndex = 6;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(339, 10);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(107, 28);
            this.btnAddIngredient.TabIndex = 0;
            this.btnAddIngredient.Text = "재료 등록";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Location = new System.Drawing.Point(232, 10);
            this.btnUpdateIngredient.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(98, 28);
            this.btnUpdateIngredient.TabIndex = 1;
            this.btnUpdateIngredient.Text = "재료 수정";
            this.btnUpdateIngredient.UseVisualStyleBackColor = true;
            // 
            // tabNutrients
            // 
            this.tabNutrients.Controls.Add(this.splitContainerNutrients);
            this.tabNutrients.Location = new System.Drawing.Point(4, 22);
            this.tabNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Name = "tabNutrients";
            this.tabNutrients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Size = new System.Drawing.Size(940, 440);
            this.tabNutrients.TabIndex = 1;
            this.tabNutrients.Text = "영양소 관리";
            this.tabNutrients.UseVisualStyleBackColor = true;
            // 
            // splitContainerNutrients
            // 
            this.splitContainerNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNutrients.Location = new System.Drawing.Point(3, 2);
            this.splitContainerNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerNutrients.Name = "splitContainerNutrients";
            // 
            // splitContainerNutrients.Panel1
            // 
            this.splitContainerNutrients.Panel1.Controls.Add(this.dgvNutrients);
            // 
            // splitContainerNutrients.Panel2
            // 
            this.splitContainerNutrients.Panel2.Controls.Add(this.grpNutrientDetail);
            this.splitContainerNutrients.Size = new System.Drawing.Size(934, 436);
            this.splitContainerNutrients.SplitterDistance = 472;
            this.splitContainerNutrients.TabIndex = 0;
            // 
            // dgvNutrients
            // 
            this.dgvNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNutrients.Location = new System.Drawing.Point(0, 0);
            this.dgvNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNutrients.Name = "dgvNutrients";
            this.dgvNutrients.RowHeadersWidth = 51;
            this.dgvNutrients.RowTemplate.Height = 27;
            this.dgvNutrients.Size = new System.Drawing.Size(472, 436);
            this.dgvNutrients.TabIndex = 0;
            // 
            // grpNutrientDetail
            // 
            this.grpNutrientDetail.Controls.Add(this.tableNutrientDetail);
            this.grpNutrientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNutrientDetail.Location = new System.Drawing.Point(0, 0);
            this.grpNutrientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNutrientDetail.Name = "grpNutrientDetail";
            this.grpNutrientDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNutrientDetail.Size = new System.Drawing.Size(458, 436);
            this.grpNutrientDetail.TabIndex = 0;
            this.grpNutrientDetail.TabStop = false;
            this.grpNutrientDetail.Text = "영양소 정보";
            // 
            // tableNutrientDetail
            // 
            this.tableNutrientDetail.ColumnCount = 2;
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Controls.Add(this.lblNutrientCode, 0, 0);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientCode, 1, 0);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientName, 0, 1);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientName, 1, 1);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientUnit, 0, 2);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientUnit, 1, 2);
            this.tableNutrientDetail.Controls.Add(this.btnSearchNutrient, 1, 3);
            this.tableNutrientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNutrientDetail.Location = new System.Drawing.Point(3, 16);
            this.tableNutrientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableNutrientDetail.Name = "tableNutrientDetail";
            this.tableNutrientDetail.RowCount = 4;
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Size = new System.Drawing.Size(452, 418);
            this.tableNutrientDetail.TabIndex = 0;
            // 
            // lblNutrientCode
            // 
            this.lblNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientCode.Location = new System.Drawing.Point(3, 0);
            this.lblNutrientCode.Name = "lblNutrientCode";
            this.lblNutrientCode.Size = new System.Drawing.Size(99, 32);
            this.lblNutrientCode.TabIndex = 0;
            this.lblNutrientCode.Text = "영양소 코드";
            this.lblNutrientCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientCode
            // 
            this.txtNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientCode.Location = new System.Drawing.Point(108, 2);
            this.txtNutrientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientCode.Name = "txtNutrientCode";
            this.txtNutrientCode.Size = new System.Drawing.Size(341, 21);
            this.txtNutrientCode.TabIndex = 1;
            // 
            // lblNutrientName
            // 
            this.lblNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientName.Location = new System.Drawing.Point(3, 32);
            this.lblNutrientName.Name = "lblNutrientName";
            this.lblNutrientName.Size = new System.Drawing.Size(99, 32);
            this.lblNutrientName.TabIndex = 2;
            this.lblNutrientName.Text = "영양소명";
            this.lblNutrientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientName
            // 
            this.txtNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientName.Location = new System.Drawing.Point(108, 34);
            this.txtNutrientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientName.Name = "txtNutrientName";
            this.txtNutrientName.Size = new System.Drawing.Size(341, 21);
            this.txtNutrientName.TabIndex = 3;
            // 
            // lblNutrientUnit
            // 
            this.lblNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientUnit.Location = new System.Drawing.Point(3, 64);
            this.lblNutrientUnit.Name = "lblNutrientUnit";
            this.lblNutrientUnit.Size = new System.Drawing.Size(99, 32);
            this.lblNutrientUnit.TabIndex = 4;
            this.lblNutrientUnit.Text = "측정 단위";
            this.lblNutrientUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientUnit
            // 
            this.txtNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientUnit.Location = new System.Drawing.Point(108, 66);
            this.txtNutrientUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientUnit.Name = "txtNutrientUnit";
            this.txtNutrientUnit.Size = new System.Drawing.Size(341, 21);
            this.txtNutrientUnit.TabIndex = 5;
            // 
            // btnSearchNutrient
            // 
            this.btnSearchNutrient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchNutrient.Location = new System.Drawing.Point(357, 243);
            this.btnSearchNutrient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchNutrient.Name = "btnSearchNutrient";
            this.btnSearchNutrient.Size = new System.Drawing.Size(92, 28);
            this.btnSearchNutrient.TabIndex = 6;
            this.btnSearchNutrient.Text = "영양소 조회";
            this.btnSearchNutrient.UseVisualStyleBackColor = true;
            // 
            // tabRecipes
            // 
            this.tabRecipes.Controls.Add(this.splitContainerRecipes);
            this.tabRecipes.Location = new System.Drawing.Point(4, 22);
            this.tabRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Name = "tabRecipes";
            this.tabRecipes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Size = new System.Drawing.Size(940, 440);
            this.tabRecipes.TabIndex = 2;
            this.tabRecipes.Text = "요리 관리";
            this.tabRecipes.UseVisualStyleBackColor = true;
            // 
            // splitContainerRecipes
            // 
            this.splitContainerRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipes.Location = new System.Drawing.Point(3, 2);
            this.splitContainerRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerRecipes.Name = "splitContainerRecipes";
            // 
            // splitContainerRecipes.Panel1
            // 
            this.splitContainerRecipes.Panel1.Controls.Add(this.dgvRecipes);
            // 
            // splitContainerRecipes.Panel2
            // 
            this.splitContainerRecipes.Panel2.Controls.Add(this.grpRecipeDetail);
            this.splitContainerRecipes.Size = new System.Drawing.Size(934, 436);
            this.splitContainerRecipes.SplitterDistance = 472;
            this.splitContainerRecipes.TabIndex = 0;
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipes.Location = new System.Drawing.Point(0, 0);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.RowTemplate.Height = 27;
            this.dgvRecipes.Size = new System.Drawing.Size(472, 436);
            this.dgvRecipes.TabIndex = 0;
            // 
            // grpRecipeDetail
            // 
            this.grpRecipeDetail.Controls.Add(this.tableRecipeDetail);
            this.grpRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipeDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRecipeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipeDetail.Name = "grpRecipeDetail";
            this.grpRecipeDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipeDetail.Size = new System.Drawing.Size(458, 436);
            this.grpRecipeDetail.TabIndex = 0;
            this.grpRecipeDetail.TabStop = false;
            this.grpRecipeDetail.Text = "요리 정보";
            // 
            // tableRecipeDetail
            // 
            this.tableRecipeDetail.ColumnCount = 2;
            this.tableRecipeDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableRecipeDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRecipeDetail.Controls.Add(this.lblRecipeName, 0, 0);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeName, 1, 0);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeDescription, 0, 1);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeDescription, 1, 1);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeIngredient, 0, 2);
            this.tableRecipeDetail.Controls.Add(this.cmbRecipeIngredient, 1, 2);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeAmount, 0, 3);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeAmount, 1, 3);
            this.tableRecipeDetail.Controls.Add(this.btnAddRecipeIngredient, 1, 4);
            this.tableRecipeDetail.Controls.Add(this.lstRecipeIngredients, 0, 5);
            this.tableRecipeDetail.Controls.Add(this.flowRecipeButtons, 0, 6);
            this.tableRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRecipeDetail.Location = new System.Drawing.Point(3, 16);
            this.tableRecipeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableRecipeDetail.Name = "tableRecipeDetail";
            this.tableRecipeDetail.RowCount = 7;
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRecipeDetail.Size = new System.Drawing.Size(452, 418);
            this.tableRecipeDetail.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(99, 32);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "요리명";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(108, 2);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(341, 21);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblRecipeDescription
            // 
            this.lblRecipeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeDescription.Location = new System.Drawing.Point(3, 32);
            this.lblRecipeDescription.Name = "lblRecipeDescription";
            this.lblRecipeDescription.Size = new System.Drawing.Size(99, 96);
            this.lblRecipeDescription.TabIndex = 2;
            this.lblRecipeDescription.Text = "설명 / 비고";
            this.lblRecipeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeDescription
            // 
            this.txtRecipeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeDescription.Location = new System.Drawing.Point(108, 34);
            this.txtRecipeDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeDescription.Multiline = true;
            this.txtRecipeDescription.Name = "txtRecipeDescription";
            this.txtRecipeDescription.Size = new System.Drawing.Size(341, 92);
            this.txtRecipeDescription.TabIndex = 3;
            // 
            // lblRecipeIngredient
            // 
            this.lblRecipeIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeIngredient.Location = new System.Drawing.Point(3, 128);
            this.lblRecipeIngredient.Name = "lblRecipeIngredient";
            this.lblRecipeIngredient.Size = new System.Drawing.Size(99, 32);
            this.lblRecipeIngredient.TabIndex = 4;
            this.lblRecipeIngredient.Text = "재료 선택";
            this.lblRecipeIngredient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRecipeIngredient
            // 
            this.cmbRecipeIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRecipeIngredient.FormattingEnabled = true;
            this.cmbRecipeIngredient.Location = new System.Drawing.Point(108, 130);
            this.cmbRecipeIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRecipeIngredient.Name = "cmbRecipeIngredient";
            this.cmbRecipeIngredient.Size = new System.Drawing.Size(341, 20);
            this.cmbRecipeIngredient.TabIndex = 5;
            // 
            // lblRecipeAmount
            // 
            this.lblRecipeAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeAmount.Location = new System.Drawing.Point(3, 160);
            this.lblRecipeAmount.Name = "lblRecipeAmount";
            this.lblRecipeAmount.Size = new System.Drawing.Size(99, 32);
            this.lblRecipeAmount.TabIndex = 6;
            this.lblRecipeAmount.Text = "투입량 (g)";
            this.lblRecipeAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeAmount
            // 
            this.txtRecipeAmount.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtRecipeAmount.Location = new System.Drawing.Point(108, 162);
            this.txtRecipeAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeAmount.Name = "txtRecipeAmount";
            this.txtRecipeAmount.Size = new System.Drawing.Size(132, 21);
            this.txtRecipeAmount.TabIndex = 7;
            // 
            // btnAddRecipeIngredient
            // 
            this.btnAddRecipeIngredient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddRecipeIngredient.Location = new System.Drawing.Point(108, 194);
            this.btnAddRecipeIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRecipeIngredient.Name = "btnAddRecipeIngredient";
            this.btnAddRecipeIngredient.Size = new System.Drawing.Size(131, 27);
            this.btnAddRecipeIngredient.TabIndex = 8;
            this.btnAddRecipeIngredient.Text = "재료 추가";
            this.btnAddRecipeIngredient.UseVisualStyleBackColor = true;
            // 
            // lstRecipeIngredients
            // 
            this.tableRecipeDetail.SetColumnSpan(this.lstRecipeIngredients, 2);
            this.lstRecipeIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecipeIngredients.FormattingEnabled = true;
            this.lstRecipeIngredients.ItemHeight = 12;
            this.lstRecipeIngredients.Location = new System.Drawing.Point(3, 226);
            this.lstRecipeIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstRecipeIngredients.Name = "lstRecipeIngredients";
            this.lstRecipeIngredients.Size = new System.Drawing.Size(446, 156);
            this.lstRecipeIngredients.TabIndex = 9;
            // 
            // flowRecipeButtons
            // 
            this.flowRecipeButtons.AutoSize = true;
            this.tableRecipeDetail.SetColumnSpan(this.flowRecipeButtons, 2);
            this.flowRecipeButtons.Controls.Add(this.btnCreateRecipe);
            this.flowRecipeButtons.Controls.Add(this.btnUpdateRecipe);
            this.flowRecipeButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRecipeButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRecipeButtons.Location = new System.Drawing.Point(3, 386);
            this.flowRecipeButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRecipeButtons.Name = "flowRecipeButtons";
            this.flowRecipeButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowRecipeButtons.Size = new System.Drawing.Size(446, 30);
            this.flowRecipeButtons.TabIndex = 10;
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.Location = new System.Drawing.Point(347, 10);
            this.btnCreateRecipe.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(99, 28);
            this.btnCreateRecipe.TabIndex = 0;
            this.btnCreateRecipe.Text = "요리 등록";
            this.btnCreateRecipe.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRecipe
            // 
            this.btnUpdateRecipe.Location = new System.Drawing.Point(239, 10);
            this.btnUpdateRecipe.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnUpdateRecipe.Name = "btnUpdateRecipe";
            this.btnUpdateRecipe.Size = new System.Drawing.Size(99, 28);
            this.btnUpdateRecipe.TabIndex = 1;
            this.btnUpdateRecipe.Text = "요리 수정";
            this.btnUpdateRecipe.UseVisualStyleBackColor = true;
            // 
            // tabMealPlans
            // 
            this.tabMealPlans.Controls.Add(this.splitContainerMealPlans);
            this.tabMealPlans.Location = new System.Drawing.Point(4, 22);
            this.tabMealPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Name = "tabMealPlans";
            this.tabMealPlans.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Size = new System.Drawing.Size(940, 440);
            this.tabMealPlans.TabIndex = 3;
            this.tabMealPlans.Text = "식단 관리";
            this.tabMealPlans.UseVisualStyleBackColor = true;
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
            this.splitContainerMealPlans.Size = new System.Drawing.Size(934, 436);
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
            this.dgvMealPlans.Size = new System.Drawing.Size(472, 436);
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
            this.grpMealPlanDetail.Size = new System.Drawing.Size(458, 436);
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
            this.tableMealPlanDetail.Controls.Add(this.lblMealType, 0, 1);
            this.tableMealPlanDetail.Controls.Add(this.cmbMealType, 1, 1);
            this.tableMealPlanDetail.Controls.Add(this.lblMealRecipes, 0, 2);
            this.tableMealPlanDetail.Controls.Add(this.lstMealRecipes, 1, 2);
            this.tableMealPlanDetail.Controls.Add(this.lblMealNotes, 0, 3);
            this.tableMealPlanDetail.Controls.Add(this.txtMealNotes, 1, 3);
            this.tableMealPlanDetail.Controls.Add(this.flowMealButtons, 0, 4);
            this.tableMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealPlanDetail.Location = new System.Drawing.Point(3, 16);
            this.tableMealPlanDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealPlanDetail.Name = "tableMealPlanDetail";
            this.tableMealPlanDetail.RowCount = 5;
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.Size = new System.Drawing.Size(452, 418);
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
            this.dtpMealDate.Size = new System.Drawing.Size(176, 21);
            this.dtpMealDate.TabIndex = 1;
            // 
            // lblMealType
            // 
            this.lblMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealType.Location = new System.Drawing.Point(3, 32);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(99, 32);
            this.lblMealType.TabIndex = 2;
            this.lblMealType.Text = "식단 구분";
            this.lblMealType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMealType
            // 
            this.cmbMealType.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Items.AddRange(new object[] {
            "조식",
            "중식",
            "석식"});
            this.cmbMealType.Location = new System.Drawing.Point(108, 34);
            this.cmbMealType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(176, 20);
            this.cmbMealType.TabIndex = 3;
            // 
            // lblMealRecipes
            // 
            this.lblMealRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealRecipes.Location = new System.Drawing.Point(3, 64);
            this.lblMealRecipes.Name = "lblMealRecipes";
            this.lblMealRecipes.Size = new System.Drawing.Size(99, 160);
            this.lblMealRecipes.TabIndex = 4;
            this.lblMealRecipes.Text = "요리 구성";
            this.lblMealRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstMealRecipes
            // 
            this.lstMealRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMealRecipes.FormattingEnabled = true;
            this.lstMealRecipes.ItemHeight = 12;
            this.lstMealRecipes.Location = new System.Drawing.Point(108, 66);
            this.lstMealRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMealRecipes.Name = "lstMealRecipes";
            this.lstMealRecipes.Size = new System.Drawing.Size(341, 156);
            this.lstMealRecipes.TabIndex = 5;
            // 
            // lblMealNotes
            // 
            this.lblMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealNotes.Location = new System.Drawing.Point(3, 224);
            this.lblMealNotes.Name = "lblMealNotes";
            this.lblMealNotes.Size = new System.Drawing.Size(99, 96);
            this.lblMealNotes.TabIndex = 6;
            this.lblMealNotes.Text = "비고";
            this.lblMealNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMealNotes
            // 
            this.txtMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMealNotes.Location = new System.Drawing.Point(108, 226);
            this.txtMealNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMealNotes.Multiline = true;
            this.txtMealNotes.Name = "txtMealNotes";
            this.txtMealNotes.Size = new System.Drawing.Size(341, 92);
            this.txtMealNotes.TabIndex = 7;
            // 
            // flowMealButtons
            // 
            this.flowMealButtons.AutoSize = true;
            this.tableMealPlanDetail.SetColumnSpan(this.flowMealButtons, 2);
            this.flowMealButtons.Controls.Add(this.btnRegisterMealPlan);
            this.flowMealButtons.Controls.Add(this.btnUpdateMealPlan);
            this.flowMealButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMealButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowMealButtons.Location = new System.Drawing.Point(3, 322);
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
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.splitContainerUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Size = new System.Drawing.Size(940, 440);
            this.tabUsers.TabIndex = 4;
            this.tabUsers.Text = "이용자 관리";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // splitContainerUsers
            // 
            this.splitContainerUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUsers.Location = new System.Drawing.Point(3, 2);
            this.splitContainerUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerUsers.Name = "splitContainerUsers";
            // 
            // splitContainerUsers.Panel1
            // 
            this.splitContainerUsers.Panel1.Controls.Add(this.dgvUsers);
            // 
            // splitContainerUsers.Panel2
            // 
            this.splitContainerUsers.Panel2.Controls.Add(this.grpUserDetail);
            this.splitContainerUsers.Size = new System.Drawing.Size(934, 436);
            this.splitContainerUsers.SplitterDistance = 472;
            this.splitContainerUsers.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 27;
            this.dgvUsers.Size = new System.Drawing.Size(472, 436);
            this.dgvUsers.TabIndex = 0;
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.Controls.Add(this.tableUserDetail);
            this.grpUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDetail.Location = new System.Drawing.Point(0, 0);
            this.grpUserDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserDetail.Size = new System.Drawing.Size(458, 436);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "이용자 정보";
            // 
            // tableUserDetail
            // 
            this.tableUserDetail.ColumnCount = 2;
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Controls.Add(this.lblUserName, 0, 0);
            this.tableUserDetail.Controls.Add(this.txtUserName, 1, 0);
            this.tableUserDetail.Controls.Add(this.lblUserGrade, 0, 1);
            this.tableUserDetail.Controls.Add(this.txtUserGrade, 1, 1);
            this.tableUserDetail.Controls.Add(this.lblUserClass, 0, 2);
            this.tableUserDetail.Controls.Add(this.txtUserClass, 1, 2);
            this.tableUserDetail.Controls.Add(this.lblUserAllergy, 0, 3);
            this.tableUserDetail.Controls.Add(this.txtUserAllergyNotes, 1, 3);
            this.tableUserDetail.Controls.Add(this.flowUserButtons, 0, 4);
            this.tableUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUserDetail.Location = new System.Drawing.Point(3, 16);
            this.tableUserDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableUserDetail.Name = "tableUserDetail";
            this.tableUserDetail.RowCount = 5;
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Size = new System.Drawing.Size(452, 418);
            this.tableUserDetail.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(3, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(99, 32);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "이름";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(108, 2);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(341, 21);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserGrade
            // 
            this.lblUserGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserGrade.Location = new System.Drawing.Point(3, 32);
            this.lblUserGrade.Name = "lblUserGrade";
            this.lblUserGrade.Size = new System.Drawing.Size(99, 32);
            this.lblUserGrade.TabIndex = 2;
            this.lblUserGrade.Text = "학년";
            this.lblUserGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserGrade
            // 
            this.txtUserGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUserGrade.Location = new System.Drawing.Point(108, 34);
            this.txtUserGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserGrade.Name = "txtUserGrade";
            this.txtUserGrade.Size = new System.Drawing.Size(88, 21);
            this.txtUserGrade.TabIndex = 3;
            // 
            // lblUserClass
            // 
            this.lblUserClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserClass.Location = new System.Drawing.Point(3, 64);
            this.lblUserClass.Name = "lblUserClass";
            this.lblUserClass.Size = new System.Drawing.Size(99, 32);
            this.lblUserClass.TabIndex = 4;
            this.lblUserClass.Text = "반 / 번호";
            this.lblUserClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserClass
            // 
            this.txtUserClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUserClass.Location = new System.Drawing.Point(108, 66);
            this.txtUserClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserClass.Name = "txtUserClass";
            this.txtUserClass.Size = new System.Drawing.Size(132, 21);
            this.txtUserClass.TabIndex = 5;
            // 
            // lblUserAllergy
            // 
            this.lblUserAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserAllergy.Location = new System.Drawing.Point(3, 96);
            this.lblUserAllergy.Name = "lblUserAllergy";
            this.lblUserAllergy.Size = new System.Drawing.Size(99, 96);
            this.lblUserAllergy.TabIndex = 6;
            this.lblUserAllergy.Text = "알레르기 참고";
            this.lblUserAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserAllergyNotes
            // 
            this.txtUserAllergyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAllergyNotes.Location = new System.Drawing.Point(108, 98);
            this.txtUserAllergyNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAllergyNotes.Multiline = true;
            this.txtUserAllergyNotes.Name = "txtUserAllergyNotes";
            this.txtUserAllergyNotes.Size = new System.Drawing.Size(341, 92);
            this.txtUserAllergyNotes.TabIndex = 7;
            // 
            // flowUserButtons
            // 
            this.flowUserButtons.AutoSize = true;
            this.tableUserDetail.SetColumnSpan(this.flowUserButtons, 2);
            this.flowUserButtons.Controls.Add(this.btnRegisterUser);
            this.flowUserButtons.Controls.Add(this.btnUpdateUser);
            this.flowUserButtons.Controls.Add(this.btnManageUserAllergies);
            this.flowUserButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowUserButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowUserButtons.Location = new System.Drawing.Point(3, 194);
            this.flowUserButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowUserButtons.Name = "flowUserButtons";
            this.flowUserButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowUserButtons.Size = new System.Drawing.Size(446, 40);
            this.flowUserButtons.TabIndex = 8;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(330, 10);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(116, 28);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "이용자 등록";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(214, 10);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(107, 28);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "이용자 수정";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnManageUserAllergies
            // 
            this.btnManageUserAllergies.Location = new System.Drawing.Point(98, 10);
            this.btnManageUserAllergies.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnManageUserAllergies.Name = "btnManageUserAllergies";
            this.btnManageUserAllergies.Size = new System.Drawing.Size(107, 28);
            this.btnManageUserAllergies.TabIndex = 2;
            this.btnManageUserAllergies.Text = "알레르기 등록";
            this.btnManageUserAllergies.UseVisualStyleBackColor = true;
            // 
            // tabAllergies
            // 
            this.tabAllergies.Controls.Add(this.splitContainerAllergies);
            this.tabAllergies.Location = new System.Drawing.Point(4, 22);
            this.tabAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Name = "tabAllergies";
            this.tabAllergies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Size = new System.Drawing.Size(940, 440);
            this.tabAllergies.TabIndex = 5;
            this.tabAllergies.Text = "알레르기 관리";
            this.tabAllergies.UseVisualStyleBackColor = true;
            // 
            // splitContainerAllergies
            // 
            this.splitContainerAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergies.Location = new System.Drawing.Point(3, 2);
            this.splitContainerAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerAllergies.Name = "splitContainerAllergies";
            // 
            // splitContainerAllergies.Panel1
            // 
            this.splitContainerAllergies.Panel1.Controls.Add(this.dgvAllergies);
            // 
            // splitContainerAllergies.Panel2
            // 
            this.splitContainerAllergies.Panel2.Controls.Add(this.grpAllergyDetail);
            this.splitContainerAllergies.Size = new System.Drawing.Size(934, 436);
            this.splitContainerAllergies.SplitterDistance = 472;
            this.splitContainerAllergies.TabIndex = 0;
            // 
            // dgvAllergies
            // 
            this.dgvAllergies.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergies.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllergies.Name = "dgvAllergies";
            this.dgvAllergies.RowHeadersWidth = 51;
            this.dgvAllergies.RowTemplate.Height = 27;
            this.dgvAllergies.Size = new System.Drawing.Size(472, 436);
            this.dgvAllergies.TabIndex = 0;
            // 
            // grpAllergyDetail
            // 
            this.grpAllergyDetail.Controls.Add(this.tableAllergyDetail);
            this.grpAllergyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyDetail.Name = "grpAllergyDetail";
            this.grpAllergyDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyDetail.Size = new System.Drawing.Size(458, 436);
            this.grpAllergyDetail.TabIndex = 0;
            this.grpAllergyDetail.TabStop = false;
            this.grpAllergyDetail.Text = "알레르기 정보";
            // 
            // tableAllergyDetail
            // 
            this.tableAllergyDetail.ColumnCount = 2;
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Controls.Add(this.lblAllergyCode, 0, 0);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyCode, 1, 0);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyName, 0, 1);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyName, 1, 1);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyDescription, 0, 2);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyDescription, 1, 2);
            this.tableAllergyDetail.Controls.Add(this.flowAllergyButtons, 0, 3);
            this.tableAllergyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllergyDetail.Location = new System.Drawing.Point(3, 16);
            this.tableAllergyDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllergyDetail.Name = "tableAllergyDetail";
            this.tableAllergyDetail.RowCount = 4;
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Size = new System.Drawing.Size(452, 418);
            this.tableAllergyDetail.TabIndex = 0;
            // 
            // lblAllergyCode
            // 
            this.lblAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyCode.Location = new System.Drawing.Point(3, 0);
            this.lblAllergyCode.Name = "lblAllergyCode";
            this.lblAllergyCode.Size = new System.Drawing.Size(99, 32);
            this.lblAllergyCode.TabIndex = 0;
            this.lblAllergyCode.Text = "코드";
            this.lblAllergyCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyCode
            // 
            this.txtAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyCode.Location = new System.Drawing.Point(108, 2);
            this.txtAllergyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyCode.Name = "txtAllergyCode";
            this.txtAllergyCode.Size = new System.Drawing.Size(341, 21);
            this.txtAllergyCode.TabIndex = 1;
            // 
            // lblAllergyName
            // 
            this.lblAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyName.Location = new System.Drawing.Point(3, 32);
            this.lblAllergyName.Name = "lblAllergyName";
            this.lblAllergyName.Size = new System.Drawing.Size(99, 32);
            this.lblAllergyName.TabIndex = 2;
            this.lblAllergyName.Text = "알레르기명";
            this.lblAllergyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyName
            // 
            this.txtAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyName.Location = new System.Drawing.Point(108, 34);
            this.txtAllergyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyName.Name = "txtAllergyName";
            this.txtAllergyName.Size = new System.Drawing.Size(341, 21);
            this.txtAllergyName.TabIndex = 3;
            // 
            // lblAllergyDescription
            // 
            this.lblAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyDescription.Location = new System.Drawing.Point(3, 64);
            this.lblAllergyDescription.Name = "lblAllergyDescription";
            this.lblAllergyDescription.Size = new System.Drawing.Size(99, 96);
            this.lblAllergyDescription.TabIndex = 4;
            this.lblAllergyDescription.Text = "비고";
            this.lblAllergyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyDescription
            // 
            this.txtAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyDescription.Location = new System.Drawing.Point(108, 66);
            this.txtAllergyDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyDescription.Multiline = true;
            this.txtAllergyDescription.Name = "txtAllergyDescription";
            this.txtAllergyDescription.Size = new System.Drawing.Size(341, 92);
            this.txtAllergyDescription.TabIndex = 5;
            // 
            // flowAllergyButtons
            // 
            this.flowAllergyButtons.AutoSize = true;
            this.tableAllergyDetail.SetColumnSpan(this.flowAllergyButtons, 2);
            this.flowAllergyButtons.Controls.Add(this.btnRegisterAllergy);
            this.flowAllergyButtons.Controls.Add(this.btnUpdateAllergy);
            this.flowAllergyButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowAllergyButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowAllergyButtons.Location = new System.Drawing.Point(3, 162);
            this.flowAllergyButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowAllergyButtons.Name = "flowAllergyButtons";
            this.flowAllergyButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowAllergyButtons.Size = new System.Drawing.Size(446, 40);
            this.flowAllergyButtons.TabIndex = 6;
            // 
            // btnRegisterAllergy
            // 
            this.btnRegisterAllergy.Location = new System.Drawing.Point(339, 10);
            this.btnRegisterAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRegisterAllergy.Name = "btnRegisterAllergy";
            this.btnRegisterAllergy.Size = new System.Drawing.Size(107, 28);
            this.btnRegisterAllergy.TabIndex = 0;
            this.btnRegisterAllergy.Text = "알레르기 등록";
            this.btnRegisterAllergy.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAllergy
            // 
            this.btnUpdateAllergy.Location = new System.Drawing.Point(232, 10);
            this.btnUpdateAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnUpdateAllergy.Name = "btnUpdateAllergy";
            this.btnUpdateAllergy.Size = new System.Drawing.Size(98, 28);
            this.btnUpdateAllergy.TabIndex = 1;
            this.btnUpdateAllergy.Text = "알레르기 수정";
            this.btnUpdateAllergy.UseVisualStyleBackColor = true;
            // 
            // tabAllergyRelations
            // 
            this.tabAllergyRelations.Controls.Add(this.splitContainerAllergyRelations);
            this.tabAllergyRelations.Location = new System.Drawing.Point(4, 22);
            this.tabAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Name = "tabAllergyRelations";
            this.tabAllergyRelations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Size = new System.Drawing.Size(940, 440);
            this.tabAllergyRelations.TabIndex = 6;
            this.tabAllergyRelations.Text = "알레르기 관계";
            this.tabAllergyRelations.UseVisualStyleBackColor = true;
            // 
            // splitContainerAllergyRelations
            // 
            this.splitContainerAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergyRelations.Location = new System.Drawing.Point(3, 2);
            this.splitContainerAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerAllergyRelations.Name = "splitContainerAllergyRelations";
            // 
            // splitContainerAllergyRelations.Panel1
            // 
            this.splitContainerAllergyRelations.Panel1.Controls.Add(this.dgvAllergyRelations);
            // 
            // splitContainerAllergyRelations.Panel2
            // 
            this.splitContainerAllergyRelations.Panel2.Controls.Add(this.grpAllergyRelationDetail);
            this.splitContainerAllergyRelations.Size = new System.Drawing.Size(934, 436);
            this.splitContainerAllergyRelations.SplitterDistance = 472;
            this.splitContainerAllergyRelations.TabIndex = 0;
            // 
            // dgvAllergyRelations
            // 
            this.dgvAllergyRelations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergyRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergyRelations.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllergyRelations.Name = "dgvAllergyRelations";
            this.dgvAllergyRelations.RowHeadersWidth = 51;
            this.dgvAllergyRelations.RowTemplate.Height = 27;
            this.dgvAllergyRelations.Size = new System.Drawing.Size(472, 436);
            this.dgvAllergyRelations.TabIndex = 0;
            // 
            // grpAllergyRelationDetail
            // 
            this.grpAllergyRelationDetail.Controls.Add(this.tableAllergyRelationDetail);
            this.grpAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyRelationDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyRelationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyRelationDetail.Name = "grpAllergyRelationDetail";
            this.grpAllergyRelationDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyRelationDetail.Size = new System.Drawing.Size(458, 436);
            this.grpAllergyRelationDetail.TabIndex = 0;
            this.grpAllergyRelationDetail.TabStop = false;
            this.grpAllergyRelationDetail.Text = "알레르기 연결";
            // 
            // tableAllergyRelationDetail
            // 
            this.tableAllergyRelationDetail.ColumnCount = 2;
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationUser, 0, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationUser, 1, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationAllergy, 0, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationAllergy, 1, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationNotes, 0, 2);
            this.tableAllergyRelationDetail.Controls.Add(this.txtRelationNotes, 1, 2);
            this.tableAllergyRelationDetail.Controls.Add(this.flowRelationButtons, 0, 3);
            this.tableAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllergyRelationDetail.Location = new System.Drawing.Point(3, 16);
            this.tableAllergyRelationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllergyRelationDetail.Name = "tableAllergyRelationDetail";
            this.tableAllergyRelationDetail.RowCount = 4;
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Size = new System.Drawing.Size(452, 418);
            this.tableAllergyRelationDetail.TabIndex = 0;
            // 
            // lblRelationUser
            // 
            this.lblRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationUser.Location = new System.Drawing.Point(3, 0);
            this.lblRelationUser.Name = "lblRelationUser";
            this.lblRelationUser.Size = new System.Drawing.Size(99, 32);
            this.lblRelationUser.TabIndex = 0;
            this.lblRelationUser.Text = "이용자";
            this.lblRelationUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationUser
            // 
            this.cmbRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationUser.FormattingEnabled = true;
            this.cmbRelationUser.Location = new System.Drawing.Point(108, 2);
            this.cmbRelationUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationUser.Name = "cmbRelationUser";
            this.cmbRelationUser.Size = new System.Drawing.Size(341, 20);
            this.cmbRelationUser.TabIndex = 1;
            // 
            // lblRelationAllergy
            // 
            this.lblRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationAllergy.Location = new System.Drawing.Point(3, 32);
            this.lblRelationAllergy.Name = "lblRelationAllergy";
            this.lblRelationAllergy.Size = new System.Drawing.Size(99, 32);
            this.lblRelationAllergy.TabIndex = 2;
            this.lblRelationAllergy.Text = "알레르기";
            this.lblRelationAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationAllergy
            // 
            this.cmbRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationAllergy.FormattingEnabled = true;
            this.cmbRelationAllergy.Location = new System.Drawing.Point(108, 34);
            this.cmbRelationAllergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationAllergy.Name = "cmbRelationAllergy";
            this.cmbRelationAllergy.Size = new System.Drawing.Size(341, 20);
            this.cmbRelationAllergy.TabIndex = 3;
            // 
            // lblRelationNotes
            // 
            this.lblRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationNotes.Location = new System.Drawing.Point(3, 64);
            this.lblRelationNotes.Name = "lblRelationNotes";
            this.lblRelationNotes.Size = new System.Drawing.Size(99, 96);
            this.lblRelationNotes.TabIndex = 4;
            this.lblRelationNotes.Text = "비고";
            this.lblRelationNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRelationNotes
            // 
            this.txtRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelationNotes.Location = new System.Drawing.Point(108, 66);
            this.txtRelationNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRelationNotes.Multiline = true;
            this.txtRelationNotes.Name = "txtRelationNotes";
            this.txtRelationNotes.Size = new System.Drawing.Size(341, 92);
            this.txtRelationNotes.TabIndex = 5;
            // 
            // flowRelationButtons
            // 
            this.flowRelationButtons.AutoSize = true;
            this.tableAllergyRelationDetail.SetColumnSpan(this.flowRelationButtons, 2);
            this.flowRelationButtons.Controls.Add(this.btnLinkAllergy);
            this.flowRelationButtons.Controls.Add(this.btnRemoveAllergy);
            this.flowRelationButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRelationButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRelationButtons.Location = new System.Drawing.Point(3, 162);
            this.flowRelationButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRelationButtons.Name = "flowRelationButtons";
            this.flowRelationButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowRelationButtons.Size = new System.Drawing.Size(446, 40);
            this.flowRelationButtons.TabIndex = 6;
            // 
            // btnLinkAllergy
            // 
            this.btnLinkAllergy.Location = new System.Drawing.Point(339, 10);
            this.btnLinkAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnLinkAllergy.Name = "btnLinkAllergy";
            this.btnLinkAllergy.Size = new System.Drawing.Size(107, 28);
            this.btnLinkAllergy.TabIndex = 0;
            this.btnLinkAllergy.Text = "관계 등록";
            this.btnLinkAllergy.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllergy
            // 
            this.btnRemoveAllergy.Location = new System.Drawing.Point(232, 10);
            this.btnRemoveAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRemoveAllergy.Name = "btnRemoveAllergy";
            this.btnRemoveAllergy.Size = new System.Drawing.Size(98, 28);
            this.btnRemoveAllergy.TabIndex = 1;
            this.btnRemoveAllergy.Text = "관계 삭제";
            this.btnRemoveAllergy.UseVisualStyleBackColor = true;
            // 
            // tabMealEvaluations
            // 
            this.tabMealEvaluations.Controls.Add(this.splitContainerMealEvaluations);
            this.tabMealEvaluations.Location = new System.Drawing.Point(4, 22);
            this.tabMealEvaluations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Name = "tabMealEvaluations";
            this.tabMealEvaluations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Size = new System.Drawing.Size(940, 440);
            this.tabMealEvaluations.TabIndex = 7;
            this.tabMealEvaluations.Text = "식단 평가";
            this.tabMealEvaluations.UseVisualStyleBackColor = true;
            // 
            // splitContainerMealEvaluations
            // 
            this.splitContainerMealEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMealEvaluations.Location = new System.Drawing.Point(3, 2);
            this.splitContainerMealEvaluations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMealEvaluations.Name = "splitContainerMealEvaluations";
            // 
            // splitContainerMealEvaluations.Panel1
            // 
            this.splitContainerMealEvaluations.Panel1.Controls.Add(this.dgvMealEvaluations);
            // 
            // splitContainerMealEvaluations.Panel2
            // 
            this.splitContainerMealEvaluations.Panel2.Controls.Add(this.grpMealEvaluationDetail);
            this.splitContainerMealEvaluations.Size = new System.Drawing.Size(934, 436);
            this.splitContainerMealEvaluations.SplitterDistance = 472;
            this.splitContainerMealEvaluations.TabIndex = 0;
            // 
            // dgvMealEvaluations
            // 
            this.dgvMealEvaluations.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealEvaluations.Location = new System.Drawing.Point(0, 0);
            this.dgvMealEvaluations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealEvaluations.Name = "dgvMealEvaluations";
            this.dgvMealEvaluations.RowHeadersWidth = 51;
            this.dgvMealEvaluations.RowTemplate.Height = 27;
            this.dgvMealEvaluations.Size = new System.Drawing.Size(472, 436);
            this.dgvMealEvaluations.TabIndex = 0;
            // 
            // grpMealEvaluationDetail
            // 
            this.grpMealEvaluationDetail.Controls.Add(this.tableMealEvaluationDetail);
            this.grpMealEvaluationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealEvaluationDetail.Location = new System.Drawing.Point(0, 0);
            this.grpMealEvaluationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealEvaluationDetail.Name = "grpMealEvaluationDetail";
            this.grpMealEvaluationDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealEvaluationDetail.Size = new System.Drawing.Size(458, 436);
            this.grpMealEvaluationDetail.TabIndex = 0;
            this.grpMealEvaluationDetail.TabStop = false;
            this.grpMealEvaluationDetail.Text = "평가 정보";
            // 
            // tableMealEvaluationDetail
            // 
            this.tableMealEvaluationDetail.ColumnCount = 2;
            this.tableMealEvaluationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableMealEvaluationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationMeal, 0, 0);
            this.tableMealEvaluationDetail.Controls.Add(this.cmbEvaluationMeal, 1, 0);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationUser, 0, 1);
            this.tableMealEvaluationDetail.Controls.Add(this.cmbEvaluationUser, 1, 1);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationScore, 0, 2);
            this.tableMealEvaluationDetail.Controls.Add(this.nudEvaluationScore, 1, 2);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationComment, 0, 3);
            this.tableMealEvaluationDetail.Controls.Add(this.txtEvaluationComment, 1, 3);
            this.tableMealEvaluationDetail.Controls.Add(this.flowEvaluationButtons, 0, 4);
            this.tableMealEvaluationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealEvaluationDetail.Location = new System.Drawing.Point(3, 16);
            this.tableMealEvaluationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealEvaluationDetail.Name = "tableMealEvaluationDetail";
            this.tableMealEvaluationDetail.RowCount = 5;
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealEvaluationDetail.Size = new System.Drawing.Size(452, 418);
            this.tableMealEvaluationDetail.TabIndex = 0;
            // 
            // lblEvaluationMeal
            // 
            this.lblEvaluationMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationMeal.Location = new System.Drawing.Point(3, 0);
            this.lblEvaluationMeal.Name = "lblEvaluationMeal";
            this.lblEvaluationMeal.Size = new System.Drawing.Size(99, 32);
            this.lblEvaluationMeal.TabIndex = 0;
            this.lblEvaluationMeal.Text = "식단";
            this.lblEvaluationMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEvaluationMeal
            // 
            this.cmbEvaluationMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEvaluationMeal.FormattingEnabled = true;
            this.cmbEvaluationMeal.Location = new System.Drawing.Point(108, 2);
            this.cmbEvaluationMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEvaluationMeal.Name = "cmbEvaluationMeal";
            this.cmbEvaluationMeal.Size = new System.Drawing.Size(341, 20);
            this.cmbEvaluationMeal.TabIndex = 1;
            // 
            // lblEvaluationUser
            // 
            this.lblEvaluationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationUser.Location = new System.Drawing.Point(3, 32);
            this.lblEvaluationUser.Name = "lblEvaluationUser";
            this.lblEvaluationUser.Size = new System.Drawing.Size(99, 32);
            this.lblEvaluationUser.TabIndex = 2;
            this.lblEvaluationUser.Text = "이용자";
            this.lblEvaluationUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEvaluationUser
            // 
            this.cmbEvaluationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEvaluationUser.FormattingEnabled = true;
            this.cmbEvaluationUser.Location = new System.Drawing.Point(108, 34);
            this.cmbEvaluationUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEvaluationUser.Name = "cmbEvaluationUser";
            this.cmbEvaluationUser.Size = new System.Drawing.Size(341, 20);
            this.cmbEvaluationUser.TabIndex = 3;
            // 
            // lblEvaluationScore
            // 
            this.lblEvaluationScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationScore.Location = new System.Drawing.Point(3, 64);
            this.lblEvaluationScore.Name = "lblEvaluationScore";
            this.lblEvaluationScore.Size = new System.Drawing.Size(99, 32);
            this.lblEvaluationScore.TabIndex = 4;
            this.lblEvaluationScore.Text = "점수 (1-5)";
            this.lblEvaluationScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEvaluationScore
            // 
            this.nudEvaluationScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudEvaluationScore.Location = new System.Drawing.Point(108, 66);
            this.nudEvaluationScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudEvaluationScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudEvaluationScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEvaluationScore.Name = "nudEvaluationScore";
            this.nudEvaluationScore.Size = new System.Drawing.Size(105, 21);
            this.nudEvaluationScore.TabIndex = 5;
            this.nudEvaluationScore.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblEvaluationComment
            // 
            this.lblEvaluationComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationComment.Location = new System.Drawing.Point(3, 96);
            this.lblEvaluationComment.Name = "lblEvaluationComment";
            this.lblEvaluationComment.Size = new System.Drawing.Size(99, 96);
            this.lblEvaluationComment.TabIndex = 6;
            this.lblEvaluationComment.Text = "의견";
            this.lblEvaluationComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEvaluationComment
            // 
            this.txtEvaluationComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvaluationComment.Location = new System.Drawing.Point(108, 98);
            this.txtEvaluationComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvaluationComment.Multiline = true;
            this.txtEvaluationComment.Name = "txtEvaluationComment";
            this.txtEvaluationComment.Size = new System.Drawing.Size(341, 92);
            this.txtEvaluationComment.TabIndex = 7;
            // 
            // flowEvaluationButtons
            // 
            this.flowEvaluationButtons.AutoSize = true;
            this.tableMealEvaluationDetail.SetColumnSpan(this.flowEvaluationButtons, 2);
            this.flowEvaluationButtons.Controls.Add(this.btnRegisterEvaluation);
            this.flowEvaluationButtons.Controls.Add(this.btnRefreshEvaluation);
            this.flowEvaluationButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowEvaluationButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowEvaluationButtons.Location = new System.Drawing.Point(3, 194);
            this.flowEvaluationButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowEvaluationButtons.Name = "flowEvaluationButtons";
            this.flowEvaluationButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowEvaluationButtons.Size = new System.Drawing.Size(446, 40);
            this.flowEvaluationButtons.TabIndex = 8;
            // 
            // btnRegisterEvaluation
            // 
            this.btnRegisterEvaluation.Location = new System.Drawing.Point(339, 10);
            this.btnRegisterEvaluation.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRegisterEvaluation.Name = "btnRegisterEvaluation";
            this.btnRegisterEvaluation.Size = new System.Drawing.Size(107, 28);
            this.btnRegisterEvaluation.TabIndex = 0;
            this.btnRegisterEvaluation.Text = "평가 등록";
            this.btnRegisterEvaluation.UseVisualStyleBackColor = true;
            // 
            // btnRefreshEvaluation
            // 
            this.btnRefreshEvaluation.Location = new System.Drawing.Point(232, 10);
            this.btnRefreshEvaluation.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRefreshEvaluation.Name = "btnRefreshEvaluation";
            this.btnRefreshEvaluation.Size = new System.Drawing.Size(98, 28);
            this.btnRefreshEvaluation.TabIndex = 1;
            this.btnRefreshEvaluation.Text = "평가 조회";
            this.btnRefreshEvaluation.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 520);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학교 급양 관리 시스템";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.grpMealLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.grpMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            this.grpStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.tabManagement.ResumeLayout(false);
            this.tabControlManagement.ResumeLayout(false);
            this.tabIngredients.ResumeLayout(false);
            this.splitContainerIngredients.Panel1.ResumeLayout(false);
            this.splitContainerIngredients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).EndInit();
            this.splitContainerIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.grpIngredientDetail.ResumeLayout(false);
            this.tableIngredientDetail.ResumeLayout(false);
            this.tableIngredientDetail.PerformLayout();
            this.flowIngredientButtons.ResumeLayout(false);
            this.tabNutrients.ResumeLayout(false);
            this.splitContainerNutrients.Panel1.ResumeLayout(false);
            this.splitContainerNutrients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).EndInit();
            this.splitContainerNutrients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).EndInit();
            this.grpNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.PerformLayout();
            this.tabRecipes.ResumeLayout(false);
            this.splitContainerRecipes.Panel1.ResumeLayout(false);
            this.splitContainerRecipes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            this.splitContainerRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.grpRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.PerformLayout();
            this.flowRecipeButtons.ResumeLayout(false);
            this.tabMealPlans.ResumeLayout(false);
            this.splitContainerMealPlans.Panel1.ResumeLayout(false);
            this.splitContainerMealPlans.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).EndInit();
            this.splitContainerMealPlans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).EndInit();
            this.grpMealPlanDetail.ResumeLayout(false);
            this.tableMealPlanDetail.ResumeLayout(false);
            this.tableMealPlanDetail.PerformLayout();
            this.flowMealButtons.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.splitContainerUsers.Panel1.ResumeLayout(false);
            this.splitContainerUsers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).EndInit();
            this.splitContainerUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpUserDetail.ResumeLayout(false);
            this.tableUserDetail.ResumeLayout(false);
            this.tableUserDetail.PerformLayout();
            this.flowUserButtons.ResumeLayout(false);
            this.tabAllergies.ResumeLayout(false);
            this.splitContainerAllergies.Panel1.ResumeLayout(false);
            this.splitContainerAllergies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).EndInit();
            this.splitContainerAllergies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).EndInit();
            this.grpAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.PerformLayout();
            this.flowAllergyButtons.ResumeLayout(false);
            this.tabAllergyRelations.ResumeLayout(false);
            this.splitContainerAllergyRelations.Panel1.ResumeLayout(false);
            this.splitContainerAllergyRelations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).EndInit();
            this.splitContainerAllergyRelations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).EndInit();
            this.grpAllergyRelationDetail.ResumeLayout(false);
            this.tableAllergyRelationDetail.ResumeLayout(false);
            this.tableAllergyRelationDetail.PerformLayout();
            this.flowRelationButtons.ResumeLayout(false);
            this.tabMealEvaluations.ResumeLayout(false);
            this.splitContainerMealEvaluations.Panel1.ResumeLayout(false);
            this.splitContainerMealEvaluations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).EndInit();
            this.splitContainerMealEvaluations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).EndInit();
            this.grpMealEvaluationDetail.ResumeLayout(false);
            this.tableMealEvaluationDetail.ResumeLayout(false);
            this.tableMealEvaluationDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).EndInit();
            this.flowEvaluationButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabManagement;
        private System.Windows.Forms.GroupBox grpMealLogs;
        private System.Windows.Forms.DataGridView dgvMealLogs;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnCancelMeal;
        private System.Windows.Forms.Button btnServeMeal;
        private System.Windows.Forms.TextBox txtMenuCode;
        private System.Windows.Forms.Label lblMenuCode;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.GroupBox grpMenus;
        private System.Windows.Forms.DataGridView dgvMenus;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblNotMealValue;
        private System.Windows.Forms.Label lblNotMeal;
        private System.Windows.Forms.Label lblTodayMealValue;
        private System.Windows.Forms.Label lblTodayMeal;
        private System.Windows.Forms.Label lblTotalStudentValue;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.TabControl tabControlManagement;
        private System.Windows.Forms.TabPage tabIngredients;
        private System.Windows.Forms.SplitContainer splitContainerIngredients;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.GroupBox grpIngredientDetail;
        private System.Windows.Forms.TableLayoutPanel tableIngredientDetail;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Label lblIngredientUnit;
        private System.Windows.Forms.TextBox txtIngredientUnit;
        private System.Windows.Forms.Label lblIngredientNutrient;
        private System.Windows.Forms.TextBox txtIngredientNutrient;
        private System.Windows.Forms.FlowLayoutPanel flowIngredientButtons;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnUpdateIngredient;
        private System.Windows.Forms.TabPage tabNutrients;
        private System.Windows.Forms.SplitContainer splitContainerNutrients;
        private System.Windows.Forms.DataGridView dgvNutrients;
        private System.Windows.Forms.GroupBox grpNutrientDetail;
        private System.Windows.Forms.TableLayoutPanel tableNutrientDetail;
        private System.Windows.Forms.Label lblNutrientCode;
        private System.Windows.Forms.TextBox txtNutrientCode;
        private System.Windows.Forms.Label lblNutrientName;
        private System.Windows.Forms.TextBox txtNutrientName;
        private System.Windows.Forms.Label lblNutrientUnit;
        private System.Windows.Forms.TextBox txtNutrientUnit;
        private System.Windows.Forms.Button btnSearchNutrient;
        private System.Windows.Forms.TabPage tabRecipes;
        private System.Windows.Forms.SplitContainer splitContainerRecipes;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox grpRecipeDetail;
        private System.Windows.Forms.TableLayoutPanel tableRecipeDetail;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblRecipeDescription;
        private System.Windows.Forms.TextBox txtRecipeDescription;
        private System.Windows.Forms.Label lblRecipeIngredient;
        private System.Windows.Forms.ComboBox cmbRecipeIngredient;
        private System.Windows.Forms.Label lblRecipeAmount;
        private System.Windows.Forms.TextBox txtRecipeAmount;
        private System.Windows.Forms.Button btnAddRecipeIngredient;
        private System.Windows.Forms.ListBox lstRecipeIngredients;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeButtons;
        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.Button btnUpdateRecipe;
        private System.Windows.Forms.TabPage tabMealPlans;
        private System.Windows.Forms.SplitContainer splitContainerMealPlans;
        private System.Windows.Forms.DataGridView dgvMealPlans;
        private System.Windows.Forms.GroupBox grpMealPlanDetail;
        private System.Windows.Forms.TableLayoutPanel tableMealPlanDetail;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.Label lblMealRecipes;
        private System.Windows.Forms.ListBox lstMealRecipes;
        private System.Windows.Forms.Label lblMealNotes;
        private System.Windows.Forms.TextBox txtMealNotes;
        private System.Windows.Forms.FlowLayoutPanel flowMealButtons;
        private System.Windows.Forms.Button btnRegisterMealPlan;
        private System.Windows.Forms.Button btnUpdateMealPlan;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.SplitContainer splitContainerUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.TableLayoutPanel tableUserDetail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserGrade;
        private System.Windows.Forms.TextBox txtUserGrade;
        private System.Windows.Forms.Label lblUserClass;
        private System.Windows.Forms.TextBox txtUserClass;
        private System.Windows.Forms.Label lblUserAllergy;
        private System.Windows.Forms.TextBox txtUserAllergyNotes;
        private System.Windows.Forms.FlowLayoutPanel flowUserButtons;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnManageUserAllergies;
        private System.Windows.Forms.TabPage tabAllergies;
        private System.Windows.Forms.SplitContainer splitContainerAllergies;
        private System.Windows.Forms.DataGridView dgvAllergies;
        private System.Windows.Forms.GroupBox grpAllergyDetail;
        private System.Windows.Forms.TableLayoutPanel tableAllergyDetail;
        private System.Windows.Forms.Label lblAllergyCode;
        private System.Windows.Forms.TextBox txtAllergyCode;
        private System.Windows.Forms.Label lblAllergyName;
        private System.Windows.Forms.TextBox txtAllergyName;
        private System.Windows.Forms.Label lblAllergyDescription;
        private System.Windows.Forms.TextBox txtAllergyDescription;
        private System.Windows.Forms.FlowLayoutPanel flowAllergyButtons;
        private System.Windows.Forms.Button btnRegisterAllergy;
        private System.Windows.Forms.Button btnUpdateAllergy;
        private System.Windows.Forms.TabPage tabAllergyRelations;
        private System.Windows.Forms.SplitContainer splitContainerAllergyRelations;
        private System.Windows.Forms.DataGridView dgvAllergyRelations;
        private System.Windows.Forms.GroupBox grpAllergyRelationDetail;
        private System.Windows.Forms.TableLayoutPanel tableAllergyRelationDetail;
        private System.Windows.Forms.Label lblRelationUser;
        private System.Windows.Forms.ComboBox cmbRelationUser;
        private System.Windows.Forms.Label lblRelationAllergy;
        private System.Windows.Forms.ComboBox cmbRelationAllergy;
        private System.Windows.Forms.Label lblRelationNotes;
        private System.Windows.Forms.TextBox txtRelationNotes;
        private System.Windows.Forms.FlowLayoutPanel flowRelationButtons;
        private System.Windows.Forms.Button btnLinkAllergy;
        private System.Windows.Forms.Button btnRemoveAllergy;
        private System.Windows.Forms.TabPage tabMealEvaluations;
        private System.Windows.Forms.SplitContainer splitContainerMealEvaluations;
        private System.Windows.Forms.DataGridView dgvMealEvaluations;
        private System.Windows.Forms.GroupBox grpMealEvaluationDetail;
        private System.Windows.Forms.TableLayoutPanel tableMealEvaluationDetail;
        private System.Windows.Forms.Label lblEvaluationMeal;
        private System.Windows.Forms.ComboBox cmbEvaluationMeal;
        private System.Windows.Forms.Label lblEvaluationUser;
        private System.Windows.Forms.ComboBox cmbEvaluationUser;
        private System.Windows.Forms.Label lblEvaluationScore;
        private System.Windows.Forms.NumericUpDown nudEvaluationScore;
        private System.Windows.Forms.Label lblEvaluationComment;
        private System.Windows.Forms.TextBox txtEvaluationComment;
        private System.Windows.Forms.FlowLayoutPanel flowEvaluationButtons;
        private System.Windows.Forms.Button btnRegisterEvaluation;
        private System.Windows.Forms.Button btnRefreshEvaluation;
    }
}
