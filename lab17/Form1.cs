using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab17
{
    public partial class Form1 : Form
    {
        private TrapezoidalIntegration calculator;

        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxFunction.Items.Add("1/3√x");
            comboBoxFunction.Items.Add("e^x/√x");
            comboBoxFunction.Items.Add("log2(x)");
            comboBoxFunction.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            int n = Convert.ToInt32(textBoxN.Text);

            double result = calculator.Calculate(a, b, n);

            labelResults.Text = "Результат обчислення інтегралу: " + result;
        }

        private void comboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFunction.SelectedIndex == 0)
            {
                calculator = new TrapezoidalIntegration(x => 1.0 / (3 * Math.Sqrt(x)));
            }
            else if (comboBoxFunction.SelectedIndex == 1)
            {
                calculator = new TrapezoidalIntegration(x => Math.Exp(x) / Math.Sqrt(x));
            }
            else if (comboBoxFunction.SelectedIndex == 2)
            {
                calculator = new TrapezoidalIntegration(x => Math.Log(x, 2));
            }
        }
    }
}



