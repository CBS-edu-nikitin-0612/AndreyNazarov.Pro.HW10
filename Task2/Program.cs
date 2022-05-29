using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ParserFacebook parserFacebook = new ParserFacebook();
            ParserVK parserVK = new ParserVK();

            parserFacebook.Parse();
            Console.WriteLine();
            parserVK.Parse();
        }
    }
}
