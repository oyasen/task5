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

namespace facebook
{
    /// <summary>
    /// Interaction logic for adminpage.xaml
    /// </summary>
    public partial class adminpage : Page
    {
        public adminpage()
        {
            InitializeComponent();
        }

        private void search_button(object sender, RoutedEventArgs e)
        {
            search search = new search();
            NavigationService.Navigate(search);
        }

        private void delete_button(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            NavigationService.Navigate(delete);
        }
    }
}
