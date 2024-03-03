using System;
using System.IO;

namespace FibonacciOne
{
    public class InputRead
    {
      public string Path {get; set;} 

      public InputRead(string path)
      {
        this.Path = path;
      }

      public string ReadFromFile()
      {
        try
        {
            return File.ReadAllText(Path);
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            return null;
        }
      }
    }
}
