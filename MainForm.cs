﻿//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Simple Calculator
//	File Name:		MainForm.cs
//	Description:    Code behind the form
//	Author:			Johnny Pack, packjc@etsu.edu, Department of Computing, East Tennessee State University
//	Created:		Thursday, May 11, 2020
//	Copyright:		Johnny Pack, 2020
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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
    /// <summary>
    /// Form class
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string answer = "";
            string operation = "";
            OpLabel.Text = operation;
            OpAnswer.Text = answer;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text = string.Empty;
            OpAnswer.Text = string.Empty;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += (decimal)9;
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
            OpLabel.Text += 2.0;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 1.0;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " - ";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += 0.0;
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += ".";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            DataTable myDataTable = new DataTable();
            string decypher = OpLabel.Text;
            var answer = myDataTable.Compute(decypher, "");
            OpAnswer.Text = answer.ToString();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            OpLabel.Text += " + ";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OpAnswer.Text = "";
            OpLabel.Text = "";
        }
    }
}
