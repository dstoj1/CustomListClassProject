﻿using System;
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
        [TestMethod]
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
            Assert.IsFalse(expectedResults == results);
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
            int results = list.Count;
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]

        public void ToOverRideOperator()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>;
            CustomList<string> Two = new CustomList<string>;
            CustomList<string> Results = new CustomList<string>;
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Neymar");            
            Results = One + Two;
            //Assert
            string expectedResults = "Ibrahimovic";
            string results = Results[4];
            Assert.AreEqual(expectedResults, results);
        }
        [TestMethod]
            public void ToOverRideOperator1()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>;
            CustomList<string> Two = new CustomList<string>;
            CustomList<string> Results = new CustomList<string>;
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

        public void ToOverRideOperator2()
        {
            //Arrange
            CustomList<string> One = new CustomList<string>;
            CustomList<string> Two = new CustomList<string>;
            CustomList<string> Results = new CustomList<string>;
            //Act
            One.Add("Messi");
            One.Add("Ronaldo");
            One.Add("Beckham");

            Two.Add("Kaka");
            Two.Add("Ibrahimovic");
            Two.Add("Ronaldo");
            Results = One - Two;
            //Assert
            string expetedResults = One[1];
            string results = "Beckham";
            Assert.IsFalse()

        }
    }
}
