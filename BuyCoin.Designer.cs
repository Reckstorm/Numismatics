namespace Numismatics
{
    partial class BuyCoin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Name_lb = new Label();
            Description_lb = new Label();
            Price_lb = new Label();
            Buy_btn = new Button();
            Res_lb = new Label();
            SuspendLayout();
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(41, 21);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(49, 20);
            Name_lb.TabIndex = 0;
            Name_lb.Text = "Name";
            // 
            // Description_lb
            // 
            Description_lb.AutoSize = true;
            Description_lb.Location = new Point(240, 21);
            Description_lb.Name = "Description_lb";
            Description_lb.Size = new Size(85, 20);
            Description_lb.TabIndex = 1;
            Description_lb.Text = "Description";
            // 
            // Price_lb
            // 
            Price_lb.AutoSize = true;
            Price_lb.Location = new Point(541, 21);
            Price_lb.Name = "Price_lb";
            Price_lb.Size = new Size(41, 20);
            Price_lb.TabIndex = 2;
            Price_lb.Text = "Price";
            // 
            // Buy_btn
            // 
            Buy_btn.Location = new Point(794, 17);
            Buy_btn.Name = "Buy_btn";
            Buy_btn.Size = new Size(94, 29);
            Buy_btn.TabIndex = 3;
            Buy_btn.Text = "Buy";
            Buy_btn.UseVisualStyleBackColor = true;
            Buy_btn.Click += Buy_btn_Click;
            // 
            // Res_lb
            // 
            Res_lb.AutoSize = true;
            Res_lb.Location = new Point(677, 21);
            Res_lb.Name = "Res_lb";
            Res_lb.Size = new Size(49, 20);
            Res_lb.TabIndex = 4;
            Res_lb.Text = "Result";
            // 
            // BuyCoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(Res_lb);
            Controls.Add(Buy_btn);
            Controls.Add(Price_lb);
            Controls.Add(Description_lb);
            Controls.Add(Name_lb);
            Name = "BuyCoin";
            Size = new Size(938, 64);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_lb;
        private Label Description_lb;
        protected Label Price_lb;
        protected Button Buy_btn;
        protected Label Res_lb;
    }
}
