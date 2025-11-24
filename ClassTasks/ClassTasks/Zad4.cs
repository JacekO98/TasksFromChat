
namespace Zad4
{
    public class Zwierze
    {
        public string Name { get; }
        public int Age { get; }
        public Zwierze(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void DajGlos()
        {
            Console.WriteLine($"Daje glos");
        }
    }

    public class Lion : Zwierze
    {
        public Lion(string Name, int Age) : base(Name, Age)
        {
        }
        public override void DajGlos()
        {
            Console.WriteLine("Rooarrr");
        }
    }

    public class Horse : Zwierze
    {
        public Horse(string Name, int Age) : base(Name, Age)
        {
        }

        public override void DajGlos()
        {
            Console.WriteLine("Ihaaaa");


        }
        
    }
}
