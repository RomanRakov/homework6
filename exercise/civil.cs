using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class civil : war
    {
        private string country;
        public string Country
        {  
            get
            { 
                return country; 
            } 
            set 
            {  
                country = value; 
            } 
        }
        public civil(string answer)
        {
            if (answer == "нет" || answer == "Нет")
                System.Environment.Exit(0);
        }
        public civil()
        {
            Console.WriteLine("Вывожу информацию....");
        }
        public void info()
        {
            Console.WriteLine($"\nНазвание войны: {Name}\nГод начала войны: {Startyear}\nГод окончания войны: {Endyear}" +
                    $"\nПотери в войне: {Losses}\nКоличество стран-участников: {Participants}" +    
                    $"\nСтрана, на территории которой состоялась гражданская война: {Country}");
        }
    }
}
