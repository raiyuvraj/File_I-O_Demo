using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIODemo
{
    public class StreamReaderAndWriter
    {
        private string path;
        public StreamReaderAndWriter()
        {
            path = @"D:\RFP-244\FileIO Demo\File_I-O_Demo\FileIODemo\data.txt";
        }

        public void CheckFileExist()
        {
            if (File.Exists(path))
            {
                return;
            }
        }
        public void ReadFile()
        {
            CheckFileExist();
            using (StreamReader sr = new StreamReader(path))
            {
                string data = string.Empty;
                while((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }
        }
        public void WriteFile()
        {
            CheckFileExist();
            using(StreamWriter sw = new StreamWriter(path))
            {
                string data = string.Empty;
                while((data = sw.Readline())
            }
        }


    }
}
