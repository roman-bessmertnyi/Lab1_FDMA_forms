using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab1_FDMA_forms.Models;

namespace Lab1_FDMA_forms.Controllers
{
    public class OutputController
    {
        public Output Calculate(Input _Input)
        {
            double _BoosterWireLength = (_Input.WireLength / _Input.BoostedWiresNumber);
            int _BoosterStationNumber = (_Input.BoostedWiresNumber - 1);
            int _ServicedBoosterStationNumber = Convert.ToInt16(_BoosterStationNumber * _Input.ServicedBoosterStationPart);
            int _UnservicedBoosterStationNumber = _BoosterStationNumber - _ServicedBoosterStationNumber;

            return new Output
                (_BoosterWireLength,
                _BoosterStationNumber,
                _ServicedBoosterStationNumber,
                _UnservicedBoosterStationNumber
                );
        }
    }
}
