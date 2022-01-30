using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2
{
    class TextAnalizator
    {
        public string Text { set; get; }
        public string[] Wordss { get; private set; } // для разбиения текста на слова

        private List<string> Words = new List<string>();//для всех слов без пробелов

        private Dictionary<string, int> WordFrequency = new Dictionary<string, int>();//для списка слов и их количесвта в тексте
        
 
    public TextAnalizator(String text)
        {
            Text = text;
        }
        public void TextSeparation()
        {
            Text.ToLower().Trim();
            Wordss = Text.Split(' ', '!', '"', ';', ':', ',', '.', '?', '(', ')', '-');
            if(Wordss.Length < 1)
                Console.WriteLine("Введите текст заново");            
            Words.AddRange(Wordss);

            for (int i = 0; i < Words.Count; i++)          
            {
                if (Words[i] == "") Words.Remove(Words[i]); //ручной аналог  Split(delimeters, StringSplitOptions.RemoveEmptyEntries), вспомнил про это уже после того, как все записал в лист,
                                                            //в некст раз сделай правильно
            }
            int counter = 0;
            for (int i = 0; i < Words.Count; i++)
            {
                foreach (var item in Words)
                {
                    if (Words[i] == item) counter++;//сравниваем слова и считаем их количесвто                  
                }
                // Console.WriteLine($"Слово <{Words[i]}> встретилось {counter} раз");
                for (int j = -1; j < WordFrequency.Count; j++)
                {
                    if (!WordFrequency.ContainsKey(Words[i]))//проверка для того , что бы когда фор встретит сторой раз слово со значением его количества, больше его не записывал
                        WordFrequency.Add(Words[i], counter);
                }
                counter = 0;
            }
        }

 
        public void FindWord()
        {    
            foreach (var person in WordFrequency)
            {
                Console.WriteLine($"Слово: <{person.Key}>  встретилось <{person.Value}> раз");
            }            
        }

        public void UniqueWords()
        {
            Console.WriteLine(WordFrequency.OrderByDescending(z => z.Value).ToDictionary(a => a, s => s).Last().Value);
        }

        public void PopularWord()
        {
            Console.WriteLine("Наиболее употребляемое слово: {0}", WordFrequency.OrderByDescending(z => z.Value).ToDictionary(a => a, s => s).First().Value);
        }

        public void PrintWordFrequencyFromAllWords()
        {
            var sortedDictionary = WordFrequency.OrderByDescending(pair => pair.Value);

            foreach (var pair in sortedDictionary)
            {
                double wordFrequency = (double)pair.Value / Words.Count * 100;
                Console.WriteLine("Частота встречаемости слова в тексте:");
                Console.WriteLine($"[{pair.Key}] : {wordFrequency: 0.00}%");
            }
        }
    }
}
