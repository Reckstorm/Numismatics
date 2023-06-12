using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numismatics.Models
{
    public class Log
    {
        public int ID { get; set; }
        public int UserFromID { get; set; }
        public int UserToID { get; set; }
        public int CoinID { get; set; }
        public DateTime Date { get; set; }
        public Log()
        {
            ID = 0;
            UserFromID = 0;
            UserToID = 0;
            CoinID = 0;
            Date = DateTime.MinValue;
        }
        public Log(int iD, int userFromID, int userToID, int coinID, DateTime date)
        {
            ID = iD;
            UserFromID = userFromID;
            UserToID = userToID;
            CoinID = coinID;
            Date = date;
        }
    }
}
