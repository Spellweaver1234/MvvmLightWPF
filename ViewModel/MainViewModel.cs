using System.Threading.Tasks;
using System.Windows;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using WpfMvvmLight.Models;
using WpfMvvmLight.Views;

namespace WpfMvvmLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MonitorViewModel MonitorModel { get; set; }

        #region COMMANDS
        public RelayCommand GetTemp => new RelayCommand(ShowTemp);
        public RelayCommand OpenWindow => new RelayCommand(ShowWindow);
        #endregion COMMANDS

        public MainViewModel()
        {
            MonitorModel = new MonitorViewModel();

            Temp = new MyData() { NumberOne = 10, NumberTwo = 30, NumberThree = 60 };

            int index = 0;
            Task.Run(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    index++;
                    MonitorModel.Data = index;
                }
            });
        }

        #region PROPERTIES
        private MyData temp;
        public MyData Temp
        {
            get { return temp; }
            set { temp = value; RaisePropertyChanged(); }
        }
        #endregion PROPERTIES
        

        private void ShowTemp()
        {
            MessageBox.Show(Temp.NumberOne.ToString() + " " + Temp.NumberTwo.ToString() + " " + Temp.NumberThree.ToString());
        }

        private void ShowWindow()
        {
            MonitorWindow objMonitor = new MonitorWindow();
            objMonitor.DataContext = MonitorModel;
            objMonitor.ShowDialog();
        }
    }
}