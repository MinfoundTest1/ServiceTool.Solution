using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceToolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is for service tool test.");
                // Modify second time to test review.
                Console.WriteLine("Add this line to test review.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
