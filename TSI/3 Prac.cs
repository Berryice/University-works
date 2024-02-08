using System;
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
            sum += ((sum / 100) * 7);
            if (i == mon - 1)
            {
                Console.WriteLine($"Месяц {mon}: сумма вклада {sum}");
            }
        }
        ///Задание 2
        Console.Write("Введите Имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите Фамилию: ");
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
        int i = 0, counter = 0;
        Console.Write("Введите что-то ");
        string number = Console.ReadLine();
        do
        {
            if (char.IsNumber(number[i]))
            {
                counter += 1;
            }
            i += 1;
        } while (i < number.Length);
        Console.WriteLine($"В стоке {counter} цифр");
        //Задание 4
        Console.Write("Введите Число ");
        int fakt = Convert.ToInt32(Console.ReadLine());
        int end = 1;
        for (int i = 1; i <= fakt; ++i)
        {
            end = end * i;
        }
        Console.WriteLine($"!{fakt} = {end}");
        //Задание 5
        int n = 20, m = 10;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("\n" + i + "\t");
            for (int j = 1; j <= m; j++)
            {
                if (i > 0) Console.Write(i * j + "\t");
                else Console.Write(j + "\t");
            }
            Console.Write("\n");
        }
    }
}