using System;
using System.Drawing;
using System.Windows.Forms;
using nutritionist.Tabs.Management;

namespace nutritionist.Forms
{
    public partial class RawMaterialsForm : Form
    {
        private RawMaterialsTabPage _view;

        public RawMaterialsForm() : this(new RawMaterialsTabPage())
        {
        }

        public RawMaterialsForm(RawMaterialsTabPage view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            InitializeComponent();
            InitializeLogic();
        }

        public RawMaterialsTabPage View => _view;

        private void InitializeComponent()
        {
            SuspendLayout();
            _view = new RawMaterialsTabPage();
            _view.Dock = DockStyle.Fill;
            Controls.Add(_view);
            AutoScaleDimensions = new SizeF(7F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            FormBorderStyle = FormBorderStyle.None;
            Text = "RawMaterialsForm";
            ResumeLayout(false);
        }
    }
}
