namespace nutritionist
{
    partial class NutrientsForm
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
            this.splitContainerNutrients = new System.Windows.Forms.SplitContainer();
            this.dgvNutrients = new System.Windows.Forms.DataGridView();
            this.grpNutrientDetail = new System.Windows.Forms.GroupBox();
            this.tableNutrientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblNutrientCode = new System.Windows.Forms.Label();
            this.txtNutrientCode = new System.Windows.Forms.TextBox();
            this.lblNutrientName = new System.Windows.Forms.Label();
            this.txtNutrientName = new System.Windows.Forms.TextBox();
            this.lblNutrientUnit = new System.Windows.Forms.Label();
            this.txtNutrientUnit = new System.Windows.Forms.TextBox();
            this.btnSearchNutrient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).BeginInit();
            this.splitContainerNutrients.Panel1.SuspendLayout();
            this.splitContainerNutrients.Panel2.SuspendLayout();
            this.splitContainerNutrients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).BeginInit();
            this.grpNutrientDetail.SuspendLayout();
            this.tableNutrientDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerNutrients
            // 
            this.splitContainerNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerNutrients.Location = new System.Drawing.Point(0, 0);
            this.splitContainerNutrients.Name = "splitContainerNutrients";
            // 
            // splitContainerNutrients.Panel1
            // 
            this.splitContainerNutrients.Panel1.Controls.Add(this.dgvNutrients);
            // 
            // splitContainerNutrients.Panel2
            // 
            this.splitContainerNutrients.Panel2.Controls.Add(this.grpNutrientDetail);
            this.splitContainerNutrients.Panel2Collapsed = true;
            this.splitContainerNutrients.Size = new System.Drawing.Size(954, 487);
            this.splitContainerNutrients.SplitterDistance = 477;
            this.splitContainerNutrients.TabIndex = 0;
            // 
            // dgvNutrients
            // 
            this.dgvNutrients.BackgroundColor = System.Drawing.Color.White;
            this.dgvNutrients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNutrients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNutrients.Location = new System.Drawing.Point(0, 0);
            this.dgvNutrients.Name = "dgvNutrients";
            this.dgvNutrients.RowHeadersWidth = 51;
            this.dgvNutrients.RowTemplate.Height = 27;
            this.dgvNutrients.Size = new System.Drawing.Size(954, 487);
            this.dgvNutrients.TabIndex = 0;
            // 
            // grpNutrientDetail
            // 
            this.grpNutrientDetail.Controls.Add(this.tableNutrientDetail);
            this.grpNutrientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNutrientDetail.Location = new System.Drawing.Point(0, 0);
            this.grpNutrientDetail.Name = "grpNutrientDetail";
            this.grpNutrientDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpNutrientDetail.Size = new System.Drawing.Size(96, 100);
            this.grpNutrientDetail.TabIndex = 0;
            this.grpNutrientDetail.TabStop = false;
            this.grpNutrientDetail.Text = "상세 정보";
            // 
            // tableNutrientDetail
            // 
            this.tableNutrientDetail.ColumnCount = 2;
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableNutrientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableNutrientDetail.Controls.Add(this.lblNutrientCode, 0, 0);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientCode, 1, 0);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientName, 0, 1);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientName, 1, 1);
            this.tableNutrientDetail.Controls.Add(this.lblNutrientUnit, 0, 2);
            this.tableNutrientDetail.Controls.Add(this.txtNutrientUnit, 1, 2);
            this.tableNutrientDetail.Controls.Add(this.btnSearchNutrient, 0, 3);
            this.tableNutrientDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableNutrientDetail.Location = new System.Drawing.Point(3, 25);
            this.tableNutrientDetail.Name = "tableNutrientDetail";
            this.tableNutrientDetail.RowCount = 4;
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableNutrientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableNutrientDetail.Size = new System.Drawing.Size(90, 144);
            this.tableNutrientDetail.TabIndex = 0;
            // 
            // lblNutrientCode
            // 
            this.lblNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientCode.Location = new System.Drawing.Point(3, 0);
            this.lblNutrientCode.Name = "lblNutrientCode";
            this.lblNutrientCode.Size = new System.Drawing.Size(114, 36);
            this.lblNutrientCode.TabIndex = 0;
            this.lblNutrientCode.Text = "영양소 코드";
            this.lblNutrientCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientCode
            // 
            this.txtNutrientCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientCode.Location = new System.Drawing.Point(123, 2);
            this.txtNutrientCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientCode.Name = "txtNutrientCode";
            this.txtNutrientCode.ReadOnly = true;
            this.txtNutrientCode.Size = new System.Drawing.Size(1, 30);
            this.txtNutrientCode.TabIndex = 1;
            // 
            // lblNutrientName
            // 
            this.lblNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientName.Location = new System.Drawing.Point(3, 36);
            this.lblNutrientName.Name = "lblNutrientName";
            this.lblNutrientName.Size = new System.Drawing.Size(114, 36);
            this.lblNutrientName.TabIndex = 2;
            this.lblNutrientName.Text = "영양소명";
            this.lblNutrientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientName
            // 
            this.txtNutrientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientName.Location = new System.Drawing.Point(123, 38);
            this.txtNutrientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientName.Name = "txtNutrientName";
            this.txtNutrientName.ReadOnly = true;
            this.txtNutrientName.Size = new System.Drawing.Size(1, 30);
            this.txtNutrientName.TabIndex = 3;
            // 
            // lblNutrientUnit
            // 
            this.lblNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNutrientUnit.Location = new System.Drawing.Point(3, 72);
            this.lblNutrientUnit.Name = "lblNutrientUnit";
            this.lblNutrientUnit.Size = new System.Drawing.Size(114, 36);
            this.lblNutrientUnit.TabIndex = 4;
            this.lblNutrientUnit.Text = "단위";
            this.lblNutrientUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNutrientUnit
            // 
            this.txtNutrientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNutrientUnit.Location = new System.Drawing.Point(123, 74);
            this.txtNutrientUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNutrientUnit.Name = "txtNutrientUnit";
            this.txtNutrientUnit.ReadOnly = true;
            this.txtNutrientUnit.Size = new System.Drawing.Size(1, 30);
            this.txtNutrientUnit.TabIndex = 5;
            // 
            // btnSearchNutrient
            // 
            this.tableNutrientDetail.SetColumnSpan(this.btnSearchNutrient, 2);
            this.btnSearchNutrient.Location = new System.Drawing.Point(3, 110);
            this.btnSearchNutrient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchNutrient.Name = "btnSearchNutrient";
            this.btnSearchNutrient.Size = new System.Drawing.Size(84, 28);
            this.btnSearchNutrient.TabIndex = 6;
            this.btnSearchNutrient.Text = "새로고침";
            this.btnSearchNutrient.UseVisualStyleBackColor = true;
            // 
            // NutrientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerNutrients);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NutrientsForm";
            this.Text = "NutrientsForm";
            this.splitContainerNutrients.Panel1.ResumeLayout(false);
            this.splitContainerNutrients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerNutrients)).EndInit();
            this.splitContainerNutrients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNutrients)).EndInit();
            this.grpNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.ResumeLayout(false);
            this.tableNutrientDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerNutrients;
        private System.Windows.Forms.DataGridView dgvNutrients;
        private System.Windows.Forms.GroupBox grpNutrientDetail;
        private System.Windows.Forms.TableLayoutPanel tableNutrientDetail;
        private System.Windows.Forms.Label lblNutrientCode;
        private System.Windows.Forms.TextBox txtNutrientCode;
        private System.Windows.Forms.Label lblNutrientName;
        private System.Windows.Forms.TextBox txtNutrientName;
        private System.Windows.Forms.Label lblNutrientUnit;
        private System.Windows.Forms.TextBox txtNutrientUnit;
        private System.Windows.Forms.Button btnSearchNutrient;
    }
}

