using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Calendar : IEnumerable, IEnumerator
    {
        string [] title = { "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" };
        int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        int[] day = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public IEnumerator GetEnumerator() // реализация интерфейса IEnumerable
        {
            return this;
        }

        int position = -1;

        public object Current // реализация интерфейса IEnumerator
        {
            get { return month[position] + " - " + day[position]; }
        }

        public bool MoveNext() // реализация интерфейса IEnumerator
        {
            if (position < month.Length - 1)
            {
                position++;
                return true;
            }

            return false;
        }

        public void Reset() // реализация интерфейса IEnumerator
        {
            position = -1;
        }

        public string GetMonthByNumber(int number)
        {
            string mounths = $"Месяц под номером {number} это - " + title[number - 1];
            
            return mounths;
        }

        public string GetMonthByDays(int days)
        {
            string months = string.Empty;

            for (int i = 0; i < day.Length; i++)
            {
                if (day[i] == days)
                {
                    months += ", " + month[i] + " - " + title[i];
                }
            }

            months = $"Месяцы с {days} днями: " + months.Substring(2, months.Length-2);

            return months;
        }

    }
}
