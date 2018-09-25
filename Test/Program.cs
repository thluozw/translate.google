using System;
using Translate;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TranslateClass translate = new TranslateClass();
            Console.WriteLine("Translate.Google.cn");
            string cn = Console.ReadLine();
            while(cn != "Q")
            {
                string str = translate.GoogleTranslate(cn, "zh-CN", "en");
                Console.WriteLine(str);
                cn = Console.ReadLine();
            }
        }
    }
}
