public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
       List<int> numbers = Enumerable.Range(1, max).ToList();
	    int sum = numbers.Sum();
        return sum * sum;
		// for(int i=0; i<=max; i++){
		// 	numbers.Add(i);			
		// }
          
  //       return numbers.Sum() * numbers.Sum();
    }

    public static int CalculateSumOfSquares(int max)
    {
       List<int> numbers = Enumerable.Range(1, max).ToList();
	    return numbers.Select(f => f * f).Sum();
		// for(int i=0; i<=max; i++){
		// 	numbers.Add(i*i);			
		// }
      //  return  numbers.Sum(); 
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
       return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}