using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    public class JuniorManager : Manager
    {
        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Дата трудоустройства: {HireDate}, Ставка: {Rate}, Прошло лет работы: {YearsWorked}, Премия: {Bonus}");
        }

        public override decimal GetPrice()
        {
            // Младший менеджер получает премию только 2 раза в год
            DateTime currentDate = DateTime.Now;
            if (currentDate.Month == 6 || currentDate.Month == 12)
            {
                return Rate + (Rate * YearsWorked) + Bonus;
            }
            else
            {
                return Rate + (Bonus * YearsWorked);
            }
        }
    }
}
