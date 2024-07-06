public static class ArrayExtensions
{
    public static void PrintArray(this int[] array)
    {
            var str = "[";
            array.ToList().ForEach(i => { str += i + ", "; });
            str = str.Substring(0, str.Length - 2);
            str += "]";
            Console.WriteLine(str);
    }
}