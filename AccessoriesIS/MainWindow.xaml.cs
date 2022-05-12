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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AccessoriesIS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_auth_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(loginTextBox.Text))
            {
                if (!string.IsNullOrEmpty(passwordTextBox.Password))
                {
                    IQueryable<Authorization> autorizstion_list = DataBase.GetContext().Authorization.Where(p => p.Login == loginTextBox.Text && p.Password == passwordTextBox.Password);
                    if (autorizstion_list.Count() == 1)
                        MessageBox.Show("Добро пожаловать.");
                    else MessageBox.Show("Неверный логин или пароль.");

                }
            }
        }
    }
}
