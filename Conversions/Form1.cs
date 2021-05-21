using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvetButton_Click(object sender, EventArgs e)
        {
            int method = Convert.ToInt32(choiceInput.Text);
            int number = Convert.ToInt32(numberInput.Text);

            if(method == 1)
            {
                double cms = InchestoCm(number);

                outputLabel.Text = $"{number} inches = {cms.ToString(".##")} cms";
            }
            else if(method == 2)
            {
                double cm = FeettoCm(number);

                outputLabel.Text = $"{number} feet = {cm.ToString(".##")} cms";
            }
            else if(method == 3)
            {
                double metres = YardstoMetres(number);

                outputLabel.Text = $"{number} yards = {metres.ToString(".##")}ms";
            }
            else if (method == 4)
            {
                double kms = MilestoKm(number);

                outputLabel.Text = $"{number} miles = {kms.ToString(".##")} kms";
            }
            else
            {
                outputLabel.Text = $"Please insert a number from 1-4";

            }
        }

        public double InchestoCm(int inches)
        {
            double cms = inches * 2.54;
            return cms;
        }

        public double FeettoCm(int feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        public double YardstoMetres(int yards)
        {
            double metres = yards * 0.91;
            return metres;
        }

        public double MilestoKm(int miles)
        {
            double kms = miles * 1.6;
            return kms;
        }
    }
}
