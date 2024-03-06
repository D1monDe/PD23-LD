using System;

class Program
{
    static void Main()
    {
        // Задача 1
        Console.WriteLine("Задача 1: Введіть три цілих числа:");
        int num1 = GetValidInput();
        int num2 = GetValidInput();
        int num3 = GetValidInput();

        Console.WriteLine("Числа, які належать інтервалу [1, 21]:");
        PrintNumbersInRange(num1);
        PrintNumbersInRange(num2);
        PrintNumbersInRange(num3);

        // Задача 2
        Console.WriteLine("\nЗадача 2: Введіть три сторони трикутника:");
        double side1 = GetValidDoubleInput();
        double side2 = GetValidDoubleInput();
        double side3 = GetValidDoubleInput();

        if (IsTriangle(side1, side2, side3))
        {
            double perimeter = CalculatePerimeter(side1, side2, side3);
            double area = CalculateArea(side1, side2, side3);
            string triangleType = DetermineTriangleType(side1, side2, side3);

            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");
            Console.WriteLine($"Тип трикутника: {triangleType}");
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }

        // Задача 3
        Console.WriteLine("\nЗадача 3: числовий масив:");
        int[] arrayX = new int[21];
        Random random = new Random();

        for (int i = 0; i < arrayX.Length; i++)
        {       
            arrayX[i] = random.Next(-50, 51);
        }

        int min = FindMinValue(arrayX);
        int max = FindMaxValue(arrayX);

        Console.WriteLine("Масив Х:");
        PrintArray(arrayX);
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");

        // Задача 4
        Console.WriteLine("\nЗадача 4: Введіть число M для фільтрації масиву Х:");
        int m = GetValidInput();

        int[] arrayY = FilterArrayByM(arrayX, m);

        Console.WriteLine($"Число M: {m}");
        Console.WriteLine("Фільтрований масив Y:");
        PrintArray(arrayY);
    }

    // Допоміжні методи:

    static int GetValidInput()
    {
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Введіть ціле число:");
        }
        return input;
    }

    static double GetValidDoubleInput()
    {
        double input;
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Введіть число:");
        }
        return input;
    }

    static void PrintNumbersInRange(int number)
    {
        if (number >= 1 && number <= 21)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(" Число не належить проміжку");
        }
    }

    static bool IsTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }

    static double CalculatePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    static double CalculateArea(double side1, double side2, double side3)
    {
        double s = (side1 + side2 + side3) / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }

    static string DetermineTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
            return "рівносторонній";
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            return "рівнобедрений";
        else
            return "різносторонній";
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static int FindMinValue(int[] array)
    {
        int min = array[0];
        foreach (var item in array)
        {
            if (item < min)
                min = item;
        }
        return min;
    }

    static int FindMaxValue(int[] array)
    {
        int max = array[0];
        foreach (var item in array)
        {
            if (item > max)
                max = item;
        }
        return max;
    }

    static int[] FilterArrayByM(int[] array, int m)
    {
        int[] newArray = new int[array.Length];
        int newIndex = 0;

        foreach (var item in array)
        {
            if (Math.Abs(item) > Math.Abs(m))
            {
                newArray[newIndex] = item;
                newIndex++;
            }
        }

        Array.Resize(ref newArray, newIndex);

        return newArray;
    }
}
