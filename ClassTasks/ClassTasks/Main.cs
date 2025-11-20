using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zad1;
using Zad2;
using Zad3;

namespace ClassTasks
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Zadanie1:");
            Car Car1 = new Car("Honda", "Accord", 2003);
            Car1.PrintCarInformations();

            Console.WriteLine("Zadanie2:");
            BankAccount Account1 = new BankAccount(100, 4321);
            Account1.Income(100);
            Account1.Account();
            Account1.Outcome(500);
            Account1.Saldo();

            Console.WriteLine("Zadanie3:");
            Author Sapkowski = new Author("Andrzej", "Sapkowski");
            Book Wiedźmin = new Book("Krew elfów", 2000, Sapkowski);
            Wiedźmin.PrintInformation();
        }


    }
}
