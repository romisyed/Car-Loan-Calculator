using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class AynchronousProgramming : Form
    {
        public AynchronousProgramming()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void btnFactorial_Click(object sender, EventArgs e)
        {
            await Run();
        }
        private async Task Run()
        {
            long factorial = 0;
            await Task.Run(async () => {
                factorial = await Factorial(Convert.ToInt64(txtFactorialInput.Text));
            });
            if (factorial != 0)
            {
                lblFactorial.Text = factorial.ToString();
            }

        }
        private async Task<long> Factorial(long num)
        {
            long factorial = 1;
            for (long i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            int rate = Convert.ToInt32(txtInterest.Text);
            int duration = Convert.ToInt32(txtDuration.Text);

            int interest = amount * rate * duration;
            lblInterest.Text = interest.ToString();

        }
    }
}