namespace Numismatics
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Res_lb = new Label();
            Enter_btn = new Button();
            Exit_btn = new Button();
            Password_tb = new TextBox();
            label2 = new Label();
            Login_tb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // Res_lb
            // 
            Res_lb.AutoSize = true;
            Res_lb.Location = new Point(377, 281);
            Res_lb.Name = "Res_lb";
            Res_lb.Size = new Size(49, 20);
            Res_lb.TabIndex = 13;
            Res_lb.Text = "Result";
            // 
            // Enter_btn
            // 
            Enter_btn.Location = new Point(408, 229);
            Enter_btn.Name = "Enter_btn";
            Enter_btn.Size = new Size(94, 29);
            Enter_btn.TabIndex = 12;
            Enter_btn.Text = "Enter";
            Enter_btn.UseVisualStyleBackColor = true;
            Enter_btn.Click += Login_btn_Click;
            // 
            // Exit_btn
            // 
            Exit_btn.Location = new Point(298, 229);
            Exit_btn.Name = "Exit_btn";
            Exit_btn.Size = new Size(94, 29);
            Exit_btn.TabIndex = 11;
            Exit_btn.Text = "Exit";
            Exit_btn.UseVisualStyleBackColor = true;
            Exit_btn.Click += Exit_btn_Click;
            // 
            // Password_tb
            // 
            Password_tb.Location = new Point(377, 183);
            Password_tb.Name = "Password_tb";
            Password_tb.Size = new Size(125, 27);
            Password_tb.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 186);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "Password:";
            // 
            // Login_tb
            // 
            Login_tb.Location = new Point(377, 150);
            Login_tb.Name = "Login_tb";
            Login_tb.Size = new Size(125, 27);
            Login_tb.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 153);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Login:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(Res_lb);
            Controls.Add(Enter_btn);
            Controls.Add(Exit_btn);
            Controls.Add(Password_tb);
            Controls.Add(label2);
            Controls.Add(Login_tb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Res_lb;
        private Button Enter_btn;
        private Button Exit_btn;
        private TextBox Password_tb;
        private Label label2;
        private TextBox Login_tb;
        private Label label1;
    }
}