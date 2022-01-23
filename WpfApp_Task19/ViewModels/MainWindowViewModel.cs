using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp_Task19.Models;

namespace WpfApp_Task19.ViewModels
{
    class MainWindowViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                radius = value;
                OnPropertyChanged();
            }
        }
        private double circumference;
        public double Circumference
        {
            get => circumference;
            set
            {
                circumference = value;
                OnPropertyChanged();
            }
        }

        public ICommand GetCircumferenceByRadiusCommand { get; }
        private void OnGetCircumferenceByRadiusCommandExecute(object p)
        {
            Circumference = GeomCalc.CircumferenceByRadius(Radius);
        }
        private bool CanGetCircumferenceByRadiusCommandExecuted(object p)
        {
            if (Radius != 0)
                return true;
            else
                return false;
        }
        public MainWindowViewModel()
        {
            GetCircumferenceByRadiusCommand = new RelayCommand(OnGetCircumferenceByRadiusCommandExecute, CanGetCircumferenceByRadiusCommandExecuted);
        }
    }
}
