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
    public partial class PostControl : UserControl
    {
        public int? PostID { get; set; }
        public PostControl()
        {
            InitializeComponent();
            Load += (s, e) =>
            {
                DefaultData(s, e);
                this.Res_lb.Text = string.Empty;
            };
        }
        public void DefaultData(object sender, EventArgs e)
        {
            Numismatics parent = this.Parent.Parent as Numismatics;
            this.Name_tb.Text = string.Empty;
            this.Text_tb.Text = string.Empty;
            PostID = null;
        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            DefaultData(sender, e);
            this.Res_lb.Text = string.Empty;
        }
        private void Save_btn_Click(object sender, EventArgs e)
        {
            this.Res_lb.Text = string.Empty;
            Post temp;
            Numismatics parent = this.Parent.Parent as Numismatics;
            if (PostID != null)
            {
                temp = parent.MyContext.Posts.FirstOrDefault(x => x.ID.Equals(PostID));
                temp.Text = this.Text_tb.Text;
                temp.Name = this.Name_tb.Text;
                temp.Date = DateTime.Now;
                parent.MyContext.Update(temp);
                parent.MyContext.SaveChanges();
                Res_lb.ForeColor = Color.Green;
                Res_lb.Text = "Success";
            }
            else
            {
                temp = new Post();
                temp.Text = this.Text_tb.Text;
                temp.Name = this.Name_tb.Text;
                temp.Date = DateTime.Now;
                parent.MyContext.Posts.Add(temp);
                if (parent.CurrentUser.Posts == null) parent.CurrentUser.Posts = new List<Post>();
                parent.CurrentUser.Posts.Add(temp);
                parent.MyContext.SaveChanges();
                Res_lb.ForeColor = Color.Green;
                Res_lb.Text = "Success";
            }
            DefaultData(sender, e);
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            this.Res_lb.Text = string.Empty;
            Numismatics parent = this.Parent.Parent as Numismatics;
            if (PostID != null)
            {
                parent.MyContext.Remove(parent.MyContext.Posts.FirstOrDefault(x => x.ID.Equals(PostID)));
                parent.MyContext.SaveChanges();
                Res_lb.ForeColor = Color.Green;
                Res_lb.Text = "Success";
            }
            DefaultData(sender, e);
        }

        public void SetData(PostView post)
        {
            Numismatics parent = this.Parent.Parent as Numismatics;
            if (parent.CurrentUser.Posts != null && parent.CurrentUser.Posts.Any(x => x.ID.Equals(post.PostID)))
            {
                this.Name_tb.Text = post.Name_lb.Text;
                this.Text_tb.Text = post.Text_tb.Text;
                this.PostID = post.PostID;
            }
        }
    }
}
