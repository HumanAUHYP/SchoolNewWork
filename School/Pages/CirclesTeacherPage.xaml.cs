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
    /// Логика взаимодействия для CirclesTeacherPage.xaml
    /// </summary>
    public partial class CirclesTeacherPage : Page
    {
        List<Section_Teacher> sections = new List<Section_Teacher>();
        public int idTeach;
        public CirclesTeacherPage(int id)
        {
            InitializeComponent();
            idTeach = id;
            sections = DBconnection.db.Section_Teacher.Where(p => p.TeacherID == idTeach).ToList();
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
            NavigationService.Navigate(new CirclesStudentInfoPage((int)idSect));
        }
    }
}
