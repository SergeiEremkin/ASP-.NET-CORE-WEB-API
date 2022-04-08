using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace MetricsManagerTests
{
   
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

        
}

