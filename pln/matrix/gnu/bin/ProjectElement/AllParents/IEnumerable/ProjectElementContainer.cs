using System;
using System.Collections.Generic;

namespace pln.ProjectElement.AllParents.IEnumerable
{
    public class ProjectElementContainer
    {
        public ProjectElementContainer()
        {
            // TODO Project element container names files
        }
    }

    public class ElementContainer
    {
        public IEnumerable<ProjectElementContainer> AllParents
        {
            get;
        }

    }
}
