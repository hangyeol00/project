namespace nutritionist
{
    partial class NutritionistForm
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
            this.menuAddRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panelWorkspace = new System.Windows.Forms.Panel();
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
            this.tabRawMaterials = new System.Windows.Forms.TabPage();
            this.panelRawToolbar = new System.Windows.Forms.Panel();
            this.flowRawCalorieFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRawCalorie = new System.Windows.Forms.Label();
            this.nudRawCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.lblRawCalorieSeparator = new System.Windows.Forms.Label();
            this.nudRawCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.lblRawCalorieUnit = new System.Windows.Forms.Label();
            this.flowRawNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRawNutrientFilter = new System.Windows.Forms.Label();
            this.chkRawNutrientProtein = new System.Windows.Forms.CheckBox();
            this.chkRawNutrientFat = new System.Windows.Forms.CheckBox();
            this.chkRawNutrientCarb = new System.Windows.Forms.CheckBox();
            this.chkRawGroup = new System.Windows.Forms.CheckBox();
            this.btnRawClear = new System.Windows.Forms.Button();
            this.btnRawSearch = new System.Windows.Forms.Button();
            this.txtRawSearch = new System.Windows.Forms.TextBox();
            this.lblRawSearch = new System.Windows.Forms.Label();
            this.splitContainerRawMaterials = new System.Windows.Forms.SplitContainer();
            this.tvRawMaterials = new System.Windows.Forms.TreeView();
            this.dgvRawMaterials = new System.Windows.Forms.DataGridView();
            this.grpRawDetail = new System.Windows.Forms.GroupBox();
            this.tableRawDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRawDetailName = new System.Windows.Forms.Label();
            this.txtRawDetailName = new System.Windows.Forms.TextBox();
            this.lblRawDetailCategory = new System.Windows.Forms.Label();
            this.txtRawDetailCategory = new System.Windows.Forms.TextBox();
            this.lblRawDetailUnit = new System.Windows.Forms.Label();
            this.txtRawDetailUnit = new System.Windows.Forms.TextBox();
            this.lblRawDetailBaseQty = new System.Windows.Forms.Label();
            this.txtRawDetailBaseQty = new System.Windows.Forms.TextBox();
            this.lblRawDetailStorage = new System.Windows.Forms.Label();
            this.txtRawDetailStorage = new System.Windows.Forms.TextBox();
            this.lblRawDetailShelfLife = new System.Windows.Forms.Label();
            this.txtRawDetailShelfLife = new System.Windows.Forms.TextBox();
            this.lblRawDetailActive = new System.Windows.Forms.Label();
            this.txtRawDetailActive = new System.Windows.Forms.TextBox();
            this.lblRawNutrients = new System.Windows.Forms.Label();
            this.dgvRawNutrients = new System.Windows.Forms.DataGridView();
            this.lblRawComponents = new System.Windows.Forms.Label();
            this.dgvRawComponents = new System.Windows.Forms.DataGridView();
            this.splitContainerRawDetail = new System.Windows.Forms.SplitContainer();
            this.flowRawButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRawAdd = new System.Windows.Forms.Button();
            this.btnRawRefresh = new System.Windows.Forms.Button();
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
            this.panelRecipeToolbar = new System.Windows.Forms.Panel();
            this.flowRecipeCalorieFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecipeCalorie = new System.Windows.Forms.Label();
            this.nudRecipeCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.lblRecipeCalorieSeparator = new System.Windows.Forms.Label();
            this.nudRecipeCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.lblRecipeCalorieUnit = new System.Windows.Forms.Label();
            this.flowRecipeNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecipeNutrientFilter = new System.Windows.Forms.Label();
            this.chkRecipeNutrientProtein = new System.Windows.Forms.CheckBox();
            this.chkRecipeNutrientFat = new System.Windows.Forms.CheckBox();
            this.chkRecipeNutrientCarb = new System.Windows.Forms.CheckBox();
            this.btnRecipeClear = new System.Windows.Forms.Button();
            this.btnRecipeSearch = new System.Windows.Forms.Button();
            this.txtRecipeSearch = new System.Windows.Forms.TextBox();
            this.lblRecipeSearch = new System.Windows.Forms.Label();
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.grpRecipeDetail = new System.Windows.Forms.GroupBox();
            this.tableRecipeDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeCode = new System.Windows.Forms.Label();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.lblRecipeType = new System.Windows.Forms.Label();
            this.txtRecipeType = new System.Windows.Forms.TextBox();
            this.lblRecipeServing = new System.Windows.Forms.Label();
            this.txtRecipeServing = new System.Windows.Forms.TextBox();
            this.lblRecipeActive = new System.Windows.Forms.Label();
            this.txtRecipeActive = new System.Windows.Forms.TextBox();
            this.splitContainerRecipeDetail = new System.Windows.Forms.SplitContainer();
            this.dgvRecipeNutrients = new System.Windows.Forms.DataGridView();
            this.lblRecipeNutrients = new System.Windows.Forms.Label();
            this.dgvRecipeComponents = new System.Windows.Forms.DataGridView();
            this.lblRecipeComponents = new System.Windows.Forms.Label();
            this.flowRecipeButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshRecipe = new System.Windows.Forms.Button();
            this.btnRegisterRecipe = new System.Windows.Forms.Button();
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnNavManagement = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
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
            this.tabRawMaterials.SuspendLayout();
            this.panelRawToolbar.SuspendLayout();
            this.flowRawCalorieFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).BeginInit();
            this.flowRawNutrientFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).BeginInit();
            this.splitContainerRawMaterials.Panel1.SuspendLayout();
            this.splitContainerRawMaterials.Panel2.SuspendLayout();
            this.splitContainerRawMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            this.grpRawDetail.SuspendLayout();
            this.tableRawDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).BeginInit();
            this.splitContainerRawDetail.Panel1.SuspendLayout();
            this.splitContainerRawDetail.Panel2.SuspendLayout();
            this.splitContainerRawDetail.SuspendLayout();
            this.flowRawButtons.SuspendLayout();
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
            this.panelRecipeToolbar.SuspendLayout();
            this.flowRecipeCalorieFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).BeginInit();
            this.flowRecipeNutrientFilters.SuspendLayout();
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
            this.panelNav.SuspendLayout();
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
            this.menuStrip.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReload,
            this.menuAddRaw,
            this.menuOpenAdmin,
            this.menuSeparator,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(43, 20);
            this.menuFile.Text = "메뉴";
            // 
            // menuAddRaw
            // 
            this.menuAddRaw.Name = "menuAddRaw";
            this.menuAddRaw.Size = new System.Drawing.Size(166, 22);
            this.menuAddRaw.Text = "원재료 등록";
            // 
            // menuReload
            // 
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(166, 22);
            this.menuReload.Text = "새로고침";
            // 
            // menuOpenAdmin
            // 
            this.menuOpenAdmin.Name = "menuOpenAdmin";
            this.menuOpenAdmin.Size = new System.Drawing.Size(166, 22);
            this.menuOpenAdmin.Text = "관리자 화면 열기";
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(163, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(166, 22);
            this.menuExit.Text = "종료";
            // 
            // panelWorkspace
            // 
            this.panelWorkspace.BackColor = System.Drawing.Color.White;
            this.panelWorkspace.Controls.Add(this.tabMain);
            this.panelWorkspace.Controls.Add(this.panelNav);
            this.panelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkspace.Location = new System.Drawing.Point(0, 24);
            this.panelWorkspace.Name = "panelWorkspace";
            this.panelWorkspace.Size = new System.Drawing.Size(1182, 496);
            this.panelWorkspace.TabIndex = 1;
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabDashboard);
            this.tabMain.Controls.Add(this.tabManagement);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tabMain.Location = new System.Drawing.Point(220, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(962, 496);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 2;
            this.tabMain.TabStop = false;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.TabMain_SelectedIndexChanged);
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.White;
            this.tabDashboard.Controls.Add(this.grpMealLogs);
            this.tabDashboard.Controls.Add(this.grpAction);
            this.tabDashboard.Controls.Add(this.grpMenus);
            this.tabDashboard.Controls.Add(this.grpStudents);
            this.tabDashboard.Controls.Add(this.grpSummary);
            this.tabDashboard.Location = new System.Drawing.Point(4, 5);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Size = new System.Drawing.Size(954, 487);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "메인 현황";
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
            this.grpMealLogs.Text = "식단 계획";
            // 
            // dgvMealLogs
            // 
            this.dgvMealLogs.AllowUserToAddRows = false;
            this.dgvMealLogs.AllowUserToDeleteRows = false;
            this.dgvMealLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealLogs.Location = new System.Drawing.Point(3, 20);
            this.dgvMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealLogs.MultiSelect = false;
            this.dgvMealLogs.Name = "dgvMealLogs";
            this.dgvMealLogs.ReadOnly = true;
            this.dgvMealLogs.RowHeadersWidth = 51;
            this.dgvMealLogs.RowTemplate.Height = 27;
            this.dgvMealLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealLogs.Size = new System.Drawing.Size(922, 146);
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
            this.grpAction.Text = "업무 작업";
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Location = new System.Drawing.Point(149, 104);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(96, 32);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "발주 요청 등록";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Location = new System.Drawing.Point(26, 104);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(96, 32);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "식단 계획 등록";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(105, 60);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.ReadOnly = true;
            this.txtMenuCode.Size = new System.Drawing.Size(149, 25);
            this.txtMenuCode.TabIndex = 3;
            this.txtMenuCode.TabStop = false;
            // 
            // lblMenuCode
            // 
            this.lblMenuCode.AutoSize = true;
            this.lblMenuCode.Location = new System.Drawing.Point(13, 64);
            this.lblMenuCode.Name = "lblMenuCode";
            this.lblMenuCode.Size = new System.Drawing.Size(106, 19);
            this.lblMenuCode.TabIndex = 2;
            this.lblMenuCode.Text = "선택 식단 계획:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(105, 28);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(149, 25);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TabStop = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(13, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(87, 19);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "선택 원재료:";
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
            this.grpMenus.Text = "최종 메뉴";
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.Location = new System.Drawing.Point(3, 20);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMenus.MultiSelect = false;
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.RowTemplate.Height = 27;
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Size = new System.Drawing.Size(256, 162);
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
            this.grpStudents.Text = "원재료 목록";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 20);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 27;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(344, 162);
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
            this.lblNotMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
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
            this.lblNotMeal.Size = new System.Drawing.Size(78, 19);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "대기 발주 :";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.AutoSize = true;
            this.lblTodayMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
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
            this.lblTodayMeal.Size = new System.Drawing.Size(78, 19);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "등록 식단 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.AutoSize = true;
            this.lblTotalStudentValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
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
            this.lblTotalStudent.Size = new System.Drawing.Size(92, 19);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "등록 원재료 :";
            // 
            // tabManagement
            // 
            this.tabManagement.BackColor = System.Drawing.Color.White;
            this.tabManagement.Controls.Add(this.tabControlManagement);
            this.tabManagement.Location = new System.Drawing.Point(4, 5);
            this.tabManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabManagement.Size = new System.Drawing.Size(954, 487);
            this.tabManagement.TabIndex = 1;
            this.tabManagement.Text = "상세 관리";
            // 
            // tabControlManagement
            // 
            this.tabControlManagement.Controls.Add(this.tabRawMaterials);
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
            this.tabControlManagement.Size = new System.Drawing.Size(948, 483);
            this.tabControlManagement.TabIndex = 0;
            // 
            // tabRawMaterials
            // 
            this.tabRawMaterials.Controls.Add(this.splitContainerRawMaterials);
            this.tabRawMaterials.Controls.Add(this.panelRawToolbar);
            this.tabRawMaterials.Location = new System.Drawing.Point(4, 26);
            this.tabRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRawMaterials.Name = "tabRawMaterials";
            this.tabRawMaterials.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRawMaterials.Size = new System.Drawing.Size(940, 453);
            this.tabRawMaterials.TabIndex = 0;
            this.tabRawMaterials.Text = "재료 관리";
            this.tabRawMaterials.UseVisualStyleBackColor = true;
            // 
            // splitContainerRawMaterials
            // 
            this.splitContainerRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawMaterials.Location = new System.Drawing.Point(3, 48);
            this.splitContainerRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerRawMaterials.Name = "splitContainerRawMaterials";
            // 
            // splitContainerRawMaterials.Panel1
            // 
            this.splitContainerRawMaterials.Panel1.Controls.Add(this.tvRawMaterials);
            this.splitContainerRawMaterials.Panel1.Controls.Add(this.dgvRawMaterials);
            // 
            // splitContainerRawMaterials.Panel2
            // 
            this.splitContainerRawMaterials.Panel2.Controls.Add(this.grpRawDetail);
            this.splitContainerRawMaterials.Size = new System.Drawing.Size(934, 403);
            this.splitContainerRawMaterials.SplitterDistance = 472;
            this.splitContainerRawMaterials.TabIndex = 1;
            // 
            // dgvRawMaterials
            // 
            this.dgvRawMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.dgvRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRawMaterials.Name = "dgvRawMaterials";
            this.dgvRawMaterials.RowHeadersWidth = 51;
            this.dgvRawMaterials.RowTemplate.Height = 27;
            this.dgvRawMaterials.Size = new System.Drawing.Size(472, 401);
            this.dgvRawMaterials.TabIndex = 0;
            // 
            // tvRawMaterials
            // 
            this.tvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRawMaterials.HideSelection = false;
            this.tvRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.tvRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvRawMaterials.Name = "tvRawMaterials";
            this.tvRawMaterials.Size = new System.Drawing.Size(472, 401);
            this.tvRawMaterials.TabIndex = 1;
            // 
            // grpRawDetail
            // 
            this.grpRawDetail.Controls.Add(this.splitContainerRawDetail);
            this.grpRawDetail.Controls.Add(this.tableRawDetail);
            this.grpRawDetail.Controls.Add(this.flowRawButtons);
            this.grpRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRawDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRawDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRawDetail.Name = "grpRawDetail";
            this.grpRawDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRawDetail.Size = new System.Drawing.Size(458, 403);
            this.grpRawDetail.TabIndex = 0;
            this.grpRawDetail.TabStop = false;
            this.grpRawDetail.Text = "상세 정보";
            // 
            // tableRawDetail
            // 
            this.tableRawDetail.ColumnCount = 2;
            this.tableRawDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableRawDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRawDetail.Controls.Add(this.lblRawDetailName, 0, 0);
            this.tableRawDetail.Controls.Add(this.txtRawDetailName, 1, 0);
            this.tableRawDetail.Controls.Add(this.lblRawDetailCategory, 0, 1);
            this.tableRawDetail.Controls.Add(this.txtRawDetailCategory, 1, 1);
            this.tableRawDetail.Controls.Add(this.lblRawDetailUnit, 0, 2);
            this.tableRawDetail.Controls.Add(this.txtRawDetailUnit, 1, 2);
            this.tableRawDetail.Controls.Add(this.lblRawDetailBaseQty, 0, 3);
            this.tableRawDetail.Controls.Add(this.txtRawDetailBaseQty, 1, 3);
            this.tableRawDetail.Controls.Add(this.lblRawDetailStorage, 0, 4);
            this.tableRawDetail.Controls.Add(this.txtRawDetailStorage, 1, 4);
            this.tableRawDetail.Controls.Add(this.lblRawDetailShelfLife, 0, 5);
            this.tableRawDetail.Controls.Add(this.txtRawDetailShelfLife, 1, 5);
            this.tableRawDetail.Controls.Add(this.lblRawDetailActive, 0, 6);
            this.tableRawDetail.Controls.Add(this.txtRawDetailActive, 1, 6);
            this.tableRawDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableRawDetail.Location = new System.Drawing.Point(3, 20);
            this.tableRawDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableRawDetail.Name = "tableRawDetail";
            this.tableRawDetail.RowCount = 7;
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.Size = new System.Drawing.Size(452, 252);
            this.tableRawDetail.TabIndex = 0;
            // 
            // splitContainerRawDetail
            // 
            this.splitContainerRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawDetail.Location = new System.Drawing.Point(3, 272);
            this.splitContainerRawDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerRawDetail.Name = "splitContainerRawDetail";
            this.splitContainerRawDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRawDetail.Panel1
            // 
            this.splitContainerRawDetail.Panel1.Controls.Add(this.dgvRawNutrients);
            this.splitContainerRawDetail.Panel1.Controls.Add(this.lblRawNutrients);
            // 
            // splitContainerRawDetail.Panel2
            // 
            this.splitContainerRawDetail.Panel2.Controls.Add(this.dgvRawComponents);
            this.splitContainerRawDetail.Panel2.Controls.Add(this.lblRawComponents);
            this.splitContainerRawDetail.Size = new System.Drawing.Size(452, 131);
            this.splitContainerRawDetail.SplitterDistance = 65;
            this.splitContainerRawDetail.TabIndex = 18;
            // 
            // lblRawDetailName
            // 
            this.lblRawDetailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailName.Location = new System.Drawing.Point(3, 0);
            this.lblRawDetailName.Name = "lblRawDetailName";
            this.lblRawDetailName.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailName.TabIndex = 0;
            this.lblRawDetailName.Text = "원재료명";
            this.lblRawDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailName
            // 
            this.txtRawDetailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailName.Location = new System.Drawing.Point(123, 2);
            this.txtRawDetailName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailName.Name = "txtRawDetailName";
            this.txtRawDetailName.ReadOnly = true;
            this.txtRawDetailName.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailName.TabIndex = 1;
            // 
            // lblRawDetailCategory
            // 
            this.lblRawDetailCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailCategory.Location = new System.Drawing.Point(3, 36);
            this.lblRawDetailCategory.Name = "lblRawDetailCategory";
            this.lblRawDetailCategory.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailCategory.TabIndex = 2;
            this.lblRawDetailCategory.Text = "분류";
            this.lblRawDetailCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailCategory
            // 
            this.txtRawDetailCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailCategory.Location = new System.Drawing.Point(123, 38);
            this.txtRawDetailCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailCategory.Name = "txtRawDetailCategory";
            this.txtRawDetailCategory.ReadOnly = true;
            this.txtRawDetailCategory.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailCategory.TabIndex = 3;
            // 
            // lblRawDetailUnit
            // 
            this.lblRawDetailUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailUnit.Location = new System.Drawing.Point(3, 72);
            this.lblRawDetailUnit.Name = "lblRawDetailUnit";
            this.lblRawDetailUnit.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailUnit.TabIndex = 4;
            this.lblRawDetailUnit.Text = "구매 단위";
            this.lblRawDetailUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailUnit
            // 
            this.txtRawDetailUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailUnit.Location = new System.Drawing.Point(123, 74);
            this.txtRawDetailUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailUnit.Name = "txtRawDetailUnit";
            this.txtRawDetailUnit.ReadOnly = true;
            this.txtRawDetailUnit.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailUnit.TabIndex = 5;
            // 
            // lblRawDetailBaseQty
            // 
            this.lblRawDetailBaseQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailBaseQty.Location = new System.Drawing.Point(3, 108);
            this.lblRawDetailBaseQty.Name = "lblRawDetailBaseQty";
            this.lblRawDetailBaseQty.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailBaseQty.TabIndex = 6;
            this.lblRawDetailBaseQty.Text = "1단위 기준량";
            this.lblRawDetailBaseQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailBaseQty
            // 
            this.txtRawDetailBaseQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailBaseQty.Location = new System.Drawing.Point(123, 110);
            this.txtRawDetailBaseQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailBaseQty.Name = "txtRawDetailBaseQty";
            this.txtRawDetailBaseQty.ReadOnly = true;
            this.txtRawDetailBaseQty.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailBaseQty.TabIndex = 7;
            // 
            // lblRawDetailStorage
            // 
            this.lblRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailStorage.Location = new System.Drawing.Point(3, 144);
            this.lblRawDetailStorage.Name = "lblRawDetailStorage";
            this.lblRawDetailStorage.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailStorage.TabIndex = 8;
            this.lblRawDetailStorage.Text = "보관 방식";
            this.lblRawDetailStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailStorage
            // 
            this.txtRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailStorage.Location = new System.Drawing.Point(123, 146);
            this.txtRawDetailStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailStorage.Name = "txtRawDetailStorage";
            this.txtRawDetailStorage.ReadOnly = true;
            this.txtRawDetailStorage.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailStorage.TabIndex = 9;
            // 
            // lblRawDetailShelfLife
            // 
            this.lblRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailShelfLife.Location = new System.Drawing.Point(3, 180);
            this.lblRawDetailShelfLife.Name = "lblRawDetailShelfLife";
            this.lblRawDetailShelfLife.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailShelfLife.TabIndex = 10;
            this.lblRawDetailShelfLife.Text = "유통기한(일)";
            this.lblRawDetailShelfLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailShelfLife
            // 
            this.txtRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailShelfLife.Location = new System.Drawing.Point(123, 182);
            this.txtRawDetailShelfLife.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailShelfLife.Name = "txtRawDetailShelfLife";
            this.txtRawDetailShelfLife.ReadOnly = true;
            this.txtRawDetailShelfLife.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailShelfLife.TabIndex = 11;
            // 
            // lblRawDetailActive
            // 
            this.lblRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailActive.Location = new System.Drawing.Point(3, 216);
            this.lblRawDetailActive.Name = "lblRawDetailActive";
            this.lblRawDetailActive.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailActive.TabIndex = 12;
            this.lblRawDetailActive.Text = "사용 여부";
            this.lblRawDetailActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailActive
            // 
            this.txtRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailActive.Location = new System.Drawing.Point(123, 218);
            this.txtRawDetailActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailActive.Name = "txtRawDetailActive";
            this.txtRawDetailActive.ReadOnly = true;
            this.txtRawDetailActive.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailActive.TabIndex = 13;
            // 
            // lblRawNutrients
            // 
            // lblRawNutrients
            // 
            this.lblRawNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRawNutrients.Name = "lblRawNutrients";
            this.lblRawNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawNutrients.Size = new System.Drawing.Size(452, 30);
            this.lblRawNutrients.TabIndex = 14;
            this.lblRawNutrients.Text = "영양소 정보";
            // 
            // dgvRawNutrients
            // 
            this.dgvRawNutrients.AllowUserToAddRows = false;
            this.dgvRawNutrients.AllowUserToDeleteRows = false;
            this.dgvRawNutrients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawNutrients.Location = new System.Drawing.Point(0, 30);
            this.dgvRawNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRawNutrients.MultiSelect = false;
            this.dgvRawNutrients.Name = "dgvRawNutrients";
            this.dgvRawNutrients.ReadOnly = true;
            this.dgvRawNutrients.RowHeadersVisible = false;
            this.dgvRawNutrients.RowHeadersWidth = 51;
            this.dgvRawNutrients.RowTemplate.Height = 27;
            this.dgvRawNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawNutrients.Size = new System.Drawing.Size(452, 158);
            this.dgvRawNutrients.TabIndex = 15;
            // 
            // lblRawComponents
            // 
            this.lblRawComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRawComponents.Name = "lblRawComponents";
            this.lblRawComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawComponents.Size = new System.Drawing.Size(452, 30);
            this.lblRawComponents.TabIndex = 16;
            this.lblRawComponents.Text = "포함 원재료";
            // 
            // dgvRawComponents
            // 
            this.dgvRawComponents.AllowUserToAddRows = false;
            this.dgvRawComponents.AllowUserToDeleteRows = false;
            this.dgvRawComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawComponents.Location = new System.Drawing.Point(0, 30);
            this.dgvRawComponents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRawComponents.MultiSelect = false;
            this.dgvRawComponents.Name = "dgvRawComponents";
            this.dgvRawComponents.ReadOnly = true;
            this.dgvRawComponents.RowHeadersVisible = false;
            this.dgvRawComponents.RowHeadersWidth = 51;
            this.dgvRawComponents.RowTemplate.Height = 27;
            this.dgvRawComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawComponents.Size = new System.Drawing.Size(452, 145);
            this.dgvRawComponents.TabIndex = 17;
            // 
            // flowRawButtons
            // 
            this.flowRawButtons.Controls.Add(this.btnRawAdd);
            this.flowRawButtons.Controls.Add(this.btnRawRefresh);
            this.flowRawButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRawButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRawButtons.Location = new System.Drawing.Point(3, 336);
            this.flowRawButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRawButtons.Name = "flowRawButtons";
            this.flowRawButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRawButtons.Size = new System.Drawing.Size(452, 63);
            this.flowRawButtons.TabIndex = 1;
            // 
            // btnRawAdd
            // 
            this.btnRawAdd.Location = new System.Drawing.Point(240, 6);
            this.btnRawAdd.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRawAdd.Name = "btnRawAdd";
            this.btnRawAdd.Size = new System.Drawing.Size(107, 28);
            this.btnRawAdd.TabIndex = 0;
            this.btnRawAdd.Text = "원재료 등록";
            this.btnRawAdd.UseVisualStyleBackColor = true;
            // 
            // btnRawRefresh
            // 
            this.btnRawRefresh.Location = new System.Drawing.Point(356, 6);
            this.btnRawRefresh.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRawRefresh.Name = "btnRawRefresh";
            this.btnRawRefresh.Size = new System.Drawing.Size(87, 28);
            this.btnRawRefresh.TabIndex = 1;
            this.btnRawRefresh.Text = "새로 고침";
            this.btnRawRefresh.UseVisualStyleBackColor = true;
            // 
            // panelRawToolbar
            // 
            this.panelRawToolbar.Controls.Add(this.flowRawCalorieFilter);
            this.panelRawToolbar.Controls.Add(this.flowRawNutrientFilters);
            this.panelRawToolbar.Controls.Add(this.chkRawGroup);
            this.panelRawToolbar.Controls.Add(this.btnRawClear);
            this.panelRawToolbar.Controls.Add(this.btnRawSearch);
            this.panelRawToolbar.Controls.Add(this.txtRawSearch);
            this.panelRawToolbar.Controls.Add(this.lblRawSearch);
            this.panelRawToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRawToolbar.Location = new System.Drawing.Point(3, 2);
            this.panelRawToolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRawToolbar.Name = "panelRawToolbar";
            this.panelRawToolbar.Size = new System.Drawing.Size(934, 96);
            this.panelRawToolbar.TabIndex = 0;
            // 
            // flowRawNutrientFilters
            // 
            this.flowRawNutrientFilters.AutoSize = true;
            this.flowRawNutrientFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRawNutrientFilters.Controls.Add(this.lblRawNutrientFilter);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientProtein);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientFat);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientCarb);
            this.flowRawNutrientFilters.Location = new System.Drawing.Point(8, 40);
            this.flowRawNutrientFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRawNutrientFilters.Name = "flowRawNutrientFilters";
            this.flowRawNutrientFilters.Size = new System.Drawing.Size(293, 31);
            this.flowRawNutrientFilters.TabIndex = 5;
            this.flowRawNutrientFilters.WrapContents = false;
            // 
            // lblRawNutrientFilter
            // 
            this.lblRawNutrientFilter.AutoSize = true;
            this.lblRawNutrientFilter.Location = new System.Drawing.Point(3, 0);
            this.lblRawNutrientFilter.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRawNutrientFilter.Name = "lblRawNutrientFilter";
            this.lblRawNutrientFilter.Size = new System.Drawing.Size(59, 19);
            this.lblRawNutrientFilter.TabIndex = 0;
            this.lblRawNutrientFilter.Text = "영양소";
            // 
            // chkRawNutrientProtein
            // 
            this.chkRawNutrientProtein.AutoSize = true;
            this.chkRawNutrientProtein.Location = new System.Drawing.Point(71, 3);
            this.chkRawNutrientProtein.Name = "chkRawNutrientProtein";
            this.chkRawNutrientProtein.Size = new System.Drawing.Size(74, 23);
            this.chkRawNutrientProtein.TabIndex = 1;
            this.chkRawNutrientProtein.Text = "단백질";
            this.chkRawNutrientProtein.UseVisualStyleBackColor = true;
            this.chkRawNutrientProtein.Tag = "PROT";
            // 
            // chkRawNutrientFat
            // 
            this.chkRawNutrientFat.AutoSize = true;
            this.chkRawNutrientFat.Location = new System.Drawing.Point(151, 3);
            this.chkRawNutrientFat.Name = "chkRawNutrientFat";
            this.chkRawNutrientFat.Size = new System.Drawing.Size(59, 23);
            this.chkRawNutrientFat.TabIndex = 2;
            this.chkRawNutrientFat.Text = "지방";
            this.chkRawNutrientFat.UseVisualStyleBackColor = true;
            this.chkRawNutrientFat.Tag = "FAT";
            // 
            // chkRawNutrientCarb
            // 
            this.chkRawNutrientCarb.AutoSize = true;
            this.chkRawNutrientCarb.Location = new System.Drawing.Point(216, 3);
            this.chkRawNutrientCarb.Name = "chkRawNutrientCarb";
            this.chkRawNutrientCarb.Size = new System.Drawing.Size(74, 23);
            this.chkRawNutrientCarb.TabIndex = 3;
            this.chkRawNutrientCarb.Text = "탄수화물";
            this.chkRawNutrientCarb.UseVisualStyleBackColor = true;
            this.chkRawNutrientCarb.Tag = "CARB";
            // 
            // flowRawCalorieFilter
            // 
            this.flowRawCalorieFilter.AutoSize = true;
            this.flowRawCalorieFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRawCalorieFilter.Controls.Add(this.lblRawCalorie);
            this.flowRawCalorieFilter.Controls.Add(this.nudRawCalorieMin);
            this.flowRawCalorieFilter.Controls.Add(this.lblRawCalorieSeparator);
            this.flowRawCalorieFilter.Controls.Add(this.nudRawCalorieMax);
            this.flowRawCalorieFilter.Controls.Add(this.lblRawCalorieUnit);
            this.flowRawCalorieFilter.Location = new System.Drawing.Point(8, 70);
            this.flowRawCalorieFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRawCalorieFilter.Name = "flowRawCalorieFilter";
            this.flowRawCalorieFilter.Size = new System.Drawing.Size(303, 26);
            this.flowRawCalorieFilter.TabIndex = 6;
            // 
            // lblRawCalorie
            // 
            this.lblRawCalorie.AutoSize = true;
            this.lblRawCalorie.Location = new System.Drawing.Point(3, 0);
            this.lblRawCalorie.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRawCalorie.Name = "lblRawCalorie";
            this.lblRawCalorie.Size = new System.Drawing.Size(66, 19);
            this.lblRawCalorie.TabIndex = 0;
            this.lblRawCalorie.Text = "열량(kcal)";
            // 
            // nudRawCalorieMin
            // 
            this.nudRawCalorieMin.Location = new System.Drawing.Point(78, 2);
            this.nudRawCalorieMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRawCalorieMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRawCalorieMin.Name = "nudRawCalorieMin";
            this.nudRawCalorieMin.Size = new System.Drawing.Size(70, 25);
            this.nudRawCalorieMin.TabIndex = 1;
            // 
            // lblRawCalorieSeparator
            // 
            this.lblRawCalorieSeparator.AutoSize = true;
            this.lblRawCalorieSeparator.Location = new System.Drawing.Point(154, 0);
            this.lblRawCalorieSeparator.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRawCalorieSeparator.Name = "lblRawCalorieSeparator";
            this.lblRawCalorieSeparator.Size = new System.Drawing.Size(22, 19);
            this.lblRawCalorieSeparator.TabIndex = 2;
            this.lblRawCalorieSeparator.Text = "~";
            // 
            // nudRawCalorieMax
            // 
            this.nudRawCalorieMax.Location = new System.Drawing.Point(182, 2);
            this.nudRawCalorieMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRawCalorieMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRawCalorieMax.Name = "nudRawCalorieMax";
            this.nudRawCalorieMax.Size = new System.Drawing.Size(70, 25);
            this.nudRawCalorieMax.TabIndex = 3;
            // 
            // lblRawCalorieUnit
            // 
            this.lblRawCalorieUnit.AutoSize = true;
            this.lblRawCalorieUnit.Location = new System.Drawing.Point(258, 0);
            this.lblRawCalorieUnit.Name = "lblRawCalorieUnit";
            this.lblRawCalorieUnit.Size = new System.Drawing.Size(85, 19);
            this.lblRawCalorieUnit.TabIndex = 4;
            this.lblRawCalorieUnit.Text = "기준(1단위)";
            // 
            // lblRawSearch
            // 
            this.lblRawSearch.AutoSize = true;
            this.lblRawSearch.Location = new System.Drawing.Point(8, 13);
            this.lblRawSearch.Name = "lblRawSearch";
            this.lblRawSearch.Size = new System.Drawing.Size(78, 19);
            this.lblRawSearch.TabIndex = 0;
            this.lblRawSearch.Text = "원재료명";
            // 
            // txtRawSearch
            // 
            this.txtRawSearch.Location = new System.Drawing.Point(88, 10);
            this.txtRawSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawSearch.Name = "txtRawSearch";
            this.txtRawSearch.Size = new System.Drawing.Size(220, 25);
            this.txtRawSearch.TabIndex = 1;
            // 
            // btnRawSearch
            // 
            this.btnRawSearch.Location = new System.Drawing.Point(315, 9);
            this.btnRawSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRawSearch.Name = "btnRawSearch";
            this.btnRawSearch.Size = new System.Drawing.Size(68, 28);
            this.btnRawSearch.TabIndex = 2;
            this.btnRawSearch.Text = "검색";
            this.btnRawSearch.UseVisualStyleBackColor = true;
            // 
            // btnRawClear
            // 
            this.btnRawClear.Location = new System.Drawing.Point(386, 9);
            this.btnRawClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRawClear.Name = "btnRawClear";
            this.btnRawClear.Size = new System.Drawing.Size(68, 28);
            this.btnRawClear.TabIndex = 3;
            this.btnRawClear.Text = "초기화";
            this.btnRawClear.UseVisualStyleBackColor = true;
            // 
            // chkRawGroup
            // 
            this.chkRawGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkRawGroup.AutoSize = true;
            this.chkRawGroup.Location = new System.Drawing.Point(746, 12);
            this.chkRawGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRawGroup.Name = "chkRawGroup";
            this.chkRawGroup.Size = new System.Drawing.Size(132, 23);
            this.chkRawGroup.TabIndex = 4;
            this.chkRawGroup.Text = "카테고리 묶기";
            this.chkRawGroup.UseVisualStyleBackColor = true;
            // 
            // tabIngredients
            // 
            this.tabIngredients.Controls.Add(this.splitContainerIngredients);
            this.tabIngredients.Location = new System.Drawing.Point(4, 26);
            this.tabIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Name = "tabIngredients";
            this.tabIngredients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Size = new System.Drawing.Size(940, 453);
            this.tabIngredients.TabIndex = 0;
            this.tabIngredients.Text = "발주 요청";
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
            this.splitContainerIngredients.Size = new System.Drawing.Size(934, 449);
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
            this.dgvIngredients.Size = new System.Drawing.Size(472, 449);
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
            this.grpIngredientDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableIngredientDetail.Location = new System.Drawing.Point(3, 20);
            this.tableIngredientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableIngredientDetail.Name = "tableIngredientDetail";
            this.tableIngredientDetail.RowCount = 4;
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIngredientDetail.Size = new System.Drawing.Size(452, 427);
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
            this.txtIngredientName.Size = new System.Drawing.Size(341, 25);
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
            this.txtIngredientUnit.Size = new System.Drawing.Size(341, 25);
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
            this.tabNutrients.Location = new System.Drawing.Point(4, 26);
            this.tabNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Name = "tabNutrients";
            this.tabNutrients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Size = new System.Drawing.Size(940, 453);
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
            this.splitContainerNutrients.Size = new System.Drawing.Size(934, 449);
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
            this.dgvNutrients.Size = new System.Drawing.Size(472, 449);
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
            this.grpNutrientDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableNutrientDetail.Location = new System.Drawing.Point(3, 20);
            this.tableNutrientDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableNutrientDetail.Name = "tableNutrientDetail";
            this.tableNutrientDetail.RowCount = 4;
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Size = new System.Drawing.Size(452, 427);
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
            this.txtNutrientCode.Size = new System.Drawing.Size(341, 25);
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
            this.txtNutrientName.Size = new System.Drawing.Size(341, 25);
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
            this.txtNutrientUnit.Size = new System.Drawing.Size(341, 25);
            this.txtNutrientUnit.TabIndex = 5;
            // 
            // btnSearchNutrient
            // 
            this.btnSearchNutrient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchNutrient.Location = new System.Drawing.Point(357, 247);
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
            this.tabRecipes.Controls.Add(this.panelRecipeToolbar);
            this.tabRecipes.Location = new System.Drawing.Point(4, 26);
            this.tabRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Name = "tabRecipes";
            this.tabRecipes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Size = new System.Drawing.Size(940, 453);
            this.tabRecipes.TabIndex = 2;
            this.tabRecipes.Text = "요리 관리";
            this.tabRecipes.UseVisualStyleBackColor = true;
            // 
