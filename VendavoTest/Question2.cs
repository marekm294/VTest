namespace VendavoTest;

public static class Question2
{
    public static int Solution(int U, int[] weight)
    {
        var count = 0;
        var queue = new Queue<int>(weight);

        int first = queue.Dequeue();
        int second;
        for(var i = 1; i < weight.Length; i++)
        {
            second = queue.Dequeue();
            if (first + second > U)
            {
                count++;
                first = first > second ? second : first;
                continue;
            }

            first = second;
        }

        return count;
    }
}