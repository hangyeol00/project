namespace nutritionist
{
    partial class StudentAllergyForm
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.tableStudentInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.txtStudentInfo = new System.Windows.Forms.TextBox();
            this.lblAllergy = new System.Windows.Forms.Label();
            this.cmbAllergy = new System.Windows.Forms.ComboBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpAllergies = new System.Windows.Forms.GroupBox();
            this.dgvAllergies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.tableStudentInfo.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.grpAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.dgvStudents);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Size = new System.Drawing.Size(954, 487);
            this.splitMain.SplitterDistance = 400;
            this.splitMain.TabIndex = 0;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 0);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(400, 487);
            this.dgvStudents.TabIndex = 0;
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.grpStudentInfo);
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.grpAllergies);
            this.splitRight.Size = new System.Drawing.Size(550, 487);
            this.splitRight.SplitterDistance = 200;
            this.splitRight.TabIndex = 0;
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.tableStudentInfo);
            this.grpStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStudentInfo.Location = new System.Drawing.Point(0, 0);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Padding = new System.Windows.Forms.Padding(10);
            this.grpStudentInfo.Size = new System.Drawing.Size(550, 200);
            this.grpStudentInfo.TabIndex = 0;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "학생 정보";
            // 
            // tableStudentInfo
            // 
            this.tableStudentInfo.ColumnCount = 2;
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableStudentInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStudentInfo.Controls.Add(this.lblStudentInfo, 0, 0);
            this.tableStudentInfo.Controls.Add(this.txtStudentInfo, 1, 0);
            this.tableStudentInfo.Controls.Add(this.lblAllergy, 0, 1);
            this.tableStudentInfo.Controls.Add(this.cmbAllergy, 1, 1);
            this.tableStudentInfo.Controls.Add(this.flowButtons, 0, 2);
            this.tableStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableStudentInfo.Location = new System.Drawing.Point(10, 23);
            this.tableStudentInfo.Name = "tableStudentInfo";
            this.tableStudentInfo.RowCount = 3;
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableStudentInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStudentInfo.Size = new System.Drawing.Size(530, 167);
            this.tableStudentInfo.TabIndex = 0;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudentInfo.Location = new System.Drawing.Point(3, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(94, 35);
            this.lblStudentInfo.TabIndex = 0;
            this.lblStudentInfo.Text = "학생:";
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStudentInfo
            // 
            this.txtStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentInfo.Location = new System.Drawing.Point(103, 3);
            this.txtStudentInfo.Name = "txtStudentInfo";
            this.txtStudentInfo.Size = new System.Drawing.Size(424, 21);
            this.txtStudentInfo.TabIndex = 1;
            // 
            // lblAllergy
            // 
            this.lblAllergy.AutoSize = true;
            this.lblAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergy.Location = new System.Drawing.Point(3, 35);
            this.lblAllergy.Name = "lblAllergy";
            this.lblAllergy.Size = new System.Drawing.Size(94, 35);
            this.lblAllergy.TabIndex = 2;
            this.lblAllergy.Text = "알레르기:";
            this.lblAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAllergy
            // 
            this.cmbAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAllergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAllergy.FormattingEnabled = true;
            this.cmbAllergy.Location = new System.Drawing.Point(103, 38);
            this.cmbAllergy.Name = "cmbAllergy";
            this.cmbAllergy.Size = new System.Drawing.Size(424, 20);
            this.cmbAllergy.TabIndex = 3;
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.tableStudentInfo.SetColumnSpan(this.flowButtons, 2);
            this.flowButtons.Controls.Add(this.btnAdd);
            this.flowButtons.Controls.Add(this.btnRemove);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(3, 73);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowButtons.Size = new System.Drawing.Size(524, 40);
            this.flowButtons.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(446, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(365, 13);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // grpAllergies
            // 
            this.grpAllergies.Controls.Add(this.dgvAllergies);
            this.grpAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergies.Location = new System.Drawing.Point(0, 0);
            this.grpAllergies.Name = "grpAllergies";
            this.grpAllergies.Padding = new System.Windows.Forms.Padding(10);
            this.grpAllergies.Size = new System.Drawing.Size(550, 283);
            this.grpAllergies.TabIndex = 0;
            this.grpAllergies.TabStop = false;
            this.grpAllergies.Text = "등록된 알레르기";
            // 
            // dgvAllergies
            // 
            this.dgvAllergies.AllowUserToAddRows = false;
            this.dgvAllergies.AllowUserToDeleteRows = false;
            this.dgvAllergies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergies.Location = new System.Drawing.Point(10, 23);
            this.dgvAllergies.MultiSelect = false;
            this.dgvAllergies.Name = "dgvAllergies";
            this.dgvAllergies.ReadOnly = true;
            this.dgvAllergies.RowHeadersWidth = 51;
            this.dgvAllergies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllergies.Size = new System.Drawing.Size(530, 250);
            this.dgvAllergies.TabIndex = 0;
            // 
            // StudentAllergyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentAllergyForm";
            this.Text = "학생 알레르기 관리";
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.grpStudentInfo.ResumeLayout(false);
            this.tableStudentInfo.ResumeLayout(false);
            this.tableStudentInfo.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.grpAllergies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.TableLayoutPanel tableStudentInfo;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.TextBox txtStudentInfo;
        private System.Windows.Forms.Label lblAllergy;
        private System.Windows.Forms.ComboBox cmbAllergy;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox grpAllergies;
        private System.Windows.Forms.DataGridView dgvAllergies;
    }
}

