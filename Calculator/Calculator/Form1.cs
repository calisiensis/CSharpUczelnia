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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Parser parser = new Parser(expressionTextBox.Text);
            Queue<Symbol> symbols = parser.Parse();

            RPNCalculator calculator = new RPNCalculator(symbols);
            Symbol resoult = calculator.Calculate();
            RationalNumber rationalNumberResoult = resoult as RationalNumber;
            textBox1.Text = ((double)rationalNumberResoult).ToString();
        }

        private void calculateButton_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
