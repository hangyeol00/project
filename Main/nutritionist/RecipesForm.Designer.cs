namespace nutritionist
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

        #region Windows Form 디자이너에서 생성한 코드

        private void InitializeComponent()
        {
            this.splitContainerRecipes = new System.Windows.Forms.SplitContainer();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.grpRecipeDetail = new System.Windows.Forms.GroupBox();
            this.splitContainerRecipeDetail = new System.Windows.Forms.SplitContainer();
            this.dgvRecipeNutrients = new System.Windows.Forms.DataGridView();
            this.lblRecipeNutrients = new System.Windows.Forms.Label();
            this.dgvRecipeComponents = new System.Windows.Forms.DataGridView();
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
            this.flowRecipeButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).BeginInit();
            this.splitContainerRecipes.Panel1.SuspendLayout();
            this.splitContainerRecipes.Panel2.SuspendLayout();
            this.splitContainerRecipes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.grpRecipeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).BeginInit();
            this.splitContainerRecipeDetail.Panel1.SuspendLayout();
            this.splitContainerRecipeDetail.Panel2.SuspendLayout();
            this.splitContainerRecipeDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).BeginInit();
            this.tableRecipeDetail.SuspendLayout();
            this.flowRecipeButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerRecipes
            // 
            this.splitContainerRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipes.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRecipes.Name = "splitContainerRecipes";
            // 
            // splitContainerRecipes.Panel1
            // 
            this.splitContainerRecipes.Panel1.Controls.Add(this.dgvRecipes);
            // 
            // splitContainerRecipes.Panel2
            // 
            this.splitContainerRecipes.Panel2.Controls.Add(this.grpRecipeDetail);
            this.splitContainerRecipes.Size = new System.Drawing.Size(954, 487);
            this.splitContainerRecipes.SplitterDistance = 472;
            this.splitContainerRecipes.TabIndex = 0;
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipes.Location = new System.Drawing.Point(0, 0);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.RowTemplate.Height = 27;
            this.dgvRecipes.Size = new System.Drawing.Size(472, 487);
            this.dgvRecipes.TabIndex = 0;
            // 
            // grpRecipeDetail
            // 
            this.grpRecipeDetail.Controls.Add(this.splitContainerRecipeDetail);
            this.grpRecipeDetail.Controls.Add(this.tableRecipeDetail);
            this.grpRecipeDetail.Controls.Add(this.flowRecipeButtons);
            this.grpRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecipeDetail.Location = new System.Drawing.Point(0, 0);
            this.grpRecipeDetail.Name = "grpRecipeDetail";
            this.grpRecipeDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpRecipeDetail.Size = new System.Drawing.Size(478, 487);
            this.grpRecipeDetail.TabIndex = 0;
            this.grpRecipeDetail.TabStop = false;
            this.grpRecipeDetail.Text = "상세 정보";
            // 
            // splitContainerRecipeDetail
            // 
            this.splitContainerRecipeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRecipeDetail.Location = new System.Drawing.Point(3, 200);
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
            this.splitContainerRecipeDetail.Size = new System.Drawing.Size(472, 251);
            this.splitContainerRecipeDetail.SplitterDistance = 125;
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
            this.dgvRecipeNutrients.MultiSelect = false;
            this.dgvRecipeNutrients.Name = "dgvRecipeNutrients";
            this.dgvRecipeNutrients.ReadOnly = true;
            this.dgvRecipeNutrients.RowHeadersVisible = false;
            this.dgvRecipeNutrients.RowTemplate.Height = 27;
            this.dgvRecipeNutrients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeNutrients.Size = new System.Drawing.Size(472, 95);
            this.dgvRecipeNutrients.TabIndex = 1;
            // 
            // lblRecipeNutrients
            // 
            this.lblRecipeNutrients.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeNutrients.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeNutrients.Name = "lblRecipeNutrients";
            this.lblRecipeNutrients.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeNutrients.Size = new System.Drawing.Size(472, 30);
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
            this.dgvRecipeComponents.MultiSelect = false;
            this.dgvRecipeComponents.Name = "dgvRecipeComponents";
            this.dgvRecipeComponents.ReadOnly = true;
            this.dgvRecipeComponents.RowHeadersVisible = false;
            this.dgvRecipeComponents.RowTemplate.Height = 27;
            this.dgvRecipeComponents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeComponents.Size = new System.Drawing.Size(472, 122);
            this.dgvRecipeComponents.TabIndex = 1;
            // 
            // lblRecipeComponents
            // 
            this.lblRecipeComponents.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeComponents.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeComponents.Name = "lblRecipeComponents";
            this.lblRecipeComponents.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblRecipeComponents.Size = new System.Drawing.Size(472, 30);
            this.lblRecipeComponents.TabIndex = 0;
            this.lblRecipeComponents.Text = "포함 원재료";
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
            this.tableRecipeDetail.Name = "tableRecipeDetail";
            this.tableRecipeDetail.RowCount = 5;
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableRecipeDetail.Size = new System.Drawing.Size(472, 180);
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
            this.txtRecipeName.Size = new System.Drawing.Size(356, 25);
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
            this.txtRecipeCode.Size = new System.Drawing.Size(356, 25);
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
            this.txtRecipeType.Size = new System.Drawing.Size(356, 25);
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
            this.txtRecipeServing.Size = new System.Drawing.Size(356, 25);
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
            this.txtRecipeActive.Size = new System.Drawing.Size(356, 25);
            this.txtRecipeActive.TabIndex = 9;
            // 
            // flowRecipeButtons
            // 
            this.flowRecipeButtons.Controls.Add(this.btnRefreshRecipe);
            this.flowRecipeButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowRecipeButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRecipeButtons.Location = new System.Drawing.Point(3, 451);
            this.flowRecipeButtons.Name = "flowRecipeButtons";
            this.flowRecipeButtons.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowRecipeButtons.Size = new System.Drawing.Size(472, 34);
            this.flowRecipeButtons.TabIndex = 2;
            // 
            // btnRefreshRecipe
            // 
            this.btnRefreshRecipe.Location = new System.Drawing.Point(365, 6);
            this.btnRefreshRecipe.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRefreshRecipe.Name = "btnRefreshRecipe";
            this.btnRefreshRecipe.Size = new System.Drawing.Size(107, 28);
            this.btnRefreshRecipe.TabIndex = 0;
            this.btnRefreshRecipe.Text = "새로고침";
            this.btnRefreshRecipe.UseVisualStyleBackColor = true;
            // 
            // RecipesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerRecipes);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecipesForm";
            this.Text = "RecipesForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipes)).EndInit();
            this.splitContainerRecipes.Panel1.ResumeLayout(false);
            this.splitContainerRecipes.Panel2.ResumeLayout(false);
            this.splitContainerRecipes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.grpRecipeDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRecipeDetail)).EndInit();
            this.splitContainerRecipeDetail.Panel1.ResumeLayout(false);
            this.splitContainerRecipeDetail.Panel2.ResumeLayout(false);
            this.splitContainerRecipeDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeNutrients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeComponents)).EndInit();
            this.tableRecipeDetail.ResumeLayout(false);
            this.tableRecipeDetail.PerformLayout();
            this.flowRecipeButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerRecipes;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox grpRecipeDetail;
        private System.Windows.Forms.SplitContainer splitContainerRecipeDetail;
        private System.Windows.Forms.DataGridView dgvRecipeNutrients;
        private System.Windows.Forms.Label lblRecipeNutrients;
        private System.Windows.Forms.DataGridView dgvRecipeComponents;
        private System.Windows.Forms.Label lblRecipeComponents;
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
        private System.Windows.Forms.FlowLayoutPanel flowRecipeButtons;
        private System.Windows.Forms.Button btnRefreshRecipe;
    }
}

