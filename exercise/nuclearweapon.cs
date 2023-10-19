using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class nuclearweapon : war
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public nuclearweapon(string answer)
        {
            if (answer == "нет" || answer == "Нет")
                System.Environment.Exit(0);
        }
        public nuclearweapon()
        {
            Console.WriteLine("Вывожу информацию....");
        }
        public void info()
        {
            Console.WriteLine($"\nНазвание войны: {Name}\nГод начала войны: {Startyear}\nГод окончания войны: {Endyear}" +
                $"\nПотери в войне: {Losses}\nКоличество стран-участников: {Participants}" +  
                $"\nКоличество сброшенных ядерных боеголовок: {number}");
        }
    }
}
