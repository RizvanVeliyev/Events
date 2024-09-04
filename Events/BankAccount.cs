using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public class BankAccount
    {
        public EventHandler OverDrawnEvent;
        public decimal Balance { get; set; }
        public BankAccount(decimal balance)
        {
            Balance = balance;
            OverDrawnEvent = new EventHandler(OverDrawnMethod);
        }
        public virtual void OnOverDrawnEventHandler(decimal subAmount)
        {
            if (OverDrawnEvent != null)
                OverDrawnEvent.Invoke(this, new OverDrawnArgs(subAmount));
        }

        public  void AddMoney(decimal balance)
        {
            Balance += balance;
        }
        public void OverDrawnMethod(object sender, EventArgs e)
        {
            OverDrawnArgs args = (OverDrawnArgs)e;
            MainAccount BankAccount=sender as MainAccount;
            if (BankAccount != null)
            {
                MessageBox.Show($"Kasibsan! Esas Balansdaki pul:{BankAccount.Balance} Ehtiyat balansdaki pul{BankAccount.secondAcc.Balance} Catmayan pul:{args.SubAmount}");
            }
            else 
            {
                SecondAccount BankAccount2=sender as SecondAccount;
                MessageBox.Show($"Kasibsan! Ehtiyat balansdaki pul:{BankAccount2.Balance} Catmayan pul:{args.SubAmount}");

            }
        }
    }
}
