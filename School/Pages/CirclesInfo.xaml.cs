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
    /// Логика взаимодействия для CirclesInfo.xaml
    /// </summary>
    public partial class CirclesInfo : Page
    {
        public int id_section;
        List<Teacher> teachers = new List<Teacher>();
        public CirclesInfo(int idSect)
        {
            InitializeComponent();
            id_section = idSect;
            this.DataContext = this;
            tb_Name.Text = "Курсы пикапа";
            Teacher teacher = new Teacher { Id = 1, FullName = "Барышев Эмиль", IsDeleted = false };
            Teacher teacher2 = new Teacher { Id = 1, FullName = "Мавлин Данис", IsDeleted = false };
            Teacher teacher3 = new Teacher { Id = 1, FullName = "Мамонов Иван", IsDeleted = false };
            Teacher teacher4 = new Teacher { Id = 1, FullName = "Николаев Климентий", IsDeleted = false };
            teachers.Add(teacher);
            teachers.Add(teacher2);
            teachers.Add(teacher3);
            teachers.Add(teacher4);
            lv_teachers.ItemsSource = teachers;
            tb_valuePeople.Text = "25/10";
        }

        private void search_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
