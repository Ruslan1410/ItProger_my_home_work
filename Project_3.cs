// Возведите число «1.4234» в степень 3. Округлите число к большему и выведите его на экран.



using System;

public class itProger {
    public static void Main() {
        double num = 1.4234;
        num = Math.Pow (num,3);
        int result = (int)Math.Ceiling (num);
        Console.WriteLine (result);
    }
}