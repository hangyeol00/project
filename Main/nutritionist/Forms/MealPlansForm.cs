using System;
using System.Drawing;
using System.Windows.Forms;
using nutritionist;

namespace nutritionist.Forms
{
    public partial class MealPlansForm : Form
    {
        private UserSession _session;
        private RecipesForm _recipesForm;

        public MealPlansForm(UserSession session = null, RecipesForm recipesForm = null)
        {
            _session = session;
            _recipesForm = recipesForm;
            InitializeComponent();
            InitializeLogic();
        }

        public void SetDependencies(UserSession session, RecipesForm recipesForm = null)
        {
            _session = session;
            _recipesForm = recipesForm ?? _recipesForm;
            ConfigureAccessByRole();
        }

        // Expose controls for hosting container logic that still lives in NutritionistForm.
        public SplitContainer SplitContainerMealPlans => splitContainerMealPlans;
        public DateTimePicker DtpMealDate => dtpMealDate;
        public DateTimePicker DtpMealMonth => dtpMealMonth;
        public ComboBox CmbMealWeek => cmbMealWeek;
        public Label LblSelectedMealDay => lblSelectedMealDay;
        public Label LblMealPlanStatus => lblMealPlanStatus;
        public ListBox LstWeekMealPlans => lstWeekMealPlans;
        public Button BtnDeleteMealPlan => btnDeleteMealPlan;
        public DataGridView DgvWeeklyMeals => dgvWeeklyMeals;
        public TextBox TxtMealNotes => txtMealNotes;
        public CheckedListBox ClbMenuTags => clbMenuTags;
        public ComboBox CmbMenuTypeFilter => cmbMenuTypeFilter;
        public ComboBox CmbMenuSort => cmbMenuSort;
        public Button BtnResetMenuFilter => btnResetMenuFilter;
        public Button BtnRegisterMealPlan => btnRegisterMealPlan;
        public Button BtnRequestMealApproval => btnRequestMealApproval;
        public Button BtnStartMealPlan => btnStartMealPlan;
        public ListBox LstAvailableMenus => lstAvailableMenus;
        public ListView LvMealBoard => lvMealBoard;
        public ListView LvAllergyAlerts => lvAllergyAlerts;
        public DataGridView DgvMealNutrition => dgvMealNutrition;
        public DataGridViewTextBoxColumn ColNutrientStatus => colNutrientStatus;
        public GroupBox GrpMealPlanDetail => grpMealPlanDetail;

    }
}
