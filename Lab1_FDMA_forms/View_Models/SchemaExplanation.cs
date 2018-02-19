using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lab1_FDMA_forms.View_Models
{
    public class SchemaExplanation : Label
    {
        public SchemaExplanation(string text, string name)
        {
            Font = new Font("Arial", 14);
            Text = text;
            Name = name;
            AutoSize = true;
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }
}
