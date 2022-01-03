using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private string propertyName;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
