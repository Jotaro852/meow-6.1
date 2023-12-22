
using System;
using System.IO;

class work_5_1
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("numsTask1.txt"); // чтение данных из файла и запись в массив
        string[] words = lines[0].Split(' '); // разделение строки

        foreach (string i in words)
        {
            if (i.Length % 2 != 0)// если строка не чётная
            {
                Console.WriteLine(i);
            }
        }
    }
}
