using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgSaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string logPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\args.txt";
            using (StreamWriter writer = new StreamWriter(logPath))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    writer.WriteLine($"Arg[{i}] = [{args[i]}]");
                }
                writer.Close();
            }
        }
    }
}
