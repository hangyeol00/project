namespace nutritionist.Forms
{
    partial class RecipesForm
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
            this.btnRecipeClear = new System.Windows.Forms.Button();
            this.btnRecipeSearch = new System.Windows.Forms.Button();
            this.btnRefreshRecipe = new System.Windows.Forms.Button();
            this.btnRegisterRecipe = new System.Windows.Forms.Button();
            this.chkRecipeNutrientCarb = new System.Windows.Forms.CheckBox();
            this.chkRecipeNutrientFat = new System.Windows.Forms.CheckBox();
            this.chkRecipeNutrientProtein = new System.Windows.Forms.CheckBox();
            this.dgvRecipeComponents = new System.Windows.Forms.DataGridView();
            this.dgvRecipeNutrients = new System.Windows.Forms.DataGridView();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.flowRecipeButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRecipeCalorieFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecipeCalorie = new System.Windows.Forms.Label();
            this.nudRecipeCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.lblRecipeCalorieSeparator = new System.Windows.Forms.Label();
            this.nudRecipeCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.lblRecipeCalorieUnit = new System.Windows.Forms.Label();
            this.flowRecipeNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRecipeNutrientFilter = new System.Windows.Forms.Label();
            this.grpRecipeDetail = new System.Windows.Forms.GroupBox();
            this.splitContainerRecipeDetail = new System.Windows.Forms.SplitContainer();
            this.lblRecipeNutrients = new System.Windows.Forms.Label();
            this.lblRecipeComponents = new System.Windows.Forms.Label();
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
            this.lblRecipeSearch = new System.Windows.Forms.Label();
            this.panelRecipeToolbar = new System.Windows.Forms.Panel();
            this.txtRecipeSearch = new System.Windows.Forms.TextBox();
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.flowRecipeButtons.SuspendLayout();
            this.flowRecipeCalorieFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).BeginInit();
            this.flowRecipeNutrientFilters.SuspendLayout();
            this.grpRecipeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).BeginInit();
            this.splitContainerRecipeDetail.Panel1.SuspendLayout();
            this.splitContainerRecipeDetail.Panel2.SuspendLayout();
            this.splitContainerRecipeDetail.SuspendLayout();
            this.tableRecipeDetail.SuspendLayout();
            this.panelRecipeToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).BeginInit();
            this.splitContainerRecipes.Panel1.SuspendLayout();
            this.splitContainerRecipes.Panel2.SuspendLayout();
            this.splitContainerRecipes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecipeClear
            // 
            this.btnRecipeClear.Location = new System.Drawing.Point(538, 10);
            this.btnRecipeClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRecipeClear.Name = "btnRecipeClear";
            this.btnRecipeClear.Size = new System.Drawing.Size(90, 28);
            this.btnRecipeClear.TabIndex = 3;
            this.btnRecipeClear.Text = "초기화";
            this.btnRecipeClear.UseVisualStyleBackColor = true;
            // 
            // btnRecipeSearch
            // 
            this.btnRecipeSearch.Location = new System.Drawing.Point(440, 10);
            this.btnRecipeSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRecipeSearch.Name = "btnRecipeSearch";
            this.btnRecipeSearch.Size = new System.Drawing.Size(90, 28);
            this.btnRecipeSearch.TabIndex = 2;
            this.btnRecipeSearch.Text = "검색";
            this.btnRecipeSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRecipe
            // 
            this.btnRefreshRecipe.Location = new System.Drawing.Point(452, 6);
            this.btnRefreshRecipe.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRefreshRecipe.Name = "btnRefreshRecipe";
            this.btnRefreshRecipe.Size = new System.Drawing.Size(120, 30);
            this.btnRefreshRecipe.TabIndex = 0;
            this.btnRefreshRecipe.Text = "새로 고침";
            this.btnRefreshRecipe.UseVisualStyleBackColor = true;
            // 
            // btnRegisterRecipe
            // 
            this.btnRegisterRecipe.Location = new System.Drawing.Point(321, 6);
            this.btnRegisterRecipe.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRegisterRecipe.Name = "btnRegisterRecipe";
            this.btnRegisterRecipe.Size = new System.Drawing.Size(120, 30);
            this.btnRegisterRecipe.TabIndex = 1;
            this.btnRegisterRecipe.Text = "메뉴 등록";
            this.btnRegisterRecipe.UseVisualStyleBackColor = true;
            // 
            // chkRecipeNutrientCarb
            // 
            this.chkRecipeNutrientCarb.AutoSize = true;
            this.chkRecipeNutrientCarb.Location = new System.Drawing.Point(252, 3);
            this.chkRecipeNutrientCarb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecipeNutrientCarb.Name = "chkRecipeNutrientCarb";
            this.chkRecipeNutrientCarb.Size = new System.Drawing.Size(106, 22);
            this.chkRecipeNutrientCarb.TabIndex = 3;
            this.chkRecipeNutrientCarb.Tag = "CARB";
            this.chkRecipeNutrientCarb.Text = "탄수화물";
            this.chkRecipeNutrientCarb.UseVisualStyleBackColor = true;
            // 
            // chkRecipeNutrientFat
            // 
            this.chkRecipeNutrientFat.AutoSize = true;
            this.chkRecipeNutrientFat.Location = new System.Drawing.Point(174, 3);
            this.chkRecipeNutrientFat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecipeNutrientFat.Name = "chkRecipeNutrientFat";
            this.chkRecipeNutrientFat.Size = new System.Drawing.Size(70, 22);
            this.chkRecipeNutrientFat.TabIndex = 2;
            this.chkRecipeNutrientFat.Tag = "FAT";
            this.chkRecipeNutrientFat.Text = "지방";
            this.chkRecipeNutrientFat.UseVisualStyleBackColor = true;
            // 
            // chkRecipeNutrientProtein
            // 
            this.chkRecipeNutrientProtein.AutoSize = true;
            this.chkRecipeNutrientProtein.Location = new System.Drawing.Point(78, 3);
            this.chkRecipeNutrientProtein.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRecipeNutrientProtein.Name = "chkRecipeNutrientProtein";
            this.chkRecipeNutrientProtein.Size = new System.Drawing.Size(88, 22);
            this.chkRecipeNutrientProtein.TabIndex = 1;
            this.chkRecipeNutrientProtein.Tag = "PROT";
            this.chkRecipeNutrientProtein.Text = "단백질";
            this.chkRecipeNutrientProtein.UseVisualStyleBackColor = true;
            // 
            // dgvRecipeComponents
            // 
            this.dgvRecipeComponents.AllowUserToAddRows = false;
            this.dgvRecipeComponents.AllowUserToDeleteRows = false;
            this.dgvRecipeComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipeComponents.Location = new System.Drawing.Point(0, 32);
            this.dgvRecipeComponents.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRecipeComponents.MultiSelect = false;
            this.dgvRecipeComponents.Name = "dgvRecipeComponents";
            this.dgvRecipeComponents.ReadOnly = true;
            this.dgvRecipeComponents.RowHeadersVisible = false;
            this.dgvRecipeComponents.RowHeadersWidth = 51;
            this.dgvRecipeComponents.RowTemplate.Height = 27;
            this.dgvRecipeComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeComponents.Size = new System.Drawing.Size(572, 14);
            this.dgvRecipeComponents.TabIndex = 1;
            // 
            // dgvRecipeNutrients
            // 
            this.dgvRecipeNutrients.AllowUserToAddRows = false;
            this.dgvRecipeNutrients.AllowUserToDeleteRows = false;
            this.dgvRecipeNutrients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipeNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipeNutrients.Location = new System.Drawing.Point(0, 32);
            this.dgvRecipeNutrients.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRecipeNutrients.MultiSelect = false;
            this.dgvRecipeNutrients.Name = "dgvRecipeNutrients";
            this.dgvRecipeNutrients.ReadOnly = true;
            this.dgvRecipeNutrients.RowHeadersVisible = false;
            this.dgvRecipeNutrients.RowHeadersWidth = 51;
            this.dgvRecipeNutrients.RowTemplate.Height = 27;
            this.dgvRecipeNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeNutrients.Size = new System.Drawing.Size(572, 18);
            this.dgvRecipeNutrients.TabIndex = 1;
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipes.Location = new System.Drawing.Point(0, 0);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.RowTemplate.Height = 27;
            this.dgvRecipes.Size = new System.Drawing.Size(590, 380);
            this.dgvRecipes.TabIndex = 0;
            // 
            // flowRecipeButtons
            // 
            this.flowRecipeButtons.Controls.Add(this.btnRefreshRecipe);
            this.flowRecipeButtons.Controls.Add(this.btnRegisterRecipe);
            this.flowRecipeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRecipeButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRecipeButtons.Location = new System.Drawing.Point(4, 314);
            this.flowRecipeButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRecipeButtons.Name = "flowRecipeButtons";
            this.flowRecipeButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRecipeButtons.Size = new System.Drawing.Size(572, 64);
            this.flowRecipeButtons.TabIndex = 2;
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
            this.flowRecipeCalorieFilter.Location = new System.Drawing.Point(10, 74);
            this.flowRecipeCalorieFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRecipeCalorieFilter.Name = "flowRecipeCalorieFilter";
            this.flowRecipeCalorieFilter.Size = new System.Drawing.Size(436, 32);
            this.flowRecipeCalorieFilter.TabIndex = 5;
            // 
            // lblRecipeCalorie
            // 
            this.lblRecipeCalorie.AutoSize = true;
            this.lblRecipeCalorie.Location = new System.Drawing.Point(4, 0);
            this.lblRecipeCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRecipeCalorie.Name = "lblRecipeCalorie";
            this.lblRecipeCalorie.Size = new System.Drawing.Size(88, 18);
            this.lblRecipeCalorie.TabIndex = 0;
            this.lblRecipeCalorie.Text = "열량(kcal)";
            // 
            // nudRecipeCalorieMin
            // 
            this.nudRecipeCalorieMin.Location = new System.Drawing.Point(104, 2);
            this.nudRecipeCalorieMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudRecipeCalorieMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRecipeCalorieMin.Name = "nudRecipeCalorieMin";
            this.nudRecipeCalorieMin.Size = new System.Drawing.Size(88, 28);
            this.nudRecipeCalorieMin.TabIndex = 1;
            // 
            // lblRecipeCalorieSeparator
            // 
            this.lblRecipeCalorieSeparator.AutoSize = true;
            this.lblRecipeCalorieSeparator.Location = new System.Drawing.Point(200, 0);
            this.lblRecipeCalorieSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRecipeCalorieSeparator.Name = "lblRecipeCalorieSeparator";
            this.lblRecipeCalorieSeparator.Size = new System.Drawing.Size(22, 18);
            this.lblRecipeCalorieSeparator.TabIndex = 2;
            this.lblRecipeCalorieSeparator.Text = "~";
            // 
            // nudRecipeCalorieMax
            // 
            this.nudRecipeCalorieMax.Location = new System.Drawing.Point(234, 2);
            this.nudRecipeCalorieMax.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudRecipeCalorieMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRecipeCalorieMax.Name = "nudRecipeCalorieMax";
            this.nudRecipeCalorieMax.Size = new System.Drawing.Size(88, 28);
            this.nudRecipeCalorieMax.TabIndex = 3;
            // 
            // lblRecipeCalorieUnit
            // 
            this.lblRecipeCalorieUnit.AutoSize = true;
            this.lblRecipeCalorieUnit.Location = new System.Drawing.Point(330, 0);
            this.lblRecipeCalorieUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeCalorieUnit.Name = "lblRecipeCalorieUnit";
            this.lblRecipeCalorieUnit.Size = new System.Drawing.Size(102, 18);
            this.lblRecipeCalorieUnit.TabIndex = 4;
            this.lblRecipeCalorieUnit.Text = "기준(1인분)";
            // 
            // flowRecipeNutrientFilters
            // 
            this.flowRecipeNutrientFilters.AutoSize = true;
            this.flowRecipeNutrientFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRecipeNutrientFilters.Controls.Add(this.lblRecipeNutrientFilter);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientProtein);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientFat);
            this.flowRecipeNutrientFilters.Controls.Add(this.chkRecipeNutrientCarb);
            this.flowRecipeNutrientFilters.Location = new System.Drawing.Point(10, 42);
            this.flowRecipeNutrientFilters.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRecipeNutrientFilters.Name = "flowRecipeNutrientFilters";
            this.flowRecipeNutrientFilters.Size = new System.Drawing.Size(362, 28);
            this.flowRecipeNutrientFilters.TabIndex = 4;
            this.flowRecipeNutrientFilters.WrapContents = false;
            // 
            // lblRecipeNutrientFilter
            // 
            this.lblRecipeNutrientFilter.AutoSize = true;
            this.lblRecipeNutrientFilter.Location = new System.Drawing.Point(4, 0);
            this.lblRecipeNutrientFilter.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRecipeNutrientFilter.Name = "lblRecipeNutrientFilter";
            this.lblRecipeNutrientFilter.Size = new System.Drawing.Size(62, 18);
            this.lblRecipeNutrientFilter.TabIndex = 0;
            this.lblRecipeNutrientFilter.Text = "영양소";
            // 
            // grpRecipeDetail
            // 
            this.grpRecipeDetail.Controls.Add(this.splitContainerRecipeDetail);
            this.grpRecipeDetail.Controls.Add(this.flowRecipeButtons);
            this.grpRecipeDetail.Controls.Add(this.tableRecipeDetail);
            this.grpRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipeDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRecipeDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRecipeDetail.Name = "grpRecipeDetail";
            this.grpRecipeDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRecipeDetail.Size = new System.Drawing.Size(580, 380);
            this.grpRecipeDetail.TabIndex = 0;
            this.grpRecipeDetail.TabStop = false;
            this.grpRecipeDetail.Text = "요리 정보";
            // 
            // splitContainerRecipeDetail
            // 
            this.splitContainerRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipeDetail.Location = new System.Drawing.Point(4, 214);
            this.splitContainerRecipeDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.splitContainerRecipeDetail.Size = new System.Drawing.Size(572, 100);
            this.splitContainerRecipeDetail.TabIndex = 1;
            // 
            // lblRecipeNutrients
            // 
            this.lblRecipeNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeNutrients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeNutrients.Name = "lblRecipeNutrients";
            this.lblRecipeNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeNutrients.Size = new System.Drawing.Size(572, 32);
            this.lblRecipeNutrients.TabIndex = 0;
            this.lblRecipeNutrients.Text = "영양소 정보";
            // 
            // lblRecipeComponents
            // 
            this.lblRecipeComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeComponents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeComponents.Name = "lblRecipeComponents";
            this.lblRecipeComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeComponents.Size = new System.Drawing.Size(572, 32);
            this.lblRecipeComponents.TabIndex = 0;
            this.lblRecipeComponents.Text = "포함 원재료";
            // 
            // tableRecipeDetail
            // 
            this.tableRecipeDetail.ColumnCount = 2;
            this.tableRecipeDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
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
            this.tableRecipeDetail.Location = new System.Drawing.Point(4, 23);
            this.tableRecipeDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableRecipeDetail.Name = "tableRecipeDetail";
            this.tableRecipeDetail.RowCount = 5;
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRecipeDetail.Size = new System.Drawing.Size(572, 191);
            this.tableRecipeDetail.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Location = new System.Drawing.Point(4, 0);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(130, 38);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "요리명";
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(142, 2);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(426, 28);
            this.txtRecipeName.TabIndex = 1;
            // 
            // lblRecipeCode
            // 
            this.lblRecipeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeCode.Location = new System.Drawing.Point(4, 38);
            this.lblRecipeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeCode.Name = "lblRecipeCode";
            this.lblRecipeCode.Size = new System.Drawing.Size(130, 38);
            this.lblRecipeCode.TabIndex = 2;
            this.lblRecipeCode.Text = "메뉴 코드";
            this.lblRecipeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeCode.Location = new System.Drawing.Point(142, 40);
            this.txtRecipeCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.ReadOnly = true;
            this.txtRecipeCode.Size = new System.Drawing.Size(426, 28);
            this.txtRecipeCode.TabIndex = 3;
            // 
            // lblRecipeType
            // 
            this.lblRecipeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeType.Location = new System.Drawing.Point(4, 76);
            this.lblRecipeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeType.Name = "lblRecipeType";
            this.lblRecipeType.Size = new System.Drawing.Size(130, 38);
            this.lblRecipeType.TabIndex = 4;
            this.lblRecipeType.Text = "분류";
            this.lblRecipeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeType
            // 
            this.txtRecipeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeType.Location = new System.Drawing.Point(142, 78);
            this.txtRecipeType.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeType.Name = "txtRecipeType";
            this.txtRecipeType.ReadOnly = true;
            this.txtRecipeType.Size = new System.Drawing.Size(426, 28);
            this.txtRecipeType.TabIndex = 5;
            // 
            // lblRecipeServing
            // 
            this.lblRecipeServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeServing.Location = new System.Drawing.Point(4, 114);
            this.lblRecipeServing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeServing.Name = "lblRecipeServing";
            this.lblRecipeServing.Size = new System.Drawing.Size(130, 38);
            this.lblRecipeServing.TabIndex = 6;
            this.lblRecipeServing.Text = "1인 제공량(g)";
            this.lblRecipeServing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeServing
            // 
            this.txtRecipeServing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeServing.Location = new System.Drawing.Point(142, 116);
            this.txtRecipeServing.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeServing.Name = "txtRecipeServing";
            this.txtRecipeServing.ReadOnly = true;
            this.txtRecipeServing.Size = new System.Drawing.Size(426, 28);
            this.txtRecipeServing.TabIndex = 7;
            // 
            // lblRecipeActive
            // 
            this.lblRecipeActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeActive.Location = new System.Drawing.Point(4, 152);
            this.lblRecipeActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeActive.Name = "lblRecipeActive";
            this.lblRecipeActive.Size = new System.Drawing.Size(130, 39);
            this.lblRecipeActive.TabIndex = 8;
            this.lblRecipeActive.Text = "사용 여부";
            this.lblRecipeActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRecipeActive
            // 
            this.txtRecipeActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeActive.Location = new System.Drawing.Point(142, 154);
            this.txtRecipeActive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeActive.Name = "txtRecipeActive";
            this.txtRecipeActive.ReadOnly = true;
            this.txtRecipeActive.Size = new System.Drawing.Size(426, 28);
            this.txtRecipeActive.TabIndex = 9;
            // 
            // lblRecipeSearch
            // 
            this.lblRecipeSearch.AutoSize = true;
            this.lblRecipeSearch.Location = new System.Drawing.Point(10, 14);
            this.lblRecipeSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeSearch.Name = "lblRecipeSearch";
            this.lblRecipeSearch.Size = new System.Drawing.Size(118, 18);
            this.lblRecipeSearch.TabIndex = 0;
            this.lblRecipeSearch.Text = "메뉴명 / 코드";
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
            this.panelRecipeToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelRecipeToolbar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelRecipeToolbar.Name = "panelRecipeToolbar";
            this.panelRecipeToolbar.Size = new System.Drawing.Size(1175, 100);
            this.panelRecipeToolbar.TabIndex = 0;
            // 
            // txtRecipeSearch
            // 
            this.txtRecipeSearch.Location = new System.Drawing.Point(132, 11);
            this.txtRecipeSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRecipeSearch.Name = "txtRecipeSearch";
            this.txtRecipeSearch.Size = new System.Drawing.Size(299, 28);
            this.txtRecipeSearch.TabIndex = 1;
            // 
            // splitContainerRecipes
            // 
            this.splitContainerRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipes.Location = new System.Drawing.Point(0, 100);
            this.splitContainerRecipes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerRecipes.Name = "splitContainerRecipes";
            // 
            // splitContainerRecipes.Panel1
            // 
            this.splitContainerRecipes.Panel1.Controls.Add(this.dgvRecipes);
            // 
            // splitContainerRecipes.Panel2
            // 
            this.splitContainerRecipes.Panel2.Controls.Add(this.grpRecipeDetail);
            this.splitContainerRecipes.Size = new System.Drawing.Size(1175, 380);
            this.splitContainerRecipes.SplitterDistance = 590;
            this.splitContainerRecipes.SplitterWidth = 5;
            this.splitContainerRecipes.TabIndex = 0;
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 480);
            this.Controls.Add(this.splitContainerRecipes);
            this.Controls.Add(this.panelRecipeToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "RecipesForm";
            this.Text = "RecipesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.flowRecipeButtons.ResumeLayout(false);
            this.flowRecipeCalorieFilter.ResumeLayout(false);
            this.flowRecipeCalorieFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).EndInit();
            this.flowRecipeNutrientFilters.ResumeLayout(false);
            this.flowRecipeNutrientFilters.PerformLayout();
            this.grpRecipeDetail.ResumeLayout(false);
            this.splitContainerRecipeDetail.Panel1.ResumeLayout(false);
            this.splitContainerRecipeDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).EndInit();
            this.splitContainerRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.PerformLayout();
            this.panelRecipeToolbar.ResumeLayout(false);
            this.panelRecipeToolbar.PerformLayout();
            this.splitContainerRecipes.Panel1.ResumeLayout(false);
            this.splitContainerRecipes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            this.splitContainerRecipes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnRecipeClear;
        private System.Windows.Forms.Button btnRecipeSearch;
        private System.Windows.Forms.Button btnRefreshRecipe;
        private System.Windows.Forms.Button btnRegisterRecipe;
        private System.Windows.Forms.CheckBox chkRecipeNutrientCarb;
        private System.Windows.Forms.CheckBox chkRecipeNutrientFat;
        private System.Windows.Forms.CheckBox chkRecipeNutrientProtein;
        private System.Windows.Forms.DataGridView dgvRecipeComponents;
        private System.Windows.Forms.DataGridView dgvRecipeNutrients;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeButtons;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeCalorieFilter;
        private System.Windows.Forms.FlowLayoutPanel flowRecipeNutrientFilters;
        private System.Windows.Forms.GroupBox grpRecipeDetail;
        private System.Windows.Forms.Label lblRecipeActive;
        private System.Windows.Forms.Label lblRecipeCalorie;
        private System.Windows.Forms.Label lblRecipeCalorieSeparator;
        private System.Windows.Forms.Label lblRecipeCalorieUnit;
        private System.Windows.Forms.Label lblRecipeCode;
        private System.Windows.Forms.Label lblRecipeComponents;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblRecipeNutrientFilter;
        private System.Windows.Forms.Label lblRecipeNutrients;
        private System.Windows.Forms.Label lblRecipeSearch;
        private System.Windows.Forms.Label lblRecipeServing;
        private System.Windows.Forms.Label lblRecipeType;
        private System.Windows.Forms.NumericUpDown nudRecipeCalorieMax;
        private System.Windows.Forms.NumericUpDown nudRecipeCalorieMin;
        private System.Windows.Forms.Panel panelRecipeToolbar;
        private System.Windows.Forms.SplitContainer splitContainerRecipeDetail;
        private System.Windows.Forms.SplitContainer splitContainerRecipes;
        private System.Windows.Forms.TableLayoutPanel tableRecipeDetail;
        private System.Windows.Forms.TextBox txtRecipeActive;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtRecipeSearch;
        private System.Windows.Forms.TextBox txtRecipeServing;
        private System.Windows.Forms.TextBox txtRecipeType;
    }
}
