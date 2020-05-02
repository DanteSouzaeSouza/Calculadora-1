using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class formCalc : Form
    {
        public formCalc()
        {
            InitializeComponent();
        }

        private void txtCurrent_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        StringBuilder conta = new StringBuilder();
        Double valAtual = 0;
        Double valTotal = 0;
        String lastOp = "";

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrent.Clear();
            lblHistory.Text = "";
            conta.Clear();
            valTotal = 0;
            valAtual = 0;
            lblTotal.Text = "";

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "1";
            conta.Append("1");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "2";
            conta.Append("2");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "3";
            conta.Append("3");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "4";
            conta.Append("4");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "5";
            conta.Append("5");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "6";
            conta.Append("6");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "7";
            conta.Append("7");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnEight_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "8";
            conta.Append("8");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "9";
            conta.Append("9");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCurrent.Text += "0";
            conta.Append("0");
            valAtual = Convert.ToDouble(txtCurrent.Text);
            Console.WriteLine(valAtual);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (conta.Length != 0)
            {
                lastOp = "+";
                txtCurrent.Clear();
                lblTotal.Text = valAtual.ToString();
                conta.Append(" + ");
                valTotal = valAtual + valTotal;
                Console.WriteLine("valor atual" + valAtual);
                Console.WriteLine("valor total" + valTotal);
                lblTotal.Text = valTotal.ToString();
                lblHistory.Text = conta.ToString();
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (conta.Length != 0)
            {
                lastOp = "/";
                txtCurrent.Clear();
                lblTotal.Text = valAtual.ToString();
                conta.Append(" / ");
                valTotal = valTotal / valAtual;
                Console.WriteLine("valor atual" + valAtual);
                Console.WriteLine("valor total" + valTotal);
                lblTotal.Text = valTotal.ToString();
                lblHistory.Text = conta.ToString();
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (conta.Length != 0)
            {
                lastOp = "*";
                txtCurrent.Clear();
                lblTotal.Text = valAtual.ToString();
                conta.Append(" * ");
                valTotal = valTotal * valAtual;
                Console.WriteLine("valor atual" + valAtual);
                Console.WriteLine("valor total" + valTotal);
                lblTotal.Text = valTotal.ToString();
                lblHistory.Text = conta.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (conta.Length != 0)
            {
                lastOp = "-";
                txtCurrent.Clear();
                lblTotal.Text = valAtual.ToString();
                conta.Append(" - ");
                valTotal = valTotal - valAtual;
                Console.WriteLine("valor atual" + valAtual);
                Console.WriteLine("valor total" + valTotal);
                lblTotal.Text = valTotal.ToString();
                lblHistory.Text = conta.ToString();

            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtCurrent.Text.Contains(","))
            {
                if (txtCurrent.Text == "")
                {
                    txtCurrent.Text = "0,";
                }
                else
                {
                    txtCurrent.Text += ",";
                    conta.Append(",");

                }
                valAtual = Convert.ToDouble(txtCurrent.Text);
                Console.WriteLine(valAtual);
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }
    }
}