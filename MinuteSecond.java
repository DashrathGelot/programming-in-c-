public class MinuteSecond {
    public static void main(String [] args)
    {
        String result=getDurationstring(90,56);
        String result1=getDurationstring(3700);
        System.out.println(result1);
    }
    public static String getDurationstring(long minutes,long seconds)
    {
        if(minutes>=0&&(seconds>=0&&seconds<=59))
        {

            long hour=minutes/60;
            long remainminutes=minutes%60;
            long Seco=seconds;
            String ret=hour+" H "+remainminutes+" M "+Seco+" S";
            return ret;
        }
        else
        {
            return "invalid value";
        }
    }
    public static String getDurationstring(long second)
    {
        if(second<0)
        {
            return "invalid value";
        }
        long minute=second/60;
        long remainingseconds=second%60;
        return getDurationstring(minute,remainingseconds);
    }

}
