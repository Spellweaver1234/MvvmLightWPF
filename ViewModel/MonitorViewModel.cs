using GalaSoft.MvvmLight;

namespace WpfMvvmLight.ViewModel
{
    public class MonitorViewModel : ViewModelBase
    {
        public MonitorViewModel()
        {

        }

        #region PROPERTIES
        private int data;
        public int Data
        {
            get { return data; }
            set { data = value; RaisePropertyChanged(); }
        }
        #endregion PROPERTIES
    }
}