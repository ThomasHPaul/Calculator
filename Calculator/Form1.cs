using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string btn0_Click(object sender, EventArgs e)
        {
            return "0";
        }

        private string btn1_Click(object sender, EventArgs e)
        {
            return "1";
        }

        private string btn2_Click(object sender, EventArgs e)
        {
            return "2";
        }

        private string btn3_Click(object sender, EventArgs e)
        {
            return "3";
        }

        private string btn4_Click(object sender, EventArgs e)
        {
            return "4";
        }

        private string btn5_Click(object sender, EventArgs e)
        {
            return "5";
        }

        private string btn6_Click(object sender, EventArgs e)
        {
            return "6";
        }

        private string btn7_Click(object sender, EventArgs e)
        {
            return "7";
        }

        private string btn8_Click(object sender, EventArgs e)
        {
            return "8";
        }

        private string btn9_Click(object sender, EventArgs e)
        {
            return "9";
        }

        private string btnAdd_Click(object sender, EventArgs e)
        {
            return "+";
        }

        private string btnSubtract_Click(object sender, EventArgs e)
        {
            return "-";
        }

        private string btnMultiply_Click(object sender, EventArgs e)
        {
            return "*";
        }

        private string btnDivide_Click(object sender, EventArgs e)
        {
            return "/";
        }

        private string btnEquals_Click(object sender, EventArgs e)
        {
            return "equals";
        }

        private string btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            return "(";
        }

        private string btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            return ")";
        }

        private string btnClearExpression_Click(object sender, EventArgs e)
        {
            return "clear latest";
        }

        private string btnClearGlobal_Click(object sender, EventArgs e)
        {
            return "clear all";
        }
    }
}
