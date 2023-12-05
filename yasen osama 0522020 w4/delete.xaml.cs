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
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        facebookEntities db = new facebookEntities();
        public delete()
        {
            InitializeComponent();
            datagrid.ItemsSource = db.users.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                user user = db.users.First(x => x.phone_number == search_t.Text);
                db.users.Remove(user);
                db.SaveChanges();
                datagrid.ItemsSource = db.users.ToList();

            }
            catch
            {
                MessageBox.Show("wrong phone number");
            }
        }
    }
}
