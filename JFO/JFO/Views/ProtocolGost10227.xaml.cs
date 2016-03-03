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
using System.Reflection;
using Microsoft.Office.Interop.Word;
namespace JFO.Views
{
    /// <summary>
    /// Логика взаимодействия для ProtocolGost10227.xaml
    /// </summary>
    public partial class ProtocolGost10227 : System.Windows.Controls.Page
    {
        Microsoft.Office.Interop.Word._Application App;
        Microsoft.Office.Interop.Word._Document Protocol;
        public ProtocolGost10227()
        {
            InitializeComponent();
            DateProtGostText.Text = DateTime.Now.Date.ToString();

        }

        private void MakeProtGostButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                object oMissing = System.Reflection.Missing.Value;
                App = new Microsoft.Office.Interop.Word.Application();
                App.Visible = true;
                Protocol = App.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                Microsoft.Office.Interop.Word.Paragraph paragraf1;
                paragraf1 = Protocol.Paragraphs.Add(ref oMissing);
                Protocol.Paragraphs.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraf1.Range.Font.Name = "Times New Roman";
                paragraf1.Range.Font.Size = 12;
                paragraf1.Range.Font.Bold = 1;
                paragraf1.Range.Text = "Протокол испытания реактивного топлива по ГОСТ 10227\n" + FuelNameProtGostTxt.Text;
                paragraf1.Format.SpaceAfter = 10;

                Microsoft.Office.Interop.Word.Table tableResult;
                object EndOfDoc = "\\endofdoc";
                Microsoft.Office.Interop.Word.Range wrdRng = Protocol.Bookmarks.get_Item(ref EndOfDoc).Range;
                tableResult = Protocol.Tables.Add(wrdRng, 29, 3, Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior,
                    Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitWindow);

                tableResult.Range.ParagraphFormat.SpaceAfter = 0;

                tableResult.Range.Font.Name = " Times New Roman";
                tableResult.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                tableResult.Cell(1, 1).Range.Font.Bold = 1;
                tableResult.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                tableResult.Cell(1, 1).Range.Text = "Показатель\n";
                tableResult.Cell(2, 1).Range.Text = PlotnostProtGostLabel.Content.ToString() + "\n";
                tableResult.Cell(3, 1).Range.Text = FrackSostavProtGostLabel.Content.ToString() + "\n\n" +
                    FSNachKipeniaLabel.Content.ToString() + "\n\n" + FSTemper10Label.Content.ToString() + "\n\n" +
                    FSTemper50Label.Content.ToString() + "\n\n" + FSTemper90Label.Content.ToString() + "\n\n" +
                    FSTemper98Label.Content.ToString() + "\n\n" + FSOstatok8Label.Content.ToString() + "\n\n" +
                    FSPoteryLabel.Content.ToString() + "\n";
                tableResult.Cell(4, 1).Range.Text = ViaskostProtGostLabel.Content.ToString() + "\n\n" +
                    Viascost20Label.Content.ToString() + "\n\n" + ViascostMinus40Label.Content.ToString() +
                    "\n\n" + ViascostMinus20Label.Content.ToString() + "\n";
                tableResult.Cell(5, 1).Range.Text = NizTeplotSgorLabel.Content.ToString() + "\n";
                tableResult.Cell(6, 1).Range.Text = VNPGostLabel.Content.ToString() + "\n";
                tableResult.Cell(7, 1).Range.Text = KOHGostLabel.Content.ToString() + "\n";
                tableResult.Cell(8, 1).Range.Text = IODGostLabel.Content.ToString() + "\n";
                tableResult.Cell(9, 1).Range.Text = VspishkaGostLabel.Content.ToString() + "\n";
                tableResult.Cell(10, 1).Range.Text = KristallGostLabel.Content.ToString() + "\n";
                tableResult.Cell(11, 1).Range.Text = TSRTProtGostLabel.Content.ToString() + "\n\n" +
                    TSRTOsadokGostLabel.Content.ToString() + "\n\n" + TSRTRastvorSmolyGostLabel.Content.ToString() +
                    "\n\n" + TSRTNerastvorSmolyGostLabel.Content.ToString() + "\n";
                tableResult.Cell(12, 1).Range.Text = AromaticaGostLabel.Content.ToString() + "\n";
                tableResult.Cell(13, 1).Range.Text = FactSmolyGostLabel.Content.ToString() + "\n";
                tableResult.Cell(14, 1).Range.Text = SeraGostLabel.Content.ToString() + "\n";
                tableResult.Cell(15, 1).Range.Text = MerkaptanyLabel.Content.ToString() + "\n";
                tableResult.Cell(16, 1).Range.Text = SerovodorodGostLabel.Content.ToString() + "\n";
                tableResult.Cell(17, 1).Range.Text = PlastinkaGostLabel.Content.ToString() + "\n";
                tableResult.Cell(18, 1).Range.Text = ZolnostGostLabel.Content.ToString() + "\n";
                tableResult.Cell(19, 1).Range.Text = SoderjanieKislotIChelochGostLabel.Content.ToString() + "\n";
                tableResult.Cell(20, 1).Range.Text = MiloGostLabel.Content.ToString() + "\n";
                tableResult.Cell(21, 1).Range.Text = MechprimesyGostLabel.Content.ToString() + "\n";
                tableResult.Cell(22, 1).Range.Text = NaftalinyGostLabel.Content.ToString() + "\n";
                tableResult.Cell(23, 1).Range.Text = LCHGostLabel.Content.ToString() + "\n";
                tableResult.Cell(24, 1).Range.Text = DTSGostLabel.Content.ToString() + "\n\n" +
                    DTSFiltrGostLabel.Content.ToString() + "\n\n" + DTSBallGostLabel.Content.ToString() + "\n";
                tableResult.Cell(25, 1).Range.Text = VzaimodeistvSVodoyGostLabel.Content.ToString() + "\n\n" +
                    SostPoverhnRazdelaGostLabel.Content.ToString() + "\n\n" + SostRazdenFasGostLabel.Content.ToString() + "\n";
                tableResult.Cell(26, 1).Range.Text = ElectroprovodnostGostLabel.Content.ToString() + "\n";
                tableResult.Cell(27, 1).Range.Text = DavlNasishParovGostLabel.Content.ToString() + "\n";
                tableResult.Cell(28, 1).Range.Text = SummaVodorastvSchelochGostLabel.Content.ToString() + "\n";
                tableResult.Cell(29, 1).Range.Text = JFTOTGostLabel.Content.ToString() + "\n\n" +
                    JFTOTFiltrGostLabel.Content.ToString() + "\n\n" + JFTOTBallGostLabel.Content.ToString() + "\n";

