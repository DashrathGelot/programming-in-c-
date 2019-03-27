public class Forchallenge {
    public static void main(String []args)
    {
        challenge();
    }
    public static void challenge()
    {
        int sum=0;
        for(int i=0;i<=1000;i++)
        {
            if(i%3==0&&i%5==0)
            {
                sum=sum+i;
            }
        }
        System.out.println("your sum= "+sum);
    }
}
