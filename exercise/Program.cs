using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение\nНаписать программу, в которой реализованы все принципы ООП\nНачать выполнение задания?");
            nuclearweapon War2 = new nuclearweapon(Console.ReadLine());
            War2.Name = "Вторая мировая война";
            War2.Startyear = 1939;
            War2.Endyear = 1945;
            War2.Losses = "от 55 до 80 миллионов человек";
            War2.Participants = 62;
            War2.Number = 2;
            War2.info();

            Console.WriteLine("Продолжить выполнение задания?");
            civil Spain = new civil(Console.ReadLine());
            Spain.Name = "Гражданская война в Испании";
            Spain.Startyear = 1936;
            Spain.Endyear = 1939;
            Spain.Losses = "около 300000 человек";
            Spain.Participants = 1;
            Spain.Country = "Испания";
            Spain.info();

            Console.WriteLine("Продолжить выполнение задания?");
            fleet Fleet = new fleet(Console.ReadLine());
            Fleet.Name = "Русско-турецкая война";
            Fleet.Startyear = 1787;
            Fleet.Endyear = 1791;
            Fleet.Losses = "около 11000 человек";
            Fleet.Participants = 3;
            Fleet.Sea = "Черное море";
            Fleet.info();
            Console.ReadKey();
        }
    }
}
