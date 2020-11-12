using System;

namespace DelegateApp
{
    public delegate string SpaceDel(string str);
    public delegate string ReverseDel(string str);

    class Program
    {
        static void Main(string[] args)
        {
            var strMyDel = new TestDelegate();
            SpaceDel spaceDel = strMyDel.Space;
            ReverseDel reverseDel = strMyDel.Reverse;
            Console.WriteLine(spaceDel("Pamela"));
            Console.WriteLine(reverseDel("Samuel"));
        }
    }
}
