using SimpleWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWPF.ViewModels
{
    public class CharactersViewModel : StarterViewModel
    {
        CharacterRepo repo;

        private ObservableCollection<CharacterViewModel> vmchar;

        public ObservableCollection<CharacterViewModel> VmChar
        {
            get => this.vmchar;
            set { vmchar = value; }
        }
        public CharactersViewModel(CharacterRepo repo)
        {
            this.repo = repo;
            vmchar = new ObservableCollection<CharacterViewModel>();
            foreach (Characters d in repo.Characters)
            {
                vmchar.Add(new CharacterViewModel(d));

            }
        }
    }
}
