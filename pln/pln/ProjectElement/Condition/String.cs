using System;
using System.Diagnostics;

namespace pln.ProjectElement.Condition
{
    public class String
    {
        public String()
        {
        }
    }

    public class StringEvent
    {
        public virtual string Condition
        {
            [DebuggerStepThrough]
            get;
            [DebuggerStepThrough]
            set;
        }

    }
}
