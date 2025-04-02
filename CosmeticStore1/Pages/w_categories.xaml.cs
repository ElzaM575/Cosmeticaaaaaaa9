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
using System.Data.SqlClient;
using CosmeticStore1.Connection;
namespace CosmeticStore1.Pages
{
    /// <summary>
    /// Логика взаимодействия для w_categories.xaml
    /// </summary>
    public partial class w_categories : Page
    {
        private List<w_categories> categoriesList;
        public w_categories()
        {
            InitializeComponent();
            categoriesList = new List<w_categories>();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем нового клиента
            var newClient = new clients();

            // Открываем диалоговое окно для ввода данных нового клиента
            var dialog = new ClientDialog(newClient);
        }

        private void DeletButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
