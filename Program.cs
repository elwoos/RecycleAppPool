using System;
using System.DirectoryServices;

namespace RecycleAppPool
{
    // modified from https://www.codeproject.com/Articles/26430/Recycling-IIS-6-0-application-pools-programmatical
    internal class Program
    {
        private const string SoaAppPool = "IIS://NLC20020.Northlincs.gov.uk/W3SVC.AppPools/eNLC 4.5";

        private static void Main(string[] args)
        {
            Console.WriteLine("Starting ...");

            try
            {
                var w3svc = new DirectoryEntry(SoaAppPool);
                w3svc.Invoke("Recycle", null);
                Console.WriteLine("Completed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.WriteLine(ex);
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();
        }
    }
}