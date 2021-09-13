using System;

namespace TreeNotes.Core
{

    public class Leaf<T> : TreeElement
    {

        public Leaf(string name) : base(name)
        {
        }

        public virtual T Content { get; set; }
    }

    [Obsolete("Will be removed after Media update")]
    public class ReferenceLeaf<T> : Leaf<T>
    {

        private T _content;

        public ReferenceLeaf(string name) : base(name)
        {
            
        }

        public override T Content { get => _content; set { if (value != null) { _content = value; } } }
    }

}
