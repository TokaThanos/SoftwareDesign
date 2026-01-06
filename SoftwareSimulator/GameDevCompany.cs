using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareSimulator
{
    public class GameDevCompany : Company
    {
        internal override List<IEmployee> GetEmployees()
        {
            List<IEmployee> employees = new List<IEmployee>()
            {
                new Designer(),
                new Artist(),
                new Programmer(),
                new Tester()
            };
            return employees;
        }
    }
}
