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
using Lab1_FDMA_forms.View_Models;

namespace Lab1_FDMA_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            schema = new OutputSchema(this);

            InitializeComponent();
        }

        Input input = new Input();
        Output output;
        OutputController outputController = new OutputController();
        OutputSchema schema;

        public Output Output { get => output; set => output = value; }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            input.WireLength = Convert.ToDouble(textBoxWireLength.Text);
            input.ServicedBoosterStationPart = Convert.ToDouble(textBoxServicedBoosterStationPart.Text);
            input.BoostedWiresNumber = Convert.ToInt16(textBoxBoostedWiresNumber.Text);

            Output = outputController.Calculate(input);

            textBoxBoosterWireLength.Text = Convert.ToString(Output.BoosterWireLength);
            textBoxBoosterStationNumber.Text = Convert.ToString(Output.BoosterStationNumber);
            textBoxServicedBoosterStationNumber.Text = Convert.ToString(Output.ServicedBoosterStationNumber);
            textBoxUnservicedBoosterStationNumber.Text = Convert.ToString(Output.UnservicedBoosterStationNumber);

            schema.CreateSchema(50, 350, 1000);
        }

        
    }
}
