using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleRegistratorPageLibrary.DataAccess;
using SimpleRegistratorPageLibrary.Model;

namespace SimpleRegistratorPageLibrary.BussinesLogic
{
    public static class AccountProssesor
    {
        static SqlAccountRepository sqlAccount = new SqlAccountRepository();
        public static void CreateAccount(Account acc)
        {

            var parameters = new { Username = acc.username, Password = acc.password, Email = acc.email, Address = acc.address, Phone = acc.phone, Gender = acc.gender };

            string sql = @"insert into Accounts values(@Username, @Password, @Email, @Address, @Phone, @Gender)";

            sqlAccount.SaveAccount(sql, parameters);
        }

        public static List<Account> ListAccount()
        {
            string sql = "select * from Accounts";

            return sqlAccount.LoadAccount<Account>(sql);
        }
    }
}
