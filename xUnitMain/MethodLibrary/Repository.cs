using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class Repository:IRepository
    {
        public List<Employee> getEmployees()
        {
            return new List<Employee>() { new Employee() { Name = "des", Age = 26, Title = "dev" }, new Employee() { Name = "des2", Age = 22, Title = "dev2" } };
        }
    }
}
