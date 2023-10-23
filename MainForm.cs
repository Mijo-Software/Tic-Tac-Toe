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

        private bool IsSameText(string string1, string string2, string string3) => string.Compare(string1, string2) == 0 && string.Compare(string2, string3) == 0;

        private bool CheckIfSomebodyWons()
        {
            if (string.IsNullOrEmpty(buttonField11.Text) ||
                string.IsNullOrEmpty(buttonField12.Text) ||
                string.IsNullOrEmpty(buttonField13.Text) ||
                string.IsNullOrEmpty(buttonField21.Text) ||
                string.IsNullOrEmpty(buttonField22.Text) ||
                string.IsNullOrEmpty(buttonField23.Text) ||
                string.IsNullOrEmpty(buttonField31.Text) ||
                string.IsNullOrEmpty(buttonField32.Text) ||
                string.IsNullOrEmpty(buttonField33.Text)
                )
            {
                return false;
            }
            return IsSameText(buttonField11.Text, buttonField12.Text, buttonField13.Text) ||
                IsSameText(buttonField21.Text, buttonField22.Text, buttonField23.Text) ||
                IsSameText(buttonField31.Text, buttonField32.Text, buttonField33.Text) ||
                IsSameText(buttonField11.Text, buttonField21.Text, buttonField31.Text) ||
                IsSameText(buttonField12.Text, buttonField22.Text, buttonField32.Text) ||
                IsSameText(buttonField13.Text, buttonField23.Text, buttonField33.Text) ||
                IsSameText(buttonField11.Text, buttonField22.Text, buttonField33.Text) ||
                IsSameText(buttonField13.Text, buttonField22.Text, buttonField31.Text);
        }

        private void ButtonField11_Click(object sender, EventArgs e)
        {
            buttonField11.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField11.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField12_Click(object sender, EventArgs e)
        {
            buttonField12.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField12.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField13_Click(object sender, EventArgs e)
        {
            buttonField13.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField13.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField21_Click(object sender, EventArgs e)
        {
            buttonField21.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField21.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField22_Click(object sender, EventArgs e)
        {
            buttonField22.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField22.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField23_Click(object sender, EventArgs e)
        {
            buttonField23.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField23.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField31_Click(object sender, EventArgs e)
        {
            buttonField31.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField31.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField32_Click(object sender, EventArgs e)
        {
            buttonField32.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField32.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }

        private void ButtonField33_Click(object sender, EventArgs e)
        {
            buttonField33.Text = isPlayer1Playing ? "O" : "X";
            isPlayer1Playing = !isPlayer1Playing;
            buttonField33.Enabled = false;
            if (CheckIfSomebodyWons())
            {
                MessageBox.Show("Gewonnen");
            }
        }
    }
}
