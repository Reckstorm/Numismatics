namespace Numismatics
{
    partial class CoinView
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
            SuspendLayout();
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Location = new Point(28, 13);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(49, 20);
            Name_lb.TabIndex = 0;
            Name_lb.Text = "Name";
            // 
            // Description_lb
            // 
            Description_lb.AutoSize = true;
            Description_lb.Location = new Point(235, 13);
            Description_lb.Name = "Description_lb";
            Description_lb.Size = new Size(85, 20);
            Description_lb.TabIndex = 1;
            Description_lb.Text = "Description";
            // 
            // Price_lb
            // 
            Price_lb.AutoSize = true;
            Price_lb.Location = new Point(730, 13);
            Price_lb.Name = "Price_lb";
            Price_lb.Size = new Size(41, 20);
            Price_lb.TabIndex = 2;
            Price_lb.Text = "Price";
            // 
            // CoinView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(Price_lb);
            Controls.Add(Description_lb);
            Controls.Add(Name_lb);
            Name = "CoinView";
            Size = new Size(921, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_lb;
        private Label Description_lb;
        private Label Price_lb;
    }
}
