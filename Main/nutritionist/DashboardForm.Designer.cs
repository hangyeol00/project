namespace nutritionist
{
    partial class DashboardForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblCurrentServeDate = new System.Windows.Forms.Label();
            this.lblServeDateTitle = new System.Windows.Forms.Label();
            this.lblNotMealValue = new System.Windows.Forms.Label();
            this.lblNotMeal = new System.Windows.Forms.Label();
            this.lblTodayMealValue = new System.Windows.Forms.Label();
            this.lblTodayMeal = new System.Windows.Forms.Label();
            this.lblTotalStudentValue = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.grpTodayMeals = new System.Windows.Forms.GroupBox();
            this.dgvTodayMeals = new System.Windows.Forms.DataGridView();
            this.grpTodayRaw = new System.Windows.Forms.GroupBox();
            this.dgvTodayRawNeeds = new System.Windows.Forms.DataGridView();
            this.grpShortage = new System.Windows.Forms.GroupBox();
            this.dgvShortageRaw = new System.Windows.Forms.DataGridView();
            this.grpMealLogs = new System.Windows.Forms.GroupBox();
            this.dgvMealLogs = new System.Windows.Forms.DataGridView();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnMarkServed = new System.Windows.Forms.Button();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            this.btnServeMeal = new System.Windows.Forms.Button();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.lblMenuCode = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.layoutDashboard.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.grpTodayMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMeals)).BeginInit();
            this.grpTodayRaw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayRawNeeds)).BeginInit();
            this.grpShortage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortageRaw)).BeginInit();
            this.grpMealLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).BeginInit();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutDashboard
            // 
            this.layoutDashboard.ColumnCount = 2;
            this.layoutDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutDashboard.Controls.Add(this.grpSummary, 0, 0);
            this.layoutDashboard.Controls.Add(this.grpTodayMeals, 0, 1);
            this.layoutDashboard.Controls.Add(this.grpTodayRaw, 1, 1);
            this.layoutDashboard.Controls.Add(this.grpShortage, 0, 2);
            this.layoutDashboard.Controls.Add(this.grpMealLogs, 1, 2);
            this.layoutDashboard.Controls.Add(this.grpAction, 0, 3);
            this.layoutDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDashboard.Location = new System.Drawing.Point(0, 0);
            this.layoutDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDashboard.Name = "layoutDashboard";
            this.layoutDashboard.RowCount = 4;
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.layoutDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.layoutDashboard.Size = new System.Drawing.Size(954, 487);
            this.layoutDashboard.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.layoutDashboard.SetColumnSpan(this.grpSummary, 2);
            this.grpSummary.Controls.Add(this.lblCurrentServeDate);
            this.grpSummary.Controls.Add(this.lblServeDateTitle);
            this.grpSummary.Controls.Add(this.lblNotMealValue);
            this.grpSummary.Controls.Add(this.lblNotMeal);
            this.grpSummary.Controls.Add(this.lblTodayMealValue);
            this.grpSummary.Controls.Add(this.lblTodayMeal);
            this.grpSummary.Controls.Add(this.lblTotalStudentValue);
            this.grpSummary.Controls.Add(this.lblTotalStudent);
            this.grpSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSummary.Location = new System.Drawing.Point(3, 2);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(948, 76);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "급식 현황";
            // 
            // lblCurrentServeDate
            // 
            this.lblCurrentServeDate.AutoSize = true;
            this.lblCurrentServeDate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentServeDate.Location = new System.Drawing.Point(98, 20);
            this.lblCurrentServeDate.Name = "lblCurrentServeDate";
            this.lblCurrentServeDate.Size = new System.Drawing.Size(95, 19);
            this.lblCurrentServeDate.TabIndex = 7;
            this.lblCurrentServeDate.Text = "yyyy-MM-dd";
            // 
            // lblServeDateTitle
            // 
            this.lblServeDateTitle.AutoSize = true;
            this.lblServeDateTitle.Location = new System.Drawing.Point(18, 20);
            this.lblServeDateTitle.Name = "lblServeDateTitle";
            this.lblServeDateTitle.Size = new System.Drawing.Size(73, 19);
            this.lblServeDateTitle.TabIndex = 6;
            this.lblServeDateTitle.Text = "기준 일자:";
            // 
            // lblNotMealValue
            // 
            this.lblNotMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotMealValue.Location = new System.Drawing.Point(722, 39);
            this.lblNotMealValue.Name = "lblNotMealValue";
            this.lblNotMealValue.Size = new System.Drawing.Size(24, 23);
            this.lblNotMealValue.TabIndex = 5;
            this.lblNotMealValue.Text = "0";
            this.lblNotMealValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNotMeal
            // 
            this.lblNotMeal.AutoSize = true;
            this.lblNotMeal.Location = new System.Drawing.Point(604, 41);
            this.lblNotMeal.Name = "lblNotMeal";
            this.lblNotMeal.Size = new System.Drawing.Size(120, 19);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "발주 대기 원재료:";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayMealValue.Location = new System.Drawing.Point(456, 40);
            this.lblTodayMealValue.Name = "lblTodayMealValue";
            this.lblTodayMealValue.Size = new System.Drawing.Size(40, 23);
            this.lblTodayMealValue.TabIndex = 3;
            this.lblTodayMealValue.Text = "0";
            this.lblTodayMealValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTodayMeal
            // 
            this.lblTodayMeal.AutoSize = true;
            this.lblTodayMeal.Location = new System.Drawing.Point(346, 41);
            this.lblTodayMeal.Name = "lblTodayMeal";
            this.lblTodayMeal.Size = new System.Drawing.Size(111, 19);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "승인 대기 식단 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentValue.Location = new System.Drawing.Point(239, 40);
            this.lblTotalStudentValue.Name = "lblTotalStudentValue";
            this.lblTotalStudentValue.Size = new System.Drawing.Size(40, 23);
            this.lblTotalStudentValue.TabIndex = 1;
            this.lblTotalStudentValue.Text = "0";
            this.lblTotalStudentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Location = new System.Drawing.Point(136, 41);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(100, 19);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "오늘 식단(건) :";
            // 
            // grpTodayMeals
            // 
            this.grpTodayMeals.Controls.Add(this.dgvTodayMeals);
            this.grpTodayMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayMeals.Location = new System.Drawing.Point(3, 82);
            this.grpTodayMeals.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpTodayMeals.Name = "grpTodayMeals";
            this.grpTodayMeals.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayMeals.Size = new System.Drawing.Size(465, 152);
            this.grpTodayMeals.TabIndex = 1;
            this.grpTodayMeals.TabStop = false;
            this.grpTodayMeals.Text = "오늘의 식단";
            // 
            // dgvTodayMeals
            // 
            this.dgvTodayMeals.AllowUserToAddRows = false;
            this.dgvTodayMeals.AllowUserToDeleteRows = false;
            this.dgvTodayMeals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayMeals.Location = new System.Drawing.Point(3, 20);
            this.dgvTodayMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayMeals.MultiSelect = false;
            this.dgvTodayMeals.Name = "dgvTodayMeals";
            this.dgvTodayMeals.ReadOnly = true;
            this.dgvTodayMeals.RowHeadersWidth = 51;
            this.dgvTodayMeals.RowTemplate.Height = 27;
            this.dgvTodayMeals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayMeals.Size = new System.Drawing.Size(459, 130);
            this.dgvTodayMeals.TabIndex = 0;
            // 
            // grpTodayRaw
            // 
            this.grpTodayRaw.Controls.Add(this.dgvTodayRawNeeds);
            this.grpTodayRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTodayRaw.Location = new System.Drawing.Point(480, 82);
            this.grpTodayRaw.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpTodayRaw.Name = "grpTodayRaw";
            this.grpTodayRaw.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpTodayRaw.Size = new System.Drawing.Size(465, 152);
            this.grpTodayRaw.TabIndex = 2;
            this.grpTodayRaw.TabStop = false;
            this.grpTodayRaw.Text = "오늘 필요한 원재료";
            // 
            // dgvTodayRawNeeds
            // 
            this.dgvTodayRawNeeds.AllowUserToAddRows = false;
            this.dgvTodayRawNeeds.AllowUserToDeleteRows = false;
            this.dgvTodayRawNeeds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodayRawNeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayRawNeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodayRawNeeds.Location = new System.Drawing.Point(3, 20);
            this.dgvTodayRawNeeds.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTodayRawNeeds.MultiSelect = false;
            this.dgvTodayRawNeeds.Name = "dgvTodayRawNeeds";
            this.dgvTodayRawNeeds.ReadOnly = true;
            this.dgvTodayRawNeeds.RowHeadersWidth = 51;
            this.dgvTodayRawNeeds.RowTemplate.Height = 27;
            this.dgvTodayRawNeeds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayRawNeeds.Size = new System.Drawing.Size(459, 130);
            this.dgvTodayRawNeeds.TabIndex = 0;
            // 
            // grpShortage
            // 
            this.grpShortage.Controls.Add(this.dgvShortageRaw);
            this.grpShortage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShortage.Location = new System.Drawing.Point(3, 238);
            this.grpShortage.Margin = new System.Windows.Forms.Padding(3, 2, 6, 2);
            this.grpShortage.Name = "grpShortage";
            this.grpShortage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpShortage.Size = new System.Drawing.Size(465, 152);
            this.grpShortage.TabIndex = 3;
            this.grpShortage.TabStop = false;
            this.grpShortage.Text = "발주 대기 / 부족 원재료";
            // 
            // dgvShortageRaw
            // 
            this.dgvShortageRaw.AllowUserToAddRows = false;
            this.dgvShortageRaw.AllowUserToDeleteRows = false;
            this.dgvShortageRaw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShortageRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortageRaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShortageRaw.Location = new System.Drawing.Point(3, 20);
            this.dgvShortageRaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShortageRaw.MultiSelect = false;
            this.dgvShortageRaw.Name = "dgvShortageRaw";
            this.dgvShortageRaw.ReadOnly = true;
            this.dgvShortageRaw.RowHeadersWidth = 51;
            this.dgvShortageRaw.RowTemplate.Height = 27;
            this.dgvShortageRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShortageRaw.Size = new System.Drawing.Size(459, 130);
            this.dgvShortageRaw.TabIndex = 0;
            // 
            // grpMealLogs
            // 
            this.grpMealLogs.Controls.Add(this.dgvMealLogs);
            this.grpMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMealLogs.Location = new System.Drawing.Point(480, 238);
            this.grpMealLogs.Margin = new System.Windows.Forms.Padding(6, 2, 3, 2);
            this.grpMealLogs.Name = "grpMealLogs";
            this.grpMealLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Size = new System.Drawing.Size(465, 152);
            this.grpMealLogs.TabIndex = 4;
            this.grpMealLogs.TabStop = false;
            this.grpMealLogs.Text = "식단 계획 승인 현황";
            // 
            // dgvMealLogs
            // 
            this.dgvMealLogs.AllowUserToAddRows = false;
            this.dgvMealLogs.AllowUserToDeleteRows = false;
            this.dgvMealLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealLogs.Location = new System.Drawing.Point(3, 20);
            this.dgvMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealLogs.MultiSelect = false;
            this.dgvMealLogs.Name = "dgvMealLogs";
            this.dgvMealLogs.ReadOnly = true;
            this.dgvMealLogs.RowHeadersWidth = 51;
            this.dgvMealLogs.RowTemplate.Height = 27;
            this.dgvMealLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealLogs.Size = new System.Drawing.Size(459, 130);
            this.dgvMealLogs.TabIndex = 0;
            // 
            // grpAction
            // 
            this.layoutDashboard.SetColumnSpan(this.grpAction, 2);
            this.grpAction.Controls.Add(this.btnMarkServed);
            this.grpAction.Controls.Add(this.btnCancelMeal);
            this.grpAction.Controls.Add(this.btnServeMeal);
            this.grpAction.Controls.Add(this.txtMenuCode);
            this.grpAction.Controls.Add(this.lblMenuCode);
            this.grpAction.Controls.Add(this.txtStudentId);
            this.grpAction.Controls.Add(this.lblStudentId);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAction.Location = new System.Drawing.Point(3, 394);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Size = new System.Drawing.Size(948, 87);
            this.grpAction.TabIndex = 5;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "업무 작업";
            // 
            // btnMarkServed
            // 
            this.btnMarkServed.Location = new System.Drawing.Point(808, 18);
            this.btnMarkServed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkServed.Name = "btnMarkServed";
            this.btnMarkServed.Size = new System.Drawing.Size(104, 30);
            this.btnMarkServed.TabIndex = 6;
            this.btnMarkServed.Text = "배식 완료 →";
            this.btnMarkServed.UseVisualStyleBackColor = true;
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Location = new System.Drawing.Point(532, 18);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(132, 30);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "발주 승인/등록";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Location = new System.Drawing.Point(381, 18);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(132, 30);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "식단 승인/등록";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(240, 20);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.ReadOnly = true;
            this.txtMenuCode.Size = new System.Drawing.Size(130, 25);
            this.txtMenuCode.TabIndex = 3;
            this.txtMenuCode.TabStop = false;
            // 
            // lblMenuCode
            // 
            this.lblMenuCode.AutoSize = true;
            this.lblMenuCode.Location = new System.Drawing.Point(158, 23);
            this.lblMenuCode.Name = "lblMenuCode";
            this.lblMenuCode.Size = new System.Drawing.Size(73, 19);
            this.lblMenuCode.TabIndex = 2;
            this.lblMenuCode.Text = "식단 계획:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(90, 20);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(60, 25);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TabStop = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(10, 23);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(73, 19);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "기준 일자:";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.layoutDashboard);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.layoutDashboard.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.grpTodayMeals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayMeals)).EndInit();
            this.grpTodayRaw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayRawNeeds)).EndInit();
            this.grpShortage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortageRaw)).EndInit();
            this.grpMealLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutDashboard;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblCurrentServeDate;
        private System.Windows.Forms.Label lblServeDateTitle;
        private System.Windows.Forms.Label lblNotMealValue;
        private System.Windows.Forms.Label lblNotMeal;
        private System.Windows.Forms.Label lblTodayMealValue;
        private System.Windows.Forms.Label lblTodayMeal;
        private System.Windows.Forms.Label lblTotalStudentValue;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.GroupBox grpTodayMeals;
        private System.Windows.Forms.DataGridView dgvTodayMeals;
        private System.Windows.Forms.GroupBox grpTodayRaw;
        private System.Windows.Forms.DataGridView dgvTodayRawNeeds;
        private System.Windows.Forms.GroupBox grpShortage;
        private System.Windows.Forms.DataGridView dgvShortageRaw;
        private System.Windows.Forms.GroupBox grpMealLogs;
        private System.Windows.Forms.DataGridView dgvMealLogs;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnMarkServed;
        private System.Windows.Forms.Button btnCancelMeal;
        private System.Windows.Forms.Button btnServeMeal;
        private System.Windows.Forms.TextBox txtMenuCode;
        private System.Windows.Forms.Label lblMenuCode;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblStudentId;
    }
}

