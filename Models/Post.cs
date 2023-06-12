using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Post() 
        { 
            ID = 0;
            Name = string.Empty;
            Text = string.Empty;
            Date = DateTime.MinValue;
        }
        public Post(int id, string name, string text, DateTime date)
        {
            ID = id;
            Name = name;
            Text = text;
            Date = date;
        }
    }
}
