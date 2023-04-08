using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class statistics : Form
    {

        Controller controller;

        public statistics()
        {
            InitializeComponent();

            controller = new Controller();

        }

        private void statistics_Load(object sender, EventArgs e)
        {

            int maleCount = controller.viewcountOfMales();
            int femaleCount = controller.viewcountOfFemales();

            male_count_label.Text = maleCount.ToString();
            female_count_label.Text = femaleCount.ToString();

            int avg = (maleCount + femaleCount) / 2;
            circularProgressBar1.Value = avg;


            int withdraw = controller.calcWithdraw();
            int deposit = controller.calcDeposit();

            profitValueLabel.Text = Convert.ToString(withdraw - deposit);

        }
    }
}
