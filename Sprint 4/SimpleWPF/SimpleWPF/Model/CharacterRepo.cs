using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWPF.Model
{
    public class CharacterRepo
    {
        List<Characters> characters;

        public List<Characters> Characters
        {
            get => this.characters;
            set { this.characters = value; }
        }
        public CharacterRepo()
        {
            this.characters = new List<Characters>();
            characters = new List<Characters>() { 
            new Characters(),
            new Characters() { Name = "bobby", Class = "Mage", Race = "Druid", Strength = 2, Magic = 9, Endurance = 5 }
            };
        }
    }

}
