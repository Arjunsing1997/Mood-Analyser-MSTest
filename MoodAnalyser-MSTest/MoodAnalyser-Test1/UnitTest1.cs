using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyser_MSTest;

namespace MoodAnalyser_Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyser_Happy()
        {
            //Arraneg
            string expected = "happy";
            MoodAnalyser mood = new MoodAnalyser("I am in happy Mood");
            //Act
            string actual = mood.Analyzer();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MoodAnalyser_Sad()  //Method
        {
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood"); //Create object and arrange 
            string expected = "sad";

            string actual = mood.Analyzer();    //act
            Assert.AreEqual(expected, actual);  //Assert
        }
    }
}
