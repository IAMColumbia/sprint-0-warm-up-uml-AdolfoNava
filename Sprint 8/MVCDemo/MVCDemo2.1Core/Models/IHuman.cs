using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2._1Core.Models
{
    public interface IHuman
{
        string Name { get; set; }
        int Strength { get; set; }
        int Magic { get; set; }
        int Health { get; set; }
        string About();
        int Stat(int value);
        
}
}
