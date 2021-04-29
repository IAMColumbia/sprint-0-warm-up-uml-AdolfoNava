using System;
using System.Collections.Generic;
using System.Text;

namespace MakeingTestFromGroundUp
{
    public abstract class People
    {

        public int Power { get; set; }

        public string Name { get; set; }

        public int Health { get; set; }

        public string AttackType { set; get; }

        public People()
        {

        }
        public string Statz()
        {
            return @$"Name: {Name}
Health: {Health}
Power: {Power}";
        }
        public int Attack()
        {
            return Power;
        }
        public int AtckLifePoints(int Atck)
        {
            Health = Health - Atck;
                return Health;
        }
        public int LifePoints()
        {
            return Health;
        }

        
    }
}
