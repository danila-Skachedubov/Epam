using System;

namespace Task_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = "Privet";
            string arr2 = "Hello";
            char c = 'v';
            string arr3 = string.Empty;
           
            My_String str = new My_String(arr);
            My_String str2 = new My_String(arr2);
            My_String str3 = new My_String(arr3);

            Console.WriteLine("Сравнение строки arr & arr2");
            str.Comparison(str2);//реализация cравнения строк
            Console.Write(Environment.NewLine);

            Console.WriteLine("Конкатинация строк arr & arr2");
            str3.Concatenation(str, str2);//реазизация конкатинации
            Console.WriteLine(str3.Symbols);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Поиск символа 'v' в строке arr" );
            str.Search(c);//реализация поиска символа
            Console.Write(Environment.NewLine);

            Console.WriteLine("Конвертацаия строки");
            str.ConvertString();
            str.ConvertChar();
            Console.WriteLine(str.Symbols.GetType());//нреализация приведения из/к
            Console.Write(Environment.NewLine);

            Console.WriteLine("Удаление символа 'v' в строке  arr");
            str.DelitSymb(c);//реализация удаления символа 
            Console.WriteLine(str.Symbols);
            Console.Write(Environment.NewLine);

            Console.WriteLine("Инверсия строки arr");
            str.Inversion();//реализация инверсии строки
            Console.Write(Environment.NewLine);

            Console.WriteLine("0-ой объект в индексаторе");
            My_String[] strings;
            var text = new[] { new My_String("mama"), new My_String("papa"), new My_String("mama"), new My_String("mama") };
            My_String firstword = text[0];
            Console.WriteLine(firstword.Symbols);//реализация индексатора
        }
    }
}
