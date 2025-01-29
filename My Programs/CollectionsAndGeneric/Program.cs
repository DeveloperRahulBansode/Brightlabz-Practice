namespace CollectionsAndGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericProblems.FindMax(10, 80, 30);
            GenericProblems.FindMax(10.5, 20.5, 30.5);
            GenericProblems.FindMax("rahul", "vishal", "naveen");
            GenericProblems.FindMax('a', 'b', 'c');

            GenericProblems.swapTwoNumbers(10, 20);
        }
    }
}
