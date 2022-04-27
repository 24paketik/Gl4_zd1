using System;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ввод данных
            Cl_Company ob = new Cl_Company();
            InsCompany ob1 = new InsCompany();
            // Обработка данных

            // Вывод данных
            ob.show();
            ob1.show();
        }
    }
}
