namespace TASK3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordArray = new string[] { "Apple", "Banana", "Cherry", "Orange", "Kiwi" };

            decimal[] decimalArray = new decimal[] { 3.14m, 15.67483m, 7.618m, 0.123m, 67.4m };

            char[] charArray = new char[] { 'a', 'b', 'c', 'd', 'e' };

            bool[] boolArray = new bool[] { true, false, true, false, true };

            int[][] intArray = new int[5][];
            intArray[0] = new int[] { 20, 50 };
            intArray[1] = new int[] { 5, 67 };
            intArray[2] = new int[] { 5, 9 };
            intArray[3] = new int[] { 205, 5067 };
            intArray[4] = new int[] { 420, 60 };
        }
    }
}
