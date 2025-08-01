static class SavingsAccount
{

    
    public static float InterestRate(decimal balance)
    {   
        if(balance < 0.0m)
        {
            return 3.213f;
        }
        
        if(balance < 1000.0m)
        {
            return 0.5f;    
        }
        
        if(balance >= 1000.0m && balance < 5000.0m)
        {
            return 1.621f; 
        }
    
            return 2.475f;
               
      
    }

    public static decimal Interest(decimal balance)
    {
       return ((decimal)InterestRate(balance) *(decimal)balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {

        return Interest(balance) + balance;
      //  throw new NotImplementedException("Please implement the (static) SavingsAccount.AnnualBalanceUpdate() method");
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;
      
        while(balance < targetBalance){
        balance += Interest(balance);
            year++;
        }
        return year;
        //throw new NotImplementedException("Please implement the (static) SavingsAccount.YearsBeforeDesiredBalance() method");
    }
}
