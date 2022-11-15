using AccessoriesIS.pages.mainWindowPages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AccessoriesIS.views
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private void PropertyChange(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public event PropertyChangedEventHandler PropertyChanged;

        public Authorization Authorization { get; private set; }
        public ObservableCollection<Page> PageCollection { get; private set; }
        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }
        public MainWindowViewModel(Authorization authorization)
        {
            Authorization = authorization;
            PageCollection = new ObservableCollection<Page>();
            PageCollection.Add(new Page1());
            if (authorization.AccountType.Id != 1)
                PageCollection.Add(new Page2());
            if (authorization.AccountType.Id == 3)
                PageCollection.Add(new Page3());
            CurrentPage = PageCollection[0];
        } 
    }
}
