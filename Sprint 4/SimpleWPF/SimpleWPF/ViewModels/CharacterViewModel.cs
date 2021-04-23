using SimpleWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleWPF.ViewModels
{
    public class CharacterViewModel : StarterViewModel
    {
        Characters Character;

        public string CharName 
        {
            get { return this.Character.Name; }
            set {this.Character.Name = value; RaisePropertyChangedEvent(); }
        }
        public string CharClass
        {
            get { return this.Character.Class; }
            set { this.Character.Class = value; RaisePropertyChangedEvent(); }
        }
        public string CharRace
        {
            get { return this.Character.Race; }
            set { this.Character.Race = value; RaisePropertyChangedEvent(); }
        }
        public int CharStrength
        {
                get => this.Character.Strength;
                set { this.Character.Strength = value; RaisePropertyChangedEvent(); }       
        }
        public int CharMagic
        {
            get => this.Character.Magic;
            set { this.Character.Magic = value; RaisePropertyChangedEvent(); }
        }
        public int CharEndurance
        {
            get => this.Character.Endurance;
            set { this.Character.Endurance = value; RaisePropertyChangedEvent(); }
        }
        protected string about;
        public string CharAbout
        {
            get =>this.about =  this.Character.About();
            set { this.about = value; RaisePropertyChangedEvent(); }
        }

        public ICommand CharAddStrengthCommand { get; set; }
        public ICommand CharSubStrengthCommand { get; set; }
        public ICommand CharAddMagicCommand { get; set; }
        public ICommand CharSubMagicCommand { get; set; }
        public ICommand CharAddEnduranceCommand { get; set; }
        public ICommand CharSubEnduranceCommand { get; set; }
        public ICommand CharAboutUpdateCommand { get; set; }
        public CharacterViewModel(Characters c)
        {
            this.Character = c;
            CharAddStrengthCommand = new StarterCommand(CharViewControllerAddStrengthCommand);
            CharSubStrengthCommand = new StarterCommand(CharViewControllerSubStrengthCommand);
            CharAddMagicCommand = new StarterCommand(CharViewControllerAddMagicCommand);
            CharSubMagicCommand = new StarterCommand(CharViewControllerSubMagicCommand);
            CharAddEnduranceCommand = new StarterCommand(CharViewControllerAddEnduranceCommand);
            CharSubEnduranceCommand = new StarterCommand(CharViewControllerSubEnduranceCommand);
            CharAboutUpdateCommand = new StarterCommand(CharViewControllerAbout);
        }
        protected void CharViewControllerAbout()
        {

            RaisePropertyChangedEvent("CharAbout");
        }
    protected void CharViewControllerAddStrengthCommand()
        {
            Character.IncreaseStrength();
            RaisePropertyChangedEvent("CharStrength");
        }
        protected void CharViewControllerSubStrengthCommand()
        {
            Character.DecreaseStrength();
            RaisePropertyChangedEvent("CharStrength");
        }
        protected void CharViewControllerAddMagicCommand()
        {
            Character.IncreaseMagic();
            RaisePropertyChangedEvent("CharMagic");
        }
        protected void CharViewControllerSubMagicCommand()
        {
            Character.DecreaseMagic();
            RaisePropertyChangedEvent("CharMagic");
        }
        protected void CharViewControllerAddEnduranceCommand()
        {
            Character.IncreaseEndurance();
            RaisePropertyChangedEvent("CharEndurance");
        }
        protected void CharViewControllerSubEnduranceCommand()
        {
            Character.DecreaseEndurance();
            RaisePropertyChangedEvent("CharEndurance");
        }
    }
}
