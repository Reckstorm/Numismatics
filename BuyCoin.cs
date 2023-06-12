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
    public partial class BuyCoin : UserControl
    {
        public int CoinID { get; set; }
        public BuyCoin()
        {
            InitializeComponent();
        }

        public void SetData(Coin coin)
        {
            this.Name_lb.Text = coin.Name;
            this.Description_lb.Text = coin.Description;
            this.Price_lb.Text = coin.Price.ToString();
            this.CoinID = coin.ID;
            this.Res_lb.Text = string.Empty;
        }

        private void Buy_btn_Click(object sender, EventArgs e)
        {
            Numismatics parent = this.Parent.Parent as Numismatics;
            double price = double.Parse(this.Price_lb.Text);
            if (parent.CurrentUser.Balance > price)
            {
                Coin tempCoin = parent.MyContext.Coins.FirstOrDefault(x => x.ID.Equals(CoinID));
                foreach (User u in parent.MyContext.Users)
                {
                    if (u.Coins.Any(x => x.ID.Equals(tempCoin.ID)))
                    {
                        u.Coins.Remove(tempCoin);
                        u.Balance += price;
                        break;
                    }
                }
                parent.CurrentUser.Balance -= price;
                parent.CurrentUser.Coins.Add(tempCoin);
                this.Res_lb.ForeColor = Color.Green;
                this.Res_lb.Text = "Success";
                parent.MyContext.Update(tempCoin);
                parent.MyContext.SaveChanges();
            }
            else
            {
                this.Res_lb.ForeColor = Color.Red;
                this.Res_lb.Text = "Error";
            }
        }
    }
}
