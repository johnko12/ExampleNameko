using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SampleSUT.Tests
{
    [TestClass]
    public class SampleSUTTest
    {
        //we are going test the method CalculateAge()
        [TestMethod]
        public void Test_CalculateAge()
        {
            Mock<IUser> userMock = new Mock<IUser>();
            userMock.Setup(u => u.CalculateAge()).Returns(10); //matching arguments

            userMock.Setup(u => u.Name).Returns("Carlo"); //properties

            //events

            //callbacks

            //verification

            ConsumerOfIUser consumer = new ConsumerOfIUser();

            //use the mock object of IUser instead of actual object
            var result = consumer.Consume(userMock.Object);

            Assert.AreEqual(result, 20);

            //Assert.AreEqual(10, userMock.Object.CalculateAge());
        }
    }

}
