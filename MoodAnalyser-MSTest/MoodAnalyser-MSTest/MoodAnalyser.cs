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


        public MoodAnalyser(string message) //parameterized constructor for intilizing instance member
        {
            this.message = message;

        }
        public string Analyzer()  //Analyzer method find mood
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
    static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser....");
        }
    }
}
