using System;
using System.Diagnostics;
namespace pln.ProjectElement.Parent
{
    public class ProjectElementContainer
    {
        public ProjectElementContainer()
        {
        }
    }

    public class Templates
    {
        public ProjectElementContainer Parent
        {
            [DebuggerStepThrough]
            get;
        }

    }
}
