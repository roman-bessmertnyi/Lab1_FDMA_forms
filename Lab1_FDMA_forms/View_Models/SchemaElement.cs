using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1_FDMA_forms.View_Models
{
    public class SchemaElement : Label
    {
        public SchemaElement(string text, string name)
        {
            BorderStyle = BorderStyle.FixedSingle;
            BackColor = SystemColors.ControlLightLight;
            Font = new Font("Arial", 24, FontStyle.Bold);
            Text = text;
            Name = name;
            Size = new Size(100, 100);
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
