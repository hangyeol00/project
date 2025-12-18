namespace nutritionist.Tabs.Management
{
    partial class NutrientsTabPage
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
            this.btnSearchNutrient = new System.Windows.Forms.Button();
            this.dgvNutrients = new System.Windows.Forms.DataGridView();
            this.grpNutrientDetail = new System.Windows.Forms.GroupBox();
            this.tableNutrientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblNutrientCode = new System.Windows.Forms.Label();
            this.txtNutrientCode = new System.Windows.Forms.TextBox();
            this.lblNutrientName = new System.Windows.Forms.Label();
            this.txtNutrientName = new System.Windows.Forms.TextBox();
            this.lblNutrientUnit = new System.Windows.Forms.Label();
            this.txtNutrientUnit = new System.Windows.Forms.TextBox();
            this.splitContainerNutrients = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).BeginInit();
            this.grpNutrientDetail.SuspendLayout();
            this.tableNutrientDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).BeginInit();
            this.splitContainerNutrients.Panel1.SuspendLayout();
            this.splitContainerNutrients.Panel2.SuspendLayout();
            this.splitContainerNutrients.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchNutrient
            // 
            this.btnSearchNutrient.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearchNutrient.Location = new System.Drawing.Point(446, 261);
            this.btnSearchNutrient.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearchNutrient.Name = "btnSearchNutrient";
            this.btnSearchNutrient.Size = new System.Drawing.Size(115, 30);
            this.btnSearchNutrient.TabIndex = 6;
            this.btnSearchNutrient.Text = "영양소 조회";
            this.btnSearchNutrient.UseVisualStyleBackColor = true;
            // 
            // dgvNutrients
            // 
            this.dgvNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNutrients.Location = new System.Drawing.Point(0, 0);
            this.dgvNutrients.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvNutrients.Name = "dgvNutrients";
            this.dgvNutrients.RowHeadersWidth = 51;
            this.dgvNutrients.RowTemplate.Height = 27;
            this.dgvNutrients.Size = new System.Drawing.Size(589, 476);
            this.dgvNutrients.TabIndex = 0;
            // 
            // grpNutrientDetail
            // 
            this.grpNutrientDetail.Controls.Add(this.tableNutrientDetail);
            this.grpNutrientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNutrientDetail.Location = new System.Drawing.Point(0, 0);
            this.grpNutrientDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNutrientDetail.Name = "grpNutrientDetail";
            this.grpNutrientDetail.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grpNutrientDetail.Size = new System.Drawing.Size(573, 476);
            this.grpNutrientDetail.TabIndex = 0;
            this.grpNutrientDetail.TabStop = false;
            this.grpNutrientDetail.Text = "영양소 정보";
            // 
            // tableNutrientDetail
            // 
            this.tableNutrientDetail.ColumnCount = 2;
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Controls.Add(this.lblNutrientCode, 0, 0);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientCode, 1, 0);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientName, 0, 1);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientName, 1, 1);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientUnit, 0, 2);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientUnit, 1, 2);
            this.tableNutrientDetail.Controls.Add(this.btnSearchNutrient, 1, 3);
            this.tableNutrientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableNutrientDetail.Location = new System.Drawing.Point(4, 23);
            this.tableNutrientDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tableNutrientDetail.Name = "tableNutrientDetail";
            this.tableNutrientDetail.RowCount = 4;
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Size = new System.Drawing.Size(565, 451);
            this.tableNutrientDetail.TabIndex = 0;
            // 
            // lblNutrientCode
            // 
            this.lblNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientCode.Location = new System.Drawing.Point(4, 0);
            this.lblNutrientCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutrientCode.Name = "lblNutrientCode";
            this.lblNutrientCode.Size = new System.Drawing.Size(123, 34);
            this.lblNutrientCode.TabIndex = 0;
            this.lblNutrientCode.Text = "영양소 코드";
            this.lblNutrientCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientCode
            // 
            this.txtNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientCode.Location = new System.Drawing.Point(135, 2);
            this.txtNutrientCode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNutrientCode.Name = "txtNutrientCode";
            this.txtNutrientCode.Size = new System.Drawing.Size(426, 28);
            this.txtNutrientCode.TabIndex = 1;
            // 
            // lblNutrientName
            // 
            this.lblNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientName.Location = new System.Drawing.Point(4, 34);
            this.lblNutrientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutrientName.Name = "lblNutrientName";
            this.lblNutrientName.Size = new System.Drawing.Size(123, 34);
            this.lblNutrientName.TabIndex = 2;
            this.lblNutrientName.Text = "영양소명";
            this.lblNutrientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientName
            // 
            this.txtNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientName.Location = new System.Drawing.Point(135, 36);
            this.txtNutrientName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNutrientName.Name = "txtNutrientName";
            this.txtNutrientName.Size = new System.Drawing.Size(426, 28);
            this.txtNutrientName.TabIndex = 3;
            // 
            // lblNutrientUnit
            // 
            this.lblNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientUnit.Location = new System.Drawing.Point(4, 68);
            this.lblNutrientUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNutrientUnit.Name = "lblNutrientUnit";
            this.lblNutrientUnit.Size = new System.Drawing.Size(123, 34);
            this.lblNutrientUnit.TabIndex = 4;
            this.lblNutrientUnit.Text = "측정 단위";
            this.lblNutrientUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientUnit
            // 
            this.txtNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientUnit.Location = new System.Drawing.Point(135, 70);
            this.txtNutrientUnit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNutrientUnit.Name = "txtNutrientUnit";
            this.txtNutrientUnit.Size = new System.Drawing.Size(426, 28);
            this.txtNutrientUnit.TabIndex = 5;
            // 
            // splitContainerNutrients
            // 
            this.splitContainerNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNutrients.Location = new System.Drawing.Point(4, 2);
            this.splitContainerNutrients.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.splitContainerNutrients.Name = "splitContainerNutrients";
            // 
            // splitContainerNutrients.Panel1
            // 
            this.splitContainerNutrients.Panel1.Controls.Add(this.dgvNutrients);
            // 
            // splitContainerNutrients.Panel2
            // 
            this.splitContainerNutrients.Panel2.Controls.Add(this.grpNutrientDetail);
            this.splitContainerNutrients.Size = new System.Drawing.Size(1167, 476);
            this.splitContainerNutrients.SplitterDistance = 589;
            this.splitContainerNutrients.SplitterWidth = 5;
            this.splitContainerNutrients.TabIndex = 0;
            // 
            // NutrientsTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitContainerNutrients);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "NutrientsTabPage";
            this.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Size = new System.Drawing.Size(1175, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).EndInit();
            this.grpNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.PerformLayout();
            this.splitContainerNutrients.Panel1.ResumeLayout(false);
            this.splitContainerNutrients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).EndInit();
            this.splitContainerNutrients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.Button btnSearchNutrient;
        internal System.Windows.Forms.DataGridView dgvNutrients;
        internal System.Windows.Forms.GroupBox grpNutrientDetail;
        internal System.Windows.Forms.Label lblNutrientCode;
        internal System.Windows.Forms.Label lblNutrientName;
        internal System.Windows.Forms.Label lblNutrientUnit;
        internal System.Windows.Forms.SplitContainer splitContainerNutrients;
        internal System.Windows.Forms.TableLayoutPanel tableNutrientDetail;
        internal System.Windows.Forms.TextBox txtNutrientCode;
        internal System.Windows.Forms.TextBox txtNutrientName;
        internal System.Windows.Forms.TextBox txtNutrientUnit;
    }
}
