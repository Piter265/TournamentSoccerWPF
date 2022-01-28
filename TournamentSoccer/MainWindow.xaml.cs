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
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Tournament _tournament;
        public MainWindow(Tournament tournament)
        {
            InitializeComponent();

            _tournament = tournament;

            DataContext = new MainViewModel(_tournament) ;
        }


    }
}
