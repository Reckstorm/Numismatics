using Numismatics.Models;

namespace Numismatics
{
    public partial class Numismatics : Form
    {
        public Context MyContext = new Context();
        public User? CurrentUser;
        public Numismatics()
        {
            InitializeComponent();
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            CurrentUser = MyContext.Users.First();
            this.Content_pnl.Controls.Clear();
            int x = 0;
            int y = 0;
            foreach (Coin c in MyContext.Coins)
            {
                BuyCoin temp = new BuyCoin();
                if (!CurrentUser.Coins.Contains(c))
                {
                    temp.SetData(c);
                    temp.Location = new Point(x, y);
                    this.Content_pnl.Controls.Add(temp);
                    y += temp.Height + 2;
                }
            }
        }

        private void Exchange_btn_Click(object sender, EventArgs e)
        {
            CurrentUser = MyContext.Users.First();
            this.Content_pnl.Controls.Clear();
            int x = 0;
            int y = 0;
            foreach (Coin c in MyContext.Coins)
            {
                if (!CurrentUser.Coins.Contains(c))
                {
                    ExchangeCoin temp = new ExchangeCoin();
                    temp.SetData(c);
                    temp.SetCurrentUserData(CurrentUser);
                    temp.Location = new Point(x, y);
                    this.Content_pnl.Controls.Add(temp);
                    y += temp.Height + 2;
                }
            }
            
        }
    }
}