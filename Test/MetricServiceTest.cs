using BusinessLayer;
using MMS_Test.Controllers;
using Moq;
using FluentAssertions;
using DataLayer;
using System.Runtime.CompilerServices;
using BusinessLayer.Interface;

namespace Test
{
    public class MetricServiceTest
    {
        private readonly Mock<IConversion> _mockConversion;
        private readonly MetricsService _metricsService;

        public MetricServiceTest()
        {
            _mockConversion = new();

            _metricsService = new(_mockConversion.Object);
        }

        [InlineData(1)]
        [Theory]
        public void Valid_Test(int Id)
        {
            Metric metric = new();
            _mockConversion.Setup(x=>x.convert_to_integral(Id)).Returns(metric);
            var result = _metricsService.GetConversionDataId(Id);
            result.Should().NotBeNull();
        }

        [Fact]
        public void InValid_Test()
        {
            Metric metric = new();
            _mockConversion.Setup(x => x.convert_to_integral(It.IsAny<int>()));
            var result = _metricsService.GetConversionDataId(1);
            result.Should().BeNull();
        }
    }
}