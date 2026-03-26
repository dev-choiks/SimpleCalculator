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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(54, 119);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(382, 50);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("한컴 말랑말랑 Bold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            txtOutput.Location = new Point(54, 189);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(382, 50);
            txtOutput.TabIndex = 2;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnOne.ForeColor = Color.Coral;
            btnOne.Location = new Point(57, 439);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(87, 53);
            btnOne.TabIndex = 3;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnTwo.ForeColor = Color.Coral;
            btnTwo.Location = new Point(152, 440);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(87, 53);
            btnTwo.TabIndex = 4;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnThree.ForeColor = Color.Coral;
            btnThree.Location = new Point(247, 440);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(87, 53);
            btnThree.TabIndex = 5;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnDivi
            // 
            btnDivi.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDivi.ForeColor = SystemColors.MenuHighlight;
            btnDivi.Location = new Point(340, 262);
            btnDivi.Name = "btnDivi";
            btnDivi.Size = new Size(87, 53);
            btnDivi.TabIndex = 6;
            btnDivi.Text = "÷";
            btnDivi.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnFour.ForeColor = Color.Coral;
            btnFour.Location = new Point(57, 381);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(87, 53);
            btnFour.TabIndex = 7;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnFive.ForeColor = Color.Coral;
            btnFive.Location = new Point(152, 382);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(87, 53);
            btnFive.TabIndex = 8;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnSix.ForeColor = Color.Coral;
            btnSix.Location = new Point(247, 381);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(87, 53);
            btnSix.TabIndex = 9;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnMulti
            // 
            btnMulti.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnMulti.ForeColor = SystemColors.MenuHighlight;
            btnMulti.Location = new Point(340, 320);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(87, 53);
            btnMulti.TabIndex = 10;
            btnMulti.Text = "×";
            btnMulti.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnSeven.ForeColor = Color.Coral;
            btnSeven.Location = new Point(57, 322);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(87, 53);
            btnSeven.TabIndex = 11;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnEight.ForeColor = Color.Coral;
            btnEight.Location = new Point(152, 323);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(87, 53);
            btnEight.TabIndex = 12;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnNine.ForeColor = Color.Coral;
            btnNine.Location = new Point(247, 322);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(87, 53);
            btnNine.TabIndex = 13;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnPlus.ForeColor = SystemColors.MenuHighlight;
            btnPlus.Location = new Point(340, 439);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(87, 53);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnPlma
            // 
            btnPlma.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnPlma.Location = new Point(57, 499);
            btnPlma.Name = "btnPlma";
            btnPlma.Size = new Size(87, 53);
            btnPlma.TabIndex = 15;
            btnPlma.Text = "+/-";
            btnPlma.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnZero.ForeColor = Color.Coral;
            btnZero.Location = new Point(152, 499);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(87, 53);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDot.Location = new Point(247, 499);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(87, 53);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnEqual.ForeColor = Color.Red;
            btnEqual.Location = new Point(340, 499);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(87, 53);
            btnEqual.TabIndex = 18;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnMinu
            // 
            btnMinu.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnMinu.ForeColor = SystemColors.MenuHighlight;
            btnMinu.Location = new Point(340, 379);
            btnMinu.Name = "btnMinu";
            btnMinu.Size = new Size(87, 53);
            btnMinu.TabIndex = 22;
            btnMinu.Text = "-";
            btnMinu.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnDel.Location = new Point(247, 263);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(87, 53);
            btnDel.TabIndex = 21;
            btnDel.Text = "Del";
            btnDel.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnC.Location = new Point(152, 263);
            btnC.Name = "btnC";
            btnC.Size = new Size(87, 53);
            btnC.TabIndex = 20;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnCe
            // 
            btnCe.Font = new Font("한컴 말랑말랑 Bold", 16.1999989F, FontStyle.Bold);
            btnCe.Location = new Point(57, 263);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(87, 53);
            btnCe.TabIndex = 19;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("한컴 말랑말랑 Bold", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(54, 40);
            label1.Name = "label1";
            label1.Size = new Size(382, 56);
            label1.TabIndex = 23;
            label1.Text = "Simple Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 605);
            Controls.Add(label1);
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
        private Label label1;
    }
}
