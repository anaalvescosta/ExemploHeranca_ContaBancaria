using ex01T7M10.Entities;

namespace ex01T7M10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UPCASTING  
            //não tem problema porque as subclasses são classes 
            //uma subclasse “é uma” classe.

            Account acc = new Account(1001, "Alex", 0.0);
            
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            Console.WriteLine(acc.AccountData());
            Console.WriteLine(bacc.AccountData());

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            
            Console.WriteLine();
            Console.WriteLine(acc1.AccountData());
            Console.WriteLine(acc2.AccountData());
            Console.WriteLine(acc3.AccountData());


            // DOWNCASTING    //não é seguro - é necessário testes

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            Console.WriteLine(acc4.AccountData());

            // Direto Não: BusinessAccount acc5 = (BusinessAccount)acc3;
            //testes
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }


            if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = (SavingsAccount)acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}