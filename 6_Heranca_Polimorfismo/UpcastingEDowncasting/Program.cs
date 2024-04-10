using UpcastingEDowncasting.Entities;

namespace UpcastingEDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            // UPCASTING - Subclass to Super
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWCASTING - Super to Subclass -> operação insegura
            //BusinessAccount acc4 = acc2; // Cannot convert Account to businessAccount
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            
            //acc2.Loan(100.0); // Compilador não sabe que é um BusinessAccount, a menos que façamos um casting
            
            //BusinessAccount acc5 = (BusinessAccount)acc4; //acc4 não é BusinessAccount, vai dar erro no tempo de execução
            
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount? acc5 = acc3 as BusinessAccount; //Casting alternativo
                acc5?.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount? acc5 = acc3 as SavingsAccount; //Casting alternativo
                acc5?.UpdateBalance(200.0);
                Console.WriteLine("Update Balance!");
            }


        }
    }
}
