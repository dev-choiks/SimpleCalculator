namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // 피연산자 및 연산자 저장을 위한 변수
        int firstNum = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        // --- 숫자 버튼 클릭 이벤트 (0~9) ---
        // 숫자를 누르면 txtInput(진행창)에는 계속 추가되고, txtOutput(결과창)에는 현재 숫자만 갱신됩니다.
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

        // 숫자 입력 공통 로직
        private void AppendNumber(string num)
        {
            txtInput.Text += num;     // 인풋창: 전체 식 유지 (1 + 2...)
            txtOutput.Text += num;    // 아웃풋창: 현재 입력 중인 숫자 표시
        }

        // --- 더하기(+) 버튼 클릭 이벤트 ---
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                // 1. 현재 아웃풋창에 있던 숫자를 첫 번째 피연산자로 저장
                firstNum = int.Parse(txtOutput.Text);

                // 2. 인풋창에는 연산 기호 추가 (1 + )
                txtInput.Text += " + ";

                // 3. 연산자 저장 및 아웃풋창 비우기 (숫자가 사라지는 효과)
                operation = "+";
                txtOutput.Clear();
            }
        }

        // --- 결과(=) 버튼 클릭 이벤트 ---
        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text) && operation == "+")
            {
                // 1. 아웃풋창의 현재 숫자를 두 번째 피연산자로 변환
                int secondNum = int.Parse(txtOutput.Text);

                // 2. 계산 수행
                int result = firstNum + secondNum;

                // 3. 인풋창에 최종 전체 식 완성 (1 + 2 = 3)
                txtInput.Text += " = " + result.ToString();

                // 4. 아웃풋창에는 최종 결과값 '3'만 표시
                txtOutput.Text = result.ToString();

                // 5. 연산 상태 초기화
                operation = "";
            }
        }
    }
}