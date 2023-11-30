using System;



namespace Tymakov_11_12
{
    internal class BankAccount
    {
        internal static int nextAccountNumber = 1;
        private int accountNumber;
        private decimal balance;
        private BankAccountType accountType;
        private object HashCode;

        public BankAccount(decimal initialBalance, BankAccountType type)
        {
            GenerateAccountNumber();
            balance = initialBalance;
            accountType = type;
        }

        private void GenerateAccountNumber()
        {
            accountNumber = nextAccountNumber;
            nextAccountNumber++;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public BankAccountType GetAccountType()
        {
            return accountType;
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Account Type: " + accountType);
        }

        public bool Withdraw(decimal amount)
        {
            if (0 <= amount && amount <= balance)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }
        // Переопределение оператора ==
        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            if (ReferenceEquals(account1, account2))
                return true;

            if (ReferenceEquals(account1, null) || ReferenceEquals(account2, null))
                return false;

            // Сравниваем информацию в двух счетах
            return account1.accountNumber == account2.accountNumber;
        }

        // Переопределение оператора !=
        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return !(account1 == account2);
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (ReferenceEquals(null, obj))
                return false;

            if (GetType() != obj.GetType())
                return false;

            return this == (BankAccount)obj;
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Account Number: {accountNumber}";
        }
    }
}

