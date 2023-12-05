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
    /// Interaction logic for admin.xaml
    /// </summary>
    public partial class admin : Page
    {
        facebookEntities db = new facebookEntities();
        public admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                admin user = db.admins.First(x => x.admin_username == user_t.Text && x.admin_pass == password_t.Text);
                adminpage adminpage = new adminpage();
                NavigationService.Navigate(adminpage);
                    
            }
            catch
            {
                MessageBox.Show("wrong username or password");
            }
        }
    }
}
