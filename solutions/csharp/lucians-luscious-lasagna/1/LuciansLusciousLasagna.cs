class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven(){
        return 40;
    }

    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int inOven){
        return ExpectedMinutesInOven() - inOven;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layer){ 
        return layer * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layer, int inOven){       
        return PreparationTimeInMinutes(layer) + inOven;
    }
}
