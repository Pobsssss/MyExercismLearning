public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3){
        return  !IsIsosceles(side1,side2,side3)
                && !IsEquilateral(side1,side2,side3) 
                && ((side1+side2) > side3) && ((side1+side3)>side2) && ((side2+side3) > side1);
    
    }
        
        // (((side1 > 0 && side2 >0 && side3>0) && 
        //         ((side1 != side2) && (side1 != side3) && (side2!=side3))       
        //      && ((side1+side2) > side3) && (side1+side3)> side2) && ((side2+side3) > side1));
                 
             
    

    public static bool IsIsosceles(double side1, double side2, double side3) => ((side1 > 0 && side2 >0 && side3>0) 
            && ((side1==side2) && ((side1 + side2) > side3))
            || ((side2==side3) && ((side2+side3)>side1))
            || ((side1==side3) &&((side1+side3) >side2)));
   

    public static bool IsEquilateral(double side1, double side2, double side3) =>  ((side1 > 0 && side2 >0 && side3>0) && (side1 == side2 ) && (side2 == side3));
}