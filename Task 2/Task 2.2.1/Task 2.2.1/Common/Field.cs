using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2._1
{
    public abstract class Field
    {
        private String name;

        private double Width;

        private double Length;

        List<Create> newCreate = new List<Create>();

        List<AbstractMonster> monsters = new List<AbstractMonster>();

        List<AbstactBonus> bonuses = new List<AbstactBonus>();

        public abstract void FieldCreate();
        

            
            
        

        public double Length1 { get => Length; set => Length = value; }
        public double Width1 { get => Width; set => Width = value; }
        public string Name { get => name; set => name = value; }
    }
}
