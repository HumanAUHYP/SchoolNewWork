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
using System.Windows.Shapes;
using School.DB;

namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddNewInCirclesWindow.xaml
    /// </summary>
    public partial class AddNewInCirclesWindow : Window
    {
        public List<Student> students;
        int idCircle;
        public AddNewInCirclesWindow(int idCirc)
        {
            InitializeComponent();
            idCircle = idCirc;
            students = DBconnection.db.Student.ToList();
            this.DataContext = this;
            CB_Students.ItemsSource = students;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Section_Student studentEx = DBconnection.db.Section_Student.Where(p => p.SectionId == idCircle && p.StudentId == CB_Students.SelectedIndex + 1).FirstOrDefault();
            if (studentEx != null)
            {
                MessageBox.Show("Ученик уже записан на этот курс");
                return;
            }
            Section_Student newS = new Section_Student();
            newS.SectionId = idCircle;
            newS.StudentId = CB_Students.SelectedIndex + 1;
            newS.IsRegistered = true;
            DBconnection.db.Section_Student.Add(newS);
            DBconnection.db.SaveChanges();
            MessageBox.Show("Ученик успешно записан на этот курс");
            this.Close();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
