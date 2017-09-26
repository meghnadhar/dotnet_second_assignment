using System;
using Xunit;
using Arrayproblem;

namespace arraytest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           
       
            //Arrange
            Array1 arr=new Array1();
            //Act
            int len=arr.Call(20);
            //Assert
            Assert.IsType<int>(len);
            Assert.Equal(20,len);
            Assert.NotEqual(11,len);
       
        }
    }
}
