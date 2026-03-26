namespace SimpleCalculator
{



    public partial class Form1 : Form
    {
        string firstOperand = "";
        string secondOperand = "";
        string currentOperator = "";
        bool isSecondInput = false;
        //과제 4
        //결과 확인 후 숫자 누르면 앞 계산 값이 붙어 나옴
        bool isResultDisplayed = false;

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
            if (isResultDisplayed == true)
            {
                firstOperand = "";
                secondOperand = "";
                currentOperator = "";
                isSecondInput = false;
                txtExpression.Text = "";
                txtResult.Text = "";
                isResultDisplayed = false;
            }

            if (isSecondInput == false)
            {
                if (firstOperand == "" && number == "0")
                {
                    return;
                }

                firstOperand += number;
                txtExpression.Text = firstOperand;
                txtResult.Text = firstOperand;
            }
            else
            {
                if (secondOperand == "" && number == "0")
                {
                    return;
                }

                secondOperand += number;
                txtExpression.Text = firstOperand + " " + GetDisplayOperator() + " " + secondOperand;                txtResult.Text = secondOperand;
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
                txtExpression.Text = firstOperand + " " + GetDisplayOperator();
            }
        }


        //는 버튼
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (firstOperand != "" && secondOperand != "" && currentOperator != "")
            {
                int n1 = int.Parse(firstOperand);
                int n2 = int.Parse(secondOperand);

                //과제 2 추가
                int result = 0;

                if (currentOperator == "+")
                {
                    result = n1 + n2;
                }
                else if (currentOperator == "-")
                {
                    result = n1 - n2;
                }
                else if (currentOperator == "*")
                {
                    result = n1 * n2;
                }
                else if (currentOperator == "/")
                {
                    result = n1 / n2;
                }
                //여기까지







                txtExpression.Text = firstOperand + " " + GetDisplayOperator() + " " + secondOperand + " = " + result.ToString();
                txtResult.Text = result.ToString();

                firstOperand = result.ToString();
                secondOperand = "";
                currentOperator = "";
                isSecondInput = false;
                isResultDisplayed = true;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (firstOperand != "")
            {
                currentOperator = "-";
                isSecondInput = true;
                txtExpression.Text = firstOperand + " " + GetDisplayOperator();
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (firstOperand != "")
            {
                currentOperator = "*";
                isSecondInput = true;
                txtExpression.Text = firstOperand + " " + GetDisplayOperator();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {


            if (firstOperand != "")
            {
                currentOperator = "/";
                isSecondInput = true;
                txtExpression.Text = firstOperand + " " + GetDisplayOperator();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstOperand = "";
            secondOperand = "";
            currentOperator = "";
            isSecondInput = false;
            isResultDisplayed = false;

            txtExpression.Text = "";
            txtResult.Text = "";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            //과제 4추가
            isResultDisplayed = false;
            // 


            if (isSecondInput == false)
            {
                firstOperand = "";
                txtExpression.Text = "";
                txtResult.Text = "";
            }
            else
            {
                secondOperand = "";
                txtExpression.Text = firstOperand + " " + GetDisplayOperator();
                txtResult.Text = "";
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //과제 4 추가
            isResultDisplayed = false;
            //


            if (isSecondInput == false)
            {
                if (firstOperand.Length > 0)
                {
                    firstOperand = firstOperand.Remove(firstOperand.Length - 1);
                    txtExpression.Text = firstOperand;
                    txtResult.Text = firstOperand;
                }
            }
            else
            {
                if (secondOperand.Length > 0)
                {
                    secondOperand = secondOperand.Remove(secondOperand.Length - 1);
                    txtExpression.Text = firstOperand + " " + currentOperator + " " + secondOperand;
                    txtResult.Text = secondOperand;
                }
            }
        }

        private void txtExpression_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private string GetDisplayOperator()
        {
            if (currentOperator == "/")
            {
                return "÷";
            }
            else if (currentOperator == "*")
            {
                return "X";
            }

            return currentOperator;
        }









    }
}

