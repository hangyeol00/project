namespace nutritionist
{
    partial class PurchaseApprovalForm
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
            this.dgvPurchaseRequests = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.tableDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblRawName = new System.Windows.Forms.Label();
            this.txtRawName = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRequests)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.dgvPurchaseRequests);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grpDetail);
            this.splitContainer.Size = new System.Drawing.Size(954, 487);
            this.splitContainer.SplitterDistance = 600;
            this.splitContainer.TabIndex = 0;
            // 
            // dgvPurchaseRequests
            // 
            this.dgvPurchaseRequests.AllowUserToAddRows = false;
            this.dgvPurchaseRequests.AllowUserToDeleteRows = false;
            this.dgvPurchaseRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseRequests.Location = new System.Drawing.Point(0, 0);
            this.dgvPurchaseRequests.MultiSelect = false;
            this.dgvPurchaseRequests.Name = "dgvPurchaseRequests";
            this.dgvPurchaseRequests.ReadOnly = true;
            this.dgvPurchaseRequests.RowHeadersWidth = 51;
            this.dgvPurchaseRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseRequests.Size = new System.Drawing.Size(600, 487);
            this.dgvPurchaseRequests.TabIndex = 0;
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
            this.grpDetail.Text = "발주 요청 상세";
            // 
            // tableDetail
            // 
            this.tableDetail.ColumnCount = 2;
            this.tableDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDetail.Controls.Add(this.lblRawName, 0, 0);
            this.tableDetail.Controls.Add(this.txtRawName, 1, 0);
            this.tableDetail.Controls.Add(this.lblDetails, 0, 1);
            this.tableDetail.Controls.Add(this.txtDetails, 1, 1);
            this.tableDetail.Controls.Add(this.lblStatus, 0, 2);
            this.tableDetail.Controls.Add(this.txtStatus, 1, 2);
            this.tableDetail.Controls.Add(this.flowButtons, 0, 3);
            this.tableDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDetail.Location = new System.Drawing.Point(10, 23);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.RowCount = 4;
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableDetail.Size = new System.Drawing.Size(330, 454);
            this.tableDetail.TabIndex = 0;
            // 
            // lblRawName
            // 
            this.lblRawName.AutoSize = true;
            this.lblRawName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRawName.Location = new System.Drawing.Point(3, 0);
            this.lblRawName.Name = "lblRawName";
            this.lblRawName.Size = new System.Drawing.Size(94, 35);
            this.lblRawName.TabIndex = 0;
            this.lblRawName.Text = "원재료명:";
            this.lblRawName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRawName
            // 
            this.txtRawName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRawName.Location = new System.Drawing.Point(103, 3);
            this.txtRawName.Name = "txtRawName";
            this.txtRawName.Size = new System.Drawing.Size(224, 21);
            this.txtRawName.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.Location = new System.Drawing.Point(3, 35);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(94, 35);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "상세정보:";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDetails
            // 
            this.txtDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetails.Location = new System.Drawing.Point(103, 38);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(224, 21);
            this.txtDetails.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 70);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(94, 80);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "상태정보:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStatus
            // 
            this.txtStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStatus.Location = new System.Drawing.Point(103, 73);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(224, 74);
            this.txtStatus.TabIndex = 5;
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.tableDetail.SetColumnSpan(this.flowButtons, 2);
            this.flowButtons.Controls.Add(this.btnApprove);
            this.flowButtons.Controls.Add(this.btnReject);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(3, 153);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowButtons.Size = new System.Drawing.Size(324, 40);
            this.flowButtons.TabIndex = 6;
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
            // PurchaseApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseApprovalForm";
            this.Text = "발주 승인";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseRequests)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.tableDetail.ResumeLayout(false);
            this.tableDetail.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dgvPurchaseRequests;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.TableLayoutPanel tableDetail;
        private System.Windows.Forms.Label lblRawName;
        private System.Windows.Forms.TextBox txtRawName;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}

