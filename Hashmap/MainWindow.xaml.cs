using System;
using System.Collections;
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

namespace Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            //Add
            hashtable.Add(keytext.Text.ToString(), valuetext.Text.ToString());
            MessageBox.Show(keytext.Text.ToString() + " " +valuetext.Text.ToString());
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Remove(keytext.Text.ToString());
            MessageBox.Show(keytext.Text.ToString());
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            string allValue = "All Value :\n";
            //Show All
            foreach (string key in icollection)
            {
                allValue = allValue + "  " + hashtable[key] + "\n";
            }
            MessageBox.Show(allValue);
        }
    }
}
