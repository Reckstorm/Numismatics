namespace Numismatics
{
    partial class PostView
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
            Date_lb = new Label();
            Text_tb = new TextBox();
            SuspendLayout();
            // 
            // Name_lb
            // 
            Name_lb.AutoSize = true;
            Name_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name_lb.Location = new Point(22, 14);
            Name_lb.Name = "Name_lb";
            Name_lb.Size = new Size(51, 20);
            Name_lb.TabIndex = 0;
            Name_lb.Text = "Name";
            // 
            // Date_lb
            // 
            Date_lb.AutoSize = true;
            Date_lb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Date_lb.Location = new Point(715, 14);
            Date_lb.Name = "Date_lb";
            Date_lb.Size = new Size(42, 20);
            Date_lb.TabIndex = 2;
            Date_lb.Text = "Date";
            // 
            // Text_tb
            // 
            Text_tb.Location = new Point(22, 37);
            Text_tb.Multiline = true;
            Text_tb.Name = "Text_tb";
            Text_tb.ReadOnly = true;
            Text_tb.ScrollBars = ScrollBars.Vertical;
            Text_tb.Size = new Size(895, 133);
            Text_tb.TabIndex = 3;
            // 
            // PostView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(Text_tb);
            Controls.Add(Date_lb);
            Controls.Add(Name_lb);
            Name = "PostView";
            Size = new Size(938, 179);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label Name_lb;
        private Label Date_lb;
        public TextBox Text_tb;
    }
}
