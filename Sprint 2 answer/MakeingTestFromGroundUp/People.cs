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


        public virtual string Statz()
        {
            string Abouts = "";

            Abouts = Name + "has " + Health + " Health, and " + Power + " strength";

            return Abouts;
        }

        public virtual int Attack()
        {
            return Power;
        }

        public virtual int AtckLifePoints(int Atck)
        {

            Health = Health - Atck;

            return Health;
        }

        public virtual int LifePoints()
        {
            return Health;
        }
    }
}
