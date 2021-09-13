namespace TreeNotes.Core
{
    public abstract class TreeElement
    {
        private string _name;

        public string Name { get => _name; set => _name = value ?? "Unnamed"; }

        public TreeElement(string name)
        {
            _name = name;
        }

    }
}
