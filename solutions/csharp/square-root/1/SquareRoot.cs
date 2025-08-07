public static class SquareRoot
{
    public static int Root(int number)
    {
        if(number<0)
        {
            return 0;
        }
            var search = Enumerable.Range(1, number);
			int result = 0;
			foreach(int i in search)
			{			
				result = i*i;
				
				if(result == number)
				{
					return i;
				}                
            }    
        return number;
    }
}
