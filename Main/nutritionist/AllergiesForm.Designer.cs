namespace nutritionist
{
    partial class AllergiesForm
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
            this.splitContainerAllergies = new System.Windows.Forms.SplitContainer();
            this.dgvAllergies = new System.Windows.Forms.DataGridView();
            this.grpAllergyDetail = new System.Windows.Forms.GroupBox();
            this.tableAllergyDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllergyCode = new System.Windows.Forms.Label();
            this.txtAllergyCode = new System.Windows.Forms.TextBox();
            this.lblAllergyName = new System.Windows.Forms.Label();
            this.txtAllergyName = new System.Windows.Forms.TextBox();
            this.lblAllergyDescription = new System.Windows.Forms.Label();
            this.txtAllergyDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).BeginInit();
            this.splitContainerAllergies.Panel1.SuspendLayout();
            this.splitContainerAllergies.Panel2.SuspendLayout();
            this.splitContainerAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).BeginInit();
            this.grpAllergyDetail.SuspendLayout();
            this.tableAllergyDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerAllergies
            // 
            this.splitContainerAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAllergies.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAllergies.Name = "splitContainerAllergies";
            // 
            // splitContainerAllergies.Panel1
            // 
            this.splitContainerAllergies.Panel1.Controls.Add(this.dgvAllergies);
            // 
            // splitContainerAllergies.Panel2
            // 
            this.splitContainerAllergies.Panel2.Controls.Add(this.grpAllergyDetail);
            this.splitContainerAllergies.Size = new System.Drawing.Size(954, 487);
            this.splitContainerAllergies.SplitterDistance = 477;
            this.splitContainerAllergies.TabIndex = 0;
            // 
            // dgvAllergies
            // 
            this.dgvAllergies.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllergies.Location = new System.Drawing.Point(0, 0);
            this.dgvAllergies.Name = "dgvAllergies";
            this.dgvAllergies.RowHeadersWidth = 51;
            this.dgvAllergies.RowTemplate.Height = 27;
            this.dgvAllergies.Size = new System.Drawing.Size(477, 487);
            this.dgvAllergies.TabIndex = 0;
            // 
            // grpAllergyDetail
            // 
            this.grpAllergyDetail.Controls.Add(this.tableAllergyDetail);
            this.grpAllergyDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAllergyDetail.Location = new System.Drawing.Point(0, 0);
            this.grpAllergyDetail.Name = "grpAllergyDetail";
            this.grpAllergyDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAllergyDetail.Size = new System.Drawing.Size(473, 487);
            this.grpAllergyDetail.TabIndex = 0;
            this.grpAllergyDetail.TabStop = false;
            this.grpAllergyDetail.Text = "알레르기 상세";
            // 
            // tableAllergyDetail
            // 
            this.tableAllergyDetail.ColumnCount = 2;
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAllergyDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAllergyDetail.Controls.Add(this.lblAllergyCode, 0, 0);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyCode, 1, 0);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyName, 0, 1);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyName, 1, 1);
            this.tableAllergyDetail.Controls.Add(this.lblAllergyDescription, 0, 2);
            this.tableAllergyDetail.Controls.Add(this.txtAllergyDescription, 1, 2);
            this.tableAllergyDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableAllergyDetail.Location = new System.Drawing.Point(3, 20);
            this.tableAllergyDetail.Name = "tableAllergyDetail";
            this.tableAllergyDetail.RowCount = 3;
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableAllergyDetail.Size = new System.Drawing.Size(467, 108);
            this.tableAllergyDetail.TabIndex = 0;
            // 
            // lblAllergyCode
            // 
            this.lblAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyCode.Location = new System.Drawing.Point(3, 0);
            this.lblAllergyCode.Name = "lblAllergyCode";
            this.lblAllergyCode.Size = new System.Drawing.Size(114, 36);
            this.lblAllergyCode.TabIndex = 0;
            this.lblAllergyCode.Text = "알레르기 코드";
            this.lblAllergyCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyCode
            // 
            this.txtAllergyCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyCode.Location = new System.Drawing.Point(123, 2);
            this.txtAllergyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyCode.Name = "txtAllergyCode";
            this.txtAllergyCode.ReadOnly = true;
            this.txtAllergyCode.Size = new System.Drawing.Size(341, 25);
            this.txtAllergyCode.TabIndex = 1;
            // 
            // lblAllergyName
            // 
            this.lblAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyName.Location = new System.Drawing.Point(3, 36);
            this.lblAllergyName.Name = "lblAllergyName";
            this.lblAllergyName.Size = new System.Drawing.Size(114, 36);
            this.lblAllergyName.TabIndex = 2;
            this.lblAllergyName.Text = "알레르기명";
            this.lblAllergyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyName
            // 
            this.txtAllergyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyName.Location = new System.Drawing.Point(123, 38);
            this.txtAllergyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyName.Name = "txtAllergyName";
            this.txtAllergyName.ReadOnly = true;
            this.txtAllergyName.Size = new System.Drawing.Size(341, 25);
            this.txtAllergyName.TabIndex = 3;
            // 
            // lblAllergyDescription
            // 
            this.lblAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyDescription.Location = new System.Drawing.Point(3, 72);
            this.lblAllergyDescription.Name = "lblAllergyDescription";
            this.lblAllergyDescription.Size = new System.Drawing.Size(114, 36);
            this.lblAllergyDescription.TabIndex = 4;
            this.lblAllergyDescription.Text = "설명";
            this.lblAllergyDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAllergyDescription
            // 
            this.txtAllergyDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllergyDescription.Location = new System.Drawing.Point(123, 74);
            this.txtAllergyDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAllergyDescription.Name = "txtAllergyDescription";
            this.txtAllergyDescription.ReadOnly = true;
            this.txtAllergyDescription.Size = new System.Drawing.Size(341, 25);
            this.txtAllergyDescription.TabIndex = 5;
            // 
            // AllergiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerAllergies);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllergiesForm";
            this.Text = "AllergiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAllergies)).EndInit();
            this.splitContainerAllergies.Panel1.ResumeLayout(false);
            this.splitContainerAllergies.Panel2.ResumeLayout(false);
            this.splitContainerAllergies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllergies)).EndInit();
            this.grpAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.ResumeLayout(false);
            this.tableAllergyDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerAllergies;
        private System.Windows.Forms.DataGridView dgvAllergies;
        private System.Windows.Forms.GroupBox grpAllergyDetail;
        private System.Windows.Forms.TableLayoutPanel tableAllergyDetail;
        private System.Windows.Forms.Label lblAllergyCode;
        private System.Windows.Forms.TextBox txtAllergyCode;
        private System.Windows.Forms.Label lblAllergyName;
        private System.Windows.Forms.TextBox txtAllergyName;
        private System.Windows.Forms.Label lblAllergyDescription;
        private System.Windows.Forms.TextBox txtAllergyDescription;
    }
}

