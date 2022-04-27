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
    class InsCompany : Company
    {
        int counts; //количество застрахованных лиц
        int summaplus; // сумма страховых взносов
        int summaminus; // сумма страховых выплат
                        //-----------описание методов-----------------
                        //вычисление среднего размера страховых взносов
        public InsCompany(string name, int persons, int money, int counts, int summaplus, int summaminus) : base(name, persons, money)
        {
            this.counts = counts;
            this.summaplus = summaplus;
            this.summaminus = summaminus;
        }
        public int Summaplus //свойство
        {
            get
            {
                return summaplus;
            }
        }
        // печать информации о страховой компании
        new public void show()
        {
            base.show();
            Console.WriteLine
            ("застрахованных лиц " + counts +" взносы " + summaplus +" выплаты " + summaminus);
        }
        //вычисление среднего размера страховых взносов
        public int averageIns()
        {
            return summaplus / counts;
        }
    }
}
