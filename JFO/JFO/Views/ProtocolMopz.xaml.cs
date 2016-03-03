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
using Microsoft.Office.Interop.Word;
using System.Reflection;
using MySql.Data.MySqlClient;
namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для ProtocolMopz.xaml
    /// </summary>
    public partial class ProtocolMopz : System.Windows.Controls.Page
    {
        Microsoft.Office.Interop.Word._Application App;
        Microsoft.Office.Interop.Word._Document Protocol;
        public ProtocolMopz()
        {
            InitializeComponent();

            DateProtMopztText.Text = DateTime.Now.Date.ToString();
           
        }

        private void MakeProtMopzButton_Click(object sender, RoutedEventArgs e)
        { try {
                object oMissing = System.Reflection.Missing.Value;
                App = new Microsoft.Office.Interop.Word.Application();
                App.Visible = true;
               Protocol = App.Documents.Add(ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing);

                Microsoft.Office.Interop.Word.Paragraph paragraf1;
                Protocol.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;


                paragraf1 = Protocol.Paragraphs.Add(ref oMissing);

                paragraf1.Range.Font.Name = "Times New Roman";
                paragraf1.Range.Font.Size = 12;
                paragraf1.Range.Font.Bold = 1;
                paragraf1.Range.Text = "Протокол испытаний реактивного топлива\n " + FuelNameProtMopzTxt.Text;
                paragraf1.Format.SpaceAfter = 10;
                paragraf1.Range.InsertParagraphAfter();
                object EndOfDoc = "\\endofdoc";
                Microsoft.Office.Interop.Word.Range wrdRng = Protocol.Bookmarks.get_Item(ref EndOfDoc).Range;
                Microsoft.Office.Interop.Word.Table mainTable;
                mainTable = Protocol.Tables.Add(wrdRng, 6, 3, Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                   Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow);

                mainTable.Range.Font.Name = "Times New Roman";
                mainTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                mainTable.Range.ParagraphFormat.SpaceAfter = 0;
                mainTable.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                mainTable.Cell(1, 1).Range.Font.Bold = 1;
                mainTable.Cell(1, 1).Range.Text = "Показатель";
                mainTable.Cell(2, 1).Range.Text = NR21F2ProtMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(3, 1).Range.Text = VNPMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(4, 1).Range.Text = AromaticaGostLabel.Content.ToString();
                mainTable.Cell(5, 1).Range.Text = DTSMopzLabel.Content.ToString() + "\n\n" +
                    DTSFiltrMopzLabel.Content.ToString() + "\n\n" + DTSBallMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(6, 1).Range.Text = FactSmolyMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(7, 1).Range.Text = MSEPMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(8, 1).Range.Text = LCHMopzLabel.Content.ToString() + "\n";
                mainTable.Cell(9, 1).Range.Text = JFTOTMopzLabel.Content.ToString() + "\n\n" +
                JFTOTFiltrMopzLabel.Content.ToString() + "\n\n" + JFTOTBallMopzLabel.Content.ToString() + "\n";

                mainTable.Cell(1, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                mainTable.Cell(1, 2).Range.Font.Bold = 1;
                mainTable.Cell(1, 2).Range.Text = "Норма";
                mainTable.Cell(2, 2).Range.Text = "\nне более";
                mainTable.Cell(3, 2).Range.Text = "\nне ниже";
                mainTable.Cell(4, 2).Range.Text = " \n\nне более";
                mainTable.Cell(5, 2).Range.Text = "\n\n\n\n\n\n" + "не выше" + "\n\n\n" + "не более";
                mainTable.Cell(6, 2).Range.Text = "\nне более";
                mainTable.Cell(7, 2).Range.Text = "\nне менее";
                mainTable.Cell(8, 2).Range.Text = "\nне менее";
                mainTable.Cell(9, 2).Range.Text = "\n\n\n\n\n\n" + "не выше" + "\n\n\n\n\n" + "не более";

                mainTable.Cell(1, 3).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                mainTable.Cell(1, 3).Range.Font.Bold = 1;
                mainTable.Cell(1, 3).Range.Text = "Результат";
                mainTable.Cell(2, 3).Range.Text = "\n" + NR21F2ProtMopzTxt.Text;
                mainTable.Cell(3, 3).Range.Text = "\n" + VNPMopzTxt.Text;
                mainTable.Cell(4, 3).Range.Text = "\n\n" + AromaticaGostTxt.Text;
                mainTable.Cell(5, 3).Range.Text = "\n\n\n\n\n\n" + DTSFiltrMopzTxt.Text + "\n\n\n" + DTSBallMopzTxt.Text;
                mainTable.Cell(6, 3).Range.Text = "\n" + FactSmolyMopzTxt.Text;
                mainTable.Cell(7, 3).Range.Text = "\n" + MSEPMopzTxt.Text;
                mainTable.Cell(8, 3).Range.Text = "\n" + LCHMopzTxt.Text;
                mainTable.Cell(9, 3).Range.Text = "\n\n\n\n\n\n" + JFTOTFiltrMopzTxt.Text
                    + "\n\n\n\n\n" + JFTOTBallMopzTxt.Text;

                mainTable.Range.InsertParagraphAfter();
                Microsoft.Office.Interop.Word.Paragraph paragraf2;
                paragraf2 = Protocol.Paragraphs.Add(ref oMissing);
                paragraf2.Range.Text = "\n\n\n";

                object endOfDoc = "\\endofdoc";
                Microsoft.Office.Interop.Word.Range WrdRng = Protocol.Bookmarks.get_Item(ref endOfDoc).Range;
                Microsoft.Office.Interop.Word.Table FioTable;
                FioTable = Protocol.Tables.Add(WrdRng, 2, 2, Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord8TableBehavior,
                 Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow);
                FioTable.Range.Font.Name = "Times New Roman";
                FioTable.Range.Font.Size = 12;
                FioTable.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                FioTable.Cell(1, 1).Range.Text = DoljnostProtMopzTxt.Text;
                FioTable.Cell(1, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                FioTable.Cell(1, 2).Range.Text = FioProtMopzTxt.Text;
                FioTable.Cell(2, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                FioTable.Cell(2, 2).Range.Text = DateProtMopztText.Text;
            }
            catch
            {
                System.Windows.MessageBox.Show("Убедитесь, что у вас установлен пакет Microsoft Office \n" +
                                  "в частности приложение WORD.", "Не удалось создать протокол!\n",
                                  MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void SaveProtMopzButton_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = "Server= mysql53.hostland.ru; DataBase= host1390427_1; UserID= host1390427; Password= 4350ad23";
            string commandString = "INSERT INTO MOPZ_FUEL (Date,Name,NR21F2,DTS_ball,DTS_zabivka,JFTOT_ball,JFTOT_zabivka,VNP,Fact_smoly,Aromatica,LCH,MSEP) VALUES('" +
                DateProtMopztText.Text + "','" + FuelNameProtMopzTxt.Text + "','" + NR21F2ProtMopzTxt.Text + "','"
                + DTSBallMopzTxt.Text + "','" + DTSFiltrMopzTxt.Text + "','" + JFTOTBallMopzTxt.Text + "','" + JFTOTFiltrMopzTxt.Text +
                "','" + VNPMopzTxt.Text + "','" + FactSmolyMopzTxt.Text + "','" + AromaticaGostTxt.Text + "','" + LCHMopzTxt.Text + "','" + MSEPMopzTxt.Text + "')";
            this.Cursor = System.Windows.Input.Cursors.Wait;
            try {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(commandString, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("Проверьте наличие соединения с интернетом,\n" +
                  "или обратитесь к системному администратору.", "Невозможно выполнить соединение с базой данных!\n",
                  MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Cursor = null;
            MessageBox.Show("Ваши данные успешно сохранены!");
            
        }
    }
}
