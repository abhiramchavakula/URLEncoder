using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter project name:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                Console.WriteLine("Enter activity name:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    break;
                }
            }

            public string GetUrl()
            {
                string destinationURL = "https://companyserver.com/content/[project_name]/files/[activity_name]/[activity_name]Report.pdf";

                return "~/Finish?url=" + HttpContext.Current.Server.UrlEncode(destinationURL);
            }
            //reset url 
        }
}
