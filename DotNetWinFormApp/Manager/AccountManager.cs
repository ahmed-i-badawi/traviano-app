using TravianoApp.Gateway;
using TravianoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianoApp.Manager
{
    public class AccountManager
    {
        AccountGateway _AccountGateway = new AccountGateway();
        public bool Add(Account Account)
        {
            return _AccountGateway.Add(Account);
        }
        public List<Account> GetAll() 
        {
            return _AccountGateway.GetAll();
        }

        public bool Update(Account Account) 
        { 
            return _AccountGateway.Update(Account);
        }
        public bool Delete(int id)
        {
            return _AccountGateway.Delete(id);
        }

    }
}
