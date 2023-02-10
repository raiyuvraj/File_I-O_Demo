namespace FileIODemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File I/O Demo Program");

            StreamReaderAndWriter srw = new StreamReaderAndWriter();
            srw.ReadFile();

        }
    }
}