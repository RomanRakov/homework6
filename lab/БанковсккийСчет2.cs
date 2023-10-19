using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class БанковскийСчет2
    {
        private static int randomnumber;
        private double balance;
        private ТипБанковскогоСчета type;
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public ТипБанковскогоСчета Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public int Randomnumber
        {
            get
            {     
                return randomnumber++;
            }
            set
            {
                randomnumber = value;
            }
        }       
        public void info()
        {
            Console.WriteLine($"Номер счета: {randomnumber}\nБаланс: {balance}\nТип счета: {type}");
        }        
    }
}
