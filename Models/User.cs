using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class User
    {
        public int ID { get; set; }
        public double Balance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Coin> Coins { get; set; }
        public List<Post> Posts { get; set; }
        public User() 
        { 
            ID = 0;
            Balance = 0;
            Login = string.Empty;
            Password = string.Empty;
            Coins = null;
            Posts = null;
        }
        public User(int iD, double balance, string login, string password, List<Coin> coins, List<Post> posts)
        {
            ID = iD;
            Balance = balance;
            Login = login;
            Password = password;
            Coins = coins;
            Posts = posts;
        }
    }
}
