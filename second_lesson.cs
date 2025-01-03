using System;
using System.Windows.Forms;

namespace AddTwoNumbersApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse numbers from textboxes
                double number1 = double.Parse(txtNumber1.Text);
                double number2 = double.Parse(txtNumber2.Text);

                // Add the numbers
                double result = number1 + number2;

                // Show the result
                lblResult.Text = "Result: " + result.ToString();
            }
            catch
            {
                // Handle invalid input
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
