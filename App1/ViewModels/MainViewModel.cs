using System;
using System.Windows.Input;
using App1.Helpers;
using App1.Services;
using App1.Views;

namespace App1.ViewModels
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
        }

        private ICommand _openSecondaryPageCommand;

        public ICommand OpenSecondaryPageCommand => _openSecondaryPageCommand ?? (_openSecondaryPageCommand = new RelayCommand(OnOpenSecondaryPage));

        private async void OnOpenSecondaryPage()
        {
            await WindowManagerService.Current.TryShowAsStandaloneAsync("Secondary_Title.Text".GetLocalized(), typeof(ChartPage));
        }
    }
}
