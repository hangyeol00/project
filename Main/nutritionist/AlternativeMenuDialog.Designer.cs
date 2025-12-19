namespace nutritionist
{
    partial class AlternativeMenuDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAllergyInfo = new System.Windows.Forms.Label();
            this.lblTargetMenu = new System.Windows.Forms.Label();
            this.cmbTargetMenu = new System.Windows.Forms.ComboBox();
            this.lblAlternatives = new System.Windows.Forms.Label();
            this.lstAlternatives = new System.Windows.Forms.ListBox();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblAllergyInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTargetMenu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTargetMenu, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAlternatives, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lstAlternatives, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowButtons, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 361);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAllergyInfo
            // 
            this.lblAllergyInfo.AutoSize = true;
            this.lblAllergyInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAllergyInfo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.lblAllergyInfo.Location = new System.Drawing.Point(3, 0);
            this.lblAllergyInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.lblAllergyInfo.Name = "lblAllergyInfo";
            this.lblAllergyInfo.Size = new System.Drawing.Size(408, 25);
            this.lblAllergyInfo.TabIndex = 0;
            this.lblAllergyInfo.Text = "알레르기";
            // 
            // lblTargetMenu
            // 
            this.lblTargetMenu.AutoSize = true;
            this.lblTargetMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTargetMenu.Location = new System.Drawing.Point(3, 33);
            this.lblTargetMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblTargetMenu.Name = "lblTargetMenu";
            this.lblTargetMenu.Size = new System.Drawing.Size(408, 25);
            this.lblTargetMenu.TabIndex = 1;
            this.lblTargetMenu.Text = "대체할 메뉴";
            // 
            // cmbTargetMenu
            // 
            this.cmbTargetMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTargetMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetMenu.FormattingEnabled = true;
            this.cmbTargetMenu.Location = new System.Drawing.Point(3, 60);
            this.cmbTargetMenu.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.cmbTargetMenu.Name = "cmbTargetMenu";
            this.cmbTargetMenu.Size = new System.Drawing.Size(408, 33);
            this.cmbTargetMenu.TabIndex = 2;
            // 
            // lblAlternatives
            // 
            this.lblAlternatives.AutoSize = true;
            this.lblAlternatives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlternatives.Location = new System.Drawing.Point(3, 94);
            this.lblAlternatives.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.lblAlternatives.Name = "lblAlternatives";
            this.lblAlternatives.Size = new System.Drawing.Size(408, 25);
            this.lblAlternatives.TabIndex = 3;
            this.lblAlternatives.Text = "대체 가능한 메뉴";
            // 
            // lstAlternatives
            // 
            this.lstAlternatives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlternatives.FormattingEnabled = true;
            this.lstAlternatives.ItemHeight = 25;
            this.lstAlternatives.Location = new System.Drawing.Point(3, 124);
            this.lstAlternatives.Name = "lstAlternatives";
            this.lstAlternatives.Size = new System.Drawing.Size(408, 187);
            this.lstAlternatives.TabIndex = 4;
            // 
            // flowButtons
            // 
            this.flowButtons.AutoSize = true;
            this.flowButtons.Controls.Add(this.btnOk);
            this.flowButtons.Controls.Add(this.btnCancel);
            this.flowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowButtons.Location = new System.Drawing.Point(209, 317);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.flowButtons.Size = new System.Drawing.Size(202, 41);
            this.flowButtons.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 11);
            this.btnOk.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 27);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 27);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AlternativeMenuDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlternativeMenuDialog";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "대체 메뉴 선택";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAllergyInfo;
        private System.Windows.Forms.Label lblTargetMenu;
        private System.Windows.Forms.ComboBox cmbTargetMenu;
        private System.Windows.Forms.Label lblAlternatives;
        private System.Windows.Forms.ListBox lstAlternatives;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
