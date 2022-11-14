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
        List<Section_Teacher> teachers;
        List<Section_Student> section_Students;
        DB.Section section;
        public CirclesInfo(int idSect)
        {
            InitializeComponent();
            id_section = idSect;
            section = DBconnection.db.Section.FirstOrDefault(p => p.Id == id_section);
            this.DataContext = this;
            tb_Name.Text = section.Name;
            teachers = DBconnection.db.Section_Teacher.Where(p => p.SectionId == id_section).ToList();
            section_Students = DBconnection.db.Section_Student.Where(p => p.SectionId == id_section).ToList();
            lv_teachers.ItemsSource = teachers;
            lv_students.ItemsSource = section_Students;
            foreach (var f in section_Students)
            {
                
                //f.Teacher.FullName;
            }
            tb_desc.Text = section.Description;
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
