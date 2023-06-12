namespace Numismatics
{
    partial class ExchangeCoin
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
            ResNew_lb = new Label();
            MyCoin_cb = new ComboBox();
            PriceMy_lb = new Label();
            Exchange_btn = new Button();
            SuspendLayout();
            // 
            // ResNew_lb
            // 
            ResNew_lb.AutoSize = true;
            ResNew_lb.Location = new Point(660, 50);
            ResNew_lb.Name = "ResNew_lb";
            ResNew_lb.Size = new Size(49, 20);
            ResNew_lb.TabIndex = 8;
            ResNew_lb.Text = "Result";
            // 
            // MyCoin_cb
            // 
            MyCoin_cb.FormattingEnabled = true;
            MyCoin_cb.Location = new Point(41, 80);
            MyCoin_cb.Name = "MyCoin_cb";
            MyCoin_cb.Size = new Size(151, 28);
            MyCoin_cb.TabIndex = 9;
            MyCoin_cb.SelectedIndexChanged += MyCoin_cb_SelectedIndexChanged;
            // 
            // PriceMy_lb
            // 
            PriceMy_lb.AutoSize = true;
            PriceMy_lb.Location = new Point(541, 80);
            PriceMy_lb.Name = "PriceMy_lb";
            PriceMy_lb.Size = new Size(61, 20);
            PriceMy_lb.TabIndex = 10;
            PriceMy_lb.Text = "PriceMy";
            // 
            // Exchange_btn
            // 
            Exchange_btn.Location = new Point(776, 46);
            Exchange_btn.Name = "Exchange_btn";
            Exchange_btn.Size = new Size(94, 29);
            Exchange_btn.TabIndex = 11;
            Exchange_btn.Text = "Exchange";
            Exchange_btn.UseVisualStyleBackColor = true;
            Exchange_btn.Click += Exchange_btn_Click;
            // 
            // ExchangeCoin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Exchange_btn);
            Controls.Add(PriceMy_lb);
            Controls.Add(MyCoin_cb);
            Controls.Add(ResNew_lb);
            Name = "ExchangeCoin";
            Size = new Size(938, 123);
            Controls.SetChildIndex(Buy_btn, 0);
            Controls.SetChildIndex(Res_lb, 0);
            Controls.SetChildIndex(ResNew_lb, 0);
            Controls.SetChildIndex(MyCoin_cb, 0);
            Controls.SetChildIndex(PriceMy_lb, 0);
            Controls.SetChildIndex(Exchange_btn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ResNew_lb;
        private ComboBox MyCoin_cb;
        private Label PriceMy_lb;
        private Button Exchange_btn;
    }
}
