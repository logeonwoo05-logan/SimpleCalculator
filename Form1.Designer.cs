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
            txtExpression = new TextBox();
            txtResult = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            txtTit = new Label();
            btnCe = new Button();
            btnC = new Button();
            btnDel = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnDot = new Button();
            btnPluMnu = new Button();
            SuspendLayout();
            // 
            // txtExpression
            // 
            txtExpression.Location = new Point(114, 137);
            txtExpression.Name = "txtExpression";
            txtExpression.Size = new Size(481, 39);
            txtExpression.TabIndex = 0;
            txtExpression.TextChanged += txtExpression_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(114, 191);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(481, 39);
            txtResult.TabIndex = 1;
            txtResult.TextChanged += txtResult_TextChanged;
            // 
            // btn7
            // 
            btn7.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.HotTrack;
            btn7.Location = new Point(114, 296);
            btn7.Name = "btn7";
            btn7.Size = new Size(106, 54);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.HotTrack;
            btn8.Location = new Point(243, 296);
            btn8.Name = "btn8";
            btn8.Size = new Size(106, 54);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.HotTrack;
            btn9.Location = new Point(367, 296);
            btn9.Name = "btn9";
            btn9.Size = new Size(106, 54);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.HotTrack;
            btn4.Location = new Point(114, 356);
            btn4.Name = "btn4";
            btn4.Size = new Size(106, 54);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.HotTrack;
            btn5.Location = new Point(243, 356);
            btn5.Name = "btn5";
            btn5.Size = new Size(106, 54);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.HotTrack;
            btn6.Location = new Point(367, 356);
            btn6.Name = "btn6";
            btn6.Size = new Size(106, 54);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.HotTrack;
            btn1.Location = new Point(114, 416);
            btn1.Name = "btn1";
            btn1.Size = new Size(106, 54);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.HotTrack;
            btn2.Location = new Point(243, 416);
            btn2.Name = "btn2";
            btn2.Size = new Size(106, 54);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.HotTrack;
            btn3.Location = new Point(367, 416);
            btn3.Name = "btn3";
            btn3.Size = new Size(106, 54);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.HotTrack;
            btn0.Location = new Point(243, 476);
            btn0.Name = "btn0";
            btn0.Size = new Size(106, 54);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(489, 416);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 54);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnEqual.ForeColor = Color.Purple;
            btnEqual.Location = new Point(489, 476);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(106, 54);
            btnEqual.TabIndex = 13;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // txtTit
            // 
            txtTit.AutoSize = true;
            txtTit.Font = new Font("맑은 고딕", 20F, FontStyle.Bold);
            txtTit.ForeColor = SystemColors.HotTrack;
            txtTit.Location = new Point(116, 37);
            txtTit.Name = "txtTit";
            txtTit.Size = new Size(480, 72);
            txtTit.TabIndex = 14;
            txtTit.Text = "Simple Calculator";
            // 
            // btnCe
            // 
            btnCe.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnCe.Location = new Point(114, 236);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(106, 54);
            btnCe.TabIndex = 15;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            btnCe.Click += btnCe_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnC.Location = new Point(243, 236);
            btnC.Name = "btnC";
            btnC.Size = new Size(106, 54);
            btnC.TabIndex = 16;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnDel.Location = new Point(367, 236);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(106, 54);
            btnDel.TabIndex = 17;
            btnDel.Text = "del";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnDivide.ForeColor = Color.FromArgb(192, 0, 0);
            btnDivide.Location = new Point(489, 236);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(106, 54);
            btnDivide.TabIndex = 18;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.FromArgb(192, 0, 0);
            btnMultiply.Location = new Point(489, 296);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(106, 54);
            btnMultiply.TabIndex = 19;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnSubtract.ForeColor = Color.FromArgb(192, 0, 0);
            btnSubtract.Location = new Point(489, 356);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(106, 54);
            btnSubtract.TabIndex = 20;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnDot.Location = new Point(367, 476);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(106, 54);
            btnDot.TabIndex = 21;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnPluMnu
            // 
            btnPluMnu.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            btnPluMnu.Location = new Point(114, 476);
            btnPluMnu.Name = "btnPluMnu";
            btnPluMnu.Size = new Size(106, 54);
            btnPluMnu.TabIndex = 22;
            btnPluMnu.Text = "+/-";
            btnPluMnu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 560);
            Controls.Add(btnPluMnu);
            Controls.Add(btnDot);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnDel);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Controls.Add(txtTit);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtResult);
            Controls.Add(txtExpression);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExpression;
        private TextBox txtResult;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnAdd;
        private Button btnEqual;
        private Label txtTit;
        private Button btnCe;
        private Button btnC;
        private Button btnDel;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnDot;
        private Button btnPluMnu;
    }
}
