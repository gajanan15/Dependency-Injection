using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection
{
    public interface IPropAccount
    {
        void PrintDetails();
    }
    public class PropCurrentAccount : IPropAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Current Account");
        }
    }

    public class PropSavingAccount : IPropAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details Of Saving Account");
        }
    }

    public class PropertyInjection
    {

        public IPropAccount account { get; set; }
        public void PrintDetails()
        {
            account.PrintDetails();
        }
    }
}
