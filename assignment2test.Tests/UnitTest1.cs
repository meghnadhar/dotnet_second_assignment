using System;
using Fibonacci;
using Xunit;

namespace assignment2test.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            //Arrange
             MySeries FiboSeries = new MySeries();

             //Act
            var result=FiboSeries.FiboFunction(0);  
 
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(0,result);
            Assert.NotEqual(10,result);
        }
        public void Test2()
        {

            //Arrange
             MySeries FiboSeries = new MySeries();

             //Act
            var result=FiboSeries.FiboFunction(1);  
 
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(1,result);
            Assert.NotEqual(10,result);
        }
        public void Test3()
        {

            //Arrange
             MySeries FiboSeries = new MySeries();

             //Act
            var result=FiboSeries.FiboFunction(8);  
 
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(18,result);
            Assert.NotEqual(10,result);
        }
    }
}
