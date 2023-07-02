namespace WFA_CoinFlipTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startAmount = 0;
        int betAmount = 0;
        bool topMost = false;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartAmount_Click(object sender, EventArgs e)
        {
            try
            {
                lblDisplayText.Text = "You should bet";
                startAmount = int.Parse(tbStartAmount.Text);
                betAmount = int.Parse(tbStartAmount.Text);
                lblProfit.Text = startAmount.ToString();
                tbNextBetAmount.Text = betAmount.ToString();
            }
            catch
            {
                lblDisplayText.Text = "Numbers only";
            }
        }

        private void lblNextBetAmount_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnWon_Click(object sender, EventArgs e)
        {
            betAmount = startAmount;
            tbNextBetAmount.Text = betAmount.ToString();
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            betAmount += betAmount;
            tbNextBetAmount.Text = betAmount.ToString();
        }

        private void cbTopMost_CheckedChanged(object sender, EventArgs e)
        {
            topMost = !topMost;
            if (topMost)
            {
                topMost = true;
                this.TopMost = true;
            }
            else
            {
                topMost = false;
                this.TopMost = false;
            }
        }

        private Point mouseOffsetPos;
        private Boolean isMouseDown = false;

        private void panelTopMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffsetPos = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panelTopMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
                this.Location = mousePos;
            }
        }

        private void panelTopMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}