using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main (string[] args)
    {
        while(true)
        {
            Console.WriteLine("working (with updates)... " + DateTime.Now.ToString());
            Task.Delay(10000).Wait();
        }
    }
}
