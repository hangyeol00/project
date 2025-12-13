namespace nutritionist.Tabs.Management
{
    partial class AllergyRelationsTabPage
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
            this.btnLinkAllergy = new System.Windows.Forms.Button();
            this.btnRemoveAllergy = new System.Windows.Forms.Button();
            this.cmbRelationAllergy = new System.Windows.Forms.ComboBox();
            this.cmbRelationUser = new System.Windows.Forms.ComboBox();
            this.dgvAllergyRelations = new System.Windows.Forms.DataGridView();
            this.flowRelationButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grpAllergyRelationDetail = new System.Windows.Forms.GroupBox();
            this.lblRelationAllergy = new System.Windows.Forms.Label();
            this.lblRelationNotes = new System.Windows.Forms.Label();
            this.lblRelationUser = new System.Windows.Forms.Label();
            this.splitContainerAllergyRelations = new System.Windows.Forms.SplitContainer();
            this.tableAllergyRelationDetail = new System.Windows.Forms.TableLayoutPanel();
            this.txtRelationNotes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).BeginInit();
            this.SuspendLayout();
            // AllergyRelationsTabPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerAllergyRelations);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllergyRelationsTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
            // 
            // splitContainerAllergyRelations
            // 
            this.splitContainerAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergyRelations.Location = new System.Drawing.Point(3, 2);
            this.splitContainerAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerAllergyRelations.Name = "splitContainerAllergyRelations";
            // 
            // splitContainerAllergyRelations.Panel1
            // 
            this.splitContainerAllergyRelations.Panel1.Controls.Add(this.dgvAllergyRelations);
            // 
            // splitContainerAllergyRelations.Panel2
            // 
            this.splitContainerAllergyRelations.Panel2.Controls.Add(this.grpAllergyRelationDetail);
            this.splitContainerAllergyRelations.Size = new System.Drawing.Size(934, 449);
            this.splitContainerAllergyRelations.SplitterDistance = 472;
            this.splitContainerAllergyRelations.TabIndex = 0;
            // 
            // dgvAllergyRelations
            // 
            this.dgvAllergyRelations.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergyRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergyRelations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergyRelations.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergyRelations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllergyRelations.Name = "dgvAllergyRelations";
            this.dgvAllergyRelations.RowHeadersWidth = 51;
            this.dgvAllergyRelations.RowTemplate.Height = 27;
            this.dgvAllergyRelations.Size = new System.Drawing.Size(472, 449);
            this.dgvAllergyRelations.TabIndex = 0;
            // 
            // grpAllergyRelationDetail
            // 
            this.grpAllergyRelationDetail.Controls.Add(this.tableAllergyRelationDetail);
            this.grpAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyRelationDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyRelationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyRelationDetail.Name = "grpAllergyRelationDetail";
            this.grpAllergyRelationDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyRelationDetail.Size = new System.Drawing.Size(458, 449);
            this.grpAllergyRelationDetail.TabIndex = 0;
            this.grpAllergyRelationDetail.TabStop = false;
            this.grpAllergyRelationDetail.Text = "알레르기 연결";
            // 
            // tableAllergyRelationDetail
            // 
            this.tableAllergyRelationDetail.ColumnCount = 2;
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableAllergyRelationDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationUser, 0, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationUser, 1, 0);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationAllergy, 0, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.cmbRelationAllergy, 1, 1);
            this.tableAllergyRelationDetail.Controls.Add(this.lblRelationNotes, 0, 2);
            this.tableAllergyRelationDetail.Controls.Add(this.txtRelationNotes, 1, 2);
            this.tableAllergyRelationDetail.Controls.Add(this.flowRelationButtons, 0, 3);
            this.tableAllergyRelationDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllergyRelationDetail.Location = new System.Drawing.Point(3, 20);
            this.tableAllergyRelationDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableAllergyRelationDetail.Name = "tableAllergyRelationDetail";
            this.tableAllergyRelationDetail.RowCount = 4;
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableAllergyRelationDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyRelationDetail.Size = new System.Drawing.Size(452, 427);
            this.tableAllergyRelationDetail.TabIndex = 0;
            // 
            // lblRelationUser
            // 
            this.lblRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationUser.Location = new System.Drawing.Point(3, 0);
            this.lblRelationUser.Name = "lblRelationUser";
            this.lblRelationUser.Size = new System.Drawing.Size(99, 32);
            this.lblRelationUser.TabIndex = 0;
            this.lblRelationUser.Text = "이용자";
            this.lblRelationUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationUser
            // 
            this.cmbRelationUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationUser.FormattingEnabled = true;
            this.cmbRelationUser.Location = new System.Drawing.Point(108, 2);
            this.cmbRelationUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationUser.Name = "cmbRelationUser";
            this.cmbRelationUser.Size = new System.Drawing.Size(341, 25);
            this.cmbRelationUser.TabIndex = 1;
            // 
            // lblRelationAllergy
            // 
            this.lblRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationAllergy.Location = new System.Drawing.Point(3, 32);
            this.lblRelationAllergy.Name = "lblRelationAllergy";
            this.lblRelationAllergy.Size = new System.Drawing.Size(99, 32);
            this.lblRelationAllergy.TabIndex = 2;
            this.lblRelationAllergy.Text = "알레르기";
            this.lblRelationAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbRelationAllergy
            // 
            this.cmbRelationAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbRelationAllergy.FormattingEnabled = true;
            this.cmbRelationAllergy.Location = new System.Drawing.Point(108, 34);
            this.cmbRelationAllergy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelationAllergy.Name = "cmbRelationAllergy";
            this.cmbRelationAllergy.Size = new System.Drawing.Size(341, 25);
            this.cmbRelationAllergy.TabIndex = 3;
            // 
            // lblRelationNotes
            // 
            this.lblRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRelationNotes.Location = new System.Drawing.Point(3, 64);
            this.lblRelationNotes.Name = "lblRelationNotes";
            this.lblRelationNotes.Size = new System.Drawing.Size(99, 96);
            this.lblRelationNotes.TabIndex = 4;
            this.lblRelationNotes.Text = "비고";
            this.lblRelationNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRelationNotes
            // 
            this.txtRelationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelationNotes.Location = new System.Drawing.Point(108, 66);
            this.txtRelationNotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRelationNotes.Multiline = true;
            this.txtRelationNotes.Name = "txtRelationNotes";
            this.txtRelationNotes.Size = new System.Drawing.Size(341, 92);
            this.txtRelationNotes.TabIndex = 5;
            // 
            // flowRelationButtons
            // 
            this.flowRelationButtons.AutoSize = true;
            this.tableAllergyRelationDetail.SetColumnSpan(this.flowRelationButtons, 2);
            this.flowRelationButtons.Controls.Add(this.btnLinkAllergy);
            this.flowRelationButtons.Controls.Add(this.btnRemoveAllergy);
            this.flowRelationButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRelationButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowRelationButtons.Location = new System.Drawing.Point(3, 162);
            this.flowRelationButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowRelationButtons.Name = "flowRelationButtons";
            this.flowRelationButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowRelationButtons.Size = new System.Drawing.Size(446, 40);
            this.flowRelationButtons.TabIndex = 6;
            // 
            // btnLinkAllergy
            // 
            this.btnLinkAllergy.Location = new System.Drawing.Point(339, 10);
            this.btnLinkAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnLinkAllergy.Name = "btnLinkAllergy";
            this.btnLinkAllergy.Size = new System.Drawing.Size(107, 28);
            this.btnLinkAllergy.TabIndex = 0;
            this.btnLinkAllergy.Text = "관계 등록";
            this.btnLinkAllergy.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllergy
            // 
            this.btnRemoveAllergy.Location = new System.Drawing.Point(232, 10);
            this.btnRemoveAllergy.Margin = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.btnRemoveAllergy.Name = "btnRemoveAllergy";
            this.btnRemoveAllergy.Size = new System.Drawing.Size(98, 28);
            this.btnRemoveAllergy.TabIndex = 1;
            this.btnRemoveAllergy.Text = "관계 삭제";
            this.btnRemoveAllergy.UseVisualStyleBackColor = true;
            // 
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergyRelations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergyRelations)).EndInit();
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal System.Windows.Forms.Button btnLinkAllergy;
        internal System.Windows.Forms.Button btnRemoveAllergy;
        internal System.Windows.Forms.ComboBox cmbRelationAllergy;
        internal System.Windows.Forms.ComboBox cmbRelationUser;
        internal System.Windows.Forms.DataGridView dgvAllergyRelations;
        internal System.Windows.Forms.FlowLayoutPanel flowRelationButtons;
        internal System.Windows.Forms.GroupBox grpAllergyRelationDetail;
        internal System.Windows.Forms.Label lblRelationAllergy;
        internal System.Windows.Forms.Label lblRelationNotes;
        internal System.Windows.Forms.Label lblRelationUser;
        internal System.Windows.Forms.SplitContainer splitContainerAllergyRelations;
        internal System.Windows.Forms.TableLayoutPanel tableAllergyRelationDetail;
        internal System.Windows.Forms.TextBox txtRelationNotes;
    }
}
