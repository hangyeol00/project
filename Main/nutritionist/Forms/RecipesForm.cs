using System;
using System.Drawing;
using System.Windows.Forms;
using nutritionist.Tabs.Management;

namespace nutritionist.Forms
{
    public partial class RecipesForm : Form
    {
        private RecipesTabPage _view;

        public RecipesForm() : this(new RecipesTabPage())
        {
        }

        public RecipesForm(RecipesTabPage view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            InitializeComponent();
            InitializeLogic();
        }

        public RecipesTabPage View => _view;

        private void InitializeComponent()
        {
            SuspendLayout();
            _view = new RecipesTabPage();
            _view.Dock = DockStyle.Fill;
            Controls.Add(_view);
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.None;
            Text = "RecipesForm";
            ResumeLayout(false);
        }
    }
}
