using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace WebDynamic
{
    class Mymethods
    {

        public Mymethods()
        {

        }

         public string MyMethod(string param1_value, string param2_value){
            string result= "<HTML><BODY> Hello " + param1_value + " et " + param2_value + "</BODY></HTML>";
            return result;
         }

        public void callMyExe(string param1_value, string param2_value)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            //You need to change this line for your own path to make it works
            start.FileName = @"C:/Users/PC-i7-Julien/Desktop/cours/SI4/deuxième semestre/soc/tds/td1/forkGitHub/eiin839/TD2/ExecGenerator/bin/Debug/netcoreapp3.1/ExecGenerator.exe"; // Specify exe name.
            start.Arguments = param1_value + " " + param2_value; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }

    }
}
