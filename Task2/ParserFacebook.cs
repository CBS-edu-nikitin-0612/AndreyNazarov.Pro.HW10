using System;

namespace Task2
{
    internal class ParserFacebook : Parser
    {
        protected override void GetPage()
        {
            Console.WriteLine("Get Facebook Page");
        }

        protected override void ParsePage()
        {
            Console.WriteLine("Parse Facebook Page");
        }
    }
}
