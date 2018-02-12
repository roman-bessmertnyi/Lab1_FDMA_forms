using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_FDMA_forms.Models
{
    public class Output
    {
        public double BoosterWireLength { get; set; }
        public int BoosterStationNumber { get; set; }
        public int ServicedBoosterStationNumber { get; set; }
        public int UnservicedBoosterStationNumber { get; set; }
        public Output(
            double _BoosterWireLength,
            int _BoosterStationNumber,
            int _ServicedBoosterStationNumber,
            int _UnservicedBoosterStationNumber)
        {
            BoosterWireLength = _BoosterWireLength;
            BoosterStationNumber = _BoosterStationNumber;
            ServicedBoosterStationNumber = _ServicedBoosterStationNumber;
            UnservicedBoosterStationNumber = _UnservicedBoosterStationNumber;
        }
    }
}
