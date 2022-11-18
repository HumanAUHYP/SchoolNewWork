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
    /// Логика взаимодействия для AddNewJournalPage.xaml
    /// </summary>
    public partial class AddNewJournalPage : Page
    {
        public int IdTeacher;
        List<DB.Section> sections;
        Lesson newLesson = new Lesson();
        List<StudentExisted> studentExisteds;
        List<Section_Student> students;
        public AddNewJournalPage(int idTeach)
        {
            InitializeComponent();
            IdTeacher = idTeach;
            this.DataContext = this;
            sections = DBconnection.db.Section.ToList();
            CB_Section.ItemsSource = sections;

        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void CB_Section_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DB.Section lesson = CB_Section.SelectedItem as DB.Section;
            newLesson.idSection = lesson.Id;
            DateTime today = DateTime.Today;
            newLesson.Date = today;
            DBconnection.db.Lesson.Add(newLesson);
            DBconnection.db.SaveChanges();
            List<Lesson> getLastLsit = DBconnection.db.Lesson.ToList();
            Lesson getLast = getLastLsit[getLastLsit.Count - 1];
            students = DBconnection.db.Section_Student.Where(prop => prop.SectionId == CB_Section.SelectedIndex + 1).ToList();
            foreach(var student in students)
            {
                StudentExisted studentExisted = new StudentExisted();
                studentExisted.StudentId = student.Id;
                studentExisted.idLesson = getLast.Id;
                studentExisted.IsExisted = true;
                DBconnection.db.StudentExisted.Add(studentExisted);
                DBconnection.db.SaveChanges();
            }
            studentExisteds = DBconnection.db.StudentExisted.Where(p => p.idLesson == getLast.Id).ToList();
            lvJournal.ItemsSource = studentExisteds;
        }
        private void cbStudentIsBe_Click(object sender, RoutedEventArgs e)
        {
            DBconnection.db.SaveChanges();
        }
    }
}
