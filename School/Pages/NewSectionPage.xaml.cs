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
    /// Логика взаимодействия для NewSectionPage.xaml
    /// </summary>
    public partial class NewSectionPage : Page
    {
       DB. Section newSect = new DB.Section();
        public NewSectionPage()
        {
            InitializeComponent();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            int value;
            if( tb_Name.Text == "" || tb_Value.Text == "" || tb_Desc.Text == "")
            {
                MessageBox.Show("Заполните все данные!");
                return;
            }

            try
            {
                value = Convert.ToInt32(tb_Value.Text);
            }
            catch
            {
                MessageBox.Show("Не коректно заполнено количество людей!");
                return;
            }
            newSect.Name = tb_Name.Text;
            newSect.MaxPupils = Convert.ToInt32(tb_Value.Text);
            newSect.Description = tb_Desc.Text;
            DBconnection.db.Section.Add(newSect);
            DBconnection.db.SaveChanges();
            MessageBox.Show("Кружок успешно добавлен");
            NavigationService.GoBack();
        }
    }
}
