using System;

namespace Task_3._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Метод String.Split создает массив подстрок, разбивая" +
                " входную строку по одному или нескольким разделителям. Этот метод зачастую является самым" +
                " простым способом разделить строку по границам слов. Он также используется для разбиения строк по другим конкретным символам или строкам.";
            //string text = "";
            ApplicationMenu newMenu = new ApplicationMenu(text);
            newMenu.Start();
        }
    }
}
