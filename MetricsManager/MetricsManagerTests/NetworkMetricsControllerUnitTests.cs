using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{

    public class NetworkMetricsControllerUnitTests
    {

        private NetworkMetricsController Networkcontroller;

        public NetworkMetricsControllerUnitTests()
        {
            Networkcontroller = new NetworkMetricsController();
        }


        [Fact]
        public void GetMetricsFromNetwork_ReturnsOk()

        {
            //Arrange

            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(200);

            //Act
            var result = Networkcontroller.GetMetricsFromNetwork(fromTime, toTime);

            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }


}

