namespace nutritionist.Tabs.Management
{
    partial class RawMaterialsTabPage
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
            this.flowRawNutrientFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.grpRawDetail = new System.Windows.Forms.GroupBox();
            this.lblRawCalorie = new System.Windows.Forms.Label();
            this.lblRawCalorieSeparator = new System.Windows.Forms.Label();
            this.lblRawCalorieUnit = new System.Windows.Forms.Label();
            this.lblRawComponents = new System.Windows.Forms.Label();
            this.lblRawDetailActive = new System.Windows.Forms.Label();
            this.lblRawDetailBaseQty = new System.Windows.Forms.Label();
            this.lblRawDetailCategory = new System.Windows.Forms.Label();
            this.lblRawDetailName = new System.Windows.Forms.Label();
            this.lblRawDetailShelfLife = new System.Windows.Forms.Label();
            this.lblRawDetailStorage = new System.Windows.Forms.Label();
            this.lblRawDetailUnit = new System.Windows.Forms.Label();
            this.lblRawDetailUnitGram = new System.Windows.Forms.Label();
            this.lblRawNutrientFilter = new System.Windows.Forms.Label();
            this.lblRawNutrients = new System.Windows.Forms.Label();
            this.lblRawSearch = new System.Windows.Forms.Label();
            this.nudRawCalorieMax = new System.Windows.Forms.NumericUpDown();
            this.nudRawCalorieMin = new System.Windows.Forms.NumericUpDown();
            this.panelRawToolbar = new System.Windows.Forms.Panel();
            this.splitContainerRawDetail = new System.Windows.Forms.SplitContainer();
            this.splitContainerRawMaterials = new System.Windows.Forms.SplitContainer();
            this.tableRawDetail = new System.Windows.Forms.TableLayoutPanel();
            this.tvRawMaterials = new System.Windows.Forms.TreeView();
            this.txtRawDetailActive = new System.Windows.Forms.TextBox();
            this.txtRawDetailBaseQty = new System.Windows.Forms.TextBox();
            this.txtRawDetailCategory = new System.Windows.Forms.TextBox();
            this.txtRawDetailName = new System.Windows.Forms.TextBox();
            this.txtRawDetailShelfLife = new System.Windows.Forms.TextBox();
            this.txtRawDetailStorage = new System.Windows.Forms.TextBox();
            this.txtRawDetailUnit = new System.Windows.Forms.TextBox();
            this.txtRawDetailUnitGram = new System.Windows.Forms.TextBox();
            this.txtRawSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).BeginInit();
            this.SuspendLayout();
            // RawMaterialsTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerRawMaterials);
            this.Controls.Add(this.panelRawToolbar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RawMaterialsTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
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
            this.tableRawDetail.Controls.Add(this.lblRawDetailUnitGram, 0, 4);
            this.tableRawDetail.Controls.Add(this.txtRawDetailUnitGram, 1, 4);
            this.tableRawDetail.Controls.Add(this.lblRawDetailStorage, 0, 5);
            this.tableRawDetail.Controls.Add(this.txtRawDetailStorage, 1, 5);
            this.tableRawDetail.Controls.Add(this.lblRawDetailShelfLife, 0, 6);
            this.tableRawDetail.Controls.Add(this.txtRawDetailShelfLife, 1, 6);
            this.tableRawDetail.Controls.Add(this.lblRawDetailActive, 0, 7);
            this.tableRawDetail.Controls.Add(this.txtRawDetailActive, 1, 7);
            this.tableRawDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableRawDetail.Location = new System.Drawing.Point(3, 20);
            this.tableRawDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableRawDetail.Name = "tableRawDetail";
            this.tableRawDetail.RowCount = 8;
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.Size = new System.Drawing.Size(452, 288);
            this.tableRawDetail.TabIndex = 0;
            // 
            // splitContainerRawDetail
            // 
            this.splitContainerRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawDetail.Location = new System.Drawing.Point(3, 308);
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
            // lblRawDetailUnitGram
            // 
            this.lblRawDetailUnitGram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailUnitGram.Location = new System.Drawing.Point(3, 144);
            this.lblRawDetailUnitGram.Name = "lblRawDetailUnitGram";
            this.lblRawDetailUnitGram.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailUnitGram.TabIndex = 8;
            this.lblRawDetailUnitGram.Text = "1단위(g)";
            this.lblRawDetailUnitGram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtRawDetailUnitGram
            // 
            this.txtRawDetailUnitGram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailUnitGram.Location = new System.Drawing.Point(123, 146);
            this.txtRawDetailUnitGram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailUnitGram.Name = "txtRawDetailUnitGram";
            this.txtRawDetailUnitGram.ReadOnly = true;
            this.txtRawDetailUnitGram.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailUnitGram.TabIndex = 9;
            // 
            // lblRawDetailStorage
            // 
            this.lblRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailStorage.Location = new System.Drawing.Point(3, 180);
            this.lblRawDetailStorage.Name = "lblRawDetailStorage";
            this.lblRawDetailStorage.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailStorage.TabIndex = 10;
            this.lblRawDetailStorage.Text = "보관 방식";
            this.lblRawDetailStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailStorage
            // 
            this.txtRawDetailStorage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailStorage.Location = new System.Drawing.Point(123, 182);
            this.txtRawDetailStorage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailStorage.Name = "txtRawDetailStorage";
            this.txtRawDetailStorage.ReadOnly = true;
            this.txtRawDetailStorage.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailStorage.TabIndex = 11;
            // 
            // lblRawDetailShelfLife
            // 
            this.lblRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailShelfLife.Location = new System.Drawing.Point(3, 216);
            this.lblRawDetailShelfLife.Name = "lblRawDetailShelfLife";
            this.lblRawDetailShelfLife.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailShelfLife.TabIndex = 12;
            this.lblRawDetailShelfLife.Text = "유통기한(일)";
            this.lblRawDetailShelfLife.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailShelfLife
            // 
            this.txtRawDetailShelfLife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailShelfLife.Location = new System.Drawing.Point(123, 218);
            this.txtRawDetailShelfLife.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailShelfLife.Name = "txtRawDetailShelfLife";
            this.txtRawDetailShelfLife.ReadOnly = true;
            this.txtRawDetailShelfLife.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailShelfLife.TabIndex = 13;
            // 
            // lblRawDetailActive
            // 
            this.lblRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawDetailActive.Location = new System.Drawing.Point(3, 252);
            this.lblRawDetailActive.Name = "lblRawDetailActive";
            this.lblRawDetailActive.Size = new System.Drawing.Size(114, 36);
            this.lblRawDetailActive.TabIndex = 14;
            this.lblRawDetailActive.Text = "사용 여부";
            this.lblRawDetailActive.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawDetailActive
            // 
            this.txtRawDetailActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawDetailActive.Location = new System.Drawing.Point(123, 254);
            this.txtRawDetailActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawDetailActive.Name = "txtRawDetailActive";
            this.txtRawDetailActive.ReadOnly = true;
            this.txtRawDetailActive.Size = new System.Drawing.Size(326, 25);
            this.txtRawDetailActive.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRawCalorieMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal System.Windows.Forms.Button btnRawAdd;
        internal System.Windows.Forms.Button btnRawClear;
        internal System.Windows.Forms.Button btnRawRefresh;
        internal System.Windows.Forms.Button btnRawSearch;
        internal System.Windows.Forms.CheckBox chkRawGroup;
        internal System.Windows.Forms.CheckBox chkRawNutrientCarb;
        internal System.Windows.Forms.CheckBox chkRawNutrientFat;
        internal System.Windows.Forms.CheckBox chkRawNutrientProtein;
        internal System.Windows.Forms.DataGridView dgvRawComponents;
        internal System.Windows.Forms.DataGridView dgvRawMaterials;
        internal System.Windows.Forms.DataGridView dgvRawNutrients;
        internal System.Windows.Forms.FlowLayoutPanel flowRawButtons;
        internal System.Windows.Forms.FlowLayoutPanel flowRawCalorieFilter;
        internal System.Windows.Forms.FlowLayoutPanel flowRawNutrientFilters;
        internal System.Windows.Forms.GroupBox grpRawDetail;
        internal System.Windows.Forms.Label lblRawCalorie;
        internal System.Windows.Forms.Label lblRawCalorieSeparator;
        internal System.Windows.Forms.Label lblRawCalorieUnit;
        internal System.Windows.Forms.Label lblRawComponents;
        internal System.Windows.Forms.Label lblRawDetailActive;
        internal System.Windows.Forms.Label lblRawDetailBaseQty;
        internal System.Windows.Forms.Label lblRawDetailCategory;
        internal System.Windows.Forms.Label lblRawDetailName;
        internal System.Windows.Forms.Label lblRawDetailShelfLife;
        internal System.Windows.Forms.Label lblRawDetailStorage;
        internal System.Windows.Forms.Label lblRawDetailUnit;
        internal System.Windows.Forms.Label lblRawDetailUnitGram;
        internal System.Windows.Forms.Label lblRawNutrientFilter;
        internal System.Windows.Forms.Label lblRawNutrients;
        internal System.Windows.Forms.Label lblRawSearch;
        internal System.Windows.Forms.NumericUpDown nudRawCalorieMax;
        internal System.Windows.Forms.NumericUpDown nudRawCalorieMin;
        internal System.Windows.Forms.Panel panelRawToolbar;
        internal System.Windows.Forms.SplitContainer splitContainerRawDetail;
        internal System.Windows.Forms.SplitContainer splitContainerRawMaterials;
        internal System.Windows.Forms.TableLayoutPanel tableRawDetail;
        internal System.Windows.Forms.TreeView tvRawMaterials;
        internal System.Windows.Forms.TextBox txtRawDetailActive;
        internal System.Windows.Forms.TextBox txtRawDetailBaseQty;
        internal System.Windows.Forms.TextBox txtRawDetailCategory;
        internal System.Windows.Forms.TextBox txtRawDetailName;
        internal System.Windows.Forms.TextBox txtRawDetailShelfLife;
        internal System.Windows.Forms.TextBox txtRawDetailStorage;
        internal System.Windows.Forms.TextBox txtRawDetailUnit;
        internal System.Windows.Forms.TextBox txtRawDetailUnitGram;
        internal System.Windows.Forms.TextBox txtRawSearch;
    }
}
