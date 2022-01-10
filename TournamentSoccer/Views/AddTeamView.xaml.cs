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

namespace TournamentSoccer.Views
{
    /// <summary>
    /// Interaction logic for AddClubView.xaml
    /// </summary>
    public partial class AddTeamView : UserControl
    {
        public AddTeamView()
        {
            InitializeComponent();
        }

        private void playerBtn_Checked(object sender, RoutedEventArgs e)
        {
            addToTeamBtn.Content = "Add Player";
        }

        private void coachBtn_Checked(object sender, RoutedEventArgs e)
        {
            addToTeamBtn.Content = "Add Coach";
        }
    }
}