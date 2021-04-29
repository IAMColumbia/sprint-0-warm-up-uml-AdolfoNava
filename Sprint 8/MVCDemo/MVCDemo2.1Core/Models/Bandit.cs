using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Models
{
    public class Bandit : IHuman
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Magic { get; set; }
        public int Health { get; set; }

        public Bandit()
        {
            this.Name = "Timmy";
            this.Strength = 2;
            this.Health = 20;
            this.Magic = 0;
        }
        public string About()
        {
            return $@"Name -> {Name}
stat list:
Strength: {Strength}
Magic: {Magic}
Health: {Health}";
        }

        public int Stat(int value)
        {
            return value++;
        }
    }
}
