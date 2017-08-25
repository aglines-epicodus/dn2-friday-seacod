using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PafoodicSeacod.Models;
using Xunit;

namespace PafoodicSeacod.Tests
{
    public class ModelTest
    {
           {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var Subscriber = new Subscriber();
            Subscriber.Email = "1@1.1";

            //Act
            var result = Subscriber.Email;

            //Assert
            Assert.Equal("1@1.1", result);
        }
    }
}


