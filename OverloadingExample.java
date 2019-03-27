public class OverloadingExample {
    public static void main(String [] args)
    {
       calc(2,9);
       calc(56);

    }
    public static double calc(double feet,double inch)
    {

        if(feet>=0||(inch>=0 && inch<=12))
        {
            double centimeter=(feet*12)*2.54;
            centimeter+=inch*2.54;
            System.out.println(feet+" feet , " +inch+" inch, ="+centimeter+" cm");
            return centimeter;
        }
        else {
            System.out.println("enter valid value");
            return -1;
        }
    }
    public static double calc(int inch)
    {
        if(inch>=0)
        {
            double feet=(int)inch/12;
            double remaininginches=(int)inch%12;
            System.out.println(inch+" inch = " +feet+" feet"+remaininginches+" remaining inches");
            return calc(feet,remaininginches);
        }
            return -1;
    }
}
