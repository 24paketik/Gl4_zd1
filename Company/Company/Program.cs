using System;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, // параметр цикла
                min, // наименьшая сумма страховыхвзносов
                temp, j; //вспомогательные переменные
            InsCompany[] CityCompany = new InsCompany[4];
            // Создание и инициализация объектов
            CityCompany[0] = new InsCompany
            ("ABC", 100, 100000, 111, 111111, 1111);
            CityCompany[1] = new InsCompany
            ("BCD", 200, 200000, 222, 222222, 2222);
            CityCompany[2] = new InsCompany
            ("CDE", 300, 300000, 333, 333333, 3333);
            CityCompany[3] = new InsCompany
            ("DEF", 400, 400000, 444, 444444, 4444);
            // печать информации о страховых компаниях
            min = CityCompany[0].Summaplus; j = 0;
            for (i = 1;i<4; i ++)
            {
                temp = CityCompany[i].Summaplus;
                if (temp<min)
                {
                    min = temp;
                    j= i;
                }
            }
            Console.WriteLine("\n наименьшая сумма взносов в компании " + CityCompany[j].Name);
        }
    }
}
