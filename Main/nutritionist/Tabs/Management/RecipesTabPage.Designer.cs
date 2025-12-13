namespace nutritionist.Tabs.Management
{
    partial class RecipesTabPage
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
            this.flowRecipeNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.grpRecipeDetail = new System.Windows.Forms.GroupBox();
            this.lblRecipeActive = new System.Windows.Forms.Label();
            this.lblRecipeCalorie = new System.Windows.Forms.Label();
            this.lblRecipeCalorieSeparator = new System.Windows.Forms.Label();
            this.lblRecipeCalorieUnit = new System.Windows.Forms.Label();
            this.lblRecipeCode = new System.Windows.Forms.Label();
            this.lblRecipeComponents = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeNutrientFilter = new System.Windows.Forms.Label();
            this.lblRecipeNutrients = new System.Windows.Forms.Label();
            this.lblRecipeSearch = new System.Windows.Forms.Label();
            this.lblRecipeServing = new System.Windows.Forms.Label();
            this.lblRecipeType = new System.Windows.Forms.Label();
            this.nudRecipeCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.nudRecipeCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.panelRecipeToolbar = new System.Windows.Forms.Panel();
            this.splitContainerRecipeDetail = new System.Windows.Forms.SplitContainer();
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            this.tableRecipeDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtRecipeActive = new System.Windows.Forms.TextBox();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipeSearch = new System.Windows.Forms.TextBox();
            this.txtRecipeServing = new System.Windows.Forms.TextBox();
            this.txtRecipeType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).BeginInit();
            this.SuspendLayout();
            // RecipesTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerRecipes);
            this.Controls.Add(this.panelRecipeToolbar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RecipesTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipeCalorieMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal System.Windows.Forms.Button btnRecipeClear;
        internal System.Windows.Forms.Button btnRecipeSearch;
        internal System.Windows.Forms.Button btnRefreshRecipe;
        internal System.Windows.Forms.Button btnRegisterRecipe;
        internal System.Windows.Forms.CheckBox chkRecipeNutrientCarb;
        internal System.Windows.Forms.CheckBox chkRecipeNutrientFat;
        internal System.Windows.Forms.CheckBox chkRecipeNutrientProtein;
        internal System.Windows.Forms.DataGridView dgvRecipeComponents;
        internal System.Windows.Forms.DataGridView dgvRecipeNutrients;
        internal System.Windows.Forms.DataGridView dgvRecipes;
        internal System.Windows.Forms.FlowLayoutPanel flowRecipeButtons;
        internal System.Windows.Forms.FlowLayoutPanel flowRecipeCalorieFilter;
        internal System.Windows.Forms.FlowLayoutPanel flowRecipeNutrientFilters;
        internal System.Windows.Forms.GroupBox grpRecipeDetail;
        internal System.Windows.Forms.Label lblRecipeActive;
        internal System.Windows.Forms.Label lblRecipeCalorie;
        internal System.Windows.Forms.Label lblRecipeCalorieSeparator;
        internal System.Windows.Forms.Label lblRecipeCalorieUnit;
        internal System.Windows.Forms.Label lblRecipeCode;
        internal System.Windows.Forms.Label lblRecipeComponents;
        internal System.Windows.Forms.Label lblRecipeName;
        internal System.Windows.Forms.Label lblRecipeNutrientFilter;
        internal System.Windows.Forms.Label lblRecipeNutrients;
        internal System.Windows.Forms.Label lblRecipeSearch;
        internal System.Windows.Forms.Label lblRecipeServing;
        internal System.Windows.Forms.Label lblRecipeType;
        internal System.Windows.Forms.NumericUpDown nudRecipeCalorieMax;
        internal System.Windows.Forms.NumericUpDown nudRecipeCalorieMin;
        internal System.Windows.Forms.Panel panelRecipeToolbar;
        internal System.Windows.Forms.SplitContainer splitContainerRecipeDetail;
        internal System.Windows.Forms.SplitContainer splitContainerRecipes;
        internal System.Windows.Forms.TableLayoutPanel tableRecipeDetail;
        internal System.Windows.Forms.TextBox txtRecipeActive;
        internal System.Windows.Forms.TextBox txtRecipeCode;
        internal System.Windows.Forms.TextBox txtRecipeName;
        internal System.Windows.Forms.TextBox txtRecipeSearch;
        internal System.Windows.Forms.TextBox txtRecipeServing;
        internal System.Windows.Forms.TextBox txtRecipeType;
    }
}
