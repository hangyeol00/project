namespace nutritionist.Tabs.Management
{
    partial class UsersTabPage
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
            this.btnManageUserAllergies = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.flowUserButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.tableUserDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserGrade = new System.Windows.Forms.Label();
            this.txtUserGrade = new System.Windows.Forms.TextBox();
            this.lblUserClass = new System.Windows.Forms.Label();
            this.txtUserClass = new System.Windows.Forms.TextBox();
            this.lblUserAllergy = new System.Windows.Forms.Label();
            this.txtUserAllergyNotes = new System.Windows.Forms.TextBox();
            this.splitContainerUsers = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.flowUserButtons.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            this.tableUserDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).BeginInit();
            this.splitContainerUsers.Panel1.SuspendLayout();
            this.splitContainerUsers.Panel2.SuspendLayout();
            this.splitContainerUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageUserAllergies
            // 
            this.btnManageUserAllergies.Location = new System.Drawing.Point(122, 10);
            this.btnManageUserAllergies.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnManageUserAllergies.Name = "btnManageUserAllergies";
            this.btnManageUserAllergies.Size = new System.Drawing.Size(134, 30);
            this.btnManageUserAllergies.TabIndex = 2;
            this.btnManageUserAllergies.Text = "알레르기 등록";
            this.btnManageUserAllergies.UseVisualStyleBackColor = true;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(412, 10);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(145, 30);
            this.btnRegisterUser.TabIndex = 0;
            this.btnRegisterUser.Text = "이용자 등록";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(267, 10);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(134, 30);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "이용자 수정";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 27;
            this.dgvUsers.Size = new System.Drawing.Size(589, 476);
            this.dgvUsers.TabIndex = 0;
            // 
            // flowUserButtons
            // 
            this.flowUserButtons.AutoSize = true;
            this.tableUserDetail.SetColumnSpan(this.flowUserButtons, 2);
            this.flowUserButtons.Controls.Add(this.btnRegisterUser);
            this.flowUserButtons.Controls.Add(this.btnUpdateUser);
            this.flowUserButtons.Controls.Add(this.btnManageUserAllergies);
            this.flowUserButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowUserButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowUserButtons.Location = new System.Drawing.Point(4, 206);
            this.flowUserButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowUserButtons.Name = "flowUserButtons";
            this.flowUserButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowUserButtons.Size = new System.Drawing.Size(557, 42);
            this.flowUserButtons.TabIndex = 8;
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.Controls.Add(this.tableUserDetail);
            this.grpUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDetail.Location = new System.Drawing.Point(0, 0);
            this.grpUserDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpUserDetail.Size = new System.Drawing.Size(573, 476);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "이용자 정보";
            // 
            // tableUserDetail
            // 
            this.tableUserDetail.ColumnCount = 2;
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Controls.Add(this.lblUserName, 0, 0);
            this.tableUserDetail.Controls.Add(this.txtUserName, 1, 0);
            this.tableUserDetail.Controls.Add(this.lblUserGrade, 0, 1);
            this.tableUserDetail.Controls.Add(this.txtUserGrade, 1, 1);
            this.tableUserDetail.Controls.Add(this.lblUserClass, 0, 2);
            this.tableUserDetail.Controls.Add(this.txtUserClass, 1, 2);
            this.tableUserDetail.Controls.Add(this.lblUserAllergy, 0, 3);
            this.tableUserDetail.Controls.Add(this.txtUserAllergyNotes, 1, 3);
            this.tableUserDetail.Controls.Add(this.flowUserButtons, 0, 4);
            this.tableUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUserDetail.Location = new System.Drawing.Point(4, 23);
            this.tableUserDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableUserDetail.Name = "tableUserDetail";
            this.tableUserDetail.RowCount = 5;
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Size = new System.Drawing.Size(565, 451);
            this.tableUserDetail.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(4, 0);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(123, 34);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "이름";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(135, 2);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(426, 28);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserGrade
            // 
            this.lblUserGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserGrade.Location = new System.Drawing.Point(4, 34);
            this.lblUserGrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserGrade.Name = "lblUserGrade";
            this.lblUserGrade.Size = new System.Drawing.Size(123, 34);
            this.lblUserGrade.TabIndex = 2;
            this.lblUserGrade.Text = "학년";
            this.lblUserGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserGrade
            // 
            this.txtUserGrade.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUserGrade.Location = new System.Drawing.Point(135, 36);
            this.txtUserGrade.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserGrade.Name = "txtUserGrade";
            this.txtUserGrade.Size = new System.Drawing.Size(109, 28);
            this.txtUserGrade.TabIndex = 3;
            // 
            // lblUserClass
            // 
            this.lblUserClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserClass.Location = new System.Drawing.Point(4, 68);
            this.lblUserClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserClass.Name = "lblUserClass";
            this.lblUserClass.Size = new System.Drawing.Size(123, 34);
            this.lblUserClass.TabIndex = 4;
            this.lblUserClass.Text = "반 / 번호";
            this.lblUserClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserClass
            // 
            this.txtUserClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtUserClass.Location = new System.Drawing.Point(135, 70);
            this.txtUserClass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserClass.Name = "txtUserClass";
            this.txtUserClass.Size = new System.Drawing.Size(164, 28);
            this.txtUserClass.TabIndex = 5;
            // 
            // lblUserAllergy
            // 
            this.lblUserAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserAllergy.Location = new System.Drawing.Point(4, 102);
            this.lblUserAllergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserAllergy.Name = "lblUserAllergy";
            this.lblUserAllergy.Size = new System.Drawing.Size(123, 102);
            this.lblUserAllergy.TabIndex = 6;
            this.lblUserAllergy.Text = "알레르기 참고";
            this.lblUserAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserAllergyNotes
            // 
            this.txtUserAllergyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAllergyNotes.Location = new System.Drawing.Point(135, 104);
            this.txtUserAllergyNotes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserAllergyNotes.Multiline = true;
            this.txtUserAllergyNotes.Name = "txtUserAllergyNotes";
            this.txtUserAllergyNotes.Size = new System.Drawing.Size(426, 98);
            this.txtUserAllergyNotes.TabIndex = 7;
            // 
            // splitContainerUsers
            // 
            this.splitContainerUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUsers.Location = new System.Drawing.Point(4, 2);
            this.splitContainerUsers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerUsers.Name = "splitContainerUsers";
            // 
            // splitContainerUsers.Panel1
            // 
            this.splitContainerUsers.Panel1.Controls.Add(this.dgvUsers);
            // 
            // splitContainerUsers.Panel2
            // 
            this.splitContainerUsers.Panel2.Controls.Add(this.grpUserDetail);
            this.splitContainerUsers.Size = new System.Drawing.Size(1167, 476);
            this.splitContainerUsers.SplitterDistance = 589;
            this.splitContainerUsers.SplitterWidth = 5;
            this.splitContainerUsers.TabIndex = 0;
            // 
            // UsersTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "UsersTabPage";
            this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Size = new System.Drawing.Size(1175, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.flowUserButtons.ResumeLayout(false);
            this.grpUserDetail.ResumeLayout(false);
            this.tableUserDetail.ResumeLayout(false);
            this.tableUserDetail.PerformLayout();
            this.splitContainerUsers.Panel1.ResumeLayout(false);
            this.splitContainerUsers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).EndInit();
            this.splitContainerUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.Button btnManageUserAllergies;
        internal System.Windows.Forms.Button btnRegisterUser;
        internal System.Windows.Forms.Button btnUpdateUser;
        internal System.Windows.Forms.DataGridView dgvUsers;
        internal System.Windows.Forms.FlowLayoutPanel flowUserButtons;
        internal System.Windows.Forms.GroupBox grpUserDetail;
        internal System.Windows.Forms.Label lblUserAllergy;
        internal System.Windows.Forms.Label lblUserClass;
        internal System.Windows.Forms.Label lblUserGrade;
        internal System.Windows.Forms.Label lblUserName;
        internal System.Windows.Forms.SplitContainer splitContainerUsers;
        internal System.Windows.Forms.TableLayoutPanel tableUserDetail;
        internal System.Windows.Forms.TextBox txtUserAllergyNotes;
        internal System.Windows.Forms.TextBox txtUserClass;
        internal System.Windows.Forms.TextBox txtUserGrade;
        internal System.Windows.Forms.TextBox txtUserName;
    }
}
