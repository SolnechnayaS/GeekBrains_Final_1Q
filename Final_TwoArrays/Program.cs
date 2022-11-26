Console.Clear();
Console.Write("Сколько строк с данными планируешь ввести? ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToString(Console.ReadLine());
    }
}
Console.WriteLine("Введи строки массива, разделяя их enter: ");
FillArray(array);

int TrinityArrayCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

void TrinityArray(string[] array, string[] newarray)
{
    int m = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            newarray[m] = array[i];
            m++;
        }
}

string[] newarray = new string[TrinityArrayCount(array)];
TrinityArray(array, newarray);

Console.WriteLine($"Строки, длина которых меньше или равна 3 символа:[{string.Join(", ", newarray)}]");