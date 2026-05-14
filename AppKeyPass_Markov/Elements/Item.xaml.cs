using AppKeyPass_Markov.Contexts;
using AppKeyPass_Markov.Models;
using AppKeyPass_Markov.Pages;
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

namespace AppKeyPass_Markov.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Storage Storage;
        Main Main; 
        
        public Item(Storage storage, Main main)
        {
            InitializeComponent();
            tbName.Text = storage.Name;
            tbUrl.Text = storage.Url;
            tbLogin.Text = storage.Login;
            tbPassword.Text = storage.Password;
            this.Main = main;
            this.Storage = storage;
        }
        private void Update(object sender, System.Windows.RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Add(Storage));
        }
        private void Delete(object sender, System.Windows.RoutedEventArgs e)
        {
            StorageContext.Delete(Storage.Id);
            this.Main.StorageList.Children.Remove(this);
            MessageBox.Show("Данные Nuke'нуты");
        }
    }
}
