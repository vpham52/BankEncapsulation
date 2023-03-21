namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var victoriaAccount = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());

            victoriaAccount.Deposit(amountToDeposit);
                       

            Console.WriteLine($"New account Balance is:${victoriaAccount.GetBalance()}");
                   

           

        }
    }
}
