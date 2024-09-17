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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            AddText("0");
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            AddText("1");
        }
        private void TwoBtn_Click(object sender, EventArgs e)
        {
            AddText("2");
        }
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            AddText("3");
        }
        private void FourBtn_Click(object sender, EventArgs e)
        {
            AddText("4");
        }
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            AddText("5");
        }
        private void SixBtn_Click(object sender, EventArgs e)
        {
            AddText("6");
        }
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            AddText("7");
        }
        private void EightBtn_Click(object sender, EventArgs e)
        {
            AddText("8");
        }
        private void NineBtn_Click(object sender, EventArgs e)
        {
            AddText("9");
        }
        private void DecimalBtn_Click(object sender, EventArgs e)
        {
            AddText(".");
        }
        private void LeftParenBtn_Click(object sender, EventArgs e)
        {
            AddText("(");
        }
        private void RightParenBtn_Click(object sender, EventArgs e)
        {
            AddText(")");
        }
        private void PlusBtn_Click(object sender, EventArgs e)
        {
            AddText("+");
        }
        private void MinusBtn_Click(object sender, EventArgs e)
        {
            AddText("-");
        }
        private void MultBtn_Click(object sender, EventArgs e)
        {
            AddText("*");
        }
        private void DivideBtn_Click(object sender, EventArgs e)
        {
            AddText("/");
        }
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            // Do nothing for now
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RemoveText();
        }

        // Appends text to the calculator entryBox
        private void AddText(string newText)
        {
            entryBox.Text += newText;
        }

        // Returns text of the calculator entryBox
        private string GetText()
        {
            return entryBox.Text;
        }

        // Clears text from the calculator entryBox
        private void RemoveText()
        {
            entryBox.Text = "";
        }
    }
}