// panelRecipeToolbar
            // 
            this.panelRecipeToolbar.Controls.Add(this.flowRecipeCalorieFilter);
            this.panelRecipeToolbar.Controls.Add(this.flowRecipeNutrientFilters);
            this.panelRecipeToolbar.Controls.Add(this.btnRecipeClear);
            this.panelRecipeToolbar.Controls.Add(this.btnRecipeSearch);
            this.panelRecipeToolbar.Controls.Add(this.txtRecipeSearch);
            this.panelRecipeToolbar.Controls.Add(this.lblRecipeSearch);
            this.panelRecipeToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecipeToolbar.Location = new System.Drawing.Point(3, 2);
            this.panelRecipeToolbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRecipeToolbar.Name = "panelRecipeToolbar";
            this.panelRecipeToolbar.Size = new System.Drawing.Size(934, 94);
            this.panelRecipeToolbar.TabIndex = 0;
            // 
            // lblRecipeSearch
            // 
            this.lblRecipeSearch.AutoSize = true;
            this.lblRecipeSearch.Location = new System.Drawing.Point(8, 13);
            this.lblRecipeSearch.Name = "lblRecipeSearch";
            this.lblRecipeSearch.Size = new System.Drawing.Size(92, 15);
            this.lblRecipeSearch.TabIndex = 0;
            this.lblRecipeSearch.Text = "메뉴명 / 코드";
            // 
            // txtRecipeSearch
            // 
            this.txtRecipeSearch.Location = new System.Drawing.Point(106, 10);
            this.txtRecipeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeSearch.Name = "txtRecipeSearch";
            this.txtRecipeSearch.Size = new System.Drawing.Size(240, 23);
            this.txtRecipeSearch.TabIndex = 1;
            // 
            // btnRecipeSearch
            // 
            this.btnRecipeSearch.Location = new System.Drawing.Point(352, 9);
            this.btnRecipeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecipeSearch.Name = "btnRecipeSearch";
            this.btnRecipeSearch.Size = new System.Drawing.Size(72, 26);
            this.btnRecipeSearch.TabIndex = 2;
            this.btnRecipeSearch.Text = "검색";
            this.btnRecipeSearch.UseVisualStyleBackColor = true;
            // 
            // btnRecipeClear
            // 
            this.btnRecipeClear.Location = new System.Drawing.Point(430, 9);
            this.btnRecipeClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRecipeClear.Name = "btnRecipeClear";
            this.btnRecipeClear.Size = new System.Drawing.Size(72, 26);
            this.btnRecipeClear.TabIndex = 3;
            this.btnRecipeClear.Text = "초기화";
            this.btnRecipeClear.UseVisualStyleBackColor = true;
            // 
            // flowRecipeNutrientFilters
            // 
            this.flowRecipeNutrientFilters.AutoSize = true;
            this.flowRecipeNutrientFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRecipeNutrientFilters.Controls.Add(this.lblRecipeNutrientFilter);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientProtein);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientFat);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientCarb);
            this.flowRecipeNutrientFilters.Location = new System.Drawing.Point(8, 40);
            this.flowRecipeNutrientFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRecipeNutrientFilters.Name = "flowRecipeNutrientFilters";
            this.flowRecipeNutrientFilters.Size = new System.Drawing.Size(293, 31);
            this.flowRecipeNutrientFilters.TabIndex = 4;
            this.flowRecipeNutrientFilters.WrapContents = false;
            // 
            // lblRecipeNutrientFilter
            // 
            this.lblRecipeNutrientFilter.AutoSize = true;
            this.lblRecipeNutrientFilter.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeNutrientFilter.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRecipeNutrientFilter.Name = "lblRecipeNutrientFilter";
            this.lblRecipeNutrientFilter.Size = new System.Drawing.Size(59, 19);
            this.lblRecipeNutrientFilter.TabIndex = 0;
            this.lblRecipeNutrientFilter.Text = "영양소";
            // 
            // chkRecipeNutrientProtein
            // 
            this.chkRecipeNutrientProtein.AutoSize = true;
            this.chkRecipeNutrientProtein.Location = new System.Drawing.Point(71, 3);
            this.chkRecipeNutrientProtein.Name = "chkRecipeNutrientProtein";
            this.chkRecipeNutrientProtein.Size = new System.Drawing.Size(74, 23);
            this.chkRecipeNutrientProtein.TabIndex = 1;
            this.chkRecipeNutrientProtein.Text = "단백질";
            this.chkRecipeNutrientProtein.UseVisualStyleBackColor = true;
            this.chkRecipeNutrientProtein.Tag = "PROT";
            // 
            // chkRecipeNutrientFat
            // 
            this.chkRecipeNutrientFat.AutoSize = true;
            this.chkRecipeNutrientFat.Location = new System.Drawing.Point(151, 3);
            this.chkRecipeNutrientFat.Name = "chkRecipeNutrientFat";
            this.chkRecipeNutrientFat.Size = new System.Drawing.Size(59, 23);
            this.chkRecipeNutrientFat.TabIndex = 2;
            this.chkRecipeNutrientFat.Text = "지방";
            this.chkRecipeNutrientFat.UseVisualStyleBackColor = true;
            this.chkRecipeNutrientFat.Tag = "FAT";
            // 
            // chkRecipeNutrientCarb
            // 
            this.chkRecipeNutrientCarb.AutoSize = true;
            this.chkRecipeNutrientCarb.Location = new System.Drawing.Point(216, 3);
            this.chkRecipeNutrientCarb.Name = "chkRecipeNutrientCarb";
            this.chkRecipeNutrientCarb.Size = new System.Drawing.Size(74, 23);
            this.chkRecipeNutrientCarb.TabIndex = 3;
            this.chkRecipeNutrientCarb.Text = "탄수화물";
            this.chkRecipeNutrientCarb.UseVisualStyleBackColor = true;
            this.chkRecipeNutrientCarb.Tag = "CARB";
            // 
            // flowRecipeCalorieFilter
            // 
            this.flowRecipeCalorieFilter.AutoSize = true;
            this.flowRecipeCalorieFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRecipeCalorieFilter.Controls.Add(this.lblRecipeCalorie);
            this.flowRecipeCalorieFilter.Controls.Add(this.nudRecipeCalorieMin);
            this.flowRecipeCalorieFilter.Controls.Add(this.lblRecipeCalorieSeparator);
            this.flowRecipeCalorieFilter.Controls.Add(this.nudRecipeCalorieMax);
            this.flowRecipeCalorieFilter.Controls.Add(this.lblRecipeCalorieUnit);
            this.flowRecipeCalorieFilter.Location = new System.Drawing.Point(8, 70);
            this.flowRecipeCalorieFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRecipeCalorieFilter.Name = "flowRecipeCalorieFilter";
            this.flowRecipeCalorieFilter.Size = new System.Drawing.Size(303, 26);
            this.flowRecipeCalorieFilter.TabIndex = 5;
            // 
            // lblRecipeCalorie
            // 
            this.lblRecipeCalorie.AutoSize = true;
            this.lblRecipeCalorie.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeCalorie.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRecipeCalorie.Name = "lblRecipeCalorie";
            this.lblRecipeCalorie.Size = new System.Drawing.Size(66, 19);
            this.lblRecipeCalorie.TabIndex = 0;
            this.lblRecipeCalorie.Text = "열량(kcal)";
            // 
            // nudRecipeCalorieMin
            // 
            this.nudRecipeCalorieMin.Location = new System.Drawing.Point(78, 2);
            this.nudRecipeCalorieMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRecipeCalorieMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRecipeCalorieMin.Name = "nudRecipeCalorieMin";
            this.nudRecipeCalorieMin.Size = new System.Drawing.Size(70, 25);
            this.nudRecipeCalorieMin.TabIndex = 1;
            // 
            // lblRecipeCalorieSeparator
            // 
            this.lblRecipeCalorieSeparator.AutoSize = true;
            this.lblRecipeCalorieSeparator.Location = new System.Drawing.Point(154, 0);
            this.lblRecipeCalorieSeparator.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblRecipeCalorieSeparator.Name = "lblRecipeCalorieSeparator";
            this.lblRecipeCalorieSeparator.Size = new System.Drawing.Size(22, 19);
            this.lblRecipeCalorieSeparator.TabIndex = 2;
            this.lblRecipeCalorieSeparator.Text = "~";
            // 
            // nudRecipeCalorieMax
            // 
            this.nudRecipeCalorieMax.Location = new System.Drawing.Point(182, 2);
            this.nudRecipeCalorieMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudRecipeCalorieMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRecipeCalorieMax.Name = "nudRecipeCalorieMax";
            this.nudRecipeCalorieMax.Size = new System.Drawing.Size(70, 25);
            this.nudRecipeCalorieMax.TabIndex = 3;
            // 
            // lblRecipeCalorieUnit
            // 
            this.lblRecipeCalorieUnit.AutoSize = true;
            this.lblRecipeCalorieUnit.Location = new System.Drawing.Point(258, 0);
            this.lblRecipeCalorieUnit.Name = "lblRecipeCalorieUnit";
            this.lblRecipeCalorieUnit.Size = new System.Drawing.Size(85, 19);
            this.lblRecipeCalorieUnit.TabIndex = 4;
            this.lblRecipeCalorieUnit.Text = "기준(1인분)";
            // 
            // splitContainerRecipes
            // 
            this.splitContainerRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipes.Location = new System.Drawing.Point(3, 48);
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
            this.splitContainerRecipes.Size = new System.Drawing.Size(934, 403);
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
            this.dgvRecipes.Size = new System.Drawing.Size(472, 449);
            this.dgvRecipes.TabIndex = 0;
            // 
            // grpRecipeDetail
            // 
            this.grpRecipeDetail.Controls.Add(this.splitContainerRecipeDetail);
            this.grpRecipeDetail.Controls.Add(this.tableRecipeDetail);
            this.grpRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipeDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRecipeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipeDetail.Name = "grpRecipeDetail";
            this.grpRecipeDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipeDetail.Size = new System.Drawing.Size(458, 403);
            this.grpRecipeDetail.TabIndex = 0;
            this.grpRecipeDetail.TabStop = false;
            this.grpRecipeDetail.Text = "요리 정보";
            // 
            // tableRecipeDetail
            // 
            this.tableRecipeDetail.ColumnCount = 2;
            this.tableRecipeDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableRecipeDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRecipeDetail.Controls.Add(this.lblRecipeName, 0, 0);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeName, 1, 0);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeCode, 0, 1);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeCode, 1, 1);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeType, 0, 2);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeType, 1, 2);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeServing, 0, 3);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeServing, 1, 3);
            this.tableRecipeDetail.Controls.Add(this.lblRecipeActive, 0, 4);
            this.tableRecipeDetail.Controls.Add(this.txtRecipeActive, 1, 4);
            this.tableRecipeDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableRecipeDetail.Location = new System.Drawing.Point(3, 20);
            this.tableRecipeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableRecipeDetail.Name = "tableRecipeDetail";
            this.tableRecipeDetail.RowCount = 5;
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.Size = new System.Drawing.Size(452, 180);
            this.tableRecipeDetail.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(104, 36);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "요리명";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(113, 2);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(336, 25);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblRecipeCode
            // 
            this.lblRecipeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeCode.Location = new System.Drawing.Point(3, 36);
            this.lblRecipeCode.Name = "lblRecipeCode";
            this.lblRecipeCode.Size = new System.Drawing.Size(104, 36);
            this.lblRecipeCode.TabIndex = 2;
            this.lblRecipeCode.Text = "메뉴 코드";
            this.lblRecipeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeCode.Location = new System.Drawing.Point(113, 38);
            this.txtRecipeCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.ReadOnly = true;
            this.txtRecipeCode.Size = new System.Drawing.Size(336, 25);
            this.txtRecipeCode.TabIndex = 3;
            // 
            // lblRecipeType
            // 
            this.lblRecipeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeType.Location = new System.Drawing.Point(3, 72);
            this.lblRecipeType.Name = "lblRecipeType";
            this.lblRecipeType.Size = new System.Drawing.Size(104, 36);
            this.lblRecipeType.TabIndex = 4;
            this.lblRecipeType.Text = "분류";
            this.lblRecipeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeType
            // 
            this.txtRecipeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeType.Location = new System.Drawing.Point(113, 74);
            this.txtRecipeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeType.Name = "txtRecipeType";
            this.txtRecipeType.ReadOnly = true;
            this.txtRecipeType.Size = new System.Drawing.Size(336, 25);
            this.txtRecipeType.TabIndex = 5;
            // 
            // lblRecipeServing
            // 
            this.lblRecipeServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeServing.Location = new System.Drawing.Point(3, 108);
            this.lblRecipeServing.Name = "lblRecipeServing";
            this.lblRecipeServing.Size = new System.Drawing.Size(104, 36);
            this.lblRecipeServing.TabIndex = 6;
            this.lblRecipeServing.Text = "1인 제공량(g)";
            this.lblRecipeServing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeServing
            // 
            this.txtRecipeServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeServing.Location = new System.Drawing.Point(113, 110);
            this.txtRecipeServing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeServing.Name = "txtRecipeServing";
            this.txtRecipeServing.ReadOnly = true;
            this.txtRecipeServing.Size = new System.Drawing.Size(336, 25);
            this.txtRecipeServing.TabIndex = 7;
            // 
            // lblRecipeActive
            // 
            this.lblRecipeActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeActive.Location = new System.Drawing.Point(3, 144);
            this.lblRecipeActive.Name = "lblRecipeActive";
            this.lblRecipeActive.Size = new System.Drawing.Size(104, 36);
            this.lblRecipeActive.TabIndex = 8;
            this.lblRecipeActive.Text = "사용 여부";
            this.lblRecipeActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeActive
            // 
            this.txtRecipeActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeActive.Location = new System.Drawing.Point(113, 146);
            this.txtRecipeActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipeActive.Name = "txtRecipeActive";
            this.txtRecipeActive.ReadOnly = true;
            this.txtRecipeActive.Size = new System.Drawing.Size(336, 25);
            this.txtRecipeActive.TabIndex = 9;
            // 
            // splitContainerRecipeDetail
            // 
            this.splitContainerRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipeDetail.Location = new System.Drawing.Point(3, 200);
            this.splitContainerRecipeDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerRecipeDetail.Name = "splitContainerRecipeDetail";
            this.splitContainerRecipeDetail.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRecipeDetail.Panel1
            // 
            this.splitContainerRecipeDetail.Panel1.Controls.Add(this.dgvRecipeNutrients);
            this.splitContainerRecipeDetail.Panel1.Controls.Add(this.lblRecipeNutrients);
            // 
            // splitContainerRecipeDetail.Panel2
            // 
            this.splitContainerRecipeDetail.Panel2.Controls.Add(this.dgvRecipeComponents);
            this.splitContainerRecipeDetail.Panel2.Controls.Add(this.lblRecipeComponents);
            this.splitContainerRecipeDetail.Size = new System.Drawing.Size(452, 141);
            this.splitContainerRecipeDetail.SplitterDistance = 70;
            this.splitContainerRecipeDetail.TabIndex = 1;
            // 
            // dgvRecipeNutrients
            // 
            this.dgvRecipeNutrients.AllowUserToAddRows = false;
            this.dgvRecipeNutrients.AllowUserToDeleteRows = false;
            this.dgvRecipeNutrients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipeNutrients.Location = new System.Drawing.Point(0, 30);
            this.dgvRecipeNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecipeNutrients.MultiSelect = false;
            this.dgvRecipeNutrients.Name = "dgvRecipeNutrients";
            this.dgvRecipeNutrients.ReadOnly = true;
            this.dgvRecipeNutrients.RowHeadersVisible = false;
            this.dgvRecipeNutrients.RowHeadersWidth = 51;
            this.dgvRecipeNutrients.RowTemplate.Height = 27;
            this.dgvRecipeNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeNutrients.Size = new System.Drawing.Size(452, 40);
            this.dgvRecipeNutrients.TabIndex = 1;
            // 
            // lblRecipeNutrients
            // 
            this.lblRecipeNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeNutrients.Name = "lblRecipeNutrients";
            this.lblRecipeNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeNutrients.Size = new System.Drawing.Size(452, 30);
            this.lblRecipeNutrients.TabIndex = 0;
            this.lblRecipeNutrients.Text = "영양소 정보";
            // 
            // dgvRecipeComponents
            // 
            this.dgvRecipeComponents.AllowUserToAddRows = false;
            this.dgvRecipeComponents.AllowUserToDeleteRows = false;
            this.dgvRecipeComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipeComponents.Location = new System.Drawing.Point(0, 30);
            this.dgvRecipeComponents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRecipeComponents.MultiSelect = false;
            this.dgvRecipeComponents.Name = "dgvRecipeComponents";
            this.dgvRecipeComponents.ReadOnly = true;
            this.dgvRecipeComponents.RowHeadersVisible = false;
            this.dgvRecipeComponents.RowHeadersWidth = 51;
            this.dgvRecipeComponents.RowTemplate.Height = 27;
            this.dgvRecipeComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeComponents.Size = new System.Drawing.Size(452, 65);
            this.dgvRecipeComponents.TabIndex = 1;
            // 
            // lblRecipeComponents
            // 
            this.lblRecipeComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeComponents.Name = "lblRecipeComponents";
            this.lblRecipeComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeComponents.Size = new System.Drawing.Size(452, 30);
            this.lblRecipeComponents.TabIndex = 0;
            this.lblRecipeComponents.Text = "포함 원재료";
            // 
            // flowRecipeButtons
            // 
            this.flowRecipeButtons.Controls.Add(this.btnRefreshRecipe);
            this.flowRecipeButtons.Controls.Add(this.btnRegisterRecipe);
            this.flowRecipeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRecipeButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRecipeButtons.Location = new System.Drawing.Point(3, 341);
            this.flowRecipeButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRecipeButtons.Name = "flowRecipeButtons";
            this.flowRecipeButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRecipeButtons.Size = new System.Drawing.Size(452, 60);
            this.flowRecipeButtons.TabIndex = 2;
            // 
            // btnRefreshRecipe
            // 
            this.btnRefreshRecipe.Location = new System.Drawing.Point(356, 6);
            this.btnRefreshRecipe.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRefreshRecipe.Name = "btnRefreshRecipe";
            this.btnRefreshRecipe.Size = new System.Drawing.Size(96, 28);
            this.btnRefreshRecipe.TabIndex = 0;
            this.btnRefreshRecipe.Text = "새로 고침";
            this.btnRefreshRecipe.UseVisualStyleBackColor = true;
            // 
            // btnRegisterRecipe
            // 
            this.btnRegisterRecipe.Location = new System.Drawing.Point(251, 6);
            this.btnRegisterRecipe.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRegisterRecipe.Name = "btnRegisterRecipe";
            this.btnRegisterRecipe.Size = new System.Drawing.Size(96, 28);
            this.btnRegisterRecipe.TabIndex = 1;
            this.btnRegisterRecipe.Text = "메뉴 등록";
            this.btnRegisterRecipe.UseVisualStyleBackColor = true;
            // 
