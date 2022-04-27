using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Company
    {
        protected string name;
        protected int persons;
        protected int money;

        public Company(string name, int persons, int money)
        {
            this.name = name;
            this.persons = persons;
            this.money = money;
        }
        public string Name
        {
            get { return name; }
        }
        public void show() // Печать информации о компании
        {
            Console.WriteLine("В компании {0} трудятся {1} сотрудников. Фонд заработной платы: {2}",name, persons, money);
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
}
