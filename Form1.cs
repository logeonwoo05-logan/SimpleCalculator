using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

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

        // 새로운 수식 입력을 위한 문자열 (키보드 입력용)
        string expression = "";

        public Form1()
        {
            InitializeComponent();
            // 키보드 입력을 처리하도록 설정
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
            this.KeyDown += Form1_KeyDown;
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
                expression = "";
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

        // 키보드 문자 입력 처리 (숫자, 연산자, 괄호, 소수점 등)
        private void Form1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsDigit(c) || c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')' || c == '.' )
            {
                AppendToExpression(c.ToString());
                e.Handled = true;
            }
            // Enter와 Backspace는 KeyDown에서 처리
        }

        // 키보드 특수키 처리 (Enter, Backspace, Escape 등)
        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EvaluateAndDisplay();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (expression.Length > 0)
                {
                    expression = expression.Remove(expression.Length - 1);
                    txtExpression.Text = expression;
                    txtResult.Text = "";
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // ESC는 전체 초기화
                btnC_Click(this, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void AppendToExpression(string s)
        {
            if (isResultDisplayed)
            {
                // 결과가 표시된 상태에서 숫자/문자 입력이면 새 수식으로 시작
                expression = "";
                isResultDisplayed = false;
                firstOperand = "";
                secondOperand = "";
                currentOperator = "";
            }

            expression += s;
            txtExpression.Text = expression;
        }

        private void EvaluateAndDisplay()
        {
            if (string.IsNullOrWhiteSpace(expression))
            {
                // 기존 버튼 기반 계산 로직 사용
                // 아무런 변화: btnEqual_Click가 기존 동작을 처리함
                return;
            }

            try
            {
                double result = EvaluateExpression(expression);
                string resultStr;
                if (Math.Abs(result - Math.Round(result)) < 1e-12)
                    resultStr = ((long)Math.Round(result)).ToString();
                else
                    resultStr = result.ToString(CultureInfo.InvariantCulture);

                txtExpression.Text = expression + " = " + resultStr;
                txtResult.Text = resultStr;

                // 결과를 다음 계산에서 사용할 수 있도록 상태 갱신
                expression = resultStr;
                firstOperand = resultStr;
                secondOperand = "";
                currentOperator = "";
                isSecondInput = false;
                isResultDisplayed = true;
            }
            catch (Exception ex)
            {
                txtResult.Text = "Error";
            }
        }

        // 수식 평가기: shunting-yard 알고리즘으로 토큰을 RPN으로 변환한 뒤 평가
        private double EvaluateExpression(string expr)
        {
            // 토큰화 (암묵적 곱셈 처리 포함)
            List<string> tokens = new List<string>();
            int i = 0;
            while (i < expr.Length)
            {
                char c = expr[i];
                if (char.IsWhiteSpace(c)) { i++; continue; }

                // 숫자 또는 소수점으로 시작하는 숫자 토큰
                if (char.IsDigit(c) || c == '.')
                {
                    int j = i;
                    while (j < expr.Length && (char.IsDigit(expr[j]) || expr[j] == '.')) j++;
                    string numberToken = expr.Substring(i, j - i);
                    // 만약 이전 토큰이 ')' 이면 암묵적 곱셈 삽입
                    if (tokens.Count > 0 && tokens[tokens.Count - 1] == ")")
                    {
                        tokens.Add("*");
                    }
                    tokens.Add(numberToken);
                    i = j;
                    continue;
                }

                // + 또는 - : 유니터리 처리인지 확인
                if (c == '+' || c == '-')
                {
                    bool isUnary = tokens.Count == 0 || tokens[tokens.Count - 1] == "(" || IsOperator(tokens[tokens.Count - 1]);
                    if (isUnary)
                    {
                        // 부호가 붙은 숫자 파싱
                        int j = i + 1;
                        while (j < expr.Length && char.IsWhiteSpace(expr[j])) j++;
                        int k = j;
                        if (k < expr.Length && (char.IsDigit(expr[k]) || expr[k] == '.'))
                        {
                            while (k < expr.Length && (char.IsDigit(expr[k]) || expr[k] == '.')) k++;
                            string signedNumber = expr.Substring(i, k - i);
                            tokens.Add(signedNumber);
                            i = k;
                            continue;
                        }
                        // 유니터리인데 뒤에 숫자가 없으면 연산자로 처리
                    }
                    // 이 경우에는 이 토큰을 연산자로 추가
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }

                // 괄호 또는 기타 연산자
                if (c == '*' || c == '/' || c == '(' || c == ')')
                {
                    // '(' 이전에 숫자나 ')'가 오면 암묵적 곱셈 삽입
                    if (c == '(' && tokens.Count > 0)
                    {
                        string prev = tokens[tokens.Count - 1];
                        if (prev == ")" || double.TryParse(prev, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                        {
                            tokens.Add("*");
                        }
                    }

                    // ')' 다음에 숫자나 '('가 오면 나중에 토큰화 단계에서 처리할 수 있음
                    tokens.Add(c.ToString());
                    i++;
                    continue;
                }

                // 알 수 없는 문자
                throw new ArgumentException("Invalid character in expression");
            }

            // 토큰화 후: ')' 다음에 숫자나 '('가 바로 오는 경우(예: ')(' 또는 ')2')에도 암묵적 곱셈이 필요하다.
            List<string> fixedTokens = new List<string>();
            for (int idx = 0; idx < tokens.Count; idx++)
            {
                string tk = tokens[idx];
                fixedTokens.Add(tk);
                if (tk == ")" && idx + 1 < tokens.Count)
                {
                    string next = tokens[idx + 1];
                    if (next == "(" || double.TryParse(next, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                    {
                        fixedTokens.Add("*");
                    }
                }
            }
            tokens = fixedTokens;

            // shunting-yard
            List<string> output = new List<string>();
            Stack<string> ops = new Stack<string>();
            foreach (var t in tokens)
            {
                if (double.TryParse(t, NumberStyles.Number, CultureInfo.InvariantCulture, out _))
                {
                    output.Add(t);
                }
                else if (IsOperator(t))
                {
                    while (ops.Count > 0 && IsOperator(ops.Peek()) && ((GetPrecedence(ops.Peek()) > GetPrecedence(t)) || (GetPrecedence(ops.Peek()) == GetPrecedence(t) && IsLeftAssociative(t))))
                    {
                        output.Add(ops.Pop());
                    }
                    ops.Push(t);
                }
                else if (t == "(")
                {
                    ops.Push(t);
                }
                else if (t == ")")
                {
                    while (ops.Count > 0 && ops.Peek() != "(")
                    {
                        output.Add(ops.Pop());
                    }
                    if (ops.Count == 0 || ops.Pop() != "(") throw new ArgumentException("Mismatched parentheses");
                }
            }

            while (ops.Count > 0)
            {
                var op = ops.Pop();
                if (op == "(" || op == ")") throw new ArgumentException("Mismatched parentheses");
                output.Add(op);
            }

            // RPN 평가
            Stack<double> eval = new Stack<double>();
            foreach (var tk in output)
            {
                if (double.TryParse(tk, NumberStyles.Number, CultureInfo.InvariantCulture, out double val))
                {
                    eval.Push(val);
                }
                else if (IsOperator(tk))
                {
                    if (eval.Count < 2) throw new ArgumentException("Invalid expression");
                    double b = eval.Pop();
                    double a = eval.Pop();
                    double r = tk switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => a / b,
                        _ => throw new ArgumentException("Unknown operator")
                    };
                    eval.Push(r);
                }
            }

            if (eval.Count != 1) throw new ArgumentException("Invalid expression");
            return eval.Pop();
        }

        private static bool IsOperator(string t) => t == "+" || t == "-" || t == "*" || t == "/";

        private static int GetPrecedence(string op)
        {
            return op switch
            {
                "+" => 1,
                "-" => 1,
                "*" => 2,
                "/" => 2,
                _ => 0
            };
        }

        private static bool IsLeftAssociative(string op) => op != "^"; // '^' 없음, 기본 왼쪽 결합


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
            
            //

            //피드백 후 추가
            if (isResultDisplayed == true)
            {
                return;
            }

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

            //
            
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

