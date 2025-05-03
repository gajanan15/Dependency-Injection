using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IMethodAccount
    {
        void PrintDetails();
    }
    public class MethodCurrentAccount : IMethodAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }

    public class MethodSavingAccount : IMethodAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving Account");
        }
    }
    public class MethodInjection
    {
        public void PrintAccounts(IMethodAccount account)
        {
            account.PrintDetails();
        }
    }
}
