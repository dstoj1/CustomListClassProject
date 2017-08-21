using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSoccerPlayer()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Messi");
            list.Add("Ronaldo");
            //Assert
            string expectedResult = "Messi";
            string results = list[0];
            Assert.AreEqual(expectedResult, results);
        }
        [TestMethod]
        public void AddSoccerPlayer1()
        {
            //Array
            CustomList<string> list = new CustomList<string>();
            //Act 
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            //Assert
            string expectedResult = "Beckham";
            string results = list[2];
            Assert.IsTrue(expectedResult == results);
        }
        [TestMethod]
        public void AddSoccerPlayer2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            list.Add("Kaka");
            //Assert
            int expectedResults = 4;
            int results = list.count;
            Assert.AreEqual(expectedResults, results);
        }

        /*    [TestMethod]
             [ExpectedException(typeof(ArgumentException))]
             public void AddSoccerPlayer_ExceptionThrown()
             {
                 //Arrange
                 CustomList<string> list = new CustomList<string>();
                 //Act
                 list.Add("Messi");
                 list.Add("Ronaldo");
                 list.Add("Beckham");
                 list.Add("Kaka");

                 list.Add(1);
             }
     */
        [TestMethod]
        public void RemoveSoccerPlayer()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");

            list.Remove("Ronaldo");
            //Assert
            string expectedResults = "Beckham";
            string results = list[1];
            Assert.IsTrue(expectedResults == results);
        }
        [TestMethod]
        public void RemoveSoccerPlayer1()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");

            list.Remove("Beckham");
            list.Remove("Ibrahimovic");
            //Assert
            string expectedResults = "Kaka";
            string results = list[2];
            Assert.IsTrue(expectedResults == results);
        }
        [TestMethod]
        public void RemoveSoccerPlayer2()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Messi");
            list.Add("Ronaldo");
            list.Add("Beckham");
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");

            list.Remove("Messi");
            list.Remove("Kaka");
            list.Remove("Neymar");
            //Assert
            int expectedResults = 3;
            int results = list.count;
            Assert.AreEqual(expectedResults, results);
        }
    }
}
  /*      [TestMethod]
        public void ConvertToString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");
            //Assert
            string expectedResults = "KakaIbrahimovicNeymar";
            string results = list.ToString();
            Assert.AreEqual(expectedResults, results);          
        }
        [TestMethod]
        public void RemoveIbrahimovicToString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");

            list.Remove("Ibrahimovic");
            //Assert
            string expectedResults = "KakaNeymar";
            string results = list.ToString();
            Assert.IsTrue(expectedResults == results);
        }
        [TestMethod]
        public void RemoveIbrahimovicAddRonaldoToString()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            //Act
            list.Add("Kaka");
            list.Add("Ibrahimovic");
            list.Add("Neymar");

            list.Remove("Ibrahimovic");

            list.Add("Ronaldo");
            //Assert
            string expectedResults = "KakaNeymarRonaldo";
            string results = list.ToString();
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]
        public void ToOverLoadPlusOperator()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Neymar");
            Results =  One + Two;
            //Assert
            string expectedResults = "Ibrahimovic";
            string results = Results[4];
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]
        public void ToOverLoadPlusOperator1()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");
            One.Add("Pique");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Neymar");
            Results = One + Two;
            //Assert
            string expectedResults = "Pique";
            string results = One[3];
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]
        public void ToOverLoadPlusOperator2()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");
            One.Add("Pique");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Neymar");
            Two.Add("Suarez");
            Results = One + Two
            //Assert
            string expectedResults = Results[7];
            string results = "Suarez";
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]
        public void ToOverLoadMinusOperator()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Ronaldo");
            Results = One - Two;
            //Assert
            string expectedResults = "Messi";
            string results = Results[0];
            Assert.IsTrue(expectedResults == results);
        }
        [TestMethod]
        public void ToOverLoadMinusOperatorWithRonaldoBeingInBothLists()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Ronaldo");
            Results = One - Two;
            //Assert
            string expetedResults = "Beckham";
            string results = Results[1];
            Assert.IsTrue(expetedResults == results);
        }
        [TestMethod]
        public void ToOverLoadMinusOperatorRemoveIbrahimovic()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>();
            CustomList<string> Two = new CustomList<string>();
            CustomList<string> Results = new CustomList<string>();
            //Act
            One.Add("Ibrahimovic");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Neymar");
            Results = Two - One;
            //Assert
            string expetedResults = "Neymar";
            string results = Results[1];
            Assert.IsTrue(expetedResults == results);
        }
        [TestMethod]
        public void ZipCustomListOneWithCustomListTwo()
        {
                //Arrange
                CustomList<string> One = new CustomList<string>();
                CustomList<string> Two = new CustomList<string>();
                CustomList<string> Results;
                //Act
                One.Add("Lionel");
                One.Add("Christiano");
                One.Add("David");
                One.Add("Gerard");
                One.Add("Ricardo");
                One.Add("Zlatan");
                One.Add("Santos");
                One.Add("Luis");

                Two.Add("Messi");
                Two.Add("Ronaldo");
                Two.Add("Beckham");
                Two.Add("Pique");
                Two.Add("Kaka");
                Two.Add("Ibrahimovic");
                Two.Add("Neymar");
                Two.Add("Suarez");
                Results = One.Zip(Two);
                //Assert
                string expetedResults = "Lionel";
                string results = Results[0];
                Assert.IsTrue(expetedResults == results);
        }
        [TestMethod]
        public void ZipCustomListOneWithCustomListTwo_Count()
        {
                //Arrange
                CustomList<string> One = new CustomList<string>();
                CustomList<string> Two = new CustomList<string>();
                CustomList<string> Results;
                //Act                
                One.Add("Lionel");
                One.Add("Christiano");
                One.Add("David");
                One.Add("Gerard");
                One.Add("Ricardo");
                One.Add("Zlatan");
                One.Add("Santos");
                One.Add("Luis");

                Two.Add("Messi");
                Two.Add("Ronaldo");
                Two.Add("Beckham");
                Two.Add("Pique");
                Two.Add("Kaka");
                Two.Add("Ibrahimovic");
                Two.Add("Neymar");
                Two.Add("Suarez");
                Results = One.Zip(Two);
                //Assert
                int expetedResults = 14;
                int results = Results.count;
                Assert.AreEqual(expetedResults, results);
            }
        }
        [TestMethod]
        public void ZipCustomListOneWithCustomListTwoRemoveChristianoRonaldo()
        {
                //Arrange
                CustomList<string> One = new CustomList<string>();
                CustomList<string> Two = new CustomList<string>();
                CustomList<string> Results;
                //Act
                One.Add("Lionel");
                One.Add("Christiano");
                One.Add("David");
                One.Add("Gerard");
                One.Add("Ricardo");
                One.Add("Zlatan");
                One.Add("Santos");
                One.Add("Luis");

                Two.Add("Messi");
                Two.Add("Ronaldo");
                Two.Add("Beckham");
                Two.Add("Pique");
                Two.Add("Kaka");
                Two.Add("Ibrahimovic");
                Two.Add("Neymar");
                Two.Add("Suarez");
                Results = One.Zip(Two);
                //Assert
                string expetedResults = "Ronaldo";
                string results = Results[3];
                Assert.AreEqual(expetedResults, results);
            }
            */

