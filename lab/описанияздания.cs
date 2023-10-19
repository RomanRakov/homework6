using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    public class описаниездания
    {
        private static int lastnumber = 1; 
        private int number;
        private int height;
        private int floors;
        private int apartments;
        private int entrances;
        public описаниездания()
        {
            number = GenerateNumber();
        }
        public int Number
        {
            get 
            { 
                return number; 
            }
        }
        public int Height
        {
            get 
            { 
                return height; 
            }
            set 
            { 
                height = value; 
            }
        }
        public int Floors
        {
            get 
            { 
                return floors; 
            }
            set 
            { 
                floors = value; 
            }
        }
        public int Apartments
        {
            get 
            { 
                return apartments; 
            }
            set 
            { 
                apartments = value; 
            }
        }
        public int Entrances
        {
            get 
            { 
                return entrances; 
            }
            set 
            { 
                entrances = value; 
            }
        }
        public double FloorHeight
        {
            get 
            { 
                return (double)Height / Floors; 
            }
        }
        public double ApartmentsInEntrance
        {
            get 
            { 
                return (double)Apartments / Entrances; 
            }
        }
        public double ApartmentsOnFloor
        {
            get 
            { 
                return (double)Apartments / Floors; 
            }
        }
        private static int GenerateNumber()
        {
            return lastnumber++;
        }
        public void info()
        {
            Console.WriteLine($"\nНомер здания: {Number}\nВысота: {Height}\nЭтажность: {Floors}\nКоличество квартир: {Apartments}" +
                $"\nКоличество подъездов: {Entrances}\nВысота этажа: {FloorHeight}" +
                $"\nКоличество квартир в подъезде: {ApartmentsInEntrance}\nколичество квартир на этаже: {ApartmentsOnFloor}");
        }
    }
}
