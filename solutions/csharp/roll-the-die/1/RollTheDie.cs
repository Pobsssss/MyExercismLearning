using System;
public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        int roll = rand.Next(1, 18);
        return roll;    
       
        // throw new NotImplementedException("Please implement the Player.RollDie() method");
    }

    public double GenerateSpellStrength()
    {
        Random rand = new Random();
        double strenght  = rand.NextDouble() * 100;
        return strenght;
       // throw new NotImplementedException("Please implement the Player.GenerateSpellStrength() method");
    }
}
