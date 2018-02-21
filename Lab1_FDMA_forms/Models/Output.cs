using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_FDMA_forms.Models
{
    public class Output
    {
        public Output(double boosterWireLength, int boosterStationNumber, double[] wireAttenuation)
        {
            BoosterWireLength = boosterWireLength;
            BoosterStationNumber = boosterStationNumber;
            WireAttenuation = wireAttenuation;
        }

        public double BoosterWireLength { get; set; }
        public int BoosterStationNumber { get; set; }
        public double[] WireAttenuation { get; set; }
    }
}
