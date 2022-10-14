using System;
using System.IO;

namespace LUTVisualize
{
    class Program
    {
        static void Main(string[] args)
        {
            args = new string[] {"Cintel Print to Linear.ilut" };

            foreach (string file in args)
            {
                LUTVisualize(file);
            }
        }

        static void LUTVisualize(string path)
        {

            string[] data = File.ReadAllLines(path);



        }
    }
}
