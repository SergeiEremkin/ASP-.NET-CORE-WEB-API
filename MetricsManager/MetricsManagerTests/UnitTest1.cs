using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
    public class CpuMetricsControllerUnitTests
    {
        private CpuMetricsController controller;
       
        public CpuMetricsControllerUnitTests()
        {
            controller = new CpuMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            //Arrange
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            //Act
            var result = controller.GetMetricsFromAgent(agentId, fromTime,
            toTime);
            // Assert
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

        
    }

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

        public class HddMetricsControllerUnitTests
        {

            private HddMetricsController Hddcontroller;

            public HddMetricsControllerUnitTests()
            {
                Hddcontroller = new HddMetricsController();
            }


            [Fact]
            public void GetMetricsFromHDD_ReturnsOk()

            {
                //Arrange

                int left = 50;

                //Act
                var result = Hddcontroller.GetMetricsFromHDD(left);

                // Assert
                _ = Assert.IsAssignableFrom<IActionResult>(result);
            }
        }

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

