using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір масиву N: ");
        int N = int.Parse(Console.ReadLine());

        double[] array = new double[N];
        Random random = new Random();

        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(-10, 16);
        }

        Console.WriteLine("Елементи масиву:");

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Елемент {i + 1}: {array[i]}");
        }

        double sumOfNegativesElementsOfArray = 0;

        for (int i = 0; i < N; i++)
        {
            if (array[i] < 0)
            {
                sumOfNegativesElementsOfArray += array[i];
            }
        }

        double minElementOfArray = array[0];

        for (int i = 1; i < N; i++)
        {
            if (array[i] < minElementOfArray)
            {
                minElementOfArray = array[i];
            }
        }

        double maxElement = array[0];
        int indexOfMaxElementOfArray = 0;

        for (int i = 1; i < N; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
                indexOfMaxElementOfArray = i;
            }
        }

        double maxElementOfArray = Math.Abs(array[0]);

        for (int i = 1; i < N; i++)
        {
            double maxValue = Math.Abs(array[i]);
            if (maxValue > maxElementOfArray)
            {
                maxElementOfArray = maxValue;
            }
        }

        double sumOfPositiveIndexesOfArray = 0;

        for (int i = 0; i < N; i++)
        {
            if (array[i] > 0)
            {
                sumOfPositiveIndexesOfArray += i + 1;
            }
        }

        int sumOfIntegersOfArray = 0;

        for (int i = 0; i < N; i++)
        {
            if (array[i] % 1 == 0)
            {
                sumOfIntegersOfArray++;
            }
        }

        Console.WriteLine($"Сума від'ємних елементів: {sumOfNegativesElementsOfArray}");
        Console.WriteLine($"Мінімальний елемент масиву: {minElementOfArray}");
        Console.WriteLine($"Номер (індекс) максимального елемента масиву: {indexOfMaxElementOfArray}");
        Console.WriteLine($"Максимальний за модулем елемент масиву: {maxElementOfArray}");
        Console.WriteLine($"Сума індексів додатніх елементів: {sumOfPositiveIndexesOfArray}");
        Console.WriteLine($"Кількість цілих чисел у масиві: {sumOfIntegersOfArray}");
    }
}
