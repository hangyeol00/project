namespace nutritionist.Tabs.Management
{
    partial class AllergiesTabPage
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
            this.btnRegisterAllergy = new System.Windows.Forms.Button();
            this.btnUpdateAllergy = new System.Windows.Forms.Button();
            this.dgvAllergies = new System.Windows.Forms.DataGridView();
            this.flowAllergyButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.grpAllergyDetail = new System.Windows.Forms.GroupBox();
            this.tableAllergyDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllergyCode = new System.Windows.Forms.Label();
            this.txtAllergyCode = new System.Windows.Forms.TextBox();
            this.lblAllergyName = new System.Windows.Forms.Label();
            this.txtAllergyName = new System.Windows.Forms.TextBox();
            this.lblAllergyDescription = new System.Windows.Forms.Label();
            this.txtAllergyDescription = new System.Windows.Forms.TextBox();
            this.splitContainerAllergies = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).BeginInit();
            this.flowAllergyButtons.SuspendLayout();
            this.grpAllergyDetail.SuspendLayout();
            this.tableAllergyDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).BeginInit();
            this.splitContainerAllergies.Panel1.SuspendLayout();
            this.splitContainerAllergies.Panel2.SuspendLayout();
            this.splitContainerAllergies.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegisterAllergy
            // 
            this.btnRegisterAllergy.Location = new System.Drawing.Point(423, 10);
            this.btnRegisterAllergy.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnRegisterAllergy.Name = "btnRegisterAllergy";
            this.btnRegisterAllergy.Size = new System.Drawing.Size(134, 30);
            this.btnRegisterAllergy.TabIndex = 0;
            this.btnRegisterAllergy.Text = "알레르기 등록";
            this.btnRegisterAllergy.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAllergy
            // 
            this.btnUpdateAllergy.Location = new System.Drawing.Point(290, 10);
            this.btnUpdateAllergy.Margin = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.btnUpdateAllergy.Name = "btnUpdateAllergy";
            this.btnUpdateAllergy.Size = new System.Drawing.Size(122, 30);
            this.btnUpdateAllergy.TabIndex = 1;
            this.btnUpdateAllergy.Text = "알레르기 수정";
            this.btnUpdateAllergy.UseVisualStyleBackColor = true;
            // 
            // dgvAllergies
            // 
            this.dgvAllergies.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergies.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvAllergies.Name = "dgvAllergies";
            this.dgvAllergies.RowHeadersWidth = 51;
            this.dgvAllergies.RowTemplate.Height = 27;
            this.dgvAllergies.Size = new System.Drawing.Size(589, 476);
            this.dgvAllergies.TabIndex = 0;
            // 
            // flowAllergyButtons
            // 
            this.flowAllergyButtons.AutoSize = true;
            this.tableAllergyDetail.SetColumnSpan(this.flowAllergyButtons, 2);
            this.flowAllergyButtons.Controls.Add(this.btnRegisterAllergy);
            this.flowAllergyButtons.Controls.Add(this.btnUpdateAllergy);
            this.flowAllergyButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowAllergyButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowAllergyButtons.Location = new System.Drawing.Point(4, 172);
            this.flowAllergyButtons.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowAllergyButtons.Name = "flowAllergyButtons";
            this.flowAllergyButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowAllergyButtons.Size = new System.Drawing.Size(557, 42);
            this.flowAllergyButtons.TabIndex = 6;
            // 
            // grpAllergyDetail
            // 
            this.grpAllergyDetail.Controls.Add(this.tableAllergyDetail);
            this.grpAllergyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpAllergyDetail.Name = "grpAllergyDetail";
            this.grpAllergyDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpAllergyDetail.Size = new System.Drawing.Size(573, 476);
            this.grpAllergyDetail.TabIndex = 0;
            this.grpAllergyDetail.TabStop = false;
            this.grpAllergyDetail.Text = "알레르기 정보";
            // 
            // tableAllergyDetail
            // 
            this.tableAllergyDetail.ColumnCount = 2;
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Controls.Add(this.lblAllergyCode, 0, 0);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyCode, 1, 0);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyName, 0, 1);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyName, 1, 1);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyDescription, 0, 2);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyDescription, 1, 2);
            this.tableAllergyDetail.Controls.Add(this.flowAllergyButtons, 0, 3);
            this.tableAllergyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAllergyDetail.Location = new System.Drawing.Point(4, 23);
            this.tableAllergyDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableAllergyDetail.Name = "tableAllergyDetail";
            this.tableAllergyDetail.RowCount = 4;
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Size = new System.Drawing.Size(565, 451);
            this.tableAllergyDetail.TabIndex = 0;
            // 
            // lblAllergyCode
            // 
            this.lblAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyCode.Location = new System.Drawing.Point(4, 0);
            this.lblAllergyCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergyCode.Name = "lblAllergyCode";
            this.lblAllergyCode.Size = new System.Drawing.Size(123, 34);
            this.lblAllergyCode.TabIndex = 0;
            this.lblAllergyCode.Text = "코드";
            this.lblAllergyCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyCode
            // 
            this.txtAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyCode.Location = new System.Drawing.Point(135, 2);
            this.txtAllergyCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAllergyCode.Name = "txtAllergyCode";
            this.txtAllergyCode.Size = new System.Drawing.Size(426, 28);
            this.txtAllergyCode.TabIndex = 1;
            // 
            // lblAllergyName
            // 
            this.lblAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyName.Location = new System.Drawing.Point(4, 34);
            this.lblAllergyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergyName.Name = "lblAllergyName";
            this.lblAllergyName.Size = new System.Drawing.Size(123, 34);
            this.lblAllergyName.TabIndex = 2;
            this.lblAllergyName.Text = "알레르기명";
            this.lblAllergyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyName
            // 
            this.txtAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyName.Location = new System.Drawing.Point(135, 36);
            this.txtAllergyName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAllergyName.Name = "txtAllergyName";
            this.txtAllergyName.Size = new System.Drawing.Size(426, 28);
            this.txtAllergyName.TabIndex = 3;
            // 
            // lblAllergyDescription
            // 
            this.lblAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyDescription.Location = new System.Drawing.Point(4, 68);
            this.lblAllergyDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergyDescription.Name = "lblAllergyDescription";
            this.lblAllergyDescription.Size = new System.Drawing.Size(123, 102);
            this.lblAllergyDescription.TabIndex = 4;
            this.lblAllergyDescription.Text = "비고";
            this.lblAllergyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyDescription
            // 
            this.txtAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyDescription.Location = new System.Drawing.Point(135, 70);
            this.txtAllergyDescription.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtAllergyDescription.Multiline = true;
            this.txtAllergyDescription.Name = "txtAllergyDescription";
            this.txtAllergyDescription.Size = new System.Drawing.Size(426, 98);
            this.txtAllergyDescription.TabIndex = 5;
            // 
            // splitContainerAllergies
            // 
            this.splitContainerAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergies.Location = new System.Drawing.Point(4, 2);
            this.splitContainerAllergies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerAllergies.Name = "splitContainerAllergies";
            // 
            // splitContainerAllergies.Panel1
            // 
            this.splitContainerAllergies.Panel1.Controls.Add(this.dgvAllergies);
            // 
            // splitContainerAllergies.Panel2
            // 
            this.splitContainerAllergies.Panel2.Controls.Add(this.grpAllergyDetail);
            this.splitContainerAllergies.Size = new System.Drawing.Size(1167, 476);
            this.splitContainerAllergies.SplitterDistance = 589;
            this.splitContainerAllergies.SplitterWidth = 5;
            this.splitContainerAllergies.TabIndex = 0;
            // 
            // AllergiesTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerAllergies);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "AllergiesTabPage";
            this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Size = new System.Drawing.Size(1175, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).EndInit();
            this.flowAllergyButtons.ResumeLayout(false);
            this.grpAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.PerformLayout();
            this.splitContainerAllergies.Panel1.ResumeLayout(false);
            this.splitContainerAllergies.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).EndInit();
            this.splitContainerAllergies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.Button btnRegisterAllergy;
        internal System.Windows.Forms.Button btnUpdateAllergy;
        internal System.Windows.Forms.DataGridView dgvAllergies;
        internal System.Windows.Forms.FlowLayoutPanel flowAllergyButtons;
        internal System.Windows.Forms.GroupBox grpAllergyDetail;
        internal System.Windows.Forms.Label lblAllergyCode;
        internal System.Windows.Forms.Label lblAllergyDescription;
        internal System.Windows.Forms.Label lblAllergyName;
        internal System.Windows.Forms.SplitContainer splitContainerAllergies;
        internal System.Windows.Forms.TableLayoutPanel tableAllergyDetail;
        internal System.Windows.Forms.TextBox txtAllergyCode;
        internal System.Windows.Forms.TextBox txtAllergyDescription;
        internal System.Windows.Forms.TextBox txtAllergyName;
    }
}
