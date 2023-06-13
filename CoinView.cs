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
    public partial class CoinView : UserControl
    {
        public CoinView()
        {
            InitializeComponent();
        }

        public void SetData(Coin coin)
        {
            this.Name_lb.Text = coin.Name;
            this.Description_lb.Text = coin.Description;
            this.Price_lb.Text = coin.Price.ToString();
        }
    }
}
