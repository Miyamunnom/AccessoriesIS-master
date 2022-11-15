using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace AccessoriesIS
{
    class CatalogBooksViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<SectionFilter> SectionFilters { get; private set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<Accessories> Accessories { get; set; }

        public void PropertyChange(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public Visibility _resetFilterActive;
        public Visibility ResetFilterActive
        {
            get => _resetFilterActive;
            private set
            {
                if (value != _resetFilterActive)
                {
                    _resetFilterActive = value;
                    PropertyChange("ResetFilterActive");
                }
            }
        }

        public CatalogBooksViewModel()
        {
            Accessories = new ObservableCollection<Accessories>();
            SectionFilters = new ObservableCollection<SectionFilter>(DataBase.GetContext().Section.Select(p => new SectionFilter() { Section = p }));
            UpdateBookList();
        }

        private int _currentCountElements = 0;
        private int _countAllElements = 0;
        public int CurrentCountElements
        {
            get => _currentCountElements;
            private set
            {
                if (_currentCountElements != value)
                {
                    _currentCountElements = value;
                    PropertyChange("CurrentCountElements");
                }
            }
        }
        public int CountAllElements
        {
            get => _countAllElements;
            private set
            {
                if (_countAllElements != value)
                {
                    _countAllElements = value;
                    PropertyChange("CountAllElements");
                }
            }
        }

        public int SelectedSort { get; set; } = 0;
        public string SearchString { get; set; } = "";
        public void UpdateBookList()
        {
            try
            {
                Accessories.Clear();
                List<Section> accessoriesFilter = SectionFilters.Where(p => p.IsChecked).Select(p => p.Section).ToList();
                List<Accessories> accessories = DataBase.GetContext().Accessories.ToList();
                CountAllElements = accessories.Count();
                //Поиск
                if (!String.IsNullOrWhiteSpace(SearchString))
                    accessories = accessories.Where(p => p.View_accessories.Contains(SearchString.Trim())).ToList();
                //Фильтрация
                if (accessoriesFilter.Count != 0)
                {
                    accessories = accessories.Where(p => p.Availability_accessories && p.Section1 != null && p.Section1.name == accessoriesFilter[0].name).ToList();
                    ResetFilterActive = Visibility.Visible;
                }

                switch (SelectedSort)
                {
                    case 0:
                        accessories = accessories.OrderBy(p => p.Price).ToList();
                        break;
                    case 1:
                        accessories = accessories.OrderByDescending(p => p.Price).ToList();
                        break;
                    case 2:
                        accessories = accessories.OrderBy(p => p.View_accessories).ToList();
                        break;
                    case 3:
                        accessories = accessories.OrderByDescending(p => p.View_accessories).ToList();
                        break;
                    default:
                        break;
                }
                CurrentCountElements = accessories.Count();

                if (accessories.Count != 0)
                {
                    foreach (Accessories accessories1 in accessories)
                        Accessories.Add(accessories1);
                }
                else MessageBox.Show("Ничего не найдено", "Результат поиска");


            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка: " + e.Message);
            }
        }



        public void ResetFilters()
        {
            ResetFilterActive = Visibility.Hidden;
            foreach (SectionFilter sectionFilter in SectionFilters)
            {
                sectionFilter.IsChecked = false;
            }
            UpdateBookList();
        }
    }
}
