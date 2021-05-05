using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_MSTest
{
    public class MoodAnalyser
    {
        public string message;  //instance variable      

        public MoodAnalyser()
        {

        }

        public MoodAnalyser(string message) //parameterized constructor for intilizing instance member
        {
            this.message = message;

        }
        public string Analyzer()  //Analyzer method find mood
        {
            try  // Handling Exception
            {
                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                else
                {
                    if (this.message.ToLower().Contains("happy"))
                    {
                        return "happy";
                    }
                    else
                    {
                        return "sad";
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }

        }
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser....");
        }
    }
}
