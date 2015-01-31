using System;
using System.Windows.Forms;
using ActivityLibrary.Logic;
using SharedLibrary;

namespace Forms
{
    /// <summary>
    /// Using Workflow 4 as a Rule Engine.
    /// Frode Nilsen / Inmeta Consulting 2011
    /// </summary>
    public partial class MainForm : Form
    {
        private Person _person;
        private RuleSettings _settings;
        private Form _rulesForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void BindUI()
        {
            _person = new Person();
            _person.SetSomeValues();
            _settings = new RuleSettings();
            personBindingSource.DataSource = _person;
        }

        private void PerformSalutation()
        {
            _person.Salutation = String.Empty; // Reset
            personBindingSource.ResetBindings(false);
            if (_person.Name == String.Empty || _person.Firstname == String.Empty)
            {
                MessageBox.Show("Enter both the firstname and name of the person.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstNameTextBox.Focus();
                FirstNameTextBox.SelectAll();
                return;
            }

            // Execute rules
            try
            {
                var ruleExecuter = new RuleSetInvoker();
                if (_settings.Source == RuleSource.CodedDynamic) ruleExecuter.PerformDynamicRules(_person, _settings.Rules);
                else if (_settings.Source == RuleSource.CodedStatic) ruleExecuter.PerformCodedRules(_person);
                else ruleExecuter.PerformDesignerRules(_person);
                personBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            PerformSalutation();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BindUI();    

        }
        private void RulesButton_Click(object sender, EventArgs e)
        {
            if (_rulesForm == null || _rulesForm.IsDisposed)
            {
                _rulesForm = new RulesForm(_settings);
            }
            _rulesForm.Show();
            _rulesForm.Left = this.Right;
            _rulesForm.Top = this.Top;
        }
    }
}
