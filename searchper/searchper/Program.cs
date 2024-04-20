using System;

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо користувача про довжину сторони квадрата
        Console.Write("Введіть довжину сторони квадрата: ");
        double a = Convert.ToDouble(Console.ReadLine());

        // Обчислюємо периметр квадрата
        double perimeter = 4 * a;

        // Виводимо результат
        Console.WriteLine($"Периметр квадрата зі стороною {a} одиниць дорівнює {perimeter} одиниць.");
    }
}