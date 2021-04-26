using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name + "! " + "Сегодня" + " {" + DateTime.Now + "}");
        }
    }
}