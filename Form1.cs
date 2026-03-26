namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNum = 0;
        string operation = "";

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
                txtOutput.Clear();
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
                        // 0으로 나누기 체크
                        if (secondNum == 0)
                        {
                            MessageBox.Show("0으로 나눌 수 없습니다!", "계산 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearAll(); // 에러 발생 시 초기화 함수 호출
                            return;
                        }
                        result = firstNum / secondNum;
                        break;
                }

                txtInput.Text += " = " + result.ToString();
                txtOutput.Text = result.ToString();
                operation = "";
            }
        }

        // 초기화를 위한 공통 함수 (에러 발생 시 또는 C 버튼 클릭 시 사용)
        private void ClearAll()
        {
            txtInput.Clear();
            txtOutput.Clear();
            firstNum = 0;
            operation = "";
        }
        private void btnCe_Click(object sender, EventArgs e)
        {

        }

        private void btnC_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnPlma_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }
    }
}