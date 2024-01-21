using System;
using System.Diagnostics;

namespace pln.ElementLocation
{
    [Serializable]
    public abstract class ElementLocation
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public abstract int Column
        {
            get;
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public abstract int Files
        {
            get;
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public abstract int Lines
        {
            get;
        }

        public string LocationString
        {
            get;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