                tableResult.Cell(1, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                tableResult.Cell(1, 2).Range.Font.Bold = 1;
                tableResult.Cell(1, 2).Range.Text = "Нормы ГОСТ";
                tableResult.Cell(2, 2).Range.Text = "не ниже";
                tableResult.Cell(3, 2).Range.Text = "\n\n\n не выше \n\n\n не выше \n\n\n не выше \n\n\nне выше \n\n\n не выше \n\n не более \n\n не более";
                tableResult.Cell(4, 2).Range.Text = "\n\n\n не ниже \n\n не выше \n\n не выше";
                tableResult.Cell(5, 2).Range.Text = "\n  не ниже ";
                tableResult.Cell(6, 2).Range.Text = "\n не ниже";
                tableResult.Cell(7, 2).Range.Text = "\n не более";
                tableResult.Cell(8, 2).Range.Text = "\n не более";
                tableResult.Cell(9, 2).Range.Text = "\n\n  не ниже";
                tableResult.Cell(10, 2).Range.Text = "\n  не выше";
                tableResult.Cell(11, 2).Range.Text = "\n\n\n\n\n не более \n\n\n  не более \n\n\n\n не более";
                tableResult.Cell(12, 2).Range.Text = "\n\n не более";
                tableResult.Cell(13, 2).Range.Text = "\n не более";
                tableResult.Cell(14, 2).Range.Text = "\n  не более";
                tableResult.Cell(15, 2).Range.Text = "\n  не более";
                tableResult.Cell(16, 2).Range.Text = "\n отсутствие";
                tableResult.Cell(17, 2).Range.Text = "\n\n выдерживает";
                tableResult.Cell(18, 2).Range.Text = " отсутствие";
                tableResult.Cell(19, 2).Range.Text = "\n\n отсутствие";
                tableResult.Cell(20, 2).Range.Text = "\n отсутствие";
                tableResult.Cell(21, 2).Range.Text = "\n отсутствие";
                tableResult.Cell(22, 2).Range.Text = "\n\n не более";
                tableResult.Cell(23, 2).Range.Text = "\n не более";
                tableResult.Cell(24, 2).Range.Text = "\n\n\n\n\n\n  не более \n\n\n не более";
                tableResult.Cell(25, 2).Range.Text = "\n\n\n\n не более \n\n не более ";
                tableResult.Cell(26, 2).Range.Text = "\n не более ";
                tableResult.Cell(27, 2).Range.Text = "\n не более ";
                tableResult.Cell(28, 2).Range.Text = "\n\n отсутствие";
                tableResult.Cell(29, 2).Range.Text = "\n\n\n\n\n\n не более \n\n\n  не более";

                tableResult.Cell(1, 3).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                tableResult.Cell(1, 3).Range.Font.Bold = 1;
                tableResult.Cell(1, 3).Range.Text = "Результат";
                tableResult.Cell(2, 3).Range.Text = PlotnostProtGostTxt.Text;
                tableResult.Cell(3, 3).Range.Text = "\n\n\n" + FSNachKipeniaTxt.Text + "\n\n\n" + FSTemper10Txt.Text +
                    "\n\n\n" + FSTemper50Txt.Text + "\n\n\n" + FSTemper90Txt.Text + "\n\n\n" + FSTemper98Txt.Text + "\n\n" +
                    FSOstatokTxt.Text + "\n\n" + FSPoteryTxt.Text;
                tableResult.Cell(4, 3).Range.Text = "\n\n\n" + Viascost20Txt.Text + "\n\n" + ViascostMinus20Txt.Text +
                    "\n\n" + ViascostMinus40Txt.Text;
                tableResult.Cell(5, 3).Range.Text = "\n" + NizTeplotSgorTxt.Text;
                tableResult.Cell(6, 3).Range.Text = "\n" + VNPGostTxt.Text;
                tableResult.Cell(7, 3).Range.Text = "\n" + KOHGostTxt.Text;
                tableResult.Cell(8, 3).Range.Text = "\n" + IODGostTxt.Text;
                tableResult.Cell(9, 3).Range.Text = "\n\n" + VspishkaGostTxt.Text;
                tableResult.Cell(10, 3).Range.Text = "\n" + KristallGostTxt.Text;
                tableResult.Cell(11, 3).Range.Text = "\n\n\n\n\n" + TSRTOsadokGostTxt.Text + "\n\n\n" +
                    TSRTHastvorSmolyGostTxt.Text + "\n\n\n\n" + TSRTNerastvorSmolyGostTxt.Text;
                tableResult.Cell(12, 3).Range.Text = "\n\n" + AromaticaGostTxt.Text;
                tableResult.Cell(13, 3).Range.Text = "\n" + FactSmolyGostTxt.Text;
                tableResult.Cell(14, 3).Range.Text = "\n" + SeraGostTxt.Text;
                tableResult.Cell(15, 3).Range.Text = "\n" + MerkaptanyGostTxt.Text;
                tableResult.Cell(16, 3).Range.Text = "\n" + SerovodorodGostTxt.Text;
                tableResult.Cell(17, 3).Range.Text = "\n\n" + PlastinkaGostTxt.Text;
                tableResult.Cell(18, 3).Range.Text = ZolnostGostTxt.Text;
                tableResult.Cell(19, 3).Range.Text = "\n\n" + SoderjanieKislotIChelochGostTxt.Text;
                tableResult.Cell(20, 3).Range.Text = "\n" + MiloGostTxt.Text;
                tableResult.Cell(21, 3).Range.Text = "\n" + MechprimesyGostTxt.Text;
                tableResult.Cell(22, 3).Range.Text = "\n\n" + NaftalinyGostTxt.Text;
                tableResult.Cell(23, 3).Range.Text = "\n" + LCHGostTxt.Text;
                tableResult.Cell(24, 3).Range.Text = "\n\n\n\n\n\n" + DTSFiltrGostTxt.Text + "\n\n\n" +
                    DTSBallGostTxt.Text;
                tableResult.Cell(25, 3).Range.Text = "\n\n\n\n" + SostPoverhnRazdelaTxt.Text + "\n\n" +
                    SostRazdenFasTxt.Text;
                tableResult.Cell(26, 3).Range.Text = "\n" + ElectroprovodnostGostTxt.Text;
                tableResult.Cell(27, 3).Range.Text = "\n" + DavlNasishParovGostGostTxt.Text;
                tableResult.Cell(28, 3).Range.Text = "\n\n" + SummaVodorastvSchelochGostTxt.Text;
                tableResult.Cell(29, 3).Range.Text = "\n\n\n\n\n\n" + JFTOTFiltrGostTxt.Text +
                    "\n\n\n" + JFTOTBallGostTxt.Text;

                tableResult.Range.InsertParagraphAfter();
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
                FioTable.Cell(1, 1).Range.Text = DoljnostProtGostTxt.Text;
                FioTable.Cell(1, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                FioTable.Cell(1, 2).Range.Text = FioProtGostTxt.Text;
                FioTable.Cell(2, 2).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                FioTable.Cell(2, 2).Range.Text = DateProtGostText.Text;

            }
            catch
            {
                System.Windows.MessageBox.Show("Убедитесь, что у вас установлен пакет Microsoft Office \n" +
                                  "в частности приложение WORD.", "Не удалось создать протокол!\n",
                                  MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }
    }
}
