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
using System.Windows.Shapes;
using System.Data.Entity;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public AddWindow addw = new AddWindow();
        private Parts parts = new Parts(); // новый экземпляр класса, связанный с таблицей Parts в базе данных
        public Main()
        {
            InitializeComponent();
            var currentList = autoshopEntities.GetContext().Parts.ToList();
            List.ItemsSource = currentList;
        }

        private void SearchList() // поиск по названию
        {
            var searchLists = autoshopEntities.GetContext().Parts.ToList();

            searchLists = searchLists.Where(p => p.PartName.ToLower().Contains(SearchBox.Text.ToLower())).ToList();

            List.ItemsSource = searchLists.OrderBy(p => p.PartName).ToList();
        }




        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            var ItemForRemoving = List.SelectedItems.Cast<Parts>().ToList();
            autoshopEntities.GetContext().Parts.RemoveRange(ItemForRemoving);
            autoshopEntities.GetContext().SaveChanges();
            this.Close();
            autoshopContext.main = new Main();
            autoshopContext.main.Show();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchList();
        }



        private void AddWindowButton_Click(object sender, RoutedEventArgs e) 
        {

            addw.Show();
            this.Close();
        }

        

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

       

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
         
            

        }
    }
}
