using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.IO;

namespace Session_13___Interfaces
{
    internal class Database : IDatabase
    {
        string path = @"C:\DatabaseFile.txt";

        public void ReadFromTextFile()
        {
            if (File.Exists(path))
            {
                try
                {
                    string[] linesToRead = File.ReadAllLines(path);
                    foreach (string line in linesToRead)
                    {
                        Console.WriteLine(line);
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("I/O reading error, file empty");
                }
            }
        }


        public bool WriteToTextFile(string textToAdd)
        {
            try
            {
                if (!PathHandler())
                {
                    Console.WriteLine("File not found.");
                    return false;
                }

                File.AppendAllText(path, textToAdd + Environment.NewLine);
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine("Error writing to file: " + e.Message);
                return false;
            }
        }


        public bool EmptyFile()
        {
            if (PathHandler())
            {
                var toDelete = File.Open(path, FileMode.Truncate);

                toDelete.SetLength(0);
                return true;
            }
            return false;
        }


        public bool PathHandler()
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found in path");
                // .Exists returnere false hvis den ik finder fil
            }
            return true;
        }
    }
}

