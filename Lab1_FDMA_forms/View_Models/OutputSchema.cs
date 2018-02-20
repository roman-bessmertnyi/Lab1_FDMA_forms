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
                form1.Controls.Add(lables[i]);
            }
        }
    }
}
