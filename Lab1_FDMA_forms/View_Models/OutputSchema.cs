using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1_FDMA_forms.View_Models
{
    public class OutputSchema
    {
        List<Label> lables = new List<Label>();
        Form1 form1;
        int x; int y; int width;

        public OutputSchema(Form1 form1)
        {
            this.form1 = form1;
        }

        public void CreateSchema(int x, int y, int width)
        {
            this.x = x;
            this.y = y;
            this.width = width;

            foreach (Control control in lables)
            {
                form1.Controls.Remove(control);
            }
            lables.Clear();

            AddElements();
            AddExplanations();
        }

        public void AddElements()
        {
            int lastLableIndex = lables.Count;
            int elementsCount = form1.Output.BoosterStationNumber + 2;

            lables.Add(new SchemaElement("ОС А", "schemaStart"));

            for (int i = 1; i <= form1.Output.BoosterStationNumber; i++)
            {
                lables.Add(new SchemaElement("НУП" + i, "BoosterStation" + i));
            }

            lables.Add(new SchemaElement("ОС B", "schemaEnd"));

            for (int i = 0; i < elementsCount; i++)
            {
                int xCurrent = x + (width * i / (lables.Count - 1));
                lables[lastLableIndex + i].Location = new Point(xCurrent, y);
                form1.Controls.Add(lables[lastLableIndex+ i]);
            }
        }

        public void AddExplanations()
        {
            int lastLableIndex = lables.Count;

            lables.Add(new SchemaExplanation("L, " + form1.Input.WireLength + " км" , "Length")
            { Location = new Point(x+width/2, y + 160)});
            form1.Controls.Add(lables[lables.Count-1]);

            lables.Add(new SchemaExplanation("Lпд , " + form1.Output.BoosterWireLength + " км", "BoosterLength")
            { Location = new Point(x + width / form1.Input.BoostedWiresNumber / 2, y + 120) });
            form1.Controls.Add(lables[lables.Count - 1]);

            for (int i = 0; i < form1.Input.BoostedWiresNumber; i++)
            {
                lables.Add(new SchemaExplanation("Аділ " + (i+1) + ", " + form1.Output.WireAttenuation[i] + " Дб", "Wireattenuation" + (i + 1))
                { Location = new Point(x + width / form1.Input.BoostedWiresNumber / 2 + width / form1.Input.BoostedWiresNumber * i, y - 30) });
                form1.Controls.Add(lables[lables.Count - 1]);
            }
        }
    }
}
