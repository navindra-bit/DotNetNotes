using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoboxAndLibox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            object newitem = newtextadd.Text;
            combo.Items.Add(newitem);
            newtextadd.Text = "";
        }

        private void c_Click(object sender, RoutedEventArgs e)
        {
            int count = combo.Items.Count;
            //combo.Items.Clear();
           // combo.Items.Remove("India");
            combo.Items.RemoveAt(count-1);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int count1 = lb.SelectedItems.Count;

            for (int i = 0; i < count1; i++)
            {
                ListBoxItem listBoxItem = (ListBoxItem)lb.SelectedItems[i];
                if(listBoxItem.Content is not null)
                {
                MessageBox.Show(listBoxItem.Content.ToString());
                }
            }
        }
    }
}