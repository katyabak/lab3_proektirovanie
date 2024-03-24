using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class Manager : Employee
    {
        public int Bonus { get; set; }
        public int YearsWorked { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Дата трудоустройства: {HireDate}, Ставка: {Rate}, Прошло лет работы: {YearsWorked}, Премия: {Bonus}");
        }

        public override decimal GetPrice()
        {
            return Rate + (Rate * YearsWorked) + Bonus;
        }
    }
}
