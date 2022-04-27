using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Cl_Company
    {
        protected string Name;
        protected int persons;
        protected int money;

        public void show() // Печать информации о компании
        {
            Console.WriteLine("В компании {0} трудятся {1} сотрудников. Фонд заработной платы: {2}",Name, persons, money);
        }
        public int averageSalary() // Вычисление средней зарплаты
        {
            return money / persons;
        }
        public int maxPersons(int salary) // Средняя зарплата
        {
            return money / persons;
        }
        public int minus(int minus1, int minus2) // Определение суммы налогов в ПФ
        {
            return money * (minus1 + minus2) / 100;
        }
    }
    class InsCompany : Cl_Company
    {
        int counts; //количество застрахованных лиц
        int summaplus; // сумма страховых взносов
        int summaminus; // сумма страховых выплат
                        //-----------описание методов-----------------
                        //вычисление среднего размера страховых взносов
        public int averageInsSumma()
        {
            return summaplus / counts;
        }
    }; // конец описания класса InsCompany
    class AvtoCompany : Cl_Company
    {
        int count; //количество автомобилей
        int haul; // объём грузоперевозок
                  //---- ------описание методов---------------
                  // определение среднего объема грузоперевозок
        public int averageAvto()
        {
            return haul / count;
        }
    } // конец описания класса AvtoCompany
}
