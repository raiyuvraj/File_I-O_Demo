namespace CsvFileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read CSV File Data");
            ReadWriteOperationCsv readwritecsv = new ReadWriteOperationCsv();
            readwritecsv.ReadWriteOperation();
        }
    }
}