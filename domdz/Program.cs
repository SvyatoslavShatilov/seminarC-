/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 7 == 0 && number % 23 == 0)
        {
            Console.WriteLine("Число кратно и 7, и 23");
        }
        else
        {
            Console.WriteLine("Число не кратно одновременно 7 и 23");
        }
    }
}*/

/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координату X:");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Введите координату Y:");
        double y = Convert.ToDouble(Console.ReadLine());
        
        if (x > 0 && y > 0)
        {
            Console.WriteLine("Точка находится в первой четверти");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Точка находится во второй четверти");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Точка находится в третьей четверти");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Точка находится в четвёртой четверти");
        }
    }
}*/
/*using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое число от 10 до 99:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number < 10 || number > 99)
        {
            Console.WriteLine("Число не входит в указанный диапазон");
            return;
        }
        
        int firstDigit = number / 10;
        int secondDigit = number % 10;
        
        if (firstDigit > secondDigit)
        {
            Console.WriteLine("Наибольшая цифра числа: " + firstDigit);
        }
        else
        {
            Console.WriteLine("Наибольшая цифра числа: " + secondDigit);
        }
    }
}*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число N:");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("Число должно быть натуральным");
            return;
        }

        string numStr = N.ToString();
        for (int i = 0; i < numStr.Length; i++)
        {
            Console.Write(numStr[i]);
            if (i < numStr.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
}
