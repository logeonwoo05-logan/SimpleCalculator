namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string firstOperand = "";
        string secondOperand = "";
        string currentOperator = "";
        bool isSecondInput = false;


        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //아 이게 뭐지...
        private void InputNumber(string number)
        {
            if (isSecondInput == false)
            {
                firstOperand += number;
                txtExpression.Text = firstOperand;
                txtResult.Text = firstOperand;
            }
            else
            {
                secondOperand += number;
                txtExpression.Text = firstOperand + " " + currentOperator + " " + secondOperand;
                txtResult.Text = secondOperand;
            }
        }


        //숫자 버튼
        private void btn0_Click(object sender, EventArgs e)
        {
            InputNumber("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            InputNumber("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            InputNumber("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            InputNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            InputNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            InputNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            InputNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            InputNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            InputNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            InputNumber("9");
        }

        //더하기 버튼 코드
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (firstOperand != "")
            {
                currentOperator = "+";
                isSecondInput = true;
                txtExpression.Text = firstOperand+ " " + currentOperator;
            }
        }
        
        
        //는 버튼
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (firstOperand != "" && secondOperand != "" && currentOperator == "+")
            {
                int n1 = int.Parse(firstOperand);
                int n2 = int.Parse(secondOperand);
                int result = n1 + n2;

                txtExpression.Text = firstOperand + " " + currentOperator + " " + secondOperand + " = " + result.ToString();
                txtResult.Text = result.ToString();

                firstOperand = result.ToString();
                secondOperand = "";
                currentOperator = "";
                isSecondInput = false;
            }
        }








    }

}
