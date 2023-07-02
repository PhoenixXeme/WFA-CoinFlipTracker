namespace WFA_CoinFlipTracker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnWon = new Button();
            tbStartAmount = new TextBox();
            btnStartAmount = new Button();
            label2 = new Label();
            panelTop = new Panel();
            btnLost = new Button();
            lblProfit = new Label();
            label1 = new Label();
            lblDisplayText = new Label();
            tbNextBetAmount = new TextBox();
            cbTopMost = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // btnWon
            // 
            btnWon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnWon.FlatStyle = FlatStyle.Flat;
            btnWon.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnWon.ForeColor = Color.FromArgb(128, 255, 128);
            btnWon.Location = new Point(38, 168);
            btnWon.Name = "btnWon";
            btnWon.Size = new Size(95, 44);
            btnWon.TabIndex = 0;
            btnWon.Text = "Won";
            btnWon.UseVisualStyleBackColor = true;
            btnWon.Click += btnWon_Click;
            // 
            // tbStartAmount
            // 
            tbStartAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbStartAmount.BackColor = Color.FromArgb(61, 61, 61);
            tbStartAmount.BorderStyle = BorderStyle.FixedSingle;
            tbStartAmount.ForeColor = Color.White;
            tbStartAmount.Location = new Point(93, 269);
            tbStartAmount.Name = "tbStartAmount";
            tbStartAmount.Size = new Size(190, 23);
            tbStartAmount.TabIndex = 2;
            tbStartAmount.TextChanged += textBox2_TextChanged;
            // 
            // btnStartAmount
            // 
            btnStartAmount.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnStartAmount.FlatStyle = FlatStyle.Flat;
            btnStartAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnStartAmount.ForeColor = Color.White;
            btnStartAmount.Location = new Point(12, 269);
            btnStartAmount.Name = "btnStartAmount";
            btnStartAmount.Size = new Size(75, 23);
            btnStartAmount.TabIndex = 4;
            btnStartAmount.Text = "Enter";
            btnStartAmount.UseVisualStyleBackColor = true;
            btnStartAmount.Click += btnStartAmount_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(72, -2);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 5;
            label2.Text = "Coin Flip Tracker";
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.BackColor = Color.FromArgb(61, 61, 61);
            panelTop.Controls.Add(label4);
            panelTop.Controls.Add(label3);
            panelTop.Controls.Add(label2);
            panelTop.Location = new Point(-5, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(304, 42);
            panelTop.TabIndex = 6;
            panelTop.MouseDown += panelTopMouseDown;
            panelTop.MouseMove += panelTopMouseMove;
            panelTop.MouseUp += panelTopMouseUp;
            // 
            // btnLost
            // 
            btnLost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnLost.FlatStyle = FlatStyle.Flat;
            btnLost.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLost.ForeColor = Color.Red;
            btnLost.Location = new Point(161, 168);
            btnLost.Name = "btnLost";
            btnLost.Size = new Size(95, 44);
            btnLost.TabIndex = 0;
            btnLost.Text = "Lost";
            btnLost.UseVisualStyleBackColor = true;
            btnLost.Click += btnLost_Click;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfit.ForeColor = Color.White;
            lblProfit.Location = new Point(58, 45);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(23, 25);
            lblProfit.TabIndex = 7;
            lblProfit.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 8;
            label1.Text = "Profit:";
            // 
            // lblDisplayText
            // 
            lblDisplayText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDisplayText.AutoSize = true;
            lblDisplayText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayText.Location = new Point(87, 89);
            lblDisplayText.Name = "lblDisplayText";
            lblDisplayText.Size = new Size(124, 21);
            lblDisplayText.TabIndex = 9;
            lblDisplayText.Text = "You should bet";
            lblDisplayText.TextAlign = ContentAlignment.MiddleCenter;
            lblDisplayText.Click += label3_Click;
            // 
            // tbNextBetAmount
            // 
            tbNextBetAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbNextBetAmount.BackColor = Color.FromArgb(31, 31, 31);
            tbNextBetAmount.BorderStyle = BorderStyle.None;
            tbNextBetAmount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            tbNextBetAmount.ForeColor = Color.White;
            tbNextBetAmount.Location = new Point(12, 113);
            tbNextBetAmount.Name = "tbNextBetAmount";
            tbNextBetAmount.ReadOnly = true;
            tbNextBetAmount.Size = new Size(271, 43);
            tbNextBetAmount.TabIndex = 11;
            tbNextBetAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // cbTopMost
            // 
            cbTopMost.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbTopMost.AutoSize = true;
            cbTopMost.FlatStyle = FlatStyle.Popup;
            cbTopMost.Location = new Point(208, 45);
            cbTopMost.Name = "cbTopMost";
            cbTopMost.Size = new Size(73, 19);
            cbTopMost.TabIndex = 6;
            cbTopMost.Text = "Top Most";
            cbTopMost.UseVisualStyleBackColor = true;
            cbTopMost.CheckedChanged += cbTopMost_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "v0.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 23);
            label4.Name = "label4";
            label4.Size = new Size(129, 15);
            label4.TabIndex = 12;
            label4.Text = "Made by PhoenixXeme";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(295, 305);
            Controls.Add(cbTopMost);
            Controls.Add(lblProfit);
            Controls.Add(tbNextBetAmount);
            Controls.Add(lblDisplayText);
            Controls.Add(label1);
            Controls.Add(panelTop);
            Controls.Add(btnStartAmount);
            Controls.Add(tbStartAmount);
            Controls.Add(btnLost);
            Controls.Add(btnWon);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(311, 344);
            MinimizeBox = false;
            MinimumSize = new Size(311, 344);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coin Flip Tracker";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWon;
        private TextBox tbStartAmount;
        private Button btnStartAmount;
        private Label label2;
        private Button btnLost;
        private Label lblProfit;
        private Label label1;
        private Label lblDisplayText;
        private TextBox tbNextBetAmount;
        private CheckBox cbTopMost;
        private Panel panelTop;
        private Label label4;
        private Label label3;
    }
}