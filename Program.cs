using System;

namespace FriendlyBank
{
    enum AccountState
    {
        New,
        Active,
        UnderAudit,
        Frozen,
        Closed
    }

    struct Account
    {
        public string Name;
        public AccountState State;
        public string Address;
        public int AccountNumber;
        public int Balance;
        public int Overdraft;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_CUST = 0;
            while (MAX_CUST == 0)
            {
                Console.WriteLine("How many customers do you want:");
                try
                {
                    MAX_CUST = int.Parse(Console.ReadLine());
                    if (MAX_CUST <= 0)
                    {
                        throw new Exception("Value must be more than 0.");
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MAX_CUST = 0;
                }
            }
            Account[] Bank = new Account[MAX_CUST];

            for (int i = 0; i < MAX_CUST; i++)
            {
                Console.WriteLine("Enter name of customer:");
                Bank[i].Name = Console.ReadLine();
                Console.WriteLine("Enter account balance");
                do
                {
                    try
                    {
                        Bank[i].Balance = int.Parse(Console.ReadLine());
                        if (Bank[i].Balance <= 0)
                        {
                            throw new Exception("Balance cannot be under 0");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (Bank[i].Balance !> 0);
            }
            Console.WriteLine(Bank);
        }
    }
}
