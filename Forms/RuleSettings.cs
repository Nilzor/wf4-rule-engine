using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharedLibrary;

namespace Forms
{
    public enum RuleSource
    {
        Designer,
        CodedStatic,
        CodedDynamic
    }
    public class RuleSettings
    {

        public RuleSource Source { get; set; }
        public List<SalutationAssignmentRule> Rules { get; set; }
    }
}
