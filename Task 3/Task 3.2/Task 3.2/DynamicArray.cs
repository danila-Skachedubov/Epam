using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    class DynamicArray<T>: ICloneable, IEnumerable, IEnumerable<T>
    {
        private T[] array;

        private int capacity;

        private int length;

        private DynamicArray()
        {
            array = new T[8];
        }
        public DynamicArray(int Capacity)
        {
            array = new T[Capacity];
        }

        public int Capacity 
        { 
            get => array.Length;
            set
            {
                if (value <= Length)
                    throw new Exception("Длина меньше нуля");
                else
                {
                    T[]  newArray = new T[value];
                    Array.Copy(array, newArray, Length);
                    array = newArray;
                }
            }
        }

        public int Length { get => length; set => length = value; }

        public DynamicArray(IEnumerable<T> collection)
        {
            array = collection.ToArray();
        }

        public void Add(T something)
        {
            if (Capacity == array.Length)
            { Capacity *= 2; }
            array[Length++] = something; 
        }

        public void AddRange(IEnumerable<T> elements)
        {
            var newElements = elements.ToArray();
            if ((Length + newElements.Length) > Capacity) 
                Capacity = Length + newElements.Length; 
           
            
            Array.Copy(newElements, 0,array, length, newElements.Length);
            Length = array.Length;
            
        }
        public bool RemoveAt(int index)
        {
            if (index > Length || index < 0)
            { 
                throw new Exception("Неверный индекс");
            }
            // Array.Clear(array, index, 1);
            
            for (int i = index; i < Length; i++)
            {
                if (i == array.Length - 1)
                { break; }
                    
                
            }
            Length -= 1;
            return true;
        }
        public bool Remove(T item)
        {
            int Numb = Length;
            for (int i = 0; i < Length; i++)
                {
                if (item.Equals(array[i]))
                {
                    array[i] = array[i + 1];
                    Length--;
                }       
            }
            if(Numb == Length)//если длина осталась неизменной, то совпадений не нашлось , иначе произошли изменения
            return false;
            else
            return true;
        }
       public bool Insert(T item, int index)
        {
            if (index < 0 || index > Length)
                throw new ArgumentOutOfRangeException("Неверный индекс");
            else
            {
                array[Length - 1] = item;
               // var values = array[Length];
                for (int i = Length-1; i > 0; i--)
                {
                    
                    while (i != index)//записываем в конечное значение массива то, что хотим добавить, и начинаем с конца перестановку
                                      //вправо пока не довдем до нужнго индекса значение item
                    {
                       
                        var value = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = value;
                        break;
                    }
                    if (i == index) { Length++; return true; }
                    if (Length == Capacity) Capacity *= 2;
                }
                return false;
            }
        
        }
        
        public T this [int index]
        {
            get 
            {
                if (index > Length)
                    throw new Exception("Несуществующий индекс");
                else
                {
                    if (index < 0)//реализация обращения по отрицательному индексу
                        return array[Length + index];
                    else
                        return array[index];
                }
            }
            set
            {
                if (index < 0 || index > Length)
                    throw new Exception("Несуществующий индекс");
                else
                    array[index] = value;
            }
        }

        public void SetNewCapacity(int newCapacity)
        {
            T[] newArray = new T[newCapacity];
            if (newCapacity >= Length)
            {
                for (int i = 0; i <= length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < Capacity; i++)
                {
                    newArray[i] = array[i];
                }
            }

        }
        
        public object Clone()
        {
            return new DynamicArray<T>(array);
        }

        public  IEnumerator<T> GetEnumerator() => new ClassNumerator(array, Length);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public class ClassNumerator : IEnumerator<T>
        {
            public T[] array;

           public int length;

            public int position = -1;

            public ClassNumerator(T[] Array, int Length)
            {
                array = Array;
                length = Length;
            }

            public T Current
            {
                get
                {
                    if (position < 0 || position >= length)
                        throw new InvalidOperationException();

                    return array[position];
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public virtual bool MoveNext()
            {
                bool result = position < length - 1;

                if (result)
                    position++;

                return result;
            }

            public void Reset() => position = -1;
        }
        
    }

    
}
