using System.ComponentModel;
using System.Windows.Forms;

namespace nutritionist.Forms
{
    partial class RawMaterialsForm
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
            this.btnRawAdd = new System.Windows.Forms.Button();
            this.btnRawClear = new System.Windows.Forms.Button();
            this.btnRawRefresh = new System.Windows.Forms.Button();
            this.btnRawSearch = new System.Windows.Forms.Button();
            this.chkRawGroup = new System.Windows.Forms.CheckBox();
            this.chkRawNutrientCarb = new System.Windows.Forms.CheckBox();
            this.chkRawNutrientFat = new System.Windows.Forms.CheckBox();
            this.chkRawNutrientProtein = new System.Windows.Forms.CheckBox();
            this.dgvRawComponents = new System.Windows.Forms.DataGridView();
            this.dgvRawMaterials = new System.Windows.Forms.DataGridView();
            this.dgvRawNutrients = new System.Windows.Forms.DataGridView();
            this.flowRawButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowRawCalorieFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRawCalorie = new System.Windows.Forms.Label();
            this.nudRawCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.lblRawCalorieSeparator = new System.Windows.Forms.Label();
            this.nudRawCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.lblRawCalorieUnit = new System.Windows.Forms.Label();
            this.flowRawNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRawNutrientFilter = new System.Windows.Forms.Label();
            this.grpRawDetail = new System.Windows.Forms.GroupBox();
            this.splitContainerRawDetail = new System.Windows.Forms.SplitContainer();
            this.lblRawNutrients = new System.Windows.Forms.Label();
            this.lblRawComponents = new System.Windows.Forms.Label();
            this.tableRawDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRawDetailName = new System.Windows.Forms.Label();
            this.txtRawDetailName = new System.Windows.Forms.TextBox();
            this.lblRawDetailCategory = new System.Windows.Forms.Label();
            this.txtRawDetailCategory = new System.Windows.Forms.TextBox();
            this.lblRawDetailUnit = new System.Windows.Forms.Label();
            this.txtRawDetailUnit = new System.Windows.Forms.TextBox();
            this.lblRawDetailBaseQty = new System.Windows.Forms.Label();
            this.txtRawDetailBaseQty = new System.Windows.Forms.TextBox();
            this.lblRawDetailUnitGram = new System.Windows.Forms.Label();
            this.txtRawDetailUnitGram = new System.Windows.Forms.TextBox();
            this.lblRawDetailActive = new System.Windows.Forms.Label();
            this.txtRawDetailActive = new System.Windows.Forms.TextBox();
            this.lblRawDetailShelfLife = new System.Windows.Forms.Label();
            this.txtRawDetailShelfLife = new System.Windows.Forms.TextBox();
            this.lblRawDetailStorage = new System.Windows.Forms.Label();
            this.txtRawDetailStorage = new System.Windows.Forms.TextBox();
            this.lblRawSearch = new System.Windows.Forms.Label();
            this.panelRawToolbar = new System.Windows.Forms.Panel();
            this.txtRawSearch = new System.Windows.Forms.TextBox();
            this.splitContainerRawMaterials = new System.Windows.Forms.SplitContainer();
            this.tvRawMaterials = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).BeginInit();
            this.flowRawButtons.SuspendLayout();
            this.flowRawCalorieFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).BeginInit();
            this.flowRawNutrientFilters.SuspendLayout();
            this.grpRawDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).BeginInit();
            this.splitContainerRawDetail.Panel1.SuspendLayout();
            this.splitContainerRawDetail.Panel2.SuspendLayout();
            this.splitContainerRawDetail.SuspendLayout();
            this.tableRawDetail.SuspendLayout();
            this.panelRawToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).BeginInit();
            this.splitContainerRawMaterials.Panel1.SuspendLayout();
            this.splitContainerRawMaterials.Panel2.SuspendLayout();
            this.splitContainerRawMaterials.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRawAdd
            // 
            this.btnRawAdd.Location = new System.Drawing.Point(438, 6);
            this.btnRawAdd.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRawAdd.Name = "btnRawAdd";
            this.btnRawAdd.Size = new System.Drawing.Size(134, 30);
            this.btnRawAdd.TabIndex = 0;
            this.btnRawAdd.Text = "원재료 등록";
            this.btnRawAdd.UseVisualStyleBackColor = true;
            // 
            // btnRawClear
            // 
            this.btnRawClear.Location = new System.Drawing.Point(655, 10);
            this.btnRawClear.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRawClear.Name = "btnRawClear";
            this.btnRawClear.Size = new System.Drawing.Size(90, 28);
            this.btnRawClear.TabIndex = 4;
            this.btnRawClear.Text = "초기화";
            this.btnRawClear.UseVisualStyleBackColor = true;
            // 
            // btnRawRefresh
            // 
            this.btnRawRefresh.Location = new System.Drawing.Point(318, 6);
            this.btnRawRefresh.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRawRefresh.Name = "btnRawRefresh";
            this.btnRawRefresh.Size = new System.Drawing.Size(109, 30);
            this.btnRawRefresh.TabIndex = 1;
            this.btnRawRefresh.Text = "새로 고침";
            this.btnRawRefresh.UseVisualStyleBackColor = true;
            // 
            // btnRawSearch
            // 
            this.btnRawSearch.Location = new System.Drawing.Point(558, 10);
            this.btnRawSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnRawSearch.Name = "btnRawSearch";
            this.btnRawSearch.Size = new System.Drawing.Size(90, 28);
            this.btnRawSearch.TabIndex = 3;
            this.btnRawSearch.Text = "검색";
            this.btnRawSearch.UseVisualStyleBackColor = true;
            // 
            // chkRawGroup
            // 
            this.chkRawGroup.AutoSize = true;
            this.chkRawGroup.Location = new System.Drawing.Point(430, 44);
            this.chkRawGroup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.chkRawGroup.Name = "chkRawGroup";
            this.chkRawGroup.Size = new System.Drawing.Size(208, 22);
            this.chkRawGroup.TabIndex = 6;
            this.chkRawGroup.Text = "카테고리별 그룹 보기";
            this.chkRawGroup.UseVisualStyleBackColor = true;
            // 
            // chkRawNutrientCarb
            // 
            this.chkRawNutrientCarb.AutoSize = true;
            this.chkRawNutrientCarb.Location = new System.Drawing.Point(252, 3);
            this.chkRawNutrientCarb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRawNutrientCarb.Name = "chkRawNutrientCarb";
            this.chkRawNutrientCarb.Size = new System.Drawing.Size(106, 22);
            this.chkRawNutrientCarb.TabIndex = 3;
            this.chkRawNutrientCarb.Tag = "CARB";
            this.chkRawNutrientCarb.Text = "탄수화물";
            this.chkRawNutrientCarb.UseVisualStyleBackColor = true;
            // 
            // chkRawNutrientFat
            // 
            this.chkRawNutrientFat.AutoSize = true;
            this.chkRawNutrientFat.Location = new System.Drawing.Point(174, 3);
            this.chkRawNutrientFat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRawNutrientFat.Name = "chkRawNutrientFat";
            this.chkRawNutrientFat.Size = new System.Drawing.Size(70, 22);
            this.chkRawNutrientFat.TabIndex = 2;
            this.chkRawNutrientFat.Tag = "FAT";
            this.chkRawNutrientFat.Text = "지방";
            this.chkRawNutrientFat.UseVisualStyleBackColor = true;
            // 
            // chkRawNutrientProtein
            // 
            this.chkRawNutrientProtein.AutoSize = true;
            this.chkRawNutrientProtein.Location = new System.Drawing.Point(78, 3);
            this.chkRawNutrientProtein.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkRawNutrientProtein.Name = "chkRawNutrientProtein";
            this.chkRawNutrientProtein.Size = new System.Drawing.Size(88, 22);
            this.chkRawNutrientProtein.TabIndex = 1;
            this.chkRawNutrientProtein.Tag = "PROT";
            this.chkRawNutrientProtein.Text = "단백질";
            this.chkRawNutrientProtein.UseVisualStyleBackColor = true;
            // 
            // dgvRawComponents
            // 
            this.dgvRawComponents.AllowUserToAddRows = false;
            this.dgvRawComponents.AllowUserToDeleteRows = false;
            this.dgvRawComponents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawComponents.Location = new System.Drawing.Point(0, 32);
            this.dgvRawComponents.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRawComponents.MultiSelect = false;
            this.dgvRawComponents.Name = "dgvRawComponents";
            this.dgvRawComponents.ReadOnly = true;
            this.dgvRawComponents.RowHeadersVisible = false;
            this.dgvRawComponents.RowHeadersWidth = 51;
            this.dgvRawComponents.RowTemplate.Height = 27;
            this.dgvRawComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawComponents.Size = new System.Drawing.Size(572, 0);
            this.dgvRawComponents.TabIndex = 17;
            // 
            // dgvRawMaterials
            // 
            this.dgvRawMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.dgvRawMaterials.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRawMaterials.Name = "dgvRawMaterials";
            this.dgvRawMaterials.RowHeadersWidth = 51;
            this.dgvRawMaterials.RowTemplate.Height = 27;
            this.dgvRawMaterials.Size = new System.Drawing.Size(590, 378);
            this.dgvRawMaterials.TabIndex = 0;
            // 
            // dgvRawNutrients
            // 
            this.dgvRawNutrients.AllowUserToAddRows = false;
            this.dgvRawNutrients.AllowUserToDeleteRows = false;
            this.dgvRawNutrients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRawNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawNutrients.Location = new System.Drawing.Point(0, 32);
            this.dgvRawNutrients.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvRawNutrients.MultiSelect = false;
            this.dgvRawNutrients.Name = "dgvRawNutrients";
            this.dgvRawNutrients.ReadOnly = true;
            this.dgvRawNutrients.RowHeadersVisible = false;
            this.dgvRawNutrients.RowHeadersWidth = 51;
            this.dgvRawNutrients.RowTemplate.Height = 27;
            this.dgvRawNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawNutrients.Size = new System.Drawing.Size(572, 0);
            this.dgvRawNutrients.TabIndex = 17;
            // 
            // flowRawButtons
            // 
            this.flowRawButtons.Controls.Add(this.btnRawAdd);
            this.flowRawButtons.Controls.Add(this.btnRawRefresh);
            this.flowRawButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRawButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRawButtons.Location = new System.Drawing.Point(4, 309);
            this.flowRawButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRawButtons.Name = "flowRawButtons";
            this.flowRawButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRawButtons.Size = new System.Drawing.Size(572, 67);
            this.flowRawButtons.TabIndex = 1;
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
            this.flowRawCalorieFilter.Location = new System.Drawing.Point(10, 74);
            this.flowRawCalorieFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRawCalorieFilter.Name = "flowRawCalorieFilter";
            this.flowRawCalorieFilter.Size = new System.Drawing.Size(436, 32);
            this.flowRawCalorieFilter.TabIndex = 7;
            // 
            // lblRawCalorie
            // 
            this.lblRawCalorie.AutoSize = true;
            this.lblRawCalorie.Location = new System.Drawing.Point(4, 0);
            this.lblRawCalorie.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRawCalorie.Name = "lblRawCalorie";
            this.lblRawCalorie.Size = new System.Drawing.Size(88, 18);
            this.lblRawCalorie.TabIndex = 0;
            this.lblRawCalorie.Text = "열량(kcal)";
            // 
            // nudRawCalorieMin
            // 
            this.nudRawCalorieMin.Location = new System.Drawing.Point(104, 2);
            this.nudRawCalorieMin.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudRawCalorieMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRawCalorieMin.Name = "nudRawCalorieMin";
            this.nudRawCalorieMin.Size = new System.Drawing.Size(88, 28);
            this.nudRawCalorieMin.TabIndex = 1;
            // 
            // lblRawCalorieSeparator
            // 
            this.lblRawCalorieSeparator.AutoSize = true;
            this.lblRawCalorieSeparator.Location = new System.Drawing.Point(200, 0);
            this.lblRawCalorieSeparator.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRawCalorieSeparator.Name = "lblRawCalorieSeparator";
            this.lblRawCalorieSeparator.Size = new System.Drawing.Size(22, 18);
            this.lblRawCalorieSeparator.TabIndex = 2;
            this.lblRawCalorieSeparator.Text = "~";
            // 
            // nudRawCalorieMax
            // 
            this.nudRawCalorieMax.Location = new System.Drawing.Point(234, 2);
            this.nudRawCalorieMax.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.nudRawCalorieMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRawCalorieMax.Name = "nudRawCalorieMax";
            this.nudRawCalorieMax.Size = new System.Drawing.Size(88, 28);
            this.nudRawCalorieMax.TabIndex = 3;
            // 
            // lblRawCalorieUnit
            // 
            this.lblRawCalorieUnit.AutoSize = true;
            this.lblRawCalorieUnit.Location = new System.Drawing.Point(330, 0);
            this.lblRawCalorieUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawCalorieUnit.Name = "lblRawCalorieUnit";
            this.lblRawCalorieUnit.Size = new System.Drawing.Size(102, 18);
            this.lblRawCalorieUnit.TabIndex = 4;
            this.lblRawCalorieUnit.Text = "기준(1인분)";
            // 
            // flowRawNutrientFilters
            // 
            this.flowRawNutrientFilters.AutoSize = true;
            this.flowRawNutrientFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRawNutrientFilters.Controls.Add(this.lblRawNutrientFilter);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientProtein);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientFat);
            this.flowRawNutrientFilters.Controls.Add(this.chkRawNutrientCarb);
            this.flowRawNutrientFilters.Location = new System.Drawing.Point(10, 42);
            this.flowRawNutrientFilters.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowRawNutrientFilters.Name = "flowRawNutrientFilters";
            this.flowRawNutrientFilters.Size = new System.Drawing.Size(362, 28);
            this.flowRawNutrientFilters.TabIndex = 5;
            this.flowRawNutrientFilters.WrapContents = false;
            // 
            // lblRawNutrientFilter
            // 
            this.lblRawNutrientFilter.AutoSize = true;
            this.lblRawNutrientFilter.Location = new System.Drawing.Point(4, 0);
            this.lblRawNutrientFilter.Margin = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.lblRawNutrientFilter.Name = "lblRawNutrientFilter";
            this.lblRawNutrientFilter.Size = new System.Drawing.Size(62, 18);
            this.lblRawNutrientFilter.TabIndex = 0;
            this.lblRawNutrientFilter.Text = "영양소";
            // 
            // grpRawDetail
            // 
            this.grpRawDetail.Controls.Add(this.splitContainerRawDetail);
            this.grpRawDetail.Controls.Add(this.tableRawDetail);
            this.grpRawDetail.Controls.Add(this.flowRawButtons);
            this.grpRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRawDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRawDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRawDetail.Name = "grpRawDetail";
            this.grpRawDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpRawDetail.Size = new System.Drawing.Size(580, 378);
            this.grpRawDetail.TabIndex = 0;
            this.grpRawDetail.TabStop = false;
            this.grpRawDetail.Text = "원재료 상세";
            // 
            // splitContainerRawDetail
            // 
            this.splitContainerRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawDetail.Location = new System.Drawing.Point(4, 328);
            this.splitContainerRawDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.splitContainerRawDetail.Size = new System.Drawing.Size(572, 0);
            this.splitContainerRawDetail.SplitterDistance = 25;
            this.splitContainerRawDetail.TabIndex = 17;
            // 
            // lblRawNutrients
            // 
            this.lblRawNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRawNutrients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawNutrients.Name = "lblRawNutrients";
            this.lblRawNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawNutrients.Size = new System.Drawing.Size(572, 32);
            this.lblRawNutrients.TabIndex = 0;
            this.lblRawNutrients.Text = "영양소 정보";
            // 
            // lblRawComponents
            // 
            this.lblRawComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRawComponents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawComponents.Name = "lblRawComponents";
            this.lblRawComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawComponents.Size = new System.Drawing.Size(572, 32);
            this.lblRawComponents.TabIndex = 0;
            this.lblRawComponents.Text = "조합 구성";
            // 
            // tableRawDetail
            // 
            this.tableRawDetail.ColumnCount = 2;
            this.tableRawDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableRawDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRawDetail.Controls.Add(this.lblRawDetailName, 0, 0);
            this.tableRawDetail.Controls.Add(this.txtRawDetailName, 1, 0);
            this.tableRawDetail.Controls.Add(this.lblRawDetailCategory, 0, 1);
            this.tableRawDetail.Controls.Add(this.txtRawDetailCategory, 1, 1);
            this.tableRawDetail.Controls.Add(this.lblRawDetailUnit, 0, 2);
            this.tableRawDetail.Controls.Add(this.txtRawDetailUnit, 1, 2);
            this.tableRawDetail.Controls.Add(this.lblRawDetailBaseQty, 0, 3);
            this.tableRawDetail.Controls.Add(this.txtRawDetailBaseQty, 1, 3);
            this.tableRawDetail.Controls.Add(this.lblRawDetailUnitGram, 0, 4);
            this.tableRawDetail.Controls.Add(this.txtRawDetailUnitGram, 1, 4);
            this.tableRawDetail.Controls.Add(this.lblRawDetailActive, 0, 5);
            this.tableRawDetail.Controls.Add(this.txtRawDetailActive, 1, 5);
            this.tableRawDetail.Controls.Add(this.lblRawDetailShelfLife, 0, 6);
            this.tableRawDetail.Controls.Add(this.txtRawDetailShelfLife, 1, 6);
            this.tableRawDetail.Controls.Add(this.lblRawDetailStorage, 0, 7);
            this.tableRawDetail.Controls.Add(this.txtRawDetailStorage, 1, 7);
            this.tableRawDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableRawDetail.Location = new System.Drawing.Point(4, 23);
            this.tableRawDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableRawDetail.Name = "tableRawDetail";
            this.tableRawDetail.RowCount = 8;
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableRawDetail.Size = new System.Drawing.Size(572, 305);
            this.tableRawDetail.TabIndex = 0;
            // 
            // lblRawDetailName
            // 
            this.lblRawDetailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailName.Location = new System.Drawing.Point(4, 0);
            this.lblRawDetailName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailName.Name = "lblRawDetailName";
            this.lblRawDetailName.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailName.TabIndex = 0;
            this.lblRawDetailName.Text = "명칭";
            this.lblRawDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailName
            // 
            this.txtRawDetailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailName.Location = new System.Drawing.Point(142, 2);
            this.txtRawDetailName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailName.Name = "txtRawDetailName";
            this.txtRawDetailName.ReadOnly = true;
            this.txtRawDetailName.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailName.TabIndex = 1;
            // 
            // lblRawDetailCategory
            // 
            this.lblRawDetailCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailCategory.Location = new System.Drawing.Point(4, 38);
            this.lblRawDetailCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailCategory.Name = "lblRawDetailCategory";
            this.lblRawDetailCategory.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailCategory.TabIndex = 3;
            this.lblRawDetailCategory.Text = "분류";
            this.lblRawDetailCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailCategory
            // 
            this.txtRawDetailCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailCategory.Location = new System.Drawing.Point(142, 40);
            this.txtRawDetailCategory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailCategory.Name = "txtRawDetailCategory";
            this.txtRawDetailCategory.ReadOnly = true;
            this.txtRawDetailCategory.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailCategory.TabIndex = 3;
            // 
            // lblRawDetailUnit
            // 
            this.lblRawDetailUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailUnit.Location = new System.Drawing.Point(4, 76);
            this.lblRawDetailUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailUnit.Name = "lblRawDetailUnit";
            this.lblRawDetailUnit.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailUnit.TabIndex = 4;
            this.lblRawDetailUnit.Text = "구매 단위";
            this.lblRawDetailUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailUnit
            // 
            this.txtRawDetailUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailUnit.Location = new System.Drawing.Point(142, 78);
            this.txtRawDetailUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailUnit.Name = "txtRawDetailUnit";
            this.txtRawDetailUnit.ReadOnly = true;
            this.txtRawDetailUnit.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailUnit.TabIndex = 5;
            // 
            // lblRawDetailBaseQty
            // 
            this.lblRawDetailBaseQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailBaseQty.Location = new System.Drawing.Point(4, 114);
            this.lblRawDetailBaseQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailBaseQty.Name = "lblRawDetailBaseQty";
            this.lblRawDetailBaseQty.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailBaseQty.TabIndex = 7;
            this.lblRawDetailBaseQty.Text = "기준량";
            this.lblRawDetailBaseQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailBaseQty
            // 
            this.txtRawDetailBaseQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailBaseQty.Location = new System.Drawing.Point(142, 116);
            this.txtRawDetailBaseQty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailBaseQty.Name = "txtRawDetailBaseQty";
            this.txtRawDetailBaseQty.ReadOnly = true;
            this.txtRawDetailBaseQty.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailBaseQty.TabIndex = 7;
            // 
            // lblRawDetailUnitGram
            // 
            this.lblRawDetailUnitGram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailUnitGram.Location = new System.Drawing.Point(4, 152);
            this.lblRawDetailUnitGram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailUnitGram.Name = "lblRawDetailUnitGram";
            this.lblRawDetailUnitGram.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailUnitGram.TabIndex = 9;
            this.lblRawDetailUnitGram.Text = "1단위(g)";
            this.lblRawDetailUnitGram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailUnitGram
            // 
            this.txtRawDetailUnitGram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailUnitGram.Location = new System.Drawing.Point(142, 154);
            this.txtRawDetailUnitGram.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailUnitGram.Name = "txtRawDetailUnitGram";
            this.txtRawDetailUnitGram.ReadOnly = true;
            this.txtRawDetailUnitGram.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailUnitGram.TabIndex = 9;
            // 
            // lblRawDetailActive
            // 
            this.lblRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailActive.Location = new System.Drawing.Point(4, 190);
            this.lblRawDetailActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailActive.Name = "lblRawDetailActive";
            this.lblRawDetailActive.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailActive.TabIndex = 10;
            this.lblRawDetailActive.Text = "사용 여부";
            this.lblRawDetailActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailActive
            // 
            this.txtRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailActive.Location = new System.Drawing.Point(142, 192);
            this.txtRawDetailActive.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailActive.Name = "txtRawDetailActive";
            this.txtRawDetailActive.ReadOnly = true;
            this.txtRawDetailActive.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailActive.TabIndex = 11;
            // 
            // lblRawDetailShelfLife
            // 
            this.lblRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailShelfLife.Location = new System.Drawing.Point(4, 228);
            this.lblRawDetailShelfLife.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailShelfLife.Name = "lblRawDetailShelfLife";
            this.lblRawDetailShelfLife.Size = new System.Drawing.Size(130, 38);
            this.lblRawDetailShelfLife.TabIndex = 11;
            this.lblRawDetailShelfLife.Text = "유통기한(일)";
            this.lblRawDetailShelfLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailShelfLife
            // 
            this.txtRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailShelfLife.Location = new System.Drawing.Point(142, 230);
            this.txtRawDetailShelfLife.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailShelfLife.Name = "txtRawDetailShelfLife";
            this.txtRawDetailShelfLife.ReadOnly = true;
            this.txtRawDetailShelfLife.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailShelfLife.TabIndex = 13;
            // 
            // lblRawDetailStorage
            // 
            this.lblRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailStorage.Location = new System.Drawing.Point(4, 266);
            this.lblRawDetailStorage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawDetailStorage.Name = "lblRawDetailStorage";
            this.lblRawDetailStorage.Size = new System.Drawing.Size(130, 39);
            this.lblRawDetailStorage.TabIndex = 12;
            this.lblRawDetailStorage.Text = "보관 방식";
            this.lblRawDetailStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailStorage
            // 
            this.txtRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailStorage.Location = new System.Drawing.Point(142, 268);
            this.txtRawDetailStorage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawDetailStorage.Name = "txtRawDetailStorage";
            this.txtRawDetailStorage.ReadOnly = true;
            this.txtRawDetailStorage.Size = new System.Drawing.Size(426, 28);
            this.txtRawDetailStorage.TabIndex = 15;
            // 
            // lblRawSearch
            // 
            this.lblRawSearch.AutoSize = true;
            this.lblRawSearch.Location = new System.Drawing.Point(10, 14);
            this.lblRawSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRawSearch.Name = "lblRawSearch";
            this.lblRawSearch.Size = new System.Drawing.Size(100, 18);
            this.lblRawSearch.TabIndex = 0;
            this.lblRawSearch.Text = "명칭 / 분류";
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
            this.panelRawToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelRawToolbar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelRawToolbar.Name = "panelRawToolbar";
            this.panelRawToolbar.Size = new System.Drawing.Size(1175, 102);
            this.panelRawToolbar.TabIndex = 0;
            // 
            // txtRawSearch
            // 
            this.txtRawSearch.Location = new System.Drawing.Point(132, 11);
            this.txtRawSearch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtRawSearch.Name = "txtRawSearch";
            this.txtRawSearch.Size = new System.Drawing.Size(415, 28);
            this.txtRawSearch.TabIndex = 1;
            // 
            // splitContainerRawMaterials
            // 
            this.splitContainerRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawMaterials.Location = new System.Drawing.Point(0, 102);
            this.splitContainerRawMaterials.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerRawMaterials.Name = "splitContainerRawMaterials";
            // 
            // splitContainerRawMaterials.Panel1
            // 
            this.splitContainerRawMaterials.Panel1.Controls.Add(this.dgvRawMaterials);
            this.splitContainerRawMaterials.Panel1.Controls.Add(this.tvRawMaterials);
            // 
            // splitContainerRawMaterials.Panel2
            // 
            this.splitContainerRawMaterials.Panel2.Controls.Add(this.grpRawDetail);
            this.splitContainerRawMaterials.Size = new System.Drawing.Size(1175, 378);
            this.splitContainerRawMaterials.SplitterDistance = 590;
            this.splitContainerRawMaterials.SplitterWidth = 5;
            this.splitContainerRawMaterials.TabIndex = 1;
            // 
            // tvRawMaterials
            // 
            this.tvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.tvRawMaterials.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tvRawMaterials.Name = "tvRawMaterials";
            this.tvRawMaterials.Size = new System.Drawing.Size(590, 378);
            this.tvRawMaterials.TabIndex = 1;
            // 
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 480);
            this.Controls.Add(this.splitContainerRawMaterials);
            this.Controls.Add(this.panelRawToolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "RawMaterialsForm";
            this.Text = "RawMaterialsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).EndInit();
            this.flowRawButtons.ResumeLayout(false);
            this.flowRawCalorieFilter.ResumeLayout(false);
            this.flowRawCalorieFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).EndInit();
            this.flowRawNutrientFilters.ResumeLayout(false);
            this.flowRawNutrientFilters.PerformLayout();
            this.grpRawDetail.ResumeLayout(false);
            this.splitContainerRawDetail.Panel1.ResumeLayout(false);
            this.splitContainerRawDetail.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).EndInit();
            this.splitContainerRawDetail.ResumeLayout(false);
            this.tableRawDetail.ResumeLayout(false);
            this.tableRawDetail.PerformLayout();
            this.panelRawToolbar.ResumeLayout(false);
            this.panelRawToolbar.PerformLayout();
            this.splitContainerRawMaterials.Panel1.ResumeLayout(false);
            this.splitContainerRawMaterials.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).EndInit();
            this.splitContainerRawMaterials.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnRawAdd;
        private System.Windows.Forms.Button btnRawClear;
        private System.Windows.Forms.Button btnRawRefresh;
        private System.Windows.Forms.Button btnRawSearch;
        private System.Windows.Forms.CheckBox chkRawGroup;
        private System.Windows.Forms.CheckBox chkRawNutrientCarb;
        private System.Windows.Forms.CheckBox chkRawNutrientFat;
        private System.Windows.Forms.CheckBox chkRawNutrientProtein;
        private System.Windows.Forms.DataGridView dgvRawComponents;
        private System.Windows.Forms.DataGridView dgvRawMaterials;
        private System.Windows.Forms.DataGridView dgvRawNutrients;
        private System.Windows.Forms.FlowLayoutPanel flowRawButtons;
        private System.Windows.Forms.FlowLayoutPanel flowRawCalorieFilter;
        private System.Windows.Forms.FlowLayoutPanel flowRawNutrientFilters;
        private System.Windows.Forms.GroupBox grpRawDetail;
        private System.Windows.Forms.Label lblRawCalorie;
        private System.Windows.Forms.Label lblRawCalorieSeparator;
        private System.Windows.Forms.Label lblRawCalorieUnit;
        private System.Windows.Forms.Label lblRawComponents;
        private System.Windows.Forms.Label lblRawDetailActive;
        private System.Windows.Forms.Label lblRawDetailBaseQty;
        private System.Windows.Forms.Label lblRawDetailCategory;
        private System.Windows.Forms.Label lblRawDetailName;
        private System.Windows.Forms.Label lblRawDetailShelfLife;
        private System.Windows.Forms.Label lblRawDetailStorage;
        private System.Windows.Forms.Label lblRawDetailUnit;
        private System.Windows.Forms.Label lblRawDetailUnitGram;
        private System.Windows.Forms.Label lblRawNutrientFilter;
        private System.Windows.Forms.Label lblRawNutrients;
        private System.Windows.Forms.Label lblRawSearch;
        private System.Windows.Forms.NumericUpDown nudRawCalorieMax;
        private System.Windows.Forms.NumericUpDown nudRawCalorieMin;
        private System.Windows.Forms.Panel panelRawToolbar;
        private System.Windows.Forms.SplitContainer splitContainerRawDetail;
        private System.Windows.Forms.SplitContainer splitContainerRawMaterials;
        private System.Windows.Forms.TableLayoutPanel tableRawDetail;
        private System.Windows.Forms.TreeView tvRawMaterials;
        private System.Windows.Forms.TextBox txtRawDetailActive;
        private System.Windows.Forms.TextBox txtRawDetailBaseQty;
        private System.Windows.Forms.TextBox txtRawDetailCategory;
        private System.Windows.Forms.TextBox txtRawDetailName;
        private System.Windows.Forms.TextBox txtRawDetailShelfLife;
        private System.Windows.Forms.TextBox txtRawDetailStorage;
        private System.Windows.Forms.TextBox txtRawDetailUnit;
        private System.Windows.Forms.TextBox txtRawDetailUnitGram;
        private System.Windows.Forms.TextBox txtRawSearch;
    }
}
