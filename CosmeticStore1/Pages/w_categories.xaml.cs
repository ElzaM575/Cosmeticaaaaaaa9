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
        }
        
    }
}
