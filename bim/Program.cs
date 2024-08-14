using System;

class Program
{
    static void Main(string[] args)
    {
        int initialPosition = 100;
        int[] days = new int[30];


        Random random = new Random();
        for (int i = 0; i < days.Length; i++)
        {
            days[i] = random.Next(0, 2);
        }

        int currentPosition = initialPosition;

        for (int i = 0; i < days.Length; i++)
        {
            if (days[i] == 1)
            {
                currentPosition += 5; // Солнечный день, улитка поднимается на 5 см
            }
            else
            {
                currentPosition -= 3; // Пасмурный день, улитка опускается на 3 см
            }

            // Проверяю, чтобы улитка не поднималась выше верхушки дерева и не опускалась ниже земли
            if (currentPosition > 500)
            {
                currentPosition = 500;
            }
            else if (currentPosition < 0)
            {
                currentPosition = 0;
            }
        }

        Console.WriteLine($"Местоположение улитки к концу 30-го дня: {currentPosition} см от земли.");
    }
}