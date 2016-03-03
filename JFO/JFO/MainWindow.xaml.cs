using JFO.Classes;
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
using System.IO;
using System.Windows.Forms;
using JFO.Views;


namespace JFO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator cl;
        public MainWindow()
        { 
            InitializeComponent();
           
        }

        private void OpenCalculator_Click(object sender, RoutedEventArgs e)
        {
            cl = new Calculator();
            MainFraim.Content = cl;
            this.Title = "Калькулятор";
            SaveCulculator.IsEnabled = true;
        }

        private void MOPZMenuItem_Click(object sender, RoutedEventArgs e)
        {
          
            MainFraim.Source = new Uri("Views/MopzDataBase.xaml", UriKind.Relative);
            this.Title = "Испытания МОПЗ";
            SaveCulculator.IsEnabled = false;
        }

        private void ProtocolGost_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Source = new Uri("Views/ProtocolGost10227.xaml", UriKind.Relative);
            this.Title = "Протокол испытаний по ГОСТ 10227";
            SaveCulculator.IsEnabled = false;
        }

        private void ProtocolMopz_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Source = new Uri("Views/ProtocolMopz.xaml", UriKind.Relative);
            this.Title = "Протокол испытаний МОПЗ";
            SaveCulculator.IsEnabled = false;
        }

        private void VNIIMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainFraim.Source = new Uri("Views/OtchetyDataBase.xaml", UriKind.Relative);
            this.Title = "Отчеты по НПЗ";
            SaveCulculator.IsEnabled = false;
        }

       

       

        private void AboutPropertyFuelItem_Click(object sender, RoutedEventArgs e)
        {
            AboutFuelProperty afp = new AboutFuelProperty();
            afp.ShowDialog();

        }

        private void AboutProgramMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutPrograme apr = new AboutPrograme();
            apr.ShowDialog();
        }

        private void AboutMethodsItem_Click(object sender, RoutedEventArgs e)
        {
            AboutMethods am = new AboutMethods();
            am.ShowDialog();
        }

        private void PrintItem_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog pd = new System.Windows.Controls.PrintDialog();
            if(pd.ShowDialog()==true)
                {
                pd.PrintVisual(MainFraim, "Документ JFO");
            }
        }

        private void SaveCulculator_Click(object sender, RoutedEventArgs e)
        {
        
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text files|*.txt";
            if (sf.ShowDialog() == System.Windows.Forms.DialogResult.OK & sf.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(sf.FileName, true))
                {
                    sw.WriteLine("Результаты расчетов");
                    sw.WriteLine("");
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.Plotnost20Label.Content.ToString() + "                    |   " + cl.Plotnost20Text.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.Plotnost15Label.Content.ToString() + "                   |   " + cl.Plotnost15Text.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.VNPLabel.Content.ToString() + "                |   " + cl.VNPText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.LCHLabel.Content.ToString() + "                       |   " + cl.LCHText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.NizTeplotSgorLabel.Content.ToString() + "               |   " + cl.NizTeplotSgorText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.PoverhnNatiajLabel.Content.ToString() + "                  |   " + cl.PoverhnNatiajText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.PokazatelPrelomleniaLabel.Content.ToString() + "                        |   " + cl.PokazatelPrelomleniaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.MolarnajaMassaLabel.Content.ToString() + "                        |   " + cl.MoularnajaMassaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.MolniyObiemLabel.Content.ToString() + "                         |   " + cl.MolniyObiemText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.VodorodLabel.Content.ToString() + "                    |   " + cl.VodorodText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.UglerodLabel.Content.ToString() + "                    |   " + cl.UglerodText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.WriteLine(cl.FactorNasaLabel.Content.ToString() + "                  |   " + cl.FactorNasaText.Text);
                    sw.WriteLine("-------------------------------------------------------------------------------------");
                    sw.Close();
                
            }

        }


    }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cl = new Calculator();
            MainFraim.Content = cl;
            this.Title = "Калькулятор";
            SaveCulculator.IsEnabled = true;
        }

        private void CloseItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }
    

