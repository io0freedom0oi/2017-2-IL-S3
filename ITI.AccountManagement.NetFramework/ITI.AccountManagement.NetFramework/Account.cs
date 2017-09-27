using System;

namespace ITI.AccountManagement
{
    public class Account
    {
        readonly string _accountId;
        string _password;
        int _balance;

        public Account(string accountId, string password, int balance)
        {
            if (string.IsNullOrWhiteSpace(accountId)) throw new ArgumentException("The account id must be not null nor whitespace.", nameof(accountId));
            if (accountId.Length < 8) throw new ArgumentException("The account id length must be greater than 7.", nameof(accountId));
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (password.Length < 4) throw new ArgumentException("The password length must be greater than 3.", nameof(password));
            if (balance < 0) throw new ArgumentException("The balance must be greater or equal to 0.", nameof(balance));

            _accountId = accountId;
            _password = password;
            _balance = balance;
        }

        public int GetBalance(string password)
        {
            if (_password != password) return -1;
            return _balance;

            // return _password == password ? _balance : -1;
        }

        public bool Debit(string password, int amount)
        {
            if (amount <= 0) throw new ArgumentException("The amount must be greater or equal to 0.", nameof(amount));

            if (password != _password || amount > _balance) return false;
            _balance -= amount;
            return true;
        }

        public bool Credit(int amount)
        {
            if (amount < 0) return false;
            _balance += amount;
            return true;
        }

        public bool ChangePassword(string currentPassword, string newPassword)
        {
            if (currentPassword != _password) return false;
            _password = newPassword;
            return true;
        }
    }
}
