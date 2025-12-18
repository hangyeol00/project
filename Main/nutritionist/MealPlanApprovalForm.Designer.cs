namespace nutritionist
{
    partial class MealPlanApprovalForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dgvMealPlans = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.tableDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.tableDetail.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dgvMealPlans);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer.Size = new System.Drawing.Size(954, 487);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvMealPlans
            // 
            this.dgvMealPlans.AllowUserToAddRows = false;
            this.dgvMealPlans.AllowUserToDeleteRows = false;
            this.dgvMealPlans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMealPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvMealPlans.MultiSelect = false;
            this.dgvMealPlans.Name = "dgvMealPlans";
            this.dgvMealPlans.ReadOnly = true;
            this.dgvMealPlans.RowHeadersWidth = 51;
            this.dgvMealPlans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealPlans.Size = new System.Drawing.Size(600, 487);
            this.dgvMealPlans.TabIndex = 0;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.tableDetail);
            this.grpDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDetail.Location = new System.Drawing.Point(0, 0);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Padding = new System.Windows.Forms.Padding(10);
            this.grpDetail.Size = new System.Drawing.Size(350, 487);
            this.grpDetail.TabIndex = 0;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "식단 계획 상세";
            // 
            // tableDetail
            // 
            this.tableDetail.ColumnCount = 2;
            this.tableDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDetail.Controls.Add(this.lblPlanName, 0, 0);
            this.tableDetail.Controls.Add(this.txtPlanName, 1, 0);
            this.tableDetail.Controls.Add(this.lblDetails, 0, 1);
            this.tableDetail.Controls.Add(this.txtDetails, 1, 1);
            this.tableDetail.Controls.Add(this.flowButtons, 0, 2);
            this.tableDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDetail.Location = new System.Drawing.Point(10, 23);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.RowCount = 3;
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDetail.Size = new System.Drawing.Size(330, 454);
            this.tableDetail.TabIndex = 0;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanName.Location = new System.Drawing.Point(3, 0);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(94, 35);
            this.lblPlanName.TabIndex = 0;
            this.lblPlanName.Text = "계획명:";
            this.lblPlanName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlanName
            // 
            this.txtPlanName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlanName.Location = new System.Drawing.Point(103, 3);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(224, 21);
            this.txtPlanName.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Location = new System.Drawing.Point(3, 35);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(94, 100);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "상세정보:";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetails.Location = new System.Drawing.Point(103, 38);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(224, 94);
            this.txtDetails.TabIndex = 3;
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.tableDetail.SetColumnSpan(this.flowButtons, 2);
            this.flowButtons.Controls.Add(this.btnApprove);
            this.flowButtons.Controls.Add(this.btnReject);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(3, 138);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowButtons.Size = new System.Drawing.Size(324, 40);
            this.flowButtons.TabIndex = 4;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(246, 13);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "승인";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(165, 13);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "거부";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // MealPlanApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealPlanApprovalForm";
            this.Text = "식단 계획 승인";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealPlans)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.tableDetail.ResumeLayout(false);
            this.tableDetail.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvMealPlans;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TableLayoutPanel tableDetail;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}

