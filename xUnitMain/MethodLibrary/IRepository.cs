using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public interface IRepository
    {
        List<Employee> getEmployees();
    }
}
