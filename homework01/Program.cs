int CountNumber(string s)
{
    Console.Write(s);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int Square (int N)
{
    int square = N*N;
    return square;
}
int number = CountNumber("Введите число N: ");
int result = Square(number);
Console.WriteLine(result);

