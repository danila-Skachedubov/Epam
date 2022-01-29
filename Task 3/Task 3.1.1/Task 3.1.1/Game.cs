using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1
{
    class Game
    {

        public void StartGame()
        {
            Console.WriteLine("Введите количество людей в кругу");
            //Dictionary<int, object> people =            // сначала хотел реализовать словарь (Dictionary) и работать уже с ключами,
            //но после удаления каждого 2 не придумал как работать с ними
            int n = int.Parse(Console.ReadLine());


            var people = new List<object>();
            {
                for (int i = 0; i < n; i++)
                {
                    Human newHuman = new Human();
                    newHuman.Number = i + 1;
                    people.Add(newHuman.Number);
                }

            };
            foreach (var person in people)
            {
                Console.WriteLine($" Добавлен человек под номером {person}");
            }
            Console.WriteLine("Введите порядок удаления");

            int counter = 0;
            int w = int.Parse(Console.ReadLine());
            int l = w;
            while (w <= people.Count)
            {
                for (int i = counter; i <= people.Count + 1;)
                {
                    if (w >= Math.Pow(l, n) || w > people.Count) break;
                    people[w - 1] = 0;
                    w += l;
                }                                                                       /*первый фор нужен для того, чтобы элементы массива, которые мы впоследсвтии удалим , 
                                                                                         * можно было бы в этом же форе после замены на 
                                                                                         * ноль ремувать, но тогда сразу после удаления перезаписывается массив после первого же удаления.
                                                                                         По сути это не сыгралот бы большой роли, и результат был бы такой же, но у меня у людей есть номера(имена)
                                                                                         и если выводить прсото без имени, то разницы нет , а если с именем, то порядок удаления будет неверным(объяснил, наверное ужасно, вот пример) 
                                                                                                person[0] = 1
                                                                                                person[1] = 2
                                                                                                person[2] = 3
                                                                                                person[3] = 4
                                                                                                person[4] = 5
                                                                                                При ремуве в 1 форе после первого пробега удалился бы человек 2 и все игроки сместились бы на 
                                                                                                1 позицию и во втором пробеге при удаленнии person[3] удалился бы не 4, а 5 игрок
                                                                                            */
                for (int i = 0; i < people.Count; i++)
                {
                    people.Remove(0);
                }
                w = l;
                counter++;
                Console.Write($"Раунд {counter}, вычеркнуто {n - people.Count}, осталось людей: {people.Count} {Environment.NewLine}");
            }
            Console.WriteLine("Невозможно больше удалять людей");    
            Console.WriteLine($"Осталось людей {people.Count}");
            

        }
    }
       
}
