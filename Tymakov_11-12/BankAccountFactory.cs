using System;
using System.Collections.Generic;

namespace Tymakov_11_12
{
    internal class BankAccountFactory
    {
        private Dictionary<int, BankAccount> accountTable;

        public BankAccountFactory()
        {
            accountTable = new Dictionary<int, BankAccount>();
        }

        public int GetNextAccountNumber()
        {
            return BankAccount.nextAccountNumber;
        }

        public int CreateAccount(decimal initialBalance, BankAccountType type)
        {
            BankAccount account = new BankAccount(initialBalance, type);
            int accountNumber = account.GetAccountNumber();
            accountTable.Add(accountNumber, account);
            return accountNumber;
        }

        public void CloseAccount(int accountNumber)
        {
            if (accountTable.ContainsKey(accountNumber))
            {
                accountTable.Remove(accountNumber);
                Console.WriteLine("Счёт " + accountNumber + " закрыт");
            }
            else
            {
                Console.WriteLine("Счёт " + accountNumber + " не найден");
            }
        }
    }
}

