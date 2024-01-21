using System;
using System.Diagnostics;

namespace pln.ProjectElement.Label
{
    public class String
    {
        public String()
        {
        }
    }

    public class StringEvent
    {
        public string Label
        {
            [DebuggerStepThrough]
            get;
            [DebuggerStepThrough]
            set;
        }

    }
}
