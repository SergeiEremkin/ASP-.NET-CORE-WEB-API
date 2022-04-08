using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
   
    public class DotNetMetricsControllerUnitTests
    {
        private DotNetMetricsController DotNetcontroller;

        public DotNetMetricsControllerUnitTests()
        {
            DotNetcontroller = new DotNetMetricsController();
        }

        [Fact]
        public void GetMetricsFromDotNet_ReturnsOk()

        {
            //Arrange

            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = DotNetcontroller.GetMetricsFromDotNet(fromTime,
            toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }

        
}

