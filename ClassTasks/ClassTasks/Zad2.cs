
namespace Zad2
{
    public class BankAccount
    {
        private decimal _saldo;
        readonly int AccountNumber;

        public BankAccount(decimal _saldo, int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
            this._saldo = _saldo;
        }
        public void Account()
        {
            Console.WriteLine(this.AccountNumber);
        }

        public void Income(decimal incom)
        {
            this._saldo = this._saldo + incom;

            Console.WriteLine(_saldo);
        }

        public void Outcome(decimal outcome)
        {
            if (this._saldo > outcome)
            {
                this._saldo -= outcome;
            }
            else
            {
                Console.WriteLine("Nie masz kasy biedaku");
            }
        }

        public void Saldo()
        {
            Console.WriteLine(_saldo);
        }
    }

    
}
