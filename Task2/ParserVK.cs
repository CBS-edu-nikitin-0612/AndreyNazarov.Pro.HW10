using System;

namespace Task2
{
    internal class ParserVK : Parser
    {
        protected override void GetPage()
        {
            Console.WriteLine("Get VK Page");
        }

        protected override void ParsePage()
        {
            Console.WriteLine("Parse VK Page");
        }

        protected override void FilterData()
        {
            Console.WriteLine("Filter VK data");
        }
    }
}
