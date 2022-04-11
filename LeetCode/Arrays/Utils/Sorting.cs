namespace LeetCode.Arrays.Utils
{
    public static class Sorting
    {
        public static void SelectionSort(int[] input, int fromIndex = 0)
        {
            for (var i = fromIndex; i < input.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < input.Length; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
        }

    }
}
