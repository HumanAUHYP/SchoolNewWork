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
    /// Логика взаимодействия для TeachesJournalPage.xaml
    /// </summary>
    public partial class TeachesJournalPage : Page
    {
        public List<Lesson> Lessons { get; set; }
        public int idTeacher;

        public TeachesJournalPage(int idTeach)
        {
            InitializeComponent();
            idTeacher = idTeach;
            Lessons = DBconnection.db.Lesson.ToList();
            this.DataContext = this;
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewJournalPage(idTeacher));
        }

        private void lv_teachers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void search_TB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
