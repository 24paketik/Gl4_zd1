using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
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
            ("застрахованных лиц " + counts + " взносы " + summaplus + " выплаты " + summaminus);
        }
        //вычисление среднего размера страховых взносов
        public int averageIns()
        {
            return summaplus / counts;
        }
    }
}
