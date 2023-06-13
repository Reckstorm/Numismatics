namespace Numismatics
{
    partial class PostControl
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
            Save_btn = new Button();
            Clear_btn = new Button();
            Name_tb = new TextBox();
            Text_tb = new TextBox();
            Remove_btn = new Button();
            Res_lb = new Label();
            SuspendLayout();
            // 
            // Save_btn
            // 
            Save_btn.Location = new Point(822, 15);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(94, 29);
            Save_btn.TabIndex = 1;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Clear_btn
            // 
            Clear_btn.Location = new Point(822, 85);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(94, 29);
            Clear_btn.TabIndex = 2;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Name_tb
            // 
            Name_tb.Location = new Point(19, 15);
            Name_tb.Name = "Name_tb";
            Name_tb.Size = new Size(125, 27);
            Name_tb.TabIndex = 3;
            // 
            // Text_tb
            // 
            Text_tb.Location = new Point(150, 16);
            Text_tb.Multiline = true;
            Text_tb.Name = "Text_tb";
            Text_tb.ScrollBars = ScrollBars.Vertical;
            Text_tb.Size = new Size(666, 121);
            Text_tb.TabIndex = 4;
            // 
            // Remove_btn
            // 
            Remove_btn.Location = new Point(822, 50);
            Remove_btn.Name = "Remove_btn";
            Remove_btn.Size = new Size(94, 29);
            Remove_btn.TabIndex = 5;
            Remove_btn.Text = "Remove";
            Remove_btn.UseVisualStyleBackColor = true;
            Remove_btn.Click += Remove_btn_Click;
            // 
            // Res_lb
            // 
            Res_lb.AutoSize = true;
            Res_lb.Location = new Point(822, 117);
            Res_lb.Name = "Res_lb";
            Res_lb.Size = new Size(49, 20);
            Res_lb.TabIndex = 6;
            Res_lb.Text = "Result";
            // 
            // PostControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(Res_lb);
            Controls.Add(Remove_btn);
            Controls.Add(Text_tb);
            Controls.Add(Name_tb);
            Controls.Add(Clear_btn);
            Controls.Add(Save_btn);
            Name = "PostControl";
            Size = new Size(938, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save_btn;
        private Button Clear_btn;
        private TextBox Name_tb;
        private TextBox Text_tb;
        private Button Remove_btn;
        private Label Res_lb;
    }
}
