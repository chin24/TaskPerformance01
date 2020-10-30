using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueingForm
{
    
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<String> CashierQueue;
        public static string peekNumber = "";
       
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<String>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
        public void peekNumberGenerator()
        {
            peekNumber = CashierQueue.Peek();
        }
    }

}
