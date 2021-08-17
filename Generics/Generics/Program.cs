using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> persons = new MyDictionary<int, string>();

            persons.Add(1, "Esra");
            persons.Add(2, "Yusuf");
            persons.Listed();
        }
    }
}
