using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;
using TournamentSoccer.Views;

namespace TournamentSoccer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Tournament _tournament;

        public App()
        {
            _tournament = Tournament.GetInstance();
        }

        protected override void OnStartup(StartupEventArgs e)
        {

        }

        /* protected override void RegisterTypes(IContainerRegistry containerRegistry)
         {
             containerRegistry.Register<IView, AddTeamView>();
         }*/
    }
}