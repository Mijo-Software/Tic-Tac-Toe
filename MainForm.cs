using System;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        bool isPlayer1Playing = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Won()
        {
            foreach (Button button in tableLayoutPanel.Controls)
            {
                button.Enabled = false;
            }
            MessageBox.Show("Gewonnen");
        }

        private bool IsSameText(string string1, string string2, string string3) => string.Compare(string1, string2) == 0 && string.Compare(string2, string3) == 0;

        private bool CheckIfSomebodyWons()
        {
            if (!string.IsNullOrEmpty(value: buttonField11.Text) && !string.IsNullOrEmpty(value: buttonField12.Text) && !string.IsNullOrEmpty(value: buttonField13.Text))
            {
                return IsSameText(string1: buttonField11.Text, string2: buttonField12.Text, string3: buttonField13.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField21.Text) && !string.IsNullOrEmpty(value: buttonField22.Text) && !string.IsNullOrEmpty(value: buttonField23.Text))
            {
                return IsSameText(string1: buttonField21.Text, string2: buttonField22.Text, string3: buttonField23.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField31.Text) && !string.IsNullOrEmpty(value: buttonField32.Text) && !string.IsNullOrEmpty(value: buttonField33.Text))
            {
                return IsSameText(string1: buttonField31.Text, string2: buttonField32.Text, string3: buttonField33.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField11.Text) && !string.IsNullOrEmpty(value: buttonField21.Text) && !string.IsNullOrEmpty(value: buttonField31.Text))
            {
                return IsSameText(string1: buttonField11.Text, string2: buttonField21.Text, string3: buttonField31.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField12.Text) && !string.IsNullOrEmpty(value: buttonField22.Text) && !string.IsNullOrEmpty(value: buttonField32.Text))
            {
                return IsSameText(string1: buttonField12.Text, string2: buttonField22.Text, string3: buttonField32.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField13.Text) && !string.IsNullOrEmpty(value: buttonField23.Text) && !string.IsNullOrEmpty(value: buttonField33.Text))
            {
                return IsSameText(string1: buttonField13.Text, string2: buttonField23.Text, string3: buttonField33.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField11.Text) && !string.IsNullOrEmpty(value: buttonField22.Text) && !string.IsNullOrEmpty(value: buttonField33.Text))
            {
                return IsSameText(string1: buttonField11.Text, string2: buttonField22.Text, string3: buttonField33.Text);
            }
            if (!string.IsNullOrEmpty(value: buttonField13.Text) && !string.IsNullOrEmpty(value: buttonField22.Text) && !string.IsNullOrEmpty(value: buttonField31.Text))
            {
                return IsSameText(string1: buttonField13.Text, string2: buttonField22.Text, string3: buttonField31.Text);
            }
            return false;
        }

        private void ButtonField11_Click(object sender, EventArgs e)
        {
            buttonField11.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField11.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField12_Click(object sender, EventArgs e)
        {
            buttonField12.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField12.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField13_Click(object sender, EventArgs e)
        {
            buttonField13.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField13.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField21_Click(object sender, EventArgs e)
        {
            buttonField21.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField21.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField22_Click(object sender, EventArgs e)
        {
            buttonField22.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField22.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField23_Click(object sender, EventArgs e)
        {
            buttonField23.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField23.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField31_Click(object sender, EventArgs e)
        {
            buttonField31.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField31.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField32_Click(object sender, EventArgs e)
        {
            buttonField32.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField32.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ButtonField33_Click(object sender, EventArgs e)
        {
            buttonField33.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField33.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                Won();
            }
        }

        private void ToolStripButtonNewGame_Click(object sender, EventArgs e)
        {
            foreach (Button button in tableLayoutPanel.Controls)
            {
                button.Enabled = true;
                button.Text = string.Empty;
            }
        }
    }
}
