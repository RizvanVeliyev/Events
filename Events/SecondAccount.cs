using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public class SecondAccount : BankAccount
    {
        public SecondAccount(decimal balance) : base(balance)
        {
        }
        public void PayMoney(decimal amount)
        {
            if (amount <= Balance) Balance -= amount;
            else OnOverDrawnEventHandler(amount - Balance);
        }
    }
}
