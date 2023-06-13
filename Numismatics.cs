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
            Load += (s, e) => CurrentUser = MyContext.Users.First();
            //Load += (s, e) => this.CurrentUser = MyContext.Users.FirstOrDefault(x => x.Login.Equals("a"));
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


    }
}