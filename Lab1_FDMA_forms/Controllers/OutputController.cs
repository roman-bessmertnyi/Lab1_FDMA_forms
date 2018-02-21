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
            double[] _WireAttenuation = new double[4];
            for (int i = 0; i < _Input.BoostedWiresNumber; i++)
            {
                _WireAttenuation[i] = _Input.WireAlpha[i] * _BoosterWireLength;
            }

            return new Output
                (_BoosterWireLength,
                _BoosterStationNumber,
                _WireAttenuation
                );
        }
    }
}
