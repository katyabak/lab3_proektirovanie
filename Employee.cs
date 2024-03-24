using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Rate { get; set; }

        public abstract void GetInfo();
        public abstract decimal GetPrice();
    }
}
