public static class IntArrayExtensions
{
    public static double Average(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new Exception("Array is null or empty.");
        }

        double sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }

        return sum / array.Length;
    }
}
