using System;

namespace UI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Init();
            Initiator initiator = DependencyInjector.Retrieve<Initiator>();            
            string data = initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