// tabMealPlans
            // 
            this.tabMealPlans.Controls.Add(this.splitContainerMealPlans);
            this.tabMealPlans.Location = new System.Drawing.Point(4, 26);
            this.tabMealPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Name = "tabMealPlans";
            this.tabMealPlans.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Size = new System.Drawing.Size(940, 453);
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
            this.tableMealPlanDetail.Controls.Add(this.lblMealType, 0, 1);
            this.tableMealPlanDetail.Controls.Add(this.cmbMealType, 1, 1);
            this.tableMealPlanDetail.Controls.Add(this.lblMealRecipes, 0, 2);
            this.tableMealPlanDetail.Controls.Add(this.lstMealRecipes, 1, 2);
            this.tableMealPlanDetail.Controls.Add(this.lblMealNotes, 0, 3);
            this.tableMealPlanDetail.Controls.Add(this.txtMealNotes, 1, 3);
            this.tableMealPlanDetail.Controls.Add(this.flowMealButtons, 0, 4);
            this.tableMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMealPlanDetail.Location = new System.Drawing.Point(3, 20);
            this.tableMealPlanDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealPlanDetail.Name = "tableMealPlanDetail";
            this.tableMealPlanDetail.RowCount = 5;
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            this.cmbMealType.Size = new System.Drawing.Size(176, 25);
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
            this.lstMealRecipes.ItemHeight = 17;
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
            this.tabUsers.Location = new System.Drawing.Point(4, 26);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Size = new System.Drawing.Size(940, 453);
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
            this.splitContainerUsers.Size = new System.Drawing.Size(934, 449);
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
            this.dgvUsers.Size = new System.Drawing.Size(472, 449);
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
            this.grpUserDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableUserDetail.Location = new System.Drawing.Point(3, 20);
            this.tableUserDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableUserDetail.Name = "tableUserDetail";
            this.tableUserDetail.RowCount = 5;
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Size = new System.Drawing.Size(452, 427);
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
            this.txtUserName.Size = new System.Drawing.Size(341, 25);
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
            this.txtUserGrade.Size = new System.Drawing.Size(88, 25);
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
            this.txtUserClass.Size = new System.Drawing.Size(132, 25);
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
            this.tabAllergies.Location = new System.Drawing.Point(4, 26);
            this.tabAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Name = "tabAllergies";
            this.tabAllergies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Size = new System.Drawing.Size(940, 453);
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
            this.splitContainerAllergies.Size = new System.Drawing.Size(934, 449);
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
            this.dgvAllergies.Size = new System.Drawing.Size(472, 449);
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
            this.grpAllergyDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableAllergyDetail.Location = new System.Drawing.Point(3, 20);
            this.tableAllergyDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllergyDetail.Name = "tableAllergyDetail";
            this.tableAllergyDetail.RowCount = 4;
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Size = new System.Drawing.Size(452, 427);
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
            this.txtAllergyCode.Size = new System.Drawing.Size(341, 25);
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
            this.txtAllergyName.Size = new System.Drawing.Size(341, 25);
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
            this.tabAllergyRelations.Location = new System.Drawing.Point(4, 26);
            this.tabAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Name = "tabAllergyRelations";
            this.tabAllergyRelations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Size = new System.Drawing.Size(940, 453);
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
            this.splitContainerAllergyRelations.Size = new System.Drawing.Size(934, 449);
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
            this.dgvAllergyRelations.Size = new System.Drawing.Size(472, 449);
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
            this.grpAllergyRelationDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableAllergyRelationDetail.Location = new System.Drawing.Point(3, 20);
            this.tableAllergyRelationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllergyRelationDetail.Name = "tableAllergyRelationDetail";
            this.tableAllergyRelationDetail.RowCount = 4;
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Size = new System.Drawing.Size(452, 427);
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
            this.cmbRelationUser.Size = new System.Drawing.Size(341, 25);
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
            this.cmbRelationAllergy.Size = new System.Drawing.Size(341, 25);
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
            this.tabMealEvaluations.Location = new System.Drawing.Point(4, 26);
            this.tabMealEvaluations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Name = "tabMealEvaluations";
            this.tabMealEvaluations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Size = new System.Drawing.Size(940, 453);
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
            this.splitContainerMealEvaluations.Size = new System.Drawing.Size(934, 449);
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
            this.dgvMealEvaluations.Size = new System.Drawing.Size(472, 449);
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
            this.grpMealEvaluationDetail.Size = new System.Drawing.Size(458, 449);
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
            this.tableMealEvaluationDetail.Location = new System.Drawing.Point(3, 20);
            this.tableMealEvaluationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableMealEvaluationDetail.Name = "tableMealEvaluationDetail";
            this.tableMealEvaluationDetail.RowCount = 5;
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealEvaluationDetail.Size = new System.Drawing.Size(452, 427);
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
            this.cmbEvaluationMeal.Size = new System.Drawing.Size(341, 25);
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
            this.cmbEvaluationUser.Size = new System.Drawing.Size(341, 25);
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
            this.nudEvaluationScore.Size = new System.Drawing.Size(105, 25);
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
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(45)))), ((int)(((byte)(61)))));
            this.panelNav.Controls.Add(this.btnNavManagement);
            this.panelNav.Controls.Add(this.btnNavDashboard);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Margin = new System.Windows.Forms.Padding(0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Padding = new System.Windows.Forms.Padding(15, 20, 0, 20);
            this.panelNav.Size = new System.Drawing.Size(220, 496);
            this.panelNav.TabIndex = 0;
            // 
            // btnNavManagement
            // 
            this.btnNavManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNavManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavManagement.FlatAppearance.BorderSize = 0;
            this.btnNavManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.btnNavManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnNavManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManagement.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNavManagement.ForeColor = System.Drawing.Color.White;
            this.btnNavManagement.Location = new System.Drawing.Point(15, 90);
            this.btnNavManagement.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.btnNavManagement.Name = "btnNavManagement";
            this.btnNavManagement.Padding = new System.Windows.Forms.Padding(10);
            this.btnNavManagement.Size = new System.Drawing.Size(205, 70);
            this.btnNavManagement.TabIndex = 2;
            this.btnNavManagement.Text = "상세 관리";
            this.btnNavManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavManagement.UseVisualStyleBackColor = false;
            this.btnNavManagement.Click += new System.EventHandler(this.BtnNavManagement_Click);
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(88)))), ((int)(((byte)(109)))));
            this.btnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(15, 20);
            this.btnNavDashboard.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(10);
            this.btnNavDashboard.Size = new System.Drawing.Size(205, 70);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "메인 현황";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.BtnNavDashboard_Click);
            // 
            // NutritionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 520);
            this.Controls.Add(this.panelWorkspace);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NutritionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학교 급양 관리 시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelWorkspace.ResumeLayout(false);
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
            this.tabRawMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).EndInit();
            this.splitContainerRawMaterials.Panel1.ResumeLayout(false);
            this.splitContainerRawMaterials.Panel2.ResumeLayout(false);
            this.splitContainerRawMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            this.grpRawDetail.ResumeLayout(false);
            this.tableRawDetail.ResumeLayout(false);
            this.tableRawDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).EndInit();
            this.splitContainerRawDetail.Panel1.ResumeLayout(false);
            this.splitContainerRawDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).EndInit();
            this.splitContainerRawDetail.ResumeLayout(false);
            this.flowRawButtons.ResumeLayout(false);
            this.panelRawToolbar.ResumeLayout(false);
            this.panelRawToolbar.PerformLayout();
            this.flowRawCalorieFilter.ResumeLayout(false);
            this.flowRawCalorieFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).EndInit();
            this.flowRawNutrientFilters.ResumeLayout(false);
            this.flowRawNutrientFilters.PerformLayout();
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
            this.panelRecipeToolbar.ResumeLayout(false);
            this.panelRecipeToolbar.PerformLayout();
            this.flowRecipeCalorieFilter.ResumeLayout(false);
            this.flowRecipeCalorieFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).EndInit();
            this.flowRecipeNutrientFilters.ResumeLayout(false);
            this.flowRecipeNutrientFilters.PerformLayout();
            this.tabRecipes.ResumeLayout(false);
            this.splitContainerRecipes.Panel1.ResumeLayout(false);
            this.splitContainerRecipes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            this.splitContainerRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.grpRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).EndInit();
            this.splitContainerRecipeDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).EndInit();
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
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuAddRaw;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripMenuItem menuOpenAdmin;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnNavManagement;
        private System.Windows.Forms.Button btnNavDashboard;
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
        private System.Windows.Forms.TabPage tabRawMaterials;
        private System.Windows.Forms.Panel panelRawToolbar;
        private System.Windows.Forms.Label lblRawSearch;
        private System.Windows.Forms.TextBox txtRawSearch;
        private System.Windows.Forms.Button btnRawSearch;
        private System.Windows.Forms.Button btnRawClear;
        private System.Windows.Forms.FlowLayoutPanel flowRawNutrientFilters;
        private System.Windows.Forms.Label lblRawNutrientFilter;
        private System.Windows.Forms.CheckBox chkRawNutrientProtein;
        private System.Windows.Forms.CheckBox chkRawNutrientFat;
        private System.Windows.Forms.CheckBox chkRawNutrientCarb;
        private System.Windows.Forms.FlowLayoutPanel flowRawCalorieFilter;
        private System.Windows.Forms.Label lblRawCalorie;
        private System.Windows.Forms.NumericUpDown nudRawCalorieMin;
        private System.Windows.Forms.Label lblRawCalorieSeparator;
        private System.Windows.Forms.NumericUpDown nudRawCalorieMax;
        private System.Windows.Forms.Label lblRawCalorieUnit;
        private System.Windows.Forms.CheckBox chkRawGroup;
        private System.Windows.Forms.SplitContainer splitContainerRawMaterials;
        private System.Windows.Forms.TreeView tvRawMaterials;
        private System.Windows.Forms.DataGridView dgvRawMaterials;
        private System.Windows.Forms.GroupBox grpRawDetail;
        private System.Windows.Forms.TableLayoutPanel tableRawDetail;
        private System.Windows.Forms.Label lblRawDetailName;
        private System.Windows.Forms.TextBox txtRawDetailName;
        private System.Windows.Forms.Label lblRawDetailCategory;
        private System.Windows.Forms.TextBox txtRawDetailCategory;
        private System.Windows.Forms.Label lblRawDetailUnit;
        private System.Windows.Forms.TextBox txtRawDetailUnit;
        private System.Windows.Forms.Label lblRawDetailBaseQty;
        private System.Windows.Forms.TextBox txtRawDetailBaseQty;
        private System.Windows.Forms.Label lblRawDetailStorage;
        private System.Windows.Forms.TextBox txtRawDetailStorage;
        private System.Windows.Forms.Label lblRawDetailShelfLife;
        private System.Windows.Forms.TextBox txtRawDetailShelfLife;
        private System.Windows.Forms.Label lblRawDetailActive;
        private System.Windows.Forms.TextBox txtRawDetailActive;
        private System.Windows.Forms.Label lblRawNutrients;
        private System.Windows.Forms.DataGridView dgvRawNutrients;
        private System.Windows.Forms.Label lblRawComponents;
        private System.Windows.Forms.DataGridView dgvRawComponents;
        private System.Windows.Forms.SplitContainer splitContainerRawDetail;
        private System.Windows.Forms.FlowLayoutPanel flowRawButtons;
        private System.Windows.Forms.Button btnRawAdd;
        private System.Windows.Forms.Button btnRawRefresh;
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
        private System.Windows.Forms.Panel panelRecipeToolbar;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeNutrientFilters;
        private System.Windows.Forms.Label lblRecipeNutrientFilter;
        private System.Windows.Forms.CheckBox chkRecipeNutrientProtein;
        private System.Windows.Forms.CheckBox chkRecipeNutrientFat;
        private System.Windows.Forms.CheckBox chkRecipeNutrientCarb;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeCalorieFilter;
        private System.Windows.Forms.Label lblRecipeCalorie;
        private System.Windows.Forms.NumericUpDown nudRecipeCalorieMin;
        private System.Windows.Forms.Label lblRecipeCalorieSeparator;
        private System.Windows.Forms.NumericUpDown nudRecipeCalorieMax;
        private System.Windows.Forms.Label lblRecipeCalorieUnit;
        private System.Windows.Forms.Button btnRecipeClear;
        private System.Windows.Forms.Button btnRecipeSearch;
        private System.Windows.Forms.TextBox txtRecipeSearch;
        private System.Windows.Forms.Label lblRecipeSearch;
        private System.Windows.Forms.SplitContainer splitContainerRecipes;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox grpRecipeDetail;
        private System.Windows.Forms.TableLayoutPanel tableRecipeDetail;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblRecipeCode;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.Label lblRecipeType;
        private System.Windows.Forms.TextBox txtRecipeType;
        private System.Windows.Forms.Label lblRecipeServing;
        private System.Windows.Forms.TextBox txtRecipeServing;
        private System.Windows.Forms.Label lblRecipeActive;
        private System.Windows.Forms.TextBox txtRecipeActive;
        private System.Windows.Forms.SplitContainer splitContainerRecipeDetail;
        private System.Windows.Forms.DataGridView dgvRecipeNutrients;
        private System.Windows.Forms.Label lblRecipeNutrients;
        private System.Windows.Forms.DataGridView dgvRecipeComponents;
        private System.Windows.Forms.Label lblRecipeComponents;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeButtons;
        private System.Windows.Forms.Button btnRefreshRecipe;
        private System.Windows.Forms.Button btnRegisterRecipe;
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
