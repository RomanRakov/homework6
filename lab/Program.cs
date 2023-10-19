using System;
namespace lab
{
    enum ТипБанковскогоСчета
    {
        Текущий,
        Сберегательный,
        Кредитный
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лаборотная работа\nУпражнение 7.1\nСоздать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета");
            БанковскийСчет счет = new БанковскийСчет();
            счет.Number = 1234567890;
            счет.Balance = 1234;
            счет.Type = ТипБанковскогоСчета.Текущий;
            счет.ВывестиИнформацию();

            Console.WriteLine("\nУпражнение 7.2\nИзменить класс счет в банке из упражнения 7.1 таким образом, чтобы номер счета генерировался сам и был уникальным");
            БанковскийСчет2 счет2 = new БанковскийСчет2();
            Random rnd = new Random();
            int случайныйномер = rnd.Next();
            счет2.Randomnumber = случайныйномер;
            счет2.Balance = 1234567;
            счет2.Type = ТипБанковскогоСчета.Кредитный;
            счет2.info();

            Console.WriteLine("\nУпражнение 7.3\nДобавить в класс счет в банке два метода: снять со счета и положить на счет");
            БанковскийСчет3 счет3 = new БанковскийСчет3();
            счет3.Balance = 1234;
            счет3.Type = ТипБанковскогоСчета.Сберегательный;
            int случайныйномер2 = rnd.Next();
            счет3.Randomnumber = случайныйномер2;
            счет3.info();
            Console.WriteLine("Сколько вы хотите снять?");
            int.TryParse(Console.ReadLine(), out int суммаснятия);
            счет3.takeoff(суммаснятия);
            счет3.info();
            Console.WriteLine("Сколько вы хотите положить на счет?");
            int.TryParse(Console.ReadLine(), out int пополнение);
            счет3.put(пополнение);
            счет3.info();

            Console.WriteLine("\nДомашнее задание 7.1\nРеализовать класс для описания здания\nВведите высоту здания:");
            описаниездания здание = new описаниездания();
            int.TryParse(Console.ReadLine(), out int height);
            здание.Height = height;
            Console.WriteLine("Введите этажность здания:");
            int.TryParse(Console.ReadLine(), out int floors);
            здание.Floors = floors;
            Console.WriteLine("Введите количество квартир:");
            int.TryParse(Console.ReadLine(), out int apartments);
            здание.Apartments = apartments;
            Console.WriteLine("Введите количество подъездов:");
            int.TryParse(Console.ReadLine(), out int entrances);
            здание.Entrances = entrances;
            здание.info();
            Console.ReadKey();
        }
    }
}


