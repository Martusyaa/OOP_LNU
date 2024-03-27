namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            System.Console.WriteLine(document.requestNext());
            System.Console.WriteLine(document.requestNext());
            System.Console.WriteLine(document.requestNext());
            System.Console.WriteLine(document.requestPrevious());
        }
    }
}
