using System.Windows.Forms;

namespace Events
{
    public class MainAccount : BankAccount
    {
        public BankAccount secondAcc { get; set; }
        public MainAccount(decimal balance) : base(balance)
        {
        }

        public void PayMoney(decimal payment)
        {
            if (Balance + secondAcc.Balance >= payment)
            {
                if (payment <= Balance) Balance -= payment;
                else if (payment > Balance)
                {
                    payment -= Balance;
                    Balance = 0;
                    secondAcc.Balance -= payment;
                }
            }
            else OnOverDrawnEventHandler(payment - (Balance + secondAcc.Balance));
            
        }
    }
}
