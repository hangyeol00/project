using System;
using System.Drawing;
using System.Windows.Forms;
using nutritionist;
using nutritionist.Tabs.Management;

namespace nutritionist.Forms
{
    public partial class MealPlansForm : Form
    {
        private MealPlansTabPage _view;
        private UserSession _session;
        private RecipesForm _recipesForm;

        public MealPlansForm() : this(new MealPlansTabPage())
        {
        }

        public MealPlansForm(MealPlansTabPage view, UserSession session = null, RecipesForm recipesForm = null)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _session = session;
            _recipesForm = recipesForm;
            InitializeComponent();
            InitializeLogic();
        }

        public MealPlansTabPage View => _view;

        public void SetDependencies(UserSession session, RecipesForm recipesForm = null)
        {
            _session = session;
            _recipesForm = recipesForm ?? _recipesForm;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            _view = new MealPlansTabPage();
            _view.Dock = DockStyle.Fill;
            Controls.Add(_view);
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.None;
            Text = "MealPlansForm";
            ResumeLayout(false);
        }
    }
}
