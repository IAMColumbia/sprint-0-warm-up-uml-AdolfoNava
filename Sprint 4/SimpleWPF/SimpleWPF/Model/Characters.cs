using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWPF.Model
{
    class Characters : INotifyPropertyChanged
    {
        protected string name;
        protected string classs;
        protected string race;

        public string Name { 
            get { 
                return name; 
            } set { 
                if (Name != value)
                {
                    name = value;
                    RaisePropertyChanged(Name);
                }
            } }
        public string Class
        {
            get
            {
                return classs;
            }
            set
            {
                if (Class != value)
                {
                    classs = value;
                    RaisePropertyChanged(Class);
                }
            }
        }
        public string Race
        {
            get
            {
                return race;
            }
            set
            {
                if (Race != value)
                {
                    race = value;
                    RaisePropertyChanged(Race);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    
        private void RaisePropertyChanged(string word)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(word));
            }
        }

    }
}
