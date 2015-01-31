using System.Activities;
using System.Collections.Generic;
using SharedLibrary;

namespace ActivityLibrary.Logic
{
    public class RuleSetInvoker
    {
        public void PerformDynamicRules(Person person, List<SalutationAssignmentRule> rules)
        {
            var activity = SalutationRuleGeneratorDynamic.CreateSalutationRules(rules);
            ExecuteRules(activity, person);
        }

        public void PerformCodedRules(Person person)
        {
            var activity = SalutationRuleGeneratorStatic.CreateSalutationRules();
            ExecuteRules(activity, person);
        }

        public void PerformDesignerRules(Person person)
        {
            var activity = new SalutationRules();
            ExecuteRules(activity, person);
        }

        private void ExecuteRules(Activity activity, Person person)
        {
            var input = new Dictionary<string, object>();
            input.Add("Person", person);
            WorkflowInvoker.Invoke(activity, input);
        }
    }
}
