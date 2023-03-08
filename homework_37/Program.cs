using static Library;

int[] array123 = new int[12];
feelArray(array123);
Console.WriteLine(printArray(array123));
int[] array_length = new int[9];
feelArray1(array_length, 1, 9);
Console.WriteLine(printArray(array_length));
Console.WriteLine(printArray2(array123, array_length));