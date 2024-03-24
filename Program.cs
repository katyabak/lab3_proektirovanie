using System;
using _3;
class Program
{
    static void Main(string[] args)
    {
        KitchenStaff kitchenStaff1 = new KitchenStaff { Name = "Иван", HireDate = new DateTime(2020, 5, 10), Rate = 10, HoursWorked = 160 };
        KitchenStaff kitchenStaff2 = new KitchenStaff { Name = "Евгения", HireDate = new DateTime(2019, 8, 15), Rate = 12, HoursWorked = 180 };

        Waiter waiter1 = new Waiter { Name = "Алексей", HireDate = new DateTime(2018, 3, 20), Rate = 8, HoursWorked = 150, Tips = 200 };
        Waiter waiter2 = new Waiter { Name = "Елена", HireDate = new DateTime(2017, 6, 25), Rate = 9, HoursWorked = 170, Tips = 250 };

        Manager manager = new Manager { Name = "Дмитрий", HireDate = new DateTime(2015, 10, 5), Rate = 20, Bonus = 500, YearsWorked = 6 };

        JuniorManager juniorManager = new JuniorManager { Name = "Ольга", HireDate = new DateTime(2016, 12, 12), Rate = 18, Bonus = 300, YearsWorked = 5 };

        Console.WriteLine("Информация о сотрудниках:");
        kitchenStaff1.GetInfo();
        Console.WriteLine($"Заработная плата: {kitchenStaff1.GetPrice()}");

        kitchenStaff2.GetInfo();
        Console.WriteLine($"Заработная плата: {kitchenStaff2.GetPrice()}");

        waiter1.GetInfo();
        Console.WriteLine($"Заработная плата: {waiter1.GetPrice()}");

        waiter2.GetInfo();
        Console.WriteLine($"Заработная плата: {waiter2.GetPrice()}");

        manager.GetInfo();
        Console.WriteLine($"Заработная плата: {manager.GetPrice()}");

        juniorManager.GetInfo();
        Console.WriteLine($"Заработная плата: {juniorManager.GetPrice()}");

        Console.ReadLine();
    }
}

