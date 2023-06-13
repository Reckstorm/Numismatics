using Numismatics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatics
{
    public partial class ExchangeCoin : BuyCoin
    {
        public int SelectedCoinID { get; set; }
        public List<Coin>? CoinList { get; set; }
        public ExchangeCoin()
        {
            InitializeComponent();
            base.Res_lb.Visible = false;
            base.Buy_btn.Visible = false;
            this.PriceMy_lb.Text = string.Empty;
            this.ResNew_lb.Text = string.Empty;
        }

        public void SetCurrentUserData(User currentUser)
        {
            CoinList = currentUser.Coins;
            CoinList.ForEach(coin => this.MyCoin_cb.Items.Add(coin.Name));
        }

        private void MyCoin_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Coin temp = CoinList.Find(coin => coin.Name.Equals(MyCoin_cb.SelectedItem));
            PriceMy_lb.Text = temp.Price.ToString();
            SelectedCoinID = temp.ID;
        }

        private void Exchange_btn_Click(object sender, EventArgs e)
        {
            Numismatics parent = this.Parent.Parent as Numismatics;
            double price = double.Parse(base.Price_lb.Text);
            double myPrice = PriceMy_lb.Text.Equals(string.Empty) ? 0 : double.Parse(this.PriceMy_lb.Text);
            if (price.Equals(myPrice))
            {
                Coin tempCoin = parent.MyContext.Coins.FirstOrDefault(x => x.ID.Equals(CoinID));
                Coin tempCoinMy = parent.MyContext.Coins.FirstOrDefault(x => x.ID.Equals(SelectedCoinID));
                foreach (User u in parent.MyContext.Users)
                {
                    if (u.Coins.Any(x => x.ID.Equals(tempCoin.ID)))
                    {
                        u.Coins.Remove(tempCoin);
                        u.Coins.Add(tempCoinMy);
                        break;
                    }
                }
                parent.CurrentUser.Coins.Add(tempCoin);
                parent.CurrentUser.Coins.Remove(tempCoinMy);
                this.ResNew_lb.ForeColor = Color.Green;
                this.ResNew_lb.Text = "Success";
                parent.MyContext.Update(tempCoin);
                parent.MyContext.Update(tempCoinMy);
                parent.MyContext.SaveChanges();
            }
            else
            {
                this.ResNew_lb.ForeColor = Color.Red;
                this.ResNew_lb.Text = "Error";
            }
        }
    }
}
