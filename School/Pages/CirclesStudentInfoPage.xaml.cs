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
    /// Логика взаимодействия для CirclesStudentInfoPage.xaml
    /// </summary>
    public partial class CirclesStudentInfoPage : Page
    {
        List<Section_Student> students;
        public int idSection;
        public CirclesStudentInfoPage(int idSect)
        {
            InitializeComponent();
            idSection = idSect;
            students = DBconnection.db.Section_Student.Where(p => p.SectionId == idSection).ToList();
            lv_teachers.ItemsSource = students;
            this.DataContext = this;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void search_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AddNewInCirclesWindow(idSection);
            window.Show();
        }
    }
}
