public static class ScrabbleScore
{
    public static int Score(string input)
    {
      int textScore = 0;
            string scoreOne = "A,E,I,O,U,L,N,R,S,T";
            string scoreTwo = "D,G";
            string scoreThree = "B,C,M,P";
            string scoreFour = "F,H,V,W,Y";
            string scoreFive = "K";
            string scoreSix = "J,X";
            string scoreSeven = "Q,Z";
            
            for(int x=0;x<=input.Length-1;x++){
               string currentString = input.Substring(x,1).ToUpper();
                if(scoreOne.IndexOf(currentString)>=0){
                    textScore+=1;
                    continue;
                }
                if(scoreTwo.IndexOf(currentString)>=0){
                    textScore+=2;
                    continue;
                }
                  if(scoreThree.IndexOf(currentString)>=0){
                    textScore+=3;
                    continue;
                }
                  if(scoreFour.IndexOf(currentString)>=0){
                    textScore+=4;
                    continue;
                }
                  if(scoreFive.IndexOf(currentString)>=0){
                    textScore+=5;
                    continue;
                }
                  if(scoreSix.IndexOf(currentString)>=0){
                    textScore+=8;
                    continue;
                }
                  if(scoreSeven.IndexOf(currentString)>=0){
                    textScore+=10;
                    continue;
                }
            }
            return textScore;
       // throw new NotImplementedException("You need to implement this method.");
    }
}