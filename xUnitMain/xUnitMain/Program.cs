using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodLibrary;

namespace xUnitMain
{
    public class Program
    {
        static void Main(string[] args)
        {

            IRepository r = new Repository();
            Company c = new Company(r);

            Console.WriteLine(c.hasDevelopers());

            foreach (var x in c.getListofDevelopers())
            {
                Console.WriteLine(x.Name);
            }
            Console.Read();
        }
    }
}
