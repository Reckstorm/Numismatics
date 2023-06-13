namespace Numismatics
{
    partial class Numismatics
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Content_pnl = new Panel();
            UserName_lb = new Label();
            Logout_btn = new Button();
            Buy_btn = new Button();
            Exchange_btn = new Button();
            Balance_lb = new Label();
            MyCoins_btn = new Button();
            Blog_btn = new Button();
            Download_btn = new Button();
            Controls_pnl = new Panel();
            Controls_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // Content_pnl
            // 
            Content_pnl.AutoScroll = true;
            Content_pnl.Location = new Point(310, 2);
            Content_pnl.Name = "Content_pnl";
            Content_pnl.Size = new Size(921, 701);
            Content_pnl.TabIndex = 1;
            // 
            // UserName_lb
            // 
            UserName_lb.AutoSize = true;
            UserName_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            UserName_lb.Location = new Point(3, 7);
            UserName_lb.Name = "UserName_lb";
            UserName_lb.Size = new Size(83, 20);
            UserName_lb.TabIndex = 0;
            UserName_lb.Text = "UserName";
            // 
            // Logout_btn
            // 
            Logout_btn.Location = new Point(215, 3);
            Logout_btn.Name = "Logout_btn";
            Logout_btn.Size = new Size(94, 29);
            Logout_btn.TabIndex = 1;
            Logout_btn.Text = "Logout";
            Logout_btn.UseVisualStyleBackColor = true;
            Logout_btn.Click += Logout_btn_Click;
            // 
            // Buy_btn
            // 
            Buy_btn.Location = new Point(3, 116);
            Buy_btn.Name = "Buy_btn";
            Buy_btn.Size = new Size(306, 48);
            Buy_btn.TabIndex = 2;
            Buy_btn.Text = "Buy";
            Buy_btn.UseVisualStyleBackColor = true;
            Buy_btn.Click += Buy_btn_Click;
            // 
            // Exchange_btn
            // 
            Exchange_btn.Location = new Point(3, 170);
            Exchange_btn.Name = "Exchange_btn";
            Exchange_btn.Size = new Size(306, 48);
            Exchange_btn.TabIndex = 3;
            Exchange_btn.Text = "Exchange";
            Exchange_btn.UseVisualStyleBackColor = true;
            Exchange_btn.Click += Exchange_btn_Click;
            // 
            // Balance_lb
            // 
            Balance_lb.AutoSize = true;
            Balance_lb.Location = new Point(3, 27);
            Balance_lb.Name = "Balance_lb";
            Balance_lb.Size = new Size(61, 20);
            Balance_lb.TabIndex = 4;
            Balance_lb.Text = "Balance";
            // 
            // MyCoins_btn
            // 
            MyCoins_btn.Location = new Point(3, 278);
            MyCoins_btn.Name = "MyCoins_btn";
            MyCoins_btn.Size = new Size(306, 48);
            MyCoins_btn.TabIndex = 5;
            MyCoins_btn.Text = "My Coins";
            MyCoins_btn.UseVisualStyleBackColor = true;
            MyCoins_btn.Click += MyCoins_btn_Click;
            // 
            // Blog_btn
            // 
            Blog_btn.Location = new Point(3, 224);
            Blog_btn.Name = "Blog_btn";
            Blog_btn.Size = new Size(306, 48);
            Blog_btn.TabIndex = 6;
            Blog_btn.Text = "Blog";
            Blog_btn.UseVisualStyleBackColor = true;
            Blog_btn.Click += Blog_btn_Click;
            // 
            // Download_btn
            // 
            Download_btn.Location = new Point(3, 387);
            Download_btn.Name = "Download_btn";
            Download_btn.Size = new Size(306, 48);
            Download_btn.TabIndex = 7;
            Download_btn.Text = "Download Log";
            Download_btn.UseVisualStyleBackColor = true;
            Download_btn.Click += Download_btn_Click;
            // 
            // Controls_pnl
            // 
            Controls_pnl.BackColor = SystemColors.ControlDark;
            Controls_pnl.Controls.Add(Download_btn);
            Controls_pnl.Controls.Add(Blog_btn);
            Controls_pnl.Controls.Add(MyCoins_btn);
            Controls_pnl.Controls.Add(Balance_lb);
            Controls_pnl.Controls.Add(Exchange_btn);
            Controls_pnl.Controls.Add(Buy_btn);
            Controls_pnl.Controls.Add(Logout_btn);
            Controls_pnl.Controls.Add(UserName_lb);
            Controls_pnl.Location = new Point(0, 2);
            Controls_pnl.Name = "Controls_pnl";
            Controls_pnl.Size = new Size(312, 701);
            Controls_pnl.TabIndex = 0;
            // 
            // Numismatics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1232, 703);
            Controls.Add(Content_pnl);
            Controls.Add(Controls_pnl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Numismatics";
            Text = "Form1";
            FormClosed += Numismatics_FormClosed;
            Controls_pnl.ResumeLayout(false);
            Controls_pnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Content_pnl;
        private Label UserName_lb;
        private Button Logout_btn;
        private Button Buy_btn;
        private Button Exchange_btn;
        private Label Balance_lb;
        private Button MyCoins_btn;
        private Button Blog_btn;
        private Button Download_btn;
        private Panel Controls_pnl;
    }
}