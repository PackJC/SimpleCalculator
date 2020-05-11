using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string answer = "";
            string operation = "Calculator ready!";

            OpLabel.Text = operation;
            OpAnswer.Text = answer;


        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpLabel.Text = string.Empty;
            OpAnswer.Text = string.Empty;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 9;

        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 8;

        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 7;

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " / ";

        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 6;

        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 5;

        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 4;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " * ";

        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 3;

        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 2;

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 1;

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " - ";

        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 0;

        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " . ";

        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string decypher = OpLabel.Text;
            decimal answer = (decimal)dt.Compute(decypher, null);
            OpAnswer.Text = answer.ToString();

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " + ";
        }
    }
}
