using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of learning Career College!");
            Console.WriteLine("Student Dayly report");
            Console.WriteLine("What is yor name?");
            string name = Console.ReadLine();
            Console.WriteLine("what course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What is the page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? please answer \"true\"or\"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp);
            Console.WriteLine("were there any positive expereince you'd like to share? please give specifics.");
            string positiveExpereinces = Console.ReadLine();
            Console.WriteLine("is there any other feedback? Please be pecific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum=Convert.ToInt32(studyHours);
            Console.WriteLine("Thanks for your Answers. An istructor will respond you soon. Hav a good day.");
            Console.ReadLine();


        }
    }

}
   
