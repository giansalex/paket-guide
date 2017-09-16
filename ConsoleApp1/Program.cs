using Ionic.Zip;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var zip = new ZipFile();
            zip.AddEntry("paket.txt", "hello Paket");
            zip.Save("test.zip");
        }
    }
}
