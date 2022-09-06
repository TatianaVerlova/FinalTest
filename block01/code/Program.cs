void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
}

Console.WriteLine("Введите значения строкового массива через точку с запятой без пробела: ");
string[] input = Console.ReadLine().Split(';');
string res = "";

for(int i = 0; i < input.Length; i++)
{
    int l = input[i].Length;
    if(l <= 3)
    {
        res = res + input[i] + ";";
    }
}

string[] result = res.Split(';');
PrintArray(result);