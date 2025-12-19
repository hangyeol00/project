using System;
using System.Drawing;
using System.Windows.Forms;
namespace nutritionist.Forms
{
    public partial class RawMaterialsForm : Form
    {
        public RawMaterialsForm(UserSession session = null)
        {
            _session = session;
            InitializeComponent();
            InitializeLogic();
        }
    }
}
