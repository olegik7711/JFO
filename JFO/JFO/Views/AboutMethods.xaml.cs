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
    /// Логика взаимодействия для AboutMethods.xaml
    /// </summary>
    public partial class AboutMethods : Window
    {
        public AboutMethods()
        {
            InitializeComponent();
        }

        private void Plotnost_Checked(object sender, RoutedEventArgs e)
        {
            try {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-3900-85", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void FracSost_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://standartgost.ru/g/%D0%93%D0%9E%D0%A1%D0%A2_%D0%A0_%D0%95%D0%9D_%D0%98%D0%A1%D0%9E_3405-2007", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Viascost_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-33-2000", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void NizTepSgor_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://standartgost.ru/g/%D0%93%D0%9E%D0%A1%D0%A2_11065-90", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void VNP_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/1200007917", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Kislotn_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/1200005438", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Iod_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-2070-82?block=8", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Vspishka_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-6356-75", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Aromat_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-r-52063-2003", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void FactSmoly_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-1567-97", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Sera_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-r-51947-2002", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Merkaptan_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://snipov.net/c_4727_snip_105908.html", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Serovodorod_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/1200007946", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Plastinka_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-6321-92", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Zolnost_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-1461-75", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Naftaliny_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/1200007947", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void LCH_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-17750-72", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DTS_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-17751-79?block=16", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Electro_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-25950-83", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DavlenParov_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/gost-1756-52", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void TSRT_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://standartgost.ru/g/%D0%93%D0%9E%D0%A1%D0%A2_11802-88", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Kristall_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                HelpWeb.Source = new Uri("http://docs.cntd.ru/document/1200007918", UriKind.RelativeOrAbsolute);
                this.Cursor = null;
            }
            catch
            {
                MessageBox.Show("Нет доступа к документу!\n" + "Проверьте подключение к интернету!", "ВНИМАНИЕ",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
