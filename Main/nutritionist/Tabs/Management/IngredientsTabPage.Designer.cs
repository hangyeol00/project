namespace nutritionist.Tabs.Management
{
    partial class IngredientsTabPage
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
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.flowIngredientButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grpIngredientDetail = new System.Windows.Forms.GroupBox();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.lblIngredientNutrient = new System.Windows.Forms.Label();
            this.lblIngredientUnit = new System.Windows.Forms.Label();
            this.splitContainerIngredients = new System.Windows.Forms.SplitContainer();
            this.tableIngredientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.txtIngredientNutrient = new System.Windows.Forms.TextBox();
            this.txtIngredientUnit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).BeginInit();
            this.SuspendLayout();
            // IngredientsTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerIngredients);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IngredientsTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal System.Windows.Forms.Button btnAddIngredient;
        internal System.Windows.Forms.Button btnUpdateIngredient;
        internal System.Windows.Forms.DataGridView dgvIngredients;
        internal System.Windows.Forms.FlowLayoutPanel flowIngredientButtons;
        internal System.Windows.Forms.GroupBox grpIngredientDetail;
        internal System.Windows.Forms.Label lblIngredientName;
        internal System.Windows.Forms.Label lblIngredientNutrient;
        internal System.Windows.Forms.Label lblIngredientUnit;
        internal System.Windows.Forms.SplitContainer splitContainerIngredients;
        internal System.Windows.Forms.TableLayoutPanel tableIngredientDetail;
        internal System.Windows.Forms.TextBox txtIngredientName;
        internal System.Windows.Forms.TextBox txtIngredientNutrient;
        internal System.Windows.Forms.TextBox txtIngredientUnit;
    }
}
