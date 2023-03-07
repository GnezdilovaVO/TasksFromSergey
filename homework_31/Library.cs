public static class Library
{
    public static void fillArray (int[] collection)
    {
        for(int i =0; i < collection.Length; i++)
        {
            collection[i] = new Random().Next(0, 100);
        }
    }
    public static void printArray (int[] coll)
    {
        string massiv = String.Empty;
        for( int j =0; j< coll.Length; j++)
        {
            Console.Write(coll[j]+" ");
        }
    }
}