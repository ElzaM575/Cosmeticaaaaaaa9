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
using CosmeticStore1.Connection;

namespace CosmeticStore1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientDialog.xaml
    /// </summary>
    public partial class ClientDialog : Page
    {
        private clients _client;
        public ClientDialog()
        {
            InitializeComponent();
            _client = client;
            DataContext = _client;
        }

        public bool DialogResult { get; private set; }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь можно добавить дополнительную логику валидации данных
            DialogResult = true;
            Close();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }
    }
}
