namespace UC4_ENCAPSULATION
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oops Concept\n");
            BankAccount obj = new BankAccount(5000);
            obj.Deposit(2000);

            Console.WriteLine("After Depositing Money New Balance is " + obj.GetBalance() + "\n");

            obj.Withdraw(500);
            Console.WriteLine("After Money withdrawal Current Balance is: " + obj.GetBalance());
            Console.Read();
        }
    }
}
