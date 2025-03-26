using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IAccount
    {
        void PrintDetails();
    }
    public class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }

    public class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving Account");
        }
    }

    public class Account
    {
        private IAccount _account;

        public Account(IAccount account)
        {
            this._account = account;
        }

        public void PrintDetails()
        {
            _account.PrintDetails();
        }
    }
}
