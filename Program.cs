using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string balanceMoney; 
            string userInput;
            string converter;
            string currencySelection;
            float usd = 200, pln = 800, rus = 2000;
            float usdToPln = 4.2f; 
            float usdToRus = 90f;
            float plnToUsd = 4;
            float plnToRus = 18;
            float rusToPln = 17;
            float rusToUsd = 88;
            float correncyCount;

            Console.WriteLine("Добро пожаловать в личный кабинет. Выбирете вашу операцию.");
            Console.WriteLine ("1 -  Проверка баланса. 2 - Сконвертировать валюту. 3 - Выйти из кабинета");
            userInput = Console.ReadLine();

            while (userInput != "3")
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine($"Ваш баланс равен {usd} долларов, {pln} злотых, {rus} рублей");
                        Console.WriteLine("1 -  Проверка баланса. 2 - Сконвертировать валюту. 3 - Выйти из кабинета");
                        userInput = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Выбор валют для конверсии:  1 - USD в PLN, 2 -  PLN в USD, 3 - USD в RUS," +
                            "4 - PLN в RUS, 5 - RUS в PLN, 6 - RUS в USD");
                        currencySelection = Console.ReadLine();

                        switch (currencySelection)
                        {
                            case "1":
                                Console.WriteLine("Сколько долларов(USD) сконвертировать в злотые(PLN)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= usd)
                                {
                                    usd -= correncyCount;
                                    pln += correncyCount * usdToPln;
                                    Console.WriteLine("Конверсия долларов(USD) v  злотые(PLN) успешна.");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Сколько злотых(PLN) сконвертировать в доллары(USD)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= pln)
                                {
                                    pln -= correncyCount;
                                    usd += correncyCount / usdToPln;
                                    Console.WriteLine("Конверсия  злотых(PLN) в доллары(USD) успешна. ");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            case "3":
                                Console.WriteLine("Сколько долларов(USD) сконвертировать в рубли(RUS)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= usd)
                                {
                                    usd -= correncyCount;
                                    rus += correncyCount * usdToRus;
                                    Console.WriteLine("Конверсия долларов(USD) в рубли(RUS) успешна.");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            case "4":
                                Console.WriteLine("Сколько злотых(PLN) сконвертировать в рубли(RUS)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= pln)
                                {
                                    pln -= correncyCount;
                                    rus += correncyCount * plnToRus;
                                    Console.WriteLine("Конверсия злотых(USD) в рубли(RUS) успешна.");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            case "5":
                                Console.WriteLine("Сколько рублей(RUS) сконвертировать в злотые(PLN)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= rus)
                                {
                                    rus -= correncyCount;
                                    pln += correncyCount / rusToPln;
                                    Console.WriteLine("Конверсия рублей(Rus) в злотые(RUS) успешна.");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            case "6":
                                Console.WriteLine("Сколько рублей(RUS) сконвертировать в доллары(USD)?");
                                correncyCount = Convert.ToSingle(Console.ReadLine());
                                if (correncyCount <= rus)
                                {
                                    rus -= correncyCount;
                                    usd += correncyCount / rusToUsd;
                                    Console.WriteLine("Конверсия рублей(Rus) в доллары(USD) успешна.");
                                }
                                else
                                {
                                    Console.WriteLine("Не достаточно средств, проверьте баланс.");
                                }
                                break;

                            default:
                                Console.WriteLine("Добро пожаловать в личный кабинет. Выбирете вашу операцию.");
                                Console.WriteLine("1 -  Проверка баланса. 2 - Сконвертировать валюту. 3 - Выйти из кабинета");
                                userInput = Console.ReadLine();
                                break;
                        }
                        Console.WriteLine("Добро пожаловать в личный кабинет. Выбирете вашу операцию.");
                        Console.WriteLine("1 -  Проверка баланса. 2 - Сконвертировать валюту. 3 - Выйти из кабинета");
                        userInput = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Добро пожаловать в личный кабинет. Выбирете вашу операцию.");
                        Console.WriteLine("1 -  Проверка баланса. 2 - Сконвертировать валюту. 3 - Выйти из кабинета");
                        userInput = Console.ReadLine();
                        break;
                }
            }
            if (userInput == "3");
                Console.WriteLine("Выход из личного кабинета.");
        }
    }
}
