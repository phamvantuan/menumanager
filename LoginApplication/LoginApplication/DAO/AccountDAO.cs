using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public DataTable Login(string userName, string passWord)
        {
            string query = "SELECT * FROM [dbo].[user] WHERE [username] = '" + userName + "' AND [password] = '" + passWord + "'";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result;
        }
    }
}
