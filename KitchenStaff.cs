using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class KitchenStaff : Employee
    {
        public int HoursWorked { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Дата трудоустройства: {HireDate}, Ставка: {Rate}, Отработанные часы: {HoursWorked}");
        }

        public override decimal GetPrice()
        {
            return Rate * HoursWorked;
        }
    }
}
