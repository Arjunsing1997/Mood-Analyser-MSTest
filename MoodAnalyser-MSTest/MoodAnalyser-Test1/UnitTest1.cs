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

        [TestMethod]
        public void Nullmood_happy_Result()  //Method
        {
            MoodAnalyser mood = new MoodAnalyser(null); //Create object and arrange 
            string expected = "happy";

            string actual = mood.Analyzer();    //act

            Assert.AreEqual(expected, actual);  //Assert


        }

        [TestMethod]
        public void Given_Nullmood_Using_CustomExpection_Return_Null()  //Method
        {
            MoodAnalyser mood = new MoodAnalyser(null); //Create object and arrange 
            //string actual = "";
            string actual = "";

            try
            {
                actual = mood.Analyzer();    //act

            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual("Mood should not be null", exception.Message);  //Assert
            }
        }

        /* TC 3.2:- Empty Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood 
                   - Handle Empty Mood Scenario throw MoodAnalysisException and inform user of the EmptyMood
                   HINT: Use Enum to EMPTY or NULL
        */
        [TestMethod]
        public void Given_Emptymood_Using_CustomExpection_Return_Empty()  //Method
        {

            string actual = "";

            try
            {
                string message = string.Empty;
                MoodAnalyser mood = new MoodAnalyser(message); //Create object and arrange 
                actual = mood.Analyzer();    //act

            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual("Mood should not be empty", exception.Message);  //Assert
            }

        }

        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            MoodAnalyserFactor factory = new MoodAnalyserFactor();
            object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }

        /* TC 4.2:- Given Class Name When Improper Should Throw MoodAnalysisException
                    - To pass this test case pass wrong class name catch Exception and throw 
                    Exception indicating No Such Class Error.
         */
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NOClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;
                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactor factory = new MoodAnalyserFactor();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /*TC 4.3:- Given Class When Constructor Not Proper Should Throw MoodAnalysisException.
                  - To pass this Test Case pass wrong Constructor parameter, catch the Exception and throw indicating No 
                   Such Method Error. 
        */
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;
                object moodAnalyser = new MoodAnalyser(message);
                MoodAnalyserFactor factory = new MoodAnalyserFactor();
                object obj = factory.CreateMoodAnalyzerObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
