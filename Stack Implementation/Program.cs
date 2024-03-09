namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack init = new Stack();
            init.Push(5);
            init.Push(6);

            init.Pop();

            init.GetTop();

            init.Push(4);   
            init.Push(9);

            Console.WriteLine(init.IsEmpty());

            init.Print();

            Console.ReadKey();
       
        }
    }
}
