using System;
using System.Windows.Forms;

namespace nutritionist
{
    public partial class AdminForm : Form
    {
        private readonly UserSession _session;
        private PurchaseApprovalForm _purchaseApprovalForm;
        private MealPlanApprovalForm _mealPlanApprovalForm;
        private StudentAllergyForm _studentAllergyForm;

        public AdminForm() : this(null)
        {
        }

        public AdminForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
            
            var titleSuffix = !string.IsNullOrWhiteSpace(_session?.UserName)
                ? $" - {_session.UserName}"
                : string.Empty;
            Text = $"관리자 도구{titleSuffix}";
            
            InitializeForms();
        }

        private void InitializeForms()
        {
            // 발주 승인 폼
            _purchaseApprovalForm = new PurchaseApprovalForm(_session);
            EmbedFormInTab(_purchaseApprovalForm, tabPurchase);
            _purchaseApprovalForm.OnDataChanged += (s, e) => { };

            // 식단 승인 폼
            _mealPlanApprovalForm = new MealPlanApprovalForm(_session);
            EmbedFormInTab(_mealPlanApprovalForm, tabMealPlan);
            _mealPlanApprovalForm.OnDataChanged += (s, e) => { };

            // 학생 알레르기 폼
            _studentAllergyForm = new StudentAllergyForm(_session);
            EmbedFormInTab(_studentAllergyForm, tabAllergy);
        }

        private void EmbedFormInTab(Form form, TabPage tabPage)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            tabPage.Controls.Add(form);
        }

        private void TabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 탭 변경 시 필요시 처리
        }

        private void MenuReload_Click(object sender, EventArgs e)
        {
            _purchaseApprovalForm?.Reload();
            _mealPlanApprovalForm?.Reload();
            _studentAllergyForm?.Reload();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _purchaseApprovalForm?.Close();
            _mealPlanApprovalForm?.Close();
            _studentAllergyForm?.Close();
            base.OnFormClosing(e);
        }
    }
}
