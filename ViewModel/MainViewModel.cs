using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_UI_Testing.Core;

namespace WPF_UI_Testing.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private object _currentView;
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand LearningViewCommand { get; set; }
        public RelayCommand ServicesViewCommand { get; set; }
        public RelayCommand DownloadsViewCommand { get; set; }
        public RelayCommand SupportViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public LearningViewModel LearningVM { get; set; }
        public ServicesViewModel ServicesVM { get; set; }
        public DownloadsViewModel DownloadsVM { get; set; }
        public SupportViewModel SupportVM { get; set; }
        public object CurrentView { get { return _currentView; }
            set
            {
                if (_currentView != value)
                {
                    _currentView = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            LearningVM = new LearningViewModel();
            ServicesVM = new ServicesViewModel();
            DownloadsVM = new DownloadsViewModel();
            SupportVM = new SupportViewModel();

            _currentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            LearningViewCommand = new RelayCommand(o =>
            {
                CurrentView = LearningVM;
            });

            ServicesViewCommand = new RelayCommand(o =>
            {
                CurrentView = ServicesVM;
            });

            DownloadsViewCommand = new RelayCommand(o =>
            {
                CurrentView = DownloadsVM;
            });

            SupportViewCommand = new RelayCommand(o =>
            {
                CurrentView = SupportVM;
            });
        }
    }
}
