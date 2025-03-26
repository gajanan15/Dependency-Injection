using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Dependency_Injection
{
    class Program
    {
        public static void Main(string[] args)
        {
            IAccount caccount = new CurrentAccount();
            Account a = new Account(caccount);
            a.PrintDetails();

            IAccount saccount = new SavingAccount();
            Account b = new Account(saccount);
            b.PrintDetails();   
            Console.ReadLine();
        }

    }
}
