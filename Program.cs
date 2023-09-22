Console.Clear();


string[] mas = new string[]{"Hello", "2", "world", ":-)"};

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i].Length<=3)
    {
        Console.Write(mas[i]+"; ");
    }
    
}


