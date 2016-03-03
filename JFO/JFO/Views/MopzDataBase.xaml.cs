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
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для MopzDataBase.xaml
    /// </summary>
    public partial class MopzDataBase : Page
    { 
        string connectionString;
        string cmd;
        SQLConnect sqlConnect;
       
        public MopzDataBase()
        {
            InitializeComponent();
            DelMopzDataBtn.IsEnabled = false;
            AddFileMopzDataBtn.IsEnabled = false;
            Updating.IsEnabled = false;
            ExtractFileMopzDataBtn.IsEnabled = false;
            connectionString = "Your connection string";
            cmd = "Select * FROM MOPZ_FUEL";
            sqlConnect = new SQLConnect( connectionString, cmd);
        }

        private void Zagruzka_Click(object sender, RoutedEventArgs e)
        {

            string Parol = "";
            CheckParol chp = new CheckParol();

            chp.ShowDialog();

            Parol = chp.parol;

            if (Parol == "Sergey6611")
            {
                DelMopzDataBtn.IsEnabled = true;
                AddFileMopzDataBtn.IsEnabled = true;
                Updating.IsEnabled = true;
                ExtractFileMopzDataBtn.IsEnabled = true;
                sqlConnect.CommandsForBase(MopzDataGrid, cmd);

            }

            else
            {
                System.Windows.MessageBox.Show("Не верный пароль!","ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Warning);

            }


        }

        private void DelMopzDataBtn_Click(object sender, RoutedEventArgs e)
        {
                if (DelMopzDataTxt.Text == "")
                {
                    DelMopzDataTxt.IsEnabled = false;
                    System.Windows.MessageBox.Show("Введите ID записи для удаления!", "Внимание!",
                  MessageBoxButton.OK, MessageBoxImage.Warning);
                    DelMopzDataTxt.Focus();
                }
                else
                {
                    this.Cursor = System.Windows.Input.Cursors.Wait;
                    string commandText = "DELETE FROM MOPZ_FUEL WHERE ID='" + DelMopzDataTxt.Text + "'";
                    sqlConnect.DeleteDate(MopzDataGrid, commandText);
                    this.Cursor = null;
                    System.Windows.MessageBox.Show("Ваши данные успешно удалены!", "Данные удалены!",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
            
        }

        private void AddFileMopzDataBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddFileMopzDataTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Введите ID записи к которой добавляется файл!", "Внимание!",
              MessageBoxButton.OK, MessageBoxImage.Warning);
                AddFileMopzDataTxt.Focus();
            }
            else
            {
                try {
                    string filterFile = "Image Files( *.JPG)|  *.JPG";
                    string commandText = "UPDATE  MOPZ_FUEL SET File=@FileArr  WHERE ID = '" + AddFileMopzDataTxt.Text + "'";
                    sqlConnect.SaveFile(MopzDataGrid, commandText, filterFile);
                    System.Windows.MessageBox.Show("Файл успешно добавлен к записи\n ID = " + AddFileMopzDataTxt.Text, "Файл добавлен!",
                       MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    System.Windows.MessageBox.Show("Невозможно добавить файл в базу данных!\n",
                    " Потеряна связь с базой данных.\n" +
                    " Обратитесь к системному администратору.", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void ExtractFileMopzDataBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddFileMopzDataTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Введите ID записи в которой хранится файл!", "Внимание!",
              MessageBoxButton.OK, MessageBoxImage.Warning);
                AddFileMopzDataTxt.Focus();
              
            }
            else
            {
                string filterFile = "Image Files( *.JPG)|  *.JPG";
                string commandText = "SELECT File FROM MOPZ_FUEL   WHERE ID = '" + AddFileMopzDataTxt.Text + "'";
                sqlConnect.ExtractFile(commandText, filterFile);
                System.Windows.MessageBox.Show("Файл успешно сохранен!\n" + sqlConnect.filePath, "Файл извлечен!",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FindMopzDataBtn_Click(object sender, RoutedEventArgs e)
        {
            string category = FindFieldMopzDataCombo.Text;
            string word = FindWordMopzDataTxt.Text;
            sqlConnect.FindData(MopzDataGrid, category, word);
        }

        private void SortMopzDataBtn_Click(object sender, RoutedEventArgs e)
        {
            string category = SortFieldMopzDataCombo.Text;
            string napr = SortNapravlenieMopzDataCombo.Text;
            sqlConnect.SortData(MopzDataGrid, category, napr);

        }

      

        private void Updating_Click(object sender, RoutedEventArgs e)
        { this.Cursor = System.Windows.Input.Cursors.Wait;
            sqlConnect.UpdateFromBase(MopzDataGrid);
            this.Cursor = null;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string Parol = "";
            CheckParol chp = new CheckParol();

            chp.ShowDialog();

            Parol = chp.parol;

            if (Parol == "Sergey6611")
            {
                DelMopzDataBtn.IsEnabled = true;
                AddFileMopzDataBtn.IsEnabled = true;
                Updating.IsEnabled = true;
                ExtractFileMopzDataBtn.IsEnabled = true;
                sqlConnect.CommandsForBase(MopzDataGrid, cmd);

            }
            else
            {
                System.Windows.MessageBox.Show("Не верный пароль!", "ВНИМАНИЕ!",
                   MessageBoxButton.OK, MessageBoxImage.Warning);

            }

        }
    }
}
