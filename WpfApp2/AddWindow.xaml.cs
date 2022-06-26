using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Parts parts = new Parts();
        public AddWindow()
        {
            InitializeComponent();
            DataContext = parts;
        }
                
        private void acceptbutton_Click(object sender, RoutedEventArgs e)
        {
            autoshopEntities.GetContext().Parts.Add(parts);
            autoshopEntities.GetContext().SaveChanges();
            
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            autoshopContext.main = new Main();
            autoshopContext.main.Show();
             
        }
    }
}
