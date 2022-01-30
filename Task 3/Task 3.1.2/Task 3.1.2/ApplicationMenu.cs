using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class ApplicationMenu
    {
        public string Text { set; get; }

        public ApplicationMenu(string text)
        {
            Text = text;
        }
        public void Start()
        {   
            int input = 0;
            TextAnalizator newTextAnalizator = new TextAnalizator(Text);
            do
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 Ввести текст" + Environment.NewLine +
                    "2 Вывести список слов и их количество в тексте" + Environment.NewLine +
                    "3 Вывести самое часто встречаемое слово" + Environment.NewLine +
                    "4 Вывести самое редкое слово" + Environment.NewLine +
                    "5 Вывести процентное соотношение встречаемости слова в тексте" + Environment.NewLine +
                    "0 Выйти" + Environment.NewLine );
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        break;
                    case 1:
                        if (Text.Length < 2) 
                        { 
                        Console.WriteLine("Текст пустой");
                        break; 
                        }
                        newTextAnalizator.TextSeparation();
                        break;
                    case 2:
                        newTextAnalizator.FindWord();
                        break;
                    case 3:
                        newTextAnalizator.PopularWord();
                        break;
                    case 4:
                        newTextAnalizator.UniqueWords();
                        break;
                    case 5:
                        newTextAnalizator.PrintWordFrequencyFromAllWords();
                        break;
                }
            } while (input!=0);
        }
    }
    
}
