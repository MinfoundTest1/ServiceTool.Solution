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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
