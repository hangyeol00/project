namespace nutritionist
{
    partial class AdminForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPurchase = new System.Windows.Forms.TabPage();
            this.tabMealPlan = new System.Windows.Forms.TabPage();
            this.tabAllergy = new System.Windows.Forms.TabPage();
            this.menuStrip.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuReload,
                this.menuSeparator,
                this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(43, 20);
            this.menuFile.Text = "메뉴";
            // 
            // menuReload
            // 
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new System.Drawing.Size(122, 22);
            this.menuReload.Text = "새로고침";
            this.menuReload.Click += new System.EventHandler(this.MenuReload_Click);
            // 
            // menuSeparator
            // 
            this.menuSeparator.Name = "menuSeparator";
            this.menuSeparator.Size = new System.Drawing.Size(119, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(122, 22);
            this.menuExit.Text = "종료";
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPurchase);
            this.tabMain.Controls.Add(this.tabMealPlan);
            this.tabMain.Controls.Add(this.tabAllergy);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1000, 576);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.TabMain_SelectedIndexChanged);
            // 
            // tabPurchase
            // 
            this.tabPurchase.Location = new System.Drawing.Point(4, 22);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchase.Size = new System.Drawing.Size(992, 550);
            this.tabPurchase.TabIndex = 0;
            this.tabPurchase.Text = "발주 승인";
            this.tabPurchase.UseVisualStyleBackColor = true;
            // 
            // tabMealPlan
            // 
            this.tabMealPlan.Location = new System.Drawing.Point(4, 22);
            this.tabMealPlan.Name = "tabMealPlan";
            this.tabMealPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tabMealPlan.Size = new System.Drawing.Size(992, 550);
            this.tabMealPlan.TabIndex = 1;
            this.tabMealPlan.Text = "식단 계획 승인";
            this.tabMealPlan.UseVisualStyleBackColor = true;
            // 
            // tabAllergy
            // 
            this.tabAllergy.Location = new System.Drawing.Point(4, 22);
            this.tabAllergy.Name = "tabAllergy";
            this.tabAllergy.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllergy.Size = new System.Drawing.Size(992, 550);
            this.tabAllergy.TabIndex = 2;
            this.tabAllergy.Text = "학생 알레르기 관리";
            this.tabAllergy.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AdminForm";
            this.Text = "관리자 도구";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuReload;
        private System.Windows.Forms.ToolStripSeparator menuSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPurchase;
        private System.Windows.Forms.TabPage tabMealPlan;
        private System.Windows.Forms.TabPage tabAllergy;
    }
}
