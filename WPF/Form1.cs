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
        private bool doingDecimals = false;
        private int selectOperation;
        private bool isFirstThing = false;
        private double memory;


        //OPERATIONS
        /* 0 � -
         * 1 � /
         * 2 � +
         * 3 � x
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
            isFirstThing = true;

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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
            isFirstThing = true;
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
                isFirstThing = true;
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double temp = 0;
            if (waitingNewNumber)
            {
                switch (selectOperation)
                {
                    case 0:
                        //Minus
                        try
                        {
                            newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('-') + 1));
                            temp = selectNumber - newSelectNumber;
                            this.textBox1.Text = Convert.ToString(Math.Round(temp, 3));
                        }
                        catch (Exception oopsie)
                        {
                            throwErrorInCalc();
                        }
                        
                        break;
                    case 1:
                        //Divide
                        try
                        {
                            if (newSelectNumber == 0)
                            {
                                throwErrorInCalc();
                            }
                            else
                            {
                                newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('/') + 1));
                                temp = selectNumber / newSelectNumber;
                                this.textBox1.Text = Convert.ToString(Math.Round(temp, 3));
                            }
                        }
                        catch (Exception oospie)
                        {
                            throwErrorInCalc();
                        }

                        break;
                    case 2:
                        //Plus
                        try
                        {
                            newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('+') + 1));
                            temp = selectNumber + newSelectNumber;
                            this.textBox1.Text = Convert.ToString(Math.Round(temp, 3));
                        }
                        catch (Exception oopsie)
                        {
                            throwErrorInCalc();
                        }
                        
                        break;
                    case 3:
                        //Multi
                        try
                        {
                            newSelectNumber = Convert.ToDouble(this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('x') + 1));
                            temp = selectNumber * newSelectNumber;
                            this.textBox1.Text = Convert.ToString(Math.Round(temp, 3));
                        }
                        catch(Exception oopsie)
                        {
                            throwErrorInCalc();
                        }
                        
                        break;
                    default:
                        selectNumber = Convert.ToDouble(this.textBox1.Text);
                        break;
                }
                selectNumber = temp;
                waitingNewNumber = false;
                checkZero = false;
            }


        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            waitingNewNumber = false;
            checkZero = false;
            doingDecimals = false;
            if (errored)
            {
                this.label2.Visible = false;
                errored = false;
            }

        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
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
                    throwErrorInCalc();
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
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
                    throwErrorInCalc();
                }
            }
            else
            {
                throwErrorInCalc();
            }

        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
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
                    throwErrorInCalc();
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
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
                    throwErrorInCalc();
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
            {
                string tempOperation = string.Empty;

                if (!waitingNewNumber)
                {
                    this.textBox1.Text += ',';
                    doingDecimals = true;
                    var temp = this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf(',') + 1);
                    double tempL = temp.Length;
                    for (int i = 0; i < tempL; i++)
                    {
                        selectNumber += temp[i] * Math.Pow(10, i--);
                    }
                }
                else
                {
                    string newOP1;
                    string newOP2;
                    double tempL = 0;
                    this.textBox1.Text += ',';
                    short tempI;
                    switch (selectOperation)
                    {
                        case 0:
                            newOP1 = this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('-') + 1); //TEMP
                            newOP2 = newOP1.Substring(newOP1.LastIndexOf(',') + 1);
                            tempL = newOP2.Length;
                            for (int i = 0; i < tempL; i++)
                            {
                                selectNumber += newOP2[i] * Math.Pow(10, i--);
                            }
                            break;
                        case 1:
                            newOP1 = this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('/') + 1); //TEMP
                            newOP2 = newOP1.Substring(newOP1.LastIndexOf(',') + 1);
                            tempL = newOP2.Length;
                            for (int i = 0; i < tempL; i++)
                            {
                                selectNumber += newOP2[i] * Math.Pow(10, i--);
                            }
                            break;
                        case 2:
                            newOP1 = this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('+') + 1); //TEMP
                            newOP2 = newOP1.Substring(newOP1.LastIndexOf(',') + 1);
                            tempL = newOP2.Length;
                            for (int i = 0; i < tempL; i++)
                            {
                                tempI = (short)(i - 1);
                                selectNumber += newOP2[i] * Math.Pow(10, tempI);
                            }
                            break;
                        case 3:
                            newOP1 = this.textBox1.Text.Substring(this.textBox1.Text.LastIndexOf('-') + 1); //TEMP
                            newOP2 = newOP1.Substring(newOP1.LastIndexOf(',') + 1);
                            tempL = newOP2.Length;
                            for (int i = 0; i < tempL; i++)
                            {
                                selectNumber += newOP2[i] * Math.Pow(10, i--);
                            }
                            break;
                    }
                }


            }
            else
            {
                throwErrorInCalc();
            }
        }

        private void btnSTO_Click(object sender, EventArgs e)
        {
            if (!waitingNewNumber)
            {
                if (selectNumber != 0)
                {
                    memory = Convert.ToDouble(this.textBox1.Text);
                    this.labelM.Visible = true;
                    this.textBox1.Text = String.Empty;
                }
                else
                {
                    throwErrorInCalc();
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }

        private void btnMEM_Click(object sender, EventArgs e)
        {
            if (memory != 0)
            {
                if (waitingNewNumber)
                {
                    newSelectNumber = memory;
                    this.textBox1.Text += Convert.ToString(newSelectNumber);
                }
                else
                {
                    selectNumber = memory;
                    this.textBox1.Text += Convert.ToString(selectNumber);
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            if (isFirstThing)
            {
                if (!waitingNewNumber)
                {
                    memory += Convert.ToDouble(this.textBox1.Text);
                    if (memory == 0)
                    {
                        this.labelM.Visible = false;
                    }
                    this.textBox1.Text = Convert.ToString(memory);
                }
            }
            else
            {
                throwErrorInCalc();
            }
        }
        private void throwErrorInCalc()
        {
            this.label2.Visible = true;
            errored = true;
        }
    }
}