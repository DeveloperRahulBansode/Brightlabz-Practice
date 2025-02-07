using Testing;

namespace MSUnitForTesting
{

    [TestClass]
    public  class Test1
    {
        [TestMethod]
        [DataRow(30,10,20)]
        [DataRow(40,20,20)]
        public void SumOfTwoNumber(int expected, int num1, int num2)
        {
         var programs=new BasicPrograms();

        //Arrenge
        //var a = 10;
        //    var b = 20;

            //act

            var actual=programs.addTwoNumbers(num1, num2);


            //Assert

            Assert.AreEqual(expected, actual);



        }

        [TestClass]
        public class Test2
        {
            [TestMethod]
            [DataRow(false,3)]
            [DataRow(false,1)]

            public void OddReturnFalse(bool expected,int num)
            {
                var programs=new BasicPrograms();


                //arrenge
                //int num = 3;

                //act
                
                var actual=programs.OddorEven(num);

                //assert

                Assert.AreEqual(expected, actual);





            }


        }
    }
}
