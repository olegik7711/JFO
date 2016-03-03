using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Controls;
using System.IO;
using System.Windows.Forms;
using System.Windows;

namespace JFO.Classes
{
    public class SQLConnect
    {
        string ConString;
        string CommandString;
        MySqlConnection Connection;
        MySqlCommand Command;
        MySqlCommandBuilder CmdBuilder;
        MySqlDataAdapter Da;
        DataSet Ds;
        public string filePath;
      
        public SQLConnect( string connection, string command)
        {
            this.ConString = connection;
            this.CommandString = command;
         
                using (Connection = new MySqlConnection(ConString))
                {
                    Da = new MySqlDataAdapter(CommandString, Connection);
                    Ds = new DataSet();
                
            }
           
        }
        //загрузка таблицы базы данных
        public  void  CommandsForBase(System.Windows.Controls.DataGrid dg, string command)
        {
            try {

            Connection.Open();

                Da.Fill(Ds);
               dg.ItemsSource =  Ds.Tables[0].DefaultView;
                Connection.Close();
            }
            catch
            {
                System.Windows.MessageBox.Show("Проверьте наличие соединения с интернетом,\n" +
                   "или обратитесь к системному администратору.","Невозможно выполнить соединение с базой данных!\n",
                   MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //сохранение изменений в таблице базы данных
        public void UpdateFromBase(System.Windows.Controls.DataGrid dg)

        {
            try {
                Connection.Open();
                MySqlCommandBuilder cb = new MySqlCommandBuilder(Da);
                Da.UpdateCommand = cb.GetUpdateCommand();
                Da.Update(Ds);
                Ds = new DataSet();
                Da.Fill(Ds);
                dg.ItemsSource = Ds.Tables[0].DefaultView;
                Connection.Close();
            }
            catch
            {
                System.Windows.MessageBox.Show("Невозможно выполнить обновление данных!\n",
                    " Потеряна связь с базой данных.\n" + 
                    " Обратитесь к системному администратору.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
         //удаление строк из базы данных
        public void DeleteDate (System.Windows.Controls.DataGrid dg, string commandText)
        {

            try {
                Connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandText, Connection))
                {
                    cmd.ExecuteNonQuery();
                    Da = new MySqlDataAdapter(CommandString, Connection);
                    Ds = new DataSet();
                    Da.Fill(Ds);
                    dg.ItemsSource = Ds.Tables[0].DefaultView;
                    Connection.Close();
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Невозможно выполнить удаление данных!\n",
                    " Потеряна связь с базой данных.\n" +
                    " Обратитесь к системному администратору.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
      
        //сохранение файла в базе данных
        public void SaveFile(System.Windows.Controls.DataGrid dg, string commandText, string filterFile)
        {
            try
            {
                string filePath;
                byte[] FileArr = null;
                OpenFileDialog fd = new OpenFileDialog();
                fd.Filter = filterFile;
                if (fd.ShowDialog() == DialogResult.OK)
                { 
                filePath = fd.FileName;
                FileArr = System.IO.File.ReadAllBytes(filePath);
                    }

                Connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandText, Connection))
                {
                    cmd.Parameters.Add("@FIleArr", MySqlDbType.Binary);
                    cmd.Parameters["@FileArr"].Value = FileArr;
                    cmd.ExecuteNonQuery();
                    Da = new MySqlDataAdapter(CommandString, Connection);
                    Ds = new DataSet();
                    Da.Fill(Ds);
                    dg.ItemsSource = Ds.Tables[0].DefaultView;
                    Connection.Close();
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Невозможно добавить файл в базу данных!\n",
                    " Потеряна связь с базой данных.\n" +
                    " Обратитесь к системному администратору.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //извлечение файла из базы данных
        public void ExtractFile(string commandText, string filterFile)
        {
            try { 
            Connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(commandText, Connection))
                {
                    byte[] FileArr = (byte[])cmd.ExecuteScalar();
                     

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = filterFile;
                    if (saveFileDialog.ShowDialog() != DialogResult.OK) { return; }
                    filePath = saveFileDialog.FileName;

                    FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(FileArr);
                    bw.Close();
                    Connection.Close();
                }
                }
                 catch
            {
                System.Windows.MessageBox.Show("Невозможно извлечь файл из базы дынных!\n",
                    " Потеряна связь с базой данных.\n" +
                    " Обратитесь к системному администратору.", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        
        }

        //поиск по таблице 
        public void FindData(System.Windows.Controls.DataGrid dg, string findCategory, string findWord )
        {
           
            DataView dv = new DataView(Ds.Tables[0]);
            
            dv.RowFilter = findCategory +"="+"'"+findWord+"'";
            dg.ItemsSource = dv;
        }

        //сортировка записей в таблице
        public void SortData(System.Windows.Controls.DataGrid dg, string SortCategory, string napravl)
        {
            
            DataView dv = new DataView(Ds.Tables[0]);
            if(napravl == "По возрастанию")
            {
                dv.Sort = SortCategory + " ASC";
            }
            else if (napravl=="По убыванию")
            {
                dv.Sort = SortCategory + " DESC";
            }
            dg.ItemsSource = dv;

        }
    }
}
