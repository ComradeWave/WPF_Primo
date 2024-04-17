using System.Linq.Expressions;

namespace WPF
{
    public partial class Form1 : Form
    {
        public double selectNumber;
        public double newSelectNumber;
        private bool waitingNewNumber = false;
        private bool checkZero = false;
        private bool errored = false;
        private int selectOperation;



        //OPERATIONS
        /* 0 è -
         * 1 è /
         * 2 è +
         * 3 è x
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 1;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 1;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 2;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 2;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 3;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 3;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 4;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 4;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 5;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 5;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 6;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 6;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 7;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 7;

                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 8;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 8;
                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (waitingNewNumber)
            {
                newSelectNumber = 9;
                this.textBox1.Text += newSelectNumber.ToString();
            }
            else
            {
                selectNumber = 9;
                this.textBox1.Text += selectNumber.ToString();
            }
            checkZero = true;
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (checkZero)
            {
                if (waitingNewNumber)
                {
                    newSelectNumber = 0;
                    this.textBox1.Text += newSelectNumber.ToString();
                }
                else
                {
                    selectNumber = 0;
                    this.textBox1.Text += selectNumber.ToString();
                }
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double temp=0;
            if (waitingNewNumber)
            {
                switch (selectOperation)
                {
                    case 0:
                        //Minus
                        newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('-') + 1));
                        selectNumber = temp;
                        this.textBox1.Text = Convert.ToString(temp);
                        break;
                    case 1:
                        //Divide
                        newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('/') + 1));
                        temp = selectNumber / newSelectNumber;
                        this.textBox1.Text = Convert.ToString(temp);
                        break;
                    case 2:
                        //Plus
                        newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('+') + 1));
                        temp = selectNumber + newSelectNumber;
                        this.textBox1.Text = Convert.ToString(temp);
                        break;
                    case 3:
                        //Multi
                        newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('x') + 1));
                        temp = selectNumber * newSelectNumber;
                        this.textBox1.Text = Convert.ToString(temp);
                        break;
                }
                selectNumber = temp;
                waitingNewNumber = false;
                checkZero = false;
            }
            else
            {
                this.textBox1.Text = Convert.ToString(selectNumber);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            waitingNewNumber = false;
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
                this.selectNumber = Convert.ToDouble(this.textBox1.Text);
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
            if (!waitingNewNumber)
            {
                this.selectNumber = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text += "/";
                waitingNewNumber = true;
                selectOperation = 1;
            }
            else
            {
                this.label2.Visible = true;
                errored = true;
            }

        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (!waitingNewNumber)
            {
                this.selectNumber = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text += "+";
                waitingNewNumber = true;
                selectOperation = 2;
            }
            else
            {
                this.label2.Visible = true;
                errored = true;
            }
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (!waitingNewNumber)
            {
                this.selectNumber = Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text += "x";
                waitingNewNumber = true;
                selectOperation = 3;
            }
            else
            {
                this.label2.Visible = true;
                errored = true;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

        }
    }
}