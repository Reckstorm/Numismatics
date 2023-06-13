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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Numismatics
{
    public partial class PostView : UserControl
    {
        public int PostID { get; set; }
        public PostView()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        public void SetData(Post post)
        {
            this.PostID = post.ID;
            this.Name_lb.Text = post.Name;
            this.Text_tb.Text = post.Text;
            this.Date_lb.Text = post.Date.ToString();
        }
    }
}
