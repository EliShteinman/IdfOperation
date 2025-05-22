using System;
using IdfOperation.NameGenerator;

class Program
{
    static void Main()
    {
        var gen = new RandomName();

        // שם לזכר עם 2 שמות אמצעיים כראשי תיבות
        string name = gen.GenerateName(male: true, middleCount: 2, useInitials: true);
        Console.WriteLine("Generated name: " + name);

        Console.WriteLine("----------");

        // 5 שמות אקראיים לזכר או נקבה (לדוגמה כאן כולם זכרים)
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(gen.GenerateName(male: true, middleCount: 2));
        }
    }
}