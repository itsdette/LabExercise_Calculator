namespace CalculatorApplication
{
    partial class FrmCalculator
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
            label1 = new Label();
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            label2 = new Label();
            cbOperator = new ComboBox();
            label3 = new Label();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter First Number:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(253, 42);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(293, 30);
            txtBoxInput1.TabIndex = 1;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(253, 162);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(293, 30);
            txtBoxInput2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 164);
            label2.Name = "label2";
            label2.Size = new Size(202, 23);
            label2.TabIndex = 2;
            label2.Text = "Enter Second Number:";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(323, 101);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(151, 31);
            cbOperator.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(148, 223);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 5;
            label3.Text = "Answer:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(323, 274);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(151, 46);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(253, 223);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(81, 23);
            lblDisplayTotal.TabIndex = 7;
            lblDisplayTotal.Text = "Answer:";
            lblDisplayTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 332);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(label3);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(label2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label1);
            Name = "FrmCalculator";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private Label label2;
        private ComboBox cbOperator;
        private Label label3;
        private Button btnEqual;
        private Label lblDisplayTotal;
    }
}