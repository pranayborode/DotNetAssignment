using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TheorySession.DelegateAndEvents
{
    public delegate void MyBankDelegate();
    public class Bank
    {
        public event MyBankDelegate LowBalance;
        public double balance;
      
        public Bank()
        {
            balance = 5000;
        }

        public void Withdraw(double amount)
        {
            if (amount>balance)
            {
                LowBalance(); //call or raise an event

            }
            else
            {
                balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Your balance is {balance}";
        }
    }

    public class MyMessage 
    {
        public void BalanceMsg()
        {
            Console.WriteLine("You have low balance");
        }
    }

    public class BankMain
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            MyMessage myMessage = new MyMessage();

            bank.LowBalance += new MyBankDelegate(myMessage.BalanceMsg);

            Console.WriteLine("Initial Balance");

            Console.WriteLine(bank);


            bank.Withdraw(1000);
            Console.WriteLine("Balance After Withdraw 1000 :");

            Console.WriteLine(bank);

            bank.Withdraw(6000);
            Console.WriteLine("balance after withdraw 6000");
            Console.WriteLine(bank);


        }
    }
}
