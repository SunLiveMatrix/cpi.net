using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace pln.ProjectElement.PreviousSibling
{
    public class ProjectElement
    {
        public ProjectElement()
        {
        }
    }

    public class Previous
    {
        public ProjectElement PreviousSibling
        {
            [DebuggerStepThrough]
            [CompilerGenerated]
            get;
        }
    }
}
