using System;

namespace ExtensionMethodsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //instead of writing out Console.Writeline
            var abc = "abc";
            abc.ToUpper().ToConsole();
        }
    }
}
