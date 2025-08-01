public static class ScrabbleScore
{
    public static int Score(string input)
    {
        int score = 0;
        char[] scoreOne = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
        char[] scoreTwo = {'D', 'G' };
        char[] scoreThree = {'B', 'C', 'M', 'P'};
        char[] scoreFour = {'F', 'H', 'V', 'W','Y'};
        char[] scoreFive = {'K'};
        char[] scoreEight = {'J', 'X'};
        char[] scoreTen = {'Q', 'Z'};
        
        if (input == "")
        {
            return 0;
        }
           
        foreach(char c in input.ToUpper()){
            if (scoreOne.Contains(c)) 
            {
                score +=1;
                continue;
            }
             if (scoreTwo.Contains(c)) 
            {
                score +=2;
                continue;
            }
              if (scoreThree.Contains(c)) 
            {
                score +=3;
                continue;
            }
              if (scoreFour.Contains(c)) 
            {
                score +=4;
                continue;
            }
              if (scoreFive.Contains(c)) 
            {
                score +=5;
                continue;
            }
           if (scoreEight.Contains(c)) 
            {
                score +=8;
                continue;
            }
               if (scoreTen.Contains(c)) 
            {
                score +=10;
                continue;
            }
            
        }


        
        return score;
       // throw new NotImplementedException("You need to implement this method.");
    }
}