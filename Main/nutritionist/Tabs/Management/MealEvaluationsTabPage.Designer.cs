namespace nutritionist.Tabs.Management
{
    partial class MealEvaluationsTabPage
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).BeginInit();
            this.splitContainerMealEvaluations.Panel1.SuspendLayout();
            this.splitContainerMealEvaluations.Panel2.SuspendLayout();
            this.splitContainerMealEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).BeginInit();
            this.grpMealEvaluationDetail.SuspendLayout();
            this.tableMealEvaluationDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).BeginInit();
            this.SuspendLayout();
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
            // MealEvaluationsTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerMealEvaluations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MealEvaluationsTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
            this.splitContainerMealEvaluations.Panel1.ResumeLayout(false);
            this.splitContainerMealEvaluations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).EndInit();
            this.splitContainerMealEvaluations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).EndInit();
            this.grpMealEvaluationDetail.ResumeLayout(false);
            this.tableMealEvaluationDetail.ResumeLayout(false);
            this.tableMealEvaluationDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.SplitContainer splitContainerMealEvaluations;
        internal System.Windows.Forms.DataGridView dgvMealEvaluations;
        internal System.Windows.Forms.GroupBox grpMealEvaluationDetail;
        internal System.Windows.Forms.TableLayoutPanel tableMealEvaluationDetail;
        internal System.Windows.Forms.Label lblEvaluationMeal;
        internal System.Windows.Forms.ComboBox cmbEvaluationMeal;
        internal System.Windows.Forms.Label lblEvaluationUser;
        internal System.Windows.Forms.ComboBox cmbEvaluationUser;
        internal System.Windows.Forms.Label lblEvaluationScore;
        internal System.Windows.Forms.NumericUpDown nudEvaluationScore;
        internal System.Windows.Forms.Label lblEvaluationComment;
        internal System.Windows.Forms.TextBox txtEvaluationComment;
        internal System.Windows.Forms.FlowLayoutPanel flowEvaluationButtons;
        internal System.Windows.Forms.Button btnRegisterEvaluation;
        internal System.Windows.Forms.Button btnRefreshEvaluation;
    }
}
