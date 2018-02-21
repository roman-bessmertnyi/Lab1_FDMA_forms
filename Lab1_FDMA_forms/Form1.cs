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
        public Input Input { get => input; set => input = value; }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Input.WireLength = Convert.ToDouble(textBoxWireLength.Text);
            Input.BoostedWiresNumber = 4;
            Input.WireAlpha = new double[4];
            Input.WireAlpha[0] = Convert.ToDouble(textBox1.Text);
            Input.WireAlpha[1] = Convert.ToDouble(textBox2.Text);
            Input.WireAlpha[2] = Convert.ToDouble(textBox3.Text);
            Input.WireAlpha[3] = Convert.ToDouble(textBox4.Text);

            Output = outputController.Calculate(Input);

            schema.CreateSchema(50, 350, 1000);
        }

        
    }
}
