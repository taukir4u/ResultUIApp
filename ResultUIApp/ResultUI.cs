using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResultUIApp
{
    public partial class ResultUI : Form
    {
        public ResultUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double physics = Convert.ToDouble(physicsTextBox.Text);
            double chemestry = Convert.ToDouble(chemistryTextBox.Text);
            double math = Convert.ToDouble(mathTextBox.Text);
            Result aResult = new Result(physics, chemestry, math);

            averageTextBox.Text = aResult.GetAverage().ToString();
            gradeTextBox.Text = aResult.GetMyGrade();
        }
    }
}
