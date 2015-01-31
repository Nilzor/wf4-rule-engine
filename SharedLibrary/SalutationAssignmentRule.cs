namespace SharedLibrary
{
    public class SalutationAssignmentRule
    {
        public string Condition { get; set; }
        public int Priority { get; set; }
        public string ThenValue { get; set; }
        public string ElseValue { get; set; }
        public string TargetParameter { get; set; }

        public SalutationAssignmentRule(int priority, string condition, string thenValue, string elseValue = null)
        {
            Condition = condition;
            Priority = priority;
            TargetParameter = "Person.Salutation"; // Could be configurable
            ThenValue = thenValue;
            ElseValue = elseValue;
        }
    }
}
