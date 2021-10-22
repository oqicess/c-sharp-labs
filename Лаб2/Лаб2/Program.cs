using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Profit = 0;// Прибыль с партии
            int ProfitOne = 0; // Прибыль с единицы
            int Stonks = 0; // Прибыльное кофе
            int NoStonksCoffee = 0;//Малоприбильное кофе
            int Order = 0; // Заказы
            int StonksSrav = 0;
            int NoStonks = Int32.MaxValue;
            double average = 0; // Среднее значение
            double MaxProfit = 0; // Вся прибыль

            string full = "";

            Product[] coffee = new Product[]
            {
                    new Coffee(0, 20, 2, 10, 5),
                    new Coffee(1, 15, 7, 5, 10),
                    new Coffee(2, 10, 5, 0, 5),
                    new Water(3, "Russia"),
                    new Water(4, "France"),

            };
            CarModel[] cars = new CarModel[]
            {
                new CarModel(5, "HP"),
                new CarModel(6, "CoffeeMachine"),
                new CarModel(7, "FreeCoffee")
            };

            int len = coffee.Length + cars.Length;
            IGiver[] info = new IGiver[len];
            for (int i = 0; i < coffee.Length; i++)
            {
                info[i] = coffee[i];
                full += info[i].GetInfo();
            }
            for (int i = 0; i < cars.Length; i++)
            {
                info[i+coffee.Length] = cars[i];
                full += info[i+coffee.Length].GetInfo();
            }

            for (int i = 0; i < coffee.Length; i++)
            {
                Profit = ((coffee[i].Cost - coffee[i].CostWater - coffee[i].CostSeed) * coffee[i].Count);
                MaxProfit += Profit;
                ProfitOne = coffee[i].Cost - coffee[i].CostWater - coffee[i].CostSeed;
                if (StonksSrav < Profit)
                {
                    StonksSrav = Profit;
                    Stonks = i;
                }
                if (NoStonks > Profit)
                {
                    NoStonks = Profit;
                    NoStonksCoffee = i;
                }
                Order += coffee[i].Count;
            }
            average = MaxProfit / Order;
            Console.WriteLine($"Самое прибыльное кофе: кофе {Stonks} \nМалоприбыльное кофе: кофе {NoStonksCoffee}\nСредняя прибыль: {average}");
            for (int i = 0; i < coffee.Length; i++)
            {
                Profit = ((coffee[i].Cost - coffee[i].CostWater - coffee[i].CostSeed) * coffee[i].Count);
                ProfitOne = coffee[i].Cost - coffee[i].CostWater - coffee[i].CostSeed;
            }
            Console.WriteLine(full);
        }
    }
}