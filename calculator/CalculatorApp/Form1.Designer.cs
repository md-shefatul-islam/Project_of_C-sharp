namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(24, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(394, 97);
            this.txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn7.Location = new System.Drawing.Point(24, 151);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 53);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn8.Location = new System.Drawing.Point(129, 151);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 53);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn9.Location = new System.Drawing.Point(238, 151);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 53);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnCancel.Location = new System.Drawing.Point(343, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDiv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnDiv.Location = new System.Drawing.Point(344, 227);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 53);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.operator_clicked);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn6.Location = new System.Drawing.Point(239, 227);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 53);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn5.Location = new System.Drawing.Point(129, 227);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 53);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn4.Location = new System.Drawing.Point(25, 227);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 53);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnMul.Location = new System.Drawing.Point(343, 307);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 53);
            this.btnMul.TabIndex = 12;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.operator_clicked);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn3.Location = new System.Drawing.Point(238, 307);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 53);
            this.btn3.TabIndex = 11;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn2.Location = new System.Drawing.Point(129, 307);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 53);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn1.Location = new System.Drawing.Point(24, 307);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 53);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnMin.Location = new System.Drawing.Point(343, 385);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 53);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.operator_clicked);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn0.Location = new System.Drawing.Point(129, 385);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(185, 53);
            this.btn0.TabIndex = 14;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPoint.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnPoint.Location = new System.Drawing.Point(24, 385);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(75, 53);
            this.btnPoint.TabIndex = 13;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btn_Clicked);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnAdd.Location = new System.Drawing.Point(343, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operator_clicked);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEqual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnEqual.Location = new System.Drawing.Point(129, 463);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(189, 53);
            this.btnEqual.TabIndex = 18;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPercent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnPercent.Location = new System.Drawing.Point(24, 463);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(75, 53);
            this.btnPercent.TabIndex = 17;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(444, 557);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnPercent;
    }
}

