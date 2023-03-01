int result = NewMethod();
Console.WriteLine(N * N);

int NewMethod(string s)
{
    Console.WriteLine("s");
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}