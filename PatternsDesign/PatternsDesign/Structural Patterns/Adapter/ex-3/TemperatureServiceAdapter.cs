using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsDesign.Structural_Patterns.Adapter.Ex_3
{
    class TemperatureServiceAdapter:ITemperature
    {

        private readonly TemperatureService temperatureService;

        public TemperatureServiceAdapter(TemperatureService temperatureService)
        {
            this.temperatureService = temperatureService;
        }

        public double GetTemperature()
        {
            return temperatureService.GetTempCelsius();
        }
    }
}
