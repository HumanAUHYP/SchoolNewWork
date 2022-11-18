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
    /// Логика взаимодействия для TeacherInfoPage.xaml
    /// </summary>
    public partial class TeacherInfoPage : Page
    {
        int idxTeacher;
        List<Section_Teacher> section_Teachers;
        public TeacherInfoPage(int teacherIdx)
        {
            InitializeComponent();
            this.DataContext = this;
            idxTeacher = teacherIdx;
            section_Teachers = DBconnection.db.Section_Teacher.Where(p => p.TeacherID == idxTeacher).ToList();
            lv_circles.ItemsSource = section_Teachers;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
