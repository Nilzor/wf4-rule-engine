using System;
using System.Windows.Forms;
using SharedLibrary;

namespace Forms
{
    public partial class RulesForm : Form
    {
        private RuleSettings _settings;

        public RulesForm(RuleSettings settings)
        {
            InitializeComponent();
            _settings = settings;
            SetCheckedState();
            BindUI();
        }

        private void SetCheckedState()
        {
            DesignerRadioButton.Checked = _settings.Source == RuleSource.Designer;
            StaticRadioButton.Checked = _settings.Source == RuleSource.CodedStatic;
            DynamicRadioButton.Checked = _settings.Source == RuleSource.CodedDynamic;
        }

        private void BindUI()
        {
            ruleSettingsBindingSource.DataSource = _settings;
            ruleSettingsBindingSource.ResetBindings(false);
            rulesBindingSource.ResetBindings(false);
        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void SetData()
        {
            if (DynamicRadioButton.Checked)
            {
                _settings.Source = RuleSource.CodedDynamic;
                if (_settings.Rules == null) _settings.Rules = DefaultRulesGenerator.CreateDefaultRules();
            }
            if (StaticRadioButton.Checked) _settings.Source = RuleSource.CodedStatic;
            if (DesignerRadioButton.Checked) _settings.Source = RuleSource.Designer;
            RulesGrid.ReadOnly = !DynamicRadioButton.Checked;
            BindUI();
        }


        private void DynamicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetData();
        }

        private void StaticRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetData();
        }

        private void DesignerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            SetData();
        }
    }
}
