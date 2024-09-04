using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public MainAccount mainAccount;
        public SecondAccount secondAccount;
        public Form1()
        {
            InitializeComponent();
            mainAccount = new MainAccount(100);
            secondAccount = new SecondAccount(100);
            mainAccount.secondAcc = secondAccount;
            mainAccount.AddMoney(200);
            secondAccount.AddMoney(400);
            TxtMainBalance.Text = mainAccount.Balance.ToString("C");
            TxtSecondBalance.Text = secondAccount.Balance.ToString("C");
        }

        private void BtnMainAdd_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(TxtMainAdd.Text, out decimal value))
            {
                mainAccount.AddMoney(value);
                TxtMainBalance.Text = mainAccount.Balance.ToString("C");
            }
        }

        private void BtnMainPay_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(TxtMainPayment.Text, out decimal value))
            {
                mainAccount.PayMoney(value);
                TxtMainBalance.Text = mainAccount.Balance.ToString("C");
                TxtSecondBalance.Text = secondAccount.Balance.ToString("C");
            }

        }

        private void BtnSecondAdd_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(TxtSecondAdd.Text, out decimal value))
            {
                secondAccount.AddMoney(value);
                TxtSecondBalance.Text = secondAccount.Balance.ToString("C");
            }
        }

        private void BtnSecondPay_Click(object sender, System.EventArgs e)
        {
            if (decimal.TryParse(TxtSecondPayment.Text, out decimal value))
            {
                secondAccount.PayMoney(value);
                TxtSecondBalance.Text = secondAccount.Balance.ToString("C");

            }
        }
    }
}
