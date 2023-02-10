using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace CsvFileOperation
{
    public class ReadWriteOperationCsv
    {
        public void ReadWriteOperation()
        {
            string csvFilepath = @"D:\RFP-244\FileIO Demo\File_I-O_Demo\CSVOperation\CsvFileOperation\Address.csv";

            using (var reader = new StreamReader(csvFilepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Addresses>().ToList();
                foreach(var data in records)
                {
                    Console.WriteLine(data.firstName);
                    Console.WriteLine(","+data.lastName);
                    Console.WriteLine("," + data.email);
                    Console.WriteLine("," + data.phoneNo);
                    Console.WriteLine("," +data.Address) ;
                }
            }    
        }
    }
}
