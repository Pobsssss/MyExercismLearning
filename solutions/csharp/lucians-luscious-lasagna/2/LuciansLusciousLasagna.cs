class Lasagna
{
  
    public int ExpectedMinutesInOven(){
        return 40;
    }
 
    public int RemainingMinutesInOven(int inOven){
        return ExpectedMinutesInOven() - inOven;
    }
    
    public int PreparationTimeInMinutes(int layer){ 
        return layer * 2;
    }

    public int ElapsedTimeInMinutes(int layer, int inOven){       
        return PreparationTimeInMinutes(layer) + inOven;
    }
}
