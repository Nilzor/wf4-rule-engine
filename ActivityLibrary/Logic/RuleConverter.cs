using System.Activities;
using System.Activities.Statements;
using Microsoft.VisualBasic.Activities;
using SharedLibrary;

namespace ActivityLibrary.Logic
{
    public class RuleConverter
    {
        internal static Activity ToIfActivity(SalutationAssignmentRule inRule)
        {
            var condition = new VisualBasicValue<bool>(inRule.Condition);
            var ifActivity = new If(new InArgument<bool>(condition));
            ifActivity.Then = new Assign<string>
            {
                To = new OutArgument<string>(new VisualBasicReference<string>(inRule.TargetParameter)),
                Value = new InArgument<string>(inRule.ThenValue)
            };
            if (inRule.ElseValue != null)
            {
                ifActivity.Else = new Assign<string>
                {
                    To = new OutArgument<string>(new VisualBasicReference<string>(inRule.TargetParameter)),
                    Value = new InArgument<string>(inRule.ElseValue)
                };
            }
            return ifActivity;
        }
    }
}
