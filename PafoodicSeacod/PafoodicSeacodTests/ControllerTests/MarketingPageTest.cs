using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PafoodicSeacod.Models;
using Xunit;
using PafoodicSeacod.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PafoodicSeacod.Tests.ControllerTests
{
    public class MarketingControllerTest
    {
        [Fact]
        public void Get_ViewResult_Marketing()
        {
            //Arrange
            MarketingController controller = new MarketingController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);

        }
    }
}
