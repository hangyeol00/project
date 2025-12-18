namespace nutritionist
{
    partial class IngredientsForm
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
            this.splitContainerIngredients = new System.Windows.Forms.SplitContainer();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.grpIngredientDetail = new System.Windows.Forms.GroupBox();
            this.tableIngredientDetail = new System.Windows.Forms.TableLayoutPanel();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.lblIngredientUnit = new System.Windows.Forms.Label();
            this.txtIngredientUnit = new System.Windows.Forms.TextBox();
            this.lblIngredientNutrient = new System.Windows.Forms.Label();
            this.txtIngredientNutrient = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).BeginInit();
            this.splitContainerIngredients.Panel1.SuspendLayout();
            this.splitContainerIngredients.Panel2.SuspendLayout();
            this.splitContainerIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            this.grpIngredientDetail.SuspendLayout();
            this.tableIngredientDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerIngredients
            // 
            this.splitContainerIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerIngredients.Location = new System.Drawing.Point(0, 0);
            this.splitContainerIngredients.Name = "splitContainerIngredients";
            // 
            // splitContainerIngredients.Panel1
            // 
            this.splitContainerIngredients.Panel1.Controls.Add(this.dgvIngredients);
            // 
            // splitContainerIngredients.Panel2
            // 
            this.splitContainerIngredients.Panel2.Controls.Add(this.grpIngredientDetail);
            this.splitContainerIngredients.Panel2Collapsed = true;
            this.splitContainerIngredients.Size = new System.Drawing.Size(954, 487);
            this.splitContainerIngredients.SplitterDistance = 477;
            this.splitContainerIngredients.TabIndex = 0;
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIngredients.Location = new System.Drawing.Point(0, 0);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.RowHeadersWidth = 51;
            this.dgvIngredients.RowTemplate.Height = 27;
            this.dgvIngredients.Size = new System.Drawing.Size(954, 487);
            this.dgvIngredients.TabIndex = 0;
            // 
            // grpIngredientDetail
            // 
            this.grpIngredientDetail.Controls.Add(this.tableIngredientDetail);
            this.grpIngredientDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpIngredientDetail.Location = new System.Drawing.Point(0, 0);
            this.grpIngredientDetail.Name = "grpIngredientDetail";
            this.grpIngredientDetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpIngredientDetail.Size = new System.Drawing.Size(96, 100);
            this.grpIngredientDetail.TabIndex = 0;
            this.grpIngredientDetail.TabStop = false;
            this.grpIngredientDetail.Text = "상세 정보";
            // 
            // tableIngredientDetail
            // 
            this.tableIngredientDetail.ColumnCount = 2;
            this.tableIngredientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableIngredientDetail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableIngredientDetail.Controls.Add(this.lblIngredientName, 0, 0);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientName, 1, 0);
            this.tableIngredientDetail.Controls.Add(this.lblIngredientUnit, 0, 1);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientUnit, 1, 1);
            this.tableIngredientDetail.Controls.Add(this.lblIngredientNutrient, 0, 2);
            this.tableIngredientDetail.Controls.Add(this.txtIngredientNutrient, 1, 2);
            this.tableIngredientDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableIngredientDetail.Location = new System.Drawing.Point(3, 25);
            this.tableIngredientDetail.Name = "tableIngredientDetail";
            this.tableIngredientDetail.RowCount = 3;
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableIngredientDetail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableIngredientDetail.Size = new System.Drawing.Size(90, 108);
            this.tableIngredientDetail.TabIndex = 0;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientName.Location = new System.Drawing.Point(3, 0);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(114, 36);
            this.lblIngredientName.TabIndex = 0;
            this.lblIngredientName.Text = "원재료명";
            this.lblIngredientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientName.Location = new System.Drawing.Point(123, 2);
            this.txtIngredientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.ReadOnly = true;
            this.txtIngredientName.Size = new System.Drawing.Size(1, 30);
            this.txtIngredientName.TabIndex = 1;
            // 
            // lblIngredientUnit
            // 
            this.lblIngredientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientUnit.Location = new System.Drawing.Point(3, 36);
            this.lblIngredientUnit.Name = "lblIngredientUnit";
            this.lblIngredientUnit.Size = new System.Drawing.Size(114, 36);
            this.lblIngredientUnit.TabIndex = 2;
            this.lblIngredientUnit.Text = "수량";
            this.lblIngredientUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientUnit
            // 
            this.txtIngredientUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientUnit.Location = new System.Drawing.Point(123, 38);
            this.txtIngredientUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientUnit.Name = "txtIngredientUnit";
            this.txtIngredientUnit.ReadOnly = true;
            this.txtIngredientUnit.Size = new System.Drawing.Size(1, 30);
            this.txtIngredientUnit.TabIndex = 3;
            // 
            // lblIngredientNutrient
            // 
            this.lblIngredientNutrient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredientNutrient.Location = new System.Drawing.Point(3, 72);
            this.lblIngredientNutrient.Name = "lblIngredientNutrient";
            this.lblIngredientNutrient.Size = new System.Drawing.Size(114, 36);
            this.lblIngredientNutrient.TabIndex = 4;
            this.lblIngredientNutrient.Text = "상태";
            this.lblIngredientNutrient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIngredientNutrient
            // 
            this.txtIngredientNutrient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIngredientNutrient.Location = new System.Drawing.Point(123, 74);
            this.txtIngredientNutrient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientNutrient.Name = "txtIngredientNutrient";
            this.txtIngredientNutrient.ReadOnly = true;
            this.txtIngredientNutrient.Size = new System.Drawing.Size(1, 30);
            this.txtIngredientNutrient.TabIndex = 5;
            // 
            // IngredientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 487);
            this.Controls.Add(this.splitContainerIngredients);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientsForm";
            this.Text = "IngredientsForm";
            this.splitContainerIngredients.Panel1.ResumeLayout(false);
            this.splitContainerIngredients.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerIngredients)).EndInit();
            this.splitContainerIngredients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            this.grpIngredientDetail.ResumeLayout(false);
            this.tableIngredientDetail.ResumeLayout(false);
            this.tableIngredientDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerIngredients;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.GroupBox grpIngredientDetail;
        private System.Windows.Forms.TableLayoutPanel tableIngredientDetail;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Label lblIngredientUnit;
        private System.Windows.Forms.TextBox txtIngredientUnit;
        private System.Windows.Forms.Label lblIngredientNutrient;
        private System.Windows.Forms.TextBox txtIngredientNutrient;
    }
}

