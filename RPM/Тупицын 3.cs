using System;
using System.Threading.Channels;

public class App
{
    public static void Main(String[] args)
    {
        //Задание 1
        Console.WriteLine("Введите сумму вклада");
        double sum = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите колво месецев");
        double mon = Convert.ToDouble(Console.ReadLine());
        for (int i = 0; i < mon; ++i)
        {
            sum +=((sum/100)*7);
            if (i == mon-1)
            {
                Console.WriteLine(sum);
            }
        }
        //Задание 2
        Console.WriteLine("Введите Имя");
        string name = Console.ReadLine();
        Console.WriteLine("Введите Фамилию");
        string Sname = Console.ReadLine();
        foreach (char element in name)
        {
            Console.WriteLine($"{element}");
        }
        foreach (char element in Sname)
        {
            Console.WriteLine($"{element}");
        }
        //Задание 3
        Console.WriteLine("Введие число");
        string value = Console.ReadLine();
        int h = 0;
        foreach(int j in value)
        {
            ++h;
        }
        Console.WriteLine(h);
        //Задание 4
        Console.Write("Введите Число ");
        int fakt = Convert.ToInt32(Console.ReadLine());
        int end = 1;
        for(int i = 1; i<=fakt; ++i)
        {
            end = end*i;
        }
        Console.WriteLine(end);
        //Задание 5
        for (int i = 1; i <= 9; i++)
        {
            Console.Write("\n"+i + "\t");
            for (int j = 1; j <= 9; j++)
            {
                if (i > 0) Console.Write(i * j + "\t");
                else Console.Write(j + "\t");
            }
            Console.Write("\n");
        }
    }
}