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

void TrinityArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine(array[i]);
        }
    }
}

Console.WriteLine("Строки, длина которых меньше либо равна 3 символa:");
TrinityArray(array);