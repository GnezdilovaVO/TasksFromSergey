public static class Library
{
    public static void feelArray(int[] dannye)
    {
        for(int i=0; i<dannye.Length; i++)
        {
            dannye[i] = new Random().Next(0,10);
        }

    }
    public static string printArray(int[] vyvod)
    {
        string text = String.Empty;
        for(int i=0; i<vyvod.Length; i++)
        {
            text = text + vyvod[i] + " ";
        }
        return text;
    }
    public static void feelArray1(int[] posled, int x, int y)
    {
        int reserve = x;
        for(int i=0; i<y-reserve+1; i++)
        {
            posled[i] = x;
            x=x+1;
        }
    }
    public static int printArray2(int[] massive1, int[] massive2)
    {
        int count = 0;
        for(int i=0; i<massive2.Length; i++)
        {
            for(int j=0; j<massive1.Length; j++)
            {
                if (massive2[i] == massive1[j])
                {count = count+1;
                }
            }

        }
        return count;
    }
 }