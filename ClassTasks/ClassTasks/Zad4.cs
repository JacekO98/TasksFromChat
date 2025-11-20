
namespace Zad4
{
    public class Zwierze
    {
        public string Name { get; }
        public int Age { get; }
        private Zwierze(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void DajGlos()
        {
            Console.WriteLine($"{Name} daje glos");
        }
    }

    public class Lion : Zwierze
    {

    }
}
