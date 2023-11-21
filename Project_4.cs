// Создайте одномерный массив, что будет вмещать в себе следующий набор данных:

// 'J', 'a', 'v', 'a', '!'

// Выведите на экран третий элемент массива в формате: «Элемент: el», где el – значение элемента.



using System;

public class itProger {
    public static void Main() {
        char[] symbols = new char []{'j', 'a', 'v', 'a', '!'};
        Console.WriteLine ("Элемент: " + symbols [2]);
    }
}