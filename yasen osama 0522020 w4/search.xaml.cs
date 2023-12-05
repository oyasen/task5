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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        facebookEntities db = new facebookEntities();
        public search()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.users.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = db.users.Where(x=>x.city == search_t.Text).ToList();
        }
    }
}
