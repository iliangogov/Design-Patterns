namespace SimpleFactory
{
    public abstract class Beer
    {
        public Beer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
