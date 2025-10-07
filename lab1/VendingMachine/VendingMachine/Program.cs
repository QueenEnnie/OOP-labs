using VendingMachine.Models;

namespace VendingMachine
{
    class Program
    {
        private static Machine machine;
        private static int availableMoney = 0;
        static void ShowWelcomeMessage()
        {
            Console.WriteLine("Вендинговый автомат готов к работе! Ниже представлены возможные действия, " +
                              "чтобы перейти к ним введите символ из скобок английскими буквами:");
            Console.WriteLine("- посмотреть ассортимент товаров (P)");
            Console.WriteLine("- вставить монеты (M)");
            Console.WriteLine("- выбрать товар (C)");
            Console.WriteLine("- войти как администратор (A)");
            Console.WriteLine("Для того, чтобы завершить взаимодействие с автоматом введите END.");
            Console.WriteLine("");
        }

        static bool ValidateCoins(string input)
        {
            int[] nominal = [1, 2, 5, 10, 50, 100];
            if (string.IsNullOrWhiteSpace(input)) return false;
            foreach (string part in input.Split(' '))
            {
                if (!int.TryParse(part, out int coin)) return false;
                if (!nominal.Contains(coin)) return false;
            }
            return true;
        }
        
        static int InsertCoins()
        {                       
            Console.WriteLine("Чтобы вставить монеты, введите их номинал в строку через пробел " +
                                                  "(вы можете использовать только номиналы 1, 2, 5, 10, 50, 100):");
            string input = Console.ReadLine();
            while (!ValidateCoins(input))
            {
                Console.WriteLine("Пожалуйста, введите корректные данные!");
                input = Console.ReadLine();
            }
            return input.Split(' ').Select(int.Parse).Sum();
        }

        static void ChooseProduct(int money)
        {
            Console.WriteLine("Напишите название товара, который хотите выбрать:");
            string input = Console.ReadLine();
            while (!machine.Products.ContainsKey(input))
            {
                Console.WriteLine("Такого продукта не существует!");
                input = Console.ReadLine();
            }

            if (money >= machine.Products[input].ProductPrice)
            {
                machine.SellProduct(input);
                
                Console.WriteLine($"Покупка успешно завершена! " +
                                  $"Ваша сдача: {availableMoney - machine.Products[input].ProductPrice}р");
                availableMoney = 0;
            }
            else
            {
                Console.WriteLine("Денег недостаточно, повторите операцию вставки монет или отмените покупку!");
                Console.WriteLine("Для отмены введите STOP.");
            }
        }

        static void ShowAdministratorMessage()
        {
            Console.WriteLine("Добро пожаловать в режим администратора! Выберите действие:");
            Console.WriteLine("- добавить новый товар (N)");
            Console.WriteLine("- пополнить уже имеющиеся товары (R)");
            Console.WriteLine("- собрать выручку (T)");
            Console.WriteLine("Для того чтобы выйти из администраторского режима введите EXIT.");
        }
        
        static void Administrate()
        {
            ShowAdministratorMessage();
            string input = Console.ReadLine();
            while (input.ToUpperInvariant() != "EXIT")
            {
                switch (input)
                {
                    case "N": break;   
                    case "R": break;
                    case "T": break;
                }
                input = Console.ReadLine();
            }
            
            
        }
        static void Main(string[] args)
        {   
            var defaultProductList = new Product[]
            {
                new Product("Coke", 100, 10),
                new Product("Pepsi", 120, 8)
            };
            machine = new Machine(defaultProductList);
            
            ShowWelcomeMessage();
            var message = Console.ReadLine();
            while (message?.ToUpperInvariant() != "END")
            {
                switch (message?.ToUpperInvariant())
                {
                    case "P": machine.ShowProducts(); break;
                    case "M":
                        availableMoney = InsertCoins();
                        break;
                    case "C": ChooseProduct(availableMoney); break;
                    case "A": Administrate(); break;
                    case "STOP": 
                        Console.WriteLine($"Ваши деньги: {availableMoney}р");
                        availableMoney = 0;
                        break; 
                }
                message = Console.ReadLine();
            }
        }
    }
}
