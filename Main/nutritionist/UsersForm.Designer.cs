namespace nutritionist
{
    partial class UsersForm
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
            this.splitContainerUsers = new System.Windows.Forms.SplitContainer();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).BeginInit();
            this.splitContainerUsers.Panel1.SuspendLayout();
            this.splitContainerUsers.Panel2.SuspendLayout();
            this.splitContainerUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.grpUserDetail.SuspendLayout();
            this.tableUserDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerUsers
            // 
            this.splitContainerUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUsers.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUsers.Name = "splitContainerUsers";
            // 
            // splitContainerUsers.Panel1
            // 
            this.splitContainerUsers.Panel1.Controls.Add(this.dgvUsers);
            // 
            // splitContainerUsers.Panel2
            // 
            this.splitContainerUsers.Panel2.Controls.Add(this.grpUserDetail);
            this.splitContainerUsers.Size = new System.Drawing.Size(954, 487);
            this.splitContainerUsers.SplitterDistance = 477;
            this.splitContainerUsers.TabIndex = 0;
            // 
            // dgvUsers
            // 
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 27;
            this.dgvUsers.Size = new System.Drawing.Size(477, 487);
            this.dgvUsers.TabIndex = 0;
            // 
            // grpUserDetail
            // 
            this.grpUserDetail.Controls.Add(this.tableUserDetail);
            this.grpUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDetail.Location = new System.Drawing.Point(0, 0);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUserDetail.Size = new System.Drawing.Size(473, 487);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "사용자 상세";
            // 
            // tableUserDetail
            // 
            this.tableUserDetail.ColumnCount = 2;
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableUserDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableUserDetail.Controls.Add(this.lblUserName, 0, 0);
            this.tableUserDetail.Controls.Add(this.txtUserName, 1, 0);
            this.tableUserDetail.Controls.Add(this.lblUserGrade, 0, 1);
            this.tableUserDetail.Controls.Add(this.txtUserGrade, 1, 1);
            this.tableUserDetail.Controls.Add(this.lblUserClass, 0, 2);
            this.tableUserDetail.Controls.Add(this.txtUserClass, 1, 2);
            this.tableUserDetail.Controls.Add(this.lblUserAllergy, 0, 3);
            this.tableUserDetail.Controls.Add(this.txtUserAllergyNotes, 1, 3);
            this.tableUserDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableUserDetail.Location = new System.Drawing.Point(3, 20);
            this.tableUserDetail.Name = "tableUserDetail";
            this.tableUserDetail.RowCount = 4;
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableUserDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableUserDetail.Size = new System.Drawing.Size(467, 144);
            this.tableUserDetail.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(3, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(114, 36);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "이름";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(123, 2);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(341, 25);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserGrade
            // 
            this.lblUserGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserGrade.Location = new System.Drawing.Point(3, 36);
            this.lblUserGrade.Name = "lblUserGrade";
            this.lblUserGrade.Size = new System.Drawing.Size(114, 36);
            this.lblUserGrade.TabIndex = 2;
            this.lblUserGrade.Text = "학년";
            this.lblUserGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserGrade
            // 
            this.txtUserGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserGrade.Location = new System.Drawing.Point(123, 38);
            this.txtUserGrade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserGrade.Name = "txtUserGrade";
            this.txtUserGrade.ReadOnly = true;
            this.txtUserGrade.Size = new System.Drawing.Size(341, 25);
            this.txtUserGrade.TabIndex = 3;
            // 
            // lblUserClass
            // 
            this.lblUserClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserClass.Location = new System.Drawing.Point(3, 72);
            this.lblUserClass.Name = "lblUserClass";
            this.lblUserClass.Size = new System.Drawing.Size(114, 36);
            this.lblUserClass.TabIndex = 4;
            this.lblUserClass.Text = "반";
            this.lblUserClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserClass
            // 
            this.txtUserClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserClass.Location = new System.Drawing.Point(123, 74);
            this.txtUserClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserClass.Name = "txtUserClass";
            this.txtUserClass.ReadOnly = true;
            this.txtUserClass.Size = new System.Drawing.Size(341, 25);
            this.txtUserClass.TabIndex = 5;
            // 
            // lblUserAllergy
            // 
            this.lblUserAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserAllergy.Location = new System.Drawing.Point(3, 108);
            this.lblUserAllergy.Name = "lblUserAllergy";
            this.lblUserAllergy.Size = new System.Drawing.Size(114, 36);
            this.lblUserAllergy.TabIndex = 6;
            this.lblUserAllergy.Text = "알레르기 정보";
            this.lblUserAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserAllergyNotes
            // 
            this.txtUserAllergyNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserAllergyNotes.Location = new System.Drawing.Point(123, 110);
            this.txtUserAllergyNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserAllergyNotes.Name = "txtUserAllergyNotes";
            this.txtUserAllergyNotes.ReadOnly = true;
            this.txtUserAllergyNotes.Size = new System.Drawing.Size(341, 25);
            this.txtUserAllergyNotes.TabIndex = 7;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerUsers);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUsers)).EndInit();
            this.splitContainerUsers.Panel1.ResumeLayout(false);
            this.splitContainerUsers.Panel2.ResumeLayout(false);
            this.splitContainerUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.grpUserDetail.ResumeLayout(false);
            this.tableUserDetail.ResumeLayout(false);
            this.tableUserDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.TableLayoutPanel tableUserDetail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserGrade;
        private System.Windows.Forms.TextBox txtUserGrade;
        private System.Windows.Forms.Label lblUserClass;
        private System.Windows.Forms.TextBox txtUserClass;
        private System.Windows.Forms.Label lblUserAllergy;
        private System.Windows.Forms.TextBox txtUserAllergyNotes;
    }
}

