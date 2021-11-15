using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStringManipulation
{
    public class StartUp
    {
        public StartUp(string input)
        {
            fileInputPath = input;
        }
        public string fileInputPath { get; set; }
        public string Statup()
        {
            StreamReader textWriter = new StreamReader(fileInputPath);
            var str = textWriter.ReadToEnd();
            return str;

        }
    }
}
