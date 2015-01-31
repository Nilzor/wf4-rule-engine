using System.Activities;
using System.Activities.Statements;
using Microsoft.VisualBasic.Activities;
using SharedLibrary;

namespace ActivityLibrary.Logic
{
    /// <summary>
    /// Translates a "MyRule" object to a Sequence of If-Then-Assign-Actions
    /// </summary>
    public class SalutationRuleGeneratorStatic
    {
        public static Activity CreateSalutationRules()
        {
            var inProperty = new DynamicActivityProperty
            {
                Name = "Person",
                Type = typeof(InArgument<Person>)
                            
            };
            var activity = new DynamicActivity() { Properties = { inProperty} };
            Common.AddVbSetting(activity);

            var sequence = new Sequence();
            activity.Implementation = () => sequence;

            // First rule
            var condition1 = new VisualBasicValue<bool>("Person.Gender = \"Male\"");
            var if1 = new If(new InArgument<bool>(condition1));
            if1.Then = new Assign<string>
            {
                To = new OutArgument<string>(new VisualBasicReference<string>("Person.Salutation")),
                Value = new InArgument<string>("Mr")

            };
            if1.Else = new Assign<string>
            {
                To = new OutArgument<string>(new VisualBasicReference<string>("Person.Salutation")),
                Value = new InArgument<string>("Miss")
            };

            // Second rule
            var condition2 = new VisualBasicValue<bool>("Person.Gender = \"Female\" AND Person.Married");
            var if2 = new If(new InArgument<bool>(condition2));
            if2.Then = new Assign<string>
            {
                To = new OutArgument<string>(new VisualBasicReference<string>("Person.Salutation")),
                Value = new InArgument<string>("Mrs")

            };

            // Third rule
            var condition3 = new VisualBasicValue<bool>("Person.Minor");
            var if3 = new If(new InArgument<bool>(condition3));
            if3.Then = new Assign<string>
            {
                To = new OutArgument<string>(new VisualBasicReference<string>("Person.Salutation")),
                Value = new InArgument<string>("To the parents of")
            };

            // Priority is implicitly defined by the order in which we add the IF-activites
            sequence.Activities.Add(if1);
            sequence.Activities.Add(if2);
            sequence.Activities.Add(if3);

            return activity;
        }
    }
}
