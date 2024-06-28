using System.Text;

public static class MyExtensions
{
    public static string PrintArr(this int[] arr)
    {
        var rval = new StringBuilder(arr.Length);
        for(int i = 0; i < arr.Length; i++)
        {
            rval.Append(arr[i]);
            if (i < arr.Length - 1)
            {
                rval.Append(",");
            }
        }
        return rval.ToString();
    }
}