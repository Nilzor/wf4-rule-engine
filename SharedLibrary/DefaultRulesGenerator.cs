using System.Collections.Generic;

namespace SharedLibrary
{
    public class DefaultRulesGenerator
    {
        public static List<SalutationAssignmentRule> CreateDefaultRules()
        {
            var rules = new List<SalutationAssignmentRule>();

            rules.Add(new SalutationAssignmentRule(10, "Person.Minor", "To the parents of"));
            rules.Add(new SalutationAssignmentRule(30, "Person.Gender = \"Male\"", "Mr", "Miss"));
            rules.Add(new SalutationAssignmentRule(20, "Person.Gender = \"Female\" AND Person.Married", "Mrs"));
            return rules;
        }
    }
}
