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
        Input input = new Input();
        OutputController outputController = new OutputController();
        List<Control> schema = new List<Control>();

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

            CreateSchema(output, 50, 350, 1000);
        }

        void CreateSchema(Output output, int x, int y, int width)
        {
            foreach (SchemaElement _SchemaElement in schema)
            {
                Controls.Remove(_SchemaElement);
            }
            schema.Clear();

            schema.Add(new SchemaElement("ОС А", "schemaStart"));

            for (int i = 1; i <= output.BoosterStationNumber; i++)
            {
                schema.Add(new SchemaElement("НУП" + i, "BoosterStation" + i));
            }

            schema.Add(new SchemaElement("ОС B", "schemaEnd"));

            for (int i = 0; i <schema.Count; i++)
            {
                int xCurrent = x + (width * i / (schema.Count - 1));
                schema[i].Location = new Point(xCurrent, y);
                Controls.Add(schema[i]);
            }


        }
    }
}
