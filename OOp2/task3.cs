using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    interface ICalculatorable
    {
        void Name();
        void Salary();
        void VacationDays();

    }


    class Proqraming : ICalculatorable
    {
        public void Name()
        {
            Console.WriteLine("Kamran");
        }

        public void Salary()
        {
            Console.WriteLine("20000$");
        }

        public void VacationDays()
        {
            Console.WriteLine("5 day");
        }
    }
    class Design : ICalculatorable
    {
        public void Name()
        {
            Console.WriteLine("Nigar");
        }

        public void Salary()
        {
            Console.WriteLine("12000$");
        }

        public void VacationDays()
        {
            Console.WriteLine("5 day");
        }
    }
    class Manager : ICalculatorable
    {
        public void Name()
        {
            Console.WriteLine("David");
        }

        public void Salary()
        {
            Console.WriteLine("18000$");
        }

        public void VacationDays()
        {
            Console.WriteLine("5 day");
        }
    }

}