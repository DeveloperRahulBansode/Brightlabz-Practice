using Microsoft.VisualStudio.TestPlatform.TestHost;
using Testing;

namespace NUnitForTesting
{
    public class Tests
    {
        private  BasicPrograms programs;
        [SetUp]
        public void Setup()
        {
            programs=new BasicPrograms();
        }

        [Test]
        public void addTwoNumbers()
        {
            //Arrenge
            int num = 10;
           int num2 = 20;
            int expected = 30;

            //Act

            int actual=programs.addTwoNumbers(num, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void OddReturnFalse() 
        { 
            //Arrenge

            int num=3; 
            bool expected = false;

            //Act

            bool actual=programs.OddorEven(num);

            //Assert
             Assert.AreEqual(expected, actual);
        
        
        }
    }
}