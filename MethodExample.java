public class MethodExample {
    public static void main(String [] args)
    {
        System.out.println("this is method exrcise ");
        boolean gameplay=false;
       int scores= calculate(true,800,5,100);
       System.out.println("score is "+scores);
       int position = calculateposition(scores);
       displayhighscoreposition("dashrath",position);
         scores= calculate(true,900,1,10);
        System.out.println("score is "+scores);
        position = calculateposition(scores);
        displayhighscoreposition("dakti",position);
    }
    public static int calculate(boolean gameplay,int score,int level,int bonus)
    {
        if(gameplay)
        {
            int finalscore=score+(level*bonus);
            return finalscore;
        }
        else
        {
            return -1;
        }
    }
    public static int calculateposition(int scores)
    {
        int pos;
        if(scores>1000)
        {
            pos=1;
        }
        else if(scores>=500)
        {
            pos= 2;
        }
        else if(scores>=100)
        {
           pos=3;
        }
        else
        {
            pos= 4;
        }
        return pos;
    }
    public static void displayhighscoreposition(String playername, int position)
    {
        System.out.println("player name = "+playername+" position "+position);
    }
}
