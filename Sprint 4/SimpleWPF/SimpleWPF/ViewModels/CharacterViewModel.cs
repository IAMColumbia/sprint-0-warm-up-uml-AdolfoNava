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
    class CharacterViewModel : INotifyPropertyChanged
    {
        private Characters character;

        public Characters Character
        {
            get
            { return character; }
            set
            { character = value; RaisePropertyChanged("Character"); }
        }

        private ObservableCollection<Characters> characters;

        public ObservableCollection<Characters> Characters
        {
            get
            {
                return characters;
            }
            set
            {
                characters = value; RaisePropertyChanged("Characters");
            }
        }
        private void SubmitExecute(object parameter)
        {
            Characters.Add(Character);
        }
            private bool CanSubmit(object parameter)
        {
            if(string.IsNullOrEmpty(character.Name)|| string.IsNullOrEmpty(character.Class) || string.IsNullOrEmpty(character.Race))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string word)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(word));
            }
        }
        public CharacterViewModel()
        {
            Character = new Characters();
            Characters = new ObservableCollection<Characters>();
        }



    }
}
