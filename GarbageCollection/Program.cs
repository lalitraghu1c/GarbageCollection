using System;
namespace GarbageCollection
{
    class Program
    {
        public static void Main(string[] args)
        {
            long num1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[5000]; //ALLOCATE AN ARRAY AND MAKE IT UNREACHABLE
                values = null;
            }
            long num2 = GC.GetTotalMemory(false);
            {
                GC.Collect(); //COLLECT GARBAGE
            }
            long num3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }
            Console.WriteLine("########## Lalit ##########");
            long byte1 = GC.GetTotalMemory(false); //GET MEMORY IN BYTE
            byte[] memory = new byte[1000 + 1000 + 10]; //TEN MILLION BYTE
            memory[0] = 1; //SET MEMORY (prevent allocation from being optimised out)
            long byte2 = GC.GetTotalMemory(false); //GET MEMORY
            long byte3 = GC.GetTotalMemory(true); //GET MEMORY
            Console.WriteLine(byte1);
            Console.WriteLine(byte2);
            Console.WriteLine(byte2-byte1);//Wtite Difference
            Console.WriteLine(byte3);
            Console.WriteLine(byte3-byte2);//Write Difference
            Console.ReadLine();
        }
    }
}