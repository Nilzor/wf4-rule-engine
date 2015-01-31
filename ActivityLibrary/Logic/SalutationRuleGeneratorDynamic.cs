using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using SharedLibrary;

namespace ActivityLibrary.Logic
{
    /// <summary>
    /// Translates a "MyRule" object to a Sequence of If-Then-Assign-Actions
    /// </summary>
    public class SalutationRuleGeneratorDynamic
    {
        public static Activity CreateSalutationRules(List<SalutationAssignmentRule> rules)
        {
            var inProperty = new DynamicActivityProperty
            {
                Name = "Person",
                Type = typeof(InArgument<Person>)

            };
            var activity = new DynamicActivity() { Properties = { inProperty } };
            Common.AddVbSetting(activity);

            var sequence = new Sequence();
            activity.Implementation = () => sequence;

            // Sort descending - those added first are lowest priority
            var sortedRules = rules.OrderByDescending(p => p.Priority).ToList();
            
            // Convert to if-activities and add to sequence
            foreach (var inRule in sortedRules)
            {
                var outRule = RuleConverter.ToIfActivity(inRule);
                sequence.Activities.Add(outRule);
            }

            return activity;
        }
    }
}
