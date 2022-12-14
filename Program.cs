namespace Collection_Demo_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection Demo Classes");
            DemoClass objDemo = new DemoClass();
            objDemo.DictionaryDemo();
            objDemo.QueueDemo();
            objDemo.StackDemo();
            objDemo.ListDemo();
        }
    }
}