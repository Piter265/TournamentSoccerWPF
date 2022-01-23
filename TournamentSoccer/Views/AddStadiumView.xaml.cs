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
using System.Windows.Shapes;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Views
{
    /// <summary>
    /// Interaction logic for AddStadiumView.xaml
    /// </summary>
    public partial class AddStadiumView : Window
    {
        private AddStadiumViewModel _addStadiumViewModel;

        public AddStadiumView(LaunchTournamentViewModel launchTournamentViewModel)
        {
            InitializeComponent();

            _addStadiumViewModel = new AddStadiumViewModel(launchTournamentViewModel);

            DataContext = _addStadiumViewModel;
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void matchStadiumRadioBtn_Click(object sender, RoutedEventArgs e)
        {
            _addStadiumViewModel.MatchStadium = true;
        }

        private void trainingStadiumRadioBtn_Click(object sender, RoutedEventArgs e)
        {
            _addStadiumViewModel.MatchStadium = false;
        }
    }
}
