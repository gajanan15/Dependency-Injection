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
            // Constructor Injection
            Console.WriteLine("Constructor Injection");
            IAccount caccount = new CurrentAccount();
            Account a = new Account(caccount);
            a.PrintDetails();

            IAccount saccount = new SavingAccount();
            Account b = new Account(saccount);
            b.PrintDetails();
            Console.WriteLine("\n");
            //Console.ReadLine();

            // Property Injection
            Console.WriteLine("Property Injection");
            PropertyInjection p = new PropertyInjection();
            p.account = new PropCurrentAccount();
            p.PrintDetails();

            p.account = new PropSavingAccount();
            p.PrintDetails();

            Console.WriteLine("\n");

            // Method Injection
            Console.WriteLine("Method Injection");
            MethodInjection methodInjection = new MethodInjection();
            methodInjection.PrintAccounts(new MethodCurrentAccount());

            methodInjection.PrintAccounts(new MethodSavingAccount());   
            Console.ReadLine();
        }

    }
}
