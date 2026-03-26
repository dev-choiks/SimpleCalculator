using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D; // 타원 경로 설정을 위해 필수
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        bool isNewNum = false;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Simple Calculator";

            // --- 원형 버튼 스타일 적용 ---
            // 폼의 모든 버튼을 찾아서 완전히 원형으로 만듭니다.
            ApplyCircularStyle(this);
        }

        #region UI 스타일 설정 (완전한 원형)
        private void ApplyCircularStyle(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;

                    // 1. 시각적으로 깔끔한 원형을 만들기 위해 스타일 설정
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(235, 235, 235); // 연한 회색 (과제 이미지 느낌)

                    // 2. 텍스트가 항상 중앙에 오도록 설정
                    btn.TextAlign = ContentAlignment.MiddleCenter;

                    // 3. 버튼 영역을 완전히 원형으로 깎음
                    SetCircularRegion(btn);
                }

                // 만약 패널 안에 버튼이 있다면 재귀적으로 탐색
                if (c.HasChildren) ApplyCircularStyle(c);
            }
        }

        private void SetCircularRegion(Control control)
        {
            // 컨트롤의 클라이언트 영역 전체를 덮는 타원(Ellipse) 경로를 만듭니다.
            GraphicsPath path = new GraphicsPath();
            // 디자이너에서 가로=세로로 맞췄다면 완벽한 원이 됩니다.
            path.AddEllipse(0, 0, control.Width, control.Height);

            // 해당 타원 모양으로 컨트롤의 활성 영역을 설정합니다.
            control.Region = new Region(path);
        }
        #endregion

        // --- 숫자 버튼 클릭 이벤트 (기존 유지) ---
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
            if (isNewNum) { txtOutput.Clear(); isNewNum = false; }
            txtInput.Text += num;
            txtOutput.Text += num;
        }

        // --- 연산자 및 기호 버튼 이벤트 (기존 유지) ---
        private void btnPlus_Click(object sender, EventArgs e) { AppendOperator("+"); }
        private void btnMinu_Click(object sender, EventArgs e) { AppendOperator("-"); }
        private void btnMulti_Click(object sender, EventArgs e) { AppendOperator("×"); }
        private void btnDivi_Click(object sender, EventArgs e) { AppendOperator("÷"); }
        private void btnLparen_Click(object sender, EventArgs e) { AppendOperator("("); }
        private void btnRparen_Click(object sender, EventArgs e) { AppendOperator(")"); }

        private void AppendOperator(string op)
        {
            if (txtInput.Text.Length > 0)
            {
                string currentText = txtInput.Text.TrimEnd();
                char lastChar = currentText[currentText.Length - 1];
                string operators = "+-×÷";
                if (operators.Contains(lastChar) && operators.Contains(op))
                {
                    int lastOpIdx = txtInput.Text.LastIndexOf(lastChar);
                    txtInput.Text = txtInput.Text.Substring(0, lastOpIdx) + op + " ";
                    return;
                }
            }
            txtInput.Text += " " + op + " ";
            isNewNum = true;
        }

        // --- 특수 기능 (소수점, 부호 전환) ---
        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtOutput.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(txtOutput.Text)) { txtOutput.Text = "0"; txtInput.Text += "0"; }
                txtOutput.Text += ".";
                txtInput.Text += ".";
            }
        }

        private void btnPlma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
            {
                double val = double.Parse(txtOutput.Text) * -1;
                string oldVal = txtOutput.Text;
                txtOutput.Text = val.ToString();
                int lastIdx = txtInput.Text.LastIndexOf(oldVal);
                if (lastIdx != -1)
                {
                    txtInput.Text = txtInput.Text.Remove(lastIdx, oldVal.Length).Insert(lastIdx, txtOutput.Text);
                }
            }
        }

        // --- 최종 결과 계산 (=) 및 전처리 (기존 유지) ---
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string expression = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(expression)) return;

            if ("+-×÷".Contains(expression[expression.Length - 1])) { MessageBox.Show("수식이 연산자로 끝날 수 없습니다.", "수식 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (expression.Count(f => f == '(') != expression.Count(f => f == ')')) { MessageBox.Show("괄호의 짝이 맞지 않습니다.", "수식 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string calcExp = expression.Replace("×", "*").Replace("÷", "/");
            calcExp = Regex.Replace(calcExp, @"(\d)\s*\(", "$1 * (");
            calcExp = Regex.Replace(calcExp, @"\)\s*(\d)", ") * $1");
            calcExp = Regex.Replace(calcExp, @"\)\s*\(", ") * (");

            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(calcExp, "");
                if (result.ToString() == "Infinity" || result.ToString() == "NaN") { MessageBox.Show("0으로 나눌 수 없습니다.", "계산 오류", MessageBoxButtons.OK, MessageBoxIcon.Error); ClearAll(); return; }
                txtInput.Text = expression + " = " + result.ToString();
                txtOutput.Text = result.ToString();
                isNewNum = true;
            }
            catch (Exception) { MessageBox.Show("잘못된 수식입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error); ClearAll(); }
        }

        // --- 수정 및 삭제 (기존 유지) ---
        private void btnC_Click(object sender, EventArgs e) { ClearAll(); }
        private void ClearAll() { txtInput.Clear(); txtOutput.Clear(); isNewNum = false; }
        private void btnCe_Click(object sender, EventArgs e) { if (!string.IsNullOrEmpty(txtOutput.Text)) { txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - txtOutput.Text.Length); txtOutput.Clear(); } }
        private void btnDel_Click(object sender, EventArgs e) { if (txtOutput.Text.Length > 0) { txtOutput.Text = txtOutput.Text.Substring(0, txtOutput.Text.Length - 1); txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1); } }
    }
}