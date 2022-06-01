namespace ConsoleApp.Classes
{
    public class Person
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}