using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1_FDMA_forms.Controllers;
using Lab1_FDMA_forms.Models;

namespace Lab1_FDMA_forms
{
    public partial class Form1 : Form
    {
        Input input = new Input();
        OutputController outputController = new OutputController();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Input input = new Input();
            input.WireLength = Convert.ToDouble(textBoxWireLength.Text);
            input.ServicedBoosterStationPart = Convert.ToDouble(textBoxServicedBoosterStationPart.Text);
            input.BoostedWiresNumber = Convert.ToInt16(textBoxBoostedWiresNumber.Text);

            Output output = outputController.Calculate(input);

            textBoxBoosterWireLength.Text = Convert.ToString(output.BoosterWireLength);
            textBoxBoosterStationNumber.Text = Convert.ToString(output.BoosterStationNumber);
            textBoxServicedBoosterStationNumber.Text = Convert.ToString(output.ServicedBoosterStationNumber);
            textBoxUnservicedBoosterStationNumber.Text = Convert.ToString(output.UnservicedBoosterStationNumber);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
