using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
    
    public class RamMetricsControllerUnitTests
    {

        private RamMetricsController Ramcontroller;

        public RamMetricsControllerUnitTests()
        {
            Ramcontroller = new RamMetricsController();
        }


        [Fact]
        public void GetMetricsFromNetwork_ReturnsOk()

        {
            //Arrange

            int available = 200;
            

            //Act
            var result = Ramcontroller.GetMetricsFromRam(available);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}

