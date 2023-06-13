using Microsoft.Identity.Client;
using Numismatics.Models;
using static System.Net.Mime.MediaTypeNames;

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
            RenderBuy();
        }

        private void Exchange_btn_Click(object sender, EventArgs e)
        {
            RenderExchabge();
        }

        private void Blog_btn_Click(object sender, EventArgs e)
        {
            RenderPosts();
        }

        private void MyCoins_btn_Click(object sender, EventArgs e)
        {
            RenderCoins();
        }
        public void RenderBuy()
        {
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
        public void RenderExchabge()
        {
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
        public void RenderPosts()
        {
            this.Content_pnl.Controls.Clear();
            PostControl postControl = new PostControl();
            this.Content_pnl.Controls.Add(postControl);
            int x = 0;
            int y = postControl.Height + 2;
            foreach (Post c in MyContext.Posts)
            {
                PostView temp = new PostView();
                temp.SetData(c);
                temp.Location = new Point(x, y);
                temp.Click += (sender, e) =>
                {
                    postControl.SetData(temp);
                };
                this.Content_pnl.Controls.Add(temp);
                y += temp.Height + 2;
            }
        }
        public void RenderCoins()
        {
            this.Content_pnl.Controls.Clear();
            int x = 0;
            int y = 0;
            foreach (Coin c in MyContext.Coins)
            {
                if (CurrentUser.Coins.Contains(c))
                {
                    CoinView temp = new CoinView();
                    temp.SetData(c);
                    temp.Location = new Point(x, y);
                    this.Content_pnl.Controls.Add(temp);
                    y += temp.Height + 2;
                }
            }
        }

        private void Download_btn_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>();
            foreach (Log l in MyContext.Logs)
            {
                if (l.UserToID.Equals(CurrentUser.ID) || l.UserFromID.Equals(CurrentUser.ID))
                {
                    strings.Add($"ID: {l.ID} | From: {MyContext.Users.FirstOrDefault(x => x.ID.Equals(l.UserFromID)).Login} | To: {MyContext.Users.FirstOrDefault(x => x.ID.Equals(l.UserToID)).Login} | Coin: {MyContext.Coins.FirstOrDefault(x => x.ID.Equals(l.CoinID)).ID} - {MyContext.Coins.FirstOrDefault(x => x.ID.Equals(l.CoinID)).Name}");
                }
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, strings);
            }
        }

        public void SetBalance(double balance)
        {
            this.Balance_lb.Text = balance.ToString();
        }

        public void SetUserData(User user)
        {
            this.UserName_lb.Text = user.Login;
            this.Balance_lb.Text = user.Balance.ToString();
            CurrentUser = user;
        }

        private void Numismatics_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = true;
            this.CurrentUser = null;
            this.Balance_lb.Text = string.Empty;
            this.Content_pnl.Controls.Clear();
            this.Visible = false;
        }
    }
}