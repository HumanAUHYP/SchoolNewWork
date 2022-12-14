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
    /// Логика взаимодействия для TeachersPage.xaml
    /// </summary>
    public partial class TeachersPage : Page
    {
        List<Teacher> teachers = new List<Teacher>();
        public TeachersPage()
        {
            InitializeComponent();
            this.DataContext = this;
            teachers = DBconnection.db.Teacher.ToList();
            lv_teachers.ItemsSource = teachers;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void search_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lv_teachers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new TeacherInfoPage(lv_teachers.SelectedIndex + 1));
        }
    }
}
