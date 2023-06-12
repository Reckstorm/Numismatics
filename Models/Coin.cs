using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Coin
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Coin() 
        { 
            ID = 0;
            Price = 0;
            Name = string.Empty;
            Description = string.Empty;
        }
        public Coin(int id, double price, string name, string description)
        {
            ID = id;
            Price = price;
            Name = name;
            Description = description;
        }
    }
}
