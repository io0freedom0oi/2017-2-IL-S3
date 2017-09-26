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
