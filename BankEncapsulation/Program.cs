namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            while (true) {
                Console.WriteLine("Do you want to:\n1: Deposit\n2: Withdrawl\n3: Get Balance");
                string? input = Console.ReadLine();

                if (input == null) {
                    continue;
                }

                switch (input) {
                    // Deposit
                    case "1":
                    Console.WriteLine("How much would you like to deposit?");
                    string? amountString = Console.ReadLine();
                    double amount;

                    if (double.TryParse(amountString, out amount)) {
                        account.Deposit(amount);
                        Console.WriteLine($"Deposeted ${amount}");
                    } else {
                        continue;
                    }
                    break;

                    // Withdrawl
                    case "2":
                    Console.WriteLine("How much would you like to withdrawl?");
                    string? amountToWithdrawlString = Console.ReadLine();
                    double amountToWithdrawl;

                    if (double.TryParse(amountToWithdrawlString, out amountToWithdrawl)) {
                        account.Withdrawl(amountToWithdrawl);
                        Console.WriteLine($"Withdrew ${amountToWithdrawl}");
                    } else {
                        continue;
                    }
                    break;

                    // Check balance
                    case "3":
                    Console.WriteLine($"{account.GetBalance()}");
                    break;
                }
            }
        }
    }
}
