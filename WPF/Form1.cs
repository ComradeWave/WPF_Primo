namespace WPF
{
    public partial class Form1 : Form
    {
        public double selectNumber;
        public double selectNewNumber;
        private bool waitingNewNumber = false;
        private bool checkZero = false;
        private bool errored = false;
        private int selectOperation;



        //OPERATIONS
        /* 0 è -
         * 1 è +
         * 2 è /
         * 3 è x
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectNumber = 1;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            selectNumber = 2;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectNumber = 3;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectNumber = 4;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            selectNumber = 5;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectNumber = 6;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            selectNumber = 7;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            selectNumber = 8;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            selectNumber = 9;
            checkZero = true;
            this.textBox1.Text += selectNumber.ToString();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (checkZero)
            {
                selectNumber = 0;
                this.textBox1.Text += selectNumber.ToString();
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            waitingNewNumber = true;
            checkZero = false;
            if (errored)
            {
                this.label2.Visible = false;
                errored = false; 
            }

        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!waitingNewNumber)
            {
                this.textBox1.Text += "-";
                waitingNewNumber = true;
                selectOperation = 0;
            }
            else
            {
                this.label2.Visible = true;
                errored = true;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {

        }
        private void btnSum_Click(object sender, EventArgs e)
        {

        }
        private void btnMulti_Click(object sender, EventArgs e)
        {

        }
    }
}