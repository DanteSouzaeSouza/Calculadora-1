namespace Calculadora
{
    partial class formCalc
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
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnDot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCurrent
            // 
            this.txtCurrent.Font = new System.Drawing.Font("Digital-7", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrent.Location = new System.Drawing.Point(19, 58);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(240, 31);
            this.txtCurrent.TabIndex = 0;
            this.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrent_KeyPress);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(19, 98);
            this.btnSeven.Margin = new System.Windows.Forms.Padding(6);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(52, 52);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnNine
            // 
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.Location = new System.Drawing.Point(145, 98);
            this.btnNine.Margin = new System.Windows.Forms.Padding(6);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(52, 52);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.Location = new System.Drawing.Point(81, 98);
            this.btnEight.Margin = new System.Windows.Forms.Padding(6);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(52, 52);
            this.btnEight.TabIndex = 3;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSix
            // 
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.Location = new System.Drawing.Point(145, 155);
            this.btnSix.Margin = new System.Windows.Forms.Padding(6);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(52, 52);
            this.btnSix.TabIndex = 4;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.Location = new System.Drawing.Point(81, 155);
            this.btnFive.Margin = new System.Windows.Forms.Padding(6);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(52, 52);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.Location = new System.Drawing.Point(19, 155);
            this.btnFour.Margin = new System.Windows.Forms.Padding(6);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(52, 52);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.Location = new System.Drawing.Point(145, 211);
            this.btnThree.Margin = new System.Windows.Forms.Padding(6);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(52, 52);
            this.btnThree.TabIndex = 7;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.Location = new System.Drawing.Point(81, 211);
            this.btnTwo.Margin = new System.Windows.Forms.Padding(6);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(52, 52);
            this.btnTwo.TabIndex = 8;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.Location = new System.Drawing.Point(19, 211);
            this.btnOne.Margin = new System.Windows.Forms.Padding(6);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(52, 52);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(81, 269);
            this.btnZero.Margin = new System.Windows.Forms.Padding(6);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(52, 52);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(207, 249);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(6);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(52, 72);
            this.btnEquals.TabIndex = 11;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(19, 269);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(52, 52);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(207, 211);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(6);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(52, 35);
            this.btnPlus.TabIndex = 16;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(207, 173);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(52, 35);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(207, 135);
            this.btnMult.Margin = new System.Windows.Forms.Padding(6);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(52, 35);
            this.btnMult.TabIndex = 14;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(207, 98);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(6);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(52, 35);
            this.btnDiv.TabIndex = 13;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(23, 9);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(0, 13);
            this.lblHistory.TabIndex = 17;
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(22, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(145, 269);
            this.btnDot.Margin = new System.Windows.Forms.Padding(6);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(52, 52);
            this.btnDot.TabIndex = 19;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // formCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.txtCurrent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCalc";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDot;
    }
}

