using ConsoleApp.Services;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new CsvServices();
            reader.ImportData(@"C:\Users\Test\Desktop\Projekty\RecrutTest\ConsoleApp\ConsoleApp\data.csv");
        }
    }
}
