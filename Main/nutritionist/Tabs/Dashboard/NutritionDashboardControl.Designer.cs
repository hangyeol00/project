namespace nutritionist.Tabs
{
    partial class NutritionDashboardControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.grpMealLogs = new System.Windows.Forms.GroupBox();
            this.dgvMealLogs = new System.Windows.Forms.DataGridView();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCancelMeal = new System.Windows.Forms.Button();
            this.btnServeMeal = new System.Windows.Forms.Button();
            this.txtMenuCode = new System.Windows.Forms.TextBox();
            this.lblMenuCode = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.grpMenus = new System.Windows.Forms.GroupBox();
            this.dgvMenus = new System.Windows.Forms.DataGridView();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblNotMealValue = new System.Windows.Forms.Label();
            this.lblNotMeal = new System.Windows.Forms.Label();
            this.lblTodayMealValue = new System.Windows.Forms.Label();
            this.lblTodayMeal = new System.Windows.Forms.Label();
            this.lblTotalStudentValue = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.grpMealLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).BeginInit();
            this.grpAction.SuspendLayout();
            this.grpMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).BeginInit();
            this.grpStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMealLogs
            // 
            this.grpMealLogs.Controls.Add(this.dgvMealLogs);
            this.grpMealLogs.Location = new System.Drawing.Point(9, 296);
            this.grpMealLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Name = "grpMealLogs";
            this.grpMealLogs.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMealLogs.Size = new System.Drawing.Size(928, 168);
            this.grpMealLogs.TabIndex = 5;
            this.grpMealLogs.TabStop = false;
            this.grpMealLogs.Text = "식단 계획";
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
            this.dgvMealLogs.Size = new System.Drawing.Size(922, 146);
            this.dgvMealLogs.TabIndex = 0;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnCancelMeal);
            this.grpAction.Controls.Add(this.btnServeMeal);
            this.grpAction.Controls.Add(this.txtMenuCode);
            this.grpAction.Controls.Add(this.lblMenuCode);
            this.grpAction.Controls.Add(this.txtStudentId);
            this.grpAction.Controls.Add(this.lblStudentId);
            this.grpAction.Location = new System.Drawing.Point(656, 92);
            this.grpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Name = "grpAction";
            this.grpAction.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAction.Size = new System.Drawing.Size(280, 184);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "업무 작업";
            // 
            // btnCancelMeal
            // 
            this.btnCancelMeal.Location = new System.Drawing.Point(149, 104);
            this.btnCancelMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelMeal.Name = "btnCancelMeal";
            this.btnCancelMeal.Size = new System.Drawing.Size(96, 32);
            this.btnCancelMeal.TabIndex = 5;
            this.btnCancelMeal.Text = "발주 요청 등록";
            this.btnCancelMeal.UseVisualStyleBackColor = true;
            // 
            // btnServeMeal
            // 
            this.btnServeMeal.Location = new System.Drawing.Point(26, 104);
            this.btnServeMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServeMeal.Name = "btnServeMeal";
            this.btnServeMeal.Size = new System.Drawing.Size(96, 32);
            this.btnServeMeal.TabIndex = 4;
            this.btnServeMeal.Text = "식단 계획 등록";
            this.btnServeMeal.UseVisualStyleBackColor = true;
            // 
            // txtMenuCode
            // 
            this.txtMenuCode.Location = new System.Drawing.Point(105, 60);
            this.txtMenuCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.ReadOnly = true;
            this.txtMenuCode.Size = new System.Drawing.Size(149, 25);
            this.txtMenuCode.TabIndex = 3;
            this.txtMenuCode.TabStop = false;
            // 
            // lblMenuCode
            // 
            this.lblMenuCode.AutoSize = true;
            this.lblMenuCode.Location = new System.Drawing.Point(13, 64);
            this.lblMenuCode.Name = "lblMenuCode";
            this.lblMenuCode.Size = new System.Drawing.Size(106, 19);
            this.lblMenuCode.TabIndex = 2;
            this.lblMenuCode.Text = "선택 식단 계획:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(105, 28);
            this.txtStudentId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(149, 25);
            this.txtStudentId.TabIndex = 1;
            this.txtStudentId.TabStop = false;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(13, 32);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(87, 19);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "선택 원재료:";
            // 
            // grpMenus
            // 
            this.grpMenus.Controls.Add(this.dgvMenus);
            this.grpMenus.Location = new System.Drawing.Point(376, 92);
            this.grpMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Name = "grpMenus";
            this.grpMenus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpMenus.Size = new System.Drawing.Size(262, 184);
            this.grpMenus.TabIndex = 3;
            this.grpMenus.TabStop = false;
            this.grpMenus.Text = "최종 메뉴";
            // 
            // dgvMenus
            // 
            this.dgvMenus.AllowUserToAddRows = false;
            this.dgvMenus.AllowUserToDeleteRows = false;
            this.dgvMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenus.Location = new System.Drawing.Point(3, 20);
            this.dgvMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMenus.MultiSelect = false;
            this.dgvMenus.Name = "dgvMenus";
            this.dgvMenus.ReadOnly = true;
            this.dgvMenus.RowHeadersWidth = 51;
            this.dgvMenus.RowTemplate.Height = 27;
            this.dgvMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenus.Size = new System.Drawing.Size(256, 162);
            this.dgvMenus.TabIndex = 0;
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.dgvStudents);
            this.grpStudents.Location = new System.Drawing.Point(9, 92);
            this.grpStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStudents.Size = new System.Drawing.Size(350, 184);
            this.grpStudents.TabIndex = 2;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "원재료 목록";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(3, 20);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 27;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(344, 162);
            this.dgvStudents.TabIndex = 0;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblNotMealValue);
            this.grpSummary.Controls.Add(this.lblNotMeal);
            this.grpSummary.Controls.Add(this.lblTodayMealValue);
            this.grpSummary.Controls.Add(this.lblTodayMeal);
            this.grpSummary.Controls.Add(this.lblTotalStudentValue);
            this.grpSummary.Controls.Add(this.lblTotalStudent);
            this.grpSummary.Location = new System.Drawing.Point(9, 8);
            this.grpSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSummary.Size = new System.Drawing.Size(928, 72);
            this.grpSummary.TabIndex = 1;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "급식 현황";
            // 
            // lblNotMealValue
            // 
            this.lblNotMealValue.AutoSize = true;
            this.lblNotMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotMealValue.Location = new System.Drawing.Point(542, 32);
            this.lblNotMealValue.Name = "lblNotMealValue";
            this.lblNotMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblNotMealValue.TabIndex = 5;
            this.lblNotMealValue.Text = "0";
            // 
            // lblNotMeal
            // 
            this.lblNotMeal.AutoSize = true;
            this.lblNotMeal.Location = new System.Drawing.Point(438, 35);
            this.lblNotMeal.Name = "lblNotMeal";
            this.lblNotMeal.Size = new System.Drawing.Size(78, 19);
            this.lblNotMeal.TabIndex = 4;
            this.lblNotMeal.Text = "대기 발주 :";
            // 
            // lblTodayMealValue
            // 
            this.lblTodayMealValue.AutoSize = true;
            this.lblTodayMealValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayMealValue.Location = new System.Drawing.Point(315, 32);
            this.lblTodayMealValue.Name = "lblTodayMealValue";
            this.lblTodayMealValue.Size = new System.Drawing.Size(17, 19);
            this.lblTodayMealValue.TabIndex = 3;
            this.lblTodayMealValue.Text = "0";
            // 
            // lblTodayMeal
            // 
            this.lblTodayMeal.AutoSize = true;
            this.lblTodayMeal.Location = new System.Drawing.Point(219, 35);
            this.lblTodayMeal.Name = "lblTodayMeal";
            this.lblTodayMeal.Size = new System.Drawing.Size(78, 19);
            this.lblTodayMeal.TabIndex = 2;
            this.lblTodayMeal.Text = "등록 식단 :";
            // 
            // lblTotalStudentValue
            // 
            this.lblTotalStudentValue.AutoSize = true;
            this.lblTotalStudentValue.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudentValue.Location = new System.Drawing.Point(96, 32);
            this.lblTotalStudentValue.Name = "lblTotalStudentValue";
            this.lblTotalStudentValue.Size = new System.Drawing.Size(17, 19);
            this.lblTotalStudentValue.TabIndex = 1;
            this.lblTotalStudentValue.Text = "0";
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Location = new System.Drawing.Point(18, 35);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(92, 19);
            this.lblTotalStudent.TabIndex = 0;
            this.lblTotalStudent.Text = "등록 원재료 :";
            // 
            // NutritionDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grpMealLogs);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.grpMenus);
            this.Controls.Add(this.grpStudents);
            this.Controls.Add(this.grpSummary);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "NutritionDashboardControl";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(950, 500);
            this.grpMealLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealLogs)).EndInit();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.grpMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenus)).EndInit();
            this.grpStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpMealLogs;
        internal System.Windows.Forms.DataGridView dgvMealLogs;
        internal System.Windows.Forms.GroupBox grpAction;
        internal System.Windows.Forms.Button btnCancelMeal;
        internal System.Windows.Forms.Button btnServeMeal;
        internal System.Windows.Forms.TextBox txtMenuCode;
        internal System.Windows.Forms.Label lblMenuCode;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblStudentId;
        internal System.Windows.Forms.GroupBox grpMenus;
        internal System.Windows.Forms.DataGridView dgvMenus;
        internal System.Windows.Forms.GroupBox grpStudents;
        internal System.Windows.Forms.DataGridView dgvStudents;
        internal System.Windows.Forms.GroupBox grpSummary;
        internal System.Windows.Forms.Label lblNotMealValue;
        internal System.Windows.Forms.Label lblNotMeal;
        internal System.Windows.Forms.Label lblTodayMealValue;
        internal System.Windows.Forms.Label lblTodayMeal;
        internal System.Windows.Forms.Label lblTotalStudentValue;
        internal System.Windows.Forms.Label lblTotalStudent;
    }
}
