namespace VendavoTest;

public static class Question1
{
    // I don't fully remember the task 1. I'm not exactly sure about possible inputs;
    public static int Solution(int[] A)
    {
        var isOneZero = false;

        for (var i = 0; i < A.Length; i++)
        {
            if(isOneZero && A[i] == 0)
            {
                return 1;
            }

            if (A[i] == 0)
            {
                isOneZero = true;
            }
        }

        return isOneZero ? 2 : A.Distinct().Count();
    }

    // possibly this - as I said I'm not sure what was the task exactly
    public static int SolutionAlt(int[] A)
    {
        var isOneZero = false;
        long total = 1;

        for (var i = 0; i < A.Length; i++)
        {
            if (A[i] != 0)
            {
                total *= A[i];
                continue;
            }

            if (isOneZero)
            {
                return 1;
            }

            isOneZero = true;
        }

        if (isOneZero)
        {
            return 2;
        }

        var hashset = new HashSet<long>();
        for (var i = 0; i < A.Length; i++)
        {
            hashset.Add(total / A[i]);
        }

        return hashset.Count;
    }
}