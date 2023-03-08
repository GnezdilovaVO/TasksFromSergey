public static class Library
{
    public static void fillArray(int[] collection)
    {
        for(int i = 0; i < collection.Length; i++)
        {
            collection[i] = new Random().Next(-9, 9);
        }
    }
    public static int Summa(int[] coll)
    {
        int sumPoloj = 0;
        int sumOtric = 0;
        for(int j = 0; j<coll.Length; j++)
        {
            if (coll[j]>0)
            {
                sumPoloj = sumPoloj + coll[j];
            }
            else
            {
                sumOtric = sumOtric + coll[j];
            }
        }
        return sumPoloj; sumOtric;
    }
}