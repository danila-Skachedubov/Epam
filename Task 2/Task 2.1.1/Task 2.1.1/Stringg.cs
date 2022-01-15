using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._1
{
    public class My_String
    {
        //поля
        private char[] _symbols = null;
        public int length = 0;

        public char[] Symbols { get => _symbols; set => _symbols = value; }

        public My_String()
        {
            Symbols = new char[100];
        }
        public My_String(string array)
        {
           
            this.Symbols = array.ToCharArray();
        }
       
        
        public  bool Comparison (My_String a)
        {
            if(Symbols.Length == a.Symbols.Length)
            {
                for (int i = 0; i < Symbols.Length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if(Symbols[i] != a.Symbols[i])
                        Console.WriteLine("False");
                        return false;
                    }
                }
                Console.WriteLine("True");
                return true;
            }
            else
            Console.WriteLine("False");
            return false;
        }
        public char[] Concatenation(My_String a, My_String b)
        {
            var sum = a.Symbols.Concat(b.Symbols).ToArray();
            return Symbols = sum;
        }
        public bool Search(char c)
        {
            for (int i = 0; i < Symbols.Length; i++)
            {
                if(Symbols[i] == c)
                {
                    Console.WriteLine("True");
                    return true;
                }
            }
            Console.WriteLine("False");
            return false;
           
        }
        public string ConvertString()
        {
            return new string(Symbols);
        }
        public char[] ConvertChar()
        {
            
           char[] toReturn = new char[Symbols.Length];

           for (int i = 0; i < Symbols.Length; i++)
           {
                    toReturn[i] = Symbols[i];
           }
           return toReturn;           
        }
        public char[] DelitSymb(char c)
        {
            for (int i = 0; i < Symbols.Length; i++)
            {
                if(Symbols[i] == c)
                {
                    Symbols[i] = '\0';
                }  
            }
            return Symbols;
        }
        
        public char[] Inversion()
        {
            for (int i = 0; i < Symbols.Length/2; i++)
            {                char c = '\0';
                c = Symbols[i];
                Symbols[i] = Symbols[Symbols.Length - i-1];
                Symbols[Symbols.Length - i-1] = c;
            }
            Console.WriteLine(Symbols);
            return Symbols;
        }
        My_String[] strings;
        public My_String this[int index]
        {
            get => strings[index];
            set => strings[index] = value;
        }
    }  
}
