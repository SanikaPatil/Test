using BusinessLayer;
using BusinessLayer.Interface;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using DataLayer.DataBaseContext;
using Newtonsoft.Json.Linq;

namespace MMS_Test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly MetricsService _metricsService;

        public ConversionController(MetricsService metricsService)
        {
            _metricsService = metricsService;
        }

        [HttpGet("GetImperialData")]
        public object Get_ImperialData(int Id)
        {
            var data = _metricsService.GetConversionDataId(Id);

            data.Temperature = Math.Floor(((data.Temperature ) * 9 / 5) + 32); //Celsius(°C) TO Fahrenheit (°F)

            data.Distance = Math.Floor((data.Distance) * 6/10); //Kilometers(KM) to Miles

            data.Weight = Math.Floor((data.Weight ) * 22/10); // Kilogram(KG) to Pound

            var result = JsonConvert.SerializeObject(data);

            return result;
        }


        [HttpGet("GetMetricData")]
        public object Get_MetricData(int Id)
        {
            var data = _metricsService.GetConversionDataId(Id);

            data.Temperature = Math.Floor(((data.Temperature) * 5 / 9) - 32); //  Fahrenheit (°F) TO Celsius(°C)

            data.Distance = Math.Floor((data.Distance) * 10 / 6); // Miles To Kilometers(KM)

            data.Weight = Math.Floor((data.Weight) * 10 / 22); // Pound To Kilogram(KG)

            var result = JsonConvert.SerializeObject(data);

            return result;
        }
    }
}
