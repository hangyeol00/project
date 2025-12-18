namespace nutritionist
{
    partial class MealEvaluationsForm
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
            this.splitContainerMealEvaluations = new System.Windows.Forms.SplitContainer();
            this.dgvMealEvaluations = new System.Windows.Forms.DataGridView();
            this.grpMealEvaluationDetail = new System.Windows.Forms.GroupBox();
            this.flowEvaluationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshEvaluation = new System.Windows.Forms.Button();
            this.tableMealEvaluationDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblEvaluationMeal = new System.Windows.Forms.Label();
            this.cmbEvaluationMeal = new System.Windows.Forms.ComboBox();
            this.lblEvaluationUser = new System.Windows.Forms.Label();
            this.cmbEvaluationUser = new System.Windows.Forms.ComboBox();
            this.lblEvaluationScore = new System.Windows.Forms.Label();
            this.nudEvaluationScore = new System.Windows.Forms.NumericUpDown();
            this.lblEvaluationComment = new System.Windows.Forms.Label();
            this.txtEvaluationComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).BeginInit();
            this.splitContainerMealEvaluations.Panel1.SuspendLayout();
            this.splitContainerMealEvaluations.Panel2.SuspendLayout();
            this.splitContainerMealEvaluations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).BeginInit();
            this.grpMealEvaluationDetail.SuspendLayout();
            this.flowEvaluationButtons.SuspendLayout();
            this.tableMealEvaluationDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerMealEvaluations
            // 
            this.splitContainerMealEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMealEvaluations.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMealEvaluations.Name = "splitContainerMealEvaluations";
            // 
            // splitContainerMealEvaluations.Panel1
            // 
            this.splitContainerMealEvaluations.Panel1.Controls.Add(this.dgvMealEvaluations);
            // 
            // splitContainerMealEvaluations.Panel2
            // 
            this.splitContainerMealEvaluations.Panel2.Controls.Add(this.grpMealEvaluationDetail);
            this.splitContainerMealEvaluations.Size = new System.Drawing.Size(954, 487);
            this.splitContainerMealEvaluations.SplitterDistance = 477;
            this.splitContainerMealEvaluations.TabIndex = 0;
            // 
            // dgvMealEvaluations
            // 
            this.dgvMealEvaluations.BackgroundColor = System.Drawing.Color.White;
            this.dgvMealEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealEvaluations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealEvaluations.Location = new System.Drawing.Point(0, 0);
            this.dgvMealEvaluations.Name = "dgvMealEvaluations";
            this.dgvMealEvaluations.RowHeadersWidth = 51;
            this.dgvMealEvaluations.RowTemplate.Height = 27;
            this.dgvMealEvaluations.Size = new System.Drawing.Size(477, 487);
            this.dgvMealEvaluations.TabIndex = 0;
            // 
            // grpMealEvaluationDetail
            // 
            this.grpMealEvaluationDetail.Controls.Add(this.flowEvaluationButtons);
            this.grpMealEvaluationDetail.Controls.Add(this.tableMealEvaluationDetail);
            this.grpMealEvaluationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealEvaluationDetail.Location = new System.Drawing.Point(0, 0);
            this.grpMealEvaluationDetail.Name = "grpMealEvaluationDetail";
            this.grpMealEvaluationDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealEvaluationDetail.Size = new System.Drawing.Size(473, 487);
            this.grpMealEvaluationDetail.TabIndex = 0;
            this.grpMealEvaluationDetail.TabStop = false;
            this.grpMealEvaluationDetail.Text = "식단 평가 상세";
            // 
            // flowEvaluationButtons
            // 
            this.flowEvaluationButtons.AutoSize = true;
            this.flowEvaluationButtons.Controls.Add(this.btnRefreshEvaluation);
            this.flowEvaluationButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowEvaluationButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowEvaluationButtons.Location = new System.Drawing.Point(3, 445);
            this.flowEvaluationButtons.Name = "flowEvaluationButtons";
            this.flowEvaluationButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowEvaluationButtons.Size = new System.Drawing.Size(467, 40);
            this.flowEvaluationButtons.TabIndex = 1;
            // 
            // btnRefreshEvaluation
            // 
            this.btnRefreshEvaluation.Location = new System.Drawing.Point(369, 10);
            this.btnRefreshEvaluation.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRefreshEvaluation.Name = "btnRefreshEvaluation";
            this.btnRefreshEvaluation.Size = new System.Drawing.Size(98, 28);
            this.btnRefreshEvaluation.TabIndex = 0;
            this.btnRefreshEvaluation.Text = "새로고침";
            this.btnRefreshEvaluation.UseVisualStyleBackColor = true;
            // 
            // tableMealEvaluationDetail
            // 
            this.tableMealEvaluationDetail.ColumnCount = 2;
            this.tableMealEvaluationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableMealEvaluationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationMeal, 0, 0);
            this.tableMealEvaluationDetail.Controls.Add(this.cmbEvaluationMeal, 1, 0);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationUser, 0, 1);
            this.tableMealEvaluationDetail.Controls.Add(this.cmbEvaluationUser, 1, 1);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationScore, 0, 2);
            this.tableMealEvaluationDetail.Controls.Add(this.nudEvaluationScore, 1, 2);
            this.tableMealEvaluationDetail.Controls.Add(this.lblEvaluationComment, 0, 3);
            this.tableMealEvaluationDetail.Controls.Add(this.txtEvaluationComment, 1, 3);
            this.tableMealEvaluationDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableMealEvaluationDetail.Location = new System.Drawing.Point(3, 25);
            this.tableMealEvaluationDetail.Name = "tableMealEvaluationDetail";
            this.tableMealEvaluationDetail.RowCount = 4;
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealEvaluationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableMealEvaluationDetail.Size = new System.Drawing.Size(467, 144);
            this.tableMealEvaluationDetail.TabIndex = 0;
            // 
            // lblEvaluationMeal
            // 
            this.lblEvaluationMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationMeal.Location = new System.Drawing.Point(3, 0);
            this.lblEvaluationMeal.Name = "lblEvaluationMeal";
            this.lblEvaluationMeal.Size = new System.Drawing.Size(114, 36);
            this.lblEvaluationMeal.TabIndex = 0;
            this.lblEvaluationMeal.Text = "식단";
            this.lblEvaluationMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEvaluationMeal
            // 
            this.cmbEvaluationMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEvaluationMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvaluationMeal.FormattingEnabled = true;
            this.cmbEvaluationMeal.Location = new System.Drawing.Point(123, 2);
            this.cmbEvaluationMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEvaluationMeal.Name = "cmbEvaluationMeal";
            this.cmbEvaluationMeal.Size = new System.Drawing.Size(341, 31);
            this.cmbEvaluationMeal.TabIndex = 1;
            // 
            // lblEvaluationUser
            // 
            this.lblEvaluationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationUser.Location = new System.Drawing.Point(3, 36);
            this.lblEvaluationUser.Name = "lblEvaluationUser";
            this.lblEvaluationUser.Size = new System.Drawing.Size(114, 36);
            this.lblEvaluationUser.TabIndex = 2;
            this.lblEvaluationUser.Text = "사용자";
            this.lblEvaluationUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEvaluationUser
            // 
            this.cmbEvaluationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEvaluationUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvaluationUser.FormattingEnabled = true;
            this.cmbEvaluationUser.Location = new System.Drawing.Point(123, 38);
            this.cmbEvaluationUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEvaluationUser.Name = "cmbEvaluationUser";
            this.cmbEvaluationUser.Size = new System.Drawing.Size(341, 31);
            this.cmbEvaluationUser.TabIndex = 3;
            // 
            // lblEvaluationScore
            // 
            this.lblEvaluationScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEvaluationScore.Location = new System.Drawing.Point(3, 72);
            this.lblEvaluationScore.Name = "lblEvaluationScore";
            this.lblEvaluationScore.Size = new System.Drawing.Size(114, 36);
            this.lblEvaluationScore.TabIndex = 4;
            this.lblEvaluationScore.Text = "점수 (1-5)";
            this.lblEvaluationScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEvaluationScore
            // 
            this.nudEvaluationScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudEvaluationScore.Location = new System.Drawing.Point(123, 74);
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
            this.nudEvaluationScore.Size = new System.Drawing.Size(105, 30);
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
            this.lblEvaluationComment.Location = new System.Drawing.Point(3, 108);
            this.lblEvaluationComment.Name = "lblEvaluationComment";
            this.lblEvaluationComment.Size = new System.Drawing.Size(114, 36);
            this.lblEvaluationComment.TabIndex = 6;
            this.lblEvaluationComment.Text = "의견";
            this.lblEvaluationComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEvaluationComment
            // 
            this.txtEvaluationComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvaluationComment.Location = new System.Drawing.Point(123, 110);
            this.txtEvaluationComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvaluationComment.Name = "txtEvaluationComment";
            this.txtEvaluationComment.ReadOnly = true;
            this.txtEvaluationComment.Size = new System.Drawing.Size(341, 30);
            this.txtEvaluationComment.TabIndex = 7;
            // 
            // MealEvaluationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerMealEvaluations);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealEvaluationsForm";
            this.Text = "MealEvaluationsForm";
            this.splitContainerMealEvaluations.Panel1.ResumeLayout(false);
            this.splitContainerMealEvaluations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMealEvaluations)).EndInit();
            this.splitContainerMealEvaluations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealEvaluations)).EndInit();
            this.grpMealEvaluationDetail.ResumeLayout(false);
            this.grpMealEvaluationDetail.PerformLayout();
            this.flowEvaluationButtons.ResumeLayout(false);
            this.tableMealEvaluationDetail.ResumeLayout(false);
            this.tableMealEvaluationDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvaluationScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMealEvaluations;
        private System.Windows.Forms.DataGridView dgvMealEvaluations;
        private System.Windows.Forms.GroupBox grpMealEvaluationDetail;
        private System.Windows.Forms.TableLayoutPanel tableMealEvaluationDetail;
        private System.Windows.Forms.Label lblEvaluationMeal;
        private System.Windows.Forms.ComboBox cmbEvaluationMeal;
        private System.Windows.Forms.Label lblEvaluationUser;
        private System.Windows.Forms.ComboBox cmbEvaluationUser;
        private System.Windows.Forms.Label lblEvaluationScore;
        private System.Windows.Forms.NumericUpDown nudEvaluationScore;
        private System.Windows.Forms.Label lblEvaluationComment;
        private System.Windows.Forms.TextBox txtEvaluationComment;
        private System.Windows.Forms.FlowLayoutPanel flowEvaluationButtons;
        private System.Windows.Forms.Button btnRefreshEvaluation;
    }
}

