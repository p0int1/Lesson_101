using System;
using System.Collections;
//Создайте метод, который в качестве аргумента принимает массив целых чисел и возвращает 
//коллекцию квадратов всех нечетных чисел массива. Для формирования коллекции 
//используйте оператор yield. 

namespace Addition
{
    class Program
    {
        public static IEnumerable Method(int[] arr)
        {
            foreach (int item in arr)
            {
                if (item % 2 == 1)
                {
                    yield return item * item;
                }
            }
        }

        static void Main(string[] args)
        {
            int[] mass = { 2, 5, 6, 8, 0, 3, 45, 65, 56 };
            foreach (int item in Method(mass))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
