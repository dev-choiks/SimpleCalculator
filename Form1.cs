namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNum = 0;
        string operation = "";
        // 연산자를 누른 후 새 숫자를 입력할 차례인지 확인하는 변수
        bool isNewNum = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e) { AppendNumber("1"); }
        private void btnTwo_Click(object sender, EventArgs e) { AppendNumber("2"); }
        private void btnThree_Click(object sender, EventArgs e) { AppendNumber("3"); }
        private void btnFour_Click(object sender, EventArgs e) { AppendNumber("4"); }
        private void btnFive_Click(object sender, EventArgs e) { AppendNumber("5"); }
        private void btnSix_Click(object sender, EventArgs e) { AppendNumber("6"); }
        private void btnSeven_Click(object sender, EventArgs e) { AppendNumber("7"); }
        private void btnEight_Click(object sender, EventArgs e) { AppendNumber("8"); }
        private void btnNine_Click(object sender, EventArgs e) { AppendNumber("9"); }
        private void btnZero_Click(object sender, EventArgs e) { AppendNumber("0"); }

        private void AppendNumber(string num)
        {
            // 연산자를 누른 직후라면 아웃풋창을 비우고 새 숫자 시작
            if (isNewNum)
            {
                txtOutput.Clear();
                isNewNum = false;
            }

            txtInput.Text += num;
            txtOutput.Text += num;
        }

        private void btnPlus_Click(object sender, EventArgs e) { SetOperation("+"); }
        private void btnMinu_Click(object sender, EventArgs e) { SetOperation("-"); }
        private void btnMulti_Click(object sender, EventArgs e) { SetOperation("*"); }
        private void btnDivi_Click(object sender, EventArgs e) { SetOperation("/"); }

        private void SetOperation(string op)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                firstNum = int.Parse(txtOutput.Text);
                operation = op;
                txtInput.Text += " " + op + " ";

                // 연산자를 눌러도 txtOutput의 숫자를 지우지 않고 유지함
                // 대신 다음 숫자 입력 시 지워지도록 플래그 설정
                isNewNum = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text) && !string.IsNullOrEmpty(operation))
            {
                int secondNum = int.Parse(txtOutput.Text);
                int result = 0;

                switch (operation)
                {
                    case "+": result = firstNum + secondNum; break;
                    case "-": result = firstNum - secondNum; break;
                    case "*": result = firstNum * secondNum; break;
                    case "/":
                        if (secondNum == 0)
                        {
                            MessageBox.Show("0으로 나눌 수 없습니다!", "계산 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearAll();
                            return;
                        }
                        result = firstNum / secondNum;
                        break;
                }

                txtInput.Text += " = " + result.ToString();
                txtOutput.Text = result.ToString();
                operation = "";
                isNewNum = true; // 결과 출력 후 숫자 누르면 다시 새로 시작되도록 설정
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtInput.Clear();
            txtOutput.Clear();
            firstNum = 0;
            operation = "";
            isNewNum = false;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                int lengthToRemove = txtOutput.Text.Length;
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - lengthToRemove);
                txtOutput.Clear();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1);
            }

            if (txtInput.Text.Length > 0 && char.IsDigit(txtInput.Text[txtInput.Text.Length - 1]))
            {
                txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
            }
        }

        private void btnPlma_Click(object sender, EventArgs e) { }
        private void btnDot_Click(object sender, EventArgs e) { }
    }
}