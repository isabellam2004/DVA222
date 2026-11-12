namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testPrint obj = new testPrint("hej");

            obj.print();
        }
    }

    class testPrint
    {
        string st;

        public testPrint(string s)
        {
            st = s;
        }

       public void print()
        {
            Console.WriteLine(st);
        }
    }
}