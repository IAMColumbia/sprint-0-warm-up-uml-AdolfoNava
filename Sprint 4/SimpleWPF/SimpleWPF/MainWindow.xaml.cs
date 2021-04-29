using SimpleWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SimpleWPF.Model;

namespace SimpleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharacterRepo repo;
        CharactersViewModel charvm;
        public MainWindow()
        {
            repo = new CharacterRepo();
            charvm = new CharactersViewModel(repo);
            InitializeComponent();

        }

        private void UserControlCharacter_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlCharacter.DataContext = charvm.VmChar[0];
        }

        private void UserControlCharacter2_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlCharacter2.DataContext = charvm.VmChar[1];
        }

        private void UserControlCharactersList_Loaded(object sender, RoutedEventArgs e)
        {
            UserControlCharactersList.DataContext = charvm;
        }
    }
}
