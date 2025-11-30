public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum  = 0;
        for ( int i = 0; i<= max; i++)
        {
            sum = sum + i;
        }
        return sum * sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int square = 0;
        for ( int i = 0; i<= max; i++)
        {
            square += i*i;
        }
        return square;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int diff =  (CalculateSquareOfSum(max) -  CalculateSumOfSquares(max));
        return diff;
        throw new NotImplementedException("You need to implement this method.");
    }
}