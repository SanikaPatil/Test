using BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class MetricsService
    {
        private readonly IConversion _conversion;
        public MetricsService(IConversion conversion)
        {
            _conversion = conversion;
        }

        public Metric GetConversionDataId(int Id)
        {
            return _conversion.convert_to_integral(Id); 
        }
    }
}
