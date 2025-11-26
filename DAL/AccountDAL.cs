using ABCCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCoffee.DAL
{
    internal class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAL();
                return instance;
            }
        }

        public DataTable GetAllAccounts()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllAccount");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAccountByAccountName(string accountName)
        {
            string query = "USP_GetAccountByAccountName @AccountName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { accountName });
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
                int role = account.Role == "Nhân viên" ? 0 : 1;
                int result = DataProvider.Instance.ExecuteNonQuery("USP_InsertAccount @AccountName , @DisplayName , @Password , @Phone , @Gender , @DateOfBirth , @RoleID", 
                    new object[] { account.AccountName, account.DisplayName, account.Password, account.Phone, account.Gender, account.DateOfBirth, role});
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteAccount(string accountName)
        {
            string query = "USP_DeleteAccount @AccountName";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { accountName });
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateAccount(AccountDTO account)
        {
            string query = "USP_UpdateAccount @AccountName , @DisplayName , @Password , @RoleID , @Phone , @DateOfBirth , @Gender , @ImagePath";
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { 
                    account.AccountName, account.DisplayName, account.Password, account.Role.CompareTo("Nhân viên") == 0? 0 : 1, 
                    account.Phone, account.DateOfBirth, account.Gender, account.ImagePath });
                return result > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool CheckIn(string accountName) 
        {
            try
            {
                int res = DataProvider.Instance.ExecuteNonQuery("USP_CheckIn @AccountName",
                    new object[] { accountName });
                return res > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
