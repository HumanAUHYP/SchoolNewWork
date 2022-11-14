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
    /// Логика взаимодействия для EducationTimetable.xaml
    /// </summary>
    public partial class EducationTimetable : Page
    {
        List<Timetable> timetables;
        List<Cabinet> cabinet;
        public EducationTimetable()
        {
            InitializeComponent();
            this.DataContext = this;
            cabinet = DBconnection.db.Cabinet.ToList();
            cb_cabinet.ItemsSource = cabinet.ToString();
            //foreach (var cabinet in cabinet)
            //{
                
            //}
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
