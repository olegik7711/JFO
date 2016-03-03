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

namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для CheckParol.xaml
    /// </summary>
    public partial class CheckParol : Window
    {
        public string parol;
        public CheckParol()
        {
            InitializeComponent();
           
        }

        

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = System.Windows.Input.Cursors.Wait;
            parol = logTxt.Text + ParTxt.Password;
           
            this.Close();
        }
    }
}
