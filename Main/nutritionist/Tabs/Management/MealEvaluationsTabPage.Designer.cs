namespace nutritionist.Tabs.Management
{
    partial class MealEvaluationsTabPage
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
            this.tableEvaluationViewer = new System.Windows.Forms.TableLayoutPanel();
            this.grpEvaluationMenus = new System.Windows.Forms.GroupBox();
            this.dgvEvaluationMenus = new System.Windows.Forms.DataGridView();
            this.grpEvaluationIngredients = new System.Windows.Forms.GroupBox();
            this.dgvEvaluationIngredients = new System.Windows.Forms.DataGridView();
            this.grpEvaluationAllergies = new System.Windows.Forms.GroupBox();
            this.dgvEvaluationAllergies = new System.Windows.Forms.DataGridView();
            this.tableEvaluationViewer.SuspendLayout();
            this.grpEvaluationMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationMenus)).BeginInit();
            this.grpEvaluationIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationIngredients)).BeginInit();
            this.grpEvaluationAllergies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationAllergies)).BeginInit();
            this.SuspendLayout();
            // 
            // tableEvaluationViewer
            // 
            this.tableEvaluationViewer.ColumnCount = 3;
            this.tableEvaluationViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableEvaluationViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableEvaluationViewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableEvaluationViewer.Controls.Add(this.grpEvaluationMenus, 0, 0);
            this.tableEvaluationViewer.Controls.Add(this.grpEvaluationIngredients, 1, 0);
            this.tableEvaluationViewer.Controls.Add(this.grpEvaluationAllergies, 2, 0);
            this.tableEvaluationViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableEvaluationViewer.Location = new System.Drawing.Point(3, 2);
            this.tableEvaluationViewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableEvaluationViewer.Name = "tableEvaluationViewer";
            this.tableEvaluationViewer.RowCount = 1;
            this.tableEvaluationViewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableEvaluationViewer.Size = new System.Drawing.Size(934, 449);
            this.tableEvaluationViewer.TabIndex = 0;
            // 
            // grpEvaluationMenus
            // 
            this.grpEvaluationMenus.Controls.Add(this.dgvEvaluationMenus);
            this.grpEvaluationMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEvaluationMenus.Location = new System.Drawing.Point(3, 2);
            this.grpEvaluationMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationMenus.Name = "grpEvaluationMenus";
            this.grpEvaluationMenus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationMenus.Size = new System.Drawing.Size(305, 445);
            this.grpEvaluationMenus.TabIndex = 0;
            this.grpEvaluationMenus.TabStop = false;
            this.grpEvaluationMenus.Text = "요리";
            // 
            // dgvEvaluationMenus
            // 
            this.dgvEvaluationMenus.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvaluationMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluationMenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvaluationMenus.Location = new System.Drawing.Point(3, 18);
            this.dgvEvaluationMenus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvaluationMenus.Name = "dgvEvaluationMenus";
            this.dgvEvaluationMenus.RowHeadersWidth = 51;
            this.dgvEvaluationMenus.RowTemplate.Height = 27;
            this.dgvEvaluationMenus.Size = new System.Drawing.Size(299, 425);
            this.dgvEvaluationMenus.TabIndex = 0;
            // 
            // grpEvaluationIngredients
            // 
            this.grpEvaluationIngredients.Controls.Add(this.dgvEvaluationIngredients);
            this.grpEvaluationIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEvaluationIngredients.Location = new System.Drawing.Point(314, 2);
            this.grpEvaluationIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationIngredients.Name = "grpEvaluationIngredients";
            this.grpEvaluationIngredients.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationIngredients.Size = new System.Drawing.Size(305, 445);
            this.grpEvaluationIngredients.TabIndex = 1;
            this.grpEvaluationIngredients.TabStop = false;
            this.grpEvaluationIngredients.Text = "재료";
            // 
            // dgvEvaluationIngredients
            // 
            this.dgvEvaluationIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvaluationIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluationIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvaluationIngredients.Location = new System.Drawing.Point(3, 18);
            this.dgvEvaluationIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvaluationIngredients.Name = "dgvEvaluationIngredients";
            this.dgvEvaluationIngredients.RowHeadersWidth = 51;
            this.dgvEvaluationIngredients.RowTemplate.Height = 27;
            this.dgvEvaluationIngredients.Size = new System.Drawing.Size(299, 425);
            this.dgvEvaluationIngredients.TabIndex = 0;
            // 
            // grpEvaluationAllergies
            // 
            this.grpEvaluationAllergies.Controls.Add(this.dgvEvaluationAllergies);
            this.grpEvaluationAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEvaluationAllergies.Location = new System.Drawing.Point(625, 2);
            this.grpEvaluationAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationAllergies.Name = "grpEvaluationAllergies";
            this.grpEvaluationAllergies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpEvaluationAllergies.Size = new System.Drawing.Size(306, 445);
            this.grpEvaluationAllergies.TabIndex = 2;
            this.grpEvaluationAllergies.TabStop = false;
            this.grpEvaluationAllergies.Text = "알레르기";
            // 
            // dgvEvaluationAllergies
            // 
            this.dgvEvaluationAllergies.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvaluationAllergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluationAllergies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvaluationAllergies.Location = new System.Drawing.Point(3, 18);
            this.dgvEvaluationAllergies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEvaluationAllergies.Name = "dgvEvaluationAllergies";
            this.dgvEvaluationAllergies.RowHeadersWidth = 51;
            this.dgvEvaluationAllergies.RowTemplate.Height = 27;
            this.dgvEvaluationAllergies.Size = new System.Drawing.Size(300, 425);
            this.dgvEvaluationAllergies.TabIndex = 0;
            // 
            // MealEvaluationsTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableEvaluationViewer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MealEvaluationsTabPage";
            this.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Size = new System.Drawing.Size(940, 453);
            this.tableEvaluationViewer.ResumeLayout(false);
            this.grpEvaluationMenus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationMenus)).EndInit();
            this.grpEvaluationIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationIngredients)).EndInit();
            this.grpEvaluationAllergies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluationAllergies)).EndInit();
            this.ResumeLayout(false);

        }

        internal System.Windows.Forms.TableLayoutPanel tableEvaluationViewer;
        internal System.Windows.Forms.GroupBox grpEvaluationMenus;
        internal System.Windows.Forms.DataGridView dgvEvaluationMenus;
        internal System.Windows.Forms.GroupBox grpEvaluationIngredients;
        internal System.Windows.Forms.DataGridView dgvEvaluationIngredients;
        internal System.Windows.Forms.GroupBox grpEvaluationAllergies;
        internal System.Windows.Forms.DataGridView dgvEvaluationAllergies;
    }
}
