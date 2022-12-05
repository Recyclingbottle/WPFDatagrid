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

namespace WPFDatagrid
{
    public partial class MainWindow : Window
    {
        public class Gundam
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Party { get; set; }

            public Gundam(string name, string model, string party)
            {
                Name = name;
                Model = model;
                Party = party;
            }
        }
        protected List<Gundam> GundamList = new List<Gundam>();
        public MainWindow()
        {
            InitializeComponent();
            GundamList.Add(new Gundam("Test1", "Model1", "Party1"));
            GundamList.Add(new Gundam("Test2", "Model2", "Party2"));
            GundamList.Add(new Gundam("Test3", "Model3", "Party3"));
            GundamList.Add(new Gundam("Test4", "Model4", "Party4"));

            Grid.ItemsSource = GundamList;
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            GundamList.Add(new Gundam("Test5", "Model5", "Party5"));
            GundamList.Add(new Gundam("Test6", "Model6", "Party6"));
            Grid.Items.Refresh();
        }
    }
}
