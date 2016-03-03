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

namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для OtchetyDataBase.xaml
    /// </summary>
    public partial class OtchetyDataBase : Page
    {
        string connectionString;
        string cmd;
        SQLConnect sqlConnect;
        public OtchetyDataBase()
        {
            InitializeComponent();

            DelOtchetyDataBtn.IsEnabled = false;
            AddFileOtchetDataBtn.IsEnabled = false;
            ExtractFileMopzDataBtn.IsEnabled = false;
            Updating.IsEnabled = false;
            connectionString = "Your connection string";
            cmd = "Select * FROM VNII_OTCHET";
            sqlConnect = new SQLConnect(connectionString, cmd);
        }

        private void Zagruzka_Click(object sender, RoutedEventArgs e)
        {
            string Parol = "";
            CheckParol chp = new CheckParol();

            chp.ShowDialog();

            Parol = chp.parol;

            if (Parol == "Sergey6611")
            {
                DelOtchetyDataBtn.IsEnabled = true;
                AddFileOtchetDataBtn.IsEnabled = true;
                ExtractFileMopzDataBtn.IsEnabled = true;
                Updating.IsEnabled = true;
                sqlConnect.CommandsForBase(OtchetyDataGrid, cmd);

            }
            else
            {
                System.Windows.MessageBox.Show("Не верный пароль!", "ВНИМАНИЕ!",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

            }

        }

        private void DelOtchetyDataBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DelOtchetyDataTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Введите ID записи для удаления!", "Внимание!",
              MessageBoxButton.OK, MessageBoxImage.Warning);
                DelOtchetyDataTxt.Focus();
            }
            else
            {
                this.Cursor = System.Windows.Input.Cursors.Wait;
                string commandText = "DELETE FROM VNII_OTCHET WHERE ID='" + DelOtchetyDataTxt.Text + "'";
                sqlConnect.DeleteDate(OtchetyDataGrid, commandText);
                this.Cursor = null;
                System.Windows.MessageBox.Show("Ваши данные успешно удалены!", "Данные удалены!",
                  MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

       

        private void AddFileOtchetDataBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AddFileOtchetyDataTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Введите ID записи к которой добавляется файл!", "Внимание!",
              MessageBoxButton.OK, MessageBoxImage.Warning);
                AddFileOtchetyDataTxt.Focus();
            }
            else
            {
                try
                {
                    string filterFile = "Word Files( *.docx)| *.docx";
                    string commandText = "UPDATE VNII_OTCHET SET Otchet=@FileArr  WHERE ID = '" + AddFileOtchetyDataTxt.Text + "'";

                    sqlConnect.SaveFile(OtchetyDataGrid, commandText,filterFile);
                    System.Windows.MessageBox.Show("Файл успешно добавлен к записи\n ID = " + AddFileOtchetyDataTxt.Text, "Файл добавлен!",
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
            if (AddFileOtchetyDataTxt.Text == "")
            {
                System.Windows.MessageBox.Show("Введите ID записи в которой хранится файл!", "Внимание!",
              MessageBoxButton.OK, MessageBoxImage.Warning);
                AddFileOtchetyDataTxt.Focus();

            }
            else
            {
                string filterFile = "Word Files(*.docx) | *.docx ";
                string commandText = "SELECT Otchet FROM VNII_OTCHET   WHERE ID = '" + AddFileOtchetyDataTxt.Text + "'";
                sqlConnect.ExtractFile(commandText, filterFile);
                System.Windows.MessageBox.Show("Файл успешно сохранен!\n" + sqlConnect.filePath, "Файл извлечен!",
               MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void FindOtchetyDataBtn_Click(object sender, RoutedEventArgs e)
        {
            string category = FindFieldOtchetyDataCombo.Text;
            string word = FindWordOtchetyDataTxt.Text;
            sqlConnect.FindData(OtchetyDataGrid, category, word);
        }

        private void SortOtchetyDataBtn_Click(object sender, RoutedEventArgs e)
        {
            string category = SortFieldOtchetyDataCombo.Text;
            string napr = SortNapravlenieOtchetyDataTxt.Text;
            sqlConnect.SortData(OtchetyDataGrid, category, napr);
        }

        private void Updating_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = System.Windows.Input.Cursors.Wait;
            sqlConnect.UpdateFromBase(OtchetyDataGrid);
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
                DelOtchetyDataBtn.IsEnabled = true;
                AddFileOtchetDataBtn.IsEnabled = true;
                ExtractFileMopzDataBtn.IsEnabled = true;
                Updating.IsEnabled = true;
                sqlConnect.CommandsForBase(OtchetyDataGrid, cmd);

            }
            else
            {
                System.Windows.MessageBox.Show("Не верный пароль!", "ВНИМАНИЕ!",
                   MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
