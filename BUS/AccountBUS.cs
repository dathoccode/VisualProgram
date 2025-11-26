using ABCCoffee.DAL;
using ABCCoffee.DTO;
using System;
using System.Data;


namespace ABCCoffee.BUS
{
    public class AccountBUS
    {
        private static AccountBUS instance;
        private AccountBUS() { }
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }

        public bool LoginValidation(string accountName, string password)
        {
            // Username and password should not be empty or whitespace
            if (string.IsNullOrWhiteSpace(accountName) ||
                string.IsNullOrWhiteSpace(password))
                return false;


            // Additional business logic can be added here
            return true;
        }

        public AccountDTO GetAccountByAccountName(string accountName)
        {
            DataTable dt;
            try
            {
                dt = AccountDAL.Instance.GetAccountByAccountName(accountName);
                return new AccountDTO(dt.Rows[0]);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public DataTable GetAllAccounts()
        {
            try
            {
                return AccountDAL.Instance.GetAllAccounts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InsertAccount(AccountDTO account)
        {
            try
            {
                return AccountDAL.Instance.InsertAccount(account);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteAccount(string accountName)
        {
            try
            {
                return AccountDAL.Instance.DeleteAccount(accountName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateAccount(AccountDTO account)
        {
            try
            {
                return AccountDAL.Instance.UpdateAccount(account);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CheckIn(string accountName)
        {
            return AccountDAL.Instance.CheckIn(accountName);
        }
    }
}
