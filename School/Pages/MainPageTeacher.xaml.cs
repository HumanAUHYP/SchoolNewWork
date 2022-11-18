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

namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageTeacher.xaml
    /// </summary>
    public partial class MainPageTeacher : Page
    {
        public int id;
        public MainPageTeacher(int id_teacher)
        {
            InitializeComponent();
            id = id_teacher;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CirclesTeacherPage(id));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new CirclesStudentInfoPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TeachesJournalPage(id));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
