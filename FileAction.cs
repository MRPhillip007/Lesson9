using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHw
{
    class FileAction
    {
        static string _path = "";
        public static string[] Data { get => ReadFile(); }
        public FileAction(string path)
        {
            _path = path;
        }
        static string[] ReadFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_path))
                {
                    string[] content = reader.ReadToEnd().Split(new char[] {'\n'}).OrderBy(x=> x).ToArray();
                    return content;
                }
            }
            
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Error while read file: {ex.Message}");
            }

            return new string[0];
        }

        public static void WriteToFile(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_path, true))
                {
                    writer.WriteLine(data);
                    Console.WriteLine("[+] All data was written successfully! ");
                }
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Error {ex.Message} + {ex.FileName}");
            }
            catch(FileLoadException ex)
            {
                Console.WriteLine($"Error: {ex.Message} + {ex.FileName}");
            }
        }
    }
}
