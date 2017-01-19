using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class Company
    {
        private IRepository theRepository;

        public Company(IRepository i)
        {
            this.theRepository = i;
        }

        public bool hasDevelopers()
        {
            var temp = theRepository.getEmployees();

            bool hasDev = temp.Any(x => x.Title.ToLower() == "dev");
            return hasDev;
        }

        public List<Employee> getListofDevelopers()
        {
            var temp = theRepository.getEmployees().FindAll(x => x.Title.ToLower() == "dev");
            return temp;
        }
    }
}
