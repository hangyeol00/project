namespace nutritionist
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

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.splitContainerRawMaterials = new System.Windows.Forms.SplitContainer();
            this.dgvRawMaterials = new System.Windows.Forms.DataGridView();
            this.grpRawDetail = new System.Windows.Forms.GroupBox();
            this.splitContainerRawDetail = new System.Windows.Forms.SplitContainer();
            this.dgvRawNutrients = new System.Windows.Forms.DataGridView();
            this.lblRawNutrients = new System.Windows.Forms.Label();
            this.dgvRawComponents = new System.Windows.Forms.DataGridView();
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
            this.lblRawDetailStorage = new System.Windows.Forms.Label();
            this.txtRawDetailStorage = new System.Windows.Forms.TextBox();
            this.lblRawDetailShelfLife = new System.Windows.Forms.Label();
            this.txtRawDetailShelfLife = new System.Windows.Forms.TextBox();
            this.lblRawDetailActive = new System.Windows.Forms.Label();
            this.txtRawDetailActive = new System.Windows.Forms.TextBox();
            this.flowRawButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRawAdd = new System.Windows.Forms.Button();
            this.btnRawRefresh = new System.Windows.Forms.Button();
            this.panelRawToolbar = new System.Windows.Forms.Panel();
            this.txtRawSearch = new System.Windows.Forms.TextBox();
            this.lblRawSearch = new System.Windows.Forms.Label();
            this.btnRawSearch = new System.Windows.Forms.Button();
            this.btnRawClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).BeginInit();
            this.splitContainerRawMaterials.Panel1.SuspendLayout();
            this.splitContainerRawMaterials.Panel2.SuspendLayout();
            this.splitContainerRawMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).BeginInit();
            this.grpRawDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).BeginInit();
            this.splitContainerRawDetail.Panel1.SuspendLayout();
            this.splitContainerRawDetail.Panel2.SuspendLayout();
            this.splitContainerRawDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).BeginInit();
            this.tableRawDetail.SuspendLayout();
            this.flowRawButtons.SuspendLayout();
            this.panelRawToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRawMaterials
            // 
            this.splitContainerRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawMaterials.Location = new System.Drawing.Point(0, 50);
            this.splitContainerRawMaterials.Name = "splitContainerRawMaterials";
            // 
            // splitContainerRawMaterials.Panel1
            // 
            this.splitContainerRawMaterials.Panel1.Controls.Add(this.dgvRawMaterials);
            // 
            // splitContainerRawMaterials.Panel2
            // 
            this.splitContainerRawMaterials.Panel2.Controls.Add(this.grpRawDetail);
            this.splitContainerRawMaterials.Size = new System.Drawing.Size(954, 437);
            this.splitContainerRawMaterials.SplitterDistance = 472;
            this.splitContainerRawMaterials.TabIndex = 0;
            // 
            // dgvRawMaterials
            // 
            this.dgvRawMaterials.BackgroundColor = System.Drawing.Color.White;
            this.dgvRawMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.dgvRawMaterials.Name = "dgvRawMaterials";
            this.dgvRawMaterials.RowHeadersWidth = 51;
            this.dgvRawMaterials.RowTemplate.Height = 27;
            this.dgvRawMaterials.Size = new System.Drawing.Size(472, 437);
            this.dgvRawMaterials.TabIndex = 0;
            // 
            // grpRawDetail
            // 
            this.grpRawDetail.Controls.Add(this.splitContainerRawDetail);
            this.grpRawDetail.Controls.Add(this.tableRawDetail);
            this.grpRawDetail.Controls.Add(this.flowRawButtons);
            this.grpRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRawDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRawDetail.Name = "grpRawDetail";
            this.grpRawDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRawDetail.Size = new System.Drawing.Size(478, 437);
            this.grpRawDetail.TabIndex = 0;
            this.grpRawDetail.TabStop = false;
            this.grpRawDetail.Text = "상세 정보";
            // 
            // splitContainerRawDetail
            // 
            this.splitContainerRawDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRawDetail.Location = new System.Drawing.Point(3, 272);
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
            this.splitContainerRawDetail.Size = new System.Drawing.Size(472, 95);
            this.splitContainerRawDetail.SplitterDistance = 47;
            this.splitContainerRawDetail.TabIndex = 18;
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
            this.dgvRawNutrients.MultiSelect = false;
            this.dgvRawNutrients.Name = "dgvRawNutrients";
            this.dgvRawNutrients.ReadOnly = true;
            this.dgvRawNutrients.RowHeadersVisible = false;
            this.dgvRawNutrients.RowTemplate.Height = 27;
            this.dgvRawNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawNutrients.Size = new System.Drawing.Size(472, 17);
            this.dgvRawNutrients.TabIndex = 15;
            // 
            // lblRawNutrients
            // 
            this.lblRawNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRawNutrients.Name = "lblRawNutrients";
            this.lblRawNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawNutrients.Size = new System.Drawing.Size(472, 30);
            this.lblRawNutrients.TabIndex = 14;
            this.lblRawNutrients.Text = "영양소 정보";
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
            this.dgvRawComponents.MultiSelect = false;
            this.dgvRawComponents.Name = "dgvRawComponents";
            this.dgvRawComponents.ReadOnly = true;
            this.dgvRawComponents.RowHeadersVisible = false;
            this.dgvRawComponents.RowTemplate.Height = 27;
            this.dgvRawComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawComponents.Size = new System.Drawing.Size(472, 44);
            this.dgvRawComponents.TabIndex = 17;
            // 
            // lblRawComponents
            // 
            this.lblRawComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRawComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRawComponents.Name = "lblRawComponents";
            this.lblRawComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRawComponents.Size = new System.Drawing.Size(472, 30);
            this.lblRawComponents.TabIndex = 16;
            this.lblRawComponents.Text = "포함 원재료";
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
            this.tableRawDetail.Name = "tableRawDetail";
            this.tableRawDetail.RowCount = 7;
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRawDetail.Size = new System.Drawing.Size(472, 252);
            this.tableRawDetail.TabIndex = 0;
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
            this.txtRawDetailName.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailCategory.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailUnit.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailBaseQty.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailStorage.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailShelfLife.Size = new System.Drawing.Size(346, 25);
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
            this.txtRawDetailActive.Size = new System.Drawing.Size(346, 25);
            this.txtRawDetailActive.TabIndex = 13;
            // 
            // flowRawButtons
            // 
            this.flowRawButtons.Controls.Add(this.btnRawAdd);
            this.flowRawButtons.Controls.Add(this.btnRawRefresh);
            this.flowRawButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRawButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRawButtons.Location = new System.Drawing.Point(3, 367);
            this.flowRawButtons.Name = "flowRawButtons";
            this.flowRawButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRawButtons.Size = new System.Drawing.Size(472, 68);
            this.flowRawButtons.TabIndex = 1;
            // 
            // btnRawAdd
            // 
            this.btnRawAdd.Location = new System.Drawing.Point(365, 6);
            this.btnRawAdd.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRawAdd.Name = "btnRawAdd";
            this.btnRawAdd.Size = new System.Drawing.Size(107, 28);
            this.btnRawAdd.TabIndex = 0;
            this.btnRawAdd.Text = "원재료 등록";
            this.btnRawAdd.UseVisualStyleBackColor = true;
            // 
            // btnRawRefresh
            // 
            this.btnRawRefresh.Location = new System.Drawing.Point(269, 6);
            this.btnRawRefresh.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRawRefresh.Name = "btnRawRefresh";
            this.btnRawRefresh.Size = new System.Drawing.Size(87, 28);
            this.btnRawRefresh.TabIndex = 1;
            this.btnRawRefresh.Text = "새로 고침";
            this.btnRawRefresh.UseVisualStyleBackColor = true;
            // 
            // panelRawToolbar
            // 
            this.panelRawToolbar.Controls.Add(this.btnRawClear);
            this.panelRawToolbar.Controls.Add(this.btnRawSearch);
            this.panelRawToolbar.Controls.Add(this.txtRawSearch);
            this.panelRawToolbar.Controls.Add(this.lblRawSearch);
            this.panelRawToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRawToolbar.Location = new System.Drawing.Point(0, 0);
            this.panelRawToolbar.Name = "panelRawToolbar";
            this.panelRawToolbar.Size = new System.Drawing.Size(954, 50);
            this.panelRawToolbar.TabIndex = 1;
            // 
            // txtRawSearch
            // 
            this.txtRawSearch.Location = new System.Drawing.Point(88, 10);
            this.txtRawSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRawSearch.Name = "txtRawSearch";
            this.txtRawSearch.Size = new System.Drawing.Size(220, 25);
            this.txtRawSearch.TabIndex = 1;
            // 
            // lblRawSearch
            // 
            this.lblRawSearch.AutoSize = true;
            this.lblRawSearch.Location = new System.Drawing.Point(8, 13);
            this.lblRawSearch.Name = "lblRawSearch";
            this.lblRawSearch.Size = new System.Drawing.Size(65, 19);
            this.lblRawSearch.TabIndex = 0;
            this.lblRawSearch.Text = "원재료명:";
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
            // RawMaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerRawMaterials);
            this.Controls.Add(this.panelRawToolbar);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RawMaterialsForm";
            this.Text = "RawMaterialsForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawMaterials)).EndInit();
            this.splitContainerRawMaterials.Panel1.ResumeLayout(false);
            this.splitContainerRawMaterials.Panel2.ResumeLayout(false);
            this.splitContainerRawMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterials)).EndInit();
            this.grpRawDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRawDetail)).EndInit();
            this.splitContainerRawDetail.Panel1.ResumeLayout(false);
            this.splitContainerRawDetail.Panel2.ResumeLayout(false);
            this.splitContainerRawDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawComponents)).EndInit();
            this.tableRawDetail.ResumeLayout(false);
            this.tableRawDetail.PerformLayout();
            this.flowRawButtons.ResumeLayout(false);
            this.panelRawToolbar.ResumeLayout(false);
            this.panelRawToolbar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRawMaterials;
        private System.Windows.Forms.DataGridView dgvRawMaterials;
        private System.Windows.Forms.GroupBox grpRawDetail;
        private System.Windows.Forms.SplitContainer splitContainerRawDetail;
        private System.Windows.Forms.DataGridView dgvRawNutrients;
        private System.Windows.Forms.Label lblRawNutrients;
        private System.Windows.Forms.DataGridView dgvRawComponents;
        private System.Windows.Forms.Label lblRawComponents;
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
        private System.Windows.Forms.FlowLayoutPanel flowRawButtons;
        private System.Windows.Forms.Button btnRawAdd;
        private System.Windows.Forms.Button btnRawRefresh;
        private System.Windows.Forms.Panel panelRawToolbar;
        private System.Windows.Forms.TextBox txtRawSearch;
        private System.Windows.Forms.Label lblRawSearch;
        private System.Windows.Forms.Button btnRawSearch;
        private System.Windows.Forms.Button btnRawClear;
    }
}

