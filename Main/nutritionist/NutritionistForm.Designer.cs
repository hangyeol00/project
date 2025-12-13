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
            this.dashboardTabControl = new nutritionist.Tabs.NutritionDashboardControl();
            this.tabManagement = new System.Windows.Forms.TabPage();
            this.tabControlManagement = new System.Windows.Forms.TabControl();
            this.tabRawMaterials = new System.Windows.Forms.TabPage();
            this.rawMaterialsTabPage = new nutritionist.Tabs.Management.RawMaterialsTabPage();
            this.tabIngredients = new System.Windows.Forms.TabPage();
            this.ingredientsTabPage = new nutritionist.Tabs.Management.IngredientsTabPage();
            this.tabNutrients = new System.Windows.Forms.TabPage();
            this.nutrientsTabPage = new nutritionist.Tabs.Management.NutrientsTabPage();
            this.tabRecipes = new System.Windows.Forms.TabPage();
            this.recipesTabPage = new nutritionist.Tabs.Management.RecipesTabPage();
            this.tabMealPlans = new System.Windows.Forms.TabPage();
            this.mealPlansTabPage = new nutritionist.Tabs.Management.MealPlansTabPage();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.usersTabPage = new nutritionist.Tabs.Management.UsersTabPage();
            this.tabAllergies = new System.Windows.Forms.TabPage();
            this.allergiesTabPage = new nutritionist.Tabs.Management.AllergiesTabPage();
            this.tabAllergyRelations = new System.Windows.Forms.TabPage();
            this.allergyRelationsTabPage = new nutritionist.Tabs.Management.AllergyRelationsTabPage();
            this.tabMealEvaluations = new System.Windows.Forms.TabPage();
            this.mealEvaluationsTabPage = new nutritionist.Tabs.Management.MealEvaluationsTabPage();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnNavManagement = new System.Windows.Forms.Button();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.panelWorkspace.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            this.tabManagement.SuspendLayout();
            this.tabControlManagement.SuspendLayout();
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
            // menuReload
            // 
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(166, 22);
            this.menuReload.Text = "새로고침";
            // 
            // menuAddRaw
            // 
            this.menuAddRaw.Name = "menuAddRaw";
            this.menuAddRaw.Size = new System.Drawing.Size(166, 22);
            this.menuAddRaw.Text = "원재료 등록";
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
            this.tabDashboard.Controls.Add(this.dashboardTabControl);
            this.tabDashboard.Location = new System.Drawing.Point(4, 5);
            this.tabDashboard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 2);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabDashboard.Size = new System.Drawing.Size(954, 487);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "메인 현황";
            // 
            // dashboardTabControl
            // 
            this.dashboardTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardTabControl.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dashboardTabControl.Location = new System.Drawing.Point(3, 2);
            this.dashboardTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardTabControl.Name = "dashboardTabControl";
            this.dashboardTabControl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dashboardTabControl.Size = new System.Drawing.Size(948, 483);
            this.dashboardTabControl.TabIndex = 0;
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
            this.tabRawMaterials.Controls.Add(this.rawMaterialsTabPage);
            this.tabRawMaterials.Location = new System.Drawing.Point(4, 26);
            this.tabRawMaterials.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRawMaterials.Name = "tabRawMaterials";
            this.tabRawMaterials.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRawMaterials.Size = new System.Drawing.Size(940, 453);
            this.tabRawMaterials.TabIndex = 0;
            this.tabRawMaterials.Text = "재료 관리";
            this.tabRawMaterials.UseVisualStyleBackColor = true;
            // 
            // rawMaterialsTabPage
            // 
            this.rawMaterialsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rawMaterialsTabPage.Location = new System.Drawing.Point(3, 2);
            this.rawMaterialsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawMaterialsTabPage.Name = "rawMaterialsTabPage";
            this.rawMaterialsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawMaterialsTabPage.Size = new System.Drawing.Size(934, 449);
            this.rawMaterialsTabPage.TabIndex = 0;
            // 
            // tabIngredients
            // 
            this.tabIngredients.Controls.Add(this.ingredientsTabPage);
            this.tabIngredients.Location = new System.Drawing.Point(4, 26);
            this.tabIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Name = "tabIngredients";
            this.tabIngredients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabIngredients.Size = new System.Drawing.Size(940, 453);
            this.tabIngredients.TabIndex = 1;
            this.tabIngredients.Text = "발주 요청";
            this.tabIngredients.UseVisualStyleBackColor = true;
            // 
            // ingredientsTabPage
            // 
            this.ingredientsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsTabPage.Location = new System.Drawing.Point(3, 2);
            this.ingredientsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredientsTabPage.Name = "ingredientsTabPage";
            this.ingredientsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingredientsTabPage.Size = new System.Drawing.Size(934, 449);
            this.ingredientsTabPage.TabIndex = 0;
            // 
            // tabNutrients
            // 
            this.tabNutrients.Controls.Add(this.nutrientsTabPage);
            this.tabNutrients.Location = new System.Drawing.Point(4, 26);
            this.tabNutrients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Name = "tabNutrients";
            this.tabNutrients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNutrients.Size = new System.Drawing.Size(940, 453);
            this.tabNutrients.TabIndex = 2;
            this.tabNutrients.Text = "영양소 관리";
            this.tabNutrients.UseVisualStyleBackColor = true;
            // 
            // nutrientsTabPage
            // 
            this.nutrientsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nutrientsTabPage.Location = new System.Drawing.Point(3, 2);
            this.nutrientsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nutrientsTabPage.Name = "nutrientsTabPage";
            this.nutrientsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nutrientsTabPage.Size = new System.Drawing.Size(934, 449);
            this.nutrientsTabPage.TabIndex = 0;
            // 
            // tabRecipes
            // 
            this.tabRecipes.Controls.Add(this.recipesTabPage);
            this.tabRecipes.Location = new System.Drawing.Point(4, 26);
            this.tabRecipes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Name = "tabRecipes";
            this.tabRecipes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabRecipes.Size = new System.Drawing.Size(940, 453);
            this.tabRecipes.TabIndex = 3;
            this.tabRecipes.Text = "요리 관리";
            this.tabRecipes.UseVisualStyleBackColor = true;
            // 
            // recipesTabPage
            // 
            this.recipesTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesTabPage.Location = new System.Drawing.Point(3, 2);
            this.recipesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipesTabPage.Name = "recipesTabPage";
            this.recipesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recipesTabPage.Size = new System.Drawing.Size(934, 449);
            this.recipesTabPage.TabIndex = 0;
            // 
            // tabMealPlans
            // 
            this.tabMealPlans.Controls.Add(this.mealPlansTabPage);
            this.tabMealPlans.Location = new System.Drawing.Point(4, 26);
            this.tabMealPlans.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Name = "tabMealPlans";
            this.tabMealPlans.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealPlans.Size = new System.Drawing.Size(940, 453);
            this.tabMealPlans.TabIndex = 4;
            this.tabMealPlans.Text = "식단 관리";
            this.tabMealPlans.UseVisualStyleBackColor = true;
            // 
            // mealPlansTabPage
            // 
            this.mealPlansTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealPlansTabPage.Location = new System.Drawing.Point(3, 2);
            this.mealPlansTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealPlansTabPage.Name = "mealPlansTabPage";
            this.mealPlansTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealPlansTabPage.Size = new System.Drawing.Size(934, 449);
            this.mealPlansTabPage.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.usersTabPage);
            this.tabUsers.Location = new System.Drawing.Point(4, 26);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabUsers.Size = new System.Drawing.Size(940, 453);
            this.tabUsers.TabIndex = 5;
            this.tabUsers.Text = "이용자 관리";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // usersTabPage
            // 
            this.usersTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersTabPage.Location = new System.Drawing.Point(3, 2);
            this.usersTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersTabPage.Name = "usersTabPage";
            this.usersTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usersTabPage.Size = new System.Drawing.Size(934, 449);
            this.usersTabPage.TabIndex = 0;
            // 
            // tabAllergies
            // 
            this.tabAllergies.Controls.Add(this.allergiesTabPage);
            this.tabAllergies.Location = new System.Drawing.Point(4, 26);
            this.tabAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Name = "tabAllergies";
            this.tabAllergies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergies.Size = new System.Drawing.Size(940, 453);
            this.tabAllergies.TabIndex = 6;
            this.tabAllergies.Text = "알레르기 관리";
            this.tabAllergies.UseVisualStyleBackColor = true;
            // 
            // allergiesTabPage
            // 
            this.allergiesTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allergiesTabPage.Location = new System.Drawing.Point(3, 2);
            this.allergiesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergiesTabPage.Name = "allergiesTabPage";
            this.allergiesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergiesTabPage.Size = new System.Drawing.Size(934, 449);
            this.allergiesTabPage.TabIndex = 0;
            // 
            // tabAllergyRelations
            // 
            this.tabAllergyRelations.Controls.Add(this.allergyRelationsTabPage);
            this.tabAllergyRelations.Location = new System.Drawing.Point(4, 26);
            this.tabAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Name = "tabAllergyRelations";
            this.tabAllergyRelations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAllergyRelations.Size = new System.Drawing.Size(940, 453);
            this.tabAllergyRelations.TabIndex = 7;
            this.tabAllergyRelations.Text = "알레르기 관계";
            this.tabAllergyRelations.UseVisualStyleBackColor = true;
            // 
            // allergyRelationsTabPage
            // 
            this.allergyRelationsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allergyRelationsTabPage.Location = new System.Drawing.Point(3, 2);
            this.allergyRelationsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergyRelationsTabPage.Name = "allergyRelationsTabPage";
            this.allergyRelationsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergyRelationsTabPage.Size = new System.Drawing.Size(934, 449);
            this.allergyRelationsTabPage.TabIndex = 0;
            // 
            // tabMealEvaluations
            // 
            this.tabMealEvaluations.Controls.Add(this.mealEvaluationsTabPage);
            this.tabMealEvaluations.Location = new System.Drawing.Point(4, 26);
            this.tabMealEvaluations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Name = "tabMealEvaluations";
            this.tabMealEvaluations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMealEvaluations.Size = new System.Drawing.Size(940, 453);
            this.tabMealEvaluations.TabIndex = 8;
            this.tabMealEvaluations.Text = "식단 평가";
            this.tabMealEvaluations.UseVisualStyleBackColor = true;
            // 
            // mealEvaluationsTabPage
            // 
            this.mealEvaluationsTabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mealEvaluationsTabPage.Location = new System.Drawing.Point(3, 2);
            this.mealEvaluationsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealEvaluationsTabPage.Name = "mealEvaluationsTabPage";
            this.mealEvaluationsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealEvaluationsTabPage.Size = new System.Drawing.Size(934, 449);
            this.mealEvaluationsTabPage.TabIndex = 0;
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
            this.tabManagement.ResumeLayout(false);
            this.tabControlManagement.ResumeLayout(false);
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripMenuItem menuAddRaw;
        private System.Windows.Forms.ToolStripMenuItem menuOpenAdmin;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Panel panelWorkspace;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDashboard;
        private nutritionist.Tabs.NutritionDashboardControl dashboardTabControl;
        private System.Windows.Forms.TabPage tabManagement;
        private System.Windows.Forms.TabControl tabControlManagement;
        private System.Windows.Forms.TabPage tabRawMaterials;
        private System.Windows.Forms.TabPage tabIngredients;
        private System.Windows.Forms.TabPage tabNutrients;
        private System.Windows.Forms.TabPage tabRecipes;
        private System.Windows.Forms.TabPage tabMealPlans;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabAllergies;
        private System.Windows.Forms.TabPage tabAllergyRelations;
        private System.Windows.Forms.TabPage tabMealEvaluations;
        private nutritionist.Tabs.Management.RawMaterialsTabPage rawMaterialsTabPage;
        private nutritionist.Tabs.Management.IngredientsTabPage ingredientsTabPage;
        private nutritionist.Tabs.Management.NutrientsTabPage nutrientsTabPage;
        private nutritionist.Tabs.Management.RecipesTabPage recipesTabPage;
        private nutritionist.Tabs.Management.MealPlansTabPage mealPlansTabPage;
        private nutritionist.Tabs.Management.UsersTabPage usersTabPage;
        private nutritionist.Tabs.Management.AllergiesTabPage allergiesTabPage;
        private nutritionist.Tabs.Management.AllergyRelationsTabPage allergyRelationsTabPage;
        private nutritionist.Tabs.Management.MealEvaluationsTabPage mealEvaluationsTabPage;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnNavManagement;
        private System.Windows.Forms.Button btnNavDashboard;
    }
}
