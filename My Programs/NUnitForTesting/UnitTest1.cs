using System.Globalization;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Testing;

namespace NUnitForTesting
{
    public class Tests
    {
        private  BasicPrograms programs;
        private  Calculator program;

        [SetUp]
        public void Setup()
        {
            programs=new BasicPrograms();
            program=new Calculator();
        }

        //[Test]
        //public void addTwoNumbers()
        //{
        //    //Arrenge
        //    int num = 10;
        //   int num2 = 20;
        //    int expected = 30;

        //    //Act

        //    int actual=programs.addTwoNumbers(num, num2);

        //    //Assert
        //    Assert.AreEqual(expected, actual);

        //}

        //[Test]
        //public void OddReturnFalse() 
        //{ 
        //    //Arrenge

        //    int num=3; 
        //    bool expected = false;

        //    //Act

        //    bool actual=programs.OddorEven(num);

        //    //Assert
        //     Assert.AreEqual(expected, actual);
        
        
        //}
        [Test]
        public void Addition()
        {
            int a = 10;
            int b=20;

            int actual=program.Addition(a, b);

            Assert.AreEqual(30, actual); 

        }
        [Test]
        public void Subtraction()
        {
            int a = 20;
            int b = 10;

            int actual = program.Subtraction(a, b);

            Assert.AreEqual(10, actual);
        }

        [Test]
        public void Multiplication()
        {
            int a = 10;
            int b = 20;

            int actual = program.Multiplication(a, b);

            Assert.AreEqual(200, actual);
        }
        [Test]
        public void Division()
        {
            int a = 20;
            int b = 10;

            int actual = program.Division(a, b);

            Assert.AreEqual(2, actual);
        }

        [Test]
        public void CheckpalindromeTrueIfMAM()
        {
            string str = "MAM";

            bool actual = program.Checkstringpalindrome(str);

            Assert.AreEqual(true, actual);
        }
        [Test]
        public void CheckpalindromeFalseIfHello()
        {
            string str = "hello";

            bool actual = program.Checkstringpalindrome(str);

            Assert.AreEqual(false, actual);
        }

    }
}