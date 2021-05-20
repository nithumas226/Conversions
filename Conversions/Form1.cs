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
                InchestoCm(number);
            }
            else if(method == 2)
            {
                FeettoCm(number);
            }
            else if(method == 3)
            {
                YardstoMetres(number);
            }
            else
            {
                MilestoKm(number);
            }
        }

        public void InchestoCm(int inches)
        {
            double cms = inches * 2.54;
            outputLabel.Text = $"{inches} inches = {cms.ToString(".##")} cms";
        }

        public void FeettoCm(int feet)
        {
            double cm = feet * 30.48;
            outputLabel.Text = $"{feet} feet = {cm.ToString(".##")} cms";
        }

        public void YardstoMetres(int yards)
        {
            double metres = yards * 0.91;
            outputLabel.Text = $"{yards} yards = {metres.ToString(".##")}ms";
        }

        public void MilestoKm(int miles)
        {
            double kms = miles * 1.6;
            outputLabel.Text = $"{miles} miles = {kms.ToString(".##")} kms";
        }
    }
}
