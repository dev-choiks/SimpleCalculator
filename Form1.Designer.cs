namespace SimpleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnDivi = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnMulti = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnPlus = new Button();
            btnPlma = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnEqual = new Button();
            btnMinu = new Button();
            btnDel = new Button();
            btnC = new Button();
            btnCe = new Button();
            lblTitle = new Label();
            btnLparen = new Button();
            btnRparen = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(57, 111);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(503, 50);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtOutput.Location = new Point(57, 181);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(503, 50);
            txtOutput.TabIndex = 2;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ControlDark;
            btnOne.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnOne.ForeColor = Color.Coral;
            btnOne.Location = new Point(57, 530);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(87, 80);
            btnOne.TabIndex = 3;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ControlDark;
            btnTwo.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnTwo.ForeColor = Color.Coral;
            btnTwo.Location = new Point(150, 530);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(87, 79);
            btnTwo.TabIndex = 4;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ControlDark;
            btnThree.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnThree.ForeColor = Color.Coral;
            btnThree.Location = new Point(243, 530);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(87, 79);
            btnThree.TabIndex = 5;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnDivi
            // 
            btnDivi.BackColor = SystemColors.ControlDark;
            btnDivi.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDivi.ForeColor = SystemColors.MenuHighlight;
            btnDivi.Location = new Point(336, 269);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(87, 78);
            btnDivi.TabIndex = 6;
            btnDivi.Text = "÷";
            btnDivi.UseVisualStyleBackColor = false;
            btnDivi.Click += btnDivi_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ControlDark;
            btnFour.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnFour.ForeColor = Color.Coral;
            btnFour.Location = new Point(57, 438);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(87, 80);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ControlDark;
            btnFive.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnFive.ForeColor = Color.Coral;
            btnFive.Location = new Point(150, 439);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(87, 79);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ControlDark;
            btnSix.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnSix.ForeColor = Color.Coral;
            btnSix.Location = new Point(243, 439);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(87, 79);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = SystemColors.ControlDark;
            btnMulti.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnMulti.ForeColor = SystemColors.MenuHighlight;
            btnMulti.Location = new Point(336, 353);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(87, 79);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ControlDark;
            btnSeven.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnSeven.ForeColor = Color.Coral;
            btnSeven.Location = new Point(57, 353);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(87, 80);
            btnSeven.TabIndex = 11;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ControlDark;
            btnEight.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnEight.ForeColor = Color.Coral;
            btnEight.Location = new Point(150, 353);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(87, 79);
            btnEight.TabIndex = 12;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ControlDark;
            btnNine.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnNine.ForeColor = Color.Coral;
            btnNine.Location = new Point(243, 353);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(87, 79);
            btnNine.TabIndex = 13;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlDark;
            btnPlus.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnPlus.ForeColor = SystemColors.MenuHighlight;
            btnPlus.Location = new Point(336, 530);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(87, 79);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnPlma
            // 
            btnPlma.BackColor = SystemColors.ControlDark;
            btnPlma.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnPlma.ForeColor = Color.Chocolate;
            btnPlma.Location = new Point(57, 616);
            btnPlma.Name = "btnPlma";
            btnPlma.Size = new Size(87, 80);
            btnPlma.TabIndex = 15;
            btnPlma.Text = "+/-";
            btnPlma.UseVisualStyleBackColor = false;
            btnPlma.Click += btnPlma_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ControlDark;
            btnZero.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnZero.ForeColor = Color.Coral;
            btnZero.Location = new Point(150, 616);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(87, 79);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ControlDark;
            btnDot.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDot.ForeColor = Color.Chocolate;
            btnDot.Location = new Point(243, 616);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(87, 79);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += btnDot_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ControlDark;
            btnEqual.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnEqual.ForeColor = Color.Chocolate;
            btnEqual.Location = new Point(336, 616);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(87, 79);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnMinu
            // 
            btnMinu.BackColor = SystemColors.ControlDark;
            btnMinu.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnMinu.ForeColor = SystemColors.MenuHighlight;
            btnMinu.Location = new Point(336, 439);
            btnMinu.Name = "btnMinu";
            btnMinu.Size = new Size(87, 79);
            btnMinu.TabIndex = 22;
            btnMinu.Text = "-";
            btnMinu.UseVisualStyleBackColor = false;
            btnMinu.Click += btnMinu_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ControlDark;
            btnDel.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDel.ForeColor = Color.Chocolate;
            btnDel.Location = new Point(243, 269);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(87, 79);
            btnDel.TabIndex = 21;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // btnC
            // 
            btnC.BackColor = SystemColors.ControlDark;
            btnC.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnC.ForeColor = Color.Chocolate;
            btnC.Location = new Point(150, 269);
            btnC.Name = "btnC";
            btnC.Size = new Size(87, 79);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCe
            // 
            btnCe.BackColor = SystemColors.ControlDark;
            btnCe.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnCe.ForeColor = Color.Chocolate;
            btnCe.Location = new Point(57, 268);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(87, 80);
            btnCe.TabIndex = 19;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = false;
            btnCe.Click += btnCe_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 말랑말랑 Bold", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.Coral;
            lblTitle.Location = new Point(114, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(382, 56);
            lblTitle.TabIndex = 23;
            lblTitle.Text = "Simple Calculator";
            // 
            // btnLparen
            // 
            btnLparen.BackColor = SystemColors.ControlDark;
            btnLparen.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnLparen.ForeColor = SystemColors.MenuHighlight;
            btnLparen.Location = new Point(429, 269);
            btnLparen.Name = "btnLparen";
            btnLparen.Size = new Size(87, 79);
            btnLparen.TabIndex = 25;
            btnLparen.Text = "(";
            btnLparen.UseVisualStyleBackColor = false;
            btnLparen.Click += btnLparen_Click;
            // 
            // btnRparen
            // 
            btnRparen.BackColor = SystemColors.ControlDark;
            btnRparen.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnRparen.ForeColor = SystemColors.MenuHighlight;
            btnRparen.Location = new Point(429, 353);
            btnRparen.Name = "btnRparen";
            btnRparen.Size = new Size(87, 78);
            btnRparen.TabIndex = 24;
            btnRparen.Text = ")";
            btnRparen.UseVisualStyleBackColor = false;
            btnRparen.Click += btnRparen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 738);
            Controls.Add(btnLparen);
            Controls.Add(btnRparen);
            Controls.Add(lblTitle);
            Controls.Add(btnMinu);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Controls.Add(btnEqual);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnPlma);
            Controls.Add(btnPlus);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnMulti);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnDivi);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnDivi;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnMulti;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnPlus;
        private Button btnPlma;
        private Button btnZero;
        private Button btnDot;
        private Button btnEqual;
        private Button btnMinu;
        private Button btnDel;
        private Button btnC;
        private Button btnCe;
        private Label lblTitle;
        private Button btnLparen;
        private Button btnRparen;
    }
}
