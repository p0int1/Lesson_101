using System;
//Создайте коллекцию, в которой бы хранились наименования 12 месяцев, порядковый номер и 
//количество дней в соответствующем месяце. Реализуйте возможность выбора месяцев, как по 
//порядковому  номеру, так  и  количеству  дней  в  месяце, при  этом  результатом  может  быть  не 
//только один месяц. 

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();

            Console.WriteLine(calendar.GetMonthByNumber(6));

            Console.WriteLine(calendar.GetMonthByDays(30));

            Console.ReadKey();
        }
    }
}
