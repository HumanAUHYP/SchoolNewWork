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
using School.DB;
namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для CirclePages.xaml
    /// </summary>
    public partial class CirclePages : Page
    {
        DB.Section section = new DB.Section { Id = 1, IsDeleted = false, Name = "Дота2" };
        List<DB.Section> sections = new List<DB.Section>();
        public CirclePages()
        {
            InitializeComponent();
            sections.Add(section);
            sections.Add(section);
            sections.Add(section);
            sections.Add(section);
            sections.Add(section);
            sections.Add(section);
            this.DataContext = this;
            lv_sections.ItemsSource = sections;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }


        private void search_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CirclesInfo_Click(object sender, RoutedEventArgs e)
        {
            var span = sender as Button;
            var idSect = span.CommandParameter;
            NavigationService.Navigate(new CirclesInfo((int)idSect));
        }
    }
}
