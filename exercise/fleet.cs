using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise
{
    class fleet : war
    {
        private string sea;
        public  string Sea
        { 
            get 
            { 
                return sea; 
            } 
            set 
            {  
                sea = value; 
            } 
        }
        public fleet(string answer)
        {
            if (answer == "нет" || answer == "Нет")
                System.Environment.Exit(0);
        }
        public fleet()
        {
            Console.WriteLine("Вывожу информацию....");
        }
        public void info()
        {
            Console.WriteLine($"\nНазвание войны: {Name}\nГод начала войны: {Startyear}\nГод окончания войны: {Endyear}" +
                    $"\nПотери в войне: {Losses}\nКоличество стран-участников: {Participants}" +
                    $"\nМоре, на территории которого проходили сражения: {sea}");
        }
    }
}
