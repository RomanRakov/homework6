using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class БанковскийСчет
    {
        private uint number;
        private double balance;
        private ТипБанковскогоСчета type;
        public uint Number
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
        public void ВывестиИнформацию()
        {
            Console.WriteLine($"Номер счета: {number}\nБаланс: {balance}\nТип счета: {type}");
        }    
    }
}
