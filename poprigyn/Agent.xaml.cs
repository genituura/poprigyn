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

namespace poprigyn
{
    /// <summary>
    /// Логика взаимодействия для Agent.xaml
    /// </summary>
    public partial class Agent : Window
    {
        public demo3Entities db = new demo3Entities();
        public Agent()
        {
            InitializeComponent();
            Agents.ItemsSource = db.Agent.ToList();
            Sort.ItemsSource = db.Agent.ToList();   
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (demo3Entities db = new demo3Entities())
            {
                //Agents.ItemsSource = db.Agent.ToList().Where(c => c.Agents.Contains(Sort.Text) || c.Email.Contains(Sort.Text) || c.Phone.Contains(Search.Text));
                if (Search.Text == "Все")
                {
                    Agents.ItemsSource = db.Agent.ToList();
                }
            }
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AgentGrid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void AgentGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void NuberOfSales_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SortOfType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Type_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Name_TextChanged_4(object sender, TextChangedEventArgs e)
        {

        }
    }
}
