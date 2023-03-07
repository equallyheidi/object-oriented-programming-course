using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    class Account
    {
        public double Bal { get; set; } = 1000;

        public double withdraw, dep;

        public string Credit(double dep)
        {
            Bal += dep;

            return"Total Balance amount in the account  : " + Bal;

        }
        public string Debit(double withdraw)
        {
            if (withdraw <= Bal)
            {
                Bal -= withdraw;
                return "After Withdraw balance Amount is : " + Bal;
            }
            else
                return "\n\nWithdraw Ammount does not Exist your Account.";
        }

    }
    class SavingAccount : Account
    {
        double interest_rate, rate;
        public string CalculateIntrest()
        {
            interest_rate = 0.02;
            rate = Bal * (interest_rate / 100);
            Bal += rate;
            return "Total Balance Amount with Interest : " + Bal;
        }

    }
    class CheckingAccount : SavingAccount
    {
        double fee_per = 15;
        public string Fee()
        {
            return "Balance After Transection Charges : " + (Bal -= fee_per);
        }

    }
    class T19
    {
        static void Main()
        {
            CheckingAccount acc = new CheckingAccount();
            int num;
            char a;

            do
            {
                Console.WriteLine("Please Select Any Function.");
                Console.WriteLine("\nPress 1 for Credit an Amount. \nPress 2 for debit an Amount.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter Credit Amount :");
                        double dep = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(acc.Credit(dep));
                        Console.WriteLine(acc.CalculateIntrest());
                        break;
                    case 2:
                        Console.WriteLine("Enter Withdraw Amount :");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(acc.Debit(withdraw));
                        Console.WriteLine(acc.Fee());
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                a = Convert.ToChar(Console.ReadLine());

            } while (a == 'y');
            Console.ReadKey();
        }
    }
}