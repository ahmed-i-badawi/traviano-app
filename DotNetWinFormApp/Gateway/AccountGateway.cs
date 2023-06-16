using TravianoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravianoApp.Gateway
{
    public class AccountGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();
        public bool Add(Account Account)
        {
            _dbContext.Accounts.Add(Account);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Account> GetAll() 
        { 
            return _dbContext.Accounts.ToList();
        }
        public bool Update (Account Account) 
        {
            var data = _dbContext.Accounts.FirstOrDefault(c=>c.Id==Account.Id);
            if (data==null)
            {
                return false;
            }
            data.UserName = Account.UserName;
            data.Password = Account.Password;
            data.Server = Account.Server;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(int id) 
        {
            var Account = _dbContext.Accounts.FirstOrDefault(s => s.Id == id);
            if (Account == null)
            {
                return false;
            }
            _dbContext.Accounts.Remove(Account);
            return _dbContext.SaveChanges() > 0;

        }
    }
}
