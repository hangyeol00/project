namespace nutritionist
{
    partial class MealPlansForm
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
            this.splitContainerMealPlans = new System.Windows.Forms.SplitContainer();
            this.dgvMealPlans = new System.Windows.Forms.DataGridView();
            this.grpMealPlanDetail = new System.Windows.Forms.GroupBox();
            this.splitMealSub = new System.Windows.Forms.SplitContainer();
            this.dgvMealRecipes = new System.Windows.Forms.DataGridView();
            this.lblMealRecipes = new System.Windows.Forms.Label();
            this.dgvMealComponents = new System.Windows.Forms.DataGridView();
            this.tableMealPlanDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealDate = new System.Windows.Forms.Label();
            this.dtpMealDate = new System.Windows.Forms.DateTimePicker();
            this.lblMealType = new System.Windows.Forms.Label();
            this.cmbMealType = new System.Windows.Forms.ComboBox();
            this.lblMealNotes = new System.Windows.Forms.Label();
            this.txtMealNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).BeginInit();
            this.splitContainerMealPlans.Panel1.SuspendLayout();
            this.splitContainerMealPlans.Panel2.SuspendLayout();
            this.splitContainerMealPlans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).BeginInit();
            this.grpMealPlanDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMealSub)).BeginInit();
            this.splitMealSub.Panel1.SuspendLayout();
            this.splitMealSub.Panel2.SuspendLayout();
            this.splitMealSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealComponents)).BeginInit();
            this.tableMealPlanDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMealPlans
            // 
            this.splitContainerMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMealPlans.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMealPlans.Name = "splitContainerMealPlans";
            // 
            // splitContainerMealPlans.Panel1
            // 
            this.splitContainerMealPlans.Panel1.Controls.Add(this.dgvMealPlans);
            // 
            // splitContainerMealPlans.Panel2
            // 
            this.splitContainerMealPlans.Panel2.Controls.Add(this.grpMealPlanDetail);
            this.splitContainerMealPlans.Size = new System.Drawing.Size(954, 487);
            this.splitContainerMealPlans.SplitterDistance = 477;
            this.splitContainerMealPlans.TabIndex = 0;
            // 
            // dgvMealPlans
            // 
            this.dgvMealPlans.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvMealPlans.Name = "dgvMealPlans";
            this.dgvMealPlans.RowHeadersWidth = 51;
            this.dgvMealPlans.RowTemplate.Height = 27;
            this.dgvMealPlans.Size = new System.Drawing.Size(477, 487);
            this.dgvMealPlans.TabIndex = 0;
            // 
            // grpMealPlanDetail
            // 
            this.grpMealPlanDetail.Controls.Add(this.splitMealSub);
            this.grpMealPlanDetail.Controls.Add(this.tableMealPlanDetail);
            this.grpMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealPlanDetail.Location = new System.Drawing.Point(0, 0);
            this.grpMealPlanDetail.Name = "grpMealPlanDetail";
            this.grpMealPlanDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealPlanDetail.Size = new System.Drawing.Size(473, 487);
            this.grpMealPlanDetail.TabIndex = 0;
            this.grpMealPlanDetail.TabStop = false;
            this.grpMealPlanDetail.Text = "식단 계획 상세";
            // 
            // splitMealSub
            // 
            this.splitMealSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMealSub.Location = new System.Drawing.Point(3, 165);
            this.splitMealSub.Name = "splitMealSub";
            this.splitMealSub.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitMealSub.Panel1
            // 
            this.splitMealSub.Panel1.Controls.Add(this.dgvMealRecipes);
            this.splitMealSub.Panel1.Controls.Add(this.lblMealRecipes);
            // 
            // splitMealSub.Panel2
            // 
            this.splitMealSub.Panel2.Controls.Add(this.dgvMealComponents);
            this.splitMealSub.Size = new System.Drawing.Size(467, 320);
            this.splitMealSub.SplitterDistance = 159;
            this.splitMealSub.TabIndex = 1;
            // 
            // dgvMealRecipes
            // 
            this.dgvMealRecipes.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealRecipes.Location = new System.Drawing.Point(0, 30);
            this.dgvMealRecipes.Name = "dgvMealRecipes";
            this.dgvMealRecipes.RowHeadersWidth = 51;
            this.dgvMealRecipes.RowTemplate.Height = 27;
            this.dgvMealRecipes.Size = new System.Drawing.Size(467, 129);
            this.dgvMealRecipes.TabIndex = 1;
            // 
            // lblMealRecipes
            // 
            this.lblMealRecipes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMealRecipes.Location = new System.Drawing.Point(0, 0);
            this.lblMealRecipes.Name = "lblMealRecipes";
            this.lblMealRecipes.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblMealRecipes.Size = new System.Drawing.Size(467, 30);
            this.lblMealRecipes.TabIndex = 0;
            this.lblMealRecipes.Text = "식단 메뉴";
            // 
            // dgvMealComponents
            // 
            this.dgvMealComponents.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealComponents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealComponents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealComponents.Location = new System.Drawing.Point(0, 0);
            this.dgvMealComponents.Name = "dgvMealComponents";
            this.dgvMealComponents.RowHeadersWidth = 51;
            this.dgvMealComponents.RowTemplate.Height = 27;
            this.dgvMealComponents.Size = new System.Drawing.Size(467, 157);
            this.dgvMealComponents.TabIndex = 0;
            // 
            // tableMealPlanDetail
            // 
            this.tableMealPlanDetail.ColumnCount = 2;
            this.tableMealPlanDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableMealPlanDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealPlanDetail.Controls.Add(this.lblMealDate, 0, 0);
            this.tableMealPlanDetail.Controls.Add(this.dtpMealDate, 1, 0);
            this.tableMealPlanDetail.Controls.Add(this.lblMealType, 0, 1);
            this.tableMealPlanDetail.Controls.Add(this.cmbMealType, 1, 1);
            this.tableMealPlanDetail.Controls.Add(this.lblMealNotes, 0, 2);
            this.tableMealPlanDetail.Controls.Add(this.txtMealNotes, 1, 2);
            this.tableMealPlanDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableMealPlanDetail.Location = new System.Drawing.Point(3, 25);
            this.tableMealPlanDetail.Name = "tableMealPlanDetail";
            this.tableMealPlanDetail.RowCount = 3;
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealPlanDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealPlanDetail.Size = new System.Drawing.Size(467, 140);
            this.tableMealPlanDetail.TabIndex = 0;
            // 
            // lblMealDate
            // 
            this.lblMealDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealDate.Location = new System.Drawing.Point(3, 0);
            this.lblMealDate.Name = "lblMealDate";
            this.lblMealDate.Size = new System.Drawing.Size(114, 36);
            this.lblMealDate.TabIndex = 0;
            this.lblMealDate.Text = "날짜";
            this.lblMealDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpMealDate
            // 
            this.dtpMealDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpMealDate.Location = new System.Drawing.Point(123, 2);
            this.dtpMealDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpMealDate.Name = "dtpMealDate";
            this.dtpMealDate.Size = new System.Drawing.Size(341, 30);
            this.dtpMealDate.TabIndex = 1;
            // 
            // lblMealType
            // 
            this.lblMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealType.Location = new System.Drawing.Point(3, 36);
            this.lblMealType.Name = "lblMealType";
            this.lblMealType.Size = new System.Drawing.Size(114, 36);
            this.lblMealType.TabIndex = 2;
            this.lblMealType.Text = "식사 유형";
            this.lblMealType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMealType
            // 
            this.cmbMealType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMealType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMealType.FormattingEnabled = true;
            this.cmbMealType.Location = new System.Drawing.Point(123, 38);
            this.cmbMealType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMealType.Name = "cmbMealType";
            this.cmbMealType.Size = new System.Drawing.Size(341, 31);
            this.cmbMealType.TabIndex = 3;
            // 
            // lblMealNotes
            // 
            this.lblMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealNotes.Location = new System.Drawing.Point(3, 72);
            this.lblMealNotes.Name = "lblMealNotes";
            this.lblMealNotes.Size = new System.Drawing.Size(114, 68);
            this.lblMealNotes.TabIndex = 4;
            this.lblMealNotes.Text = "비고";
            this.lblMealNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMealNotes
            // 
            this.txtMealNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMealNotes.Location = new System.Drawing.Point(123, 74);
            this.txtMealNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMealNotes.Name = "txtMealNotes";
            this.txtMealNotes.ReadOnly = true;
            this.txtMealNotes.Size = new System.Drawing.Size(341, 30);
            this.txtMealNotes.TabIndex = 5;
            // 
            // MealPlansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerMealPlans);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealPlansForm";
            this.Text = "MealPlansForm";
            this.splitContainerMealPlans.Panel1.ResumeLayout(false);
            this.splitContainerMealPlans.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealPlans)).EndInit();
            this.splitContainerMealPlans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).EndInit();
            this.grpMealPlanDetail.ResumeLayout(false);
            this.splitMealSub.Panel1.ResumeLayout(false);
            this.splitMealSub.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMealSub)).EndInit();
            this.splitMealSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealComponents)).EndInit();
            this.tableMealPlanDetail.ResumeLayout(false);
            this.tableMealPlanDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMealPlans;
        private System.Windows.Forms.DataGridView dgvMealPlans;
        private System.Windows.Forms.GroupBox grpMealPlanDetail;
        private System.Windows.Forms.SplitContainer splitMealSub;
        private System.Windows.Forms.DataGridView dgvMealRecipes;
        private System.Windows.Forms.Label lblMealRecipes;
        private System.Windows.Forms.DataGridView dgvMealComponents;
        private System.Windows.Forms.TableLayoutPanel tableMealPlanDetail;
        private System.Windows.Forms.Label lblMealDate;
        private System.Windows.Forms.DateTimePicker dtpMealDate;
        private System.Windows.Forms.Label lblMealType;
        private System.Windows.Forms.ComboBox cmbMealType;
        private System.Windows.Forms.Label lblMealNotes;
        private System.Windows.Forms.TextBox txtMealNotes;
    }
}

