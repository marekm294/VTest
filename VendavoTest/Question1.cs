namespace VendavoTest;

public static class Question1
{
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
}