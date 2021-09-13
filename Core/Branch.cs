using System.Collections.Generic;

namespace TreeNotes.Core
{
    public class Branch : TreeElement
    {
        public Branch(string name) : base(name)
        {
        }

        public List<TreeElement> Childs { get; init; }
    }
}
