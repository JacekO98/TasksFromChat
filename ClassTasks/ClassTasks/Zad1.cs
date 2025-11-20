namespace Zad1
{
    class Car
    {
        public string marka;
        public string model;
        public int ProductionYear;

        public Car(string marka, string model, int ProductionYear)
        {
            this.marka = marka;
            this.model = model;
            this.ProductionYear = ProductionYear;
        }

        public void PrintCarInformations()
        {
            Console.WriteLine(this.marka);
            Console.WriteLine(this.model);
            Console.WriteLine(this.ProductionYear);
        }

    }
}

