namespace nutritionist
{
    partial class AllergyRelationsForm
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
            this.splitContainerAllergyRelations = new System.Windows.Forms.SplitContainer();
            this.dgvAllergyRelations = new System.Windows.Forms.DataGridView();
            this.grpAllergyRelationDetail = new System.Windows.Forms.GroupBox();
            this.tableAllergyRelationDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRelationUser = new System.Windows.Forms.Label();
            this.cmbRelationUser = new System.Windows.Forms.ComboBox();
            this.lblRelationAllergy = new System.Windows.Forms.Label();
            this.cmbRelationAllergy = new System.Windows.Forms.ComboBox();
            this.lblRelationNotes = new System.Windows.Forms.Label();
            this.txtRelationNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).BeginInit();
            this.splitContainerAllergyRelations.Panel1.SuspendLayout();
            this.splitContainerAllergyRelations.Panel2.SuspendLayout();
            this.splitContainerAllergyRelations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).BeginInit();
            this.grpAllergyRelationDetail.SuspendLayout();
            this.tableAllergyRelationDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAllergyRelations
            // 
            this.splitContainerAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergyRelations.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAllergyRelations.Name = "splitContainerAllergyRelations";
            // 
            // splitContainerAllergyRelations.Panel1
            // 
            this.splitContainerAllergyRelations.Panel1.Controls.Add(this.dgvAllergyRelations);
            // 
            // splitContainerAllergyRelations.Panel2
            // 
            this.splitContainerAllergyRelations.Panel2.Controls.Add(this.grpAllergyRelationDetail);
            this.splitContainerAllergyRelations.Size = new System.Drawing.Size(954, 487);
            this.splitContainerAllergyRelations.SplitterDistance = 477;
            this.splitContainerAllergyRelations.TabIndex = 0;
            // 
            // dgvAllergyRelations
            // 
            this.dgvAllergyRelations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergyRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergyRelations.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergyRelations.Name = "dgvAllergyRelations";
            this.dgvAllergyRelations.RowHeadersWidth = 51;
            this.dgvAllergyRelations.RowTemplate.Height = 27;
            this.dgvAllergyRelations.Size = new System.Drawing.Size(477, 487);
            this.dgvAllergyRelations.TabIndex = 0;
            // 
            // grpAllergyRelationDetail
            // 
            this.grpAllergyRelationDetail.Controls.Add(this.tableAllergyRelationDetail);
            this.grpAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyRelationDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyRelationDetail.Name = "grpAllergyRelationDetail";
            this.grpAllergyRelationDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyRelationDetail.Size = new System.Drawing.Size(473, 487);
            this.grpAllergyRelationDetail.TabIndex = 0;
            this.grpAllergyRelationDetail.TabStop = false;
            this.grpAllergyRelationDetail.Text = "알레르기 관계 상세";
            // 
            // tableAllergyRelationDetail
            // 
            this.tableAllergyRelationDetail.ColumnCount = 2;
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationUser, 0, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationUser, 1, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationAllergy, 0, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationAllergy, 1, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationNotes, 0, 2);
            this.tableAllergyRelationDetail.Controls.Add(this.txtRelationNotes, 1, 2);
            this.tableAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableAllergyRelationDetail.Location = new System.Drawing.Point(3, 20);
            this.tableAllergyRelationDetail.Name = "tableAllergyRelationDetail";
            this.tableAllergyRelationDetail.RowCount = 3;
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyRelationDetail.Size = new System.Drawing.Size(467, 108);
            this.tableAllergyRelationDetail.TabIndex = 0;
            // 
            // lblRelationUser
            // 
            this.lblRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationUser.Location = new System.Drawing.Point(3, 0);
            this.lblRelationUser.Name = "lblRelationUser";
            this.lblRelationUser.Size = new System.Drawing.Size(114, 36);
            this.lblRelationUser.TabIndex = 0;
            this.lblRelationUser.Text = "사용자";
            this.lblRelationUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationUser
            // 
            this.cmbRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationUser.FormattingEnabled = true;
            this.cmbRelationUser.Location = new System.Drawing.Point(123, 2);
            this.cmbRelationUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationUser.Name = "cmbRelationUser";
            this.cmbRelationUser.Size = new System.Drawing.Size(341, 25);
            this.cmbRelationUser.TabIndex = 1;
            // 
            // lblRelationAllergy
            // 
            this.lblRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationAllergy.Location = new System.Drawing.Point(3, 36);
            this.lblRelationAllergy.Name = "lblRelationAllergy";
            this.lblRelationAllergy.Size = new System.Drawing.Size(114, 36);
            this.lblRelationAllergy.TabIndex = 2;
            this.lblRelationAllergy.Text = "알레르기";
            this.lblRelationAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationAllergy
            // 
            this.cmbRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationAllergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelationAllergy.FormattingEnabled = true;
            this.cmbRelationAllergy.Location = new System.Drawing.Point(123, 38);
            this.cmbRelationAllergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationAllergy.Name = "cmbRelationAllergy";
            this.cmbRelationAllergy.Size = new System.Drawing.Size(341, 25);
            this.cmbRelationAllergy.TabIndex = 3;
            // 
            // lblRelationNotes
            // 
            this.lblRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationNotes.Location = new System.Drawing.Point(3, 72);
            this.lblRelationNotes.Name = "lblRelationNotes";
            this.lblRelationNotes.Size = new System.Drawing.Size(114, 36);
            this.lblRelationNotes.TabIndex = 4;
            this.lblRelationNotes.Text = "비고";
            this.lblRelationNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRelationNotes
            // 
            this.txtRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelationNotes.Location = new System.Drawing.Point(123, 74);
            this.txtRelationNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRelationNotes.Name = "txtRelationNotes";
            this.txtRelationNotes.ReadOnly = true;
            this.txtRelationNotes.Size = new System.Drawing.Size(341, 25);
            this.txtRelationNotes.TabIndex = 5;
            // 
            // AllergyRelationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerAllergyRelations);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllergyRelationsForm";
            this.Text = "AllergyRelationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).EndInit();
            this.splitContainerAllergyRelations.Panel1.ResumeLayout(false);
            this.splitContainerAllergyRelations.Panel2.ResumeLayout(false);
            this.splitContainerAllergyRelations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).EndInit();
            this.grpAllergyRelationDetail.ResumeLayout(false);
            this.tableAllergyRelationDetail.ResumeLayout(false);
            this.tableAllergyRelationDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAllergyRelations;
        private System.Windows.Forms.DataGridView dgvAllergyRelations;
        private System.Windows.Forms.GroupBox grpAllergyRelationDetail;
        private System.Windows.Forms.TableLayoutPanel tableAllergyRelationDetail;
        private System.Windows.Forms.Label lblRelationUser;
        private System.Windows.Forms.ComboBox cmbRelationUser;
        private System.Windows.Forms.Label lblRelationAllergy;
        private System.Windows.Forms.ComboBox cmbRelationAllergy;
        private System.Windows.Forms.Label lblRelationNotes;
        private System.Windows.Forms.TextBox txtRelationNotes;
    }
}

